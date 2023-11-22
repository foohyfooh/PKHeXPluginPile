using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.Unmaintained.BWTool;

public class BWToolPlugin : PluginBase {

  public override string Name => nameof(BWTool);
  protected override Assembly PluginAssembly => typeof(BWToolPlugin).Assembly;
  private readonly ToolStripMenuItem MenuItem;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV5;

  public BWToolPlugin() {
    MenuItem = new ToolStripMenuItem(Language.MenuName);
    MenuItem.Click += (s, e) => new MainForm((SAV5)SaveFileEditor.SAV).ShowDialogInParent();
  }

  protected override void HandleSaveLoaded() => MenuItem.Available = IsCompatibleSave;

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    tools.DropDownItems.Add(MenuItem);
  }
}
