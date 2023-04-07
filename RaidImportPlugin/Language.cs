using PKHeX.Core;

namespace PluginPile.RaidImportPlugin {
  internal static class Language {

    internal static string DialogName {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Raid Importierer",
          "zh" => "Raid导入工具",
          "en" or _ => "Raid Importer"
        };
      }
    }

    internal static string FilesMissing {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Stelle sicher, dass alle Dateien in {0} sind.",
          "zh" => "确保所有必需的文件都在 {0} 中",
          "en" or _ => "Ensure that all necessary files are in {0}"
        };
      }
    }

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Importiere Raid",
          "zh" => "导入Raid",
          "en" or _ => "Import Raid"
        };
      }
    }

    internal static string RaidImported {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Raid importiert",
          "zh" => "Raid已导入",
          "en" or _ => "Raid Imported"
        };
      }
    }

  }
}
