using PKHeX.Core;

namespace PluginPile.TeamViewer;
internal static class Language {

  public static string ViewBattleTeams {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "View Battle Teams"
      };
    }
  }

  public static string ViewRentalTeams {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh" => "查看租借队伍",
        "en" or _ => "View Rental Teams"
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

  public static string BattleTeams {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Battle Teams"
      };
    }
  }

  public static string RentalTeams {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Rental Teams"
      };
    }
  }

  public static string Team {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Team"
      };
    }
  }
}
