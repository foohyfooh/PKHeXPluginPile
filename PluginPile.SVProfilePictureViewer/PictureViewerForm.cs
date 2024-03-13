using PKHeX.Core;
using PluginPile.Common;
using System.Drawing.Imaging;

namespace PluginPile.SVProfilePictureViewer;
public partial class PictureViewerForm : Form {

  private readonly SAV9SV SAV;

  public PictureViewerForm(SAV9SV sav9sv) {
    InitializeComponent();
    HandleLanguageChange();
    SAV = sav9sv;
    ExtractImageTo(Constants.CurrentProfilePictureImage, Constants.CurrentProfilePictureWidth, Constants.CurrentProfilePictureHeight, CrrentProfilePicture);
    ExtractImageTo(Constants.CurrentProfileIconImage, Constants.CurrentProfileIconWidth, Constants.CurrentProfileIconHeight, CurrentProfileIcon);
    ExtractImageTo(Constants.InitialProfilePictureImage, Constants.InitialProfilePictureWidth, Constants.InitialProfilePictureHeight, InitialProfilePicture);
    ExtractImageTo(Constants.InitialProfileIconImage, Constants.InitialProfileIconWidth, Constants.InitialProfileIconHeight, InitialProfileIcon);
  }

  private void HandleLanguageChange() {
    Text = Language.PluginName;
    ExportButton.Text = Language.Export;
    CurrentProfilePicturePage.Text = Language.CurrentProfilePicture;
    CurrentProfileIconPage.Text = Language.CurrentProfileIcon;
    InitialProfilePicturePage.Text = Language.InitialProfilePicture;
    InitialProfileIconPage.Text = Language.InitialProfileIcon;
  }

  private void ExportButton_Click(object sender, EventArgs e) {
    (Image? image, string name) = Tabs.SelectedIndex switch {
      0 => (CrrentProfilePicture.Image, "current_profile.png"),
      1 => (CurrentProfileIcon.Image, "current_icon.png"),
      2 => (InitialProfilePicture.Image, "initial_profile.png"),
      3 => (InitialProfileIcon.Image, "initial_icon.png"),
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

  private void ExtractImageTo(uint imageBlock, uint widthBlock, uint heightBlock, PictureBox pictureBox) {
    SCBlock image = SAV.Blocks.GetBlock(imageBlock);
    int height = (int)SAV.Blocks.GetBlockValue<uint>(heightBlock);
    int width = (int)SAV.Blocks.GetBlockValue<uint>(widthBlock);
    byte[] rgbaBytes = DXT1.Decompress(image.Data, width, height);
    pictureBox.Image = DrawingUtil.GetBitmap(rgbaBytes, width, height);
    pictureBox.Size = pictureBox.Image.Size / 4;
  }

}
