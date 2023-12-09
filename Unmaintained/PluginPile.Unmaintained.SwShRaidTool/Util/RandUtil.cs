using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShRaidTool;
public static class RandUtil {
  public static uint GetShinyXor(uint val) => (val >> 16) ^ (val & 0xFFFF);

  public static uint GetShinyValue(uint num) => GetShinyXor(num) >> 4;

  public static uint GetShinyType(uint pid, uint tidsid) {
    uint p = GetShinyXor(pid);
    uint t = GetShinyXor(tidsid);
    if (p == t) return 2; // square;
    if ((p ^ t) < 0x10) return 1; // star
    return 0;
  }

  public static int GetNextShinyFrame(ulong seed) {
    Xoroshiro128Plus rng = new Xoroshiro128Plus(seed);
    for (int i = 0; ; i++) {
      uint _ = (uint)rng.NextInt(0xFFFFFFFF); // EC
      uint SIDTID = (uint)rng.NextInt(0xFFFFFFFF);
      uint PID = (uint)rng.NextInt(0xFFFFFFFF);
      uint type = GetShinyType(PID, SIDTID);
      if (type != 0)
        return i;

      // Get the next seed, and reset for the next iteration
      rng = new Xoroshiro128Plus(seed);
      seed = rng.Next();
      rng = new Xoroshiro128Plus(seed);
    }
  }
}
