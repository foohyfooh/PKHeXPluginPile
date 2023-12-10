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

    GroupBox[] teamSlots = [Team1Box, Team2Box, Team3Box, Team4Box, Team5Box];
    for (int i = 0; i < rentalTeams.Count; i++) {
      if (rentalTeams[i].Enabled) {
        RentalTeamControl teamControl = new RentalTeamControl(saveFileProvider, rentalTeams[i]);
        teamSlots[i].Controls.Add(teamControl);
      }
    }
  }

}
