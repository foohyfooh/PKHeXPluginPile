using PKHeX.Core;

namespace PluginPile.RentalViewer;
internal class Language {

  public static string MenuItemName {
    get {
      return GameInfo.CurrentLanguage switch {
        "en" or _ => "View Rentals"
      };
    }
  }

}
