namespace PluginPile.Unmaintained.BWTool;
public class Propcase(byte[] data) {
  internal int Size = 13;
  internal int max_props = 99;
  public int props_offset = 0x1F958;

  public byte[] Data = data;

  public byte[] GetData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }

  public void SetData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }

  public bool GetProp(int Pos) {
    if (Pos > 99)
      Pos = 99;
    int curbyte = Pos / 8;
    return ((Data[curbyte] & (0x1 << Pos - (curbyte * 8))) != 0);
  }

  public void SetProp(int Pos, bool Obtained) {
    if (Pos > 99)
      Pos = 99;
    int curbyte = Pos / 8;
    if (Obtained == true)
      Data[curbyte] |= (byte)(0x1 << (Pos - (curbyte * 8)));
    else
      Data[curbyte] &= unchecked((byte)(~(0x1 << (Pos - (curbyte * 8)))));
  }

}
