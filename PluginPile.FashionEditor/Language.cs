using PKHeX.Core;

namespace PluginPile.FashionEditor;
internal static class Language {

  public static string Cancel => Common.Language.Cancel;

  public static string Item {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "样式",
        "en" or _ => "Item"
      };
    }
  }

  public static string New {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "New"
      };
    }
  }

  public static string Title {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "时装插件",
        "en" or _ => "Fashion Editor"
      };
    }
  }

  public static string Save => Common.Language.Save;

  public static string Unlocked {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "解锁",
        "en" or _ => "Unlocked"
      };
    }
  }

  public static string Unused => Common.Language.Unused;

  private static string[] GetStringList(string filename) =>
    Common.Language.GetStringList(typeof(FashionEditorPlugin).Assembly, nameof(FashionEditorPlugin), filename);

  #region Common Language
  private static string Bottoms {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "下装",
        "en" or _ => "Bottoms"
      };
    }
  }

  private static string Glasses {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "眼镜",
        "en" or _ => "Glasses"
      };
    }
  }

  private static string Hats {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "头饰",
        "en" or _ => "Hats"
      };
    }
  }

  private static string Shoes {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "鞋子",
        "en" or _ => "Shoes"
      };
    }
  }

  private static string Tops {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "上装",
        "en" or _ => "Tops"
      };
    }
  }
  #endregion

  internal static class SwSh {
    public static string Tops => Language.Tops;

    public static string[] TopsList(int gender) {
      return gender switch {
        0 => TopsListMale,
        1 => TopsListFemale,
        _ => []
      };
    }

    public static string[] TopsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_tops_male_zh.txt"),
          "en" or _ => GetStringList("swsh_tops_male_en.txt")
        };
      }
    }

    public static string[] TopsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_tops_female_zh.txt"),
          "en" or _ => GetStringList("swsh_tops_female_en.txt")
        };
      }
    }

    public static string Jackets {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "外套",
          "en" or _ => "Jackets"
        };
      }
    }

    public static string[] JacketsList(int gender) {
      return gender switch {
        0 => JacketsListMale,
        1 => JacketsListFemale,
        _ => []
      };
    }

    public static string[] JacketsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_jackets_male_zh.txt"),
          "en" or _ => GetStringList("swsh_jackets_male_en.txt")
        };
      }
    }

    public static string[] JacketsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_jackets_female_zh.txt"),
          "en" or _ => GetStringList("swsh_jackets_female_en.txt")
        };
      }
    }

    public static string Bottoms => Language.Bottoms;

    public static string[] BottomsList(int gender) {
      return gender switch {
        0 => BottomsListMale,
        1 => BottomsListFemale,
        _ => []
      };
    }

    public static string[] BottomsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_bottoms_male_zh.txt"),
          "en" or _ => GetStringList("swsh_bottoms_male_en.txt")
        };
      }
    }

    public static string[] BottomsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_bottoms_female_zh.txt"),
          "en" or _ => GetStringList("swsh_bottoms_female_en.txt")
        };
      }
    }

    public static string Dresses {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "时装",
          "en" or _ => "Dresses"
        };
      }
    }

    public static string Socks {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "袜子",
          "en" or _ => "Socks"
        };
      }
    }

    public static string[] SocksList(int gender) {
      return gender switch {
        0 => SocksListMale,
        1 => SocksListFemale,
        _ => []
      };
    }

    public static string[] SocksListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_socks_male_zh.txt"),
          "en" or _ => GetStringList("swsh_socks_male_en.txt")
        };
      }
    }

    public static string[] SocksListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_socks_female_zh.txt"),
          "en" or _ => GetStringList("swsh_socks_female_en.txt")
        };
      }
    }

    public static string Shoes => Language.Shoes;

    public static string[] ShoesList(int gender) {
      return gender switch {
        0 => ShoesListMale,
        1 => ShoesListFemale,
        _ => []
      };
    }

    public static string[] ShoesListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_shoes_male_zh.txt"),
          "en" or _ => GetStringList("swsh_shoes_male_en.txt")
        };
      }
    }

    public static string[] ShoesListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_shoes_female_zh.txt"),
          "en" or _ => GetStringList("swsh_shoes_female_en.txt")
        };
      }
    }

    public static string Bags {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "包包",
          "en" or _ => "Bags"
        };
      }
    }

    public static string[] BagsList(int gender) {
      return gender switch {
        0 => BagsListMale,
        1 => BagsListFemale,
        _ => []
      };
    }

    public static string[] BagsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_bags_male_zh.txt"),
          "en" or _ => GetStringList("swsh_bags_male_en.txt")
        };
      }
    }

    public static string[] BagsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_bags_female_zh.txt"),
          "en" or _ => GetStringList("swsh_bags_female_en.txt")
        };
      }
    }

    public static string Hats => Language.Hats;

    public static string[] HatsList(int gender) {
      return gender switch {
        0 => HatsListMale,
        1 => HatsListFemale,
        _ => []
      };
    }

    public static string[] HatsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_hats_male_zh.txt"),
          "en" or _ => GetStringList("swsh_hats_male_en.txt")
        };
      }
    }

    public static string[] HatsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_hats_female_zh.txt"),
          "en" or _ => GetStringList("swsh_hats_female_en.txt")
        };
      }
    }

    public static string Glasses => Language.Glasses;

    public static string[] GlassesList(int gender) {
      return gender switch {
        0 => GlassesListMale,
        1 => GlassesListFemale,
        _ => []
      };
    }

    public static string[] GlassesListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_glasses_male_zh.txt"),
          "en" or _ => GetStringList("swsh_glasses_male_en.txt")
        };
      }
    }

    public static string[] GlassesListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_glasses_female_zh.txt"),
          "en" or _ => GetStringList("swsh_glasses_female_en.txt")
        };
      }
    }

    public static string Gloves {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "手套",
          "en" or _ => "Gloves"
        };
      }
    }

    public static string[] GlovesList(int gender) {
      return gender switch {
        0 => GlovesListMale,
        1 => GlovesListFemale,
        _ => []
      };
    }

    public static string[] GlovesListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_gloves_male_zh.txt"),
          "en" or _ => GetStringList("swsh_gloves_male_en.txt")
        };
      }
    }

    public static string[] GlovesListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_gloves_female_zh.txt"),
          "en" or _ => GetStringList("swsh_gloves_female_en.txt")
        };
      }
    }
  }

  internal static class BDSP {
    public static string FashionEveryday {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "平常",
          "en" or _ => "Everyday"
        };
      }
    }

    public static string FashionPikachu {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "皮卡丘卫衣",
          "en" or _ => "Pikachu"
        };
      }
    }

    public static string FashionPlatinum {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "白金",
          "en" or _ => "Platinum"
        };
      }
    }

    public static string FashionOveralls {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "工装服",
          "en" or _ => "Overalls"
        };
      }
    }

    public static string FashionEevee {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "伊布刺绣夹克",
          "en" or _ => "Eevee"
        };
      }
    }

    public static string FashionGengar {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "耿鬼刺绣夹克",
          "en" or _ => "Gengar"
        };
      }
    }

    public static string FashionCyber {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "赛博",
          "en" or _ => "Cyber"
        };
      }
    }

    public static string FashionSummer {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "夏季",
          "en" or _ => "Summer"
        };
      }
    }

    public static string FashionWinter {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "冬季",
          "en" or _ => "Winter"
        };
      }
    }

    public static string FashionSpring {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "春季",
          "en" or _ => "Spring"
        };
      }
    }

    public static string FashionCasual {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "运动",
          "en" or _ => "Casual"
        };
      }
    }

    public static string FashionLeather {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "皮夹克",
          "en" or _ => "Leather"
        };
      }
    }
  }

  internal static class LA {
    public static string Hats => Language.Hats;

    public static string[] HatsList(int gender) {
      return gender switch {
        0 => HatsListMale,
        1 => HatsListFemale,
        _ => []
      };
    }


    public static string[] HatsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_hats_male_zh.txt"),
          "en" or _ => GetStringList("la_hats_male_en.txt")
        };
      }
    }

    public static string[] HatsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_hats_female_zh.txt"),
          "en" or _ => GetStringList("la_hats_female_en.txt")
        };
      }
    }

    public static string Tops => Language.Tops;

    public static string[] TopsList {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_tops_zh.txt"),
          "en" or _ => GetStringList("la_tops_en.txt")
        };
      }
    }

    public static string Bottoms => Language.Bottoms;

    public static string[] BottomsList {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_bottoms_zh.txt"),
          "en" or _ => GetStringList("la_bottoms_en.txt")
        };
      }
    }

    public static string Uniforms {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "套装",
          "en" or _ => "Uniforms"
        };
      }
    }

    public static string[] UniformsList {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_uniforms_zh.txt"),
          "en" or _ => GetStringList("la_uniforms_en.txt")
        };
      }
    }

    public static string Shoes => Language.Shoes;

    public static string[] ShoesList {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_shoes_zh.txt"),
          "en" or _ => GetStringList("la_shoes_en.txt")
        };
      }
    }

    public static string Glasses => Language.Glasses;

    public static string[] GlassesList {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_glasses_zh.txt"),
          "en" or _ => GetStringList("la_glasses_en.txt")
        };
      }
    }
  }

}
