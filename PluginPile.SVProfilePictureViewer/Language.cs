using PKHeX.Core;

namespace PluginPile.SVProfilePictureViewer;
internal static class Language {
  public static string CurrentProfilePicture {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "当前个人简介照片",
        "it"      => "Foto Profilo Attuale",
        "en" or _ => "Current Profile Picture"
      };
    }
  }

  public static string CurrentProfileIcon {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "当前训练家头像",
        "it"      => "Icona Profilo Corrente",
        "en" or _ => "Current Profile Icon"
      };
    }
  }

  public static string InitialProfilePicture {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "初始个人简介照片",
        "it"      => "Foto Profilo Iniziale",
        "en" or _ => "Initial Profile Picture"
      };
    }
  }

  public static string InitialProfileIcon {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "初始训练家头像",
        "it"      => "Icona Profilo Iniziale",
        "en" or _ => "Initial Profile Icon"
      };
    }
  }

  public static string PluginName {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "个人简介照片查看器",
        "it"      => "Visualizzatore Foto Profilo",
        "en" or _ => "Profile Picture Viewer"
      };
    }
  }

  public static string Export {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "导出",
        "it"      => "Esporta",
        "en" or _ => "Export"
      };
    }
  }
}
