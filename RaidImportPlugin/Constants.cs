using Block = PluginPile.Common.Block;

namespace PluginPile.RaidImportPlugin {

  internal static class SwShConstants {
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
    public static readonly IReadOnlyList<Block> BaseGameBlocks    = new List<Block>() { BonusRewards, DiaEncounter, DropRewards, NormalEncount };
    public static readonly IReadOnlyList<Block> IsleOfArmorBlocks = new List<Block>(BaseGameBlocks) { NormalEncountRigel1 };
    public static readonly IReadOnlyList<Block> CrownTundraBlocks = new List<Block>(IsleOfArmorBlocks) { NormalEncountRigel2 };
  }

  internal static class SVConstants {
    // Base Game
    public static readonly Block EventRaidIdentifier    = (0x37B99B4D, "event_raid_identifier");
    public static readonly Block FixedRewardItemArray   = (0x7D6C2B82, "fixed_reward_item_array");
    public static readonly Block LotteryRewardItemArray = (0xA52B4811, "lottery_reward_item_array");
    public static readonly Block RaidEnemyArray         = (0x0520A1B0, "raid_enemy_array");
    public static readonly Block RaidPriorityArray      = (0x095451E4, "raid_priority_array");

    // Block Lists
    public static readonly IReadOnlyList<Block> BaseGameBlocks = new List<Block>() { EventRaidIdentifier, FixedRewardItemArray, LotteryRewardItemArray, RaidEnemyArray, RaidPriorityArray };
    public static readonly IReadOnlyList<Block> BaseGameBlocks_1_3_0 = BaseGameBlocks.Select(b => new Block(b.Location, b.Path + "_1_3_0")).ToList();
    public static readonly IReadOnlyList<Block> TealMaskBlocks = BaseGameBlocks.Select(b => new Block(b.Location, b.Path + "_2_0_0")).ToList();
  }
}
