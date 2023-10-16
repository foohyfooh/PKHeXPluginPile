using PKHeX.Core;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PluginPile.SVProfilePictureViewer; 
public partial class PictureViewerForm : Form {

  private readonly SAV9SV sav;

  public PictureViewerForm(SAV9SV sav9sv) {
    InitializeComponent();
    HandleLanguageChange();
    sav = sav9sv;
    ExtractImageTo(Constants.CurrentProfilePictureImage, Constants.CurrentProfilePictureHeight, Constants.CurrentProfilePictureWidth, currentProfilePicture);
    ExtractImageTo(Constants.CurrentProfileIconImage, Constants.CurrentProfileIconHeight, Constants.CurrentProfileIconWidth, currentProfileIcon);
    ExtractImageTo(Constants.InitialProfilePictureImage, Constants.InitialProfilePictureHeight, Constants.InitialProfilePictureWidth, initialProfilePicture);
    ExtractImageTo(Constants.InitialProfileIconImage, Constants.InitialProfileIconHeight, Constants.InitialProfileIconWidth, initialProfileIcon);
  }

  private void HandleLanguageChange() {
    Text = Language.PluginName;
    exportButton.Text = Language.Export;
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
      3 => (initialProfileIcon.Image, "initial_icon.png"),
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

  private void ExtractImageTo(uint imageBlock, uint heightBlock, uint widthBlock, PictureBox pictureBox) {
    SCBlock image = sav.Blocks.GetBlock(imageBlock);
    int height = (int)sav.Blocks.GetBlockValue<uint>(heightBlock);
    int width = (int)sav.Blocks.GetBlockValue<uint>(widthBlock);

    Bitmap result = new Bitmap(width, height, PixelFormat.Format32bppArgb);
    Rectangle resultSizeRect = new Rectangle(0, 0, width, height);
    BitmapData resultData = result.LockBits(resultSizeRect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
    IntPtr resultPtr = resultData.Scan0;
    byte[] rgbaBytes = DXT1.Decompress(image.Data, width, height);
    Marshal.Copy(rgbaBytes, 0, resultPtr, rgbaBytes.Length);
    result.UnlockBits(resultData);

    pictureBox.Image = result;
    pictureBox.Size = pictureBox.Image.Size / 4;
  }
}
