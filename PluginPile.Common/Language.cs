using PKHeX.Core;
using System.Reflection;

namespace PluginPile.Common; 
public static class Language {

  public static string Cancel {
    get {
      return GameInfo.CurrentLanguage switch {
        "de"      => "Abbrechen",
        "zh"      => "取消",
        "it"      => "Annulla",
        "en" or _ => "Cancel"
      };
    }
  }

  public static string Save {
    get {
      return GameInfo.CurrentLanguage switch {
        "de"      => "Speichern",
        "zh"      => "保存",
        "it"      => "Salva",
        "en" or _ => "Save"
      };
    }
  }

  public static string Unused {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "未使用",
        "it"      => "Inutilizzato",
        "en" or _ => "Unused"
      };
    }
  }

  private const string StringCachePrefix = "PluginPile";

  // Modified Copy Of PKHeX ResourceUtil.GetStringList
  public static string[] GetStringList(Assembly assembly, string pluginName, string filename) {
    string fullyQualifiedName = $"{StringCachePrefix}_{pluginName}_{filename}";
    if (Util.IsStringListCached(fullyQualifiedName, out string[]? cachedText))
      return cachedText;
    string? resourceName = assembly.GetManifestResourceNames()
      .SingleOrDefault(str => str.EndsWith(filename));
    if (resourceName == null)
      return Array.Empty<string>();
    using Stream? stream = assembly.GetManifestResourceStream(resourceName);
    if (stream == null) return Array.Empty<string>();
    using StreamReader reader = new StreamReader(stream);
    string text = reader.ReadToEnd().Trim(); // Handle Final Newline Getting Counted
    return Util.LoadStringList(fullyQualifiedName, text);
  }

}
