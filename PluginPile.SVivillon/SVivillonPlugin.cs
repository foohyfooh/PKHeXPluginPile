using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.SVivillon; 
public class SVivillonPlugin : PluginBase {

  public override string Name => nameof(SVivillonPlugin);
  protected override Assembly PluginAssembly => typeof(SVivillonPlugin).Assembly;
  private readonly ToolStripMenuItem OpenFormButton;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV9SV;

  public SVivillonPlugin() {
    OpenFormButton = new ToolStripMenuItem(Language.MenuItemName) {
      Image = Properties.Images.F18_Fancy
    };
    OpenFormButton.Click += (s, e) => new VivillonForm((SAV9SV)SaveFileEditor.SAV).ShowDialogInParent();
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    OpenFormButton.Available = IsCompatibleSave;
    tools.DropDownItems.Add(OpenFormButton);
  }

  protected override void HandleSaveLoaded() => OpenFormButton.Available = IsCompatibleSave;

}
