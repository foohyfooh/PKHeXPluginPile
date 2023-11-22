namespace PluginPile.Unmaintained.BWTool;
public class Medals {
  internal int MedalSize = 4;

  public readonly byte[] Data;
  public Medals(byte[] data) {
    Data = data;
  }
  private int index = 0;
  public int Index {
    get { return index / MedalSize; }
    set { if ((value >= 0) && (value < 256)) { index = (int)(value * MedalSize); } }
  }

  private ushort build_date(int day, int month, int year) {
    return (ushort)(((day & 0x1F) << 11) | ((month & 0x0F) << 7) | (year & 0x7F));
  }

  public uint medal_bytes { get { return (BitConverter.ToUInt32(Data, index)); } }

  public int Day {
    get { return (BitConverter.ToUInt16(Data, index)) >> 11; }
    set { BitConverter.GetBytes(build_date(value, Month, Year)).CopyTo(Data, index); }
  }
  public int Month {
    get { return (BitConverter.ToUInt16(Data, index) & 0x0780) >> 7; }
    set { BitConverter.GetBytes(build_date(Day, value, Year)).CopyTo(Data, index); }
  }
  public int Year {
    get { return (BitConverter.ToUInt16(Data, index) & 0x007F); }
    set { BitConverter.GetBytes(build_date(Day, Month, value)).CopyTo(Data, index); }
  }
  public UInt16 Flags {
    get { return BitConverter.ToUInt16(Data, index + 0x02); }
    set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, index + 0x2); }
  }

  public bool Flag1 {
    get { return Convert.ToBoolean(Flags & 0x1); }
    set { if (value == true) Flags = (ushort)(Flags | 0x1); else Flags = (ushort)(Flags & ~(0x1)); }
  }
  public bool Flag2 {
    get { return Convert.ToBoolean(Flags & 0x2); }
    set { if (value == true) Flags = (ushort)(Flags | 0x2); else Flags = (ushort)(Flags & ~(0x2)); }
  }
  public bool Flag3 {
    get { return Convert.ToBoolean(Flags & 0x4); }
    set { if (value == true) Flags = (ushort)(Flags | 0x4); else Flags = (ushort)(Flags & ~(0x4)); }
  }
  public bool Flag4 {
    get { return Convert.ToBoolean(Flags & 0x8); }
    set { if (value == true) Flags = (ushort)(Flags | 0x8); else Flags = (ushort)(Flags & ~(0x8)); }
  }
}
