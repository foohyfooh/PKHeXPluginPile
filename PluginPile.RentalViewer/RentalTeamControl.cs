using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.RentalViewer;
public partial class RentalTeamControl : UserControl {

  private readonly ISaveFileProvider SaveFileEditor;
  private readonly RentalTeam Team;
  private readonly ToolTip SetTooltip;

  public RentalTeamControl(ISaveFileProvider saveFileEditor, RentalTeam rentalTeam) {
    InitializeComponent();
    SetTooltip = new ToolTip() { InitialDelay = 200, IsBalloon = false, AutoPopDelay = 32_767 };
    SaveFileEditor = saveFileEditor;
    Team = rentalTeam;
    teamName.Text = Team.Name;
    teamInfo.Text = $"{Team.Creator} | {Team.Code}";

    PictureBox[] boxes = new PictureBox[] { pokemon1Image, pokemon2Image, pokemon3Image, pokemon4Image, pokemon5Image, pokemon6Image };
    foreach ((PictureBox box, PKM mon) in boxes.Zip(Team.Members)) {
      box.Image = DrawingUtil.GetSprite(mon);
      box.MouseEnter += (o, args) => {
        string setText = ShowdownParsing.GetLocalizedPreviewText(mon, GameInfo.CurrentLanguage);
        SetTooltip.SetToolTip(box, setText);
      };
      box.MouseLeave += (o, args) => SetTooltip.RemoveAll();
    }
  }

  private void BoxCopy_Click(object sender, EventArgs e) {
    for (int i = 0; i < Team.Count; i++)
      SaveFileEditor.SAV.SetBoxSlotAtIndex(Team[i], SaveFileEditor.CurrentBox, i);
    SaveFileEditor.ReloadSlots();
  }

  private void PartyCopy_Click(object sender, EventArgs e) {
    for (int i = 0; i < Team.Count; i++)
      SaveFileEditor.SAV.SetPartySlotAtIndex(Team[i], i);
    SaveFileEditor.ReloadSlots();
  }
}
