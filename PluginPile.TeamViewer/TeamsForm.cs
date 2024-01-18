using PKHeX.Core;

namespace PluginPile.TeamViewer;
public partial class TeamsForm : Form {

  public TeamsForm(ISaveFileProvider saveFileProvider, TeamsType type) {
    InitializeComponent();
    Text = type == TeamsType.BattleBox ? Language.BattleTeams : Language.RentalTeams;

    TeamsBase teams;
    if (saveFileProvider.SAV is SAV8SWSH sav8swsh)
      teams = type == TeamsType.BattleBox ? new BattleTeams(sav8swsh) : new RentalTeams(sav8swsh);
    else if(saveFileProvider.SAV is SAV9SV sav9sv)
      teams = type == TeamsType.BattleBox ? new BattleTeams(sav9sv) : new RentalTeams(sav9sv);
    else
      throw new ArgumentException("Invalid SAV Type");

    Size = new Size(530, 50 + 155 * teams.Count);

    GroupBox[] teamSlots = [Team1Box, Team2Box, Team3Box, Team4Box, Team5Box, Team6Box];
    for (int i = 0; i < teams.Count; i++) {
      if (teams[i].Enabled) {
        TeamControl teamControl = new TeamControl(saveFileProvider, teams[i]);
        teamSlots[i].Controls.Add(teamControl);
      }
    }
  }

}

public enum TeamsType {
  BattleBox = 0,
  Rentals = 1,
}
