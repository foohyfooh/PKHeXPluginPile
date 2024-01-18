using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.TeamViewer;
public class BattleTeams : TeamsBase {

  public BattleTeams(SAV8SWSH sav) : base(Constants.SwSh.NumBattleTeams) {
    byte[] teamsData = sav.Blocks.GetBlock(Constants.SwSh.BattleTeamsIndexes).Data;
    byte[] namesData = sav.Blocks.GetBlock(Constants.SwSh.BatleTeamsNames).Data;
    ExtractSwShOrSV(sav, Constants.SwSh.NumBattleTeams, teamsData, namesData, Constants.SwSh.BattleTeamNameSize);
  }

  public BattleTeams(SAV9SV sav) : base(Constants.SV.NumBattleTeams) {
    byte[] teamsData = sav.Blocks.GetBlock(Constants.SV.BattleTeamsIndexes).Data;
    byte[] namesData = sav.Blocks.GetBlock(Constants.SV.BatleTeamsNames).Data;
    ExtractSwShOrSV(sav, Constants.SV.NumBattleTeams, teamsData, namesData, Constants.SV.BattleTeamNameSize);
  }

  private void ExtractSwShOrSV(SaveFile sav, int numTeams, byte[] indexes, byte[] names, int nameSize) {
    int indexSize = 0x0C; // 2 bytes (slot and box) for each member
    for (int i = 0; i < numTeams; i++) {
      byte[] nameBytes = names
        .Skip(i * nameSize)
        .Take(nameSize)
        .ToArray();
      string name = StringUtils.GetUnicodeString(nameBytes);
      if (name.Length == 0) name = $"{Language.Team} {i + 1}";
      byte[] teamIndexes = indexes
        .Skip(i * indexSize)
        .Take(indexSize)
        .ToArray();
      List<PKM> mons = [];
      for (int j = 0; j < Constants.NumTeamMons; j++) {
        byte slot = teamIndexes[j * 2    ];
        byte box  = teamIndexes[j * 2 + 1];
        if (slot != 0xFF && box != 0xFF) {
          PKM mon = sav.GetBoxSlotAtIndex(box, slot);
          mons.Add(mon);
        }
      }
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
