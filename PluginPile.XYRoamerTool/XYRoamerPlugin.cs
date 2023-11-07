using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.XYRoamerTool;
public class XYRoamerPlugin : PluginBase {
  public override string Name => nameof(XYRoamerPlugin);
  protected override Assembly PluginAssembly => typeof(XYRoamerPlugin).Assembly;
  public ToolStripMenuItem MenuItem;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV6XY;

  public XYRoamerPlugin() {
    MenuItem = new ToolStripMenuItem(Language.MenuItemName);
    MenuItem.Click += (s, e) => new RoamerForm((SAV6XY)SaveFileEditor.SAV).ShowDialogInParent();
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    tools.DropDownItems.Add(MenuItem);
  }

  protected override void HandleSaveLoaded() => MenuItem.Available = IsCompatibleSave;
}
