using PKHeX.Core;
using System.Buffers.Binary;
using System.Drawing.Imaging;

namespace PluginPile.SVProfilePictureViewer {
  public partial class PictureViewerForm : Form {

    private readonly SAV9SV sav;

    public PictureViewerForm(SAV9SV sav9sv) {
      InitializeComponent();
      HandleLanguageChange();
      sav = sav9sv;
      currentProfilePicture.Image = ExtractImage(Constants.CurrentProfilePictureImage, Constants.CurrentProfilePictureHeight, Constants.CurrentProfilePictureWidth);
      currentProfileIcon.Image = ExtractImage(Constants.CurrentProfileIconImage, Constants.CurrentProfileIconHeight, Constants.CurrentProfileIconWidth);
      initialProfilePicture.Image = ExtractImage(Constants.InitialProfilePictureImage, Constants.InitialProfilePictureHeight, Constants.InitialProfilePictureWidth);
      initialProfileIcon.Image = ExtractImage(Constants.InitialProfileIconImage, Constants.InitialProfileIconHeight, Constants.InitialProfileIconWidth);
    }

    private void HandleLanguageChange() {
      Text = Language.PluginName;
      saveButton.Text = Language.Save;
      currentProfilePicturePage.Text = Language.CurrentProfilePicture;
      currentProfileIconPage.Text = Language.CurrentProfileIcon;
      initialProfilePicturePage.Text = Language.InitialProfilePicture;
      initialProfileIconPage.Text = Language.InitialProfileIcon;
    }

    private void saveButton_Click(object sender, EventArgs e) {
      (Image? image, string name) = tabs.SelectedIndex switch {
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
      if (saveFileDialog.ShowDialog() == DialogResult.OK) {
        ImageFormat format = Path.GetExtension(saveFileDialog.FileName) switch {
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
    private Bitmap ExtractImage(uint imageBlcok, uint heightBlock, uint widthBlock) {
      SCBlock image = sav.Blocks.GetBlock(imageBlcok);
      int height = (int)sav.Blocks.GetBlockValue<uint>(heightBlock);
      int width = (int)sav.Blocks.GetBlockValue<uint>(widthBlock);
      Bitmap bitmap = new Bitmap(width / 4, height / 4);
      for (int y = 0, byteIndex = 0; y < bitmap.Height; y++) {
        for (int x = 0; x < bitmap.Width; x++, byteIndex += 8) {
          byte[] colourBytes = image.Data[byteIndex..(byteIndex + 2)];
          int colour = BinaryPrimitives.ReadInt16LittleEndian(colourBytes);
          int b =  (colour & 0x001F) <<  3;
          int g = ((colour & 0x07E0) >>  5) << 2;
          int r = ((colour & 0xF800) >> 11) << 3;
          Color c = Color.FromArgb(255, r, g, b);
          bitmap.SetPixel(x, y, c);
        }
      }
      return bitmap;
    }

  }
}
