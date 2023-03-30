using PKHeX.Core;

namespace PluginPile.RaidImportPlugin {
  internal static class Language {

    internal static string DialogName {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Raid导入工具",
          "en" or _ => "Raid Importer"
        };
      }
    }

    internal static string FilesMissing {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "确保所有必需的文件都在 {0} 中",
          "en" or _ => "Ensure that all necessary files are in {0}"
        };
      }
    }

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "导入Raid",
          "en" or _ => "Import Raid"
        };
      }
    }

    internal static string RaidImported {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Raid已导入",
          "en" or _ => "Raid Imported"
        };
      }
    }

  }
}
