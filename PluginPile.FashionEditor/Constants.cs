using PluginPile.Common;

namespace PluginPile.FashionEditor; 
internal static class SwShConstants {
  public static readonly Block Fashion = 0xD224F9AC;
  public const int RegionSize = 0x80;
  // Offsets
  public const int GlassesOffset  = 0x300;                       // 0x300
  public const int HatsOffset     = GlassesOffset  + RegionSize; // 0x380
  public const int JacketsOffset  = HatsOffset     + RegionSize; // 0x400
  public const int TopsOffset     = JacketsOffset  + RegionSize; // 0x480
  public const int BagsOffset     = TopsOffset     + RegionSize; // 0x500
  public const int GlovesOffset   = BagsOffset     + RegionSize; // 0x580
  public const int BotttomsOffset = GlovesOffset   + RegionSize; // 0x600
  public const int SocksOffset    = BotttomsOffset + RegionSize; // 0x680
  public const int ShoesOffset    = SocksOffset    + RegionSize; // 0x700
  // Region Numbers
  public const int GlassesRegion  = GlassesOffset  / RegionSize; //  6
  public const int HatsRegion     = HatsOffset     / RegionSize; //  7
  public const int JacketsRegion  = JacketsOffset  / RegionSize; //  8
  public const int TopsRegion     = TopsOffset     / RegionSize; //  9
  public const int BagsRegion     = BagsOffset     / RegionSize; // 10
  public const int GlovesRegion   = GlovesOffset   / RegionSize; // 11
  public const int BotttomsRegion = BotttomsOffset / RegionSize; // 12
  public const int SocksRegion    = SocksOffset    / RegionSize; // 13
  public const int ShoesRegion    = ShoesOffset    / RegionSize; // 14
}

internal static class BDSPConstants {
  public const int FashionEveryday = 1246;
  public const int FashionPikachu  = 1247;
  public const int FashionPlatinum = 1248;
  public const int FashionOveralls = 1249;
  public const int FashionEevee    = 1250;
  public const int FashionGengar   = 1251;
  public const int FashionCyber    = 1252;
  public const int FashionSummer   = 1253;
  public const int FashionWinter   = 1254;
  public const int FashionSpring   = 1255;
  public const int FashionCasual   = 1256;
  public const int FashionLeather  = 1257;
}

internal static class LAConstants {
  public static readonly Block FashionHats     = 0x3ADB8A98;
  public static readonly Block FashionTops     = 0x82D57F17;
  public static readonly Block FashionBottoms  = 0x11B37EC9;
  public static readonly Block FashionUniforms = 0x45851092;
  public static readonly Block FashionShoes    = 0x636A5ABD;
  public static readonly Block FashionGlasses  = 0x58AB6233;
}

internal static class SVConstants {
  public static readonly Block FashionEyewear   = 0xCBA20ED5;
  public static readonly Block FashionGloves    = 0x581667B1;
  public static readonly Block FashionBag       = 0x5D6F8110;
  public static readonly Block FashionFootwear  = 0x0221A618;
  public static readonly Block FashionHeadwear  = 0x860CD8FB;
  public static readonly Block FashionLegwear   = 0xD186222E;
  public static readonly Block FashionUniform   = 0x78FF2CB2;
  public static readonly Block FashionPhoneCase = 0xED0AC675;
}
