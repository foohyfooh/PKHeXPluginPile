using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;
using Block = PluginPile.Common.Block;

namespace PluginPile.RaidImportPlugin {
  public class RaidImportPlugin : PluginBase {
    public override string Name => nameof(RaidImportPlugin);
    protected override Assembly PluginAssembly => typeof(RaidImportPlugin).Assembly;
    private ToolStripMenuItem ImportRaidOrOutbreakButton = null!;
    private bool IsCompatibleSave {
      get { return SaveFileEditor.SAV is SAV8SWSH or SAV9SV; }
    }

    protected override void LoadMenu(ToolStripDropDownItem tools) {
      ImportRaidOrOutbreakButton = new ToolStripMenuItem();
      tools.DropDownItems.Add(ImportRaidOrOutbreakButton);
      SetImportItems();
    }

    private void SetImportItems() {
      ImportRaidOrOutbreakButton.Available = IsCompatibleSave;
      ImportRaidOrOutbreakButton.Click -= ImportRaid;
      ImportRaidOrOutbreakButton.DropDownItems.Clear();
      if (SaveFileEditor.SAV is SAV8SWSH) {
        ImportRaidOrOutbreakButton.Text = Language.ImportRaid;
        ImportRaidOrOutbreakButton.Click += ImportRaid;
      } else if (SaveFileEditor.SAV is SAV9SV sav9SV) {
               if (sav9SV.SaveRevision == 0) {
          ImportRaidOrOutbreakButton.Text = Language.ImportRaid;
          ImportRaidOrOutbreakButton.Click += ImportRaid;
        } else if(sav9SV.SaveRevision == 1) {
          ImportRaidOrOutbreakButton.Text = Language.ImportRaidOrOutbreak;
          ToolStripMenuItem importRaidButton = new ToolStripMenuItem(Language.ImportRaid);
          importRaidButton.Click += ImportRaid;
          ImportRaidOrOutbreakButton.DropDownItems.Add(importRaidButton);
          ToolStripMenuItem importOutbreakButton = new ToolStripMenuItem(Language.ImportOutbreak);
          importOutbreakButton.Click += ImportOutbreak;
          ImportRaidOrOutbreakButton.DropDownItems.Add(importOutbreakButton);
        }
      }
    }

    private void ImportRaid(object? sender, EventArgs e) {
      FolderBrowserDialog dialog = new FolderBrowserDialog();
      DialogResult dialogResult = dialog.ShowDialog();
      if (dialogResult == DialogResult.OK) {
        string raidPath = dialog.SelectedPath;
        IReadOnlyList<Block>[] blocksLists = null!;
        if (SaveFileEditor.SAV is SAV8SWSH sav8SwSh) {
               if (sav8SwSh.SaveRevision == 0) blocksLists = new IReadOnlyList<Block>[]{ SwShConstants.BaseGameBlocks };
          else if (sav8SwSh.SaveRevision == 1) blocksLists = new IReadOnlyList<Block>[]{ SwShConstants.IsleOfArmorBlocks };
          else if (sav8SwSh.SaveRevision == 2) blocksLists = new IReadOnlyList<Block>[]{ SwShConstants.CrownTundraBlocks };
        } else if (SaveFileEditor.SAV is SAV9SV sav9SV) {
          raidPath += @"\Files";
               if (sav9SV.SaveRevision == 0) blocksLists = new IReadOnlyList<Block>[] { SVConstants.BaseGameRaidBlocks, SVConstants.BaseGameRaidBlocks_1_3_0 };
          else if (sav9SV.SaveRevision == 1) blocksLists = new IReadOnlyList<Block>[] { SVConstants.TealMaskRaidBlocks };
        }
        Import(raidPath, (dynamic)SaveFileEditor.SAV, blocksLists, Language.RaidImported);
      }
    }

    private void ImportOutbreak(object? sender, EventArgs e) {
      FolderBrowserDialog dialog = new FolderBrowserDialog();
      DialogResult dialogResult = dialog.ShowDialog();
      if (dialogResult == DialogResult.OK) {
        SAV9SV sav = (SAV9SV)SaveFileEditor.SAV;
        string outbtreakPath = $@"{dialog.SelectedPath}\Files";
        IReadOnlyList<Block>[] blocksLists = new IReadOnlyList<Block>[] { SVConstants.TealMaskOutbreakBlocks };
        bool didImport = Import(outbtreakPath, sav, blocksLists, Language.OutbreakImported);
        if (didImport) {
          sav.Blocks.GetBlock(SVConstants.OutbreakEnabled).ChangeBooleanType(SCTypeCode.Bool2);
        } 
      }
    }

    private static bool Import<S>(string path, S sav, IReadOnlyList<Block>[] blocksLists, string successMessage) where S: SaveFile, ISCBlockArray, ISaveFileRevision {
      string FilePath(string file) => $@"{path}\{file}";
      bool didImport = false;
      foreach (IReadOnlyList<Block> blocks in blocksLists) {
        if (blocks.FilesExist(FilePath)) {
          foreach ((uint blockLocation, string file) in blocks)
            sav.Accessor.GetBlock(blockLocation).ChangeData(File.ReadAllBytes(FilePath(file)));
          didImport = true;
          sav.State.Edited = true;
          MessageBox.Show(successMessage, Language.DialogName);
        }
        if(didImport) break;
      }
      if (!didImport) {
        MessageBox.Show(string.Format(Language.FilesMissing, path), Language.DialogName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      return didImport;
    }

    protected override void HandleSaveLoaded() => SetImportItems();

  }
}
