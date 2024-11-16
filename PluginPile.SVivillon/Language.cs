using PKHeX.Core;

namespace PluginPile.SVivillon;
internal static class Language {

  public static string Cancel => Common.Language.Cancel;

  public static string FormTitle => MenuItemName;

  public static string MenuItemName => GameInfo.CurrentLanguage switch {
    "de"      => "Vivillon Form Wechsler",
    "zh-Hans" => "彩粉蝶形态转换器",
    "it"      => "Editor Forma di Vivillion",
    "en" or _ => "Vivillon Form Changer"
  };

  public static string Save => Common.Language.Save;

  public static string VivillonForms => GameInfo.CurrentLanguage switch {
    "de"      => "Vivillon Formen",
    "zh-Hans" => "彩粉蝶形态",
    "it"      => "Forme di Vivillion",
    "en" or _ => "Vivillon Forms"
  };

  public static string VivillonForm00Name => GameInfo.CurrentLanguage switch {
    "de"      => "Frost",
    "zh-Hans" => "冰雪花纹",
    "it"      => "Nevi Perenni",
    "en" or _ => "Icy Snow"
  };

  public static string VivillonForm01Name => GameInfo.CurrentLanguage switch {
    "de"      => "Schneefeld",
    "zh-Hans" => "雪国花纹",
    "it"      => "Nordico",
    "en" or _ => "Polar"
  };

  public static string VivillonForm02Name => GameInfo.CurrentLanguage switch {
    "de"      => "Flocken",
    "zh-Hans" => "雪原花纹",
    "it"      => "Manto di Neve",
    "en" or _ => "Tundra"
  };

  public static string VivillonForm03Name => GameInfo.CurrentLanguage switch {
    "de"      => "Kontinental",
    "zh-Hans" => "大陆花纹",
    "it"      => "Continentale",
    "en" or _ => "Continental"
  };

  public static string VivillonForm04Name => GameInfo.CurrentLanguage switch {
    "de"      => "Ziergarten",
    "zh-Hans" => "ͥ庭园花纹",
    "it"      => "Prato",
    "en" or _ => "Garden"
  };

  public static string VivillonForm05Name => GameInfo.CurrentLanguage switch {
    "de"      => "Prunk",
    "zh-Hans" => "高雅花纹",
    "it"      => "Eleganza",
    "en" or _ => "Elegant"
  };

  public static string VivillonForm06Name => GameInfo.CurrentLanguage switch {
    "de"      => "Blumenmeer",
    "zh-Hans" => "花园花纹",
    "it"      => "Giardinfiore",
    "en" or _ => "Meadow"
  };

  public static string VivillonForm07Name => GameInfo.CurrentLanguage switch {
    "de"      => "Innovation",
    "zh-Hans" => "摩登花纹",
    "it"      => "Trendy",
    "en" or _ => "Modern"
  };

  public static string VivillonForm08Name => GameInfo.CurrentLanguage switch {
    "de"      => "Aquamarin",
    "zh-Hans" => "大海花纹",
    "it"      => "Marino",
    "en" or _ => "Marine"
  };

  public static string VivillonForm09Name => GameInfo.CurrentLanguage switch {
    "de"      => "Archipel",
    "zh-Hans" => "群岛花纹",
    "it"      => "Arcipelago",
    "en" or _ => "Archipelago"
  };

  public static string VivillonForm10Name => GameInfo.CurrentLanguage switch {
    "de"      => "Dürre",
    "zh-Hans" => "荒野花纹",
    "it"      => "Deserto",
    "en" or _ => "High Plains"
  };

  public static string VivillonForm11Name => GameInfo.CurrentLanguage switch {
    "de"      => "Sand",
    "zh-Hans" => "沙尘花纹",
    "it"      => "Sabbia",
    "en" or _ => "Sandstorm"
  };

  public static string VivillonForm12Name => GameInfo.CurrentLanguage switch {
    "de"      => "Flussdelta",
    "zh-Hans" => "大河花纹",
    "it"      => "Fluviale",
    "en" or _ => "River"
  };

  public static string VivillonForm13Name => GameInfo.CurrentLanguage switch {
    "de"      => "Monsun",
    "zh-Hans" => "骤雨花纹",
    "it"      => "Pluviale",
    "en" or _ => "Monsoon"
  };

  public static string VivillonForm14Name => GameInfo.CurrentLanguage switch {
    "de"      => "Savanne",
    "zh-Hans" => "热带草原花纹",
    "it"      => "Savana",
    "en" or _ => "Savana"
  };

  public static string VivillonForm15Name => GameInfo.CurrentLanguage switch {
    "de"      => "Sonne",
    "zh-Hans" => "̫太阳花纹",
    "it"      => "Solare",
    "en" or _ => "Sun"
  };

  public static string VivillonForm16Name => GameInfo.CurrentLanguage switch {
    "de"      => "Ozean",
    "zh-Hans" => "大洋花纹",
    "it"      => "Oceanico",
    "en" or _ => "Ocean"
  };

  public static string VivillonForm17Name => GameInfo.CurrentLanguage switch {
    "de"      => "Dschungel",
    "zh-Hans" => "热带雨林花纹",
    "it"      => "Giungla",
    "en" or _ => "Jungle"
  };

  public static string VivillonForm18Name => GameInfo.CurrentLanguage switch {
    "de"      => "Fantasie",
    "zh-Hans" => "幻彩花纹",
    "it"      => "Sbarazzino",
    "en" or _ => "Fancy"
  };

}
