using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool;

public partial class MedalsForm : Form {
  private readonly SAV5B2W2 SAV;
  private readonly Medals medals;

  public MedalsForm(SAV5B2W2 sav) {
    InitializeComponent();
    SAV = sav;
    red_panel.Visible = false;
    medals = new Medals(SAV.GetBlock(Constants.B2W2.Medals));
    indexbox.SelectedIndex = 0;

    update_date();
    update_medal_state();
    unreadFlag.Checked = medals.Flag4;
  }

  void indexbox_SelectedIndexChanged(object sender, EventArgs e) {
    if (indexbox.SelectedIndex == 0) {
      indexbox.SelectedIndex = 1;
    } else if (indexbox.SelectedIndex == 8) {
      indexbox.SelectedIndex = 9;
    } else if (indexbox.SelectedIndex == 107) {
      indexbox.SelectedIndex = 108;
    } else if (indexbox.SelectedIndex == 164) {
      indexbox.SelectedIndex = 165;
    } else if (indexbox.SelectedIndex == 189) {
      indexbox.SelectedIndex = 190;
    }

    if (indexbox.SelectedIndex > 0 && indexbox.SelectedIndex < 8) {
      medals.Index = indexbox.SelectedIndex - 1;
    } else if (indexbox.SelectedIndex > 8 && indexbox.SelectedIndex < 107) {
      medals.Index = indexbox.SelectedIndex - 2;
    } else if (indexbox.SelectedIndex > 107 && indexbox.SelectedIndex < 164) {
      medals.Index = indexbox.SelectedIndex - 3;
    } else if (indexbox.SelectedIndex > 164 && indexbox.SelectedIndex < 189) {
      medals.Index = indexbox.SelectedIndex - 4;
    } else if (indexbox.SelectedIndex > 189) {
      medals.Index = indexbox.SelectedIndex - 5;
    }

    update_date();
    update_medal_state();
    unreadFlag.Checked = medals.Flag4;
  }

  void Exit_butClick(object sender, EventArgs e) => Close();
  void Saveexit_butClick(object sender, EventArgs e) {
    SAV.SetBlock(medals.Data, Constants.B2W2.Medals);
    Close();
  }
  void Flag4boxCheckedChanged(object sender, EventArgs e) {
    medals.Flag4 = unreadFlag.Checked;
    update_hex();
  }

  void update_date() {
    if (medals.Year != 0 && medals.Month != 0 && medals.Day != 0) {
      red_panel.Visible = false;
      medal_date.Value = new DateTime(2000 + medals.Year, medals.Month, medals.Day);
      obtained.Checked = true;
    } else {
      red_panel.Visible = true;
      obtained.Checked = false;
    }
  }

  void Medal_dateValueChanged(object sender, EventArgs e) {
    medals.Year = medal_date.Value.Year - 2000;
    medals.Month = medal_date.Value.Month;
    medals.Day = medal_date.Value.Day;

    update_date();
    update_hex();
  }

  void Delete_butClick(object sender, EventArgs e) {
    medals.Year = 0;
    medals.Month = 0;
    medals.Day = 0;
    medals.Flag1 = false;
    medals.Flag2 = false;
    medals.Flag3 = false;
    medals.Flag4 = false;
    update_date();
    update_medal_state();
    unreadFlag.Checked = medals.Flag4;
  }

  void update_hex() {
    date_hex.Text = (medals.medal_bytes & 0x0000FFFF).ToString("X4");
    flag_hex.Text = ((medals.medal_bytes & 0xFFFF0000) >> 4).ToString("X4");
  }

  private void medalState_SelectedIndexChanged(object sender, EventArgs e) {
    if (medalState.SelectedIndex == 0) {
      medals.Flag1 = false;
      medals.Flag2 = false;
      medals.Flag3 = false;
    } else if (medalState.SelectedIndex == 1) {
      medals.Flag1 = true;
      medals.Flag2 = false;
      medals.Flag3 = false;
    } else if (medalState.SelectedIndex == 2) {
      medals.Flag1 = false;
      medals.Flag2 = true;
      medals.Flag3 = false;
    } else if (medalState.SelectedIndex == 3) {
      medals.Flag1 = true;
      medals.Flag2 = true;
      medals.Flag3 = false;
    } else if (medalState.SelectedIndex == 4) {
      medals.Flag1 = false;
      medals.Flag2 = false;
      medals.Flag3 = true;
    }
    update_hex();
  }

  private void update_medal_state() {
    if (!medals.Flag1 && !medals.Flag2 && !medals.Flag3) medalState.SelectedIndex = 0;
    else if (medals.Flag1 && !medals.Flag2 && !medals.Flag3) medalState.SelectedIndex = 1;
    else if (!medals.Flag1 && medals.Flag2 && !medals.Flag3) medalState.SelectedIndex = 2;
    else if (medals.Flag1 && medals.Flag2 && !medals.Flag3) medalState.SelectedIndex = 3;
    else if (!medals.Flag1 && !medals.Flag2 && medals.Flag3) medalState.SelectedIndex = 4;
  }

}
