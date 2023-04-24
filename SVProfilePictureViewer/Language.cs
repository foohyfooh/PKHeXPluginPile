using PKHeX.Core;

namespace PluginPile.SVProfilePictureViewer {
  internal static class Language {
    internal static string CurrentProfilePicture {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "当前个人简介照片",
          "en" or _ => "Current Profile Picture"
        };
      }
    }

    internal static string CurrentProfileIcon {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "当前训练家头像",
          "en" or _ => "Current Profile Icon"
        };
      }
    }

    internal static string InitialProfilePicture {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "初始个人简介照片",
          "en" or _ => "Initial Profile Picture"
        };
      }
    }

    internal static string InitialProfileIcon {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "初始训练家头像",
          "en" or _ => "Initial Profile Icon"
        };
      }
    }

    internal static string PluginName {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "个人简介照片查看器",
          "en" or _ => "Profile Picture Viewer"
        };
      }
    }

    internal static string Export {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "导出",
          "en" or _ => "Export"
        };
      }
    }

    internal static string ImportTitle {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "选择一张图片作为您的个人简介照片或训练家头像",
          "en" or _ => "Select Image for picture/icon"
        };
      }
    }

    internal static string ImportPicture {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "导入照片",
          "en" or _ => "Import Picture"
        };
      }
    }

    internal static string ImportIcon {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "导入头像",
          "en" or _ => "Import Icon"
        };
      }
    }
  }
}
