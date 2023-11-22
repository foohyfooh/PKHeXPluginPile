namespace PluginPile.Unmaintained.BWTool;
public class ExtralinkForest {

  //private int Size = SAV is SAV5BW ? SAV.getBlockLength(Constants.BW.Forest) : SAV.getBlockLength(Constants.B2W2.Forest);

  public byte[] Data;
  public ExtralinkForest(byte[] data) {
    Data = data;
  }

  private int area = 4;
  private int indexpkm = 0;
  private int total_areas = (9 * 3) + 1;
  private int area_size = 0x50;
  private int deep_area_size = 0x28;
  private int pkmnsize = 4;

  public int Area {
    get { return area; }
    set { if ((value >= 0) && (value < total_areas)) { area = value; } }
  }

  public int Indexpkm {
    get { return indexpkm; }
    set { if ((value >= 0) && (value < 20)) { indexpkm = (value); } }
  }

  public byte Unlock9 {
    get { return Data[0x848]; }
    set { Data[0x848] = value; }
  }

  public byte Unlock8 {
    get { return Data[0x849]; }
    set { Data[0x849] = value; }
  }

  internal int get_pkmoffset() {
    if (area == 0) { //Deepest area
      if (indexpkm > 19) return -1;
      return indexpkm * pkmnsize;
    } else if (area > 0 && area < 4) { //Area 9 ony holds 10 pokes
      if (indexpkm > 9) return -1;
      return area_size + (indexpkm * pkmnsize) + deep_area_size * area - deep_area_size;
    } else if (area > 3 && area < 28) { //Areas 1-8
      if (indexpkm > 19) return -1;
      return area_size + (deep_area_size * 3) + ((area - 4) * area_size) + (indexpkm * pkmnsize);
    }
    return -1;
  }

  public void dump_area() {
    int tmp_slot = indexpkm;
    byte[] phl = new byte[4 * 20];
    indexpkm = 0;

    if (area > 0 && area < 4) { //Area 9 ony holds 10 pokes
      for (indexpkm = 0; indexpkm < 10; indexpkm++) {
        BitConverter.GetBytes(get_pkm()).CopyTo(phl, indexpkm * 4);
      }
    } else {
      for (indexpkm = 0; indexpkm < 20; indexpkm++) {
        BitConverter.GetBytes(get_pkm()).CopyTo(phl, indexpkm * 4);
      }
    }

    indexpkm = tmp_slot;
    FileIO.SaveFile(phl, "Entree Forest Area data|*.phl|All Files (*.*)|*.*");
  }

  public void import_area() {
    byte[]? phl = new byte[4 * 20];
    string? path = null;
    int res = FileIO.LoadFile(ref phl, ref path, "Entree Forest Area data|*.phl|All Files (*.*)|*.*");
    if (res == -1) return;

    uint temp_pkm;
    indexpkm = 0;

    if (area > 0 && area < 4) { //Area 9 ony holds 10 pokes
      for (indexpkm = 0; indexpkm < 10; indexpkm++) {
        temp_pkm = BitConverter.ToUInt32(phl!, indexpkm * 4);
        edit_pkm(temp_pkm);
      }
    } else {
      for (indexpkm = 0; indexpkm < 20; indexpkm++) {
        temp_pkm = BitConverter.ToUInt32(phl!, indexpkm * 4);
        edit_pkm(temp_pkm);
      }
    }

    indexpkm = 0;
  }

  public void export_forest() {
    FileIO.SaveFile(Data, "Entralink Forest Decrypted Data|*.efdd|All Files (*.*)|*.*");
  }

  public void import_forest() {
    byte[] forest = new byte[2304];
    string? path = null;
    FileIO.LoadFile(ref forest!, ref path, "Entralink Forest Decrypted Data|*.efdd|All Files (*.*)|*.*");
    Data = forest;
    indexpkm = 0;
  }

  /*
  Pokemon Structure (4 bytes)
  Bits
  00-10   Species
  11-20   Special Move
  21-22   Gender (0 -> male, 1 -> female, 2 -> genderless)
  23-27   Form
  28-31   Animation (only even numbers allowed, last bit makes Pokemon invisible)
  */
  private int species;
  private int move;
  private int gender;
  private int form;
  private int animation;

  public int Species {
    get { return (BitConverter.ToInt32(Data, get_pkmoffset()) & 0x7FF); }
    set { species = value; }
  }
  public int Move {
    get { return ((BitConverter.ToInt32(Data, get_pkmoffset()) & 0x1FF800) >> 11); }
    set { move = value; }
  }
  public int Gender {
    get { return ((BitConverter.ToInt32(Data, get_pkmoffset()) & 0x600000) >> 21); }
    set { gender = value; }
  }
  public int Form {
    get { return ((BitConverter.ToInt32(Data, get_pkmoffset()) & 0xF800000) >> 23); }
    set { form = value; }
  }
  public int Animation {
    get { return (int)((BitConverter.ToInt32(Data, get_pkmoffset()) & 0xF0000000) >> 28); }
    set { animation = value; }
  }

