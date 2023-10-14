using PKHeX.Core;

namespace PluginPile.Common {
  public static class SlotViewInfoExtensions {
    public static bool IsNonEmptyWriteableBoxSlot(this SlotViewInfo<PictureBox> info) {
      return info.Slot.Origin == SlotOrigin.Box && info.ReadCurrent().Species != (int)Species.None && info.CanWriteTo();
    }
  }
}
