using PKHeX.Core;

namespace PluginPile.XYRoamerTool; 
public partial class RoamerForm : Form {

  private const int SpeciesOffset = 144;
  private const int StarterChoiceIndex = 48;
  private readonly SAV6XY SAV;
  private readonly Roamer6 Roamer;

  public RoamerForm(SAV6XY sav) {
    InitializeComponent();
    HandleLanguageChange();
    SAV = sav;
    Roamer = SAV.Encount.Roamer;

    // Roamer Species is obtainable from roamer info but if player hasn't beaten the league then derive it from the starter choice
    RoamerSpecies.SelectedIndex = Roamer.Species != 0 ? Roamer.Species - SpeciesOffset : sav.GetWork(StarterChoiceIndex);
    Encountered.Value = Roamer.TimesEncountered;
    State.SelectedIndex = (int)Roamer.RoamStatus;
  }

  private void HandleLanguageChange() {
    Text = Language.MenuItemName;
    RoamerSpecies.Items.AddRange(Language.Roamers);
    State.Items.AddRange(Language.RoamerState);
    Cancel.Text = Language.Cancel;
    Save.Text = Language.Save;
  }

  private void RoamerSpeciesLabel_Click(object sender, EventArgs e) => RoamerSpecies.Focus();

  private void EncounteredLabel_Click(object sender, EventArgs e) => Encountered.Focus();

  private void StateLabel_Click(object sender, EventArgs e) => State.Focus();

  private void Cancel_Click(object sender, EventArgs e) => Close();

  private void Save_Click(object sender, EventArgs e) {
    Roamer.Species = (ushort)(SpeciesOffset + RoamerSpecies.SelectedIndex);
    Roamer.TimesEncountered = (uint)Encountered.Value;
    Roamer.RoamStatus = (Roamer6State)State.SelectedIndex;
    SAV.State.Edited = true;
    Close();
  }

}
