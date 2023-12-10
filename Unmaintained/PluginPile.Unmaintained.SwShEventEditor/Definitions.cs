using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.Unmaintained.SwShEventEditor;

public static class Definitions {

  public const uint Playtime = 0x8CBBFD90;

  public static readonly Block DojoWattDonationProgress = 0x0CBEB855;
  public static readonly Block DojoWattDonationTotal = 0xC7161487;
  public static readonly Block DojoHairStylistAvailable = 0xE02A722C;
  public static readonly Block DojoBrokenRotomiDisappeared = 0x60E04225;
  public static readonly Block DojoRotomiDisappeared = 0x82E071A0;
  public static readonly Block DojoTableDisappeared = 0x3D83DC85;
  public static readonly Block DojoDrinksVendingMachineDisappeared = 0x209CF1DC;
  public static readonly Block DojoVitaminsVendingMachineDisappeared = 0x5C3ED669;
  public static readonly Block CanBattleHoney = 0xC0423F6D;
  public static readonly Block BattledHoneyToday = 0xDDA3F583;

  public static readonly Block SwordsOfJusticeQuestStatus = 0x4DBB9B79;
  public static readonly Block SwordsOfJusticeQuestProgress = 0xCB135C68;

  public static readonly Dictionary<Species, uint> SwordsOfJusticeProgressKeys = new Dictionary<Species, uint>() {
    {Species.Cobalion, 0xC35F6291},
    {Species.Terrakion, 0x03C69A96},
    {Species.Virizion, 0xB98F962B},
    {Species.Keldeo, 0x9A39C8FC}
  };

  public static readonly Dictionary<Species, uint> SwordsOfJusticeDisappearedKeys = new Dictionary<Species, uint>() {
    {Species.Cobalion, 0xBB305227},
    {Species.Terrakion, 0x750C83A4},
    {Species.Virizion, 0x1A27DF2C},
    {Species.Keldeo, 0xA097DE31}
  };

  public static readonly Dictionary<Species, uint> SwordsOfJusticeFootprintPercentageKeys = new Dictionary<Species, uint>() {
    {Species.Cobalion, 0x4D50B655},
    {Species.Terrakion, 0x771E4c88},
    {Species.Virizion, 0xAD67A297}
  };

  public const uint KRegielekiOrRegidragoPattern = 0xCF90B39A;

  public static readonly Dictionary<Species, uint> RegisKeys = new Dictionary<Species, uint>() {
    { Species.Regirock, 0xEE3F84E6},
    { Species.Regice, 0xDAB3DD3A},
    { Species.Registeel, 0xEE1FD86E},
    { Species.Regigigas, 0xC4308A93},
    { Species.Regieleki, 0x4F4AEC32},
    { Species.Regidrago, 0x4F30F174}
  };

  public static readonly Dictionary<Species, uint> BirdsKeys = new Dictionary<Species, uint>() {
    { Species.Articuno, 0x4CAB7DA6},
    { Species.Zapdos, 0x284CBECF},
    { Species.Moltres, 0xF1E493AA},
  };

  public static readonly Dictionary<string, uint> GiftsKeys = new Dictionary<string, uint>() {
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

  public static readonly Dictionary<string, uint> PokeCampKeys = new Dictionary<string, uint>() {
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

  public static readonly Dictionary<string, uint> CrownTundraMiscKeys = new Dictionary<string, uint>() {
    { "FE_CAPTURE_MIKARUGE", 0x11C12005},
    { "z_wr0321_SymbolEncountPokemonGimmickSpawner_WR03_Mikaruge", 0x1895E693},
    { "KPlayersInteractedOnline", 0x31A13425}
  };

  public static readonly Dictionary<string, uint> MaxLairMiscKeys = new Dictionary<string, uint>() {
    { "KMaxLairDisconnectStreak", 0x8EAEB8FF},
    { "KMaxLairEndlessStreak", 0x7F4B4B10},

    { "KMaxLairSpeciesID1Noted", 0x6F669A35},
    { "KMaxLairSpeciesID2Noted", 0x6F66951C},
    { "KMaxLairSpeciesID3Noted", 0x6F6696CF},

    { "KMaxLairPeoniaSpeciesHint", 0xF26B9151},

    { "KMaxLairRentalChoiceSeed", 0x0D74AA40},
  };


  public static class MaxLairExclusives {
    public static readonly List<string> Sword = [
      "Ho-oh",
      "Latios",
      "Groudon",
      "Dialga",
      "Tornadus",
      "Reshiram",
      "Xerneas"
    ];

    public static readonly List<string> Shield = [
      "Lugia",
      "Latias",
      "Kyogre",
      "Palkia",
      "Thundurus",
      "Zekrom",
      "Yveltal"
    ];
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
