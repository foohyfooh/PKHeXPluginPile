using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.Unmaintained.SwShEventEditor {
  public partial class PokeCampCurrydexForm : Form {

    private readonly SAV8SWSH SAV;
    //bool[][] CurryDex;

    public PokeCampCurrydexForm(SAV8SWSH sav) {
      SAV = sav;
      InitializeComponent();
    }

    private void CurrdexForm_Load(object sender, EventArgs e) {
      SetupCamp();
      //label1.Text = SAV.Blocks.GetBlock(0x68EED750).Type.ToString();
    }

    #region Camp
    void SetupCamp() {
      camp_ball_fresh_CB.Checked = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_FRESH_BALL"]).GetBooleanValue();
      camp_ball_weighted_CB.Checked = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_HEAVY_BALL"]).GetBooleanValue();
      camp_ball_soothe_CB.Checked = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_YASURAGI_BALL"]).GetBooleanValue();
      camp_ball_mirror_CB.Checked = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_MIRROR_BALL"]).GetBooleanValue();
      camp_ball_tympole_CB.Checked = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_OTAMA_BALL"]).GetBooleanValue();
      camp_ball_champion_CB.Checked = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_CHAMPION_BALL"]).GetBooleanValue();

      camp_has_golden_CB.Checked = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_GOLDEN_KITCHENWARE"]).GetBooleanValue();
      camp_use_golden_CB.Checked = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_USE_GOLDEN_KITCHENWARE"]).GetBooleanValue();

      camp_type_CMB.SelectedIndex = Convert.ToInt32(SAV.Blocks.GetBlock(Definitions.PokeCampKeys["SYS_WORK_POKECAMP_TENT_COLOR"]).GetValue());
    }

    void SaveCamp() {
      SCBlock b_fresh_ball = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_FRESH_BALL"]);
      SCBlock b_weighted_ball = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_HEAVY_BALL"]);
      SCBlock b_soothe_ball = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_YASURAGI_BALL"]);
      SCBlock b_mirror_ball = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_MIRROR_BALL"]);
      SCBlock b_tympole_ball = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_OTAMA_BALL"]);
      SCBlock b_champion_ball = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_CHAMPION_BALL"]);

      SCBlock b_has_golden_CB = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_OPEN_GOLDEN_KITCHENWARE"]);
      SCBlock b_use_golden_CB = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["FSYS_POKECAMP_USE_GOLDEN_KITCHENWARE"]);

      SCBlock b_tent_color = SAV.Blocks.GetBlock(Definitions.PokeCampKeys["SYS_WORK_POKECAMP_TENT_COLOR"]);

      b_fresh_ball.ChangeBooleanValue(camp_ball_fresh_CB.Checked);
      b_weighted_ball.ChangeBooleanValue(camp_ball_weighted_CB.Checked);
      b_soothe_ball.ChangeBooleanValue(camp_ball_soothe_CB.Checked);
      b_mirror_ball.ChangeBooleanValue(camp_ball_mirror_CB.Checked);
      b_tympole_ball.ChangeBooleanValue(camp_ball_tympole_CB.Checked);
      b_champion_ball.ChangeBooleanValue(camp_ball_champion_CB.Checked);

      b_has_golden_CB.ChangeBooleanValue(camp_has_golden_CB.Checked);
      b_use_golden_CB.ChangeBooleanValue(camp_use_golden_CB.Checked);

      b_tent_color.SetValue(Convert.ToUInt32(camp_type_CMB.SelectedIndex));
    }

    private void camp_type_CMB_SelectedIndexChanged(object sender, EventArgs e) {
      camp_type_PB.Invalidate();
    }

    private void camp_type_PB_Paint(object sender, PaintEventArgs e) {
      e.Graphics.Clear(Color.Magenta);
      if (camp_type_CMB.SelectedIndex != -1)
        e.Graphics.DrawImage((Bitmap)Properties.Resources.ResourceManager.GetObject($"type_icon_{camp_type_CMB.SelectedIndex}")!, 0, 0);
    }
    #endregion

    private void ts_applyBTN_Click(object sender, EventArgs e) {
      SaveCamp();
      Close();
    }
  }
}
