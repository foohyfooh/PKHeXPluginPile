using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool; 
internal static class Language {

  public static string MenuName {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "BW Tool"
      };
    }
  }

}
