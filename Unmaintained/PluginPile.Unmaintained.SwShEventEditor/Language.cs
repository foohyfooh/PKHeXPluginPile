using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShEventEditor;

internal static class Language {

  public static string MenuItemName => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "剑盾事件编辑器",
    "en" or _ => "Sword/Shield Event Editor"
  };

  public static string EditorBaseGameWorldEvent => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "基础游戏",
    "en" or _ => "Edit Base Game World Events"
  };

  public static string EditIsleOfArmorWorldEvents => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "铠之孤岛",
    "en" or _ => "Edit Isle of Armor World Events"
  };

  public static string CrownTundra => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "王冠雪原",
    "en" or _ => "Crown Tundra"
  };

  public static string CrownTundraEditWorldEvents => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "编辑 世界事件",
    "en" or _ => "Edit World Events"
  };

  public static string CrownTundraEditMaxLair => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "编辑 极巨大冒险",
    "en" or _ => "Edit Max Lair"
  };

  public static string CrownTundraEditRegis => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "编辑 雷吉",
    "en" or _ => "Edit Regis"
  };

  public static string CrownTundraEditSwordsOfJustice => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "编辑 四剑客",
    "en" or _ => "Edit Swords of Justice"
  };

  public static string EditCurrydexAndPokecamp => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "编辑 宝可梦野营/咖喱图鉴",
    "en" or _ => "Edit Currydex/Pokecamp"
  };

  public static string ConvertWondercard => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "神秘礼物卡片导入",
    "en" or _ => "Convert Wondercard"
  };

  public static string[] DojoWattDonationQuestProgress => GameInfo.CurrentLanguage switch {
    "zh-Hans" => ["未激活", "和蜜叶谈过了", "可改变发型", "洛托米安装", "洛托米功能", "自动贩卖机可购买美味之水", "自动贩卖机可购买劲爽汽水", "自动贩卖机可购买果汁牛奶", "食材定期配送服务", "自动贩卖机可购买攻击/防御增强剂", "自动贩卖机可购买特攻/特防增强剂", "自动贩卖机可购买HP/速度增强剂", "联盟卡背景", "收到蜜叶的联盟卡", "可与蜜叶对战", "收到蜜叶的稀有联盟卡"],
    "en" or _ => ["Not Started", "Talked To Honey", "Hair Stylist Available", "Broken Rotomi Terminal", "Fixed Rotomi Terminal", "Fresh Water in Vending Machine", "Soda Pop in Vending Machine", "Lemonade in Vending Machine", "Fresh Ingredients in Refrigerator", "Protein and Iron in Vending Machine", "Calcium and Zinc in Vending Machine", "HP Up and Carbos in Vending Machine", "Master Dojo League Card Backgrounds", "Honey's League Card Received", "Trainer Battle with Honey Unlocked", "Walk with Honey and Honey's Rare League Card"]
  };

  public static string[] SwordsOfJusticeQuestStatus => GameInfo.CurrentLanguage switch {
    "zh-Hans" => ["无法启动", "可以启动", "镜头突出勾帕路翁的脚印", "进行中"],
    "en" or _ => ["Can't Start", "Can Start", "Camera Highlights Cobalion Footprints", "In Progress"]
  };

  public static string[] SwordsOfJusticeQuestProgress => GameInfo.CurrentLanguage switch {
    "zh-Hans" => ["0 已报告", "1 已报告", "2 已报告", "3 报告/凯路迪欧可激活", "凯路迪欧已捕获", "凯路迪欧已报告"],
    "en" or _ => ["0 Reported", "1 Reported", "2 Reported", "3 Reported/Keldeo Available", "Keldeo Captured", "Keldeo Reported"]
  };

  public static string[] SwordsOfJusticeProgress => GameInfo.CurrentLanguage switch {
    "zh-Hans" => ["未报告的足迹", "显示/出现的位置", "已捕获", "捕获报告"],
    "en" or _ => ["Footprints Unreported", "Location Revealed/Appeared", "Captured", "Capture Reported"]
  };

  public static string[] KeldeoProgress => GameInfo.CurrentLanguage switch {
    "zh-Hans" => ["必须野营", "出现", "已捕获"],
    "en" or _ => ["Have To Camp", "Appeared", "Captured"]
  };
}
