using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.TeamViewer;
public class BattleTeams : TeamsBase {

  public BattleTeams(SAV8SWSH sav) : base(Constants.SwSh.NumBattleTeams) {
    sav.TeamIndexes.LoadBattleTeams();
    byte[] namesData = sav.Blocks.GetBlock(Constants.SwSh.BatleTeamsNames).Data;
    ExtractTeamFromIndexes(sav, Constants.SwSh.NumBattleTeams, sav.TeamIndexes, namesData, Constants.SwSh.BattleTeamNameSize);
  }

  public BattleTeams(SAV9SV sav) : base(Constants.SV.NumBattleTeams) {
    sav.TeamIndexes.LoadBattleTeams();
    byte[] namesData = sav.Blocks.GetBlock(Constants.SV.BatleTeamsNames).Data;
    ExtractTeamFromIndexes(sav, Constants.SV.NumBattleTeams, sav.TeamIndexes, namesData, Constants.SV.BattleTeamNameSize);
  }

  private void ExtractTeamFromIndexes(SaveFile sav, int numTeams, ITeamIndexSet indexes, byte[] names, int nameSize) {
    for (int i = 0; i < numTeams; i++) {
      byte[] nameBytes = names
        .Skip(i * nameSize)
        .Take(nameSize)
        .ToArray();
      string name = StringConverter8.GetString(nameBytes);
      if (name.Length == 0) name = $"{Language.Team} {i + 1}";
      List<PKM> mons = indexes.GetTeam(sav, i);
      Teams.Add(new BattleTeam(name, mons));
    }
  }

}

public class BattleTeam : TeamBase {
  public BattleTeam(string teamName, List<PKM> mons) : base() {
    Enabled = mons.Count > 0;
    Name = teamName;
    Mons = mons;
  }
}
