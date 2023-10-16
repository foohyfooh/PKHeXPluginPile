using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.Unmaintained.ThreeFinder;
public class ThreeFinderPlugin : PluginBase {
  public override string Name => nameof(ThreeFinderPlugin);
  protected override Assembly PluginAssembly => typeof(ThreeFinderPlugin).Assembly;
  private readonly ToolStripMenuItem MenuItem;
  private bool IsCompatibleSave {
    get { return SaveFileEditor.SAV is SAV8SWSH or SAV8BS or SAV9SV; }
  }

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
    int dunsparce_count = 0;
    int dunsparce_3_count = 0;
    int tandemaus_count = 0;
    int tandemaus_3_count = 0;
    string output_message = string.Empty;

    for (int i = 0; i < sav.PartyCount; i++) {
      PKM current_party_mon = sav.GetPartySlotAtIndex(i);
      if (current_party_mon.Species == (int)Species.Dunsparce) {
        dunsparce_count++;
        if (current_party_mon.EncryptionConstant % 100 == 0) {
          dunsparce_3_count++;
          output_message += $"Three-Segment Dunsparce found in party slot {i + 1}\n";
        }
      } else if (current_party_mon.Species == (int)Species.Tandemaus) {
        tandemaus_count++;
        if (current_party_mon.EncryptionConstant % 100 == 0) {
          tandemaus_3_count++;
          output_message += $"Family of Three Tandemaus found in party slot {i + 1}\n";
        }
      }
    }


    for (int i = 0; i < sav.BoxCount * sav.BoxSlotCount; i++) {
      PKM current_box_mon = sav.GetBoxSlotAtIndex(i);
      if (current_box_mon.Species == (int)Species.Dunsparce) {
        dunsparce_count++;
        if (current_box_mon.EncryptionConstant % 100 == 0) {
          dunsparce_3_count++;
          output_message += $"Three-Segment Dunsparce found in box #{(i / slotCount) + 1} ({sav.GetBoxName(i / slotCount)}) slot {(i % slotCount) + 1}\n";
        }
      } else if (current_box_mon.Species == (int)Species.Tandemaus) {
        tandemaus_count++;
        if (current_box_mon.EncryptionConstant % 100 == 0) {
          tandemaus_3_count++;
          output_message += $"Family of Three Tandemaus found in box #{(i / slotCount) + 1} ({sav.GetBoxName(i / slotCount)}) slot {(i % slotCount) + 1}\n";
        }
      }
    }

    if (output_message.Length > 0) output_message += "\n\n";
    output_message += $"Total Dunsparce found: {dunsparce_count}\n";
    output_message += $"Total Three-Segment Dunsparce found: {dunsparce_3_count}\n\n";
    if (sav is SAV9SV) {
      output_message += $"Total Tandemaus found: {tandemaus_count}\n";
      output_message += $"Total Family of Three Tandemaus found: {tandemaus_3_count}\n";
    }

    string display_message = output_message + "\n\n                Copy results to clipboard?                ";
    DialogResult dialog_result = MessageBox.Show(display_message, Name, MessageBoxButtons.OKCancel);
    if (dialog_result == DialogResult.OK) {
      Clipboard.SetText(output_message);
    }
  }

  protected override void HandleSaveLoaded() => MenuItem.Available = IsCompatibleSave;
}
