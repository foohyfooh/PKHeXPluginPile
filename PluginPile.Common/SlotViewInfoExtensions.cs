using PKHeX.Core;

namespace PluginPile.Common;
public static class SlotViewInfoExtensions {
  public static bool IsNonEmptyWriteableBoxSlot(this SlotViewInfo<PictureBox> info) {
    return info.Slot.Type == StorageSlotType.Box && info.ReadCurrent().Species != (int)Species.None && info.CanWriteTo();
  }

  public static PKM GetViewPokemon(this SlotViewInfo<PictureBox> info, SaveFile sav) {
    switch (info.Slot.Type) {
      case StorageSlotType.Party:
        return sav.GetPartySlotAtIndex(info.Slot.Slot);
      case StorageSlotType.Box:
        if (info.View.ViewIndex >= 0) {
          int slotIndex = info.View.ViewIndex * sav.BoxSlotCount + info.Slot.Slot;
          return sav.GetBoxSlotAtIndex(slotIndex);
        }
        return sav.BlankPKM;
      default:
        return sav.BlankPKM;
    }
  }
}
