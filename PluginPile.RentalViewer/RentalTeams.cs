using PKHeX.Core;
using System.Text;

namespace PluginPile.RentalViewer;
public class RentalTeams {

  private readonly List<RentalTeam> teams;

  private RentalTeams(int numTeams) {
    teams = new List<RentalTeam>(numTeams);
  }

  public RentalTeams(SAV8SWSH sav) : this(Constants.SwSh.NumRentalTeams) {
    SCBlock team1Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam1);
    teams.Add(new RentalTeam8(team1Block.Data));
    SCBlock team2Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam2);
    teams.Add(new RentalTeam8(team2Block.Data));
    SCBlock team3Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam3);
    teams.Add(new RentalTeam8(team3Block.Data));
    SCBlock team4Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam4);
    teams.Add(new RentalTeam8(team4Block.Data));
    SCBlock team5Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam5);
    teams.Add(new RentalTeam8(team5Block.Data));
  }

  public RentalTeams(SAV9SV sav) : this(Constants.SV.NumRentalTeams) {
    byte[] codeData = sav.Blocks.GetBlock(Constants.SV.RentalTeamCodesLocation).Data;
    byte[] teamsData = sav.Blocks.GetBlock(Constants.SV.RentalTeamsLocation).Data;
    for (int i = 0; i < Constants.SV.NumRentalTeams; i++) {
      byte[] codeBytes = codeData
        .Skip(i * Constants.SV.RentalCodeSize)
        .Take(Constants.SV.RentalCodeSize)
        .ToArray();
      byte[] teamBytes = teamsData
        .Skip(i * Constants.SV.TeamSize)
        .Take(Constants.SV.TeamSize)
        .ToArray();
      teams.Add(new RentalTeam9(codeBytes, teamBytes));
    }
  }

  public RentalTeam this[int index] => teams[index];
}

public abstract class RentalTeam {
  public bool Enabled { get; init; }
  public string Code { get; init; }
  public string Creator { get; init; }
  public string Name { get; init; }
  protected List<PKM> Mons;

  public RentalTeam() {
    Enabled = false;
    Code = string.Empty;
    Creator = string.Empty;
    Name = string.Empty;
    Mons = new List<PKM>(Constants.NumTeamMons);
  }

  public IReadOnlyList<PKM> Members => Mons;
  public int Count => Members.Count;
  public PKM this[int index] => Members[index];
}

public class RentalTeam8 : RentalTeam {
  public RentalTeam8(byte[] allTeamBytes) : base() {
    Enabled = allTeamBytes.Take(Constants.SwSh.StartingDataSize).Any(b => b != 0);
    if (!Enabled) return;
    byte[] teamBytes = allTeamBytes.Skip(Constants.SwSh.StartingDataSize).ToArray();
    byte[] codeBytes = teamBytes.Take(Constants.SwSh.TeamCodeSize).ToArray();
    Code = Encoding.Unicode.GetString(codeBytes).Trim('\0');
    Code = string.Join(" ", Code.Chunk(4).Select(c => new string(c)));
    byte[] teamNameBytes = teamBytes.Skip(Constants.SwSh.TeamCodeSize).Take(Constants.SwSh.TeanNameSize).ToArray();
    Name = Encoding.Unicode.GetString(teamNameBytes).Trim('\0');
    byte[] teamCreatorBytes = teamBytes.Skip(Constants.SwSh.TeamCodeSize + Constants.SwSh.TeanNameSize).Take(Constants.SwSh.TeamCreatorNameSize).ToArray();
    Creator = Encoding.Unicode.GetString(teamCreatorBytes).Trim('\0');
    byte[] pokemonBytes = allTeamBytes.Skip(Constants.SwSh.TeamHeaderSize).ToArray();
    for (int i = 0; i < Constants.NumTeamMons; i++) {
      byte[] partialData = pokemonBytes
      .Skip(i * Constants.SwSh.PokemonSize)
      .Take(Constants.SwSh.PokemonSize)
      .ToArray();
      PK8 mon = new PK8(partialData);
      if (mon.Valid && mon.Species != (int)Species.None)
        Mons.Add(mon);
    }
  }
}

public class RentalTeam9 : RentalTeam {
  public RentalTeam9(byte[] codeBytes, byte[] teamBytes) : base() {
    Enabled = teamBytes[Constants.SV.TeamEnabledLocation] != 0;
    if (!Enabled) return;
    Code = Encoding.Unicode.GetString(codeBytes).Trim('\0');
    byte[] creatorNameBytes = teamBytes.Take(Constants.SV.TeamCreatorNameSize).ToArray();
    Creator = Encoding.Unicode.GetString(creatorNameBytes).Trim('\0');
    byte[] teamNameBytes = teamBytes.Skip(Constants.SV.TeamCreatorNameSize).Take(Constants.SV.TeamNameSize).ToArray();
    Name = Encoding.Unicode.GetString(teamNameBytes).Trim('\0');
    byte[] pokemonBytes = teamBytes.Skip(Constants.SV.TeamHeaderSize).ToArray();
    for (int i = 0; i < Constants.NumTeamMons; i++) {
      byte[] partialData = pokemonBytes
      .Skip(i * Constants.SV.PokemonSize)
      .Take(Constants.SV.PokemonSize)
      .ToArray();
      PK9 mon = new PK9(partialData);
      if (mon.Valid && mon.Species != (int)Species.None)
        Mons.Add(mon);
    }
  }
}
