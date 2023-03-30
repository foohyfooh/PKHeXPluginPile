using PKHeX.Core;

namespace PluginPile.InsertionPlugin {
  internal static class Language {

    internal static string BoxNumber {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "箱子编号",
          "en" or _ => "Box Number"
        };
      }
    }

    internal static string BoxNumberRangeError {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "盒子编号应介于 1 和 {0} 之间",
          "en" or _ => "Box Number should be between 1 and {0}."
        };
      }
    }

    internal static string BoxSlotEmptyError {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "盒子 {0} 槽位 {1} 已为空",
          "en" or _ => "Box {0} Slot {1} is already empty"
        };
      }
    }

    internal static string FormTitle => MenuItemName;

    internal static string InputError {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "输入错误",
          "en" or _ => "Input Error"
        };
      }
    }

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "插入插件",
          "en" or _ => "Insert Slot"
        };
      }
    }

    internal static string NoEmptySlotsError {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "盒子 {0} 槽位 {1} 之后没有空槽位",
          "en" or _ => "There are no empty slots after Box {0} Slot {1}"
        };
      }
    }

    internal static string SlotNumber {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "槽位编号",
          "en" or _ => "Slot Number"
        };
      }
    }

    internal static string SlotNumberRangeError {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "槽位编号应介于1和 {0} 之间",
          "en" or _ => "Slot Number should be between 1 and {0}"
        };
      }
    }

  }
}
