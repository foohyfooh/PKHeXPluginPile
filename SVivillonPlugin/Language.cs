using PKHeX.Core;

namespace PluginPile.SVivillonPlugin {
  internal static class Language {

    internal static string Cancel {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "ȡ��",
          "en" or _ => "Cancel"
        };
      }
    }

    internal static string FormTitle => MenuItemName;

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "�ʷ۵���̬ת����",
          "en" or _ => "Vivillon Form Changer"
        };
      }
    }

    internal static string Save {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "����",
          "en" or _ => "Save"
        };
      }
    }

    internal static string VivillonForms {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "�ʷ۵���̬",
          "en" or _ => "Vivillon Forms"
        };
      }
    }

    internal static string VivillonForm00Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "��ѩ����",
          "en" or _ => "Icy Snow"
        };
      }
    }

    internal static string VivillonForm01Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "ѩ������",
          "en" or _ => "Polar"
        };
      }
    }

    internal static string VivillonForm02Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "ѩԭ����",
          "en" or _ => "Tundra"
        };
      }
    }

    internal static string VivillonForm03Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "��½����",
          "en" or _ => "Continental"
        };
      }
    }

    internal static string VivillonForm04Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "ͥ԰����",
          "en" or _ => "Garden"
        };
      }
    }

    internal static string VivillonForm05Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "���Ż���",
          "en" or _ => "Elegant"
        };
      }
    }

    internal static string VivillonForm06Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "��԰����",
          "en" or _ => "Meadow"
        };
      }
    }

    internal static string VivillonForm07Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Ħ�ǻ���",
          "en" or _ => "Modern"
        };
      }
    }

    internal static string VivillonForm08Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "�󺣻���",
          "en" or _ => "Marine"
        };
      }
    }

    internal static string VivillonForm09Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Ⱥ������",
          "en" or _ => "Archipelago"
        };
      }
    }

    internal static string VivillonForm10Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "��Ұ����",
          "en" or _ => "High Plains"
        };
      }
    }

    internal static string VivillonForm11Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "ɳ������",
          "en" or _ => "Sandstorm"
        };
      }
    }

    internal static string VivillonForm12Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "��ӻ���",
          "en" or _ => "River"
        };
      }
    }

    internal static string VivillonForm13Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "���껨��",
          "en" or _ => "Monsoon"
        };
      }
    }

    internal static string VivillonForm14Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "�ȴ���ԭ����",
          "en" or _ => "Savana"
        };
      }
    }

    internal static string VivillonForm15Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "̫������",
          "en" or _ => "Sun"
        };
      }
    }

    internal static string VivillonForm16Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "������",
          "en" or _ => "Ocean"
        };
      }
    }

    internal static string VivillonForm17Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "�ȴ����ֻ���",
          "en" or _ => "Jungle"
        };
      }
    }

    internal static string VivillonForm18Name {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "�òʻ���",
          "en" or _ => "Fancy"
        };
      }
    }


  }
}
