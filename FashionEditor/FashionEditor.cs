using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.FashionEditor {
  public class FashionEditor : Common.PluginBase {
    public override string Name => nameof(FashionEditor);
    protected override Assembly PluginAssembly => typeof(FashionEditor).Assembly;
    private ToolStripMenuItem FashionEditorButton = null!;
    private bool IsCompatibleSave {
      get { return SaveFileEditor.SAV is SAV8SWSH or SAV8BS or SAV8LA; }
    }

    protected override void LoadMenu(ToolStripDropDownItem tools) {
      FashionEditorButton = new ToolStripMenuItem(Language.Title) {
        Image = Properties.Images.Icon
      };
      FashionEditorButton.Available = IsCompatibleSave;
      FashionEditorButton.Click += (s, e) => {
        if (SaveFileEditor.SAV is SAV8SWSH sav8swsh) {
          new FashionFormSwSh(sav8swsh).ShowDialog();
        } else if (SaveFileEditor.SAV is SAV8BS sav8bs) {
          new FashionFormBDSP(sav8bs).ShowDialog();
        } else if (SaveFileEditor.SAV is SAV8LA sav8la) {
          new FashionFormLA(sav8la).ShowDialog();
        }
      };
      tools.DropDownItems.Add(FashionEditorButton);
    }

    protected override void HandleSaveLoaded() => FashionEditorButton.Available = IsCompatibleSave;
  }
}
