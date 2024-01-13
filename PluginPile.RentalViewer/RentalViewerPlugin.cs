using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.RentalViewer;

public class RentalViewerPlugin : PluginBase {

  public override string Name => nameof(RentalViewer);
  private readonly ToolStripMenuItem ViewRentalsButton;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV8SWSH or SAV9SV;

  public RentalViewerPlugin() {
    ViewRentalsButton = new ToolStripMenuItem(Language.MenuItemName);
    ViewRentalsButton.Click += (s, e) => new RentalTeamsForm(SaveFileEditor).Show();
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    tools.DropDownItems.Add(ViewRentalsButton);
  }

  protected override void HandleSaveLoaded() => ViewRentalsButton.Available = IsCompatibleSave;

  public override void NotifyDisplayLanguageChanged(string language) => ViewRentalsButton.Text = Language.MenuItemName;

}
