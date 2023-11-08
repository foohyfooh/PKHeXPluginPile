using PKHeX.Core;

namespace PluginPile.XYRoamerTool; 
public partial class RoamerForm : Form {

  private const int SpeciesOffset = 144;
  private const int StarterChoiceIndex = 48;
  private readonly SAV6XY SAV;
  private readonly Roamer6 roamer;

  public RoamerForm(SAV6XY sav) {
    InitializeComponent();
    HandleLanguageChange();
    SAV = sav;
    roamer = SAV.Encount.Roamer;

    // Roamer Species is obtainable from roamer info but if player hasn't beaten the league then derive it from the starter choice
    roamerSpecies.SelectedIndex = roamer.Species != 0 ? roamer.Species - SpeciesOffset : sav.GetWork(StarterChoiceIndex);
    encountered.Value = roamer.TimesEncountered;
    state.SelectedIndex = (int)roamer.RoamStatus;
  }

  private void HandleLanguageChange() {
    Text = Language.MenuItemName;
    roamerSpecies.Items.AddRange(Language.Roamers);
    state.Items.AddRange(Language.RoamerState);
    cancel.Text = Language.Cancel;
    save.Text = Language.Save;
  }

  private void roamerSpeciesLabel_Click(object sender, EventArgs e) => roamerSpecies.Focus();

  private void encounteredLabel_Click(object sender, EventArgs e) => encountered.Focus();

  private void stateLabel_Click(object sender, EventArgs e) => state.Focus();

  private void cancel_Click(object sender, EventArgs e) => Close();

  private void save_Click(object sender, EventArgs e) {
    roamer.Species = (ushort)(SpeciesOffset + roamerSpecies.SelectedIndex);
    roamer.TimesEncountered = (uint)encountered.Value;
    roamer.RoamStatus = (Roamer6State)state.SelectedIndex;
    SAV.Encount.Roamer = roamer;
    SAV.State.Edited = true;
    Close();
  }

}
