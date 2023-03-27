using PKHeX.Core;

namespace PluginPile.InsertionPlugin {
  internal static class Language {

    internal static string BoxNumber {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Box Number"
        };
      }
    }

    internal static string BoxNumberRangeError {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Box Number should be between 1 and {0}."
        };
      }
    }

    internal static string BoxSlotEmptyError {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Box {0} Slot {1} is already empty"
        };
      }
    }

    internal static string InputError {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Input Error"
        };
      }
    }

    internal static string MenuItemName {
      get {
        return PKHeX.Core.GameInfo.CurrentLanguage switch {
          "en" or _ => "Insertion Plugin"
        };
      }
    }

    internal static string NoEmptySlotsError {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "There are no empty slots after Box {0} Slot {1}"
        };
      }
    }

    internal static string SlotNumber {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Slot Number"
        };
      }
    }

    internal static string SlotNumberRangeError {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Slot Number should be between 1 and {0}"
        };
      }
    }

  }
}
