using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.TeamViewer;
public partial class TeamControl : UserControl {

  private readonly ISaveFileProvider SaveFileEditor;
  private readonly TeamBase Team;
  private readonly ToolTip SetTooltip;

  public TeamControl(ISaveFileProvider saveFileEditor, TeamBase team) {
    InitializeComponent();
    HandleLanguageChange();
    SetTooltip = new ToolTip() { InitialDelay = 200, IsBalloon = false, AutoPopDelay = 32_767 };
    SaveFileEditor = saveFileEditor;
    Team = team;
    TeamName.Text = Team.Name;
    if (Team is RentalTeam rentalTeam) {
      TeamInfo.Text = $"{rentalTeam.Creator} | {rentalTeam.Code}";
    } else {
      TeamInfo.Text = "";
      CopyToBox.Enabled = false;
      CopyToParty.Enabled = false;
    }

    PictureBox[] boxes = [Pokemon1Image, Pokemon2Image, Pokemon3Image, Pokemon4Image, Pokemon5Image, Pokemon6Image];
    foreach ((PictureBox box, PKM mon) in boxes.Zip(Team.Members)) {
      box.Image = DrawingUtil.GetSprite(mon);
      box.MouseEnter += (o, args) => {
        string setText = ShowdownParsing.GetLocalizedPreviewText(mon, new BattleTemplateExportSettings(GameInfo.CurrentLanguage));
        SetTooltip.SetToolTip(box, setText);
      };
      box.MouseLeave += (o, args) => SetTooltip.RemoveAll();
    }
  }

  private void HandleLanguageChange() {
    CopyToBox.Text = Language.CopyToBox;
    CopyToParty.Text = Language.CopyToParty;
    CopyPaste.Text = Language.CopyPaste;
  }

  private void CopyToBox_Click(object sender, EventArgs e) {
    for (int i = 0; i < Team.Count; i++)
      SaveFileEditor.SAV.SetBoxSlotAtIndex(Team[i], SaveFileEditor.CurrentBox, i);
    SaveFileEditor.ReloadSlots();
  }

  private void CopyToParty_Click(object sender, EventArgs e) {
    for (int i = 0; i < Team.Count; i++)
      SaveFileEditor.SAV.SetPartySlotAtIndex(Team[i], i);
    SaveFileEditor.ReloadSlots();
  }

  private void CopyPaste_Click(object sender, EventArgs e) {
    string paste = ShowdownParsing.GetShowdownSets(Team.Members, Environment.NewLine + Environment.NewLine);
    Clipboard.SetText(paste);
  }
}
