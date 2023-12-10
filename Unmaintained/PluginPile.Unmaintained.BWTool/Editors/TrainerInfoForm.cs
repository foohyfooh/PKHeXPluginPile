using PKHeX.Core;
using System.Text;

namespace PluginPile.Unmaintained.BWTool;

public partial class TrainerInfoForm : Form {

  private readonly SAV5 SAV;
  private readonly TrainerData trainer;
  private readonly RIVAL rival = null!;
  private readonly Badges badge;
  private readonly Battle battle;
  private readonly TrainerCard card;

  public TrainerInfoForm(SAV5 sav) {
    InitializeComponent();
    SAV = sav;
    money.Maximum = 9999999;
    bp.Maximum = 9999;

    if (SAV is SAV5BW) {
      battle = new Battle(SAV.GetBlock(Constants.BW.Battle));
      rival_name.Visible = false;
      rival_label.Visible = false;
    } else { //SAV is SAV5B2W2
      battle = new Battle(SAV.GetBlock(Constants.B2W2.Battle));
      rival = new RIVAL(SAV.GetBlock(Constants.B2W2.Rival));
    }

    //Common data
    trainer = new TrainerData(SAV.GetBlock(Constants.TrainerData));
    badge = new Badges(SAV.GetBlock(Constants.Badges));
    card = new TrainerCard(SAV.GetBlock(Constants.TrainerCard));

    LoadData();
  }

  void LoadData() {
    name.Text = trainer.Name;
    if (SAV is SAV5B2W2) {
      rival_name.Text = rival.Name;
    }

    tid.Value = trainer.TID;
    sid.Value = trainer.SID;

    money.Value = badge.Money;


    if (trainer.Gender == 0) {
      tnr_class.Items.Clear();
      tnr_class.Items.AddRange([
        "Youngster",
        "Ace trainer",
        "PKMN Ranger",
        "PKMN Breeder",
        "Scientist",
        "Hiker",
        "Roughneck",
        "Preschooler"]);
      tnr_class.SelectedIndex = trainer.TrainerClass;
    } else {
      tnr_class.Items.Clear();
      tnr_class.Items.AddRange([
        "Lass",
        "Ace trainer",
        "PKMN Ranger",
        "PKMN Breeder",
        "Scientist",
        "Parasol Lady",
        "Nurse",
        "Preschooler"]);
      tnr_class.SelectedIndex = trainer.TrainerClass - 8;
    }
    gender.SelectedIndex = trainer.Gender;

    hours.Value = trainer.Hours;
    minutes.Value = trainer.Minutes;
    seconds.Value = trainer.Seconds;

    bp.Value = battle.BP;

    tnr_nature.SelectedIndex = card.Nature;

    badge1.Checked = badge.Badge1;
    badge2.Checked = badge.Badge2;
    badge3.Checked = badge.Badge3;
    badge4.Checked = badge.Badge4;
    badge5.Checked = badge.Badge5;
    badge6.Checked = badge.Badge6;
    badge7.Checked = badge.Badge7;
    badge8.Checked = badge.Badge8;

    badge1_date.Value = card.GetBadgeDate(0);
    badge2_date.Value = card.GetBadgeDate(1);
    badge3_date.Value = card.GetBadgeDate(2);
    badge4_date.Value = card.GetBadgeDate(3);
    badge5_date.Value = card.GetBadgeDate(4);
    badge6_date.Value = card.GetBadgeDate(5);
    badge7_date.Value = card.GetBadgeDate(6);
    badge8_date.Value = card.GetBadgeDate(7);
  }

  void SetData() {
    trainer.Name = name.Text;

    if (SAV is SAV5B2W2) {
      rival.Name = rival_name.Text;
    }

    trainer.TID = (ushort)tid.Value;
    trainer.SID = (ushort)sid.Value;

    badge.Money = (uint)money.Value;

    trainer.Gender = (byte)gender.SelectedIndex;

    if (gender.SelectedIndex == 1)
      trainer.TrainerClass = (byte)(tnr_class.SelectedIndex + 8);
    else
      trainer.TrainerClass = (byte)(tnr_class.SelectedIndex);

    trainer.Hours = (ushort)hours.Value;
    trainer.Minutes = (byte)minutes.Value;
    trainer.Seconds = (byte)seconds.Value;

    battle.BP = (ushort)bp.Value;

    card.Nature = (byte)tnr_nature.SelectedIndex;

    badge.Badge1 = badge1.Checked;
    badge.Badge2 = badge2.Checked;
    badge.Badge3 = badge3.Checked;
    badge.Badge4 = badge4.Checked;
    badge.Badge5 = badge5.Checked;
    badge.Badge6 = badge6.Checked;
    badge.Badge7 = badge7.Checked;
    badge.Badge8 = badge8.Checked;

    card.SetBadgeDate(badge1_date.Value, 0);
    card.SetBadgeDate(badge2_date.Value, 1);
    card.SetBadgeDate(badge3_date.Value, 2);
    card.SetBadgeDate(badge4_date.Value, 3);
    card.SetBadgeDate(badge5_date.Value, 4);
    card.SetBadgeDate(badge6_date.Value, 5);
    card.SetBadgeDate(badge7_date.Value, 6);
    card.SetBadgeDate(badge8_date.Value, 7);
  }
  void Exit_butClick(object sender, EventArgs e) {
    this.Close();
  }
  void Saveexit_butClick(object sender, EventArgs e) {
    SetData();

    SAV.SetBlock(trainer.Data, Constants.TrainerData);
    if (SAV is SAV5B2W2) {
      SAV.SetBlock(rival.Data, Constants.B2W2.Rival);
    }
    SAV.SetBlock(badge.Data, Constants.Badges);
    SAV.SetBlock(battle.Data, SAV is SAV5BW ? Constants.BW.Battle : Constants.B2W2.Battle);
    SAV.SetBlock(card.Data, Constants.TrainerCard);
    this.Close();
  }

