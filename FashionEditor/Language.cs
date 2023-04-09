using PKHeX.Core;

namespace PluginPile.FashionEditor {
  internal static class Language {

    internal static string Cancel => Common.Language.Cancel;

    internal static string Item {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "时装",
          "en" or _ => "Item"
        };
      }
    }

    internal static string Title {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "服装插件",
          "en" or _ => "Fashion Editor"
        };
      }
    }

    internal static string Save => Common.Language.Save;

    internal static string Unlocked {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh" => "解锁",
          "en" or _ => "Unlocked"
        };
      }
    }

    internal static string Unused => Common.Language.Unused;

    private static string[] GetStringList(string filename) =>
      Common.Language.GetStringList(typeof(FashionEditor).Assembly, nameof(FashionEditor), filename);

    internal static class BDSP {
      internal static string FashionEveryday {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "平常",
            "en" or _ => "Everyday"
          };
        }
      }

      internal static string FashionPikachu {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "皮卡丘卫衣",
            "en" or _ => "Pikachu"
          };
        }
      }

      internal static string FashionPlatinum {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "白金",
            "en" or _ => "Platinum"
          };
        }
      }

      internal static string FashionOveralls {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "工装服",
            "en" or _ => "Overalls"
          };
        }
      }

      internal static string FashionEevee {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "伊布刺绣夹克",
            "en" or _ => "Eevee"
          };
        }
      }

      internal static string FashionGengar {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "耿鬼刺绣夹克",
            "en" or _ => "Gengar"
          };
        }
      }

      internal static string FashionCyber {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "赛博",
            "en" or _ => "Cyber"
          };
        }
      }

      internal static string FashionSummer {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "夏季",
            "en" or _ => "Summer"
          };
        }
      }

      internal static string FashionWinter {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "冬季",
            "en" or _ => "Winter"
          };
        }
      }

      internal static string FashionSpring {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "春季",
            "en" or _ => "Spring"
          };
        }
      }

      internal static string FashionCasual {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "运动",
            "en" or _ => "Casual"
          };
        }
      }

      internal static string FashionLeather {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "皮夹克",
            "en" or _ => "Leather"
          };
        }
      }
    }

    internal static class LA {
      internal static string Hats {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "头饰",
            "en" or _ => "Hats"
          };
        }
      }

      internal static string[] HatsList {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => GetStringList("la_hats_zh.txt"),
            "en" or _ => GetStringList("la_hats_en.txt")
          };
        }
      }

      internal static string Tops {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "上装",
            "en" or _ => "Tops"
          };
        }
      }

      internal static string[] TopsList {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => GetStringList("la_tops_zh.txt"),
            "en" or _ => GetStringList("la_tops_en.txt")
          };
        }
      }

      internal static string Bottoms {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "下装",
            "en" or _ => "Bottoms"
          };
        }
      }

      internal static string[] BottomsList {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => GetStringList("la_bottoms_zh.txt"),
            "en" or _ => GetStringList("la_bottoms_en.txt")
          };
        }
      }

      internal static string Uniforms {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "套装",
            "en" or _ => "Uniforms"
          };
        }
      }

      internal static string[] UniformsList {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => GetStringList("la_uniforms_zh.txt"),
            "en" or _ => GetStringList("la_uniforms_en.txt")
          };
        }
      }

      internal static string Shoes {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "鞋子",
            "en" or _ => "Shoes"
          };
        }
      }

      internal static string[] ShoesList {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => GetStringList("la_shoes_zh.txt"),
            "en" or _ => GetStringList("la_shoes_en.txt")
          };
        }
      }

      internal static string Glasses {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => "眼镜",
            "en" or _ => "Glasses"
          };
        }
      }

      internal static string[] GlassesList {
        get {
          return GameInfo.CurrentLanguage switch {
            "zh" => GetStringList("la_glasses_zh.txt"),
            "en" or _ => GetStringList("la_glasses_en.txt")
          };
        }
      }
    }

  }
}
