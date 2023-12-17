using PKHeX.Core;

namespace PluginPile.Sorting;
internal class Gen8_Sinnoh : SortingBase {

  public static Func<PKM, IComparable>[] GetSortFunctions() {
    return Gen4_Sinnoh.GetDPSortFunctions();
  }

}
