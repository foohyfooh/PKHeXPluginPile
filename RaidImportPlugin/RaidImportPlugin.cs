using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;
using Block = PluginPile.Common.Block;

namespace PluginPile.RaidImportPlugin {
  public class RaidImportPlugin : PluginBase {
    public override string Name => nameof(RaidImportPlugin);
    protected override Assembly PluginAssembly => typeof(RaidImportPlugin).Assembly;
    private ToolStripMenuItem ImportRaidButton = null!;
    private bool IsCompatibleSave {
      get { return SaveFileEditor.SAV is SAV8SWSH or SAV9SV; }
    }

    protected override void LoadMenu(ToolStripDropDownItem tools) {
      ImportRaidButton = new ToolStripMenuItem(Language.MenuItemName);
      ImportRaidButton.Available = IsCompatibleSave;
      ImportRaidButton.Click += (s, e) => ImportRaid();
      tools.DropDownItems.Add(ImportRaidButton);
    }

    private void ImportRaid() {
      FolderBrowserDialog dialog = new FolderBrowserDialog();
      DialogResult dialogResult = dialog.ShowDialog();
      if (dialogResult == DialogResult.OK) {
        string raidPath = dialog.SelectedPath;
        IReadOnlyList<Block>[] blocksLists = null!;
        if (SaveFileEditor.SAV is SAV8SWSH sav8SwSh) {
               if (sav8SwSh.SaveRevision == 0) blocksLists = new IReadOnlyList<Block>[] { SwShConstants.BaseGameBlocks };
          else if (sav8SwSh.SaveRevision == 1) blocksLists = new IReadOnlyList<Block>[]{ SwShConstants.IsleOfArmorBlocks };
          else if (sav8SwSh.SaveRevision == 2) blocksLists = new IReadOnlyList<Block>[]{ SwShConstants.CrownTundraBlocks };
        } else if (SaveFileEditor.SAV is SAV9SV) {
          raidPath += @"\Files";
          blocksLists = new IReadOnlyList<Block>[] { SVConstants.BaseGameBlocks, SVConstants.BaseGameBlocks_1_3_0 };
        }
        ImportRaid(raidPath, (dynamic)SaveFileEditor.SAV, blocksLists);
      }
    }
    private static void ImportRaid<S>(string raidPath, S sav, IReadOnlyList<Block>[] blocksLists) where S: SaveFile, ISCBlockArray, ISaveFileRevision {
      string RaidFilePath(string file) => $@"{raidPath}\{file}";
      bool didImport = false;
      foreach (IReadOnlyList<Block> blocks in blocksLists) {
        if (blocks.All(b => File.Exists(RaidFilePath(b.Path)))) {
          foreach ((uint blockLocation, string file) in blocks)
            sav.Accessor.GetBlock(blockLocation).ChangeData(File.ReadAllBytes(RaidFilePath(file)));
          didImport = true;
          sav.State.Edited = true;
          MessageBox.Show(Language.RaidImported, Language.DialogName);
        }
        if(didImport) break;
      }
      if (!didImport) {
        MessageBox.Show(string.Format(Language.FilesMissing, raidPath), Language.DialogName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    protected override void HandleSaveLoaded() => ImportRaidButton.Available = IsCompatibleSave;

  }
}
