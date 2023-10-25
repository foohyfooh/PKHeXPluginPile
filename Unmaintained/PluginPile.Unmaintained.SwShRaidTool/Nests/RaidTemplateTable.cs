namespace PluginPile.Unmaintained.SwShRaidTool;
public class RaidTemplateTable {
  public readonly ulong TableID;
  public readonly uint GameVersion;
  public readonly RaidTemplate[] Entries;

  public RaidTemplateTable(ulong tableID, uint game, RaidTemplate[] entries) {
    TableID = tableID;
    GameVersion = game;
    Entries = entries;
  }
}

public static class RaidTemplateExtensions {
  public static RaidTemplate GetTemplateFrom(this IReadOnlyList<RaidTemplate> entries, RaidParameters param) {
    int index = entries.GetIndex(param.Stars, param.RandRoll);
    return entries[index];
  }

  public static int GetIndex(this IReadOnlyList<RaidTemplate> entries, int stars, int roll) {
    uint probability = 1;
    for (int idx = 0; idx < entries.Count; idx++) {
      probability += entries[idx].Probabilities[stars];
      if (probability > roll)
        return idx;
    }
    return entries.Count - 1;
  }

  public static RaidPKM ConvertToPKM(this RaidTemplateTable[] denDetails, RaidParameters raidParameters, ulong hash, uint TID, uint SID) {
    RaidTemplateTable nest = Array.Find(denDetails, n => n.TableID == hash)!;
    return nest.ConvertToPKM(raidParameters, TID, SID);
  }

  public static RaidPKM ConvertToPKM(this RaidTemplateTable raidTemplateTable, RaidParameters raidParameters, uint TID, uint SID) {
    RaidTemplate template = raidTemplateTable.Entries.GetTemplateFrom(raidParameters);
    return template.ConvertToPKM(raidParameters.Seed, TID, SID);
  }
}
