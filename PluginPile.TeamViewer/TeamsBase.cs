using PKHeX.Core;

namespace PluginPile.TeamViewer; 
public abstract class TeamsBase(int numTeams) {
  protected readonly List<TeamBase> Teams = new List<TeamBase>(numTeams);
  public int Count => Teams.Count;
  public TeamBase this[int index] => Teams[index];
}

public abstract class TeamBase {
  public bool Enabled { get; init; }
  public string Name { get; init; }
  protected List<PKM> Mons;

  public TeamBase() {
    Enabled = false;
    Name = string.Empty;
    Mons = new List<PKM>(Constants.NumTeamMons);
  }

  public IReadOnlyList<PKM> Members => Mons;
  public int Count => Members.Count;
  public PKM this[int index] => Members[index];
}
