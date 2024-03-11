using PKHeX.Core;

namespace PluginPile.Common; 
public static class SavExtensions {

  public static string GetBoxName(this SaveFile sav, int index) {
    return sav switch {
      IBoxDetailNameRead bdn => bdn.GetBoxName(index),
      _ => BoxDetailNameExtensions.GetDefaultBoxName(index)
    };
  }

}
