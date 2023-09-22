using PKHeX.Core;

namespace PluginPile.SortingPlugin {
  class Gen6_Kalos : SortingBase {

    private static readonly Dictionary<Species, PositionForms> CentralKalosDex = new Dictionary<Species, PositionForms>() {
      {Species.Chespin, 1},
      {Species.Quilladin, 2},
      {Species.Chesnaught, 3},
      {Species.Fennekin, 4},
      {Species.Braixen, 5},
      {Species.Delphox, 6},
      {Species.Froakie, 7},
      {Species.Frogadier, 8},
      {Species.Greninja, 9},
      {Species.Bunnelby, 10},
      {Species.Diggersby, 11},
      {Species.Zigzagoon, 12},
      {Species.Linoone, 13},
      {Species.Fletchling, 14},
      {Species.Fletchinder, 15},
      {Species.Talonflame, 16},
      {Species.Pidgey, 17},
      {Species.Pidgeotto, 18},
      {Species.Pidgeot, 19},
      {Species.Scatterbug, (20, 0..19)},
      {Species.Spewpa, (21, 0..19)},
      {Species.Vivillon, (22, 0..19)},
      {Species.Caterpie, 23},
      {Species.Metapod, 24},
      {Species.Butterfree, 25},
      {Species.Weedle, 26},
      {Species.Kakuna, 27},
      {Species.Beedrill, 28},
      {Species.Pansage, 29},
      {Species.Simisage, 30},
      {Species.Pansear, 31},
      {Species.Simisear, 32},
      {Species.Panpour, 33},
      {Species.Simipour, 34},
      {Species.Pichu, 35},
      {Species.Pikachu, 36},
      {Species.Raichu, 37},
      {Species.Bidoof, 38},
      {Species.Bibarel, 39},
      {Species.Dunsparce, 40},
      {Species.Azurill, 41},
      {Species.Marill, 42},
      {Species.Azumarill, 43},
      {Species.Burmy, (44, 0..2)},
      {Species.Wormadam, (45, 0..2)},
      {Species.Mothim, (46, 0..2)},
      {Species.Surskit, 47},
      {Species.Masquerain, 48},
      {Species.Magikarp, 49},
      {Species.Gyarados, 50},
      {Species.Corphish, 51},
      {Species.Crawdaunt, 52},
      {Species.Goldeen, 53},
      {Species.Seaking, 54},
      {Species.Carvanha, 55},
      {Species.Sharpedo, 56},
      {Species.Litleo, 57},
      {Species.Pyroar, 58},
      {Species.Psyduck, 59},
      {Species.Golduck, 60},
      {Species.Farfetchd, 61},
      {Species.Riolu, 62},
      {Species.Lucario, 63},
      {Species.Ralts, 64},
      {Species.Kirlia, 65},
      {Species.Gardevoir, 66},
      {Species.Gallade, 67},
      {Species.Flabébé, (68, 0..4)},
      {Species.Floette, (69, 0..5)},
      {Species.Florges, (70, 0..4)},
      {Species.Budew, 71},
      {Species.Roselia, 72},
      {Species.Roserade, 73},
      {Species.Ledyba, 74},
      {Species.Ledian, 75},
      {Species.Combee, 76},
      {Species.Vespiquen, 77},
      {Species.Skitty, 78},
      {Species.Delcatty, 79},
      {Species.Bulbasaur, 80},
      {Species.Ivysaur, 81},
      {Species.Venusaur, 82},
      {Species.Charmander, 83},
      {Species.Charmeleon, 84},
      {Species.Charizard, 85},
      {Species.Squirtle, 86},
      {Species.Wartortle, 87},
      {Species.Blastoise, 88},
      {Species.Skiddo, 89},
      {Species.Gogoat, 90},
      {Species.Pancham, 91},
      {Species.Pangoro, 92},
      {Species.Furfrou, (93, 0..9)},
      {Species.Doduo, 94},
      {Species.Dodrio, 95},
      {Species.Plusle, 96},
      {Species.Minun, 97},
      {Species.Gulpin, 98},
      {Species.Swalot, 99},
      {Species.Scraggy, 100},
      {Species.Scrafty, 101},
      {Species.Abra, 102},
      {Species.Kadabra, 103},
      {Species.Alakazam, 104},
      {Species.Oddish, 105},
      {Species.Gloom, 106},
      {Species.Vileplume, 107},
      {Species.Bellossom, 108},
      {Species.Sentret, 109},
      {Species.Furret, 110},
      {Species.Nincada, 111},
      {Species.Ninjask, 112},
      {Species.Shedinja, 113},
      {Species.Espurr, 114},
      {Species.Meowstic, (115, 0..1)},
      {Species.Kecleon, 116},
      {Species.Honedge, 117},
      {Species.Doublade, 118},
      {Species.Aegislash, (119, 0..1)},
      {Species.Venipede, 120},
      {Species.Whirlipede, 121},
      {Species.Scolipede, 122},
      {Species.Audino, 123},
      {Species.Smeargle, 124},
      {Species.Croagunk, 125},
      {Species.Toxicroak, 126},
      {Species.Ducklett, 127},
      {Species.Swanna, 128},
      {Species.Spritzee, 129},
      {Species.Aromatisse, 130},
      {Species.Swirlix, 131},
      {Species.Slurpuff, 132},
      {Species.Volbeat, 133},
      {Species.Illumise, 134},
      {Species.Hoppip, 135},
      {Species.Skiploom, 136},
      {Species.Jumpluff, 137},
      {Species.Munchlax, 138},
      {Species.Snorlax, 139},
      {Species.Whismur, 140},
      {Species.Loudred, 141},
      {Species.Exploud, 142},
      {Species.Meditite, 143},
      {Species.Medicham, 144},
      {Species.Zubat, 145},
      {Species.Golbat, 146},
      {Species.Crobat, 147},
      {Species.Axew, 148},
      {Species.Fraxure, 149},
      {Species.Haxorus, 150},
      {Species.Diancie, 151},
      {Species.Hoopa, (152, 0..1)},
      {Species.Volcanion, 153},
    };

