using PKHeX.Core;
using System.Text;

namespace PluginPile.Unmaintained.BWTool;
public class MemoryLink {
  public const int Size = 0xA20;
  public const int Offset = 0x7E000;

  public readonly byte[] Data;
  public readonly MemoryLinkBlock1 block1;
  public readonly MemoryLinkBlock1 block1_mirror;
  public readonly MemoryLinkBlock2 block2;
  
  public MemoryLink(byte[] data) {
    Data = data;

    byte[] decrypt1 = Crypto.CryptoArray(getData(0, MemoryLinkBlock1.Size), 0xC, 0x364, 0x374 - 4);
    byte[] decrypt2 = Crypto.CryptoArray(getData(0x400, MemoryLinkBlock1.Size), 0xC, 0x364, 0x374 - 4);
    block1 = new MemoryLinkBlock1(decrypt1);
    block1_mirror = new MemoryLinkBlock1(decrypt2);

    block2 = new MemoryLinkBlock2(getData(0x800, MemoryLinkBlock2.Size));//Not encrypted, but has CRC
  }

  public byte[] getData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }

  public void setData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }  

  public void set_blocks() {
    //Block 1
    //Recrypt
    byte[] encrypt1 = Crypto.CryptoArray(block1.Data, 0xC, 0x364, 0x374 - 4);
    //Recalculate CRC
    ushort crc = Checksums.CRC16_CCITT(encrypt1.Skip(0xC).Take(0x368).ToArray());
    BitConverter.GetBytes(crc).CopyTo(encrypt1, 0x8);
    //Set new data
    setData(encrypt1, 0);

    //Block 1 Mirror
    //Just put block 1 for now as mirror
    setData(encrypt1, 0x400);

    /*
    //Recrypt
    byte[] encrypt_mirror = Crypto.cryptoArray(block1_mirror.Data, 0xC, 0x364, 0x374-4);
    //Recalculate CRC
    ushort crc_mirror = Checksums.CRC16_CCITT(encrypt_mirror.Skip(0xC).Take(0x368).ToArray());
    BitConverter.GetBytes(crc_mirror).CopyTo(encrypt_mirror, 0x8);
    //Set new data
    setData(encrypt_mirror, 0x400);
    */

    //Block 2
    //Recalculate CRC
    ushort crc2 = Checksums.CRC16_CCITT(block2.Data.Skip(0xC).Take(0x214).ToArray());
    block2.crc = crc2;
    //Set new data
    setData(block2.Data, 0x800);
  }

  public ushort block1_crc {
    get => BitConverter.ToUInt16(Data, 0x8);
    set => setData(BitConverter.GetBytes(value), 0x8);
  }

  public uint block1_crypt_seed {
    get => BitConverter.ToUInt32(Data, 0x370);
    set => setData(BitConverter.GetBytes(value), 0x370);
  }

  public ushort block1_mirror_crc {
    get => BitConverter.ToUInt16(Data, 0x400 + 0x8);
    set => setData(BitConverter.GetBytes(value), 0x400 + 0x8);
  }

  public uint block1_mirror_crypt_seed {
    get => BitConverter.ToUInt32(Data, 0x400 + 0x370);
    set => setData(BitConverter.GetBytes(value), 0x400 + 0x370);
  }

  public ushort block2_crc {
    get => BitConverter.ToUInt16(Data, 0x800 + 0x8);
    set => setData(BitConverter.GetBytes(value), 0x800 + 0x8);
  }

  public class MemoryLinkBlock1 {
    public const int Size = 0x374;

    public readonly byte[] Data;

    public MemoryLinkBlock1(byte[] data) {
      Data = data;
    }

    public byte[] getData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void setData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public ushort crc {
      get => BitConverter.ToUInt16(Data, 0x8);
      set => setData(BitConverter.GetBytes(value), 0x8);
    }

    public uint crypt_seed {
      get => BitConverter.ToUInt32(Data, 0x370);
      set => setData(BitConverter.GetBytes(value), 0x370);
    }
  }
  public class MemoryLinkBlock2 {
    public const int Size = 0x2A0;

    public readonly byte[] Data;
    public MemoryLinkBlock2(byte[] data) {
      Data = data;
    }

    public byte[] getData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void setData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public ushort crc {
      get => BitConverter.ToUInt16(Data, 0x8);
      set => setData(BitConverter.GetBytes(value), 0x8);
    }

    //Helper functions from pkhex
    internal static string TrimFromFFFF(string input) {
      int index = input.IndexOf((char)0xFFFF);
      return index < 0 ? input : input.Substring(0, index);
    }

    public void name_fromarray(byte[] input) {
      name = TrimFromFFFF(Encoding.Unicode.GetString(input, 0x0, 0xE))
                .Replace("\uE08F", "\u2640") // nidoran
                .Replace("\uE08E", "\u2642") // nidoran
                .Replace("\u2019", "\u0027"); // farfetch'd
    }
    public string name {
      get {
        return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x48, 0xE))
            .Replace("\uE08F", "\u2640") // nidoran
            .Replace("\uE08E", "\u2642") // nidoran
            .Replace("\u2019", "\u0027"); // farfetch'd
      }
      set {
        if (value.Length > 0xE / 2)
          value = value.Substring(0, 0xE / 2); // Hard cap
        string TempNick = value // Replace Special Characters and add Terminator
            .Replace("\u2640", "\uE08F") // nidoran
            .Replace("\u2642", "\uE08E") // nidoran
            .Replace("\u0027", "\u2019") // farfetch'd
            .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
        Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x48);
        Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x60);
        Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x78);
      }
    }
    public ushort TID {
      get => BitConverter.ToUInt16(getData(0x44, 2), 0);
      set {
        setData(BitConverter.GetBytes(value), 0x44);
        setData(BitConverter.GetBytes(value), 0x5C);
        setData(BitConverter.GetBytes(value), 0x74);
      }
    }
    public ushort SID {
      get => BitConverter.ToUInt16(getData(0x46, 2), 0);
      set {
        setData(BitConverter.GetBytes(value), 0x46);
        setData(BitConverter.GetBytes(value), 0x5E);
        setData(BitConverter.GetBytes(value), 0x76);
      }
    }
    public byte STARTER {
      get => Data[0x8E];
      set => Data[0x8E] = value;
    }

    public bool checkflag(int index) {
      if (index > 7)
        index = 7;
      if ((Data[0x8D] & (0x1 << index)) == 0)
        return false;
      else
        return true;
    }
    public void setflag(int index, bool status) {
      if (index > 7)
        index = 7;

      if (status)
        Data[0x8D] |= (byte)(0x1 << index);
      else
        Data[0x8D] &= unchecked((byte)(~(0x1 << index)));
    }

    public void set_hof(byte[] input) {
      setData(input, 0xB8);
    }

    public void set_props(byte[] input) {
      setData(input, 0x94);
    }
  }
}
