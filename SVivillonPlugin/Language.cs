using PKHeX.Core;

namespace PluginPile.SVivillonPlugin {
  internal static class Language {

    internal static string Cancel => Common.Language.Cancel;

    internal static string FormTitle => MenuItemName;

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Vivillon Form Wechsler",
          "zh" => "彩粉蝶形态转换器",
          "it" => "Editor Forma di Vivillion",
          "en" or _ => "Vivillon Form Changer"
        };
      }
    }

    internal static string Save => Common.Language.Save;

    internal static string VivillonForms {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Vivillon Formen",
          "zh" => "彩粉蝶形态",
          "it" => "Forme di Vivillion",
          "en" or _ => "Vivillon Forms"
        };
      }
    }

    internal static string VivillonForm00Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Frost",
          "zh" => "冰雪花纹",
          "it" => "Nevi Perenni",
          "en" or _ => "Icy Snow"
        };
      }
    }

    internal static string VivillonForm01Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Schneefeld",
          "zh" => "雪国花纹",
          "it" => "Nordico",
          "en" or _ => "Polar"
        };
      }
    }

    internal static string VivillonForm02Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Flocken",
          "zh" => "雪原花纹",
          "it" => "Manto di Neve",
          "en" or _ => "Tundra"
        };
      }
    }

    internal static string VivillonForm03Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Kontinental",
          "zh" => "大陆花纹",
          "it" => "Continentale",
          "en" or _ => "Continental"
        };
      }
    }

    internal static string VivillonForm04Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Ziergarten",
          "zh" => "ͥ庭园花纹",
          "it" => "Prato",
          "en" or _ => "Garden"
        };
      }
    }

    internal static string VivillonForm05Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Prunk",
          "zh" => "高雅花纹",
          "it" => "Eleganza",
          "en" or _ => "Elegant"
        };
      }
    }

    internal static string VivillonForm06Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Blumenmeer",
          "zh" => "花园花纹",
          "it" => "Giardinfiore",
          "en" or _ => "Meadow"
        };
      }
    }

    internal static string VivillonForm07Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Innovation",
          "zh" => "摩登花纹",
          "it" => "Trendy",
          "en" or _ => "Modern"
        };
      }
    }

    internal static string VivillonForm08Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Aquamarin",
          "zh" => "大海花纹",
          "it" => "Marino",
          "en" or _ => "Marine"
        };
      }
    }

    internal static string VivillonForm09Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Archipel",
          "zh" => "群岛花纹",
          "it" => "Arcipelago",
          "en" or _ => "Archipelago"
        };
      }
    }

    internal static string VivillonForm10Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Dürre",
          "zh" => "荒野花纹",
          "it" => "Deserto",
          "en" or _ => "High Plains"
        };
      }
    }

    internal static string VivillonForm11Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Sand",
          "zh" => "沙尘花纹",
          "it" => "Sabbia",
          "en" or _ => "Sandstorm"
        };
      }
    }

    internal static string VivillonForm12Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Flussdelta",
          "zh" => "大河花纹",
          "it" => "Fluviale",
          "en" or _ => "River"
        };
      }
    }

    internal static string VivillonForm13Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Monsun",
          "zh" => "骤雨花纹",
          "it" => "Pluviale",
          "en" or _ => "Monsoon"
        };
      }
    }

    internal static string VivillonForm14Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Savanne",
          "zh" => "热带草原花纹",
          "it" => "Savana",
          "en" or _ => "Savana"
        };
      }
    }

    internal static string VivillonForm15Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Sonne",
          "zh" => "̫太阳花纹",
          "it" => "Solare",
          "en" or _ => "Sun"
        };
      }
    }

    internal static string VivillonForm16Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Ozean",
          "zh" => "大洋花纹",
          "it" => "Oceanico",
          "en" or _ => "Ocean"
        };
      }
    }

    internal static string VivillonForm17Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Dschungel",
          "zh" => "热带雨林花纹",
          "it" => "Giungla",
          "en" or _ => "Jungle"
        };
      }
    }

    internal static string VivillonForm18Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Fantasie",
          "zh" => "幻彩花纹",
          "it" => "Sbarazzino",
          "en" or _ => "Fancy"
        };
      }
    }


  }
}
