using PKHeX.Core;

namespace PluginPile.RentalViewer;
public partial class RentalTeamsForm : Form {

  public RentalTeamsForm(ISaveFileProvider saveFileProvider) {
    InitializeComponent();
    RentalTeams rentalTeams;

    if (saveFileProvider.SAV is SAV8SWSH sav8swsh)
      rentalTeams = new RentalTeams(sav8swsh);
    else if(saveFileProvider.SAV is SAV9SV sav9sv)
      rentalTeams = new RentalTeams(sav9sv);
    else
      throw new ArgumentException("Invalid SAV Type");

    GroupBox[] teamSlots = new GroupBox[] { team1Box, team2Box, team3Box, team4Box, team5Box };
    for (int i = 0; i < Constants.SV.NumRentalTeams; i++) {
      if (rentalTeams[i].Enabled) {
        RentalTeamControl teamControl = new RentalTeamControl(saveFileProvider, rentalTeams[i]);
        teamSlots[i].Controls.Add(teamControl);
      }
    }
  }

}
