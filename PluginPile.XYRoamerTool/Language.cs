using PKHeX.Core;

namespace PluginPile.XYRoamerTool; 
internal class Language {

  public static string MenuItemName {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Edit Roamer"
      };
    }
  }

  public static string[] Roamers => GameInfo.Strings.specieslist.Slice((int)Species.Articuno, 3);

  public static string[] RoamerState {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => new string[] { "Inactive", "Roaming", "Stationary", "Defeated", "Captured" }
      };
    }
  }

  public static string Cancel = Common.Language.Cancel;

  public static string Save = Common.Language.Save;

}
