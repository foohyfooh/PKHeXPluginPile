using PKHeX.Core;

namespace PluginPile.SortingPlugin {
  class SortingBase {
    
    private static (int, int, int) ProduceComparable(Dictionary<SpeciesForm, int>[] dexes, PKM pkm) {
      for (int i = 0; i < dexes.Length; i++) {
        SpeciesForm speciesForm = (pkm.Species, pkm.Form);
        if (dexes[i].ContainsKey(speciesForm))
          return (i, dexes[i][speciesForm], pkm.Form);
      }
      return (dexes.Length, pkm.Species, pkm.Form);
    }

    protected static Func<PKM, IComparable>[] GenerateSortingFunctions(params Dictionary<SpeciesForm, int>[] dexes) {
      Func<PKM, IComparable>[] sortFunctions = new Func<PKM, IComparable>[] {
        (PKM p) => ProduceComparable(dexes, p),
      };
      return sortFunctions;
    }

  }
}
