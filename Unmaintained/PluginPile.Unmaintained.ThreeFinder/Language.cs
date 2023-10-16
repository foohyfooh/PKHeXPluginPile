using PKHeX.Core;

namespace PluginPile.Unmaintained.ThreeFinder; 
internal class Language {

  public static string MenuItemName {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Three Finder"
      };
    }
  }

}
