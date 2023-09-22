using PKHeX.Core;

namespace PluginPile.SortingPlugin {
  class Gen7_Kanto : Gen1_Kanto {

    private static readonly Dictionary<Species, PositionForms> extendedDex = new Dictionary<Species, PositionForms>(dex) {
      {Species.Meltan, 152},
      {Species.Melmetal, 153},
    };

    public static new Func<PKM, IComparable>[] GetSortFunctions() {
      return GenerateSortingFunctions(extendedDex);
    }

  }
}
