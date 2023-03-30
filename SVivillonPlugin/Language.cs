using PKHeX.Core;

namespace PluginPile.SVivillonPlugin {
  internal static class Language {

    internal static string Cancel {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "取消",
          "en" or _ => "Cancel"
        };
      }
    }

    internal static string FormTitle => MenuItemName;

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "彩粉蝶形态转换器",
          "en" or _ => "Vivillon Form Changer"
        };
      }
    }

    internal static string Save {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "保存",
          "en" or _ => "Save"
        };
      }
    }

    internal static string VivillonForms {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "彩粉蝶形态",
          "en" or _ => "Vivillon Forms"
        };
      }
    }

    internal static string VivillonForm00Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "冰雪花纹",
          "en" or _ => "Icy Snow"
        };
      }
    }

    internal static string VivillonForm01Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "雪国花纹",
          "en" or _ => "Polar"
        };
      }
    }

    internal static string VivillonForm02Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "雪原花纹",
          "en" or _ => "Tundra"
        };
      }
    }

    internal static string VivillonForm03Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "大陆花纹",
          "en" or _ => "Continental"
        };
      }
    }

    internal static string VivillonForm04Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "ͥ庭园花纹",
          "en" or _ => "Garden"
        };
      }
    }

    internal static string VivillonForm05Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "高雅花纹",
          "en" or _ => "Elegant"
        };
      }
    }

    internal static string VivillonForm06Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "花园花纹",
          "en" or _ => "Meadow"
        };
      }
    }

    internal static string VivillonForm07Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "摩登花纹",
          "en" or _ => "Modern"
        };
      }
    }

    internal static string VivillonForm08Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "大海花纹",
          "en" or _ => "Marine"
        };
      }
    }

    internal static string VivillonForm09Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "群岛花纹",
          "en" or _ => "Archipelago"
        };
      }
    }

    internal static string VivillonForm10Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "荒野花纹",
          "en" or _ => "High Plains"
        };
      }
    }

    internal static string VivillonForm11Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "沙尘花纹",
          "en" or _ => "Sandstorm"
        };
      }
    }

    internal static string VivillonForm12Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "大河花纹",
          "en" or _ => "River"
        };
      }
    }

    internal static string VivillonForm13Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "骤雨花纹",
          "en" or _ => "Monsoon"
        };
      }
    }

    internal static string VivillonForm14Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "热带草原花纹",
          "en" or _ => "Savana"
        };
      }
    }

    internal static string VivillonForm15Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "̫太阳花纹",
          "en" or _ => "Sun"
        };
      }
    }

    internal static string VivillonForm16Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "大洋花纹",
          "en" or _ => "Ocean"
        };
      }
    }

    internal static string VivillonForm17Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "热带雨林花纹",
          "en" or _ => "Jungle"
        };
      }
    }

    internal static string VivillonForm18Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "幻彩花纹",
          "en" or _ => "Fancy"
        };
      }
    }


  }
}
