using PKHeX.Core;

namespace PluginPile.TMTool;
internal class Language {

  internal static string MenuItemName {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh" => "TM 工具",
        "en" or _ => "TM Tool"
      };
    }
  }

  internal static string AddProtect {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh" => "添加保护",
        "en" or _ => "Add Protect"
      };
    }
  }

  internal static string LearnTMs {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh" => "学习 TM",
        "en" or _ => "Learn TMs"
      };
    }
  }

}
