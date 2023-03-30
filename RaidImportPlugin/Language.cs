using PKHeX.Core;

namespace PluginPile.RaidImportPlugin {
  internal static class Language {

    internal static string DialogName {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Raid���빤��",
          "en" or _ => "Raid Importer"
        };
      }
    }

    internal static string FilesMissing {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "ȷ�����б�����ļ����� {0} ��",
          "en" or _ => "Ensure that all necessary files are in {0}"
        };
      }
    }

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "����Raid",
          "en" or _ => "Import Raid"
        };
      }
    }

    internal static string RaidImported {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Raid�ѵ���",
          "en" or _ => "Raid Imported"
        };
      }
    }

  }
}
