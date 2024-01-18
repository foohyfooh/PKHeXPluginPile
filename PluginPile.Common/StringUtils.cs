using System.Text;

namespace PluginPile.Common; 
public static class StringUtils {
  public static string GetUnicodeString(byte[] stringBytes) {
    string f = Encoding.Unicode.GetString(stringBytes);
    return f[..f.IndexOf('\0')];
  }
}
