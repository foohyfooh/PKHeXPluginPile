namespace PluginPile.Unmaintained.SwShEventEditor;

public static class Definitions {

  /// <summary>
  /// Which pattern was drawn for which regi, this should match the given regi
  /// </summary>
  public const uint KRegielekiOrRegidragoPattern = 0xCF90B39A;

  public const uint Playtime = 0x8CBBFD90;

  public static readonly Dictionary<string, uint> memkeys_FootprintPercentage = new Dictionary<string, uint>() {
    { "Cobalion", 0x4D50B655},
    { "Terrakion", 0x771E4c88},
    { "Virizion", 0xAD67A297}
  };

  public static readonly Dictionary<string, uint> memkeys_SwordsofJustice = new Dictionary<string, uint>() {
    { "Cobalion", 0xBB305227},
    { "Terrakion", 0x750C83A4},
    { "Virizion", 0x1A27DF2C},
    { "Keldeo", 0xA097DE31}
  };

  public static readonly Dictionary<string, uint> memkeys_Regis = new Dictionary<string, uint>() {
    { "Regirock", 0xEE3F84E6},
    { "Regice", 0xDAB3DD3A},
    { "Registeel", 0xEE1FD86E},
    { "Regigigas", 0xC4308A93},
    { "Regieleki", 0x4F4AEC32},
    { "Regidrago", 0x4F30F174}
  };

  public static readonly Dictionary<string, uint> memkeys_Birds = new Dictionary<string, uint>() {
    { "Galarian Articuno", 0x4CAB7DA6},
    { "Galarian Zapdos", 0x284CBECF},
    { "Galarian Moltres", 0xF1E493AA},
  };

  public static readonly Dictionary<string, uint> memkeys_Gifts = new Dictionary<string, uint>() {
    { "FSYS_PLAY_LETSGO_PIKACHU", 0x1C74460E},
    { "FSYS_PLAY_LETSGO_EEVEE", 0xC804E4AF},
    { "FE_SUB_037_PIKACHU_CLEAR", 0x9D95E9CA},
    { "FE_SUB_037_EEVEE_CLEAR", 0x855235FF},
    { "FE_SUB_005_CLEAR", 0xC41B40F7},
    { "z_d0901_BEBENOM", 0x4B3C9063},
    { "z_bt0101_POKE_NUL", 0x2AB6CECC},
    { "z_wr0301_i0401_COSMOG", 0x52F6F77F},
    { "z_t0101_i0202_MONSBALL", 0x178159E5}
  };

  public static readonly Dictionary<string, uint> memkeys_PokeCamp = new Dictionary<string, uint>() {
    { "FSYS_POKECAMP_OPEN_FRESH_BALL", 0xAFA33CBD},
    { "FSYS_POKECAMP_OPEN_HEAVY_BALL", 0xE49088C4},
    { "FSYS_POKECAMP_OPEN_YASURAGI_BALL", 0x45E850BE}, //soothe?
    { "FSYS_POKECAMP_OPEN_MIRROR_BALL", 0x9B6CD5A2},
    { "FSYS_POKECAMP_OPEN_OTAMA_BALL", 0xEA3E6881}, //tympole?
    { "FSYS_POKECAMP_OPEN_CHAMPION_BALL", 0x45FD94D6},

    { "FSYS_POKECAMP_OPEN_GOLDEN_KITCHENWARE", 0x72D4B15E},
    { "FSYS_POKECAMP_USE_GOLDEN_KITCHENWARE", 0x88FE6F97},
    { "SYS_WORK_POKECAMP_TENT_COLOR", 0x61952B51}
  };

  public static readonly Dictionary<string, uint> memkeys_CrownTundra_Misc = new Dictionary<string, uint>() {
    { "FE_CAPTURE_MIKARUGE", 0x11C12005},
    { "z_wr0321_SymbolEncountPokemonGimmickSpawner_WR03_Mikaruge", 0x1895E693},
    { "KPlayersInteractedOnline", 0x31A13425}
  };

  public static readonly Dictionary<string, uint> memkeys_MaxLairMisc = new Dictionary<string, uint>() {
    { "KMaxLairDisconnectStreak", 0x8EAEB8FF},
    { "KMaxLairEndlessStreak", 0x7F4B4B10},

    { "KMaxLairSpeciesID1Noted", 0x6F669A35},
    { "KMaxLairSpeciesID2Noted", 0x6F66951C},
    { "KMaxLairSpeciesID3Noted", 0x6F6696CF},

    { "KMaxLairPeoniaSpeciesHint", 0xF26B9151},

    { "KMaxLairRentalChoiceSeed", 0x0D74AA40},
  };


  public static class MaxLairExclusives {
    public static readonly List<string> Sword = new List<string>() {
      "Ho-oh",
      "Latios",
      "Groudon",
      "Dialga",
      "Tornadus",
      "Reshiram",
      "Xerneas"
    };

    public static readonly List<string> Shield = new List<string>() {
      "Lugia",
      "Latias",
      "Kyogre",
      "Palkia",
      "Thundurus",
      "Zekrom",
      "Yveltal"
    };
  }

  public static class NationalDex {
    private static readonly Dictionary<string, int> s_nationalDex = new Dictionary<string, int>() {
      { "None", 0 },
      { "Articuno", 144},
      { "Zapdos", 145},
      { "Moltres", 156},
      { "Mewtwo", 150},
      { "Raikou", 243},
      { "Entei", 244},
      { "Suicune", 245},
      { "Lugia", 249},
      { "Ho-oh", 250},
      { "Latias", 380},
      { "Latios", 381},
      { "Kyogre", 382},
      { "Groudon", 383},
      { "Rayquaza", 384},
      { "Uxie", 480},
      { "Mesprit", 481},
      { "Azelf", 482},
      { "Dialga", 483},
      { "Palkia", 484},
      { "Heatran", 485},
      { "Giratina", 487},
      { "Cresselia", 488},
      { "Tornadus", 641},
      { "Thundurus", 642},
      { "Reshiram", 643},
      { "Zekrom", 644},
      { "Landorus", 645},
      { "Kryurem", 646},
      { "Xerneas", 716},
      { "Yveltal", 717},
      { "Zygarde", 718},
      { "Tapu Koko", 785},
      { "Tapu Lele", 786},
      { "Tapu Bulu", 787},
      { "Tapu Fini", 788},
      { "Solgaleo", 791},
      { "Lunala", 792},
      { "Nihilego", 793},
      { "Buzzwole", 794 },
      { "Pheromosa", 795 },
      { "Xurkitree", 796 },
      { "Celesteela", 797 },
      { "Kartana", 798 },
      { "Guzzlord", 799 },
      { "Necrozma", 800 },
      { "Stakataka", 805 },
      { "Blacephalon", 806 }
    };

    public static int GetNameIndex(string name) => s_nationalDex.ToList().IndexOf(s_nationalDex.First(x => x.Key == name));
    public static int GetIDIndex(int id) => s_nationalDex.ToList().IndexOf(s_nationalDex.First(x => x.Value == id));

    public static bool ContainsID(int id) => s_nationalDex.ContainsValue(id);
    public static string GetName(int id) => s_nationalDex.Where(x => x.Value == id).First().Key;
    public static bool ContainsString(string name) => s_nationalDex.ContainsKey(name);
    public static int GetID(string name) => s_nationalDex[name];
  }

}
