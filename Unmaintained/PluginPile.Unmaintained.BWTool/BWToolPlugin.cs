using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.Unmaintained.BWTool;

public class BWToolPlugin : PluginBase {

  public override string Name => nameof(BWTool);
  private readonly ToolStripMenuItem MenuItem;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV5;

  public BWToolPlugin() {
    MenuItem = new ToolStripMenuItem(Language.MenuName);
    MenuItem.Click += (s, e) => new MainForm((SAV5)SaveFileEditor.SAV).ShowDialogInParent();
  }

  protected override void HandleSaveLoaded() => MenuItem.Available = IsCompatibleSave;

  public override void NotifyDisplayLanguageChanged(string language) => MenuItem.Text = Language.MenuName;

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    tools.DropDownItems.Add(MenuItem);
  }

}
