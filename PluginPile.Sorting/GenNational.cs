using PKHeX.Core;

namespace PluginPile.Sorting; 
internal class GenNational: SortingBase {

  private static double SortRegionalForms(PKM pkm) {
    Species species = (Species)pkm.Species;

    // Alolan Forms
    if (species == Species.Rattata && pkm.Form == 1) return 7;
    if (species == Species.Raticate && pkm.Form == 1) return 7;
    if (species == Species.Raichu && pkm.Form == 1) return 7;
    if (species == Species.Sandshrew && pkm.Form == 1) return 7;
    if (species == Species.Sandslash && pkm.Form == 1) return 7;
    if (species == Species.Vulpix && pkm.Form == 1) return 7;
    if (species == Species.Ninetales && pkm.Form == 1) return 7;
    if (species == Species.Diglett && pkm.Form == 1) return 7;
    if (species == Species.Dugtrio && pkm.Form == 1) return 7;
    if (species == Species.Meowth && pkm.Form == 1) return 7;
    if (species == Species.Persian && pkm.Form == 1) return 7;
    if (species == Species.Geodude && pkm.Form == 1) return 7;
    if (species == Species.Graveler && pkm.Form == 1) return 7;
    if (species == Species.Golem && pkm.Form == 1) return 7;
    if (species == Species.Grimer && pkm.Form == 1) return 7;
    if (species == Species.Muk && pkm.Form == 1) return 7;
    if (species == Species.Exeggutor && pkm.Form == 1) return 7;
    if (species == Species.Marowak && pkm.Form == 1) return 7;

    // Galarian Forms
    if (species == Species.Meowth && pkm.Form == 2) return 8;
    if (species == Species.Ponyta && pkm.Form == 1) return 8;
    if (species == Species.Rapidash && pkm.Form == 1) return 8;
    if (species == Species.Farfetchd && pkm.Form == 1) return 8;
    if (species == Species.Weezing && pkm.Form == 1) return 8;
    if (species == Species.MrMime && pkm.Form == 1) return 8;
    if (species == Species.Corsola && pkm.Form == 1) return 8;
    if (species == Species.Zigzagoon && pkm.Form == 1) return 8;
    if (species == Species.Linoone && pkm.Form == 1) return 8;
    if (species == Species.Darumaka && pkm.Form == 1) return 8;
    if (species == Species.Darmanitan && (pkm.Form == 2 || pkm.Form == 3)) return 8;
    if (species == Species.Yamask && pkm.Form == 1) return 8;
    if (species == Species.Stunfisk && pkm.Form == 1) return 8;
    if (species == Species.Slowpoke && pkm.Form == 1) return 8;
    if (species == Species.Slowbro && pkm.Form == 2) return 8;
    if (species == Species.Slowking && pkm.Form == 1) return 8;
    if (species == Species.Articuno && pkm.Form == 1) return 8;
    if (species == Species.Zapdos && pkm.Form == 1) return 8;
    if (species == Species.Moltres && pkm.Form == 1) return 8;

    // Hisuian Forms
    if (species == Species.Growlithe && pkm.Form == 1) return 8.5;
    if (species == Species.Arcanine && pkm.Form == 1) return 8.5;
    if (species == Species.Voltorb && pkm.Form == 1) return 8.5;
    if (species == Species.Electrode && pkm.Form == 1) return 8.5;
    if (species == Species.Typhlosion && pkm.Form == 1) return 8.5;
    if (species == Species.Qwilfish && pkm.Form == 1) return 8.5;
    if (species == Species.Sneasel && pkm.Form == 1) return 8.5;
    if (species == Species.Samurott && pkm.Form == 1) return 8.5;
    if (species == Species.Lilligant && pkm.Form == 1) return 8.5;
    if (species == Species.Basculin && pkm.Form == 2) return 8.5;
    if (species == Species.Zorua && pkm.Form == 1) return 8.5;
    if (species == Species.Zoroark && pkm.Form == 1) return 8.5;
    if (species == Species.Braviary && pkm.Form == 1) return 8.5;
    if (species == Species.Sliggoo && pkm.Form == 1) return 8.5;
    if (species == Species.Goodra && pkm.Form == 1) return 8.5;
    if (species == Species.Avalugg && pkm.Form == 1) return 8.5;
    if (species == Species.Decidueye && pkm.Form == 1) return 8.5;

    // Paldean Forms
    if (species == Species.Tauros && 1 <= pkm.Form && pkm.Form <= 3) return 9;
    if (species == Species.Wooper && pkm.Form == 1) return 9;
    if (species == Species.Ursaluna && pkm.Form == 1) return 9;

    // Handle Dexes
    // Gen 1 Kanto
    if (  1 <= pkm.Species && pkm.Species <=  151) return 1;
    // Gen 2 Johto
    if (152 <= pkm.Species && pkm.Species <=  251) return 2;
    // Gen 3 Hoenn
    if (252 <= pkm.Species && pkm.Species <=  386) return 3;
    // Gen 4 Sinnoh
    if (387 <= pkm.Species && pkm.Species <=  493) return 4;
    // Gen 5 Unova
    if (494 <= pkm.Species && pkm.Species <=  649) return 5;
    // Gen 6 Kalos
    if (650 <= pkm.Species && pkm.Species <=  721) return 6;
    // Gen 7 Alola
    if (722 <= pkm.Species && pkm.Species <=  809) return 7;
    // Gen 8 Galar
    if (810 <= pkm.Species && pkm.Species <=  898) return 8;
    // Gen 8 Hisui
    if (899 <= pkm.Species && pkm.Species <=  905) return 8.5;
    // Gen 9 Paldea
    if (906 <= pkm.Species && pkm.Species <= 1017) return 9;

    // Default Value
    return double.MaxValue;
  }

  public static Func<PKM, IComparable>[] GetNationalDexWithRegionalFormsSortFunctions() {
    Func<PKM, IComparable>[] sortFunctions = [
      p => SortRegionalForms(p),
      p => p.Species,
    ];
    return AddSortOptions(sortFunctions);
  }

}
