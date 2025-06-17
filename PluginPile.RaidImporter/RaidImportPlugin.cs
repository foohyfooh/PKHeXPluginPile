using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.RaidImporter;
public class RaidImportPlugin : PluginBase {
  public override string Name => nameof(RaidImportPlugin);
  private readonly ToolStripMenuItem ImportRaidOrOutbreakButton;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV8SWSH or SAV9SV;

  public RaidImportPlugin() {
    ImportRaidOrOutbreakButton = new ToolStripMenuItem();
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
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
      } else if(sav9SV.SaveRevision >= 1) {
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
      List<IReadOnlyList<Block>> blocksLists = [];
      if (SaveFileEditor.SAV is SAV8SWSH sav8SwSh) {
        blocksLists.Add(Constants.SwSh.BaseGameBlocks);
        if (sav8SwSh.SaveRevision >= 1) blocksLists.Insert(0, Constants.SwSh.IsleOfArmorBlocks);
        if (sav8SwSh.SaveRevision >= 2) blocksLists.Insert(0, Constants.SwSh.CrownTundraBlocks);
      } else if (SaveFileEditor.SAV is SAV9SV sav9SV) {
        raidPath += @"\Files";
        // No PKHeX way to determine if 1.0.0 vs 1.3.0 so both are just included by default
        blocksLists.AddRange([Constants.SV.BaseGameRaidBlocks_1_3_0, Constants.SV.BaseGameRaidBlocks]);
        if (sav9SV.SaveRevision >= 1) blocksLists.Insert(0, Constants.SV.TealMaskRaidBlocks);
        if (sav9SV.SaveRevision >= 2) blocksLists.Insert(0, Constants.SV.IndigoDiskRaidBlocks);
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
      List<IReadOnlyList<Block>> blocksLists = [Constants.SV.TealMaskOutbreakBlocks];
      if (sav.SaveRevision >= 2) blocksLists.Insert(0, Constants.SV.IndigoDiskOutbreakBlocks);
      bool didImport = Import(outbtreakPath, sav, blocksLists, Language.OutbreakImported);
      if (didImport) {
        sav.Blocks.GetBlock(Constants.SV.OutbreakEnabled).ChangeBooleanType(SCTypeCode.Bool2);
      }
    }
  }

  private static bool Import<S>(string path, S sav, List<IReadOnlyList<Block>> blocksLists, string successMessage) where S: SaveFile, ISCBlockArray, ISaveFileRevision {
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

  public override void NotifyDisplayLanguageChanged(string language) => SetImportItems();
}
