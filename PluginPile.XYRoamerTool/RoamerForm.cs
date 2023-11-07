using PKHeX.Core;

namespace PluginPile.XYRoamerTool; 
public partial class RoamerForm : Form {

  private readonly SAV6XY SAV;
  private readonly Roamer6 roamer;

  public RoamerForm(SAV6XY sav) {
    InitializeComponent();
    HandleLanguageChange();
    SAV = sav;
    roamer = SAV.Encount.Roamer;

    roamerSpecies.Items.AddRange(Language.Roamers);
    roamerSpecies.SelectedIndex = roamer.Species - 144;
    encountered.Value = roamer.TimesEncountered;
    state.Items.AddRange(Language.RoamerState);
    state.SelectedIndex = (int)roamer.RoamStatus;
  }

  private void HandleLanguageChange() {
    Text = Language.MenuItemName;
    cancel.Text = Language.Cancel;
    save.Text = Language.Save;
  }

  private void roamerSpeciesLabel_Click(object sender, EventArgs e) => roamerSpecies.Focus();

  private void encounteredLabel_Click(object sender, EventArgs e) => encountered.Focus();

  private void stateLabel_Click(object sender, EventArgs e) => state.Focus();

  private void cancel_Click(object sender, EventArgs e) => Close();

  private void save_Click(object sender, EventArgs e) {
    roamer.Species = (ushort)(144 + roamerSpecies.SelectedIndex);
    roamer.TimesEncountered = (uint)encountered.Value;
    roamer.RoamStatus = (Roamer6State)state.SelectedIndex;
    SAV.Encount.Roamer = roamer;
    SAV.State.Edited = true;
    Close();
  }

}
