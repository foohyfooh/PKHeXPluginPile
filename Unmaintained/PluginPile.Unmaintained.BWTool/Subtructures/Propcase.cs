namespace PluginPile.Unmaintained.BWTool;
public class Propcase {
  internal int Size = 13;
  internal int max_props = 99;
  public int props_offset = 0x1F958;

  public byte[] Data;
  public Propcase(byte[] data) {
    Data = data;
  }

  public byte[] getData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }

  public void setData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }

  public bool getProp(int Pos) {
    if (Pos > 99)
      Pos = 99;
    int curbyte = Pos / 8;
    return ((Data[curbyte] & (0x1 << Pos - (curbyte * 8))) != 0);
  }

  public void setProp(int Pos, bool Obtained) {
    if (Pos > 99)
      Pos = 99;
    int curbyte = Pos / 8;
    if (Obtained == true)
      Data[curbyte] |= (byte)(0x1 << (Pos - (curbyte * 8)));
    else
      Data[curbyte] &= unchecked((byte)(~(0x1 << (Pos - (curbyte * 8)))));
  }

}
