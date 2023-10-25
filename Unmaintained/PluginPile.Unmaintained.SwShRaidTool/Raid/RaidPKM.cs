namespace PluginPile.Unmaintained.SwShRaidTool;
public class RaidPKM {
  public readonly int Nature;
  public readonly ushort Species;
  public readonly int[] IVs;
  public readonly int Gender;
  public readonly uint EC;
  public readonly uint PID;
  public readonly byte AltForm;
  public readonly int Ability;
  public readonly uint ShinyType;
  public readonly bool IsGigantamax;
  public readonly sbyte ForcedShinyType;
  public readonly int Deviation;
  public readonly int AbilityIdx;

  public RaidPKM(ushort species, byte altForm, uint ec, uint pid, int[] ivs, int ability, int abilityIdx, int gender, int nature, int deviation, uint shinyType, bool isGigantamax, sbyte forcedShinyType = 0) {
    Species = species;
    AltForm = altForm;
    EC = ec;
    PID = pid;
    IVs = ivs;
    Ability = ability;
    Gender = gender;
    Nature = nature;
    ShinyType = shinyType;
    IsGigantamax = isGigantamax;
    ForcedShinyType = forcedShinyType;
    Deviation = deviation;
    AbilityIdx = abilityIdx;
  }
}
