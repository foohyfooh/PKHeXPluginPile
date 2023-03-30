using PKHeX.Core;

namespace PluginPile.SortingPlugin {
  internal static class Language {

    internal static string Gen1Kanto {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 1 关都",
          "en" or _ => "Gen 1 Kanto"
        };
      }
    }

    internal static string Gen2Johto {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 2 城都",
          "en" or _ => "Gen 2 Johto"
        };
      }
    }

    internal static string Gen3Hoenn {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 3 丰缘",
          "en" or _ => "Gen 3 Hoenn"
        };
      }
    }

    internal static string Gen3Kanto {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 3 关都",
          "en" or _ => "Gen 3 Kanto"
        };
      }
    }

    internal static string Gen4Johto {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 4 神奥",
          "en" or _ => "Gen 4 Johto"
        };
      }
    }

    internal static string Gen4SinnohDiamondPearl {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 4 神奥 钻石/珍珠",
          "en" or _ => "Gen 4 Sinnoh Diamond/Pearl"
        };
      }
    }

    internal static string Gen4SinnohPlatinum {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 4 神奥 白金",
          "en" or _ => "Gen 4 Sinnoh Platinum"
        };
      }
    }

    internal static string Gen5UnovaBlack2White2 {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 5 合众 黑2/白2",
          "en" or _ => "Gen 5 Unova Black 2/White 2"
        };
      }
    }

    internal static string Gen5UnovaBlackWhite {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 5 合众 黑/白",
          "en" or _ => "Gen 5 Unova Black/White"
        };
      }
    }

    internal static string Gen6Hoenn {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 6 丰缘",
          "en" or _ => "Gen 6 Hoenn"
        };
      }
    }

    internal static string Gen6Kalos {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 6 卡洛斯",
          "en" or _ => "Gen 6 Kalos"
        };
      }
    }

    internal static string Gen6KalosAreas {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 6 卡洛斯地区",
          "en" or _ => "Gen 6 Kalos Areas"
        };
      }
    }

    internal static string Gen6KalosAreasCentralKalos {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "卡洛斯中央地区",
          "en" or _ => "Central Kalos"
        };
      }
    }

    internal static string Gen6KalosAreasCostalKalos {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "卡洛斯海岸地区",
          "en" or _ => "Costal Kalos"
        };
      }
    }

    internal static string Gen6KalosAreasMountainKalos {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "卡洛斯山岳地区",
          "en" or _ => "Mountain Kalos"
        };
      }
    }

    internal static string Gen7AlolaIslandsAkala {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "阿卡拉岛",
          "en" or _ => "Akala"
        };
      }
    }

    internal static string Gen7AlolaIslandsMelemele {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "美乐美乐岛",
          "en" or _ => "Melemele"
        };
      }
    }

    internal static string Gen7AlolaIslandsPoni {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "波尼岛",
          "en" or _ => "Poni"
        };
      }
    }

    internal static string Gen7AlolaIslandsUlaula {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "乌拉乌拉岛",
          "en" or _ => "Ula'ula"
        };
      }
    }

    internal static string Gen7AlolaSunMoon {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 7 阿罗拉 日/月",
          "en" or _ => "Gen 7 Alola Sun/Moon"
        };
      }
    }

    internal static string Gen7AlolaSunMoonIslands {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 7 阿罗拉 日/月 岛屿",
          "en" or _ => "Gen 7 Alola Sun/Moon Islands"
        };
      }
    }

    internal static string Gen7AlolaUltraSunUltraMoon {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 7 阿罗拉 究极之日/究极之月",
          "en" or _ => "Gen 7 Alola Ultra Sun/Ultra Moon"
        };
      }
    }

    internal static string Gen7AlolaUltraSunUltraMoonIslands {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 7 阿罗拉 究极之日/究极之月 岛屿",
          "en" or _ => "Gen 7 Alola Ultra Sun/Ultra Moon Islands"
        };
      }
    }

    internal static string Gen7Kanto {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 7 关都",
          "en" or _ => "Gen 7 Kanto"
        };
      }
    }

    internal static string Gen8Galar {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 8 伽勒尔",
          "en" or _ => "Gen 8 Galar"
        };
      }
    }

    internal static string Gen8GalarAreas {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 8 伽勒尔地区",
          "en" or _ => "Gen 8 Galar Areas"
        };
      }
    }

    internal static string Gen8GalarAreasCrownTundra {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "王冠雪原",
          "en" or _ => "Crown Tundra"
        };
      }
    }

    internal static string Gen8GalarAreasGalar {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "伽勒尔",
          "en" or _ => "Galar"
        };
      }
    }

    internal static string Gen8GalarAreasIsleofArmor {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "铠之孤岛",
          "en" or _ => "Isle of Armor"
        };
      }
    }

    internal static string Gen8Hisui {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 8 洗翠",
          "en" or _ => "Gen 8 Hisui"
        };
      }
    }

    internal static string Gen8HisuiAreas {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 8 洗翠地区",
          "en" or _ => "Gen 8 Hisui Areas"
        };
      }
    }

    internal static string Gen8HisuiAreasAlabasterIcelands {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "纯白冻土",
          "en" or _ => "Alabaster Icelands"
        };
      }
    }

    internal static string Gen8HisuiAreasCobaltCoastlands {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "群青海岸",
          "en" or _ => "Cobalt Coastlands"
        };
      }
    }

    internal static string Gen8HisuiAreasCoronetHighlands {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "天冠山麓",
          "en" or _ => "Coronet Highlands"
        };
      }
    }

    internal static string Gen8HisuiAreasCrimsonMirelands {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "红莲湿地",
          "en" or _ => "Crimson Mirelands"
        };
      }
    }

    internal static string Gen8HisuiAreasObsidianFieldlands {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "黑曜原野",
          "en" or _ => "Obsidian Fieldlands"
        };
      }
    }

    internal static string Gen8Sinnoh {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 8 神奥",
          "en" or _ => "Gen 8 Sinnoh"
        };
      }
    }

    internal static string Gen9Paldea {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "Gen 9 帕底亚",
          "en" or _ => "Gen 9 Paldea"
        };
      }
    }

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "排序插件",
          "en" or _ => "Sort Boxes By"
        };
      }
    }

    internal static string NationalPokédex {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "全国图鉴",
          "en" or _ => "National Pokédex"
        };
      }
    }

    internal static string NationalPokédexRegionalForms {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "全国图鉴(地区形态出生世代)",
          "en" or _ => "National Pokédex (Regional Forms With Generation)"
        };
      }
    }

    internal static string RegionalPokédexTemplate {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "{0} 地区图鉴",
          "en" or _ => "{0} Regional Pokédex"
        };
      }
    }

    internal static string Settings {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "设置",
          "en" or _ => "Settings"
        };
      }
    }

  }
}
