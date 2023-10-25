using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShEventEditor;
internal class Language {

  public static string MenuItemName {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Sword/Shield Event Editor"
      };
    }
  }

  public static string EditorBaseGameWorldEvent {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Edit Base Game World Events"
      };
    }
  }

  public static string EditIsleOfArmorWorldEvents {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Edit Isle of Armor World Events"
      };
    }
  }

  public static string CrownTundra {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Crown Tundra"
      };
    }
  }

  public static string CrownTundraEditWorldEvents {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Edit World Events"
      };
    }
  }

  public static string CrownTundraEditMaxLair {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Edit Max Lair"
      };
    }
  }

  public static string CrownTundraEditRegis {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Edit Regis"
      };
    }
  }

  public static string CrownTundraEditSwordsOfJustice {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Edit Swords of Justice"
      };
    }
  }

  public static string EditCurrydexAndPokecamp {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Edit Currydex/Pokecamp"
      };
    }
  }

  public static string ConvertWondercard {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "Convert Wondercard"
      };
    }
  }

}
