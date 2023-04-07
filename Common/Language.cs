using PKHeX.Core;

namespace PluginPile.Common {
  public static class Language {

    public static string Cancel {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Abbrechen",
          "zh" => "取消",
          "en" or _ => "Cancel"
        };
      }
    }

    public static string Save {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Speichern",
          "zh" => "保存",
          "en" or _ => "Save"
        };
      }
    }

  }
}
