using PluginPile.Common;

namespace PluginPile.TeamViewer;
internal static class Constants {

  public const int NumTeamMons = 6;

  internal static class SwSh {
    public static readonly Block BattleTeamsIndexes = 0x33F39467;
    public static readonly Block BatleTeamsNames = 0x1920C1E4;

    public const int BattleTeamSize = 0x0C;
    public const int BattleTeamNameSize = 0x16;
    public const int NumBattleTeams = 6;

    public static readonly Block RentalTeam1 = 0x149A1DD0;
    public static readonly Block RentalTeam2 = 0x179A2289;
    public static readonly Block RentalTeam3 = 0x169A20F6;
    public static readonly Block RentalTeam4 = 0x199A25AF;
    public static readonly Block RentalTeam5 = 0x189A241C;

    public const int RentalTeamHeaderSize = 0x56;
    public const int RentalStartingDataSize = 0x08;
    public const int RentalTeamCodeSize = 0x1E;
    public const int RentalTeamCreatorNameSize = 0x1A;

    public const int TeamNameSize = 0x16;
    public const int PokemonSize = 0x158;
    public const int NumRentalTeams = 5;
  }

  internal static class SV {
    public static readonly Block BattleTeamsIndexes = 0x33F39467;
    public static readonly Block BatleTeamsNames = 0x1920C1E4;

    public const int BattleTeamSize = 0x0C;
    public const int BattleTeamNameSize = 0x16;
    public const int NumBattleTeams = 6;

    public static readonly Block RentalTeamCodesLocation = 0xB476F6D4;
    public const int RentalCodeSize = 0x88;

    public static readonly Block RentalTeamsLocation = 0x19CB0339;
    public const int RentalTeamSize = 0x844;
    public const int RentalTeamHeaderSize = 0x30;
    public const int RentalTeamCreatorNameSize = 0x18;
    public const int RentalTeamNameSize = 0x18;
    public const int RentalTeamEnabledLocation = 0x840;
    public const int PokemonSize = 0x158;
    public const int NumRentalTeams = 5;
  }

}
