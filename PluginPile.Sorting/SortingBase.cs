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
    PluginSettings.SortOptions[] options = PluginSettings.Default.AdditionalSortOptions;
    if (options == null) return sortFunctions;
    for (int i = 0; i < options.Length; i++) {
      switch (options[i]) {
        case PluginSettings.SortOptions.LevelAsc:
          sortFunctions = [.. sortFunctions, p => p.CurrentLevel];
          break;
        case PluginSettings.SortOptions.LevelDesc:
          sortFunctions = [.. sortFunctions, p => -p.CurrentLevel];
          break;
        case PluginSettings.SortOptions.MetDateAsc:
          sortFunctions = [.. sortFunctions, p => p.MetDate!];
          break;
        case PluginSettings.SortOptions.ShinyAsc:
          sortFunctions = [.. sortFunctions, p => p.IsShiny];
          break;
        case PluginSettings.SortOptions.ShinyDesc:
          sortFunctions = [.. sortFunctions, p => !p.IsShiny];
          break;
        case PluginSettings.SortOptions.GenderAsc:
          sortFunctions = [.. sortFunctions, p => p.Gender];
          break;
        case PluginSettings.SortOptions.GenderDesc:
          sortFunctions = [.. sortFunctions, p => -p.Gender];
          break;
        default:
          break;
      }
    }

    return sortFunctions;
  }

  protected static Func<PKM, IComparable>[] GenerateSortingFunctions(params Dictionary<Species, PositionForms>[] dexes) {
    Func<PKM, IComparable>[] sortFunctions = [p => SortPokemon(dexes, p)];
    return AddSortOptions(sortFunctions);
  }

}
