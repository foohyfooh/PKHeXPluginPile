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
    LoadPeople();
  }

  public byte[] GetData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }

  public void SetData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }

  //Visitors
  private const int VISITOR_SIZE = 0xC4;
  private const int VISITOR_OFFSET = 0x08;
  private const int VISITOR_TOTAL = 8 - 1;

  public JoinAvenueOccupant GetVisitor(int index) {
    if (index > VISITOR_TOTAL) index = VISITOR_TOTAL;
    return new JoinAvenueOccupant(GetData(VISITOR_OFFSET + (VISITOR_SIZE * index), VISITOR_SIZE));
  }

  public void SetVisitor(JoinAvenueOccupant visitant, int index) {
    if (index > VISITOR_TOTAL) index = VISITOR_TOTAL;
    SetData(visitant.Data, VISITOR_OFFSET + (VISITOR_SIZE * index));
  }

  //NPC Fans
  private const int NPC_SIZE = 0x60;
  private const int NPC_OFFSET = 0x62C;
  private const int NPC_TOTAL = 12 - 1;
  public JoinAnvenueNPC GetNPC(int index) {
    if (index > NPC_TOTAL) index = NPC_TOTAL;
    return new JoinAnvenueNPC(GetData(NPC_OFFSET + (NPC_SIZE * index), NPC_SIZE));
  }
  public void SetNpc(JoinAnvenueNPC npc, int index) {
    if (index > NPC_TOTAL) index = NPC_TOTAL;
    SetData(npc.Data, NPC_OFFSET + (NPC_SIZE * index));
  }

  //Occupants
  private readonly int OCCUPANT_SIZE = 0xC4;
  private readonly int OCCUPANT_OFFSET = 0xAAC;
  private readonly int OCCUPANT_TOTAL = 8 - 1;

  public JoinAvenueOccupant GetOccupant(int index) {
    if (index > OCCUPANT_TOTAL) index = OCCUPANT_TOTAL;
    return new JoinAvenueOccupant(GetData(OCCUPANT_OFFSET + (OCCUPANT_SIZE * index), OCCUPANT_SIZE));
  }
  public void SetOccupant(JoinAvenueOccupant occupant, int index) {
    if (index > OCCUPANT_TOTAL) index = OCCUPANT_TOTAL;
    SetData(occupant.Data, OCCUPANT_OFFSET + (OCCUPANT_SIZE * index));
  }

  //Helpers
  private readonly int HELPER_SIZE = 0x58;
  private readonly int HELPER_OFFSET = 0x10CC;
  private readonly int HELPER_TOTAL = 4 - 1;

  public JoinAvenueHelper GetHelper(int index) {
    if (index > HELPER_TOTAL) index = HELPER_TOTAL;
    return new JoinAvenueHelper(GetData(HELPER_OFFSET + (HELPER_SIZE * index), HELPER_SIZE));
  }

  public void SetHelper(JoinAvenueHelper helper, int index) {
    if (index > HELPER_TOTAL) index = HELPER_TOTAL;
    SetData(helper.Data, HELPER_OFFSET + (HELPER_SIZE * index));
  }

  public void LoadPeople() {
    for (int i = 0; i < 8; i++) {
      visitor[i] = GetVisitor(i);
      shop[i] = GetOccupant(i);
    }
    for (int i = 0; i < 12; i++) {
      npc[i] = GetNPC(i);
    }
    for (int i = 0; i < 4; i++) {
      helper[i] = GetHelper(i);
    }
  }

  public void SetPeople() {
    for (int i = 0; i < 8; i++) {
      SetVisitor(visitor[i], i);
      SetOccupant(shop[i], i);
    }
    for (int i = 0; i < 12; i++) {
      SetNpc(npc[i], i);
    }
    for (int i = 0; i < 4; i++) {
      SetHelper(helper[i], i);
    }
  }

  public ushort Rank {
    get { return BitConverter.ToUInt16(GetData(0x13CC, 2), 0); }
    set { SetData(BitConverter.GetBytes(value), 0x13CC); }
  }

  //00 Orange 01 Purple 02 Blue 03 Green
  public int Color {
    get { return BitConverter.ToUInt16(GetData(0x13CE, 2), 0); }
    set { SetData(BitConverter.GetBytes((ushort)value), 0x13CE); }
  }

  

  public string FavPhrase {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x12AC, 0x10))
          .Replace("\uE08F", "\u2640") // nidoran
          .Replace("\uE08E", "\u2642") // nidoran
          .Replace("\u2019", "\u0027"); // farfetch'd
    }
    set {
      if (value.Length > 0x10 / 2)
        value = value[..(0x10 / 2)]; // Hard cap
      string TempNick = value // Replace Special Characters and add Terminator
          .Replace("\u2640", "\uE08F") // nidoran
          .Replace("\u2642", "\uE08E") // nidoran
          .Replace("\u0027", "\u2019") // farfetch'd
          .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x12AC);
    }
  }

  public string ImpPhrase {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x12BC, 0x10))
          .Replace("\uE08F", "\u2640") // nidoran
          .Replace("\uE08E", "\u2642") // nidoran
          .Replace("\u2019", "\u0027"); // farfetch'd
    }
    set {
      if (value.Length > 0x10 / 2)
        value = value[..(0x10 / 2)]; // Hard cap
      string TempNick = value // Replace Special Characters and add Terminator
          .Replace("\u2640", "\uE08F") // nidoran
          .Replace("\u2642", "\uE08E") // nidoran
          .Replace("\u0027", "\u2019") // farfetch'd
          .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x12BC);
    }
  }

  public string Name {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x12F4, 0x1A))
          .Replace("\uE08F", "\u2640") // nidoran
          .Replace("\uE08E", "\u2642") // nidoran
          .Replace("\u2019", "\u0027"); // farfetch'd
    }
    set {
      if (value.Length > 0x1A / 2)
        value = value[..(0x1A / 2)]; // Hard cap
      string TempNick = value // Replace Special Characters and add Terminator
          .Replace("\u2640", "\uE08F") // nidoran
          .Replace("\u2642", "\uE08E") // nidoran
          .Replace("\u0027", "\u2019") // farfetch'd
          .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x12F4);
    }
  }

  public string Title {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x131E, 0x10))
          .Replace("\uE08F", "\u2640") // nidoran
          .Replace("\uE08E", "\u2642") // nidoran
          .Replace("\u2019", "\u0027"); // farfetch'd
    }
    set {
      if (value.Length > 0x10 / 2)
        value = value[..(0x10 / 2)]; // Hard cap
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

public class JoinAnvenueNPC(byte[] data) {
  public readonly byte[] Data = data;

  public byte[] GetData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }

  public void SetData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }

  public string Name {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0);
    }
  }

  public int Gender {
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

  public string Text1 {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x2C, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x2C);
    }
  }

  public string Text2 {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x3C, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x3C);
    }
  }

  public bool Spoken {
    get {
      if (Data[0x4F] == 1)
        return true;
      else
        return false;
    }
    set {
      if (value)
        Data[0x4F] = 1;
      else
        Data[0x4F] = 0;
    }
  }
}

