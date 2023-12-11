using PKHeX.Core;

namespace PluginPile.RoamerTool;
internal static class Language {

  public static string MenuItemName {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Edit Roamer"
      };
    }
  }

  public static string Cancel = Common.Language.Cancel;

  public static string Save = Common.Language.Save;

  public static class Gen4 {
    public static string[] RoamerState {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => ["Roaming", "Caught", "Fainted"]
        };
      }
    }

    public static string NoActieRoamer {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "No Active Roamer"
        };
      }
    }

  }


  public static class XY {
    public static string[] Roamers => GameInfo.Strings.specieslist[(int)Species.Articuno..(int)Species.Dratini];

    public static string[] RoamerState {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => ["Inactive", "Roaming", "Stationary", "Defeated", "Captured"]
        };
      }
    }
  }

}
