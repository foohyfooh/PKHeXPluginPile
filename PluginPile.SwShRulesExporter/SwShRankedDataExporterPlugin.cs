using PKHeX.Core;
using PluginPile.Common;
using System.IO.Compression;

namespace PluginPile.SwShRulesExporter;
public class SwShRulesExporterPlugin : Common.PluginBase {
  public override string Name => nameof(SwShRulesExporterPlugin);
  private readonly ToolStripMenuItem ContainerMenuItem;
  private readonly ToolStripMenuItem CurrentSaveExport;
  private readonly ToolStripMenuItem BakFolderExport;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV8SWSH;

  public SwShRulesExporterPlugin() {
    ContainerMenuItem = new ToolStripMenuItem(Language.MenuName);

    CurrentSaveExport = new ToolStripMenuItem(Language.ExportCurrentSave);
    CurrentSaveExport.Click += (s, e) => {
      ExportRuleBlocks((SAV8SWSH)SaveFileEditor.SAV);
      EndProcess();
    };
    ContainerMenuItem.DropDownItems.Add(CurrentSaveExport);

    BakFolderExport = new ToolStripMenuItem(Language.ExportBakFolder);
    BakFolderExport.Click += (s, e) => {
      ExportBakRuleBlocks();
      EndProcess();
    };
    ContainerMenuItem.DropDownItems.Add(BakFolderExport);
  }

  private static void ExportRuleBlocks(SAV8SWSH sav) {
    string currentDir = Directory.GetCurrentDirectory();
    string rulesDir = Path.Combine(currentDir, "swsh_rules");
    string singlesDir = Path.Combine(rulesDir, "Singles");
    string doublesDir = Path.Combine(rulesDir, "Doubles");

    Directory.CreateDirectory(singlesDir);
    Directory.CreateDirectory(doublesDir);

    foreach (Block block in Constants.AllRuleBlocks) {
      SCBlock scBlock = sav.Accessor.GetBlockSafe(block);
      if (scBlock.Type is SCTypeCode.None) continue;
      byte[] data = scBlock.Data;
      if (!data.Any((byte b) => b != 0)) continue;
      byte[] nameBytes = data.Skip(Constants.EnlgishNameLocation).Take(Constants.EnlgishNameSize).ToArray();
      string rulesName = StringConverter8.GetString(nameBytes);

      // TODO: Verify no characters from Path.GetInvalidPathChars() is in the path
      string formatPath = data[Constants.FormatLocation] == 0x0 ? singlesDir : doublesDir;
      string currentRulePath = Path.Combine(formatPath, rulesName);
      if (!Path.Exists(currentRulePath)) File.WriteAllBytes(currentRulePath, data);
    }
  }

  private static void ExportBakRuleBlocks() {
    string currentDir = Directory.GetCurrentDirectory();
    string bakDir = Path.Combine(currentDir, "bak");
    string[] saves = Directory.GetFiles(bakDir);
    IEnumerable<string> filteredSaves = saves.Where(save => save.Contains("main"));
    foreach (string save in filteredSaves) {
      SaveFile? sav = SaveUtil.GetVariantSAV(save)!;
      if (sav is SAV8SWSH sav8swsh) {
        ExportRuleBlocks(sav8swsh);
      }
    }
  }

  private static void EndProcess() {
    string currentDir = Directory.GetCurrentDirectory();
    string rulesDir = Path.Combine(currentDir, "swsh_rules");
    string rulesZipPath = Path.Combine(currentDir, "swsh_rules.zip");
    if (Path.Exists(rulesZipPath)) File.Delete(rulesZipPath);
    ZipFile.CreateFromDirectory(rulesDir, rulesZipPath);
    DialogResult result = MessageBox.Show(Language.ThanksMessage, Language.MenuName, MessageBoxButtons.OKCancel);
    if (result == DialogResult.OK) {
      Clipboard.SetText(Language.UploadURL);
    }
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) => tools.DropDownItems.Add(ContainerMenuItem);

  public override void NotifySaveLoaded() => CurrentSaveExport.Enabled = IsCompatibleSave;

  public override void NotifyDisplayLanguageChanged(string language) {
    ContainerMenuItem.Text = Language.MenuName;
    CurrentSaveExport.Text = Language.ExportCurrentSave;
    BakFolderExport.Text = Language.ExportBakFolder;
  }
}
