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

  public static string[] SwordsOfJusticeQuestStatus {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => new string[] { "Can't Start", "Can Start", "Camera Highlights Cobalion Footprints", "In Progress" }
      };
    }
  }

  public static string[] SwordsOfJusticeQuestProgress {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => new string[] { "0 Reported", "1 Reported", "2 Reported", "3 Reported/Keldeo Available", "Keldeo Captured", "Keldeo Reported" }
      };
    }
  }

  public static string[] SwordsOfJusticeProgress {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => new string[] { "Footprints Unreported", "Location Revealed/Appeared", "Captured", "Capture Reported" }
      };
    }
  }

  public static string[] KeldeoProgress {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => new string[] { "Have To Camp", "Appeared", "Captured" }
      };
    }
  }

}
