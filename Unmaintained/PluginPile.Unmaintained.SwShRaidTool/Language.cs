using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShRaidTool;
internal class Language {

  public static string DisplayRaids {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Display Raids"
      };
    }
  }

  public static string SeedFinder {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Raid Seed Finder"
      };
    }
  }

}
