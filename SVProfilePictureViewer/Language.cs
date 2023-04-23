using PKHeX.Core;

namespace PluginPile.SVProfilePictureViewer {
  internal static class Language {
    internal static string CurrentProfilePicture {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Current Profile Picture"
        };
      }
    }

    internal static string CurrentProfileIcon {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Current Profile Icon"
        };
      }
    }

    internal static string InitialProfilePicture {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Initial Profile Picture"
        };
      }
    }

    internal static string InitialProfileIcon {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Initial Profile Icon"
        };
      }
    }

    internal static string PluginName {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Profile Picture Viewer"
        };
      }
    }

    internal static string Export {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Export"
        };
      }
    }

    internal static string ImportTitle {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Select Image for picture/icon"
        };
      }
    }

    internal static string ImportPicture {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Import Picture"
        };
      }
    }

    internal static string ImportIcon {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Import Icon"
        };
      }
    }
  }
}
