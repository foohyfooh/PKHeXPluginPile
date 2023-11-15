using PKHeX.Core;
using System.Text;

namespace PluginPile.RentalViewer;
public class RentalTeams {

  private readonly List<RentalTeam> teams;

  public RentalTeams(SAV8SWSH sav) {
    teams = new List<RentalTeam>(Constants.SwSh.NumRentalTeams);
    SCBlock team1Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam1);
    teams.Add(new RentalTeam(sav, team1Block.Data));
    SCBlock team2Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam2);
    teams.Add(new RentalTeam(sav, team2Block.Data));
    SCBlock team3Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam3);
    teams.Add(new RentalTeam(sav, team3Block.Data));
    SCBlock team4Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam4);
    teams.Add(new RentalTeam(sav, team4Block.Data));
    SCBlock team5Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam5);
    teams.Add(new RentalTeam(sav, team5Block.Data));
  }

  public RentalTeams(SAV9SV sav) {
    teams = new List<RentalTeam>(Constants.SV.NumRentalTeams);
    byte[] codeData = sav.Blocks.GetBlock(Constants.SV.RentalTeamCodesLocation).Data;
    byte[] teamsData = sav.Blocks.GetBlock(Constants.SV.RentalTeamsLocation).Data;
    for (int i = 0; i < Constants.SV.NumRentalTeams; i++) {
      byte[] codeBytes = codeData
        .Skip(i * Constants.SV.RentalCodeSize)
        .Take((i + 1) * Constants.SV.RentalCodeSize)
        .ToArray();

      byte[] teamBytes = teamsData
        .Skip(i * Constants.SV.TeamSize)
        .Take((i + 1) * Constants.SV.TeamSize)
        .ToArray();
      teams.Add(new RentalTeam(sav, codeBytes, teamBytes));
    }
  }

  public RentalTeam this[int index] => teams[index];
}

public class RentalTeam {
  public readonly bool Enabled;
  public readonly string Code;
  public readonly string Creator;
  public readonly string Name;
  public readonly IReadOnlyList<PKM> Members;

  public RentalTeam(SAV8SWSH _, byte[] allTeamBytes) {
    List<PKM> mons = new List<PKM>();
    Enabled = allTeamBytes.Take(Constants.SwSh.StartingDataSize).Any(b => b != 0);
    Members = mons;
    if (Enabled) {
      byte[] teamBytes = allTeamBytes.Skip(Constants.SwSh.StartingDataSize).ToArray();
      byte[] codeBytes = teamBytes.Take(Constants.SwSh.TeamCodeSize).ToArray();
      Code = Encoding.Unicode.GetString(codeBytes).Trim('\0');
      Code = string.Join(" ", Code.Chunk(4).Select(c =>new string(c)));
      byte[] teamNameBytes = teamBytes.Skip(Constants.SwSh.TeamCodeSize).Take(Constants.SwSh.TeanNameSize).ToArray();
      Name = Encoding.Unicode.GetString(teamNameBytes).Trim('\0');
      byte[] teamCreatorBytes = teamBytes.Skip(Constants.SwSh.TeamCodeSize + Constants.SwSh.TeanNameSize).Take(Constants.SwSh.TeamCreatorNameSize).ToArray();
      Creator = Encoding.Unicode.GetString(teamCreatorBytes).Trim('\0');
      byte[] pokemonBytes = allTeamBytes.Skip(Constants.SwSh.TeamHeaderSize).ToArray();
      for (int i = 0; i < Constants.SwSh.NumTeamMons; i++) {
        byte[] partialData = pokemonBytes
        .Skip(i * Constants.SwSh.PokemonSize)
        .Take((i + 1) * Constants.SwSh.PokemonSize)
        .ToArray();
        PK8 mon = new PK8(partialData);
        if (mon.Valid && mon.Species != (int)Species.None)
          mons.Add(mon);
      }
    } else {
      Code = string.Empty;
      Creator = string.Empty;
      Name = string.Empty;
    }
  }

  public RentalTeam(SAV9SV _, byte[] codeBytes, byte[] teamBytes) {
    List<PKM> mons = new List<PKM>();
    Enabled = teamBytes[Constants.SV.TeamEnabledLocation] != 0;
    Members = mons;
    if (Enabled) {
      Code = Encoding.Unicode.GetString(codeBytes).Trim('\0');
      byte[] creatorNameBytes = teamBytes.Take(Constants.SV.TeamCreatorNameSize).ToArray();
      Creator = Encoding.Unicode.GetString(creatorNameBytes).Trim('\0');
      byte[] teamNameBytes = teamBytes.Skip(Constants.SV.TeamCreatorNameSize).Take(Constants.SV.TeamNameSize).ToArray();
      Name = Encoding.Unicode.GetString(teamNameBytes).Trim('\0');
      byte[] pokemonBytes = teamBytes.Skip(Constants.SV.TeamHeaderSize).ToArray();
      for (int i = 0; i < Constants.SV.NumTeamMons; i++) {
        byte[] partialData = pokemonBytes
        .Skip(i * Constants.SV.PokemonSize)
        .Take((i + 1) * Constants.SV.PokemonSize)
        .ToArray();
        PK9 mon = new PK9(partialData);
        if (mon.Valid && mon.Species != (int)Species.None)
          mons.Add(mon);
      }
    } else {
      Code = string.Empty;
      Creator = string.Empty;
      Name = string.Empty;
    }
  }

  public int Count => Members.Count;
  public PKM this[int index] => Members[index];
}
