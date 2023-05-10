using System.Buffers.Binary;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PluginPile.SVProfilePictureViewer {
  internal static class DXT1 {

    private static Color ColorShortToColor(ushort colour, int alpha = 255) {
      int b =  (colour & 0x001F)        << 3;
      int g = ((colour & 0x07E0) >>  5) << 2;
      int r = ((colour & 0xF800) >> 11) << 3;
      return Color.FromArgb(alpha, r, g, b);
    }

    private static Color Lerp(Color c1, Color c2, int numer, int denom) {
      return Color.FromArgb(
        (c1.A * numer + c2.A * (denom - numer)) / denom,
        (c1.R * numer + c2.R * (denom - numer)) / denom,
        (c1.G * numer + c2.G * (denom - numer)) / denom,
        (c1.B * numer + c2.B * (denom - numer)) / denom
      );
    }

    public static Bitmap Decompress(byte[] data, int width, int height) {
      Bitmap result = new Bitmap(width, height, PixelFormat.Format32bppArgb);
      Rectangle resultSizeRect = new Rectangle(0, 0, width, height);
      BitmapData resultData = result.LockBits(resultSizeRect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
      IntPtr resultPtr = resultData.Scan0;
      int numBytes = Math.Abs(resultData.Stride) * height;
      byte[] rgbaBytes = new byte[numBytes];

      for (int y = 0, numBlocksY = height / 4, numBlocksX = width / 4, blockOffset = 0; y < numBlocksY; y++) {
        for (int x = 0; x < numBlocksX; x++, blockOffset += 8) {
          ushort colour0 = BinaryPrimitives.ReadUInt16LittleEndian(data.AsSpan(blockOffset..(blockOffset + 2)));
          ushort colour1 = BinaryPrimitives.ReadUInt16LittleEndian(data.AsSpan((blockOffset + 2)..(blockOffset + 4)));
          uint indices = BinaryPrimitives.ReadUInt32LittleEndian(data.AsSpan((blockOffset + 4)..(blockOffset + 8)));

          Color[] colours = new Color[4];
          colours[0] = ColorShortToColor(colour0);
          colours[1] = ColorShortToColor(colour1);
          if (colour0 > colour1) {
            colours[2] = Lerp(colours[0], colours[1], 2, 3);
            colours[3] = Lerp(colours[0], colours[1], 1, 3);
          } else { // colour0 <= colour1
            colours[2] = Lerp(colours[0], colours[1], 1, 2);
            colours[3] = Color.FromArgb(0, 0, 0, 0);
          }

          // PixelIndex = (y * 4 + pixelY) * width + x * 4 + pixelX;
          // ByteIndex = PixelIndex * 4;
          // Attempt to optimize out some of the multiplications in the inner loop
          for (int pixelY = 0, pixelOffset = y * 4 * width + x * 4; pixelY < 4; pixelY++, pixelOffset += width) {
            for (int pixelX = 0, byteIndex = pixelOffset * 4; pixelX < 4; pixelX++, byteIndex += 4) {
              int colourIndex = (int)((indices >> (2 * (4 * pixelY + pixelX))) & 0x3);
              rgbaBytes[byteIndex    ] = colours[colourIndex].B;
              rgbaBytes[byteIndex + 1] = colours[colourIndex].G;
              rgbaBytes[byteIndex + 2] = colours[colourIndex].R;
              rgbaBytes[byteIndex + 3] = colours[colourIndex].A;
            }
          }
        }
      }
      Marshal.Copy(rgbaBytes, 0, resultPtr, numBytes);
      result.UnlockBits(resultData);

      return result;
    }

  }
}
