using PKHeX.Core;
using System.Text;

namespace PluginPile.Unmaintained.BWTool;
public class MemoryLink {
  public const int Size = 0xA20;
  public const int Offset = 0x7E000;

  public readonly byte[] Data;
  public readonly MemoryLinkBlock1 Block1;
  public readonly MemoryLinkBlock1 Block1Mirror;
  public readonly MemoryLinkBlock2 Block2;
  
  public MemoryLink(byte[] data) {
    Data = data;

    byte[] decrypt1 = Crypto.CryptoArray(GetData(0, MemoryLinkBlock1.Size), 0xC, 0x364, 0x374 - 4);
    byte[] decrypt2 = Crypto.CryptoArray(GetData(0x400, MemoryLinkBlock1.Size), 0xC, 0x364, 0x374 - 4);
    Block1 = new MemoryLinkBlock1(decrypt1);
    Block1Mirror = new MemoryLinkBlock1(decrypt2);

    Block2 = new MemoryLinkBlock2(GetData(0x800, MemoryLinkBlock2.Size));//Not encrypted, but has CRC
  }

  public byte[] GetData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }

  public void SetData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }  

  public void SetBlocks() {
    //Block 1
    //Recrypt
    byte[] encrypt1 = Crypto.CryptoArray(Block1.Data, 0xC, 0x364, 0x374 - 4);
    //Recalculate CRC
    ushort crc = Checksums.CRC16_CCITT(encrypt1.Skip(0xC).Take(0x368).ToArray());
    BitConverter.GetBytes(crc).CopyTo(encrypt1, 0x8);
    //Set new data
    SetData(encrypt1, 0);

    //Block 1 Mirror
    //Just put block 1 for now as mirror
    SetData(encrypt1, 0x400);

    /*
    //Recrypt
    byte[] encryptMirror = Crypto.CryptoArray(Block1Mirror.Data, 0xC, 0x364, 0x374 - 4);
    //Recalculate CRC
    ushort crcMirror = Checksums.CRC16_CCITT(encryptMirror.Skip(0xC).Take(0x368).ToArray());
    BitConverter.GetBytes(crcMirror).CopyTo(encryptMirror, 0x8);
    //Set new data
    SetData(encryptMirror, 0x400);
    */

    //Block 2
    //Recalculate CRC
    ushort crc2 = Checksums.CRC16_CCITT(Block2.Data.Skip(0xC).Take(0x214).ToArray());
    Block2.CRC = crc2;
    //Set new data
    SetData(Block2.Data, 0x800);
  }

  public ushort Block1CRC {
    get => BitConverter.ToUInt16(Data, 0x8);
    set => SetData(BitConverter.GetBytes(value), 0x8);
  }

  public uint Block1CryptSeed {
    get => BitConverter.ToUInt32(Data, 0x370);
    set => SetData(BitConverter.GetBytes(value), 0x370);
  }

  public ushort Block1MirrorCRC {
    get => BitConverter.ToUInt16(Data, 0x400 + 0x8);
    set => SetData(BitConverter.GetBytes(value), 0x400 + 0x8);
  }

  public uint Block1MirrorCryptSeed {
    get => BitConverter.ToUInt32(Data, 0x400 + 0x370);
    set => SetData(BitConverter.GetBytes(value), 0x400 + 0x370);
  }

  public ushort Block2CRC {
    get => BitConverter.ToUInt16(Data, 0x800 + 0x8);
    set => SetData(BitConverter.GetBytes(value), 0x800 + 0x8);
  }

  public class MemoryLinkBlock1(byte[] data) {
    public const int Size = 0x374;

    public readonly byte[] Data = data;

    public byte[] GetData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void SetData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public ushort CRC {
      get => BitConverter.ToUInt16(Data, 0x8);
      set => SetData(BitConverter.GetBytes(value), 0x8);
    }

    public uint CryptSeed {
      get => BitConverter.ToUInt32(Data, 0x370);
      set => SetData(BitConverter.GetBytes(value), 0x370);
    }
  }
  public class MemoryLinkBlock2(byte[] data) {
    public const int Size = 0x2A0;

    public readonly byte[] Data = data;

    public byte[] GetData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void SetData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public ushort CRC {
      get => BitConverter.ToUInt16(Data, 0x8);
      set => SetData(BitConverter.GetBytes(value), 0x8);
    }

    public void NameFromArray(byte[] input) {
      Name = StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(input, 0x0, 0xE))
                .Replace("\uE08F", "\u2640") // nidoran
                .Replace("\uE08E", "\u2642") // nidoran
                .Replace("\u2019", "\u0027"); // farfetch'd
    }

    public string Name {
      get {
        return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x48, 0xE))
            .Replace("\uE08F", "\u2640") // nidoran
            .Replace("\uE08E", "\u2642") // nidoran
            .Replace("\u2019", "\u0027"); // farfetch'd
      }
      set {
        if (value.Length > 0xE / 2)
          value = value[..(0xE / 2)]; // Hard cap
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
      get => BitConverter.ToUInt16(GetData(0x44, 2), 0);
      set {
        SetData(BitConverter.GetBytes(value), 0x44);
        SetData(BitConverter.GetBytes(value), 0x5C);
        SetData(BitConverter.GetBytes(value), 0x74);
      }
    }

    public ushort SID {
      get => BitConverter.ToUInt16(GetData(0x46, 2), 0);
      set {
        SetData(BitConverter.GetBytes(value), 0x46);
        SetData(BitConverter.GetBytes(value), 0x5E);
        SetData(BitConverter.GetBytes(value), 0x76);
      }
    }
    public byte STARTER {
      get => Data[0x8E];
      set => Data[0x8E] = value;
    }

    public bool Checkflag(int index) {
      if (index > 7)
        index = 7;
      return (Data[0x8D] & (0x1 << index)) != 0;
    }
    public void Setflag(int index, bool status) {
      if (index > 7)
        index = 7;
      if (status)
        Data[0x8D] |= (byte)(0x1 << index);
      else
        Data[0x8D] &= unchecked((byte)(~(0x1 << index)));
    }

    public void SetHOF(byte[] input) {
      SetData(input, 0xB8);
    }

    public void SetProps(byte[] input) {
      SetData(input, 0x94);
    }
  }
}