public class JoinAvenueHelper(byte[] data) {
  public readonly byte[] Data = data;

  public byte[] GetData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }

  public void SetData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }

  public string Name {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0);
    }
  }

  public string Text0 {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x10, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x10);
    }
  }

  public string Text1 {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x34, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x34);
    }
  }

  public string Text2 {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x44, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x44);
    }
  }

  public int Sprite {
    get => Data[0x2A];
    set => Data[0x2A] = (value > 0xFF ? (byte)0xFF : (byte)value);
  }

  public int Country {
    get => Data[0xE];
    set => Data[0xE] = (value > 0xFF ? (byte)0xFF : (byte)value);
  }

  public int Subregion {
    get => Data[0xF];
    set => Data[0xF] = (value > 0xFF ? (byte)0xFF : (byte)value);
  }

  public DateTime Met {
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
}

public class JoinAvenueOccupant(byte[]? data = null) {
  public byte[] Data = data ?? new byte[0xC4];

  public byte[] GetData(int Offset, int Length) {
    return Data.Skip(Offset).Take(Length).ToArray();
  }
  public void SetData(byte[] input, int Offset) {
    input.CopyTo(Data, Offset);
  }

  public string Name {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0);
    }
  }

  public int Country {
    get => Data[0xE];
    set => Data[0xE] = (value > 0xFF ? (byte)0xFF : (byte)value);
  }

  public int Subregion {
    get => Data[0xF];
    set => Data[0xF] = (value > 0xFF ? (byte)0xFF : (byte)value);
  }

  public string Shout {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x10, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x10);
    }
  }
  public int Gender {
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

  public int Sprite {
    get => Data[0x2A];
    set => Data[0x2A] = (value > 0xFF ? (byte)0xFF : (byte)value);
  }

  public int RecruitLvl {
    get => Data[0x2C];
    set => Data[0x2C] = (value > 0xFF ? (byte)0xFF : (byte)value);
  }

  public string Greeting {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x80, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x80);
    }
  }
  public string Farewell {
    get {
      return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x90, 0xE))
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
      Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x90);
    }
  }
  public bool IsPlayer {
    get => Data[0xA0] == 1;
    set {
      if (value)
        Data[0xA0] = 1;
      else
        Data[0xA0] = 0;
    }
  }
  public DateTime Met {
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

  public int AVOccupantRank { //Rank of player's own avenue, visitors use it. Disabled since not used in gui
    get {
      return Data[0xAB];
    }
    set {
      Data[0xAB] = (value > 0xFF ? (byte)0xFF : (byte)value);
    }
  }

  public int ShopRank {
    get {
      return Data[0xAD];
    }
    set {
      Data[0xAD] = (value > 10 ? (byte)10 : (byte)value);
    }
  }

  public int ShopExp {
    get {
      return BitConverter.ToUInt16(GetData(0xAD, 2), 0);
    }
    set {
      ushort exp;
      if (value > 0xFFFF)
        exp = 0xFFFF;
      else
        exp = (ushort)value;
      SetData(BitConverter.GetBytes(exp), 0xAD);
    }
  }

  public bool Inventory {
    get {
      if (Data[0xB0] == 1)
        return true;
      else
        return false;
    }
    set {
      if (value)
        Data[0xB0] = 1;
      else
        Data[0xB0] = 0;
    }
  }

  //Note: 0xB4 = FF when there's no shop

  public ushort GetShopBytes() {
    return BitConverter.ToUInt16(GetData(0xB4, 2), 0);
  }

  public void SetShopBytes() {
    ushort bytes = (ushort)(1 + InternalShopVersion * 0x50 + InternalShopType * 0xA + InternalShopLevel);
    SetData(BitConverter.GetBytes(bytes), 0xB4);
  }

  private int InternalShopVersion;
  public int ShopVersion { //0 black, 1 white, 2 black2, 3 white2
    get {
      return GetShopBytes() / 0x50;
    }
    set {
      if (value > 3) {
        InternalShopVersion = 3;
      } else {
        InternalShopVersion = value;
      }
    }
  }

  private int InternalShopLevel;
  public int ShopLevel { // 0-9 (1-10)
    get {
      if (GetShopBytes() % 0x50 == 0) //Last shop, level 10, remainder of negative number not correctly behaving...
        return 9;
      else
        return (((GetShopBytes() % 0x50) - 1) % 0xA);
    }
    set {
      if (value > 0x9)
        InternalShopLevel = 0x9;
      else
        InternalShopLevel = value;
    }
  }

  private int InternalShopType;
  public int ShopType { // 0=raffle, 1=salon, 2 = market, 3=florist, 4 = dojo, 5=nurse, 6=antique, 7=cafe
    get {
      if (ShopLevel == 9) { //Level 10 gives problems... just consider it a level 9 shop for type return
        return (((GetShopBytes() - 1) % 0x50) / 0xA);
      } else {
        return ((GetShopBytes() % 0x50) / 0xA);
      }
    }
    set {
      if (value > 0x7)
        InternalShopType = 0x7;
      else
        InternalShopType = value;
    }
  }
}
