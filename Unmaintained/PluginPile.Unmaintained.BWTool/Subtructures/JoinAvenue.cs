using System.Text;

namespace PluginPile.Unmaintained.BWTool;
public class JoinAvenue {

  public readonly byte[] Data;
  public readonly JoinAvenueOccupant[] visitor = new JoinAvenueOccupant[8];
  public readonly JoinAvenueOccupant[] shop = new JoinAvenueOccupant[8];
  public readonly JoinAnvenueNPC[] npc = new JoinAnvenueNPC[12];
  public readonly JoinAvenueHelper[] helper = new JoinAvenueHelper[4];

  public JoinAvenue(byte[] data) {
    Data = data;
    load_people();
  }

  public byte[] getData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }

  public void setData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }

  //Visitors
  private const int VISITOR_SIZE = 0xC4;
  private const int VISITOR_OFFSET = 0x08;
  private const int VISITOR_TOTAL = 8 - 1;

  public JoinAvenueOccupant get_visitor(int index) {
    if (index > VISITOR_TOTAL) index = VISITOR_TOTAL;
    return new JoinAvenueOccupant(getData(VISITOR_OFFSET + (VISITOR_SIZE * index), VISITOR_SIZE));
  }

  public void set_visitor(JoinAvenueOccupant visitant, int index) {
    if (index > VISITOR_TOTAL) index = VISITOR_TOTAL;
    setData(visitant.Data, VISITOR_OFFSET + (VISITOR_SIZE * index));
  }

  //NPC Fans
  private const int NPC_SIZE = 0x60;
  private const int NPC_OFFSET = 0x62C;
  private const int NPC_TOTAL = 12 - 1;
  public JoinAnvenueNPC get_npc(int index) {
    if (index > NPC_TOTAL) index = NPC_TOTAL;
    return new JoinAnvenueNPC(getData(NPC_OFFSET + (NPC_SIZE * index), NPC_SIZE));
  }
  public void set_npc(JoinAnvenueNPC npc, int index) {
    if (index > NPC_TOTAL) index = NPC_TOTAL;
    setData(npc.Data, NPC_OFFSET + (NPC_SIZE * index));
  }

  //Occupants
  int OCCUPANT_SIZE = 0xC4;
  int OCCUPANT_OFFSET = 0xAAC;
  int OCCUPANT_TOTAL = 8 - 1;

  public JoinAvenueOccupant get_occupant(int index) {
    if (index > OCCUPANT_TOTAL) index = OCCUPANT_TOTAL;
    return new JoinAvenueOccupant(getData(OCCUPANT_OFFSET + (OCCUPANT_SIZE * index), OCCUPANT_SIZE));
  }
  public void set_occupant(JoinAvenueOccupant occupant, int index) {
    if (index > OCCUPANT_TOTAL) index = OCCUPANT_TOTAL;
    setData(occupant.Data, OCCUPANT_OFFSET + (OCCUPANT_SIZE * index));
  }

  //Helpers
  private int HELPER_SIZE = 0x58;
  private int HELPER_OFFSET = 0x10CC;
  private int HELPER_TOTAL = 4 - 1;

  public JoinAvenueHelper get_helper(int index) {
    if (index > HELPER_TOTAL) index = HELPER_TOTAL;
    return new JoinAvenueHelper(getData(HELPER_OFFSET + (HELPER_SIZE * index), HELPER_SIZE));
  }

  public void set_helper(JoinAvenueHelper helper, int index) {
    if (index > HELPER_TOTAL) index = HELPER_TOTAL;
    setData(helper.Data, HELPER_OFFSET + (HELPER_SIZE * index));
  }

  public void load_people() {
    for (int i = 0; i < 8; i++) {
      visitor[i] = get_visitor(i);
      shop[i] = get_occupant(i);
    }
    for (int i = 0; i < 12; i++) {
      npc[i] = get_npc(i);
    }
    for (int i = 0; i < 4; i++) {
      helper[i] = get_helper(i);
    }
  }

  public void set_people() {
    for (int i = 0; i < 8; i++) {
      set_visitor(visitor[i], i);
      set_occupant(shop[i], i);
    }
    for (int i = 0; i < 12; i++) {
      set_npc(npc[i], i);
    }
    for (int i = 0; i < 4; i++) {
      set_helper(helper[i], i);
    }
  }

  public ushort rank {
    get { return BitConverter.ToUInt16(getData(0x13CC, 2), 0); }
    set { setData(BitConverter.GetBytes(value), 0x13CC); }
  }

  //00 Orange 01 Purple 02 Blue 03 Green
  public int color {
    get { return BitConverter.ToUInt16(getData(0x13CE, 2), 0); }
    set { setData(BitConverter.GetBytes((ushort)value), 0x13CE); }
  }

  //Helper functions from pkhex
  internal static string TrimFromFFFF(string input) {
    int index = input.IndexOf((char)0xFFFF);
    return index < 0 ? input : input.Substring(0, index);
  }

  public string fav_phrase {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x12AC, 0x10))
          .Replace("\uE08F", "\u2640") // nidoran
          .Replace("\uE08E", "\u2642") // nidoran
          .Replace("\u2019", "\u0027"); // farfetch'd
    }
    set {
      if (value.Length > 0x10 / 2)
        value = value.Substring(0, 0x10 / 2); // Hard cap
      string TempNick = value // Replace Special Characters and add Terminator
          .Replace("\u2640", "\uE08F") // nidoran
          .Replace("\u2642", "\uE08E") // nidoran
          .Replace("\u0027", "\u2019") // farfetch'd
          .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x12AC);
    }
  }

  public string imp_phrase {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x12BC, 0x10))
          .Replace("\uE08F", "\u2640") // nidoran
          .Replace("\uE08E", "\u2642") // nidoran
          .Replace("\u2019", "\u0027"); // farfetch'd
    }
    set {
      if (value.Length > 0x10 / 2)
        value = value.Substring(0, 0x10 / 2); // Hard cap
      string TempNick = value // Replace Special Characters and add Terminator
          .Replace("\u2640", "\uE08F") // nidoran
          .Replace("\u2642", "\uE08E") // nidoran
          .Replace("\u0027", "\u2019") // farfetch'd
          .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x12BC);
    }
  }

  public string name {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x12F4, 0x1A))
          .Replace("\uE08F", "\u2640") // nidoran
          .Replace("\uE08E", "\u2642") // nidoran
          .Replace("\u2019", "\u0027"); // farfetch'd
    }
    set {
      if (value.Length > 0x1A / 2)
        value = value.Substring(0, 0x1A / 2); // Hard cap
      string TempNick = value // Replace Special Characters and add Terminator
          .Replace("\u2640", "\uE08F") // nidoran
          .Replace("\u2642", "\uE08E") // nidoran
          .Replace("\u0027", "\u2019") // farfetch'd
          .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x12F4);
    }
  }

  public string title {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x131E, 0x10))
          .Replace("\uE08F", "\u2640") // nidoran
          .Replace("\uE08E", "\u2642") // nidoran
          .Replace("\u2019", "\u0027"); // farfetch'd
    }
    set {
      if (value.Length > 0x10 / 2)
        value = value.Substring(0, 0x10 / 2); // Hard cap
      string TempNick = value // Replace Special Characters and add Terminator
          .Replace("\u2640", "\uE08F") // nidoran
          .Replace("\u2642", "\uE08E") // nidoran
          .Replace("\u0027", "\u2019") // farfetch'd
          .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x131E);
    }
  }

  /*TO DO:
  START OFFSET: 23C00

  0x24E8C-0x24E9B - Player Trivia (set by avenue NPCs, see next post)
  0x24E9C-0x24EA7 - Player Activities (recent happenings to player ^)
  0x24EA8-0x24EAB - 00000000 (nothing, unused)
  0x24EAC - Your Favorite Phrase (0x10)
  0x24EBC - Your Impressed Phrase (0x10)
  0x24EF4 - Join Avenue's Name (11 characters + terminator, 0x18)
  0x24F1E - Your Title (0x10)
  */
}