    private static readonly Dictionary<Species, PositionForms> CostalKalosDex = new Dictionary<Species, PositionForms>() {
      {Species.Drifloon, 1},
      {Species.Drifblim, 2},
      {Species.Mienfoo, 3},
      {Species.Mienshao, 4},
      {Species.Zangoose, 5},
      {Species.Seviper, 6},
      {Species.Spoink, 7},
      {Species.Grumpig, 8},
      {Species.Absol, 9},
      {Species.Inkay, 10},
      {Species.Malamar, 11},
      {Species.Lunatone, 12},
      {Species.Solrock, 13},
      {Species.Bagon, 14},
      {Species.Shelgon, 15},
      {Species.Salamence, 16},
      {Species.Wingull, 17},
      {Species.Pelipper, 18},
      {Species.Taillow, 19},
      {Species.Swellow, 20},
      {Species.Binacle, 21},
      {Species.Barbaracle, 22},
      {Species.Dwebble, 23},
      {Species.Crustle, 24},
      {Species.Tentacool, 25},
      {Species.Tentacruel, 26},
      {Species.Wailmer, 27},
      {Species.Wailord, 28},
      {Species.Luvdisc, 29},
      {Species.Skrelp, 30},
      {Species.Dragalge, 31},
      {Species.Clauncher, 32},
      {Species.Clawitzer, 33},
      {Species.Staryu, 34},
      {Species.Starmie, 35},
      {Species.Shellder, 36},
      {Species.Cloyster, 37},
      {Species.Qwilfish, 38},
      {Species.Horsea, 39},
      {Species.Seadra, 40},
      {Species.Kingdra, 41},
      {Species.Relicanth, 42},
      {Species.Sandile, 43},
      {Species.Krokorok, 44},
      {Species.Krookodile, 45},
      {Species.Helioptile, 46},
      {Species.Heliolisk, 47},
      {Species.Hippopotas, 48},
      {Species.Hippowdon, 49},
      {Species.Rhyhorn, 50},
      {Species.Rhydon, 51},
      {Species.Rhyperior, 52},
      {Species.Onix, 53},
      {Species.Steelix, 54},
      {Species.Woobat, 55},
      {Species.Swoobat, 56},
      {Species.Machop, 57},
      {Species.Machoke, 58},
      {Species.Machamp, 59},
      {Species.Cubone, 60},
      {Species.Marowak, 61},
      {Species.Kangaskhan, 62},
      {Species.Mawile, 63},
      {Species.Tyrunt, 64},
      {Species.Tyrantrum, 65},
      {Species.Amaura, 66},
      {Species.Aurorus, 67},
      {Species.Aerodactyl, 68},
      {Species.Ferroseed, 69},
      {Species.Ferrothorn, 70},
      {Species.Snubbull, 71},
      {Species.Granbull, 72},
      {Species.Electrike, 73},
      {Species.Manectric, 74},
      {Species.Houndour, 75},
      {Species.Houndoom, 76},
      {Species.Eevee, 77},
      {Species.Vaporeon, 78},
      {Species.Jolteon, 79},
      {Species.Flareon, 80},
      {Species.Espeon, 81},
      {Species.Umbreon, 82},
      {Species.Leafeon, 83},
      {Species.Glaceon, 84},
      {Species.Sylveon, 85},
      {Species.Emolga, 86},
      {Species.Yanma, 87},
      {Species.Yanmega, 88},
      {Species.Hawlucha, 89},
      {Species.Sigilyph, 90},
      {Species.Golett, 91},
      {Species.Golurk, 92},
      {Species.Nosepass, 93},
      {Species.Probopass, 94},
      {Species.Makuhita, 95},
      {Species.Hariyama, 96},
      {Species.Throh, 97},
      {Species.Sawk, 98},
      {Species.Starly, 99},
      {Species.Staravia, 100},
      {Species.Staraptor, 101},
      {Species.Stunky, 102},
      {Species.Skuntank, 103},
      {Species.NidoranF, 104},
      {Species.Nidorina, 105},
      {Species.Nidoqueen, 106},
      {Species.NidoranM, 107},
      {Species.Nidorino, 108},
      {Species.Nidoking, 109},
      {Species.Dedenne, 110},
      {Species.Chingling, 111},
      {Species.Chimecho, 112},
      {Species.MimeJr, 113},
      {Species.MrMime, 114},
      {Species.Solosis, 115},
      {Species.Duosion, 116},
      {Species.Reuniclus, 117},
      {Species.Wynaut, 118},
      {Species.Wobbuffet, 119},
      {Species.Roggenrola, 120},
      {Species.Boldore, 121},
      {Species.Gigalith, 122},
      {Species.Sableye, 123},
      {Species.Carbink, 124},
      {Species.Tauros, 125},
      {Species.Miltank, 126},
      {Species.Mareep, 127},
      {Species.Flaaffy, 128},
      {Species.Ampharos, 129},
      {Species.Pinsir, 130},
      {Species.Heracross, 131},
      {Species.Pachirisu, 132},
      {Species.Slowpoke, 133},
      {Species.Slowbro, 134},
      {Species.Slowking, 135},
      {Species.Exeggcute, 136},
      {Species.Exeggutor, 137},
      {Species.Chatot, 138},
      {Species.Mantyke, 139},
      {Species.Mantine, 140},
      {Species.Clamperl, 141},
      {Species.Huntail, 142},
      {Species.Gorebyss, 143},
      {Species.Remoraid, 144},
      {Species.Octillery, 145},
      {Species.Corsola, 146},
      {Species.Chinchou, 147},
      {Species.Lanturn, 148},
      {Species.Alomomola, 149},
      {Species.Lapras, 150},
      {Species.Articuno, 151},
      {Species.Zapdos, 152},
      {Species.Moltres, 153},
    };

