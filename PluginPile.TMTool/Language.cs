using PKHeX.Core;

namespace PluginPile.TMTool;
internal class Language {

  internal static string MenuItemName {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "TM Tool"
      };
    }
  }

  internal static string AddProtect {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Add Protect"
      };
    }
  }

  internal static string LearnTMs {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Learn TMs"
      };
    }
  }

}
