using PKHeX.Core;

namespace PluginPile.RentalViewer;
internal static class Language {

  public static string MenuItemName {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh" => "查看租借队伍",
        "en" or _ => "View Rentals"
      };
    }
  }

  public static string CopyToBox {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh" => "复制到盒子",
        "en" or _ => "Copy To Box"
      };
    }
  }

  public static string CopyToParty {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh" => "复制到交易方",
        "en" or _ => "Copy To Party"
      };
    }
  }

  public static string CopyPaste {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh" => "复制粘贴",
        "en" or _ => "Copy Paste"
      };
    }
  }

}
