using PKHeX.Core;

namespace PluginPile.SwShRulesExporter; 
internal static class Language {

  public static string MenuName => GameInfo.CurrentLanguage switch {
    "en" or _ => "SwSh Download Rules Exporter"
  };

  public static string ExportCurrentSave => GameInfo.CurrentLanguage switch {
    "en" or _ => "Export From Current Save"
  };

  public static string ExportBakFolder => GameInfo.CurrentLanguage switch {
    "en" or _ => "Export From bak Folder"
  };

  public static string UploadURL => "https://projectpokemon.org/home/forums/topic/65248-help-me-add-sword-and-shield-download-rules-to-the-rules-repo/";

  public static string ThanksMessage => GameInfo.CurrentLanguage switch {
    "en" or _ => $"Export Successful.\nPlease distribute the swsh_rules.zip to foohyfooh on Project Pokémon at {UploadURL} .\n\nCopy URL to clipoard"
  };

}
