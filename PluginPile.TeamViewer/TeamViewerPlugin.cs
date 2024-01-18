using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.TeamViewer;

public class TeamViewerPlugin : PluginBase {

  public override string Name => nameof(TeamViewer);
  private readonly ToolStripMenuItem ViewBattleTeamsButton;
  private readonly ToolStripMenuItem ViewRentalsButton;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV8SWSH or SAV9SV;

  public TeamViewerPlugin() {
    ViewBattleTeamsButton = new ToolStripMenuItem(Language.ViewBattleTeams);
    ViewBattleTeamsButton.Click += (s, e) => new TeamsForm(SaveFileEditor, TeamsType.BattleBox).Show();
    ViewRentalsButton = new ToolStripMenuItem(Language.ViewRentalTeams);
    ViewRentalsButton.Click += (s, e) => new TeamsForm(SaveFileEditor, TeamsType.Rentals).Show();
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    tools.DropDownItems.Add(ViewBattleTeamsButton);
    tools.DropDownItems.Add(ViewRentalsButton);
  }

  protected override void HandleSaveLoaded() => ViewRentalsButton.Available = IsCompatibleSave;

  public override void NotifyDisplayLanguageChanged(string language) {
    ViewBattleTeamsButton.Text = Language.ViewBattleTeams;
    ViewRentalsButton.Text = Language.ViewRentalTeams;
  }

}
