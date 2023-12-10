namespace PluginPile.Unmaintained.BWTool; 
internal static class StringUtil {

  public static string TrimFromFFFF(string input) {
    int index = input.IndexOf((char)0xFFFF);
    return index < 0 ? input : input[..index];
  }

}
