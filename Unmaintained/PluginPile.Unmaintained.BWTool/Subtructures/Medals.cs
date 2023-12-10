namespace PluginPile.Unmaintained.BWTool;
public class Medals(byte[] data) {
  internal int MedalSize = 4;

  public readonly byte[] Data = data;
  private int index = 0;
  public int Index {
    get { return index / MedalSize; }
    set { if ((value >= 0) && (value < 256)) { index = (int)(value * MedalSize); } }
  }

  private static ushort BuildDate(int day, int month, int year) {
    return (ushort)(((day & 0x1F) << 11) | ((month & 0x0F) << 7) | (year & 0x7F));
  }

  public uint MedalBytes { get { return (BitConverter.ToUInt32(Data, index)); } }

  public int Day {
    get => (BitConverter.ToUInt16(Data, index)) >> 11;
    set => BitConverter.GetBytes(BuildDate(value, Month, Year)).CopyTo(Data, index);
  }

  public int Month {
    get => (BitConverter.ToUInt16(Data, index) & 0x0780) >> 7;
    set => BitConverter.GetBytes(BuildDate(Day, value, Year)).CopyTo(Data, index);
  }

  public int Year {
    get => (BitConverter.ToUInt16(Data, index) & 0x007F);
    set => BitConverter.GetBytes(BuildDate(Day, Month, value)).CopyTo(Data, index);
  }

  public ushort Flags {
    get => BitConverter.ToUInt16(Data, index + 0x02);
    set => BitConverter.GetBytes(value).CopyTo(Data, index + 0x2);
  }

  public bool Flag1 {
    get => Convert.ToBoolean(Flags & 0x1);
    set { if (value) Flags = (ushort)(Flags | 0x1); else Flags = (ushort)(Flags & ~(0x1)); }
  }

  public bool Flag2 {
    get => Convert.ToBoolean(Flags & 0x2);
    set { if (value) Flags = (ushort)(Flags | 0x2); else Flags = (ushort)(Flags & ~(0x2)); }
  }

  public bool Flag3 {
    get => Convert.ToBoolean(Flags & 0x4);
    set { if (value) Flags = (ushort)(Flags | 0x4); else Flags = (ushort)(Flags & ~(0x4)); }
  }

  public bool Flag4 {
    get => Convert.ToBoolean(Flags & 0x8);
    set { if (value) Flags = (ushort)(Flags | 0x8); else Flags = (ushort)(Flags & ~(0x8)); }
  }
}
