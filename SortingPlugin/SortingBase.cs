using PKHeX.Core;

namespace PluginPile.SortingPlugin {
  class SortingBase {
    
    private static (int, int, int) ProduceComparable(Dictionary<Species, PositionForms>[] dexes, PKM pkm) {
      for (int i = 0; i < dexes.Length; i++) {
        Species species = (Species)pkm.Species;
        if (dexes[i].ContainsKey(species) && ((PluginSettings.Default.CheckForms && dexes[i][species].Forms.Contains(pkm.Form)) || !PluginSettings.Default.CheckForms)) {
          return (i, dexes[i][species].Position, pkm.Form);
        }
      }
      return (dexes.Length, pkm.Species, pkm.Form);
    }

    protected static Func<PKM, IComparable>[] GenerateSortingFunctions(params Dictionary<Species, PositionForms>[] dexes) {
      Func<PKM, IComparable>[] sortFunctions = new Func<PKM, IComparable>[] {
        (PKM p) => ProduceComparable(dexes, p),
      };
      return sortFunctions;
    }

  }
}
