using PluginPile.Common;

namespace PluginPile.RentalViewer;
internal static class Constants {

  internal static class SV {
    public static readonly Block RentalTeamCodesLocation = 0xB476F6D4;
    public const int RentalCodeSize = 0x88;

    public static readonly Block RentalTeamsLocation = 0x19CB0339;
    public const int TeamSize = 0x844;
    public const int TeamHeaderSize = 0x30;
    public const int TeamCreatorNameSize = 0x18;
    public const int TeamNameSize = 0x18;
    public const int TeamEnabledLocation = 0x840;
    public const int PokemonSize = 0x158;
    public const int NumRentalTeams = 5;
    public const int NumTeamMons = 6;
  }

  internal static class SwSh {
    public static readonly Block RentalTeam1 = 0x149A1DD0;
    public static readonly Block RentalTeam2 = 0x179A2289;
    public static readonly Block RentalTeam3 = 0x169A20F6;
    public static readonly Block RentalTeam4 = 0x199A25AF;
    public static readonly Block RentalTeam5 = 0x189A241C;

    public const int TeamHeaderSize = 0x56;
    public const int StartingDataSize = 0x08;
    public const int TeamCodeSize = 0x1E;
    public const int TeanNameSize = 0x16;
    public const int TeamCreatorNameSize = 0x1A;
    public const int PokemonSize = 0x158;
    public const int NumRentalTeams = 5;
    public const int NumTeamMons = 6;
  }

}
