using PKHeX.Core;

namespace PluginPile.TMTool;
internal static class Language {

  public static string MenuItemName => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "TM 工具",
    "en" or _ => "TM Tool"
  };

  public static string AddProtect => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "添加保护",
    "en" or _ => "Add Protect"
  };

  public static string LearnTMs => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "学习 TM",
    "en" or _ => "Learn TMs"
  };

}
