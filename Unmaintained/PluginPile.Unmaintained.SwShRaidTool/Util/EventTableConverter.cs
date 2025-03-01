using Newtonsoft.Json;
using PKHeX.Core;
using FlatBuffers;

namespace PluginPile.Unmaintained.SwShRaidTool;
public static class EventTableConverter {
  // https://projectpokemon.org/home/forums/topic/56121-swsh-blocks-and-save-research/
  const uint NORMAL_ENCOUNTER = 0xAD9DFA6A;
  const uint NORMAL_ENCOUNTER_RIGEL1 = 0x0E615A8C;
  const uint NORMAL_ENCOUNTER_RIGEL2 = 0x11615F45;

  public static void GetCurrentEventTable(SaveBlockAccessor8SWSH blocks, RaidTables rt) {
    byte[] archive = blocks.GetBlock(NORMAL_ENCOUNTER).Data.ToArray();
    if (archive.Length < 0x20 || archive.Length != 4 + BitConverter.ToInt32(archive, 0x10) || BitConverter.ToInt32(archive, 0x8) != 0x20)
      return; // no event loaded
    byte[] encount_data = new byte[archive.Length - 0x24];
    Array.Copy(archive, 0x20, encount_data, 0, encount_data.Length);


    FlatBufferBuilder fbb = new FlatBufferBuilder(new ByteBuffer(encount_data));
    NestHoleDistributionEncounter8Archive dist_encounts = NestHoleDistributionEncounter8Archive.GetRootAsNestHoleDistributionEncounter8Archive(fbb.DataBuffer);

    NestHoleDistributionEncounter8Table sword_table = dist_encounts.Tables(0)!.Value;
    NestHoleDistributionEncounter8Table shield_table = dist_encounts.Tables(1)!.Value;
    if (sword_table.GameVersion != 1) {
      sword_table = dist_encounts.Tables(1)!.Value;
      shield_table = dist_encounts.Tables(0)!.Value;
    }

    RaidTemplateTable swordTable = new RaidTemplateTable(NestLocations.EventHash, 1, new RaidTemplate[sword_table.EntriesLength]);
    RaidTemplateTable shieldTable = new RaidTemplateTable(NestLocations.EventHash, 2, new RaidTemplate[sword_table.EntriesLength]);
    for (int i = 0; i < sword_table.EntriesLength; i++) {
      NestHoleDistributionEncounter8 entry1 = sword_table.Entries(i)!.Value;

      swordTable.Entries[i] = new RaidTemplate(entry1.Species, entry1.GetProbabilitiesArray(), entry1.FlawlessIVs, entry1.AltForm, entry1.Ability, entry1.Gender, entry1.Nature, entry1.IsGigantamax, entry1.ShinyForced);
      entry1 = shield_table.Entries(i)!.Value;
      shieldTable.Entries[i] = new RaidTemplate(entry1.Species, entry1.GetProbabilitiesArray(), entry1.FlawlessIVs, entry1.AltForm, entry1.Ability, entry1.Gender, entry1.Nature, entry1.IsGigantamax, entry1.ShinyForced);
    }
    if (sword_table.EntriesLength > 0) {
      rt.SwordNestsEvent[0] = swordTable;
      rt.ShieldNestsEvent[0] = shieldTable;
    }

    // Rigel1
    archive = blocks.GetBlock(NORMAL_ENCOUNTER_RIGEL1).Data.ToArray();
    if (archive.Length < 0x20 || archive.Length != 4 + BitConverter.ToInt32(archive, 0x10) || BitConverter.ToInt32(archive, 0x8) != 0x20)
      return; // no event loaded
    encount_data = new byte[archive.Length - 0x24];
    Array.Copy(archive, 0x20, encount_data, 0, encount_data.Length);


    fbb = new FlatBufferBuilder(new ByteBuffer(encount_data));
    dist_encounts = NestHoleDistributionEncounter8Archive.GetRootAsNestHoleDistributionEncounter8Archive(fbb.DataBuffer);

    sword_table = dist_encounts.Tables(0)!.Value;
    shield_table = dist_encounts.Tables(1)!.Value;
    if (sword_table.GameVersion != 1) {
      sword_table = dist_encounts.Tables(1)!.Value;
      shield_table = dist_encounts.Tables(0)!.Value;
    }

    RaidTemplateTable swordTable_rigel1 = new RaidTemplateTable(NestLocations.EventHash_Rigel1, 1, new RaidTemplate[sword_table.EntriesLength]);
    RaidTemplateTable shieldTable_rigel1 = new RaidTemplateTable(NestLocations.EventHash_Rigel1, 2, new RaidTemplate[sword_table.EntriesLength]);
    for (int i = 0; i < sword_table.EntriesLength; i++) {
      NestHoleDistributionEncounter8 entry1 = sword_table.Entries(i)!.Value;

      swordTable_rigel1.Entries[i] = new RaidTemplate(entry1.Species, entry1.GetProbabilitiesArray(), entry1.FlawlessIVs, entry1.AltForm, entry1.Ability, entry1.Gender, entry1.Nature, entry1.IsGigantamax, entry1.ShinyForced);
      entry1 = shield_table.Entries(i)!.Value;
      shieldTable_rigel1.Entries[i] = new RaidTemplate(entry1.Species, entry1.GetProbabilitiesArray(), entry1.FlawlessIVs, entry1.AltForm, entry1.Ability, entry1.Gender, entry1.Nature, entry1.IsGigantamax, entry1.ShinyForced);
    }
    if (sword_table.EntriesLength > 0) {
      rt.SwordNestsEvent[1] = swordTable_rigel1;
      rt.ShieldNestsEvent[1] = shieldTable_rigel1;
    }

    // Rigel2
    archive = blocks.GetBlock(NORMAL_ENCOUNTER_RIGEL2).Data.ToArray();
    if (archive.Length < 0x20 || archive.Length != 4 + BitConverter.ToInt32(archive, 0x10) || BitConverter.ToInt32(archive, 0x8) != 0x20)
      return; // no event loaded
    encount_data = new byte[archive.Length - 0x24];
    Array.Copy(archive, 0x20, encount_data, 0, encount_data.Length);


    fbb = new FlatBufferBuilder(new ByteBuffer(encount_data));
    dist_encounts = NestHoleDistributionEncounter8Archive.GetRootAsNestHoleDistributionEncounter8Archive(fbb.DataBuffer);

    sword_table = dist_encounts.Tables(0)!.Value;
    shield_table = dist_encounts.Tables(1)!.Value;
    if (sword_table.GameVersion != 1) {
      sword_table = dist_encounts.Tables(1)!.Value;
      shield_table = dist_encounts.Tables(0)!.Value;
    }

    RaidTemplateTable swordTable_rigel2 = new RaidTemplateTable(NestLocations.EventHash_Rigel2, 1, new RaidTemplate[sword_table.EntriesLength]);
    RaidTemplateTable shieldTable_rigel2 = new RaidTemplateTable(NestLocations.EventHash_Rigel2, 2, new RaidTemplate[sword_table.EntriesLength]);
    for (int i = 0; i < sword_table.EntriesLength; i++) {
      NestHoleDistributionEncounter8 entry1 = sword_table.Entries(i)!.Value;
      swordTable_rigel2.Entries[i] = new RaidTemplate(entry1.Species, entry1.GetProbabilitiesArray(), entry1.FlawlessIVs, entry1.AltForm, entry1.Ability, entry1.Gender, entry1.Nature, entry1.IsGigantamax, entry1.ShinyForced);
      entry1 = shield_table.Entries(i)!.Value;
      shieldTable_rigel2.Entries[i] = new RaidTemplate(entry1.Species, entry1.GetProbabilitiesArray(), entry1.FlawlessIVs, entry1.AltForm, entry1.Ability, entry1.Gender, entry1.Nature, entry1.IsGigantamax, entry1.ShinyForced);
    }
    if (sword_table.EntriesLength > 0) {
      rt.SwordNestsEvent[2] = swordTable_rigel2;
      rt.ShieldNestsEvent[2] = shieldTable_rigel2;
    }
  }

