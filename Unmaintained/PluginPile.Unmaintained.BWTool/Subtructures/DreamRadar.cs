namespace PluginPile.Unmaintained.BWTool;
public class DreamRadarKey(byte[] data) {
  internal int Size = 0xF0;

  public readonly byte[] Data = data;

  public uint Unknown1 { //Not sure how this is used/updated by 3DS link data block
    get => BitConverter.ToUInt32(Data, 0x00);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x00);
  }

  public byte FLAGS { get => Data[0x04]; set => Data[0x04] = value; }
  public bool Tornadus { get => (FLAGS & (1 << 0)) == 1 << 0; set => FLAGS = (byte)(FLAGS & ~(1 << 0) | (value ? 1 << 0 : 0)); }
  public bool Thundurus { get => (FLAGS & (1 << 1)) == 1 << 1; set => FLAGS = (byte)(FLAGS & ~(1 << 1) | (value ? 1 << 1 : 0)); }
  public bool Landorus { get => (FLAGS & (1 << 2)) == 1 << 2; set => FLAGS = (byte)(FLAGS & ~(1 << 2) | (value ? 1 << 2 : 0)); }
  public bool Dialga { get => (FLAGS & (1 << 3)) == 1 << 3; set => FLAGS = (byte)(FLAGS & ~(1 << 3) | (value ? 1 << 3 : 0)); }
  public bool Palkia { get => (FLAGS & (1 << 4)) == 1 << 4; set => FLAGS = (byte)(FLAGS & ~(1 << 4) | (value ? 1 << 4 : 0)); }
  public bool Giratina { get => (FLAGS & (1 << 5)) == 1 << 5; set => FLAGS = (byte)(FLAGS & ~(1 << 5) | (value ? 1 << 5 : 0)); }
  public bool HoOh { get => (FLAGS & (1 << 6)) == 1 << 6; set => FLAGS = (byte)(FLAGS & ~(1 << 6) | (value ? 1 << 6 : 0)); }
  public bool Lugia { get => (FLAGS & (1 << 7)) == 1 << 7; set => FLAGS = (byte)(FLAGS & ~(1 << 7) | (value ? 1 << 7 : 0)); }

  //This value is set to 0x01 when 3DS Link has been used at least once and seems to remain that way
  public bool Used { get { return (Data[0x08] & (1 << 0)) == 1 << 0; } set { Data[0x08] = (byte)(Data[0x08] & ~(1 << 0) | (value ? 1 << 0 : 0)); } }

  //Call this to clean all data so legendaries can be received again. Must be used with the other classes ReInit() for it to work
  public void ReInit() {
    Unknown1 = 0;
    FLAGS = 0;
    Used = false;
  }

}
public class DreamRadarA(byte[] data) {
  private const uint ident = 0x43524746;

  public readonly byte[] Data = data;

  //This value is set to 0x01 when 3DS Link has data to be received and 0x00 when no data/data already received
  public bool Received { get { return (Data[0x00] & (1 << 0)) == 1 << 0; } set { Data[0x00] = (byte)(Data[0x00] & ~(1 << 0) | (value ? 1 << 0 : 0)); } }

  public uint Unknown1 { //derived from offset 0x25E00 (0x00000000 if the Pokemon were not yet received)
    get => BitConverter.ToUInt32(Data, 0x04);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x04);
  }

  public uint Ident { //always 0x43524746 (CRGF)
    get => BitConverter.ToUInt32(Data, 0x08);
    set => BitConverter.GetBytes(ident).CopyTo(Data, 0x08);
  }

  //Encryption Key used for the next transfer from DR (0x00000000 if the Pokemon were not yet received) --> Also seems to hold the lengedary flags!
  public uint Key {
    get => BitConverter.ToUInt32(Data, 0x0C);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x0C);
  }

  //Call this to clean all data so legendaries can be received again. Must be used with the other classes ReInit() for it to work
  public void ReInit() {
    Received = true;
    Unknown1 = 0;
    Ident = ident;
    Key = 0;
  }
}
public class DreamRadarB {
  public const int Size = 0x80;

  public readonly byte[] Data;
  private readonly uint[] Legendaries = new uint[8];
  private readonly uint[] Pokes = new uint[6];
  private readonly uint[] Items = new uint[6];

