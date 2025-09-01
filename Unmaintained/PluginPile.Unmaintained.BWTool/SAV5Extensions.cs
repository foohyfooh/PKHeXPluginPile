using PKHeX.Core;
using System.Reflection;

namespace PluginPile.Unmaintained.BWTool; 
public static class SAV5Extensions {

  public static byte[] GetData(this SAV5 sav, int Offset, int Length) {
    return [.. sav.Data.ToArray().Skip(Offset).Take(Length)];
  }

  public static void SetData(this SAV5 sav, byte[] input, int Offset) {
    input.CopyTo(sav.Data[Offset..(Offset+input.Length)]);
    sav.State.Edited = true;
  }

  private static byte[] GetBlock(this SAV5 sav, int index, int crcIndex, int backupOffset) {
    if (index < crcIndex) {
      return [.. sav.Data[sav.AllBlocks[index].Offset..sav.AllBlocks[index + 1].Offset]];
    } else if (index == crcIndex) {
      return [.. sav.Data[sav.AllBlocks[index].Offset..backupOffset]];
    }
    throw new ArgumentOutOfRangeException($"Index should be less than {crcIndex}");
  }

  public static byte[] GetBlock(this SAV5 sav, int index) {
    if (sav is SAV5BW) {
      return sav.GetBlock(index, Constants.BW.CrcIndex, Constants.BW.BackupOffset);
    } else { // sav is SAV5B2W2
      return sav.GetBlock(index, Constants.B2W2.CrcIndex, Constants.B2W2.BackupOffset);
    } 
  }

  private static int GetBlockLength(this SAV5 sav, int index, int crcIndex, int backupOffset) {
    //Get size
    if (index < crcIndex)
      return sav.AllBlocks[index + 1].Offset - sav.AllBlocks[index].Offset;
    else if (index == crcIndex)
      return backupOffset - sav.AllBlocks[index].Offset;
    throw new ArgumentOutOfRangeException($"Index should be less than {crcIndex}");
  }

  public static int GetBlockLength(this SAV5 sav, int index) {
    if (sav is SAV5BW) {
      return sav.GetBlockLength(index, Constants.BW.CrcIndex, Constants.BW.BackupOffset);
    } else { // sav is SAV5B2W2
      return sav.GetBlockLength(index, Constants.B2W2.CrcIndex, Constants.B2W2.BackupOffset);
    }
  }

  private static int Checksum(this BlockInfoNDS block) {
    FieldInfo checksumOffsetProperty = typeof(BlockInfoNDS).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Single(p => p.Name == "ChecksumOffset");
    return (int)checksumOffsetProperty.GetValue(block)!;
  }

  public static void SetBlock(this SAV5 sav, byte[] input, int index, int crcIndex, int backupOffset) {
    if (index <= crcIndex) {
      //Recalculate checksum before applying to savedata
      ushort crc = Checksums.CRC16_CCITT(input.Take(sav.AllBlocks[index].Length).ToArray());
      ushort crcintable = BitConverter.ToUInt16(sav.Data[(sav.AllBlocks[crcIndex].Offset + (index * 2))..]);
      if (crc != BitConverter.ToUInt16(input, ((BlockInfoNDS)sav.AllBlocks[index]).Checksum() - sav.AllBlocks[index].Offset) || crc != crcintable) {
        byte[] crcBytes = BitConverter.GetBytes(crc);
        Array.Copy(crcBytes, 0, input, ((BlockInfoNDS)sav.AllBlocks[index]).Checksum() - sav.AllBlocks[index].Offset, 2);
        // Update CRC tables
        crcBytes.CopyTo(sav.Data.Slice((sav.AllBlocks[crcIndex].Offset) + (index * 2)               , 2));
        crcBytes.CopyTo(sav.Data.Slice((sav.AllBlocks[crcIndex].Offset) + (index * 2) + backupOffset, 2));
        // recalculate CRC table's checksum
        ushort crctable = Checksums.CRC16_CCITT(sav.Data.Slice(sav.AllBlocks[crcIndex].Offset, (crcIndex + 1) * 2));
        byte[] crctableBytes = BitConverter.GetBytes(crctable);
        crctableBytes.CopyTo(sav.Data.Slice(((BlockInfoNDS)sav.AllBlocks[crcIndex]).Checksum()               , 2));
        crctableBytes.CopyTo(sav.Data.Slice(((BlockInfoNDS)sav.AllBlocks[crcIndex]).Checksum() + backupOffset, 2));
      }

      input.CopyTo(sav.Data.Slice(sav.AllBlocks[index].Offset, input.Length));
      input.CopyTo(sav.Data.Slice(sav.AllBlocks[index].Offset + backupOffset, input.Length));
      sav.State.Edited = true;
    } else throw new ArgumentOutOfRangeException($"Index should be less than {crcIndex}");
  }

