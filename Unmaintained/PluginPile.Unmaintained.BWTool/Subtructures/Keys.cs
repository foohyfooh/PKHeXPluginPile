namespace PluginPile.Unmaintained.BWTool;
public class Keys(byte[] data) {
  public readonly byte[] Data = data;

  /*
  0x00-0x07 - Unknown
  0x08-0x17 - Seems always 0x00
  0x18-0x27 - Unknown
  0x28 - Easy key (W) 				- 0x00035691
  0x2C - Challenge key (B) 			- 0x00018256
  0x30 - Tower Key (B)/ Treehollow key (W)	- 0x00059389
  0x34 - Iron Key (B) 				- 0x00048292
  0x38 - Iceberg Key (W)  			- 0x00009892
  0x3C - Easy mode unlocked			- 0x00093389
  0x40 - Challenge mode unlocked 			- 0x00022843
  0x44 - Black City / White forest unlocked 	- 0x00034771
  0x48 - Iron chamber unlocked 			- 0x000AB031
  0x4C - Iceberg chamber unlocked 		- 0x000B3818
  0x50 - Difficulty config (easy 0x00031239 | normal 0x00015657 | challenge 0x00049589)
  0x54 - Black city/White city config (black city 0x00034525| white city 0x00011963)
  0x58 - Chamber config (rock 0x00094525 | iron 0x00081963 | iceberg 0x00038569)
  0x5C - Unique ID used to xor the keys (also present in memory link block)
  0x60 - Counter
  0x62 - ccrit checksum
  */
  private const uint EasyKey = 0x00035691;
  private const uint ChallengeKey = 0x00018256;
  private const uint CityKey = 0x00059389;
  private const uint IronKey = 0x00048292;
  private const uint IcebergKey = 0x00009892;
  private const uint EasyUnlocked = 0x00093389;
  private const uint ChallengeUnlocked = 0x00022843;
  private const uint CityUnlocked = 0x00034771;
  private const uint IronUnlocked = 0x000AB031;
  private const uint IcebergUnlocked = 0x000B3818;
  private readonly uint[] DifficultCfg = [0x0, 0x00031239, 0x00015657, 0x00049589];
  private readonly uint[] CtyCg = [0x0, 0x00034525, 0x00011963];
  private readonly uint[] ChamberCfg = [0x0, 0x00094525, 0x00081963, 0x00038569];
  private const uint zero = 0;

  public bool KeysUnlocked() {
    for (int i = 0; i < 0x5C; i++) {
      if (Data[i] != 0x00)
        return true;
    }
    return false;
  }

  public int GetConfig(int configIndex) {
    if (configIndex == 0) {
      for (int i = 0; i < 4; i++) {
        if (GetKeyXor(10) == DifficultCfg[i]) {
          return i;
        }
      }
      return 0;
    } else if (configIndex == 1) {
      for (int i = 0; i < 3; i++) {
        if (GetKeyXor(11) == CtyCg[i]) {
          return i;
        }
      }
      return 0;
    } else if (configIndex == 2) {
      for (int i = 0; i < 4; i++) {
        if (GetKeyXor(12) == ChamberCfg[i]) {
          return i;
        }
      }
      return 0;
    } else {
      return 0;
    }
  }
  private uint GetKey(int keyIndex) {
    return BitConverter.ToUInt32(Data, 0x28 + (keyIndex * 4));
  }
  private uint GetKeyXor(int keyIndex) {
    return GetKey(keyIndex) ^ ID;
  }
  public bool GetKeyState(int keyIndex) {
    return GetKeyXor(keyIndex) switch {
      EasyKey => true,
      ChallengeKey => true,
      CityKey => true,
      IronKey => true,
      IcebergKey => true,
      EasyUnlocked => true,
      ChallengeUnlocked => true,
      CityUnlocked => true,
      IronUnlocked => true,
      IcebergUnlocked => true,
      _ => false,
    };
  }
  public void SetKey(bool state, int keyIndex) {
    if (!state) {
      Array.Copy(BitConverter.GetBytes(zero), 0, Data, 0x28 + (keyIndex * 4), 4);
    } else {
      var xorkey = keyIndex switch {
        0 => EasyKey,
        1 => ChallengeKey,
        2 => CityKey,
        3 => IronKey,
        4 => IcebergKey,
        5 => EasyUnlocked,
        6 => ChallengeUnlocked,
        7 => CityUnlocked,
        8 => IronUnlocked,
        9 => IcebergUnlocked,
        //Invalid index, this should never happen
        _ => zero,
      };
      Array.Copy(BitConverter.GetBytes(ID ^ xorkey), 0, Data, 0x28 + (keyIndex * 4), 4);
    }

  }

  private uint ID {
    get { return BitConverter.ToUInt32(Data, 0x5C); }
    set { BitConverter.GetBytes(value).CopyTo(Data, 0x5C); }
  }
}
