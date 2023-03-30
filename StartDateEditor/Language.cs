using PKHeX.Core;

namespace PluginPile.StartDateEditor {
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
          "zh" => "开始日期编辑器",
          "en" or _ => "Start Date Editor"
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

    internal static string StartDate {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "开始日期",
          "en" or _ => "Start Date"
        };
      }
    }

  }
}
