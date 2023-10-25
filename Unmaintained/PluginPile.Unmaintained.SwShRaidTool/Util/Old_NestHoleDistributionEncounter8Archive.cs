namespace PluginPile.Unmaintained.SwShRaidTool;
public class Old_NestHoleDistributionEncounter8Archive {
  public required Old_NestHoleDistributionEncounter8Table[] Tables { get; set; }
}

public class Old_NestHoleDistributionEncounter8Table {
  public ulong TableID { get; set; }
  public uint GameVersion { get; set; }
  public byte Field_02 { get; set; }
  public byte Field_03 { get; set; }
  public required Old_NestHoleDistributionEncounter8[] Entries { get; set; }
}

public class Old_NestHoleDistributionEncounter8 {
  public int EntryIndex { get; set; }
  public uint Species { get; set; }
  public uint AltForm { get; set; }
  public int Level { get; set; }
  public ushort DynamaxLevel { get; set; }
  public uint Field_05 { get; set; } // probably EVs
  public uint Field_06 { get; set; }
  public uint Field_07 { get; set; }
  public uint Field_08 { get; set; }
  public uint Field_09 { get; set; }
  public uint Field_0A { get; set; }
  public byte Ability { get; set; }
  public bool IsGigantamax { get; set; }
  public ulong DropTableID { get; set; }
  public ulong BonusTableID { get; set; }
  public required uint[] Probabilities { get; set; }
  public byte Gender { get; set; }
  public byte FlawlessIVs { get; set; }
  public sbyte ShinyForced { get; set; }
  public byte Field_13 { get; set; } // 3/4
  public byte Field_14 { get; set; } // 3/4/5 -- +1 for second entries
  public byte Nature { get; set; }
  public int Field_16 { get; set; }
  public uint Move0 { get; set; }
  public uint Move1 { get; set; }
  public uint Move2 { get; set; }
  public uint Move3 { get; set; }
  public float DynamaxBoost { get; set; }
  public uint Field_1C { get; set; }
  public uint Field_1D { get; set; }
  public uint Field_1E { get; set; } // Shield
  public uint Field_1F { get; set; } // % only if move
  public uint Field_20 { get; set; } // Move ID
  public uint Field_21 { get; set; } // Shield only if move
  public uint Field_22 { get; set; } // % only if move
  public uint Field_23 { get; set; } // Move ID
  public uint Field_24 { get; set; } // shield? only if move
  public int MinRank => Array.FindIndex(Probabilities, z => z != 0);
  public int MaxRank => Array.FindLastIndex(Probabilities, z => z != 0);
}
