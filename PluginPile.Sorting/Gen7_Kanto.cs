using PKHeX.Core;

namespace PluginPile.Sorting; 
class Gen7_Kanto : Gen1_Kanto {

  private static readonly Dictionary<Species, PositionForms> ExtendedDex = new Dictionary<Species, PositionForms>(Dex) {
    {Species.Meltan, 152},
    {Species.Melmetal, 153},
  };

  public static new Func<PKM, IComparable>[] GetSortFunctions() {
    return GenerateSortingFunctions(ExtendedDex);
  }

}
