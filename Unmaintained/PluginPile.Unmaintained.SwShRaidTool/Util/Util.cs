namespace PluginPile.Unmaintained.SwShRaidTool;
public static class Util {
  public static bool IsHex(char c) => (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f');
  public static bool IsDigitOrControl(char c) => char.IsDigit(c) || char.IsControl(c);
  public static bool IsHexOrControl(char c) => IsHex(c) || char.IsControl(c);

  public static int NumberOfSetBits(int i) {
    i -= ((i >> 1) & 0x55555555);
    i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
    return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
  }
}
