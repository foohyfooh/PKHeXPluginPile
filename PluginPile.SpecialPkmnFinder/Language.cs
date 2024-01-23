using PKHeX.Core;

namespace PluginPile.SpecialPkmnFinder;
internal static class Language {

  public static string Finders {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Pokémon Finders"
      };
    }
  }

  public static string ThreeFinder {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh" => "三只三节插件",
        "en" or _ => "Three Finder"
      };
    }
  }

  public static string WurmpleEvolutionFinder {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Wurmple Evolution Finder"
      };
    }
  }

  public static string NoResults {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "No Results Found"
      };
    }
  }

}