public class JoinAnvenueNPC {
  public readonly byte[] Data;
  public JoinAnvenueNPC(byte[] data) {
    Data = data;
  }

  public byte[] getData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }

  public void setData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }

  public string name {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0);
    }
  }

  public int gender {
    get {
      if (Data[0x22] == 0x10)
        return 1;
      else
        return 0;
    }
    set {
      if (value == 1)
        Data[0x22] = 0x10;
      else
        Data[0x22] = 0;
    }
  }

  public string text1 {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x2C, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x2C);
    }
  }

  public string text2 {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x3C, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x3C);
    }
  }

  public bool spoken {
    get {
      if (Data[0x4F] == 1)
        return true;
      else
        return false;
    }
    set {
      if (value == true)
        Data[0x4F] = 1;
      else
        Data[0x4F] = 0;
    }
  }

  //Helper functions from pkhex
  internal static string TrimFromFFFF(string input) {
    int index = input.IndexOf((char)0xFFFF);
    return index < 0 ? input : input.Substring(0, index);
  }
}

public class JoinAvenueHelper {
  public readonly byte[] Data;
  public JoinAvenueHelper(byte[] data) {
    Data = data;
  }

  public byte[] getData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }

  public void setData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }

  public string name {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0);
    }
  }

  public string text0 {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x10, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x10);
    }
  }

  public string text1 {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x34, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x34);
    }
  }

  public string text2 {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x44, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x44);
    }
  }

  public int sprite {
    get {
      return Data[0x2A];
    }
    set {
      Data[0x2A] = (value > 0xFF ? (byte)0xFF : (byte)value);
    }
  }

  public int country {
    get {
      return Data[0xE];
    }
    set {
      Data[0xE] = (value > 0xFF ? (byte)0xFF : (byte)value);
    }
  }

  public int subregion {
    get {
      return Data[0xF];
    }
    set {
      Data[0xF] = (value > 0xFF ? (byte)0xFF : (byte)value);
    }
  }

  public DateTime met {
    get {
      if (Data[0x30] != 0 && Data[0x31] != 0 && Data[0x32] != 0)
        return new DateTime(2000 + Data[0x30], Data[0x31], Data[0x32]);
      else
        return new DateTime(2000, 1, 1);
    }
    set {
      Data[0x30] = (byte)(value.Year - 2000);
      Data[0x31] = (byte)value.Month;
      Data[0x32] = (byte)value.Day;
    }
  }

  //Helper functions from pkhex
  internal static string TrimFromFFFF(string input) {
    int index = input.IndexOf((char)0xFFFF);
    return index < 0 ? input : input.Substring(0, index);
  }
}
public class JoinAvenueOccupant {
  public byte[] Data;
  public JoinAvenueOccupant(byte[]? data = null) {
    Data = data ?? new byte[0xC4];
  }
  public byte[] getData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }
  public void setData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }

  public string name {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0);
    }
  }
  public int country {
    get {
      return Data[0xE];
    }
    set {
      Data[0xE] = (value > 0xFF ? (byte)0xFF : (byte)value);
    }
  }
  public int subregion {
    get {
      return Data[0xF];
    }
    set {
      Data[0xF] = (value > 0xFF ? (byte)0xFF : (byte)value);
    }
  }
  public string shout {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x10, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x10);
    }
  }
  public int gender {
    get {
      if (Data[0x22] == 0x10)
        return 1;
      else
        return 0;
    }
    set {
      if (value == 1)
        Data[0x22] = 0x10;
      else
        Data[0x22] = 0;
    }
  }

  public int sprite {
    get {
      return Data[0x2A];
    }
    set {
      Data[0x2A] = (value > 0xFF ? (byte)0xFF : (byte)value);
    }
  }

  public int recruitlvl {
    get {
      return Data[0x2C];
    }
    set {
      Data[0x2C] = (value > 0xFF ? (byte)0xFF : (byte)value);
    }
  }

  public string greeting {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x80, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x80);
    }
  }
  public string farewell {
    get {
      return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x90, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x90);
    }
  }
  public bool isplayer {
    get {
      if (Data[0xA0] == 1)
        return true;
      else
        return false;
    }
    set {
      if (value == true)
        Data[0xA0] = (byte)1;
      else
        Data[0xA0] = (byte)0;
    }
  }
  public DateTime met {
    get {
      if (Data[0xA3] != 0 && Data[0xA4] != 0 && Data[0xA5] != 0)
        return new DateTime(2000 + Data[0xA3], Data[0xA4], Data[0xA5]);
      else
        return new DateTime(2000, 1, 1);
    }
    set {
      Data[0xA3] = (byte)(value.Year - 2000);
      Data[0xA4] = (byte)value.Month;
      Data[0xA5] = (byte)value.Day;
    }
  }

  public int av_occupant_rank //Rank of player's own avenue, visitors use it. Disabled since not used in gui
  {
    get {
      return Data[0xAB];
    }
    set {
      Data[0xAB] = (value > 0xFF ? (byte)0xFF : (byte)value);
    }
  }

  public int shop_rank {
    get {
      return Data[0xAD];
    }
    set {
      Data[0xAD] = (value > 10 ? (byte)10 : (byte)value);
    }
  }

  public int shop_exp {
    get {
      return BitConverter.ToUInt16(getData(0xAD, 2), 0);
    }
    set {
      ushort exp;
      if (value > 0xFFFF)
        exp = 0xFFFF;
      else
        exp = (ushort)value;
      setData(BitConverter.GetBytes(exp), 0xAD);
    }
  }

  public bool inventory {
    get {
      if (Data[0xB0] == 1)
        return true;
      else
        return false;
    }
    set {
      if (value == true)
        Data[0xB0] = (byte)1;
      else
        Data[0xB0] = (byte)0;
    }
  }

  //Note: 0xB4 = FF when there's no shop

  public ushort ShopBytes() {
    return BitConverter.ToUInt16(getData(0xB4, 2), 0);
  }

  public void set_ShopBytes() {
    ushort bytes = (ushort)(1 + Shop_version * 0x50 + Shop_type * 0xA + Shop_level);
    setData(BitConverter.GetBytes(bytes), 0xB4);
  }

  private int Shop_version;
  public int shop_version //0 black, 1 white, 2 black2, 3 white3
  {
    get {
      return ShopBytes() / 0x50;
    }
    set {
      if (value > 3) {
        Shop_version = 3;
      } else {
        Shop_version = value;
      }
    }
  }

  private int Shop_level;
  public int shop_level { // 0-9 (1-10)
    get {
      if (ShopBytes() % 0x50 == 0) //Last shop, level 10, remainder of negative number not correctly behaving...
        return 9;
      else
        return (((ShopBytes() % 0x50) - 1) % 0xA);
    }
    set {
      if (value > 0x9)
        Shop_level = 0x9;
      else
        Shop_level = value;
    }
  }

  private int Shop_type;
  public int shop_type { // 0=raffle, 1=salon, 2 = market, 3=florist, 4 = dojo, 5=nurse, 6=antique, 7=cafe
    get {
      if (shop_level == 9) { //Level 10 gives problems... just consider it a level 9 shop for type return
                             //MessageBox.Show((ShopBytes() % 0x50).ToString() + "  -"+((ShopBytes() % 0x50)/0xA).ToString());
        return (((ShopBytes() - 1) % 0x50) / 0xA);
      } else {
        return ((ShopBytes() % 0x50) / 0xA);
      }
      //
      // return ((ShopBytes() % 0x50) / 0xA);
    }
    set {
      if (value > 0x7)
        Shop_type = 0x7;
      else
        Shop_type = value;
    }
  }

  //Helper functions from pkhex
  internal static string TrimFromFFFF(string input) {
    int index = input.IndexOf((char)0xFFFF);
    return index < 0 ? input : input.Substring(0, index);
  }
}