    private static readonly Dictionary<Species, PositionForms> MountainKalosDex = new Dictionary<Species, PositionForms>() {
      {Species.Diglett, 1},
      {Species.Dugtrio, 2},
      {Species.Trapinch, 3},
      {Species.Vibrava, 4},
      {Species.Flygon, 5},
      {Species.Gible, 6},
      {Species.Gabite, 7},
      {Species.Garchomp, 8},
      {Species.Geodude, 9},
      {Species.Graveler, 10},
      {Species.Golem, 11},
      {Species.Slugma, 12},
      {Species.Magcargo, 13},
      {Species.Shuckle, 14},
      {Species.Skorupi, 15},
      {Species.Drapion, 16},
      {Species.Wooper, 17},
      {Species.Quagsire, 18},
      {Species.Goomy, 19},
      {Species.Sliggoo, 20},
      {Species.Goodra, 21},
      {Species.Karrablast, 22},
      {Species.Escavalier, 23},
      {Species.Shelmet, 24},
      {Species.Accelgor, 25},
      {Species.Bellsprout, 26},
      {Species.Weepinbell, 27},
      {Species.Victreebel, 28},
      {Species.Carnivine, 29},
      {Species.Gastly, 30},
      {Species.Haunter, 31},
      {Species.Gengar, 32},
      {Species.Poliwag, 33},
      {Species.Poliwhirl, 34},
      {Species.Poliwrath, 35},
      {Species.Politoed, 36},
      {Species.Ekans, 37},
      {Species.Arbok, 38},
      {Species.Stunfisk, 39},
      {Species.Barboach, 40},
      {Species.Whiscash, 41},
      {Species.Purrloin, 42},
      {Species.Liepard, 43},
      {Species.Poochyena, 44},
      {Species.Mightyena, 45},
      {Species.Patrat, 46},
      {Species.Watchog, 47},
      {Species.Pawniard, 48},
      {Species.Bisharp, 49},
      {Species.Klefki, 50},
      {Species.Murkrow, 51},
      {Species.Honchkrow, 52},
      {Species.Foongus, 53},
      {Species.Amoonguss, 54},
      {Species.Lotad, 55},
      {Species.Lombre, 56},
      {Species.Ludicolo, 57},
      {Species.Buizel, 58},
      {Species.Floatzel, 59},
      {Species.Basculin , (60, 0..1)},
      {Species.Phantump, 61},
      {Species.Trevenant, 62},
      {Species.Pumpkaboo, (63, 0..3)},
      {Species.Gourgeist, (64, 0..3)},
      {Species.Litwick, 65},
      {Species.Lampent, 66},
      {Species.Chandelure, 67},
      {Species.Rotom, (68, 0..5)},
      {Species.Magnemite, 69},
      {Species.Magneton, 70},
      {Species.Magnezone, 71},
      {Species.Voltorb, 72},
      {Species.Electrode, 73},
      {Species.Trubbish, 74},
      {Species.Garbodor, 75},
      {Species.Swinub, 76},
      {Species.Piloswine, 77},
      {Species.Mamoswine, 78},
      {Species.Bergmite, 79},
      {Species.Avalugg, 80},
      {Species.Cubchoo, 81},
      {Species.Beartic, 82},
      {Species.Smoochum, 83},
      {Species.Jynx, 84},
      {Species.Vanillite, 85},
      {Species.Vanillish, 86},
      {Species.Vanilluxe, 87},
      {Species.Snover, 88},
      {Species.Abomasnow, 89},
      {Species.Delibird, 90},
      {Species.Sneasel, 91},
      {Species.Weavile, 92},
      {Species.Timburr, 93},
      {Species.Gurdurr, 94},
      {Species.Conkeldurr, 95},
      {Species.Torkoal, 96},
      {Species.Sandshrew, 97},
      {Species.Sandslash, 98},
      {Species.Aron, 99},
      {Species.Lairon, 100},
      {Species.Aggron, 101},
      {Species.Larvitar, 102},
      {Species.Pupitar, 103},
      {Species.Tyranitar, 104},
      {Species.Heatmor, 105},
      {Species.Durant, 106},
      {Species.Spinarak, 107},
      {Species.Ariados, 108},
      {Species.Spearow, 109},
      {Species.Fearow, 110},
      {Species.Cryogonal, 111},
      {Species.Skarmory, 112},
      {Species.Noibat, 113},
      {Species.Noivern, 114},
      {Species.Gligar, 115},
      {Species.Gliscor, 116},
      {Species.Hoothoot, 117},
      {Species.Noctowl, 118},
      {Species.Igglybuff, 119},
      {Species.Jigglypuff, 120},
      {Species.Wigglytuff, 121},
      {Species.Shuppet, 122},
      {Species.Banette, 123},
      {Species.Zorua, 124},
      {Species.Zoroark, 125},
      {Species.Gothita, 126},
      {Species.Gothorita, 127},
      {Species.Gothitelle, 128},
      {Species.Bonsly, 129},
      {Species.Sudowoodo, 130},
      {Species.Spinda, 131},
      {Species.Teddiursa, 132},
      {Species.Ursaring, 133},
      {Species.Lickitung, 134},
      {Species.Lickilicky, 135},
      {Species.Scyther, 136},
      {Species.Scizor, 137},
      {Species.Ditto, 138},
      {Species.Swablu, 139},
      {Species.Altaria, 140},
      {Species.Druddigon, 141},
      {Species.Deino, 142},
      {Species.Zweilous, 143},
      {Species.Hydreigon, 144},
      {Species.Dratini, 145},
      {Species.Dragonair, 146},
      {Species.Dragonite, 147},
      {Species.Xerneas, 148},
      {Species.Yveltal, 149},
      {Species.Zygarde, (150, 0..2)},
      {Species.Mewtwo, 151},
    };

    public static Func<PKM, IComparable>[] GetCentralDexSortFunctions() {
      return GenerateSortingFunctions(CentralKalosDex);
    }

    public static Func<PKM, IComparable>[] GetCostalDexSortFunctions() {
      return GenerateSortingFunctions(CostalKalosDex);
    }

    public static Func<PKM, IComparable>[] GetMountainDexSortFunctions() {
      return GenerateSortingFunctions(MountainKalosDex);
    }

    public static Func<PKM, IComparable>[] GetSortFunctions() {
      return GenerateSortingFunctions(CentralKalosDex, CostalKalosDex, MountainKalosDex);
    }

  }
}
