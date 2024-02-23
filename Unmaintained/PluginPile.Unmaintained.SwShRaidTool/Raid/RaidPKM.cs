namespace PluginPile.Unmaintained.SwShRaidTool;
public class RaidPKM(ushort species, byte altForm, uint ec, uint pid, int[] ivs, int ability, int abilityIdx, byte gender, int nature, int deviation, uint shinyType, bool isGigantamax, sbyte forcedShinyType = 0) {
  public readonly int Nature = nature;
  public readonly ushort Species = species;
  public readonly int[] IVs = ivs;
  public readonly byte Gender = gender;
  public readonly uint EC = ec;
  public readonly uint PID = pid;
  public readonly byte AltForm = altForm;
  public readonly int Ability = ability;
  public readonly uint ShinyType = shinyType;
  public readonly bool IsGigantamax = isGigantamax;
  public readonly sbyte ForcedShinyType = forcedShinyType;
  public readonly int Deviation = deviation;
  public readonly int AbilityIdx = abilityIdx;
}
