using PKHeX.Core;

namespace PluginPile.RaidImportPlugin {
  internal static class Language {

    internal static string DialogName {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Raid Importierer",
          "zh" => "团体战导入工具",
          "it" => "Importatore di Raid",
          "es" => "Importador de Raid",
          "en" or _ => "Raid Importer"
        };
      }
    }

    internal static string FilesMissing {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Stelle sicher, dass alle Dateien in {0} sind.",
          "zh" => "确保所有必需的文件都在 {0} 中",
          "it" => "Assicurati che tutti i file necessari siano in {0}",
          "es" => "Asegúrate de que todos los archivos necesarios están en {0}",
          "en" or _ => "Ensure that all necessary files are in {0}"
        };
      }
    }

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Importiere Raid",
          "zh" => "导入团体战",
          "it" => "Importa Raid",
          "es" => "Importar Raid",
          "en" or _ => "Import Raid"
        };
      }
    }

    internal static string RaidImported {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Raid importiert",
          "zh" => "团体战已导入",
          "it" => "Raid Importato",
          "es" => "Raid Importada",
          "en" or _ => "Raid Imported"
        };
      }
    }

  }
}
