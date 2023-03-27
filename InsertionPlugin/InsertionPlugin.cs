using System.Reflection;

namespace PluginPile.InsertionPlugin {
  public class InsertionPlugin : Common.PluginBase {
    public override string Name => nameof(InsertionPlugin);
    protected override Assembly PluginAssembly => typeof(InsertionPlugin).Assembly;

    protected override void LoadMenu(ToolStripDropDownItem tools) {
      ToolStripMenuItem insertionPluginButton = new ToolStripMenuItem(Language.MenuItemName);
      insertionPluginButton.Click += (s, e) => new PositionForm(SaveFileEditor).ShowDialog();
      tools.DropDownItems.Add(insertionPluginButton);
    }

  }
}
