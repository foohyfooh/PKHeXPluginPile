using PKHeX.Core;

namespace PluginPile.FashionEditor; 

public interface IFashionBlockConverter {
  public bool[] FromBlockData(byte[] data);
  public byte[] ToBlockData(bool[] bools);
}

public class FashionBlockConverterSwSh : IFashionBlockConverter {
  public bool[] FromBlockData(byte[] data) => FlagUtil.GitBitFlagArray(data);

  public byte[] ToBlockData(bool[] bools) {
    byte[] data = new byte[bools.Length >> 3];
    FlagUtil.SetBitFlagArray(data, bools);
    return data;
  }
}

public class FashionBlockConverterLA : IFashionBlockConverter {
  private const byte NOT_OWNED = 1;
  private const byte OWNED     = 2;

  public bool[] FromBlockData(byte[] data) => data.Select((b, i) => b == OWNED).ToArray();

  public byte[] ToBlockData(bool[] bools) => bools.Select((b, i) => b ? OWNED : NOT_OWNED).ToArray();
}
