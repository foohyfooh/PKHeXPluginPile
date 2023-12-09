using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShRaidTool;
public class RaidParameters {
  private static readonly string[] LocationNames = [
    "Axew's Eye",
    "Bridge Field",
    "Dappled Grove",
    "Dusty Bowl",
    "East Lake Axewell",
    "Giant's Cap",
    "Giant's Mirror",
    "Giant's Seat",
    "Hammerlocke Hills",
    "Lake of Outrage",
    "Motostoke Riverbank",
    "North Lake Miloch",
    "Rolling Fields",
    "South Lake Miloch",
    "Stony Wilderness",
    "Watchtower Ruins",
    "West Lake Axewell",
    //
    "Fields of Honor",
    "Soothing Wetlands",
    "Forest of Focus",
    "Challenge Beach",
    "Brawlers’ Cave",
    "Challenge Road",
    "Courageous Cavern",
    "Loop Lagoon",
    "Training Lowlands",
    //"Warm-Up Tunnel",
    "Potbottom Desert",
    "Workout Sea",
    "Stepping-Stone Sea",
    "Insular Sea",
    "Honeycalm Sea",
    "Honeycalm Island",
    "Slippery Slope",
    "Frostpoint Field",
    "Giant’s Bed",
    "Old Cemetery",
    "Snowslide Slope",
    "Path to the Peak",
    "Crown Shrine",
    "Giant’s Foot",
    "Frigid Sea",
    "Three-Point Pass",
    "Ballimere Lake",
    "Dyna Tree Hill"
  ];

  public readonly int Flags;
  public readonly RaidType Type;
  public readonly bool IsActive;
  public readonly bool IsEvent;
  public readonly bool IsRare;
  public readonly bool IsCrystal;
  public readonly bool IsWishingPiece;
  public readonly bool WattsHarvested;
  public readonly ulong Seed;
  public readonly int Index;
  public readonly int Stars;
  public readonly int RandRoll;
  public readonly int X;
  public readonly int Y;
  public readonly string Location;

  public RaidParameters(int index, RaidSpawnDetail detail, int location, int x, int y)
      : this(index, detail.Seed, detail.Stars, detail.RandRoll, detail.Flags, detail.DenType, location, x, y) { }

  public RaidParameters(int index, ulong seed, int stars, int randRoll, int flags, RaidType type, int location, int x, int y) {
    Seed = seed;
    Flags = flags;
    Type = type;
    IsActive = type > 0;
    IsCrystal = index == 16;
    IsRare = Type == RaidType.Rare || Type == RaidType.RareWish;
    IsEvent = IsActive && (Flags & 2) == 2;
    IsWishingPiece = Type == RaidType.CommonWish || Type == RaidType.RareWish;
    WattsHarvested = (Flags & 1) == 1;
    Stars = stars;
    RandRoll = randRoll;
    Index = index;
    Location = LocationNames[location];
    X = x;
    Y = y;
  }
}
