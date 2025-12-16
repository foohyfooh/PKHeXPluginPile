using PKHeX.Core;

namespace PluginPile.SwShRulesExporter;
internal static class Language {

  public static string MenuName => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "宝可梦剑盾下载规则导出器",
    "en" or _ => "SwSh Download Rules Exporter"
  };

  public static string ExportCurrentSave => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "从当前存档导出",
    "en" or _ => "Export From Current Save"
  };

  public static string ExportBakFolder => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "从bak文件夹导出",
    "en" or _ => "Export From bak Folder"
  };

  public static string UploadURL => "https://projectpokemon.org/home/forums/topic/65248-help-me-add-sword-and-shield-download-rules-to-the-rules-repo/";

  public static string ThanksMessageSuccess => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "导出成功。\n请将swsh_rules.zip文件分发到宝可梦项目（Project Pokémon）中的foohyfooh用户处，上传地址为{UploadURL}\n\n复制URL到剪贴板",
    "en" or _ => $"Export Successful.\nPlease distribute the swsh_rules.zip to foohyfooh on Project Pokémon at {UploadURL}\n\nCopy URL to clipoard"
  };

  public static string ThanksMessageNoRules => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "感谢您进行检查，但未找到规则。",
    "en" or _ => "Thanks for checking but no rules were found."
  };

}
