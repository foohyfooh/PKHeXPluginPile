using PKHeX.Core;
using System.Reflection;

namespace PluginPile.RaidImportPlugin {
  public class RaidImportPlugin : Common.PluginBase {
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
        IReadOnlyList<Block> blocks = null!;
        if (SaveFileEditor.SAV is SAV8SWSH sav8SwSh) {
               if (sav8SwSh.SaveRevision == 0) blocks = SwShConstants.BaseGameBlocks;
          else if (sav8SwSh.SaveRevision == 1) blocks = SwShConstants.IsleOfArmorBlocks;
          else if (sav8SwSh.SaveRevision == 2) blocks = SwShConstants.CrownTundraBlocks;
        } else if (SaveFileEditor.SAV is SAV9SV) {
          raidPath += @"\Files";
          blocks = SVConstants.BaseGameBlocks;
        }
        ImportRaid(raidPath, (dynamic)SaveFileEditor.SAV, blocks);
      }
    }
    private static void ImportRaid<S>(string raidPath, S sav, IReadOnlyList<Block> blocks) where S: SaveFile, ISCBlockArray, ISaveFileRevision {
      string RaidFilePath(string file) => $@"{raidPath}\{file}";
      if (blocks.All(b => File.Exists(RaidFilePath(b.Path)))) {
        foreach ((uint blockLocation, string file) in blocks)
          sav.Accessor.GetBlock(blockLocation).ChangeData(File.ReadAllBytes(RaidFilePath(file)));
        sav.State.Edited = true;
        MessageBox.Show(Language.RaidImported, Language.DialogName);
      } else {
        MessageBox.Show(string.Format(Language.FilesMissing, raidPath), Language.DialogName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    protected override void HandleSaveLoaded() => ImportRaidButton.Available = IsCompatibleSave;

  }
}
