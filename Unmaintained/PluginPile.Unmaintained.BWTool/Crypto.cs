using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool; 
internal static class Crypto {

  public static byte[] CryptoArray(byte[] ekx, int start_offset, int length, int seed_offset) {
    byte[] buffer_dec = (byte[])ekx.Clone();
    uint seed = BitConverter.ToUInt32(ekx, seed_offset);
    PokeCrypto.CryptArray(buffer_dec.AsSpan(start_offset, length), seed);
    return buffer_dec;
  }

  public static byte[] CryptoXor32Array(byte[] encarray, int start_offset, int length, int key_offset) {
    byte[] buffer_dec = (byte[])encarray.Clone();
    uint encKey = BitConverter.ToUInt32(encarray, key_offset);
    for (int i = 0; i < length; i += 4) {
      BitConverter.GetBytes(BitConverter.ToUInt32(encarray, start_offset + i) ^ encKey).CopyTo(buffer_dec, i);
    }
    return buffer_dec;
  }

}
