using PKHeX.Core;
using QRCoder;

namespace PluginPile.Unmaintained.AutoModQRPlugins;
public static class QRCodeDumper {
  public static void DumpQRCodes(IList<PKM> arr) {
    List<QRCodeResult> qrcodes = GetQRCodeImages(arr);

    string dir = Path.Combine(Directory.GetCurrentDirectory(), "qrcodes");
    Directory.CreateDirectory(dir);
    for (int i = 0; i < qrcodes.Count; i++) {
      QRCodeResult q = qrcodes[i];
      if (q.Image is null)
        continue;

      Console.WriteLine(i);
      string filename = $"{q.Source.FileNameWithoutExtension}.png";
      q.Image.Save(Path.Combine(dir, filename));
    }
  }

  private class QRCodeResult {
    public readonly PKM Source;
    public readonly Image? Image;

    public QRCodeResult(PKM pk) {
      Source = pk;
      if (pk is PK7 pk7)
        Image = GenerateQRCode7(pk7);

      if (Image != null)
        Image = Resize(Image);
    }

    private static Image Resize(Image qr) {
      Image newpic = new Bitmap(405, 455);
      using Graphics g = Graphics.FromImage(newpic);
      using SolidBrush solidBrush = new SolidBrush(Color.White);
      g.FillRectangle(solidBrush, 0, 0, newpic.Width, newpic.Height);
      g.DrawImage(qr, 0, 0);
      return newpic;
    }
  }

  private static List<QRCodeResult> GetQRCodeImages(IList<PKM> arr) {
    List<QRCodeResult> qrcodes = new List<QRCodeResult>();
    foreach (PKM pk in arr) {
      if (pk.Species == 0 || !pk.Valid)
        continue;

      QRCodeResult result = new QRCodeResult(pk);
      if (result.Image != null)
        qrcodes.Add(result);
    }
    return qrcodes;
  }

  // QR7 Utility
  public static Image GenerateQRCode7(PK7 pk7, int box = 0, int slot = 0, int num_copies = 1) {
    byte[] data = QR7.GenerateQRData(pk7, box, slot, num_copies);
    return GenerateQRCode(data, ppm: 4);
  }

  private static Image GenerateQRCode(byte[] data, int ppm = 4) {
    string msg = string.Concat(data.Select(c => (char)c));
    using QRCodeGenerator generator = new QRCodeGenerator();
    using QRCodeData qr_data = generator.CreateQrCode(msg, QRCodeGenerator.ECCLevel.Q);
    using QRCode qr_code = new QRCode(qr_data);
    return qr_code.GetGraphic(ppm);
  }
}
