using PKHeX.Core;

namespace PluginPile.RoamerTool;
public partial class Gen4RoamerForm : Form {

  private readonly SAV4 SAV;
  private readonly List<Gen4RoamerControl> RoamersControls;

  public Gen4RoamerForm(SAV4 sav) {
    InitializeComponent();
    HandleLanguageChange();
    SAV = sav;
    RoamersControls = [];
    foreach (Roamer4 roamer in SAV.GetRoamers()) {
      if (roamer.Active) {
        AddRoamerTab(roamer);
      }
    }
  }

  private void HandleLanguageChange() {
    Text = Language.MenuItemName;
    Cancel.Text = Language.Cancel;
    Save.Text = Language.Save;
  }

  private void AddRoamerTab(Roamer4 roamer) {
    Gen4RoamerControl control = new Gen4RoamerControl(roamer);
    RoamersControls.Add(control);
    TabPage page = new TabPage();
    page.Text = GameInfo.Strings.specieslist[roamer.Species];
    page.Controls.Add(control);
    Tabs.TabPages.Add(page);
  }

  private void Cancel_Click(object sender, EventArgs e) => Close();

  private void Save_Click(object sender, EventArgs e) {
    foreach(Gen4RoamerControl roamerControl in RoamersControls)
      roamerControl.Save();
    SAV.State.Edited = true;
    Close();
  }
}
