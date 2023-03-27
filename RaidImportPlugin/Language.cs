using PKHeX.Core;

namespace PluginPile.RaidImportPlugin {
  internal class Language {

    internal static string DialogName {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Raid Importer"
        };
      }
    }

    internal static string FilesMissing {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Ensure that all necessary files are in {0}"
        };
      }
    }

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Import Raid"
        };
      }
    }

    internal static string RaidImported {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Raid Imported"
        };
      }
    }

  }
}
