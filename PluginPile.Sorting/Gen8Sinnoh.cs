using PKHeX.Core;

namespace PluginPile.Sorting;
internal class Gen8Sinnoh : SortingBase {

  public static Func<PKM, IComparable>[] GetSortFunctions() {
    return Gen4Sinnoh.GetDPSortFunctions();
  }

}
