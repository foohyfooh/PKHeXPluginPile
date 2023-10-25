using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShRaidTool;
public partial class RaidList : Form {
  private readonly RaidManager _raids;
  private readonly TextBox[] IVs;

  public RaidList(SaveBlockAccessor8SWSH blocks, GameVersion game, int badges, int tid, int sid) {
    InitializeComponent();
    IVs = new[] { TB_HP_IV1, TB_ATK_IV1, TB_DEF_IV1, TB_SPA_IV1, TB_SPD_IV1, TB_SPE_IV1 };
    _raids = new RaidManager(blocks, game, badges, (uint)tid, (uint)sid);
    CB_Den.SelectedIndex = 0;
    CenterToParent();
  }

  private void ChangeDenIndex(object sender, EventArgs e) => LoadDen(_raids[CB_Den.SelectedIndex]);

  private void ShowDenIVs(object sender, EventArgs e) {
    using DenIVs divs = new DenIVs(CB_Den.SelectedIndex, _raids);
    divs.ShowDialog();
  }

  private void LoadDen(RaidParameters raidParameters) {
    CHK_Active.Checked = raidParameters.IsActive;
    CHK_Rare.Checked = raidParameters.IsRare;
    CHK_Event.Checked = raidParameters.IsEvent;
    CHK_Wishing.Checked = raidParameters.IsWishingPiece;
    CHK_Watts.Checked = raidParameters.WattsHarvested;
    L_DenSeed.Text = $"{raidParameters.Seed:X16}";
    L_Stars.Text = RaidUtil.GetStarString(raidParameters);

    RaidPKM pkm = _raids.GenerateFromIndex(raidParameters);
    GameStrings s = GameInfo.Strings;;
    L_Ability.Text = $"Ability: {s.Ability[pkm.Ability]}";
    L_Nature.Text = $"Nature: {s.natures[pkm.Nature]}";
    L_ShinyInFrames.Text = $"Next Shiny Frame: {RandUtil.GetNextShinyFrame(raidParameters.Seed)}";
    L_Shiny.Visible = pkm.ShinyType != 0;
    L_Shiny.Text = pkm.ShinyType == 1 ? "Shiny: Star" : pkm.ShinyType == 2 ? (pkm.ForcedShinyType == 2 ? "Shiny: Forced Square" : "Shiny: Square!!!") : "Shiny locked";

    for (int i = 0; i < 6; i++) {
      IVs[i].Text = $"{pkm.IVs[i]:00}";
    }

    PB_PK1.BackgroundImage = RaidUtil.GetRaidResultSprite(pkm, CHK_Active.Checked);
    L_Location.Text = raidParameters.Location;

    if (raidParameters.X > 0 && raidParameters.Y > 0)
      DenMap.BackgroundImage = RaidUtil.GetNestMap(raidParameters);
  }
}
