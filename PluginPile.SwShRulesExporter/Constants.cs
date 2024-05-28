using PluginPile.Common;

namespace PluginPile.SwShRulesExporter; 
internal static class Constants {
  // Combination of copying the documented rule blocks and undocumented blocks that have the length of 0x2304.
  // Some of which seem to contain rule data and others that are blank
  public static readonly Block[] KnownRuleBlocks = [0xEEF1B186, 0xEFF1B319, 0xF0F1B4AC, 0xF1F1B63F, 0xF2F1B7D2, 0xF3F1B965, 0xFAF1C46A, 0xFBF1C5FD];
  public static readonly Block[] PotentialRuleBlocks = [0x5586B8F0, 0x5686BA83, 0x5786BC16, 0x5886BDA9, 0x5986BF3C, 0x5A86C0CF, 0x5B86C262, 0x5C86C3F5, 0x6186CBD4, 0x6286CD67, 0xE07F44FC, 0xE17F468F, 0xE47F4B48, 0xE57F4CDB, 0xE67F4E6E, 0xE77F5001, 0xE87F5194, 0xE97F5327, 0xEA7F54BA, 0xEB7F564D, 0xECF1AE60, 0xEDF1AFF3];
  public static readonly Block[] AllRuleBlocks = [.. KnownRuleBlocks, .. PotentialRuleBlocks];

  public const int EnlgishNameLocation = 0x1280;
  public const int EnlgishNameSize = 0x4A; // This might include some of the separator space but that is fine for now
  public const int FormatLocation = 0x22E9; // 00 for singles 01 for doubles
}
