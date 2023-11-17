using PluginPile.Common;

namespace PluginPile.Unmaintained.AutoModQRPlugins;
public abstract class AutoModPlugin : PluginBase {

  private const string ParentMenuName = "Menu_AutoLegality";
  private const string ParentMenuText = "Auto-Legality Mod";

  public override abstract string Name { get; }
  public override abstract int Priority { get; }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    ToolStripItem[] menuSearch = tools.DropDownItems.Find(ParentMenuName, false);
    if (menuSearch.Length != 0) {
      ToolStripMenuItem modMenu = (ToolStripMenuItem)menuSearch[0];
      AddPluginControl(modMenu);
    }
  }

  protected abstract void AddPluginControl(ToolStripDropDownItem modMenu);
}
