using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool;

public partial class MedalsForm : Form {
  private readonly SAV5B2W2 Origin, SAV;
  private readonly MedalList5 Medals;
  private int MedalIndex;

  public MedalsForm(SAV5B2W2 sav) {
    InitializeComponent();
    SAV = (SAV5B2W2)(Origin = sav).Clone();
    MedalDate.Enabled = false;
    Medals = SAV.Medals;
    MedalSelection.SelectedIndex = 0;
  }

  void MedalSelection_SelectedIndexChanged(object sender, EventArgs e) {
    if (MedalSelection.SelectedIndex == -1) {
      return;
    } else if (MedalSelection.SelectedIndex == 0) {
      MedalSelection.SelectedIndex = 1;
    } else if (MedalSelection.SelectedIndex == 8) {
      MedalSelection.SelectedIndex = 9;
    } else if (MedalSelection.SelectedIndex == 107) {
      MedalSelection.SelectedIndex = 108;
    } else if (MedalSelection.SelectedIndex == 164) {
      MedalSelection.SelectedIndex = 165;
    } else if (MedalSelection.SelectedIndex == 189) {
      MedalSelection.SelectedIndex = 190;
    }

    if (MedalSelection.SelectedIndex > 0 && MedalSelection.SelectedIndex < 8) {
      MedalIndex = MedalSelection.SelectedIndex - 1;
    } else if (MedalSelection.SelectedIndex > 8 && MedalSelection.SelectedIndex < 107) {
      MedalIndex = MedalSelection.SelectedIndex - 2;
    } else if (MedalSelection.SelectedIndex > 107 && MedalSelection.SelectedIndex < 164) {
      MedalIndex = MedalSelection.SelectedIndex - 3;
    } else if (MedalSelection.SelectedIndex > 164 && MedalSelection.SelectedIndex < 189) {
      MedalIndex = MedalSelection.SelectedIndex - 4;
    } else if (MedalSelection.SelectedIndex > 189) {
      MedalIndex = MedalSelection.SelectedIndex - 5;
    }

    Medal5 currentMedal = Medals[MedalIndex];
    MedalState.SelectedIndex = (int)currentMedal.State;
    if (currentMedal.CanHaveDate) {
      MedalDate.Enabled = true;
      MedalDate.Value = currentMedal.Date.ToDateTime(new TimeOnly());
    } else {
      MedalDate.Enabled = false;
      MedalDate.Value = EncounterDate.GetDateNDS().ToDateTime(new TimeOnly());
    }
    UnreadFlag.Checked = currentMedal.IsUnread;
  }

  void Exit_Click(object sender, EventArgs e) => Close();

  void Save_Click(object sender, EventArgs e) {
    Origin.CopyChangesFrom(SAV);
    Close();
  }

  private void MedalState_SelectedIndexChanged(object sender, EventArgs e) {
    Medal5 currentMedal = Medals[MedalIndex];
    currentMedal.State = (MedalState5)MedalState.SelectedIndex;
    if (currentMedal.CanHaveDate) {
      if (!currentMedal.HasDate)
        currentMedal.Date = EncounterDate.GetDateNDS();
      MedalDate.Enabled = true;
    } else {
      MedalDate.Enabled = false;
    }
  }

  void MedalDate_ValueChanged(object sender, EventArgs e) {
    if (MedalDate.Enabled) {
      Medal5 CurrentMedal = Medals[MedalIndex];
      CurrentMedal.Date = DateOnly.FromDateTime(MedalDate.Value);
    } 
  }
  
  void UnreadFlag_CheckedChanged(object sender, EventArgs e) {
    Medal5 currentMedal = Medals[MedalIndex];
    currentMedal.IsUnread = UnreadFlag.Checked;
  }

  void Delete_Click(object sender, EventArgs e) {
    Medal5 currentMedal = Medals[MedalIndex];
    currentMedal.Clear();
    int index = MedalSelection.SelectedIndex;
    MedalSelection.SelectedIndex = -1;
    MedalSelection.SelectedIndex = index;
  }
}
