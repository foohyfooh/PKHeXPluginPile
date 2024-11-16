using PKHeX.Core;

namespace PluginPile.FashionEditor;
internal static class Language {

  public static string Cancel => Common.Language.Cancel;

  public static string Item => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "样式",
    "en" or _ => "Item"
  };

  public static string New => Common.Language.New;

  public static string Title => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "时装插件",
    "en" or _ => "Fashion Editor"
  };

  public static string Save => Common.Language.Save;

  public static string Unlocked => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "解锁",
    "en" or _ => "Unlocked"
  };

  public static string Unused => Common.Language.Unused;

  private static string[] GetStringList(string filename) =>
    Common.Language.GetStringList(typeof(FashionEditorPlugin).Assembly, nameof(FashionEditorPlugin), filename);

  #region Common Language
  private static string Bottoms => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "下装",
    "en" or _ => "Bottoms"
  };

  private static string Glasses => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "眼镜",
    "en" or _ => "Glasses"
  };

  private static string Hats => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "头饰",
    "en" or _ => "Hats"
  };

  private static string Shoes => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "鞋子",
    "en" or _ => "Shoes"
  };

  private static string Tops => GameInfo.CurrentLanguage switch {
    "zh-Hans" => "上装",
    "en" or _ => "Tops"
  };
  #endregion

  internal static class SwSh {
    public static string Tops => Language.Tops;

    public static string[] TopsList(int gender) => gender switch {
      0 => TopsListMale,
      1 => TopsListFemale,
      _ => []
    };

    public static string[] TopsListMale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_tops_male_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_tops_male_en.txt")
    };

    public static string[] TopsListFemale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_tops_female_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_tops_female_en.txt")
    };

    public static string Jackets => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "外套",
      "en" or _ => "Jackets"
    };

    public static string[] JacketsList(int gender) => gender switch {
      0 => JacketsListMale,
      1 => JacketsListFemale,
      _ => []
    };

    public static string[] JacketsListMale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_jackets_male_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_jackets_male_en.txt")
    };

    public static string[] JacketsListFemale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_jackets_female_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_jackets_female_en.txt")
    };

    public static string Bottoms => Language.Bottoms;

    public static string[] BottomsList(int gender) => gender switch {
      0 => BottomsListMale,
      1 => BottomsListFemale,
      _ => []
    };

    public static string[] BottomsListMale => GameInfo.CurrentLanguage switch {
      "zh-Hans"  => GetStringList("swsh_bottoms_male_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_bottoms_male_en.txt")
    };

    public static string[] BottomsListFemale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_bottoms_female_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_bottoms_female_en.txt")
    };

    public static string Dresses => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "时装",
      "en" or _ => "Dresses"
    };

    public static string Socks => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "袜子",
      "en" or _ => "Socks"
    };

    public static string[] SocksList(int gender) => gender switch {
      0 => SocksListMale,
      1 => SocksListFemale,
      _ => []
    };

    public static string[] SocksListMale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_socks_male_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_socks_male_en.txt")
    };

    public static string[] SocksListFemale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_socks_female_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_socks_female_en.txt")
    };

    public static string Shoes => Language.Shoes;

    public static string[] ShoesList(int gender) => gender switch {
      0 => ShoesListMale,
      1 => ShoesListFemale,
      _ => []
    };

    public static string[] ShoesListMale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_shoes_male_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_shoes_male_en.txt")
    };

    public static string[] ShoesListFemale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_shoes_female_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_shoes_female_en.txt")
    };

    public static string Bags => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "包包",
      "en" or _ => "Bags"
    };

    public static string[] BagsList(int gender) => gender switch {
      0 => BagsListMale,
      1 => BagsListFemale,
      _ => []
    };

    public static string[] BagsListMale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_bags_male_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_bags_male_en.txt")
    };

    public static string[] BagsListFemale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_bags_female_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_bags_female_en.txt")
    };

    public static string Hats => Language.Hats;

    public static string[] HatsList(int gender) => gender switch {
      0 => HatsListMale,
      1 => HatsListFemale,
      _ => []
    };

    public static string[] HatsListMale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_hats_male_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_hats_male_en.txt")
    };

    public static string[] HatsListFemale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_hats_female_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_hats_female_en.txt")
    };

    public static string Glasses => Language.Glasses;

    public static string[] GlassesList(int gender) => gender switch {
      0 => GlassesListMale,
      1 => GlassesListFemale,
      _ => []
    };

    public static string[] GlassesListMale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_glasses_male_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_glasses_male_en.txt")
    };

    public static string[] GlassesListFemale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_glasses_female_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_glasses_female_en.txt")
    };

    public static string Gloves => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "手套",
      "en" or _ => "Gloves"
    };

    public static string[] GlovesList(int gender) => gender switch {
      0 => GlovesListMale,
      1 => GlovesListFemale,
      _ => []
    };

    public static string[] GlovesListMale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_gloves_male_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_gloves_male_en.txt")
    };

    public static string[] GlovesListFemale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("swsh_gloves_female_zh-Hans.txt"),
      "en" or _ => GetStringList("swsh_gloves_female_en.txt")
    };
  }

  internal static class BDSP {
    public static string FashionEveryday => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "平常",
      "en" or _ => "Everyday"
    };

    public static string FashionPikachu => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "皮卡丘卫衣",
      "en" or _ => "Pikachu"
    };

    public static string FashionPlatinum => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "白金",
      "en" or _ => "Platinum"
    };

    public static string FashionOveralls => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "工装服",
      "en" or _ => "Overalls"
    };

    public static string FashionEevee => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "伊布刺绣夹克",
      "en" or _ => "Eevee"
    };

    public static string FashionGengar => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "耿鬼刺绣夹克",
      "en" or _ => "Gengar"
    };

    public static string FashionCyber => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "赛博",
      "en" or _ => "Cyber"
    };

    public static string FashionSummer => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "夏季",
      "en" or _ => "Summer"
    };

    public static string FashionWinter => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "冬季",
      "en" or _ => "Winter"
    };

    public static string FashionSpring => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "春季",
      "en" or _ => "Spring"
    };

    public static string FashionCasual => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "运动",
      "en" or _ => "Casual"
    };

    public static string FashionLeather => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "皮夹克",
      "en" or _ => "Leather"
    };
  }

  internal static class LA {
    public static string Hats => Language.Hats;

    public static string[] HatsList(int gender) => gender switch {
      0 => HatsListMale,
      1 => HatsListFemale,
      _ => []
    };


    public static string[] HatsListMale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("la_hats_male_zh-Hans.txt"),
      "en" or _ => GetStringList("la_hats_male_en.txt")
    };

    public static string[] HatsListFemale => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("la_hats_female_zh-Hans.txt"),
      "en" or _ => GetStringList("la_hats_female_en.txt")
    };

    public static string Tops => Language.Tops;

    public static string[] TopsList => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("la_tops_zh-Hans.txt"),
      "en" or _ => GetStringList("la_tops_en.txt")
    };

    public static string Bottoms => Language.Bottoms;

    public static string[] BottomsList => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("la_bottoms_zh-Hans.txt"),
      "en" or _ => GetStringList("la_bottoms_en.txt")
    };

    public static string Uniforms => GameInfo.CurrentLanguage switch {
      "zh-Hans" => "套装",
      "en" or _ => "Uniforms"
    };

    public static string[] UniformsList => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("la_uniforms_zh-Hans.txt"),
      "en" or _ => GetStringList("la_uniforms_en.txt")
    };

    public static string Shoes => Language.Shoes;

    public static string[] ShoesList => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("la_shoes_zh-Hans.txt"),
      "en" or _ => GetStringList("la_shoes_en.txt")
    };

    public static string Glasses => Language.Glasses;

    public static string[] GlassesList => GameInfo.CurrentLanguage switch {
      "zh-Hans" => GetStringList("la_glasses_zh-Hans.txt"),
      "en" or _ => GetStringList("la_glasses_en.txt")
    };
  }

}
