using PKHeX.Core;

namespace PluginPile.InsertionPlugin {
  internal static class Language {

    internal static string FormTitle => MenuItemName;

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Slot eingeben",
          "zh" => "插入插件",
          "en" or _ => "Insert Slot"
        };
      }
    }

    internal static string NoEmptySlotsError {
      get {
        return GameInfo.CurrentLanguage switch {
          "de" => "Es gibt keine leeren Slots nach Box {0} Slot {1}",
          "zh" => "盒子 {0} 槽位 {1} 之后没有空槽位",
          "en" or _ => "There are no empty slots after Box {0} Slot {1}"
        };
      }
    }

  }
}
