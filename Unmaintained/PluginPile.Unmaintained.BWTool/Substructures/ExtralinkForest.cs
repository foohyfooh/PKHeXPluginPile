namespace PluginPile.Unmaintained.BWTool;
public class ExtralinkForest(byte[] data) {

  public byte[] Data = data;
  private int InternalArea = 4;
  private int InternalIndexPkm = 0;
  private readonly int TotalAreas = (9 * 3) + 1;
  private readonly int AreaSize = 0x50;
  private readonly int DeepAreaSize = 0x28;
  private readonly int PkmnSize = 4;

  public int Area {
    get => InternalArea;
    set { if ((value >= 0) && (value < TotalAreas)) { InternalArea = value; } }
  }

  public int IndexPkm {
    get => InternalIndexPkm;
    set { if ((value >= 0) && (value < 20)) { InternalIndexPkm = (value); } }
  }

  public byte Unlock9 {
    get => Data[0x848];
    set => Data[0x848] = value;
  }

  public byte Unlock8 {
    get => Data[0x849];
    set => Data[0x849] = value;
  }

  internal int GetPkmoffset() {
    if (InternalArea == 0) { //Deepest InternalArea
      if (InternalIndexPkm > 19) return -1;
      return InternalIndexPkm * PkmnSize;
    } else if (InternalArea > 0 && InternalArea < 4) { //Area 9 ony holds 10 pokes
      if (InternalIndexPkm > 9) return -1;
      return AreaSize + (InternalIndexPkm * PkmnSize) + DeepAreaSize * InternalArea - DeepAreaSize;
    } else if (InternalArea > 3 && InternalArea < 28) { //Areas 1-8
      if (InternalIndexPkm > 19) return -1;
      return AreaSize + (DeepAreaSize * 3) + ((InternalArea - 4) * AreaSize) + (InternalIndexPkm * PkmnSize);
    }
    return -1;
  }

  public void DumpArea() {
    int tmp_slot = InternalIndexPkm;
    byte[] phl = new byte[4 * 20];
    InternalIndexPkm = 0;

    if (InternalArea > 0 && InternalArea < 4) { //Area 9 ony holds 10 pokes
      for (InternalIndexPkm = 0; InternalIndexPkm < 10; InternalIndexPkm++) {
        BitConverter.GetBytes(GetPkm()).CopyTo(phl, InternalIndexPkm * 4);
      }
    } else {
      for (InternalIndexPkm = 0; InternalIndexPkm < 20; InternalIndexPkm++) {
        BitConverter.GetBytes(GetPkm()).CopyTo(phl, InternalIndexPkm * 4);
      }
    }

    InternalIndexPkm = tmp_slot;
    FileIO.SaveFile(phl, "Entree Forest Area data|*.phl|All Files (*.*)|*.*");
  }

  public void ImportArea() {
    byte[]? phl = new byte[4 * 20];
    string? path = null;
    int res = FileIO.LoadFile(ref phl, ref path, "Entree Forest Area data|*.phl|All Files (*.*)|*.*");
    if (res == -1) return;

    uint temp_pkm;
    InternalIndexPkm = 0;

    if (InternalArea > 0 && InternalArea < 4) { //Area 9 ony holds 10 pokes
      for (InternalIndexPkm = 0; InternalIndexPkm < 10; InternalIndexPkm++) {
        temp_pkm = BitConverter.ToUInt32(phl!, InternalIndexPkm * 4);
        EditPkm(temp_pkm);
      }
    } else {
      for (InternalIndexPkm = 0; InternalIndexPkm < 20; InternalIndexPkm++) {
        temp_pkm = BitConverter.ToUInt32(phl!, InternalIndexPkm * 4);
        EditPkm(temp_pkm);
      }
    }

    InternalIndexPkm = 0;
  }

  public void ExportForest() {
    FileIO.SaveFile(Data, "Entralink Forest Decrypted Data|*.efdd|All Files (*.*)|*.*");
  }

