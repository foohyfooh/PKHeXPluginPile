namespace PluginPile.Unmaintained.BWTool;
public class DreamRadarKey {
  internal int Size = 0xF0;

  public readonly byte[] Data;
  public DreamRadarKey(byte[] data) {
    Data = data;
  }

  public uint unknown1 { //Not sure how this is used/updated by 3DS link data block
    get { return BitConverter.ToUInt32(Data, 0x00); }
    set { BitConverter.GetBytes(value).CopyTo(Data, 0x00); }
  }

  public byte FLAGS { get { return Data[0x04]; } set { Data[0x04] = value; } }
  public bool Tornadus { get { return (FLAGS & (1 << 0)) == 1 << 0; } set { FLAGS = (byte)(FLAGS & ~(1 << 0) | (value ? 1 << 0 : 0)); } }
  public bool Thundurus { get { return (FLAGS & (1 << 1)) == 1 << 1; } set { FLAGS = (byte)(FLAGS & ~(1 << 1) | (value ? 1 << 1 : 0)); } }
  public bool Landorus { get { return (FLAGS & (1 << 2)) == 1 << 2; } set { FLAGS = (byte)(FLAGS & ~(1 << 2) | (value ? 1 << 2 : 0)); } }
  public bool Dialga { get { return (FLAGS & (1 << 3)) == 1 << 3; } set { FLAGS = (byte)(FLAGS & ~(1 << 3) | (value ? 1 << 3 : 0)); } }
  public bool Palkia { get { return (FLAGS & (1 << 4)) == 1 << 4; } set { FLAGS = (byte)(FLAGS & ~(1 << 4) | (value ? 1 << 4 : 0)); } }
  public bool Giratina { get { return (FLAGS & (1 << 5)) == 1 << 5; } set { FLAGS = (byte)(FLAGS & ~(1 << 5) | (value ? 1 << 5 : 0)); } }
  public bool HoOh { get { return (FLAGS & (1 << 6)) == 1 << 6; } set { FLAGS = (byte)(FLAGS & ~(1 << 6) | (value ? 1 << 6 : 0)); } }
  public bool Lugia { get { return (FLAGS & (1 << 7)) == 1 << 7; } set { FLAGS = (byte)(FLAGS & ~(1 << 7) | (value ? 1 << 7 : 0)); } }

  //This value is set to 0x01 when 3DS Link has been used at least once and seems to remain that way
  public bool used { get { return (Data[0x08] & (1 << 0)) == 1 << 0; } set { Data[0x08] = (byte)(Data[0x08] & ~(1 << 0) | (value ? 1 << 0 : 0)); } }

  //Call this to clean all data so legendaries can be received again. Must be used with the other classes reinit() for it to work
  public void reinit() {
    unknown1 = 0;
    FLAGS = 0;
    used = false;
  }

}
public class DreamRadarA {
  private const uint ident = 0x43524746;

  public readonly byte[] Data;
  public DreamRadarA(byte[] data) {
    Data = data;
  }

  //This value is set to 0x01 when 3DS Link has data to be received and 0x00 when no data/data already received
  public bool received { get { return (Data[0x00] & (1 << 0)) == 1 << 0; } set { Data[0x00] = (byte)(Data[0x00] & ~(1 << 0) | (value ? 1 << 0 : 0)); } }

  public uint unknown1 { //derived from offset 0x25E00 (0x00000000 if the Pokemon were not yet received)
    get { return BitConverter.ToUInt32(Data, 0x04); }
    set { BitConverter.GetBytes(value).CopyTo(Data, 0x04); }
  }

  public uint Ident { //always 0x43524746 (CRGF)
    get { return BitConverter.ToUInt32(Data, 0x08); }
    set { BitConverter.GetBytes(ident).CopyTo(Data, 0x08); }
  }

  //Encryption Key used for the next transfer from DR (0x00000000 if the Pokemon were not yet received) --> Also seems to hold the lengedary flags!
  public uint key {
    get { return BitConverter.ToUInt32(Data, 0x0C); }
    set { BitConverter.GetBytes(value).CopyTo(Data, 0x0C); }
  }

  //Call this to clean all data so legendaries can be received again. Must be used with the other classes reinit() for it to work
  public void reinit() {
    received = true;
    unknown1 = 0;
    Ident = ident;
    key = 0;
  }
}
public class DreamRadarB {
  public const int Size = 0x80;

  public readonly byte[] Data;
  private readonly uint[] legendaries = new uint[8];
  private readonly uint[] pokes = new uint[6];
  private readonly uint[] items = new uint[6];

