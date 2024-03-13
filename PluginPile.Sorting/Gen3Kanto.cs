using PKHeX.Core;

namespace PluginPile.Sorting;
internal class Gen3Kanto : SortingBase {

  public static Func<PKM, IComparable>[] GetSortFunctions() {
    return Gen1Kanto.GetSortFunctions();
  }

}
