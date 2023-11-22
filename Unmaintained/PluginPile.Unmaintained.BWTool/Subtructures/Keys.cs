namespace PluginPile.Unmaintained.BWTool;
public class Keys {
  public readonly byte[] Data;
  public Keys(byte[] data) {
    Data = data;
  }
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
  private const uint easykey = 0x00035691;
  private const uint challengekey = 0x00018256;
  private const uint citykey = 0x00059389;
  private const uint ironkey = 0x00048292;
  private const uint icebergkey = 0x00009892;
  private const uint easy_u = 0x00093389;
  private const uint challenge_u = 0x00022843;
  private const uint city_u = 0x00034771;
  private const uint iron_u = 0x000AB031;
  private const uint iceberg_u = 0x000B3818;
  private uint[] difficult_cfg = new uint[4] { 0x0, 0x00031239, 0x00015657, 0x00049589 };
  private uint[] city_cfg = new uint[3] { 0x0, 0x00034525, 0x00011963 };
  private uint[] chamber_cfg = new uint[4] { 0x0, 0x00094525, 0x00081963, 0x00038569 };
  private const uint zero = 0;

  public bool KeysUnlocked() {
    for (int i = 0; i < 0x5C; i++) {
      if (Data[i] != 0x00)
        return true;
    }
    return false;
  }

  public int getConfig(int configIndex) {
    if (configIndex == 0) {
      for (int i = 0; i < 4; i++) {
        if (getKeyXor(10) == difficult_cfg[i]) {
          return i;
        }
      }
      return 0;
    } else if (configIndex == 1) {
      for (int i = 0; i < 3; i++) {
        if (getKeyXor(11) == city_cfg[i]) {
          return i;
        }
      }
      return 0;
    } else if (configIndex == 2) {
      for (int i = 0; i < 4; i++) {
        if (getKeyXor(12) == chamber_cfg[i]) {
          return i;
        }
      }
      return 0;
    } else {
      return 0;
    }
  }
  private uint getKey(int keyIndex) {
    return BitConverter.ToUInt32(Data, 0x28 + (keyIndex * 4));
  }
  private uint getKeyXor(int keyIndex) {
    return getKey(keyIndex) ^ ID;
  }
  public bool getKeyState(int keyIndex) {
    return getKeyXor(keyIndex) switch {
      easykey => true,
      challengekey => true,
      citykey => true,
      ironkey => true,
      icebergkey => true,
      easy_u => true,
      challenge_u => true,
      city_u => true,
      iron_u => true,
      iceberg_u => true,
      _ => false,
    };
  }
  public void setKey(bool state, int keyIndex) {
    if (!state) {
      Array.Copy(BitConverter.GetBytes(zero), 0, Data, 0x28 + (keyIndex * 4), 4);
    } else {
      var xorkey = keyIndex switch {
        0 => easykey,
        1 => challengekey,
        2 => citykey,
        3 => ironkey,
        4 => icebergkey,
        5 => easy_u,
        6 => challenge_u,
        7 => city_u,
        8 => iron_u,
        9 => iceberg_u,
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
