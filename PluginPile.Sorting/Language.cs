using PKHeX.Core;

namespace PluginPile.Sorting;
internal static class Language {

  public static string Gen1Kanto => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 1 Kanto",
    "zh-Hans" => "Gen 1 关都",
    "it"      => "Gen 1 Kanto",
    "en" or _ => "Gen 1 Kanto"
  };

  public static string Gen2Johto => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 2 Johto",
    "zh-Hans" => "Gen 2 城都",
    "it"      => "Gen 2 Johto",
    "en" or _ => "Gen 2 Johto"
  };

  public static string Gen3Hoenn => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 3 Hoenn",
    "zh-Hans" => "Gen 3 丰缘",
    "it"      => "Gen 3 Hoenn",
    "en" or _ => "Gen 3 Hoenn"
  };

  public static string Gen3Kanto => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 3 Kanto",
    "zh-Hans" => "Gen 3 关都",
    "it"      => "Gen 3 Kanto",
    "en" or _ => "Gen 3 Kanto"
  };

  public static string Gen4Johto => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 4 Johto",
    "zh-Hans" => "Gen 4 神奥",
    "it"      => "Gen 4 Johto",
    "en" or _ => "Gen 4 Johto"
  };

  public static string Gen4SinnohDiamondPearl => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 4 Sinnoh Diamant/Perl",
    "zh-Hans" => "Gen 4 神奥 钻石/珍珠",
    "it"      => "Gen 4 Sinnoh Diamante/Perla",
    "en" or _ => "Gen 4 Sinnoh Diamond/Pearl"
  };

  public static string Gen4SinnohPlatinum => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 4 Sinnoh Platin",
    "zh-Hans" => "Gen 4 神奥 白金",
    "it"      => "Gen 4 Sinnoh Platino",
    "en" or _ => "Gen 4 Sinnoh Platinum"
  };

  public static string Gen5UnovaBlack2White2 => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 5 Einall Schwarz 2/Weiß 2",
    "zh-Hans" => "Gen 5 合众 黑2/白2",
    "it"      => "Gen 5 Unima Nero 2/Bianco 2",
    "en" or _ => "Gen 5 Unova Black 2/White 2"
  };

  public static string Gen5UnovaBlackWhite => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 5 Einall Schwarz/Weiß",
    "zh-Hans" => "Gen 5 合众 黑/白",
    "it"      => "Gen 5 Unima Nero/Bianco",
    "en" or _ => "Gen 5 Unova Black/White"
  };

  public static string Gen6Hoenn => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 6 Hoenn",
    "zh-Hans" => "Gen 6 丰缘",
    "it"      => "Gen 6 Hoenn",
    "en" or _ => "Gen 6 Hoenn"
  };

  public static string Gen6Kalos => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 6 Kalos",
    "zh-Hans" => "Gen 6 卡洛斯",
    "it"      => "Gen 6 Kalos",
    "en" or _ => "Gen 6 Kalos"
  };

  public static string Gen6KalosAreas => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 6 Kalos Gebiete",
    "zh-Hans" => "Gen 6 卡洛斯地区",
    "it"      => "Gen 6 Aree di Kalos",
    "en" or _ => "Gen 6 Kalos Areas"
  };

  public static string Gen6KalosAreasCentralKalos => GameInfo.CurrentLanguage switch {
    "de"      => "Zentral-Kalos",
    "zh-Hans" => "卡洛斯中央地区",
    "it"      => "Kalos Centrale",
    "en" or _ => "Central Kalos"
  };

  public static string Gen6KalosAreasCostalKalos => GameInfo.CurrentLanguage switch {
    "de"      => "Kalos-Küste",
    "zh-Hans" => "卡洛斯海岸地区",
    "it"      => "Kalos Costiera",
    "en" or _ => "Costal Kalos"
  };

  public static string Gen6KalosAreasMountainKalos => GameInfo.CurrentLanguage switch {
    "de"      => "Kalos-Gebirge",
    "zh-Hans" => "卡洛斯山岳地区",
    "it"      => "Kalos Montana",
    "en" or _ => "Mountain Kalos"
  };

  public static string Gen7AlolaIslandsAkala => GameInfo.CurrentLanguage switch {
    "de"      => "Akala",
    "zh-Hans" => "阿卡拉岛",
    "it"      => "Akala",
    "en" or _ => "Akala"
  };

  public static string Gen7AlolaIslandsMelemele => GameInfo.CurrentLanguage switch {
    "de"      => "Mele-Mele",
    "zh-Hans" => "美乐美乐岛",
    "it"      => "Mele-Mele",
    "en" or _ => "Melemele"
  };

  public static string Gen7AlolaIslandsPoni => GameInfo.CurrentLanguage switch {
    "de"      => "Poni",
    "zh-Hans" => "波尼岛",
    "it"      => "Poni",
    "en" or _ => "Poni"
  };

  public static string Gen7AlolaIslandsUlaula => GameInfo.CurrentLanguage switch {
    "de"      => "Ula-Ula",
    "zh-Hans" => "乌拉乌拉岛",
    "it"      => "Ula'ula",
    "en" or _ => "Ula'ula"
  };

  public static string Gen7AlolaSunMoon => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 7 Alola Sonne/Mond",
    "zh-Hans" => "Gen 7 阿罗拉 日/月",
    "it"      => "Gen 7 Alola Sole/Luna",
    "en" or _ => "Gen 7 Alola Sun/Moon"
  };

  public static string Gen7AlolaSunMoonIslands => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 7 Alola Sonne/Mond Inseln",
    "zh-Hans" => "Gen 7 阿罗拉 日/月 岛屿",
    "it"      => "Gen 7 Alola Sole/Luna Isole",
    "en" or _ => "Gen 7 Alola Sun/Moon Islands"
  };

  public static string Gen7AlolaUltraSunUltraMoon => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 7 Alola Ultra Sonne/Ultra Mond",
    "zh-Hans" => "Gen 7 阿罗拉 究极之日/究极之月",
    "it"      => "Gen 7 Alola Ultra Sole/Ultra Luna",
    "en" or _ => "Gen 7 Alola Ultra Sun/Ultra Moon"
  };

  public static string Gen7AlolaUltraSunUltraMoonIslands => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 7 Alola Ultra Sonne/Ultra Mond Inseln",
    "zh-Hans" => "Gen 7 阿罗拉 究极之日/究极之月 岛屿",
    "it"      => "Gen 7 Alola Ultra Sole/Ultra Luna Isole",
    "en" or _ => "Gen 7 Alola Ultra Sun/Ultra Moon Islands"
  };

  public static string Gen7Kanto => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 7 Kanto",
    "zh-Hans" => "Gen 7 关都",
    "it"      => "Gen 7 Kanto",
    "en" or _ => "Gen 7 Kanto"
  };

  public static string Gen8Galar => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 8 Kalar",
    "zh-Hans" => "Gen 8 伽勒尔",
    "it"      => "Gen 8 Galar",
    "en" or _ => "Gen 8 Galar"
  };

  public static string Gen8GalarAreas => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 8 Galar Gebiete",
    "zh-Hans" => "Gen 8 伽勒尔地区",
    "it"      => "Gen 8 Aree di Galar",
    "en" or _ => "Gen 8 Galar Areas"
  };

  public static string Gen8GalarAreasCrownTundra => GameInfo.CurrentLanguage switch {
    "de"      => "Kronen-Schneelande",
    "zh-Hans" => "王冠雪原",
    "it"      => "Landa Corona",
    "en" or _ => "Crown Tundra"
  };

  public static string Gen8GalarAreasGalar => GameInfo.CurrentLanguage switch {
    "de"      => "Galar",
    "zh-Hans" => "伽勒尔",
    "it"      => "Galar",
    "en" or _ => "Galar"
  };

  public static string Gen8GalarAreasIsleofArmor => GameInfo.CurrentLanguage switch {
    "de"      => "Rüstungsinsel",
    "zh-Hans" => "铠之孤岛",
    "it"      => "Isola dell'Armatura",
    "en" or _ => "Isle of Armor"
  };

  public static string Gen8Hisui => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 8 Hisui",
    "zh-Hans" => "Gen 8 洗翠",
    "it"      => "Gen 8 Hisui",
    "en" or _ => "Gen 8 Hisui"
  };

  public static string Gen8HisuiAreas => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 8 Hisui Gebiete",
    "zh-Hans" => "Gen 8 洗翠地区",
    "it"      => "Gen 8 Aree di Hisui",
    "en" or _ => "Gen 8 Hisui Areas"
  };

  public static string Gen8HisuiAreasAlabasterIcelands => GameInfo.CurrentLanguage switch {
    "de"      => "Weißes Frostland",
    "zh-Hans" => "纯白冻土",
    "it"      => "Ghiacci Candidi",
    "en" or _ => "Alabaster Icelands"
  };

  public static string Gen8HisuiAreasCobaltCoastlands => GameInfo.CurrentLanguage switch {
    "de"      => "Kobalt-Küstenland",
    "zh-Hans" => "群青海岸",
    "it"      => "Costa Oltremare",
    "en" or _ => "Cobalt Coastlands"
  };

  public static string Gen8HisuiAreasCoronetHighlands => GameInfo.CurrentLanguage switch {
    "de"      => "Kraterberg-Hochland",
    "zh-Hans" => "天冠山麓",
    "it"      => "Pendici Corona",
    "en" or _ => "Coronet Highlands"
  };

  public static string Gen8HisuiAreasCrimsonMirelands => GameInfo.CurrentLanguage switch {
    "de"      => "Rotes Sumpfland",
    "zh-Hans" => "红莲湿地",
    "it"      => "Acquitrino Vermiglio",
    "en" or _ => "Crimson Mirelands"
  };

  public static string Gen8HisuiAreasObsidianFieldlands => GameInfo.CurrentLanguage switch {
    "de"      => "Obsidian-Grasland",
    "zh-Hans" => "黑曜原野",
    "it"      => "Landa Ossidiana",
    "en" or _ => "Obsidian Fieldlands"
  };

  public static string Gen8Sinnoh => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 8 Sinnoh",
    "zh-Hans" => "Gen 8 神奥",
    "it"      => "Gen 8 Sinnoh",
    "en" or _ => "Gen 8 Sinnoh"
  };

  public static string Gen9Paldea => GameInfo.CurrentLanguage switch {
    "de"      => "Gen 9 Paldea",
    "zh-Hans" => "Gen 9 帕底亚",
    "it"      => "Gen 9 Paldea",
    "en" or _ => "Gen 9 Paldea"
  };

  public static string Gen9PaldeaRegions => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "Gen 9 帕底亚地区",
    "en" or _ => "Gen 9 Paldea Regions"
  };

  public static string Gen9PaldeaRegionsPaldea => GameInfo.CurrentLanguage switch {
    "de"      => "Paldea",
    "zh-Hans" => "帕底亚",
    "it"      => "Paldea",
    "en" or _ => "Paldea"
  };

  public static string Gen9PaldeaRegionsKitakami => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "北上乡",
    "en" or _ => "Kitakami"
  };

  public static string Gen9PaldeaRegionsBlueberryAcademy => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "蓝莓学院",
    "en" or _ => "Blueberry Academy"
  };

  public static string Gen9Kalos => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "Gen 9 卡洛斯",
    "en" or _ => "Gen 9 Kalos"
  };

  public static string Gen9KalosRegions => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "Gen 9 卡洛斯地区",
    "en" or _ => "Gen 9 Kalos Regions"
  };

  public static string Gen9KalosRegionLumioseCity => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "密阿雷市",
    "en" or _ => "Lumiose City"
  };

  public static string Gen9KalosRegionHyperspaceLumiose => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "超空间密阿雷市",
    "en" or _ => "Hyperspace Lumiose"
  };

  public static string MenuItemName => GameInfo.CurrentLanguage switch {
    "de"      => "Sortiere Boxen nach",
    "zh-Hans" => "排序插件",
    "it"      => "Ordina i Box in base a",
    "en" or _ => "Sort Boxes By"
  };

  public static string NationalPokédex => GameInfo.CurrentLanguage switch {
    "de"      => "Nationaldex",
    "zh-Hans" => "全国图鉴",
    "it"      => "Dex Nazionale",
    "en" or _ => "National Pokédex"
  };

  public static string NationalPokédexRegionalForms => GameInfo.CurrentLanguage switch {
    "de"      => "Nationaldex (Regionale Formen mit Generation)",
    "zh-Hans" => "全国图鉴(地区形态出生世代)",
    "it"      => "Dex Nazionale (Forme Regionali nella Generazione originale)",
    "en" or _ => "National Pokédex (Regional Forms With Generation)"
  };

  public static string RegionalPokédexTemplate => GameInfo.CurrentLanguage switch {
    "de"      => "{0} Regionaldex",
    "zh-Hans" => "{0} 地区图鉴",
    "it"      => "{0} Dex Regionale",
    "en" or _ => "{0} Regional Pokédex"
  };

  public static string Settings => GameInfo.CurrentLanguage switch {
    "de"      => "Einstellungen",
    "zh-Hans" => "设置",
    "it"      => "Impostazioni",
    "en" or _ => "Settings"
  };

  public static string InsertSlot => GameInfo.CurrentLanguage switch {
    "de"      => "Slot eingeben",
    "zh-Hans" => "插入插件",
    "it"      => "Inserisci Slot",
    "en" or _ => "Insert Slot"
  };

  public static string NoEmptySlotsError => GameInfo.CurrentLanguage switch {
    "de"      => "Es gibt keine leeren Slots nach Box {0} Slot {1}",
    "zh-Hans" => "盒子 {0} 槽位 {1} 之后没有空槽位",
    "it"      => "Non ci sono slot vuoti dopo Box {0} Slot {1}",
    "en" or _ => "There are no empty slots after Box {0} Slot {1}"
  };

}