  public DreamRadarB(byte[] data) {
    Data = data;

    //Read the legendary values
    for (int i = 0; i < 8; i++) {
      Legendaries[i] = BitConverter.ToUInt32(Data, 0x00 + i * 4);
    }

    //Read pokemon
    for (int i = 0; i < 6; i++) {
      Pokes[i] = BitConverter.ToUInt32(Data, 0x20 + i * 4);
    }

    //Read items
    for (int i = 0; i < 6; i++) {
      Items[i] = BitConverter.ToUInt32(Data, 0x38 + i * 4);
    }

    //Check legality of data
    illegal = false;
    for (int i = 0; i < 6; i++) {
      for (int j = 0; j < 19; j++) {
        if (GePokeSpecies(i) == legit_pk_index[j]) {
          break; //Found valid index, continue next pokémon
        } else if ((GePokeSpecies(i) != legit_pk_index[j]) && j == 18) //Couldn't find valid species index
          {
          illegal = true;
        }
      }
      if (illegal == true) // No need to continue
        break;
    }

    if (illegal == false) {
      for (int i = 0; i < 6; i++) {
        for (int j = 0; j < 24; j++) {
          if (GetItemId(i) == legit_item_index[j]) {
            break; //Found valid index, continue next item
          } else if ((GetItemId(i) != legit_item_index[j]) && j == 23) { //Couldn't find valid item index
            illegal = true;
          }
        }
        if (illegal == true) // No need to continue
          break;
      }
    }

  }

  public const uint Tornadus = 0x80808080;
  public const uint Thundurus = 0x92567284;
  public const uint Landorus = 0x87643567;
  public const uint Dialga = 0x96436763;
  public const uint Palkia = 0x43867368;
  public const uint Giratina = 0x17693572;
  public const uint HoOh = 0x44798367;
  public const uint Lugia = 0x96636983;

  public readonly uint[] legendary_index = [0, Tornadus, Thundurus, Landorus, Dialga, Palkia, Giratina, HoOh, Lugia];

  /*
   * 079 - Slowpoke
   * 120 - Staryu
   * 137 - Porygon
   * 163 - Hoothoot
   * 174 - Igglybuff
   * 175 - Togepi
   * 213 - Shuckle
   * 238 - Smoochum
   * 280 - Ralts
   * 333 - Swablu
   * 374 - Beldum
   * 425 - Drifloon
   * 436 - Bronzor
   * 442 - Spiritomb
   * 447 - Riolu
   * 479 - Rotom
   * 517 - Munna
   * 561 - Sigilyph
   */
  public readonly int[] legit_pk_index = [0, 79, 120, 137, 163, 174, 175, 213, 238, 280, 333, 374, 425, 436, 442, 447, 479, 517, 561];

  /*
   * Red Shard
   * Blue Shard
   * Yellow Shard
   * Green Shard
   * PP Up
   * Leppa Berry
   * Revive
   * Max Revive
   * Sun Stone
   * Dawn Stone
   * Moon Stone
   * Fire Stone
   * Thunderstone
   * Water Stone
   * Leaf Stone
   * Star Piece
   * Heart Scale
   * Life Orb
   * Focus Sash
   * Eviolite
   * Sacred Ash
   * Rare Candy
   * King's Rock
   */
  public readonly int[] legit_item_index = [0, 72, 73, 74, 75, 51, 154, 28, 29, 80, 109, 81, 82, 83, 84, 85, 91, 93, 270, 275, 538, 44, 50, 221];

  public bool illegal;

  public int GetLegend(int index) {
    return Legendaries[index] switch {
      Tornadus => 1,
      Thundurus => 2,
      Landorus => 3,
      Dialga => 4,
      Palkia => 5,
      Giratina => 6,
      HoOh => 7,
      Lugia => 8,
      _ => 0,
    };
  }

  public void SetLegend(uint legend, int index) {
    BitConverter.GetBytes(legend).CopyTo(Data, 0x00 + index * 4);
  }

  public int GePokeSpecies(int index) {
    return (int)Pokes[index] >> 16;
  }

  public int GetPokeGender(int index) {
    return (int)Pokes[index] & 0x0000000F;
  }

  public void SetPoke(int species, int gender, int index) {
    int finalgender = gender;

    //Set fixed Gender species regardless of user choice
    if (species == 0) {
      finalgender = 0;
    } else {
      for (int i = 0; i < male_only.Length; i++) {
        if (species == male_only[i])
          finalgender = 0;
      }
      for (int i = 0; i < female_only.Length; i++) {
        if (species == female_only[i])
          finalgender = 1;
      }
      for (int i = 0; i < genderless.Length; i++) {
        if (species == genderless[i])
          finalgender = 2;
      }
    }

    Pokes[index] = (uint)(finalgender | (species << 16));
    BitConverter.GetBytes(Pokes[index]).CopyTo(Data, 0x20 + index * 4);
  }

