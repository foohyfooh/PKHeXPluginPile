using PKHeX.Core;

namespace PluginPile.Unmaintained.AutoModQRPlugins;
public class QRPlugins : AutoModPlugin {

  public override string Name => "QR Plugins";
  public override int Priority => 1;

  protected override void AddPluginControl(ToolStripDropDownItem modMenu) {
    ToolStripMenuItem Export = new ToolStripMenuItem("Export QR Codes") {
      Image = Resources.exportqrcode
    };
    Export.Click += ExportQRs;
    modMenu.DropDownItems.Add(Export);

    ToolStripMenuItem Import = new ToolStripMenuItem("Import PGL QR Code") {
      Image = Resources.pglqrcode,
      ShortcutKeys = Keys.Alt | Keys.Q,
    };
    modMenu.DropDownItems.Add(Import);
    Import.Click += PGLShowdownSet;
  }

  private void ExportQRs(object? sender, EventArgs e) {
    SaveFile sav = SaveFileEditor.SAV;
    if (!sav.HasBox) {
      WinFormsUtil.Error("Save file does not have box data.");
      return;
    }
    PKM[] boxData = sav.GetBoxData(sav.CurrentBox);
    QRCodeDumper.DumpQRCodes(boxData);
  }

  private static void PGLShowdownSet(object? sender, EventArgs e) {
    if (!Clipboard.ContainsImage())
      return;

    Image? img = Clipboard.GetImage();
    if (img is null)
      return;

    RentalTeam? rentalTeam = QRParser.DecryptQRCode(img);
    if (rentalTeam is null)
      return;

    List<ShowdownSet> sets = rentalTeam.ConvertedTeam.ToList();
    ShowdownSetLoader.Import(sets);
  }

}
