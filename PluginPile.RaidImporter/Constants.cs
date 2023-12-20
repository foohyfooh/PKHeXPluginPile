using PluginPile.Common;

namespace PluginPile.RaidImporter; 
internal static class Constants {

  internal static class SwSh {
    // Base Game
    public static readonly Block BonusRewards        = (0xEFCAE04E, "bonus_rewards");
    public static readonly Block DiaEncounter        = (0xAD3920F5, "dai_encount");
    public static readonly Block DropRewards         = (0x680EEB85, "drop_rewards");
    public static readonly Block NormalEncount       = (0xAD9DFA6A, "normal_encount");
    // Isle of Armor DLC
    public static readonly Block NormalEncountRigel1 = (0x0E615A8C, "normal_encount_rigel1");
    // Crown Tundra DLC
    public static readonly Block NormalEncountRigel2 = (0x11615F45, "normal_encount_rigel2");

    // Block Lists
    public static readonly IReadOnlyList<Block> BaseGameBlocks    = [BonusRewards, DiaEncounter, DropRewards, NormalEncount];
    public static readonly IReadOnlyList<Block> IsleOfArmorBlocks = [.. BaseGameBlocks,    NormalEncountRigel1];
    public static readonly IReadOnlyList<Block> CrownTundraBlocks = [.. IsleOfArmorBlocks, NormalEncountRigel2];
  }

  internal static class SV {
    // Version Suffixes
    private static readonly string TealMaskSuffix    = "_2_0_0";
    private static readonly string InidigoDiskSuffix = "_3_0_0";

    // Base Game Raids
    public static readonly Block RaidEventIdentifier        = (0x37B99B4D, "event_raid_identifier");
    public static readonly Block RaidFixedRewardItemArray   = (0x7D6C2B82, "fixed_reward_item_array");
    public static readonly Block RaidLotteryRewardItemArray = (0xA52B4811, "lottery_reward_item_array");
    public static readonly Block RaidEnemyArray             = (0x0520A1B0, "raid_enemy_array");
    public static readonly Block RaidPriorityArray          = (0x095451E4, "raid_priority_array");

    // Raids Block Lists
    public static readonly IReadOnlyList<Block> BaseGameRaidBlocks       = [RaidEventIdentifier, RaidFixedRewardItemArray, RaidLotteryRewardItemArray, RaidEnemyArray, RaidPriorityArray];
    public static readonly IReadOnlyList<Block> BaseGameRaidBlocks_1_3_0 = [.. BaseGameRaidBlocks.Select(b => new Block(b.Location, b.Path + "_1_3_0"))];
    public static readonly IReadOnlyList<Block> TealMaskRaidBlocks       = [.. BaseGameRaidBlocks.Select(b => new Block(b.Location, b.Path + TealMaskSuffix))];
    public static readonly IReadOnlyList<Block> IndigoDiskRaidBlocks     = [.. BaseGameRaidBlocks.Select(b => new Block(b.Location, b.Path + InidigoDiskSuffix))];

    // Outbreaks
    public static readonly Block OutbreakEnabled       =  0x61552076;
    public static readonly Block OutbreakPokedata      = (0x6C1A131B, "pokedata_array");
    public static readonly Block OutbreakZonePaldea    = (0x3FDC5DFF, "zone_main_array");
    public static readonly Block OutbreakZoneKitakami  = (0xF9F156A3, "zone_su1_array");
    public static readonly Block OutbreakZoneBlueberry = (0x1B45E41C, "zone_su2_array");

    // Outbreaks Block Lists
    private static readonly IReadOnlyList<Block> TealMaskOutbreakBlocksNoSuffix   = [OutbreakPokedata, OutbreakZonePaldea, OutbreakZoneKitakami];
    private static readonly IReadOnlyList<Block> IndigoDiskOutbreakBlocksNoSuffix = [.. TealMaskOutbreakBlocksNoSuffix, OutbreakZoneBlueberry];

    public static readonly IReadOnlyList<Block> TealMaskOutbreakBlocks   = [.. TealMaskOutbreakBlocksNoSuffix.Select(b => new Block(b.Location, b.Path + TealMaskSuffix))];
    public static readonly IReadOnlyList<Block> IndigoDiskOutbreakBlocks = [.. IndigoDiskOutbreakBlocksNoSuffix.Select(b => new Block(b.Location, b.Path + InidigoDiskSuffix))];
  }

}