  public int GetItemId(int index) {
    return (int)Items[index] >> 16;
  }

  public int GetItemAmount(int index) {
    //Even though item amount is stored as u16, only the least byte is used, so maximum is 255
    if (((int)Items[index] & 0x0000FFFF) < 255) {
      return (int)Items[index] & 0x0000FFFF;
    } else return 255;
  }

  public void SetItem(int amount, int id, int index) {
    if (amount == 0 && id > 0) { //Put 1 of an item if it's 0
      Items[index] = (uint)((id << 16) | 1);
    } else if (id == 0) {
      Items[index] = 0;
    } else {
      Items[index] = (uint)((id << 16) | amount);
    }
    BitConverter.GetBytes(Items[index]).CopyTo(Data, 0x38 + index * 4);
  }

  public uint EncKey {
    get => BitConverter.ToUInt32(Data, 0x7C);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x7C);
  }

  public void ReInit() { //Call this to clean all data so legendaries can be received again. Must be used with the other classes ReInit() for it to work
    for (int i = 0; i < Size; i++) {
      Data[i] = 0;
    }
  }

  public void CleanData() {
    for (int i = 0; i < Size - 4; i++) {
      Data[i] = 0;
    }
  }

  //Some arrays for gender filter
  private readonly int[] male_only = [32, 33, 34, 106, 107, 128, 237, 313, 414, 475, 538, 539, 627, 628, 236, 381, 641, 642, 645];
  private readonly int[] female_only = [29, 113, 115, 124, 241, 242, 314, 413, 416, 478, 548, 549, 629, 630, 30, 31, 238, 380, 440, 488];
  private readonly int[] genderless = [81, 82, 100, 101, 120, 121, 137, 233, 292, 337, 338, 343, 344, 374, 375, 376, 436, 437, 462, 474, 479, 489, 490, 599, 600, 601, 615, 622, 623, 132, 144, 145, 146, 150, 151, 201, 243, 244, 245, 249, 250, 251, 377, 378, 379, 382, 383, 384, 385, 386, 480, 481, 482, 483, 484, 486, 487, 491, 492, 493, 494, 638, 639, 640, 643, 644, 646, 647, 648, 649];

}

//3DS Link structure research by BlackShark: https://projectpokemon.org/forums/forums/topic/40323-white-2-dream-radar-flags/

/*
Save Offset  0x25E00
0x00  unknown (changes when the data is received)
0x04  legendary received flags
0x08  1 after DR data was received the first time, does not increase

Legendary received flags
Bit Pokemon
0   Tornadus
1   Thundurus
2   Landorus
3   Dialga
4   Palkia
5   Giratina
6   Ho-Oh
7   Lugia
======================================================================

Save Offset  0x7F000 (the Dream Radar itself only touches this area!)

0x00         received/not received flag (1 after the Pokemon were received)
0x01 - 0x03  0x000000
0x04 - 0x07  unknown (derived from offset 0x25E00) (0x00000000 if the Pokemon were not yet received)
0x08 - 0x0B  always 0x43524746 (CRGF)
0x0C - 0x0F  Encryption Key used for the next transfer from DR (0x00000000 if the Pokemon were not yet received) --> Also seems to hold the lengedary flags!
0x10 - 0x11  CRC-16-CCITT over 0x00 - 0x0F
0x12 - 0x13  0x0000
0x14 - 0x33  legendary Pokemon (see values below) (8 x 4 Bytes)
0x34 - 0x4B  normal Pokemon (6 x 4 Bytes)
0x4C - 0x63  Items (6 x 4 Bytes)
0x63 - 0x8F  probably unused (all zero)
0x90 - 0x93  Decryption Key
0x94 - 0x95  CRC-16-CCITT over 0x14 - 0x93
0x96 - 0x97  0x0000

Legendary Pokemon Values
0x80808080  Tornadus
0x92567284  Thundurus
0x87643567  Landorus
0x96436763  Dialga
0x43867368  Palkia
0x17693572  Giratina
0x44798367  Ho-Oh
0x96636983  Lugia

Pokemon Structure
0x00         Gender (0 - Male, 1 - Female, 2 - Genderless)
0x01         unknown/unused
0x02 - 0x03  Species ID

Item Structure
0x00 - 0x01  Quantity
0x02 - 0x03  Item ID

*/
