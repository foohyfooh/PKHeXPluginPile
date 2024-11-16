using PKHeX.Core;

namespace PluginPile.TeamViewer;
internal static class Language {

  public static string ViewBattleTeams => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "查看对战队伍",
    "en" or _ => "View Battle Teams"
  };

  public static string ViewRentalTeams => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "查看租借队伍",
    "en" or _ => "View Rental Teams"
  };

  public static string CopyToBox => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "复制到盒子",
    "en" or _ => "Copy To Box"
  };

  public static string CopyToParty => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "复制到交易方",
    "en" or _ => "Copy To Party"
  };

  public static string CopyPaste => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "复制粘贴",
    "en" or _ => "Copy Paste"
  };

  public static string BattleTeams => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "对战队伍",
    "en" or _ => "Battle Teams"
  };

  public static string RentalTeams => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "租借队伍",
    "en" or _ => "Rental Teams"
  };

  public static string Team => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "队伍",
    "en" or _ => "Team"
  };

}
