using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.FashionEditor; 
public class FashionEditorPlugin : PluginBase {
  public override string Name => nameof(FashionEditorPlugin);
  protected override Assembly PluginAssembly => typeof(FashionEditorPlugin).Assembly;
  private readonly ToolStripMenuItem FashionEditorButton;
  private bool IsCompatibleSave {
    get { return SaveFileEditor.SAV is SAV8SWSH or SAV8BS or SAV8LA; }
  }

  public FashionEditorPlugin() {
    FashionEditorButton = new ToolStripMenuItem(Language.Title) {
      Image = Properties.Images.Icon
    };
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    
    FashionEditorButton.Available = IsCompatibleSave;
    FashionEditorButton.Click += (s, e) => {
      if (SaveFileEditor.SAV is SAV8SWSH sav8swsh) {
        new FashionFormSwSh(sav8swsh).ShowDialogInParent();
      } else if (SaveFileEditor.SAV is SAV8BS sav8bs) {
        new FashionFormBDSP(sav8bs).ShowDialogInParent();
      } else if (SaveFileEditor.SAV is SAV8LA sav8la) {
        new FashionFormLA(sav8la).ShowDialogInParent();
      }
    };
    tools.DropDownItems.Add(FashionEditorButton);
  }

  protected override void HandleSaveLoaded() => FashionEditorButton.Available = IsCompatibleSave;
}
