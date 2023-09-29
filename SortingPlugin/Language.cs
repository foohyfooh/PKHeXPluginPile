using PKHeX.Core;

namespace PluginPile.SortingPlugin {
  internal static class Language {

    internal static string Gen1Kanto {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 1 Kanto",
          "zh"      => "Gen 1 关都",
          "it"      => "Gen 1 Kanto",
          "en" or _ => "Gen 1 Kanto"
        };
      }
    }

    internal static string Gen2Johto {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 2 Johto",
          "zh"      => "Gen 2 城都",
          "it"      => "Gen 2 Johto",
          "en" or _ => "Gen 2 Johto"
        };
      }
    }

    internal static string Gen3Hoenn {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 3 Hoenn",
          "zh"      => "Gen 3 丰缘",
          "it"      => "Gen 3 Hoenn",
          "en" or _ => "Gen 3 Hoenn"
        };
      }
    }

    internal static string Gen3Kanto {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 3 Kanto",
          "zh"      => "Gen 3 关都",
          "it"      => "Gen 3 Kanto",
          "en" or _ => "Gen 3 Kanto"
        };
      }
    }

    internal static string Gen4Johto {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 4 Johto",
          "zh"      => "Gen 4 神奥",
          "it"      => "Gen 4 Johto",
          "en" or _ => "Gen 4 Johto"
        };
      }
    }

    internal static string Gen4SinnohDiamondPearl {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 4 Sinnoh Diamant/Perl",
          "zh"      => "Gen 4 神奥 钻石/珍珠",
          "it"      => "Gen 4 Sinnoh Diamante/Perla",
          "en" or _ => "Gen 4 Sinnoh Diamond/Pearl"
        };
      }
    }

    internal static string Gen4SinnohPlatinum {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 4 Sinnoh Platin",
          "zh"      => "Gen 4 神奥 白金",
          "it"      => "Gen 4 Sinnoh Platino",
          "en" or _ => "Gen 4 Sinnoh Platinum"
        };
      }
    }

    internal static string Gen5UnovaBlack2White2 {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 5 Einall Schwarz 2/Weiß 2",
          "zh"      => "Gen 5 合众 黑2/白2",
          "it"      => "Gen 5 Unima Nero 2/Bianco 2",
          "en" or _ => "Gen 5 Unova Black 2/White 2"
        };
      }
    }

    internal static string Gen5UnovaBlackWhite {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 5 Einall Schwarz/Weiß",
          "zh"      => "Gen 5 合众 黑/白",
          "it"      => "Gen 5 Unima Nero/Bianco",
          "en" or _ => "Gen 5 Unova Black/White"
        };
      }
    }

    internal static string Gen6Hoenn {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 6 Hoenn",
          "zh"      => "Gen 6 丰缘",
          "it"      => "Gen 6 Hoenn",
          "en" or _ => "Gen 6 Hoenn"
        };
      }
    }

    internal static string Gen6Kalos {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 6 Kalos",
          "zh"      => "Gen 6 卡洛斯",
          "it"      => "Gen 6 Kalos",
          "en" or _ => "Gen 6 Kalos"
        };
      }
    }

    internal static string Gen6KalosAreas {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 6 Kalos Gebiete",
          "zh"      => "Gen 6 卡洛斯地区",
          "it"      => "Gen 6 Aree di Kalos",
          "en" or _ => "Gen 6 Kalos Areas"
        };
      }
    }

    internal static string Gen6KalosAreasCentralKalos {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Zentral-Kalos",
          "zh"      => "卡洛斯中央地区",
          "it"      => "Kalos Centrale",
          "en" or _ => "Central Kalos"
        };
      }
    }

    internal static string Gen6KalosAreasCostalKalos {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Kalos-Küste",
          "zh"      => "卡洛斯海岸地区",
          "it"      => "Kalos Costiera",
          "en" or _ => "Costal Kalos"
        };
      }
    }

    internal static string Gen6KalosAreasMountainKalos {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Kalos-Gebirge",
          "zh"      => "卡洛斯山岳地区",
          "it"      => "Kalos Montana",
          "en" or _ => "Mountain Kalos"
        };
      }
    }

    internal static string Gen7AlolaIslandsAkala {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Akala",
          "zh"      => "阿卡拉岛",
          "it"      => "Akala",
          "en" or _ => "Akala"
        };
      }
    }

    internal static string Gen7AlolaIslandsMelemele {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Mele-Mele",
          "zh"      => "美乐美乐岛",
          "it"      => "Mele-Mele",
          "en" or _ => "Melemele"
        };
      }
    }

    internal static string Gen7AlolaIslandsPoni {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Poni",
          "zh"      => "波尼岛",
          "it"      => "Poni",
          "en" or _ => "Poni"
        };
      }
    }

    internal static string Gen7AlolaIslandsUlaula {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Ula-Ula",
          "zh"      => "乌拉乌拉岛",
          "it"      => "Ula'ula",
          "en" or _ => "Ula'ula"
        };
      }
    }

    internal static string Gen7AlolaSunMoon {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 7 Alola Sonne/Mond",
          "zh"      => "Gen 7 阿罗拉 日/月",
          "it"      => "Gen 7 Alola Sole/Luna",
          "en" or _ => "Gen 7 Alola Sun/Moon"
        };
      }
    }

    internal static string Gen7AlolaSunMoonIslands {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 7 Alola Sonne/Mond Inseln",
          "zh"      => "Gen 7 阿罗拉 日/月 岛屿",
          "it"      => "Gen 7 Alola Sole/Luna Isole",
          "en" or _ => "Gen 7 Alola Sun/Moon Islands"
        };
      }
    }

    internal static string Gen7AlolaUltraSunUltraMoon {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 7 Alola Ultra Sonne/Ultra Mond",
          "zh"      => "Gen 7 阿罗拉 究极之日/究极之月",
          "it"      => "Gen 7 Alola Ultra Sole/Ultra Luna",
          "en" or _ => "Gen 7 Alola Ultra Sun/Ultra Moon"
        };
      }
    }

    internal static string Gen7AlolaUltraSunUltraMoonIslands {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 7 Alola Ultra Sonne/Ultra Mond Inseln",
          "zh"      => "Gen 7 阿罗拉 究极之日/究极之月 岛屿",
          "it"      => "Gen 7 Alola Ultra Sole/Ultra Luna Isole",
          "en" or _ => "Gen 7 Alola Ultra Sun/Ultra Moon Islands"
        };
      }
    }

    internal static string Gen7Kanto {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 7 Kanto",
          "zh"      => "Gen 7 关都",
          "it"      => "Gen 7 Kanto",
          "en" or _ => "Gen 7 Kanto"
        };
      }
    }

    internal static string Gen8Galar {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 8 Kalar",
          "zh"      => "Gen 8 伽勒尔",
          "it"      => "Gen 8 Galar",
          "en" or _ => "Gen 8 Galar"
        };
      }
    }

    internal static string Gen8GalarAreas {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 8 Galar Gebiete",
          "zh"      => "Gen 8 伽勒尔地区",
          "it"      => "Gen 8 Aree di Galar",
          "en" or _ => "Gen 8 Galar Areas"
        };
      }
    }

    internal static string Gen8GalarAreasCrownTundra {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Kronen-Schneelande",
          "zh"      => "王冠雪原",
          "it"      => "Landa Corona",
          "en" or _ => "Crown Tundra"
        };
      }
    }

    internal static string Gen8GalarAreasGalar {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Galar",
          "zh"      => "伽勒尔",
          "it"      => "Galar",
          "en" or _ => "Galar"
        };
      }
    }

    internal static string Gen8GalarAreasIsleofArmor {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Rüstungsinsel",
          "zh"      => "铠之孤岛",
          "it"      => "Isola dell'Armatura",
          "en" or _ => "Isle of Armor"
        };
      }
    }

    internal static string Gen8Hisui {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 8 Hisui",
          "zh"      => "Gen 8 洗翠",
          "it"      => "Gen 8 Hisui",
          "en" or _ => "Gen 8 Hisui"
        };
      }
    }

    internal static string Gen8HisuiAreas {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 8 Hisui Gebiete",
          "zh"      => "Gen 8 洗翠地区",
          "it"      => "Gen 8 Aree di Hisui",
          "en" or _ => "Gen 8 Hisui Areas"
        };
      }
    }

    internal static string Gen8HisuiAreasAlabasterIcelands {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Weißes Frostland",
          "zh"      => "纯白冻土",
          "it"      => "Ghiacci Candidi",
          "en" or _ => "Alabaster Icelands"
        };
      }
    }

    internal static string Gen8HisuiAreasCobaltCoastlands {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Kobalt-Küstenland",
          "zh"      => "群青海岸",
          "it"      => "Costa Oltremare",
          "en" or _ => "Cobalt Coastlands"
        };
      }
    }

    internal static string Gen8HisuiAreasCoronetHighlands {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Kraterberg-Hochland",
          "zh"      => "天冠山麓",
          "it"      => "Pendici Corona",
          "en" or _ => "Coronet Highlands"
        };
      }
    }

    internal static string Gen8HisuiAreasCrimsonMirelands {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Rotes Sumpfland",
          "zh"      => "红莲湿地",
          "it"      => "Acquitrino Vermiglio",
          "en" or _ => "Crimson Mirelands"
        };
      }
    }

    internal static string Gen8HisuiAreasObsidianFieldlands {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Obsidian-Grasland",
          "zh"      => "黑曜原野",
          "it"      => "Landa Ossidiana",
          "en" or _ => "Obsidian Fieldlands"
        };
      }
    }

    internal static string Gen8Sinnoh {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 8 Sinnoh",
          "zh"      => "Gen 8 神奥",
          "it"      => "Gen 8 Sinnoh",
          "en" or _ => "Gen 8 Sinnoh"
        };
      }
    }

    internal static string Gen9Paldea {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Gen 9 Paldea",
          "zh"      => "Gen 9 帕底亚",
          "it"      => "Gen 9 Paldea",
          "en" or _ => "Gen 9 Paldea"
        };
      }
    }

    internal static string Gen9PaldeaRegions {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "Gen 9 帕底亚地区",
          "en" or _ => "Gen 9 Paldea Regions"
        };
      }
    }

    internal static string Gen9PaldeaRegionsPaldea {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Paldea",
          "zh"      => "帕底亚",
          "it"      => "Paldea",
          "en" or _ => "Paldea"
        };
      }
    }

    internal static string Gen9PaldeaRegionsKitakami {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "北上乡",
          "en" or _ => "Kitakami"
        };
      }
    }

    internal static string MenuItemName {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Sortiere Boxen nach",
          "zh"      => "排序插件",
          "it"      => "Ordina i Box in base a",
          "en" or _ => "Sort Boxes By"
        };
      }
    }

    internal static string NationalPokédex {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Nationaldex",
          "zh"      => "全国图鉴",
          "it"      => "Dex Nazionale",
          "en" or _ => "National Pokédex"
        };
      }
    }

    internal static string NationalPokédexRegionalForms {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Nationaldex (Regionale Formen mit Generation)",
          "zh"      => "全国图鉴(地区形态出生世代)",
          "it"      => "Dex Nazionale (Forme Regionali nella Generazione originale)",
          "en" or _ => "National Pokédex (Regional Forms With Generation)"
        };
      }
    }

    internal static string RegionalPokédexTemplate {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "{0} Regionaldex",
          "zh"      => "{0} 地区图鉴",
          "it"      => "{0} Dex Regionale",
          "en" or _ => "{0} Regional Pokédex"
        };
      }
    }

    internal static string Settings {
      get {
        return GameInfo.CurrentLanguage switch {
          "de"      => "Einstellungen",
          "zh"      => "设置",
          "it"      => "Impostazioni",
          "en" or _ => "Settings"
        };
      }
    }

  }
}
