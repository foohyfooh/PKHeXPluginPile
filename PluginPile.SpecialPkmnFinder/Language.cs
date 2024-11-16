using PKHeX.Core;

namespace PluginPile.SpecialPkmnFinder;
internal static class Language {

  public static string Finders => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "宝可梦搜寻器",
    "en" or _ => "Pokémon Finders"
  };

  public static string ThreeFinder => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "三只三节插件",
    "en" or _ => "Three Finder"
  };

  public static string WurmpleEvolutionFinder => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "刺尾虫进化搜寻器",
    "en" or _ => "Wurmple Evolution Finder"
  };

  public static string NoResults => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "未找到结果",
    "en" or _ => "No Results Found"
  };

}
