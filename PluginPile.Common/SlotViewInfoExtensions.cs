using PKHeX.Core;

namespace PluginPile.Common; 
public static class SlotViewInfoExtensions {
  public static bool IsNonEmptyWriteableBoxSlot(this SlotViewInfo<PictureBox> info) {
    return info.Slot.Origin == SlotOrigin.Box && info.ReadCurrent().Species != (int)Species.None && info.CanWriteTo();
  }

  public static PKM GetViewPokemon(this SlotViewInfo<PictureBox> info, SaveFile sav) {
    switch (info.Slot.Origin) {
      case SlotOrigin.Party:
        return sav.GetPartySlotAtIndex(info.Slot.Slot);
      case SlotOrigin.Box:
        int slotIndex = info.View.ViewIndex * sav.BoxSlotCount + info.Slot.Slot;
        return sav.GetBoxSlotAtIndex(slotIndex);
      default:
        return sav.BlankPKM;
    }
  }
}