  public void ImportForest() {
    byte[] forest = new byte[2304];
    string? path = null;
    FileIO.LoadFile(ref forest!, ref path, "Entralink Forest Decrypted Data|*.efdd|All Files (*.*)|*.*");
    Data = forest;
    InternalIndexPkm = 0;
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
#pragma warning disable IDE0052 // Remove unread private members
  private int InternalSpecies;
  private int InternalMove;
  private int InternalGender;
  private int InternalForm;
  private int InternalAnimation;
#pragma warning restore IDE0052 // Remove unread private members

  public int Species {
    get => BitConverter.ToInt32(Data, GetPkmoffset()) & 0x7FF;
    set => InternalSpecies = value;
  }
  public int Move {
    get => (BitConverter.ToInt32(Data, GetPkmoffset()) & 0x1FF800) >> 11;
    set => InternalMove = value;
  }
  public int Gender {
    get => (BitConverter.ToInt32(Data, GetPkmoffset()) & 0x600000) >> 21;
    set => InternalGender = value;
  }
  public int Form {
    get => (BitConverter.ToInt32(Data, GetPkmoffset()) & 0xF800000) >> 23;
    set => InternalForm = value;
  }
  public int Animation {
    get => (int)((BitConverter.ToInt32(Data, GetPkmoffset()) & 0xF0000000) >> 28);
    set => InternalAnimation = value;
  }

  //Just return if there's a valid pkm in current slot
  public bool IsPkmEmpty() => Species == 0;

  public uint GetPkm() { //Relies on current InternalIndexPkm
    return BitConverter.ToUInt32(Data, GetPkmoffset());
  }

  //Build a u32 pkm for entralink forest
  public static uint CreatePkm(int sp, int mv, int gdr, int frm, int anim) {
    return unchecked((uint)((sp & 0x7FF) | ((mv & 0x3FF) << 11) | ((gdr & 0x3) << 21) | ((frm & 0x1F) << 23) | ((anim & 0xF) << 28)));
  }

  //Sets pkm data to current slot
  public void EditPkm(uint pkm) {
    Array.Copy(BitConverter.GetBytes(pkm), 0, Data, GetPkmoffset(), 4);
  }

  //Sets pkm data to first available slot, if there's one
  public void AddPkm(uint pkm) {
    int tmp_slot = InternalIndexPkm;
    bool found_empty = false;
    //Find first available slot
    if (InternalArea > 0 && InternalArea < 4) { //Area 9 ony holds 10 pokes
      for (InternalIndexPkm = 0; InternalIndexPkm < 10; InternalIndexPkm++) {
        if (IsPkmEmpty()) {
          found_empty = true;
          break;
        }
      }
    } else {
      for (InternalIndexPkm = 0; InternalIndexPkm < 20; InternalIndexPkm++) {
        if (IsPkmEmpty()) {
          found_empty = true;
          break;
        }
      }
    }

    if (found_empty)
      Array.Copy(BitConverter.GetBytes(pkm), 0, Data, GetPkmoffset(), 4);
    else
      MessageBox.Show("There are no free slots in this InternalArea.");

    InternalIndexPkm = tmp_slot;
  }

  //deletes current slot
  //todo: mve all slots up
  public void DeletePkm() {
    int tmp_slot = InternalIndexPkm;

    //Delete selected pkm
    uint delete = 0;
    Array.Copy(BitConverter.GetBytes(delete), 0, Data, GetPkmoffset(), 4);

    //Move all pkm up 1 slot
    int i;
    uint temp_pkm;
    if (InternalArea > 0 && InternalArea < 4) { //Area 9 ony holds 10 pokes
      if (InternalIndexPkm != 9) { //If user didn't delete last slot
        for (i = InternalIndexPkm; i < 9; i++) {
          //Get next pkm
          InternalIndexPkm++;
          temp_pkm = BitConverter.ToUInt32(Data, GetPkmoffset());
          //Set to previous slot
          InternalIndexPkm--;
          EditPkm(temp_pkm);
          //Return index to next slot
          InternalIndexPkm++;
        }
        //Now empty last slot
        temp_pkm = 0;
        EditPkm(temp_pkm);
      }
    } else {
      if (InternalIndexPkm != 19) { //If user didn't delete last slot
        for (i = InternalIndexPkm; i < 19; i++) {
          //Get next pkm
          InternalIndexPkm++;
          temp_pkm = BitConverter.ToUInt32(Data, GetPkmoffset());
          //Set to previous slot
          InternalIndexPkm--;
          EditPkm(temp_pkm);
          //Return index to next slot
          InternalIndexPkm++;
        }
        //Now empty last slot
        temp_pkm = 0;
        EditPkm(temp_pkm);
      }
    }

    InternalIndexPkm = tmp_slot;
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
