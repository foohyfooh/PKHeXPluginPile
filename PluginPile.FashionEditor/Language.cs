using PKHeX.Core;

namespace PluginPile.FashionEditor; 
internal static class Language {

  internal static string Cancel => Common.Language.Cancel;

  internal static string Item {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "样式",
        "en" or _ => "Item"
      };
    }
  }

  internal static string New {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "New"
      };
    }
  }

  internal static string Title {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "时装插件",
        "en" or _ => "Fashion Editor"
      };
    }
  }

  internal static string Save => Common.Language.Save;

  internal static string Unlocked {
    get {
      return GameInfo.CurrentLanguage switch {
        "zh"      => "解锁",
        "en" or _ => "Unlocked"
      };
    }
  }

  internal static string Unused => Common.Language.Unused;

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
    internal static string Tops => Language.Tops;
    
    internal static string[] TopsList(int gender) {
      return gender switch {
        0 => TopsListMale,
        1 => TopsListFemale,
        _ => []
      };
    }

    internal static string[] TopsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_tops_male_zh.txt"),
          "en" or _ => GetStringList("swsh_tops_male_en.txt")
        };
      }
    }

    internal static string[] TopsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_tops_female_zh.txt"),
          "en" or _ => GetStringList("swsh_tops_female_en.txt")
        };
      }
    }

    internal static string Jackets {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "外套",
          "en" or _ => "Jackets"
        };
      }
    }

    internal static string[] JacketsList(int gender) {
      return gender switch {
        0 => JacketsListMale,
        1 => JacketsListFemale,
        _ => []
      };
    }

    internal static string[] JacketsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_jackets_male_zh.txt"),
          "en" or _ => GetStringList("swsh_jackets_male_en.txt")
        };
      }
    }

    internal static string[] JacketsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_jackets_female_zh.txt"),
          "en" or _ => GetStringList("swsh_jackets_female_en.txt")
        };
      }
    }

    internal static string Bottoms => Language.Bottoms;

    internal static string[] BottomsList(int gender) {
      return gender switch {
        0 => BottomsListMale,
        1 => BottomsListFemale,
        _ => []
      };
    }

    internal static string[] BottomsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_bottoms_male_zh.txt"),
          "en" or _ => GetStringList("swsh_bottoms_male_en.txt")
        };
      }
    }

    internal static string[] BottomsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_bottoms_female_zh.txt"),
          "en" or _ => GetStringList("swsh_bottoms_female_en.txt")
        };
      }
    }

    internal static string Dresses {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "时装",
          "en" or _ => "Dresses"
        };
      }
    }

    internal static string Socks {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "袜子",
          "en" or _ => "Socks"
        };
      }
    }

    internal static string[] SocksList(int gender) {
      return gender switch {
        0 => SocksListMale,
        1 => SocksListFemale,
        _ => []
      };
    }

    internal static string[] SocksListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_socks_male_zh.txt"),
          "en" or _ => GetStringList("swsh_socks_male_en.txt")
        };
      }
    }

    internal static string[] SocksListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_socks_female_zh.txt"),
          "en" or _ => GetStringList("swsh_socks_female_en.txt")
        };
      }
    }

    internal static string Shoes => Language.Shoes;

    internal static string[] ShoesList(int gender) {
      return gender switch {
        0 => ShoesListMale,
        1 => ShoesListFemale,
        _ => []
      };
    }

    internal static string[] ShoesListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_shoes_male_zh.txt"),
          "en" or _ => GetStringList("swsh_shoes_male_en.txt")
        };
      }
    }

    internal static string[] ShoesListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_shoes_female_zh.txt"),
          "en" or _ => GetStringList("swsh_shoes_female_en.txt")
        };
      }
    }

    internal static string Bags {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "包包",
          "en" or _ => "Bags"
        };
      }
    }

    internal static string[] BagsList(int gender) {
      return gender switch {
        0 => BagsListMale,
        1 => BagsListFemale,
        _ => []
      };
    }

    internal static string[] BagsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_bags_male_zh.txt"),
          "en" or _ => GetStringList("swsh_bags_male_en.txt")
        };
      }
    }

    internal static string[] BagsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_bags_female_zh.txt"),
          "en" or _ => GetStringList("swsh_bags_female_en.txt")
        };
      }
    }

    internal static string Hats => Language.Hats;

    internal static string[] HatsList(int gender) {
      return gender switch {
        0 => HatsListMale,
        1 => HatsListFemale,
        _ => []
      };
    }

    internal static string[] HatsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_hats_male_zh.txt"),
          "en" or _ => GetStringList("swsh_hats_male_en.txt")
        };
      }
    }

    internal static string[] HatsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_hats_female_zh.txt"),
          "en" or _ => GetStringList("swsh_hats_female_en.txt")
        };
      }
    }

    internal static string Glasses => Language.Glasses;

    internal static string[] GlassesList(int gender) {
      return gender switch {
        0 => GlassesListMale,
        1 => GlassesListFemale,
        _ => []
      };
    }

    internal static string[] GlassesListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_glasses_male_zh.txt"),
          "en" or _ => GetStringList("swsh_glasses_male_en.txt")
        };
      }
    }

    internal static string[] GlassesListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_glasses_female_zh.txt"),
          "en" or _ => GetStringList("swsh_glasses_female_en.txt")
        };
      }
    }

    internal static string Gloves {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "手套",
          "en" or _ => "Gloves"
        };
      }
    }

    internal static string[] GlovesList(int gender) {
      return gender switch {
        0 => GlovesListMale,
        1 => GlovesListFemale,
        _ => []
      };
    }

    internal static string[] GlovesListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_gloves_male_zh.txt"),
          "en" or _ => GetStringList("swsh_gloves_male_en.txt")
        };
      }
    }

    internal static string[] GlovesListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("swsh_gloves_female_zh.txt"),
          "en" or _ => GetStringList("swsh_gloves_female_en.txt")
        };
      }
    }
  }

  internal static class BDSP {
    internal static string FashionEveryday {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "平常",
          "en" or _ => "Everyday"
        };
      }
    }

    internal static string FashionPikachu {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "皮卡丘卫衣",
          "en" or _ => "Pikachu"
        };
      }
    }

    internal static string FashionPlatinum {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "白金",
          "en" or _ => "Platinum"
        };
      }
    }

    internal static string FashionOveralls {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "工装服",
          "en" or _ => "Overalls"
        };
      }
    }

    internal static string FashionEevee {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "伊布刺绣夹克",
          "en" or _ => "Eevee"
        };
      }
    }

    internal static string FashionGengar {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "耿鬼刺绣夹克",
          "en" or _ => "Gengar"
        };
      }
    }

    internal static string FashionCyber {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "赛博",
          "en" or _ => "Cyber"
        };
      }
    }

    internal static string FashionSummer {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "夏季",
          "en" or _ => "Summer"
        };
      }
    }

    internal static string FashionWinter {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "冬季",
          "en" or _ => "Winter"
        };
      }
    }

    internal static string FashionSpring {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "春季",
          "en" or _ => "Spring"
        };
      }
    }

    internal static string FashionCasual {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "运动",
          "en" or _ => "Casual"
        };
      }
    }

    internal static string FashionLeather {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "皮夹克",
          "en" or _ => "Leather"
        };
      }
    }
  }

  internal static class LA {
    internal static string Hats => Language.Hats;

    internal static string[] HatsList(int gender) {
      return gender switch {
        0 => HatsListMale,
        1 => HatsListFemale,
        _ => []
      };
    }


    internal static string[] HatsListMale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_hats_male_zh.txt"),
          "en" or _ => GetStringList("la_hats_male_en.txt")
        };
      }
    }

    internal static string[] HatsListFemale {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_hats_female_zh.txt"),
          "en" or _ => GetStringList("la_hats_female_en.txt")
        };
      }
    }

    internal static string Tops => Language.Tops;

    internal static string[] TopsList {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_tops_zh.txt"),
          "en" or _ => GetStringList("la_tops_en.txt")
        };
      }
    }

    internal static string Bottoms => Language.Bottoms;

    internal static string[] BottomsList {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_bottoms_zh.txt"),
          "en" or _ => GetStringList("la_bottoms_en.txt")
        };
      }
    }

    internal static string Uniforms {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "套装",
          "en" or _ => "Uniforms"
        };
      }
    }

    internal static string[] UniformsList {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_uniforms_zh.txt"),
          "en" or _ => GetStringList("la_uniforms_en.txt")
        };
      }
    }

    internal static string Shoes => Language.Shoes;

    internal static string[] ShoesList {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_shoes_zh.txt"),
          "en" or _ => GetStringList("la_shoes_en.txt")
        };
      }
    }

    internal static string Glasses => Language.Glasses;

    internal static string[] GlassesList {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => GetStringList("la_glasses_zh.txt"),
          "en" or _ => GetStringList("la_glasses_en.txt")
        };
      }
    }
  }

}