  public static void LoadFromJson(string filecontent, RaidTables rt) {
    Old_NestHoleDistributionEncounter8Archive dist_encounts = JsonConvert.DeserializeObject<Old_NestHoleDistributionEncounter8Archive>(filecontent)!;
    List<Old_NestHoleDistributionEncounter8Table> sword_table = dist_encounts.Tables.Where(z => z.GameVersion == 1).ToList();
    List<Old_NestHoleDistributionEncounter8Table> shield_table = dist_encounts.Tables.Where(z => z.GameVersion == 2).ToList();
    RaidTemplateTable swordTable = new RaidTemplateTable(NestLocations.EventHash, 1, new RaidTemplate[sword_table[0].Entries.Length]);
    RaidTemplateTable shieldTable = new RaidTemplateTable(NestLocations.EventHash, 2, new RaidTemplate[sword_table[0].Entries.Length]);
    for (int i = 0; i < sword_table[0].Entries.Length; i++) {
      Old_NestHoleDistributionEncounter8 entry1 = sword_table[0].Entries[i];
      swordTable.Entries[i] = new RaidTemplate(entry1.Species, entry1.Probabilities, entry1.FlawlessIVs, entry1.AltForm, entry1.Ability, entry1.Gender, entry1.Nature, entry1.IsGigantamax, entry1.ShinyForced);
      entry1 = shield_table[0].Entries[i];
      shieldTable.Entries[i] = new RaidTemplate(entry1.Species, entry1.Probabilities, entry1.FlawlessIVs, entry1.AltForm, entry1.Ability, entry1.Gender, entry1.Nature, entry1.IsGigantamax, entry1.ShinyForced);
    }

    rt.SwordNestsEvent[0] = swordTable;
    rt.ShieldNestsEvent[0] = shieldTable;
  }
}
