using PKHeX.Core;
using System.Reflection;

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

    public static string Unused {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Unused"
        };
      }
    }

    private const string StringCachePrefix = "PluginPile";

    // Modified copy of PKHeX ResourceUtil GetStringList
    public static string[] GetStringList(Assembly assembly, string pluginName, string filename) {
      string fullyQualifiedName = $"{StringCachePrefix}_{pluginName}_{filename}";
      if (Util.IsStringListCached(fullyQualifiedName, out string[]? cachedText))
        return cachedText;
      string resourceName = assembly.GetManifestResourceNames()
        .Single(str => str.EndsWith(filename));
      Stream? stream = assembly.GetManifestResourceStream(resourceName);
      if (stream == null) return Array.Empty<string>();
      StreamReader reader = new StreamReader(stream);
      string text = reader.ReadToEnd().Trim(); // Handle Final Newline Getting Counted
      return Util.LoadStringList(fullyQualifiedName, text);
    }

  }
}
