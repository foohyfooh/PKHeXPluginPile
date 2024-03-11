using PKHeX.Core;

namespace PluginPile.TeamViewer;

public static class TeamIndexesExtensions {

  public static List<PKM> GetTeam(this ITeamIndexSet teamIndexes, SaveFile sav, int i) {
     int[] slots = teamIndexes switch {
      TeamIndexes8 indexes8 => indexes8.TeamSlots,
      _ => throw new ArgumentException("Invalid Team Indexes")
    };

    List<PKM> team = [];
    for(int j = i * 6, end = j + 6; j < end; j++) {
      if (slots[j] != -1) {
        team.Add(sav.GetBoxSlotAtIndex(slots[j]));
      }
    }
    return team;
  }

}
