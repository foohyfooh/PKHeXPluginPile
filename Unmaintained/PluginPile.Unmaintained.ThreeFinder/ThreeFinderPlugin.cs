using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.Unmaintained.ThreeFinder;
public class ThreeFinderPlugin : PluginBase {
  public override string Name => nameof(ThreeFinderPlugin);
  private readonly ToolStripMenuItem MenuItem;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV8SWSH or SAV8BS or SAV9SV;

  public ThreeFinderPlugin() {
    MenuItem = new ToolStripMenuItem(Language.MenuItemName) {
      Image = Properties.Resources.icon
    };
    MenuItem.Click += (s, e) => FindThreesome();
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    MenuItem.Available = IsCompatibleSave;
    tools.DropDownItems.Add(MenuItem);
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
    DialogResult dialogResult = MessageBox.Show(displayMessage, Name, MessageBoxButtons.OKCancel);
    if (dialogResult == DialogResult.OK) {
      Clipboard.SetText(outputMessage);
    }
  }

  protected override void HandleSaveLoaded() => MenuItem.Available = IsCompatibleSave;
}
