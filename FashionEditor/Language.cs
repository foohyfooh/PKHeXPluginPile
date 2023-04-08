using PKHeX.Core;

namespace PluginPile.FashionEditor {
  internal static class Language {

    internal static string Cancel => Common.Language.Cancel;

    internal static string Item {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Item"
        };
      }
    }

    internal static string Title {
      get {
        return GameInfo.CurrentLanguage switch {
          "en" or _ => "Fashion Editor"
        };
      }
    }

    internal static string Save => Common.Language.Save;

    internal static string Unlocked {
      get {
        return GameInfo.CurrentLanguage switch {
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
            "en" or _ => "Everyday"
          };
        }
      }

      internal static string FashionPikachu {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Pikachu"
          };
        }
      }

      internal static string FashionPlatinum {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Platinum"
          };
        }
      }

      internal static string FashionOveralls {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Overalls"
          };
        }
      }

      internal static string FashionEevee {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Eevee"
          };
        }
      }

      internal static string FashionGengar {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Gengar"
          };
        }
      }

      internal static string FashionCyber {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Cyber"
          };
        }
      }

      internal static string FashionSummer {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Summer"
          };
        }
      }

      internal static string FashionWinter {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Winter"
          };
        }
      }

      internal static string FashionSpring {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Spring"
          };
        }
      }

      internal static string FashionCasual {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Casual"
          };
        }
      }

      internal static string FashionLeather {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Leather"
          };
        }
      }
    }

    internal static class LA {
      internal static string Hats {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Hats"
          };
        }
      }

      internal static string[] HatsList {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => GetStringList("la_hats_en.txt")
          };
        }
      }

      internal static string Tops {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Tops"
          };
        }
      }

      internal static string[] TopsList {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => GetStringList("la_tops_en.txt")
          };
        }
      }

      internal static string Bottoms {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Bottoms"
          };
        }
      }

      internal static string[] BottomsList {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => GetStringList("la_bottoms_en.txt")
          };
        }
      }

      internal static string Uniforms {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Uniforms"
          };
        }
      }

      internal static string[] UniformsList {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => GetStringList("la_uniforms_en.txt")
          };
        }
      }

      internal static string Shoes {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Shoes"
          };
        }
      }

      internal static string[] ShoesList {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => GetStringList("la_shoes_en.txt")
          };
        }
      }

      internal static string Glasses {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => "Glasses"
          };
        }
      }

      internal static string[] GlassesList {
        get {
          return GameInfo.CurrentLanguage switch {
            "en" or _ => GetStringList("la_glasses_en.txt")
          };
        }
      }
    }

  }
}