  public class TrainerData(byte[] data) {
    public byte[] Data = data;

    public byte[] GetData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void SetData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public string Name {
      get {
        return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x04, 0xE))
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
        Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x04);
      }
    }

    public ushort TID {
      get => BitConverter.ToUInt16(GetData(0x14, 2), 0);
      set => SetData(BitConverter.GetBytes(value), 0x14);
    }

    public ushort SID {
      get => BitConverter.ToUInt16(GetData(0x16, 2), 0);
      set => SetData(BitConverter.GetBytes(value), 0x16);
    }

    public ushort Hours {
      get => BitConverter.ToUInt16(GetData(0x24, 2), 0);
      set => SetData(BitConverter.GetBytes(value), 0x24);
  }
    public byte Minutes {
      get => Data[0x26];
      set => Data[0x26] = value;
    }
    public byte Seconds {
      get => Data[0x27];
      set => Data[0x27] = value;
    }

    public int Gender {
      get {
        if (Data[0x21] == 0x01)
          return 1;
        else
          return 0;
      }
      set {
        if (value == 1)
          Data[0x21] = 0x01;
        else
          Data[0x21] = 0;
      }
    }

    public byte TrainerClass {
      get => Data[0x20];
      set => Data[0x20] = value;
    }
  }

  public class RIVAL(byte[] data) {
    public byte[] Data = data;

    public byte[] GetData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void SetData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public string Name {
      get {
        return StringUtil.TrimFromFFFF(Encoding.Unicode.GetString(Data, 0xA4, 0xE))
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
        Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0xA4);
      }
    }
  }

  public class Badges(byte[] data) {
    public readonly byte[] Data = data;

    public byte[] GetData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void SetData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public uint Money {
      get => BitConverter.ToUInt32(GetData(0, 4), 0);
      set => SetData(BitConverter.GetBytes(value), 0);
    }

    public bool Badge1 {
      get => (Data[0x4] & 0x1) != 0;
      set {
        if (value)
          Data[0x4] |= 0x1;
        else
          Data[0x4] &= unchecked((byte)(~0x1));
      }
    }
    public bool Badge2 {
      get => (Data[0x4] & 0x2) != 0;
      set {
        if (value)
          Data[0x4] |= 0x2;
        else
          Data[0x4] &= unchecked((byte)(~0x2));
      }
    }
    public bool Badge3 {
      get => (Data[0x4] & 0x4) != 0;
      set {
        if (value)
          Data[0x4] |= 0x4;
        else
          Data[0x4] &= unchecked((byte)(~0x4));
      }
    }
    public bool Badge4 {
      get => (Data[0x4] & 0x8) != 0;
      set {
        if (value)
          Data[0x4] |= 0x8;
        else
          Data[0x4] &= unchecked((byte)(~0x8));
      }
    }
    public bool Badge5 {
      get => (Data[0x4] & 0x10) != 0;
      set {
        if (value)
          Data[0x4] |= 0x10;
        else
          Data[0x4] &= unchecked((byte)(~0x10));
      }
    }
    public bool Badge6 {
      get => (Data[0x4] & 0x20) != 0;
      set {
        if (value)
          Data[0x4] |= 0x20;
        else
          Data[0x4] &= unchecked((byte)(~0x20));
      }
    }
    public bool Badge7 {
      get => (Data[0x4] & 0x40) != 0;
      set {
        if (value)
          Data[0x4] |= 0x40;
        else
          Data[0x4] &= unchecked((byte)(~0x40));
      }
    }
    public bool Badge8 {
      get => (Data[0x4] & 0x80) != 0;
      set {
        if (value)
          Data[0x4] |= 0x80;
        else
          Data[0x4] &= unchecked((byte)(~0x80));
      }
    }
  }
  public class Battle(byte[] data) {
    public byte[] Data = data;

    public byte[] GetData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void SetData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public ushort BP {
      get => BitConverter.ToUInt16(GetData(0, 2), 0);
      set => SetData(BitConverter.GetBytes(value), 0);
    }
  }
  public class TrainerCard(byte[] data) {
    public readonly byte[] Data = data;

    public byte[] GetData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void SetData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public byte Nature {
      get => Data[0x600];
      set => Data[0x600] = value;
    }

    public DateTime GetBadgeDate(int index) {
      if (Data[0x604 + (4 * index)] != 0 && Data[0x605 + (4 * index)] != 0 && Data[0x606 + (4 * index)] != 0)
        return new DateTime(2000 + Data[0x604 + (4 * index)], Data[0x605 + (4 * index)], Data[0x606 + (4 * index)]);
      else
        return new DateTime(2000, 1, 1);
    }

    public void SetBadgeDate(DateTime date, int index) {
      Data[0x604 + (4 * index)] = (byte)(date.Year - 2000);
      Data[0x605 + (4 * index)] = (byte)date.Month;
      Data[0x606 + (4 * index)] = (byte)date.Day;
    }

    public void DelBadge(int index) {
      Data[0x604 + (4 * index)] = 0;
      Data[0x605 + (4 * index)] = 0;
      Data[0x606 + (4 * index)] = 0;
    }
  }
}