  //Just return if there's a valid pkm in current slot
  public bool is_pkm_empty() {
    if (Species == 0)
      return true;
    else
      return false;
  }
  public uint get_pkm() //Relies on current indexpkm
  {
    return BitConverter.ToUInt32(Data, get_pkmoffset());
  }
  //Build a u32 pkm for entralink forest
  public uint create_pkm(int sp, int mv, int gdr, int frm, int anim) {
    return unchecked((uint)((sp & 0x7FF) | ((mv & 0x3FF) << 11) | ((gdr & 0x3) << 21) | ((frm & 0x1F) << 23) | ((anim & 0xF) << 28)));
  }
  //Sets pkm data to current slot
  public void edit_pkm(uint pkm) {
    Array.Copy(BitConverter.GetBytes(pkm), 0, Data, get_pkmoffset(), 4);
  }
  //Sets pkm data to first available slot, if there's one
  public void add_pkm(uint pkm) {
    int tmp_slot = indexpkm;
    bool found_empty = false;
    //Find first available slot
    if (area > 0 && area < 4) //Area 9 ony holds 10 pokes
    {
      for (indexpkm = 0; indexpkm < 10; indexpkm++) {
        if (is_pkm_empty() == true) {
          found_empty = true;
          break;
        }
      }
    } else {
      for (indexpkm = 0; indexpkm < 20; indexpkm++) {
        if (is_pkm_empty() == true) {
          found_empty = true;
          break;
        }
      }
    }

    if (found_empty == true)
      Array.Copy(BitConverter.GetBytes(pkm), 0, Data, get_pkmoffset(), 4);
    else
      MessageBox.Show("There are no free slots in this area.");

    indexpkm = tmp_slot;
  }
  //deletes current slot
  //todo: move all slots up
  public void delete_pkm() {
    int tmp_slot = indexpkm;
    uint temp_pkm = 0;

    //Delete selected pkm
    uint delete = 0;
    Array.Copy(BitConverter.GetBytes(delete), 0, Data, get_pkmoffset(), 4);

    //Move all pkm up 1 slot
    int i;
    if (area > 0 && area < 4) //Area 9 ony holds 10 pokes
    {
      if (indexpkm != 9)//If user didn't delete last slot
      {
        for (i = indexpkm; i < 9; i++) {
          //Get next pkm
          indexpkm = indexpkm + 1;
          temp_pkm = BitConverter.ToUInt32(Data, get_pkmoffset());
          //Set to previous slot
          indexpkm = indexpkm - 1;
          edit_pkm(temp_pkm);
          //Return index to next slot
          indexpkm = indexpkm + 1;
        }
        //Now empty last slot
        temp_pkm = 0;
        edit_pkm(temp_pkm);
      }
    } else {
      if (indexpkm != 19)//If user didn't delete last slot
      {
        for (i = indexpkm; i < 19; i++) {
          //Get next pkm
          indexpkm = indexpkm + 1;
          temp_pkm = BitConverter.ToUInt32(Data, get_pkmoffset());
          //Set to previous slot
          indexpkm = indexpkm - 1;
          edit_pkm(temp_pkm);
          //Return index to next slot
          indexpkm = indexpkm + 1;
        }
        //Now empty last slot
        temp_pkm = 0;
        edit_pkm(temp_pkm);
      }
    }

    indexpkm = tmp_slot;
  }
}

/* Structure gathered by BlackShark

General Structure
0x000   encrypted data
0x84C   initial encryption seed
0x850   update counter
0x852   checksum from 0x000 to 0x84F (CRC16-CCITT)

Decrypted Data Structure (0x000 - 0x84B)
20 Pokemon in each area from 1 - 8 as well as in the deepest area.
10 Pokemon in 9th area.
So they let you store a total of 530 Pokemon there!

0x000   Deepest Area
0x050   9th Area center
0x078   9th Area left
0x0A0   9th Area right
0x0C8   1st Area center
0x118   1st Area left
0x168   1st Area right
0x1B8   2nd Area center
0x208   2nd Area left
0x258   2nd Area right
0x2A8   3rd Area center
0x2F8   3rd Area left
0x348   3rd Area right
0x398   4th Area center
0x3E8   4th Area left
0x438   4th Area right
0x488   5th Area center
0x4D8   5th Area left
0x528   5th Area right
0x578   6th Area center
0x5C8   6th Area left
0x618   6th Area right
0x668   7th Area center
0x6B8   7th Area left
0x708   7th Area right
0x758   8th Area center
0x7A8   8th Area left
0x7F8   8th Area right
0x848   Unlock Area 9 (0x01 to unlock)
0x849   Unlock Areas 3 - 8 (0x00 - 0x06, any higher value will corrupt your forest!) (Area 1 & 2 and the deepest Area are unlocked by default -> 0x00)
0x84A   0x00
0x84B   0x00

Pokemon Structure (4 bytes)
Bits
00-10   Species
11-20   Special Move
21-22   Gender (0 -> male, 1 -> female, 2 -> genderless)
23-27   Form
28-31   Animation (only even numbers allowed, last bit makes Pokemon invisible)
*/
