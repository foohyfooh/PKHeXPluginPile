using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShRaidTool;
public static class BruteForceSearch {
  public static bool IsMatch(ulong seed, int[] ivs, int fixed_ivs) {
    Xoroshiro128Plus rng = new Xoroshiro128Plus(seed);
    rng.NextInt(); // EC
    rng.NextInt(); // TID
    rng.NextInt(); // PID
    int[] check_ivs = { -1, -1, -1, -1, -1, -1 };
    for (int i = 0; i < fixed_ivs; i++) {
      uint slot;
      do {
        slot = (uint)rng.NextInt(6);
      } while (check_ivs[slot] != -1);

      if (ivs[slot] != 31)
        return false;

      check_ivs[slot] = 31;
    }
    for (int i = 0; i < 6; i++) {
      if (check_ivs[i] != -1)
        continue; // already verified?

      uint iv = (uint)rng.NextInt(32);
      if (iv != ivs[i])
        return false;
    }
    return true;
  }

  public static IEnumerable<ulong> FindSeeds(uint ec, uint pid, uint tid, uint sid, sbyte fixedShiny = 0) {
    uint fixed_val = GetSeedStart(ec);
    uint tsv = (tid ^ sid) >> 4;
    ulong seed = fixed_val;
    do {
      Xoroshiro128Plus rng = new Xoroshiro128Plus(seed);
      rng.NextInt(); // EC
      uint tidsid = (uint)rng.NextInt();
      uint new_pid = (uint)rng.NextInt();
      new_pid = RaidTemplate.GetFinalPID(tid, sid, new_pid, tidsid, tsv, fixedShiny);
      if (new_pid == pid)
        yield return seed;
      seed += 0x1_0000_0000;
    } while (seed != fixed_val);
  }

  private static uint GetSeedStart(uint ec) {
    const uint tmp = unchecked((uint)Xoroshiro128Plus.XOROSHIRO_CONST) & 0xFFFFFFFF;
    return tmp < ec ? ec - tmp : 0xFFFFFFFF - (tmp - ec) + 1;
  }
}
