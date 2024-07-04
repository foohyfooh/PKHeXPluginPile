using PKHeX.Core;
using System.Reflection;

namespace PluginPile.Common;
public static class Language {

  public static string Cancel => GameInfo.CurrentLanguage switch {
    "de"      => "Abbrechen",
    "zh"      => "取消",
    "it"      => "Annulla",
    "en" or _ => "Cancel"
  };

  public static string Save => GameInfo.CurrentLanguage switch {
    "de"      => "Speichern",
    "zh"      => "保存",
    "it"      => "Salva",
    "en" or _ => "Save"
  };

  public static string Unused => GameInfo.CurrentLanguage switch {
    "zh"      => "未使用",
    "it"      => "Inutilizzato",
    "en" or _ => "Unused"
  };

  public static string New => GameInfo.CurrentLanguage switch {
    "en" or _ => "New"
  };

  private const string StringCachePrefix = "PluginPile";

  public static string[] GetStringList(Assembly assembly, string pluginName, string filename) {
    string fullyQualifiedName = $"{StringCachePrefix}_{pluginName}_{filename}";
    if (Util.CachedStrings.TryGetValue(fullyQualifiedName, out string[]? cachedText))
      return cachedText;
    string? resourceName = assembly.GetManifestResourceNames()
      .SingleOrDefault(str => str.EndsWith(filename));
    if (resourceName == null) return [];
    using Stream? stream = assembly.GetManifestResourceStream(resourceName);
    if (stream == null) return [];
    using StreamReader reader = new StreamReader(stream);
    string text = reader.ReadToEnd().Trim(); // Handle Final Newline Getting Counted
    string[] splitText = text.Split('\n');
    Util.CachedStrings.TryAdd(fullyQualifiedName, splitText);
    return splitText;
  }

}
