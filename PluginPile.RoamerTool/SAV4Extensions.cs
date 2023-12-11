using PKHeX.Core;

namespace PluginPile.RoamerTool;
public static class SAV4Extensions {

  public static Roamer4[] GetRoamers(this SAV4 sav4) {
    return sav4 switch {
      SAV4DP sav4dp => [sav4dp.RoamerMesprit, sav4dp.RoamerCresselia],
      SAV4Pt sav4pt => [sav4pt.RoamerMesprit, sav4pt.RoamerCresselia, sav4pt.RoamerArticuno, sav4pt.RoamerZapdos, sav4pt.RoamerMoltres],
      SAV4HGSS sav4hgss => [sav4hgss.RoamerRaikou, sav4hgss.RoamerEntei, sav4hgss.RoamerLatias, sav4hgss.RoamerLatios],
      _ => []
    };
  }

  public static bool HasActiveRoamer(this SAV4 sav4) {
    return sav4.GetRoamers().Any(roamer => roamer.Active);
  }

}
