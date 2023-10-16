using PKHeX.Core;

namespace PluginPile.Sorting; 
class SortingBase {

  private static (int, int, int) SortPokemon(Dictionary<Species, PositionForms>[] dexes, PKM pkm) {
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
      (PKM p) => SortPokemon(dexes, p),
    };
    // TODO: Optimise Adding Options To Array
    switch(PluginSettings.Default.AdditionalSortOptions) {
      case PluginSettings.SortOptions.Level:
        sortFunctions = sortFunctions.Append((PKM p) => p.CurrentLevel).ToArray();
        break;
      case PluginSettings.SortOptions.MetDate:
        sortFunctions = sortFunctions.Append((PKM p) => p.MetDate!).ToArray();
        break;
      case PluginSettings.SortOptions.LevelThenMetDate:
        sortFunctions = sortFunctions.Append((PKM p) => p.CurrentLevel).Append((PKM p) => p.MetDate!).ToArray();
        break;
      case PluginSettings.SortOptions.MetDateThenLevel:
        sortFunctions = sortFunctions.Append((PKM p) => p.MetDate!).Append((PKM p) => p.CurrentLevel).ToArray();
        break;
    }
    return sortFunctions;
  }

}
