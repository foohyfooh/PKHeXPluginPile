using PKHeX.Core;

namespace PluginPile.RaidImporter;
internal static class Language {

  public static string DialogName => GameInfo.CurrentLanguage switch {
    "de"      => "Raid Importierer",
    "zh"      => "团体战导入工具",
    "it"      => "Importatore di Raid",
    "es"      => "Importador de Raid",
    "en" or _ => "Raid Importer"
  };

  public static string FilesMissing => GameInfo.CurrentLanguage switch {
    "de"      => "Stelle sicher, dass alle Dateien in {0} sind.",
    "zh"      => "确保所有必需的文件都在 {0} 中",
    "it"      => "Assicurati che tutti i file necessari siano in {0}",
    "es"      => "Asegúrate de que todos los archivos necesarios están en {0}",
    "en" or _ => "Ensure that all necessary files are in {0}"
  };

  public static string ImportRaid => GameInfo.CurrentLanguage switch {
    "de"      => "Importiere Raid",
    "zh"      => "导入团体战",
    "it"      => "Importa Raid",
    "es"      => "Importar Raid",
    "en" or _ => "Import Raid"
  };

  public static string RaidImported => GameInfo.CurrentLanguage switch {
    "de"      => "Raid importiert",
    "zh"      => "团体战已导入",
    "it"      => "Raid Importato",
    "es"      => "Raid Importada",
    "en" or _ => "Raid Imported"
  };

  public static string ImportOutbreak => GameInfo.CurrentLanguage switch {
    "zh"      => "导入大量出现",
    "es"      => "Importar Aparición Masiva",
    "en" or _ => "Import Outbreak"
  };

  public static string OutbreakImported => GameInfo.CurrentLanguage switch {
    "zh"      => "大量出现已导入",
    "es"      => "Aparición Masiva importada",
    "en" or _ => "Outbreak Imported"
  };

  public static string ImportRaidOrOutbreak => GameInfo.CurrentLanguage switch {
    "zh"      => "导入 团体战/大量出现",
    "es"      => "Importar Raid/Aparición Masiva",
    "en" or _ => "Import Raid/Outbreak"
  };

}
