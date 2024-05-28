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
    "en" or _ => "Export From Bak Folder"
  };

  public static string ThanksMessage => GameInfo.CurrentLanguage switch {
    "en" or _ => "Export Successful.\nPlease distribute the swsh_rules.zip to foohyfooh on Project Pokémon"
  };

}
