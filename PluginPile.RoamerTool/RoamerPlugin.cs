using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.RoamerTool;
public class RoamerPlugin : PluginBase {
  public override string Name => nameof(RoamerPlugin);
  public ToolStripMenuItem MenuItem;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV4DP or SAV4Pt or SAV4HGSS or SAV6XY;

  public RoamerPlugin() {
    MenuItem = new ToolStripMenuItem(Language.MenuItemName);
    MenuItem.Click += LoadRoamerForm;
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    tools.DropDownItems.Add(MenuItem);
  }

  private void LoadRoamerForm(object? sender, EventArgs e) {
    if (SaveFileEditor.SAV is SAV4 sav4) {
      if (sav4.HasActiveRoamer())
        new Gen4RoamerForm(sav4).ShowDialogInParent();
      else
        MessageBox.Show(Language.Gen4.NoActieRoamer);
    } else if (SaveFileEditor.SAV is SAV6XY sav6xy) {
      new XYRoamerForm(sav6xy).ShowDialogInParent();
    }
  }

  protected override void HandleSaveLoaded() => MenuItem.Available = IsCompatibleSave;

  public override void NotifyDisplayLanguageChanged(string language) => MenuItem.Text = Language.MenuItemName;
}
