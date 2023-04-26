using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.InsertionPlugin {
  public class InsertionPlugin : PluginBase {
    public override string Name => nameof(InsertionPlugin);
    protected override Assembly PluginAssembly => typeof(InsertionPlugin).Assembly;

    protected override void LoadContextMenu(ContextMenuStrip contextMenu) {
      contextMenu.Opening += (s, e) => {
        SlotViewInfo<PictureBox> info = GetSenderInfo(ref s!);
        if (info.Slot.Origin == SlotOrigin.Box && info.ReadCurrent().Species != (int)Species.None) {
          ToolStripMenuItem insertSlotButton = new ToolStripMenuItem(Language.MenuItemName);
          insertSlotButton.Click += (s, e) => InsertSlot(SaveFileEditor.CurrentBox, info.Slot.Slot);
          contextMenu.Items.Add(insertSlotButton);
          contextMenu.Closing += (s, e) => contextMenu.Items.Remove(insertSlotButton);
        }
      };
    }

    private void InsertSlot(int boxNum, int slotNum) {
      int startIndex = boxNum * SaveFileEditor.SAV.BoxSlotCount + slotNum;
      int boxIndex = startIndex + 1;
      PKM currMon, nextMon;
      while (boxIndex < SaveFileEditor.SAV.SlotCount) {
        currMon = SaveFileEditor.SAV.GetBoxSlotAtIndex(boxIndex);
        if (currMon.Species == (int)Species.None) break;
        boxIndex++;
      }
      if (boxIndex == SaveFileEditor.SAV.SlotCount) {
        MessageBox.Show(string.Format(Language.NoEmptySlotsError, boxNum + 1, slotNum + 1), Language.FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      currMon = SaveFileEditor.SAV.GetBoxSlotAtIndex(startIndex);
      SaveFileEditor.SAV.SetBoxSlotAtIndex(SaveFileEditor.SAV.BlankPKM, startIndex);
      for (int index = startIndex + 1; index <= boxIndex; index++) {
        nextMon = SaveFileEditor.SAV.GetBoxSlotAtIndex(index);
        SaveFileEditor.SAV.SetBoxSlotAtIndex(currMon, index, PKMImportSetting.UseDefault, PKMImportSetting.Skip);
        currMon = nextMon;
      }
      SaveFileEditor.ReloadSlots();
    }

  }
}