  public static void SetBlock(this SAV5 sav, byte[] input, int index) {
    int expectedLength = sav.GetBlockLength(index);
    if (input.Length != expectedLength)
      throw new ArgumentException($"input.Length({input.Length}) should be {expectedLength}");
    if (sav is SAV5BW) {
      sav.SetBlock(input, index, Constants.BW.CrcIndex, Constants.BW.BackupOffset);
    } else { // sav is SAV5B2W2
      sav.SetBlock(input, index, Constants.B2W2.CrcIndex, Constants.B2W2.BackupOffset);
    }
  }

  public record EncryptedBlockInfo(int Start, int Length, int Seed);

  private static readonly Dictionary<int, EncryptedBlockInfo> BWEnc = new Dictionary<int, EncryptedBlockInfo>() {
    { 38, new EncryptedBlockInfo(0x04, 0x1DC, 0x1DC) },
    { 61, new EncryptedBlockInfo(0x00, 0x84C, 0x84C) }
  };

  private static readonly Dictionary<int, EncryptedBlockInfo> B2W2Enc = new Dictionary<int, EncryptedBlockInfo>() {
    { 34, new EncryptedBlockInfo(0x00, 0xA90, 0xA90) },
    { 38, new EncryptedBlockInfo(0x04, 0x1DC, 0x1DC) },
    { 60, new EncryptedBlockInfo(0x00, 0x84C, 0x84C) }
  };

  public static Dictionary<int, EncryptedBlockInfo> GetEnc(this SAV5 sav) => sav is SAV5BW ? BWEnc : B2W2Enc;

  public static byte[] GetBlockDec(this SAV5 sav, int index, int crcIndex, int backupOffset) {
    Dictionary<int, EncryptedBlockInfo> enc = sav.GetEnc();
    if (index < crcIndex) {
      byte[] decrypt = Crypto.CryptoArray([.. sav.Data[sav.AllBlocks[index].Offset..sav.AllBlocks[index + 1].Offset]], enc[index].Start, enc[index].Length, enc[index].Seed);
      return decrypt;
    } else if (index == crcIndex) {
      return [.. sav.Data[sav.AllBlocks[index].Offset..backupOffset]];
    }
    throw new ArgumentOutOfRangeException($"Index should be less than {crcIndex}");
  }

  public static byte[] GetBlockDec(this SAV5 sav, int index) {
    if (sav is SAV5BW) {
      return sav.GetBlockDec(index, Constants.BW.CrcIndex, Constants.BW.BackupOffset);
    } else { // sav is SAV5B2W2
      return sav.GetBlockDec(index, Constants.B2W2.CrcIndex, Constants.B2W2.BackupOffset);
    }
  }

  public static void SetBlockCrypt(this SAV5 sav, byte[] input, int index) {
    Dictionary<int, EncryptedBlockInfo> enc = sav.GetEnc();
    byte[] encrypt = Crypto.CryptoArray(input, enc[index].Start, enc[index].Length, enc[index].Seed);
    sav.SetBlock(encrypt, index);
  }

  public static byte[] GetDSLinkA(this SAV5B2W2 sav) {
    return sav.GetData(0x7F000, 0x10);
  }

  public static void SetDSLinkA(this SAV5B2W2 sav, byte[] dslinkA) {
    sav.SetData(dslinkA, 0x7F000);
    // Fix checksum
    ushort crc = Checksums.CRC16_CCITT(dslinkA);
    sav.SetData(BitConverter.GetBytes(crc), 0x7F010);
    // Just to be sure this is set 0xFFFF (seems basically unused though)
    sav.Data[0x7F012] = 0xFF;
    sav.Data[0x7F013] = 0xFF;
  }

  public static byte[] GetDSLinkB(this SAV5B2W2 sav) {
    return Crypto.CryptoXor32Array(sav.GetData(0x7F014, 0x80), 0, 0x7C, 0x7C);
  }

  public static void SetDSLinkB(this SAV5B2W2 sav, byte[] dslinkB) {
    byte[] enc = Crypto.CryptoXor32Array(dslinkB, 0, 0x7C, 0x7C);
    sav.SetData(enc, 0x7F014);
    //Fix checksum
    ushort crc = Checksums.CRC16_CCITT(enc);
    sav.SetData(BitConverter.GetBytes(crc), 0x7F094);
  }

}
