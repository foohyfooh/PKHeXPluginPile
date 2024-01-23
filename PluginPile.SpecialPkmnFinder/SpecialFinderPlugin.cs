using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.SpecialPkmnFinder;
public class SpecialFinderPlugin : PluginBase {
  public override string Name => nameof(SpecialFinderPlugin);
  private readonly ToolStripMenuItem ContainerMenuItem;
  private readonly ToolStripMenuItem ThreeFinderMenuItem;
  private readonly ToolStripMenuItem WurmpleEvolutionFinderMenuItem;
  private bool IsCompatibleSave => SaveFileEditor.SAV.Generation >= 6;

  public SpecialFinderPlugin() {
    ThreeFinderMenuItem = new ToolStripMenuItem(Language.ThreeFinder) {
      Image = Properties.Resources.icon
    };
    ThreeFinderMenuItem.Click += (s, e) => FindThreesome();
    WurmpleEvolutionFinderMenuItem = new ToolStripMenuItem(Language.WurmpleEvolutionFinder);
    WurmpleEvolutionFinderMenuItem.Click += (s, e) => FindWurmples();
    ContainerMenuItem = new ToolStripMenuItem(Language.Finders);
    ContainerMenuItem.DropDownItems.Add(ThreeFinderMenuItem);
    ContainerMenuItem.DropDownItems.Add(WurmpleEvolutionFinderMenuItem);
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    tools.DropDownItems.Add(ContainerMenuItem);
  }

  private void FindThreesome() {
    SaveFile sav = SaveFileEditor.SAV;
    int slotCount = sav.BoxSlotCount;
    int dunsparceCount = 0;
    int dunsparce3Count = 0;
    int tandemausCount = 0;
    int tandemaus3Count = 0;
    string outputMessage = string.Empty;

    for (int i = 0; i < sav.PartyCount; i++) {
      PKM currentPartyMon = sav.GetPartySlotAtIndex(i);
      if (currentPartyMon.Species == (int)Species.Dunsparce) {
        dunsparceCount++;
        if (currentPartyMon.EncryptionConstant % 100 == 0) {
          dunsparce3Count++;
          outputMessage += $"Three-Segment Dunsparce found in party slot {i + 1}\n";
        }
      } else if (currentPartyMon.Species == (int)Species.Tandemaus) {
        tandemausCount++;
        if (currentPartyMon.EncryptionConstant % 100 == 0) {
          tandemaus3Count++;
          outputMessage += $"Family of Three Tandemaus found in party slot {i + 1}\n";
        }
      }
    }

    for (int i = 0; i < sav.BoxCount * sav.BoxSlotCount; i++) {
      PKM currentBoxMon = sav.GetBoxSlotAtIndex(i);
      if (currentBoxMon.Species == (int)Species.Dunsparce) {
        dunsparceCount++;
        if (currentBoxMon.EncryptionConstant % 100 == 0) {
          dunsparce3Count++;
          outputMessage += $"Three-Segment Dunsparce found in box #{(i / slotCount) + 1} ({sav.GetBoxName(i / slotCount)}) slot {(i % slotCount) + 1}\n";
        }
      } else if (currentBoxMon.Species == (int)Species.Tandemaus) {
        tandemausCount++;
        if (currentBoxMon.EncryptionConstant % 100 == 0) {
          tandemaus3Count++;
          outputMessage += $"Family of Three Tandemaus found in box #{(i / slotCount) + 1} ({sav.GetBoxName(i / slotCount)}) slot {(i % slotCount) + 1}\n";
        }
      }
    }

    if (outputMessage.Length > 0) outputMessage += "\n\n";
    outputMessage += $"Total Dunsparce found: {dunsparceCount}\n";
    outputMessage += $"Total Three-Segment Dunsparce found: {dunsparce3Count}\n\n";
    if (sav is SAV9SV) {
      outputMessage += $"Total Tandemaus found: {tandemausCount}\n";
      outputMessage += $"Total Family of Three Tandemaus found: {tandemaus3Count}\n";
    }

    string displayMessage = outputMessage + "\n\n                Copy results to clipboard?                ";
    DialogResult dialogResult = MessageBox.Show(displayMessage, Language.ThreeFinder, MessageBoxButtons.OKCancel);
    if (dialogResult == DialogResult.OK) {
      Clipboard.SetText(outputMessage);
    }
  }

  private void FindWurmples() {
    SaveFile sav = SaveFileEditor.SAV;
    int slotCount = sav.BoxSlotCount;
    int beautiflyCount = 0;
    int dustoxCount = 0;
    string outputMessage = string.Empty;

    for (int i = 0; i < sav.PartyCount; i++) {
      PKM currentPartyMon = sav.GetPartySlotAtIndex(i);
      if (currentPartyMon.Species == (int)Species.Wurmple) {
        WurmpleEvolution evo = WurmpleUtil.GetWurmpleEvoVal(currentPartyMon.EncryptionConstant);
        if (evo == WurmpleEvolution.Silcoon) {
          beautiflyCount++;
          outputMessage += $"Potential Beautifly found in party slot {i + 1}\n";
        } else if (evo == WurmpleEvolution.Cascoon) {
          dustoxCount++;
          outputMessage += $"Potential Dustox found in party slot {i + 1}\n";
        }
      }
    }

    for (int i = 0; i < sav.BoxCount * sav.BoxSlotCount; i++) {
      PKM currentBoxMon = sav.GetBoxSlotAtIndex(i);
      if (currentBoxMon.Species == (int)Species.Wurmple) {
        WurmpleEvolution evo = WurmpleUtil.GetWurmpleEvoVal(currentBoxMon.EncryptionConstant);
        if (evo == WurmpleEvolution.Silcoon) {
          beautiflyCount++;
          outputMessage += $"Potential Beautifly found in box #{(i / slotCount) + 1} ({sav.GetBoxName(i / slotCount)}) slot {(i % slotCount) + 1}\n";
        } else if (evo == WurmpleEvolution.Cascoon) {
          dustoxCount++;
          outputMessage += $"Potential Dustox found in box #{(i / slotCount) + 1} ({sav.GetBoxName(i / slotCount)}) slot {(i % slotCount) + 1}\n";
        }
      }
    }

    if (outputMessage.Length > 0) {
      string displayMessage = outputMessage + "\n\n                Copy results to clipboard?                ";
      DialogResult dialogResult = MessageBox.Show(displayMessage, Language.WurmpleEvolutionFinder, MessageBoxButtons.OKCancel);
      if (dialogResult == DialogResult.OK) {
        Clipboard.SetText(outputMessage);
      }
    } else {
      MessageBox.Show(Language.NoResults, Language.WurmpleEvolutionFinder);
    }      
  }

  public override void NotifyDisplayLanguageChanged(string language) {
    ContainerMenuItem.Text = Language.Finders;
    ThreeFinderMenuItem.Text = Language.ThreeFinder;
    WurmpleEvolutionFinderMenuItem.Text = Language.WurmpleEvolutionFinder;
  }

  protected override void HandleSaveLoaded() => ContainerMenuItem.Available = IsCompatibleSave;
}
