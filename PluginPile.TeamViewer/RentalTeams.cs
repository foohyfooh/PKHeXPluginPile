using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.TeamViewer;
public class RentalTeams : TeamsBase  {

  public RentalTeams(SAV8SWSH sav) : base(Constants.SwSh.NumRentalTeams) {
    SCBlock team1Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam1);
    Teams.Add(new RentalTeam8(team1Block.Data.ToArray()));
    SCBlock team2Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam2);
    Teams.Add(new RentalTeam8(team2Block.Data.ToArray()));
    SCBlock team3Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam3);
    Teams.Add(new RentalTeam8(team3Block.Data.ToArray()));
    SCBlock team4Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam4);
    Teams.Add(new RentalTeam8(team4Block.Data.ToArray()));
    SCBlock team5Block = sav.Blocks.GetBlock(Constants.SwSh.RentalTeam5);
    Teams.Add(new RentalTeam8(team5Block.Data.ToArray()));
  }

  public RentalTeams(SAV9SV sav) : base(Constants.SV.NumRentalTeams) {
    byte[] codesData = sav.Blocks.GetBlock(Constants.SV.RentalTeamCodesLocation).Data.ToArray();
    byte[] teamsData = sav.Blocks.GetBlock(Constants.SV.RentalTeamsLocation).Data.ToArray();
    for (int i = 0; i < Constants.SV.NumRentalTeams; i++) {
      byte[] codeBytes = codesData
        .Skip(i * Constants.SV.RentalCodeSize)
        .Take(Constants.SV.RentalCodeSize)
        .ToArray();
      byte[] teamBytes = teamsData
        .Skip(i * Constants.SV.RentalTeamSize)
        .Take(Constants.SV.RentalTeamSize)
        .ToArray();
      Teams.Add(new RentalTeam9(codeBytes, teamBytes));
    }
  }

}

public abstract class RentalTeam : TeamBase {
  public string Code { get; init; }
  public string Creator { get; init; }

  public RentalTeam() : base() {
    Code = string.Empty;
    Creator = string.Empty;
  }
}

public class RentalTeam8 : RentalTeam {
  public RentalTeam8(byte[] allTeamBytes) : base() {
    Enabled = allTeamBytes.Take(Constants.SwSh.RentalStartingDataSize).Any(b => b != 0);
    if (!Enabled) return;
    byte[] teamBytes = allTeamBytes.Skip(Constants.SwSh.RentalStartingDataSize).ToArray();
    byte[] codeBytes = teamBytes.Take(Constants.SwSh.RentalTeamCodeSize).ToArray();
    Code = StringConverter8.GetString(codeBytes);
    Code = string.Join(" ", Code.Chunk(4).Select(c => new string(c)));
    byte[] teamNameBytes = teamBytes.Skip(Constants.SwSh.RentalTeamCodeSize).Take(Constants.SwSh.TeamNameSize).ToArray();
    Name = StringConverter8.GetString(teamNameBytes);
    byte[] teamCreatorBytes = teamBytes.Skip(Constants.SwSh.RentalTeamCodeSize + Constants.SwSh.TeamNameSize).Take(Constants.SwSh.RentalTeamCreatorNameSize).ToArray();
    Creator = StringConverter8.GetString(teamCreatorBytes);
    byte[] pokemonBytes = allTeamBytes.Skip(Constants.SwSh.RentalTeamHeaderSize).ToArray();
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
    Enabled = teamBytes[Constants.SV.RentalTeamEnabledLocation] != 0;
    if (!Enabled) return;
    Code = StringConverter8.GetString(codeBytes);
    byte[] creatorNameBytes = teamBytes.Take(Constants.SV.RentalTeamCreatorNameSize).ToArray();
    Creator = StringConverter8.GetString(creatorNameBytes);
    byte[] teamNameBytes = teamBytes.Skip(Constants.SV.RentalTeamCreatorNameSize).Take(Constants.SV.RentalTeamNameSize).ToArray();
    Name = StringConverter8.GetString(teamNameBytes);
    byte[] pokemonBytes = teamBytes.Skip(Constants.SV.RentalTeamHeaderSize).ToArray();
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
