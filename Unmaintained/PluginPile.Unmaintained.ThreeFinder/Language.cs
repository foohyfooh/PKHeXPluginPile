using PKHeX.Core;

namespace PluginPile.Unmaintained.ThreeFinder; 
internal class Language {

  public static string MenuItemName {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh" => "三只三节插件",
        "en" or _ => "Three Finder"
      };
    }
  }

}
