using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShRaidTool;
internal static class Language {

  public static string DisplayRaids {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "极巨巢穴修改器",
        "en" or _ => "Display Raids"
      };
    }
  }

  public static string SeedFinder {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "极巨巢穴Seed计算器",
        "en" or _ => "Raid Seed Finder"
      };
    }
  }

}
