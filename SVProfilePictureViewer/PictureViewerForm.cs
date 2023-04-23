using PKHeX.Core;
using System.Buffers.Binary;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PluginPile.SVProfilePictureViewer
{
  public partial class PictureViewerForm : Form
  {

    private readonly SAV9SV sav;

    public PictureViewerForm(SAV9SV sav9sv)
    {
      InitializeComponent();
      HandleLanguageChange();
      sav = sav9sv;
      currentProfilePicture.Image = ExtractImage(Constants.CurrentProfilePictureImage, Constants.CurrentProfilePictureHeight, Constants.CurrentProfilePictureWidth);
      currentProfileIcon.Image = ExtractImage(Constants.CurrentProfileIconImage, Constants.CurrentProfileIconHeight, Constants.CurrentProfileIconWidth);
      initialProfilePicture.Image = ExtractImage(Constants.InitialProfilePictureImage, Constants.InitialProfilePictureHeight, Constants.InitialProfilePictureWidth);
      initialProfileIcon.Image = ExtractImage(Constants.InitialProfileIconImage, Constants.InitialProfileIconHeight, Constants.InitialProfileIconWidth);
    }

    private void HandleLanguageChange()
    {
      Text = Language.PluginName;
      saveButton.Text = Language.Save;
      currentProfilePicturePage.Text = Language.CurrentProfilePicture;
      currentProfileIconPage.Text = Language.CurrentProfileIcon;
      initialProfilePicturePage.Text = Language.InitialProfilePicture;
      initialProfileIconPage.Text = Language.InitialProfileIcon;
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      (Image? image, string name) = tabs.SelectedIndex switch
      {
        0 => (currentProfilePicture.Image, "current_profile.png"),
        1 => (currentProfileIcon.Image, "current_icon.png"),
        2 => (initialProfilePicture.Image, "initial_profile.png"),
        3 => (currentProfileIcon.Image, "initial_icon.png"),
        _ => (null, string.Empty)
      };
      if (image == null) return;

      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.FileName = name;
      saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        ImageFormat format = Path.GetExtension(saveFileDialog.FileName) switch
        {
          ".jpg" or ".jpeg" => ImageFormat.Jpeg,
          ".bmp" => ImageFormat.Bmp,
          ".png" or _ => ImageFormat.Png,
        };
        image.Save(saveFileDialog.FileName, format);
      }
    }

    /// <summary>
    /// Obtain Bitmap from BGR565 formated bytes in block
    /// </summary>
    private Bitmap ExtractImage(uint imageBlcok, uint heightBlock, uint widthBlock)
    {
      SCBlock image = sav.Blocks.GetBlock(imageBlcok);
      int height = (int)sav.Blocks.GetBlockValue<uint>(heightBlock);
      int width = (int)sav.Blocks.GetBlockValue<uint>(widthBlock);
      Bitmap bitmap = new Bitmap(width / 4, height / 4);
      for (int y = 0, byteIndex = 0; y < bitmap.Height; y++)
      {
        for (int x = 0; x < bitmap.Width; x++, byteIndex += 8)
        {
          byte[] colourBytes = image.Data[byteIndex..(byteIndex + 2)];
          int colour = BinaryPrimitives.ReadInt16LittleEndian(colourBytes);
          int b = (colour & 0x001F) << 3;
          int g = ((colour & 0x07E0) >> 5) << 2;
          int r = ((colour & 0xF800) >> 11) << 3;
          Color c = Color.FromArgb(255, r, g, b);
          bitmap.SetPixel(x, y, c);
        }
      }
      return bitmap;
    }

    private Bitmap? SelectImage(int id) 
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Title = "Select Image for photo/icon";
      openFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        using (Image image = Image.FromFile(openFileDialog.FileName))
        {
          if (id == 1) {
            return new Bitmap(image, 360, 208);
          }
          else {
            return new Bitmap(image, 56, 56);
          }
        }
      }
      else {
        return null;
      }
    }

    private void importButtonP_Click(object sender, EventArgs e) {
      Bitmap? bmp = SelectImage(1);
      if (bmp == null)
        return;
      sav.Blocks.SetBlockValue(Constants.CurrentProfilePictureWidth, (uint)1440);
      sav.Blocks.SetBlockValue(Constants.CurrentProfilePictureHeight, (uint)832);
      sav.Blocks.SetBlockValue(Constants.CurrentProfilePictureSize, (uint)599040);
      byte[] block = new byte[622080];
      for (int b=0; b<block.Length; b++) {
        block[b] = 0;
      }
      int cursor = 0;
      for (int i = 0; i < bmp.Height; i++) {
        for (int j = 0; j < bmp.Width; j++) {
          Color color = bmp.GetPixel(j, i);
          int r = color.R;
          int g = color.G;
          int b = color.B;
          int color_int = ((r >> 3) << 11) | ((g >> 2) << 5) | (b >> 3);
          byte[] colorBytes = BitConverter.GetBytes((ushort)color_int);
          block[cursor] = colorBytes[0];
          block[cursor + 1] = colorBytes[1];
          cursor += 8;
        }
      }
      sav.Accessor.GetBlock(Constants.CurrentProfilePictureImage).ChangeData(block);
      currentProfilePicture.Image = ExtractImage(Constants.CurrentProfilePictureImage, Constants.CurrentProfilePictureHeight, Constants.CurrentProfilePictureWidth);
    }

    private void importButtonI_Click(object sender, EventArgs e)
    {
      Bitmap? bmp = SelectImage(2);
      if (bmp == null)
        return;
      sav.Blocks.SetBlockValue(Constants.CurrentProfileIconWidth, (uint)224);
      sav.Blocks.SetBlockValue(Constants.CurrentProfileIconHeight, (uint)224);
      sav.Blocks.SetBlockValue(Constants.CurrentProfileIconSize, (uint)25088);
      byte[] block = new byte[61952];
      for (int b = 0; b < block.Length; b++) {
        block[b] = 0;
      }
      int cursor = 0;
      for (int i = 0; i < bmp.Height; i++) {
        for (int j = 0; j < bmp.Width; j++) {
          Color color = bmp.GetPixel(j, i);
          int r = color.R;
          int g = color.G;
          int b = color.B;
          int color_int = ((r >> 3) << 11) | ((g >> 2) << 5) | (b >> 3);
          byte[] colorBytes = BitConverter.GetBytes((ushort)color_int);
          block[cursor] = colorBytes[0];
          block[cursor + 1] = colorBytes[1];
          cursor += 8;
        }
      }
      sav.Accessor.GetBlock(Constants.CurrentProfileIconImage).ChangeData(block);
      currentProfileIcon.Image = ExtractImage(Constants.CurrentProfileIconImage, Constants.CurrentProfileIconHeight, Constants.CurrentProfileIconWidth);
    }
  }
}