  public DreamRadarB(byte[] data) {
    Data = data;

    //Read the legendary values
    for (int i = 0; i < 8; i++) {
      legendaries[i] = BitConverter.ToUInt32(Data, 0x00 + i * 4);
    }

    //Read pokemon
    for (int i = 0; i < 6; i++) {
      pokes[i] = BitConverter.ToUInt32(Data, 0x20 + i * 4);
    }

    //Read items
    for (int i = 0; i < 6; i++) {
      items[i] = BitConverter.ToUInt32(Data, 0x38 + i * 4);
    }

    //Check legality of data
    illegal = false;
    for (int i = 0; i < 6; i++) {
      for (int j = 0; j < 19; j++) {
        if (get_poke_species(i) == legit_pk_index[j]) {
          break; //Found valid index, continue next pokémon
        } else if ((get_poke_species(i) != legit_pk_index[j]) && j == 18) //Couldn't find valid species index
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
          if (get_item_id(i) == legit_item_index[j]) {
            break; //Found valid index, continue next item
          } else if ((get_item_id(i) != legit_item_index[j]) && j == 23) { //Couldn't find valid item index
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

  public readonly uint[] legendary_index = new uint[] { 0, Tornadus, Thundurus, Landorus, Dialga, Palkia, Giratina, HoOh, Lugia};
  
  public readonly int[] legit_pk_index = new int[] { 0, 79, 120, 137, 163, 174, 175, 213, 238, 280, 333, 374, 425, 436, 442, 447, 479, 517, 561 };
  public readonly int[] legit_item_index = new int[] { 0, 72, 73, 74, 75, 51, 154, 28, 29, 80, 109, 81, 82, 83, 84, 85, 91, 93, 270, 275, 538, 44, 50, 221 };

  public bool illegal;

  public int get_legend(int index) {
    return legendaries[index] switch {
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

  public void set_legend(uint legend, int index) {
    BitConverter.GetBytes(legend).CopyTo(Data, 0x00 + index * 4);
  }  

  public int get_poke_species(int index) {
    return (int)pokes[index] >> 16;
  }

  public int get_poke_gender(int index) {
    return (int)pokes[index] & 0x0000000F;
  }

  public void set_poke(int species, int gender, int index) {
    int finalgender = gender;

    //Set fixed gender species regardless of user choice
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

    pokes[index] = (uint)(finalgender | (species << 16));
    BitConverter.GetBytes(pokes[index]).CopyTo(Data, 0x20 + index * 4);
  }

  public int get_item_id(int index) {
    return (int)items[index] >> 16;
  }

  public int get_item_amount(int index) {
    //Even though item amount is stored as u16, only the least byte is used, so maximum is 255
    if (((int)items[index] & 0x0000FFFF) < 255) {
      return (int)items[index] & 0x0000FFFF;
    } else return 255;
  }

  public void set_item(int amount, int id, int index) {
    if (amount == 0 && id > 0) { //Put 1 of an item if it's 0
      items[index] = (uint)((id << 16) | 1);
    } else if (id == 0) {
      items[index] = 0;
    } else {
      items[index] = (uint)((id << 16) | amount);
    }
    BitConverter.GetBytes(items[index]).CopyTo(Data, 0x38 + index * 4);
  }

  public uint EncKey {
    get { return BitConverter.ToUInt32(Data, 0x7C); }
    set { BitConverter.GetBytes(value).CopyTo(Data, 0x7C); }
  }

  public void reinit() { //Call this to clean all data so legendaries can be received again. Must be used with the other classes reinit() for it to work
    for (int i = 0; i < Size; i++) {
      Data[i] = 0;
    }
  }

  public void clean_data() {
    for (int i = 0; i < Size - 4; i++) {
      Data[i] = 0;
    }
  }

  //Some arrays for gender filter
  private readonly int[] male_only = new int[] { 32, 33, 34, 106, 107, 128, 237, 313, 414, 475, 538, 539, 627, 628, 236, 381, 641, 642, 645 };
  private readonly int[] female_only = new int[] { 29, 113, 115, 124, 241, 242, 314, 413, 416, 478, 548, 549, 629, 630, 30, 31, 238, 380, 440, 488 };
  private readonly int[] genderless = new int[] { 81, 82, 100, 101, 120, 121, 137, 233, 292, 337, 338, 343, 344, 374, 375, 376, 436, 437, 462, 474, 479, 489, 490, 599, 600, 601, 615, 622, 623, 132, 144, 145, 146, 150, 151, 201, 243, 244, 245, 249, 250, 251, 377, 378, 379, 382, 383, 384, 385, 386, 480, 481, 482, 483, 484, 486, 487, 491, 492, 493, 494, 638, 639, 640, 643, 644, 646, 647, 648, 649 };

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

