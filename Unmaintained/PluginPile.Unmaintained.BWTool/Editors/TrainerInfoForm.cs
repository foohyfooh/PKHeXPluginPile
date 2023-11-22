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

    load_data();
  }

  void load_data() {
    name.Text = trainer.name;
    if (SAV is SAV5B2W2) {
      rival_name.Text = rival.name;
    }

    tid.Value = trainer.TID;
    sid.Value = trainer.SID;

    money.Value = badge.money;


    if (trainer.gender == 0) {
      tnr_class.Items.Clear();
      tnr_class.Items.AddRange(new object[] {
        "Youngster",
        "Ace trainer",
        "PKMN Ranger",
        "PKMN Breeder",
        "Scientist",
        "Hiker",
        "Roughneck",
        "Preschooler"});
      tnr_class.SelectedIndex = trainer.trainer_class;
    } else {
      tnr_class.Items.Clear();
      tnr_class.Items.AddRange(new object[] {
        "Lass",
        "Ace trainer",
        "PKMN Ranger",
        "PKMN Breeder",
        "Scientist",
        "Parasol Lady",
        "Nurse",
        "Preschooler"});
      tnr_class.SelectedIndex = trainer.trainer_class - 8;
    }
    gender.SelectedIndex = trainer.gender;

    hours.Value = trainer.hours;
    minutes.Value = trainer.minutes;
    seconds.Value = trainer.seconds;

    bp.Value = battle.BP;

    tnr_nature.SelectedIndex = card.nature;

    badge1.Checked = badge.badge1;
    badge2.Checked = badge.badge2;
    badge3.Checked = badge.badge3;
    badge4.Checked = badge.badge4;
    badge5.Checked = badge.badge5;
    badge6.Checked = badge.badge6;
    badge7.Checked = badge.badge7;
    badge8.Checked = badge.badge8;

    badge1_date.Value = card.get_badge_date(0);
    badge2_date.Value = card.get_badge_date(1);
    badge3_date.Value = card.get_badge_date(2);
    badge4_date.Value = card.get_badge_date(3);
    badge5_date.Value = card.get_badge_date(4);
    badge6_date.Value = card.get_badge_date(5);
    badge7_date.Value = card.get_badge_date(6);
    badge8_date.Value = card.get_badge_date(7);
  }

  void set_data() {
    trainer.name = name.Text;

    if (SAV is SAV5B2W2) {
      rival.name = rival_name.Text;
    }

    trainer.TID = (ushort)tid.Value;
    trainer.SID = (ushort)sid.Value;

    badge.money = (uint)money.Value;

    trainer.gender = (byte)gender.SelectedIndex;

    if (gender.SelectedIndex == 1)
      trainer.trainer_class = (byte)(tnr_class.SelectedIndex + 8);
    else
      trainer.trainer_class = (byte)(tnr_class.SelectedIndex);

    trainer.hours = (ushort)hours.Value;
    trainer.minutes = (byte)minutes.Value;
    trainer.seconds = (byte)seconds.Value;

    battle.BP = (ushort)bp.Value;

    card.nature = (byte)tnr_nature.SelectedIndex;

    badge.badge1 = badge1.Checked;
    badge.badge2 = badge2.Checked;
    badge.badge3 = badge3.Checked;
    badge.badge4 = badge4.Checked;
    badge.badge5 = badge5.Checked;
    badge.badge6 = badge6.Checked;
    badge.badge7 = badge7.Checked;
    badge.badge8 = badge8.Checked;

    card.set_badge_date(badge1_date.Value, 0);
    card.set_badge_date(badge2_date.Value, 1);
    card.set_badge_date(badge3_date.Value, 2);
    card.set_badge_date(badge4_date.Value, 3);
    card.set_badge_date(badge5_date.Value, 4);
    card.set_badge_date(badge6_date.Value, 5);
    card.set_badge_date(badge7_date.Value, 6);
    card.set_badge_date(badge8_date.Value, 7);
  }
  void Exit_butClick(object sender, EventArgs e) {
    this.Close();
  }
  void Saveexit_butClick(object sender, EventArgs e) {
    set_data();

    SAV.SetBlock(trainer.Data, Constants.TrainerData);
    if (SAV is SAV5B2W2) {
      SAV.SetBlock(rival.Data, Constants.B2W2.Rival);
    }
    SAV.SetBlock(badge.Data, Constants.Badges);
    SAV.SetBlock(battle.Data, SAV is SAV5BW ? Constants.BW.Battle : Constants.B2W2.Battle);
    SAV.SetBlock(card.Data, Constants.TrainerCard);
    this.Close();
  }

  public class TrainerData {
    public byte[] Data;
    public TrainerData(byte[] data) {
      Data = data;
    }

    public byte[] getData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void setData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    //Helper functions from pkhex
    internal static string TrimFromFFFF(string input) {
      int index = input.IndexOf((char)0xFFFF);
      return index < 0 ? input : input.Substring(0, index);
    }

    public string name {
      get {
        return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x04, 0xE))
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
        Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x04);
      }
    }

    public ushort TID {
      get => BitConverter.ToUInt16(getData(0x14, 2), 0);
      set => setData(BitConverter.GetBytes(value), 0x14);
    }

    public ushort SID {
      get => BitConverter.ToUInt16(getData(0x16, 2), 0);
      set => setData(BitConverter.GetBytes(value), 0x16);
    }

    public ushort hours {
      get => BitConverter.ToUInt16(getData(0x24, 2), 0);
      set => setData(BitConverter.GetBytes(value), 0x24);
  }
    public byte minutes {
      get => Data[0x26];
      set => Data[0x26] = value;
    }
    public byte seconds {
      get => Data[0x27];
      set => Data[0x27] = value;
    }

    public int gender {
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

    public byte trainer_class {
      get => Data[0x20];
      set => Data[0x20] = value;
    }
  }

  public class RIVAL {
    public byte[] Data;
    public RIVAL(byte[] data) {
      Data = data;
    }

    public byte[] getData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void setData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    //Helper functions from pkhex
    internal static string TrimFromFFFF(string input) {
      int index = input.IndexOf((char)0xFFFF);
      return index < 0 ? input : input.Substring(0, index);
    }

    public string name {
      get {
        return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0xA4, 0xE))
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
        Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0xA4);
      }
    }
  }

  public class Badges {
    public readonly byte[] Data;
    public Badges(byte[] data) {
      Data = data;
    }

    public byte[] getData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void setData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public uint money {
      get {
        return BitConverter.ToUInt32(getData(0, 4), 0);
      }
      set {
        setData(BitConverter.GetBytes(value), 0);
      }
    }

    public bool badge1 {
      get => (Data[0x4] & 0x1) != 0;
      set {
        if (value)
          Data[0x4] |= 0x1;
        else
          Data[0x4] &= unchecked((byte)(~0x1));
      }
    }
    public bool badge2 {
      get => (Data[0x4] & 0x2) != 0;
      set {
        if (value == true)
          Data[0x4] |= (byte)(0x2);
        else
          Data[0x4] &= unchecked((byte)(~0x2));
      }
    }
    public bool badge3 {
      get => (Data[0x4] & 0x4) != 0;
      set {
        if (value == true)
          Data[0x4] |= (byte)(0x4);
        else
          Data[0x4] &= unchecked((byte)(~0x4));
      }
    }
    public bool badge4 {
      get => (Data[0x4] & 0x8) != 0;
      set {
        if (value == true)
          Data[0x4] |= (byte)(0x8);
        else
          Data[0x4] &= unchecked((byte)(~0x8));
      }
    }
    public bool badge5 {
      get => (Data[0x4] & 0x10) != 0;
      set {
        if (value)
          Data[0x4] |= 0x10;
        else
          Data[0x4] &= unchecked((byte)(~0x10));
      }
    }
    public bool badge6 {
      get => (Data[0x4] & 0x20) != 0;
      set {
        if (value)
          Data[0x4] |= 0x20;
        else
          Data[0x4] &= unchecked((byte)(~0x20));
      }
    }
    public bool badge7 {
      get => (Data[0x4] & 0x40) != 0;
      set {
        if (value)
          Data[0x4] |= 0x40;
        else
          Data[0x4] &= unchecked((byte)(~0x40));
      }
    }
    public bool badge8 {
      get => (Data[0x4] & 0x80) != 0;
      set {
        if (value)
          Data[0x4] |= 0x80;
        else
          Data[0x4] &= unchecked((byte)(~0x80));
      }
    }
  }
  public class Battle {
    public byte[] Data;
    public Battle(byte[] data) {
      Data = data;
    }

    public byte[] getData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void setData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public ushort BP {
      get => BitConverter.ToUInt16(getData(0, 2), 0);
      set => setData(BitConverter.GetBytes(value), 0);
    }
  }
  public class TrainerCard {
    public readonly byte[] Data;
    public TrainerCard(byte[] data) {
      Data = data;
    }

    public byte[] getData(int Offset, int Length) {
      return Data.Skip(Offset).Take(Length).ToArray();
    }

    public void setData(byte[] input, int Offset) {
      input.CopyTo(Data, Offset);
    }

    public byte nature {
      get => Data[0x600];
      set => Data[0x600] = value;
    }

    public DateTime get_badge_date(int index) {
      if (Data[0x604 + (4 * index)] != 0 && Data[0x605 + (4 * index)] != 0 && Data[0x606 + (4 * index)] != 0)
        return new DateTime(2000 + Data[0x604 + (4 * index)], Data[0x605 + (4 * index)], Data[0x606 + (4 * index)]);
      else
        return new DateTime(2000, 1, 1);
    }

    public void set_badge_date(DateTime date, int index) {
      Data[0x604 + (4 * index)] = (byte)(date.Year - 2000);
      Data[0x605 + (4 * index)] = (byte)date.Month;
      Data[0x606 + (4 * index)] = (byte)date.Day;
    }

    public void del_badge(int index) {
      Data[0x604 + (4 * index)] = 0;
      Data[0x605 + (4 * index)] = 0;
      Data[0x606 + (4 * index)] = 0;
    }
  }
}
