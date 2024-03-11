using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShRaidTool;
public class RaidManager {
  public readonly int BadgeCount;
  public readonly uint TID;
  public readonly uint SID;
  private readonly GameVersion Game;

  private readonly RaidTables _raidTables = new RaidTables();
  private readonly RaidParameters[] DenList;

  public RaidManager(SAV8SWSH SAV) {
    EventTableConverter.GetCurrentEventTable(SAV.Blocks, _raidTables);
    DenList = InitializeDenList(SAV.Blocks.RaidGalar, SAV.Blocks.RaidArmor, SAV.Blocks.RaidCrown);

    Game = SAV.Version;
    BadgeCount = Util.NumberOfSetBits(SAV.Badges);
    if (BadgeCount == 0)
      BadgeCount = 9; // enable all dens for basically no SaveFile loaded
    TID = SAV.TID16;
    SID = SAV.SID16;
  }

  private static RaidParameters[] InitializeDenList(RaidSpawnList8 raids, RaidSpawnList8 raidsArmor, RaidSpawnList8 raidsCrown) {
    // current release has these numbers bugged
    int NormalUsed = raids.CountUsed;
    int ArmorUsed = raidsArmor.CountUsed;
    int CrownUsed = raidsCrown.CountUsed;

    RaidParameters[] dl = new RaidParameters[NormalUsed + ArmorUsed + CrownUsed];
    RaidSpawnDetail[] allRaids = raids.GetAllRaids();
    for (int i = 0; i < NormalUsed; i++) {
      int idx = i;
      RaidSpawnDetail currentRaid = allRaids[i];
      NestHashDetail detail = NestLocations.Nests[i];
      dl[idx] = new RaidParameters(idx, currentRaid, detail.Location, detail.MapX, detail.MapY);
    }

    RaidSpawnDetail[] allArmorRaids = raidsArmor.GetAllRaids();
    for (int i = 0; i < ArmorUsed; i++) {
      int idx = NormalUsed + i;
      RaidSpawnDetail currentRaid = allArmorRaids[i];
      NestHashDetail detail = NestLocations.Nests[idx];
      dl[idx] = new RaidParameters(idx, currentRaid, detail.Location, detail.MapX, detail.MapY);
    }

    RaidSpawnDetail[] allCrownRaids = raidsCrown.GetAllRaids();
    for (int i = 0; i < CrownUsed; i++) {
      int idx = NormalUsed + ArmorUsed + i;
      RaidSpawnDetail currentRaid = allCrownRaids[i];
      NestHashDetail detail = NestLocations.Nests[idx];
      dl[idx] = new RaidParameters(idx, currentRaid, detail.Location, detail.MapX, detail.MapY);
    }

    return dl;
  }

  public RaidParameters this[int index] => DenList[index];

  public RaidPKM GenerateFromIndex(RaidParameters raidParameters) {
    if (raidParameters.IsCrystal) {
      return _raidTables.CrytalNestsEvent.ConvertToPKM(raidParameters, 0, TID, SID);
    }
    if (raidParameters.IsEvent) {
      RaidTemplateTable[] denDetails = Game == GameVersion.SW ? _raidTables.SwordNestsEvent : _raidTables.ShieldNestsEvent;
      return denDetails.ConvertToPKM(raidParameters, NestLocations.GetEventHash(raidParameters), TID, SID);
    } else {
      NestHashDetail detail = NestLocations.Nests[raidParameters.Index];
      ulong hash = raidParameters.IsRare ? detail.RareHash : detail.CommonHash;
      RaidTemplateTable[] denDetails = Game == GameVersion.SW ? _raidTables.SwordNests : _raidTables.ShieldNests;
      return denDetails.ConvertToPKM(raidParameters, hash, TID, SID);
    }
  }

  public IEnumerable<RaidTemplate> GetAllTemplatesWithStarCount(RaidParameters raidParameters, int stars) {
    if (raidParameters.IsCrystal) {
      RaidTemplateTable[]? tables = _raidTables.CrytalNestsEvent;
      RaidTemplateTable nest = Array.Find(tables, table => table.TableID == 0)!;
      return nest.Entries.AsEnumerable();
    }
    if (raidParameters.IsEvent) {
      RaidTemplateTable[] tables = Game == GameVersion.SW ? _raidTables.SwordNestsEvent : _raidTables.ShieldNestsEvent;
      RaidTemplateTable nest = Array.Find(tables, table => table.TableID == NestLocations.EventHash)!;
      return nest.Entries.Where(table => table.CanObtainWith(stars));
    } else {
      NestHashDetail detail = NestLocations.Nests[raidParameters.Index];
      RaidTemplateTable[] tables = Game == GameVersion.SW ? _raidTables.SwordNests : _raidTables.ShieldNests;
      RaidTemplateTable common = Array.Find(tables, table => table.TableID == detail.CommonHash)!;
      RaidTemplateTable rare = Array.Find(tables, table => table.TableID == detail.RareHash)!;
      return common.Entries.Where(table => table.CanObtainWith(stars)).Union(rare.Entries.Where(table => table.CanObtainWith(stars)));
    }
  }
}
