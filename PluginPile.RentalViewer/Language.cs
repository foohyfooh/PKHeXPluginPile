using PKHeX.Core;

namespace PluginPile.RentalViewer;
internal static class Language {

  public static string MenuItemName {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "View Rentals"
      };
    }
  }

  public static string CopyToBox {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Copy To Box"
      };
    }
  }

  public static string CopyToParty {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Copy To Party"
      };
    }
  }

  public static string CopyPaste {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Copy Paste"
      };
    }
  }

}
