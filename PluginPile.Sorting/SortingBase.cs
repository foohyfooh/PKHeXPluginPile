using PKHeX.Core;

namespace PluginPile.Sorting;
internal abstract class SortingBase {

  private static (int, int, int) SortPokemon(Dictionary<Species, PositionForms>[] dexes, PKM pkm) {
    for (int i = 0; i < dexes.Length; i++) {
      Species species = (Species)pkm.Species;
      if (dexes[i].TryGetValue(species, out PositionForms? position) && ((PluginSettings.Default.CheckForms && position.Forms.Contains(pkm.Form)) || !PluginSettings.Default.CheckForms)) {
        return (i, position.Position, pkm.Form);
      }
    }
    return (dexes.Length, pkm.Species, pkm.Form);
  }

  protected static Func<PKM, IComparable>[] AddSortOptions(Func<PKM, IComparable>[] sortFunctions) {
    return PluginSettings.Default.AdditionalSortOptions switch {
      PluginSettings.SortOptions.Level => [.. sortFunctions, (PKM p) => p.CurrentLevel],
      PluginSettings.SortOptions.MetDate => [.. sortFunctions, (PKM p) => p.MetDate!],
      PluginSettings.SortOptions.LevelThenMetDate => [.. sortFunctions, (PKM p) => p.CurrentLevel, (PKM p) => p.MetDate!],
      PluginSettings.SortOptions.MetDateThenLevel => [.. sortFunctions, (PKM p) => p.MetDate!, (PKM p) => p.CurrentLevel],
      PluginSettings.SortOptions.None or _ => sortFunctions,
    };
  }

  protected static Func<PKM, IComparable>[] GenerateSortingFunctions(params Dictionary<Species, PositionForms>[] dexes) {
    Func<PKM, IComparable>[] sortFunctions = [(PKM p) => SortPokemon(dexes, p)];
    return AddSortOptions(sortFunctions);
  }

}
