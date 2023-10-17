using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShEventEditor;
public partial class WorldEventsForm : Form {
  public enum Pages { Main, IsleOfArmor, CrownTundra }
  private readonly SAV8SWSH SAV;
  private bool loading;

  public WorldEventsForm(SAV8SWSH sav, Pages StartingPage) {
    InitializeComponent();
    SAV = sav;
    tabControl.SelectedIndex = (int)StartingPage;
  }

  private void WorldEvents_Load(object sender, EventArgs e) {
    loading = true;
    SetupMain();
    SetupIsleOfArmor();
    SetupCrownTundra();
    loading = false;
  }

  #region Main Game

  #region Lets go
  private void main_geevee_PB_Caught_OnClick(object sender, EventArgs e) {
    string[] issues = main_checklegal_Eevee();
    if (main_letsgo_forcelegal_CB.Checked)
      if (main_geevee_PB.Legalility == PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal)
        main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
  }

  private void main_geevee_PB_LegaliltyCheck_OnClick(object sender, EventArgs e) {
    string[] issues = main_checklegal_Eevee();
    main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
  }
  private void main_eevee_save_data_CB_CheckedChanged(object sender, EventArgs e) {
    string[] issues = main_checklegal_Eevee();
    if (main_letsgo_forcelegal_CB.Checked)
      if (main_geevee_PB.Legalility == PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal)
        main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
  }

  string[] main_checklegal_Eevee() {
    List<string> Issues = new List<string>();
    if (main_geevee_PB.Caught && !main_eevee_save_data_CB.Checked) {
      Issues.Add("Gift Eevee cannot be had while the player has no \"Let's Go: Eevee!\" save data!");
    }
    if (Issues.Count == 0)
      main_geevee_PB.Legalility = PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
    else
      main_geevee_PB.Legalility = PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal;
    return Issues.ToArray();
  }

  string[] main_checklegal_Pikachu() {
    List<string> Issues = new List<string>();
    if (main_gpikachu_PB.Caught && !main_pikachu_save_data_CB.Checked) {
      Issues.Add("Gift Pikachu cannot be had while the player has no \"Let's Go: Pikachu!\" save data!");
    }

    if (Issues.Count == 0)
      main_gpikachu_PB.Legalility = PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
    else
      main_gpikachu_PB.Legalility = PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal;
    return Issues.ToArray();
  }
  private void main_gpikachu_PB_Caught_OnClick(object sender, EventArgs e) {
    string[] issues = main_checklegal_Pikachu();
    if (main_letsgo_forcelegal_CB.Checked)
      if (main_gpikachu_PB.Legalility == PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal)
        main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
  }
  private void main_pikachu_save_data_CB_CheckedChanged(object sender, EventArgs e) {
    string[] issues = main_checklegal_Pikachu();
    if (main_letsgo_forcelegal_CB.Checked)
      if (main_gpikachu_PB.Legalility == PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal)
        main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
  }

  private void main_gpikachu_PB_LegaliltyCheck_OnClick(object sender, EventArgs e) {
    string[] issues = main_checklegal_Pikachu();
    main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issues);
  }

  private void main_letsgo_forcelegal_CB_CheckedChanged(object sender, EventArgs e) {
    string[] issuese = main_checklegal_Eevee();
    if (main_letsgo_forcelegal_CB.Checked)
      if (main_geevee_PB.Legalility == PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal)
        main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issuese);

    string[] issuesp = main_checklegal_Pikachu();
    if (main_letsgo_forcelegal_CB.Checked)
      if (main_gpikachu_PB.Legalility == PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal)
        main_letsgo_forcelegal_CB.Checked = ShowLegalMSG(issuesp);
  }
  #endregion

  void SetupMain() {

    main_eevee_save_data_CB.Checked = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["FSYS_PLAY_LETSGO_EEVEE"]).Type == SCTypeCode.Bool2;
    main_pikachu_save_data_CB.Checked = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["FSYS_PLAY_LETSGO_PIKACHU"]).Type == SCTypeCode.Bool2;

    main_geevee_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_037_EEVEE_CLEAR"]).Type == SCTypeCode.Bool2;
    main_gpikachu_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_037_PIKACHU_CLEAR"]).Type == SCTypeCode.Bool2;

    main_gift_gcharmander_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["z_t0101_i0202_MONSBALL"]).Type == SCTypeCode.Bool2;
    main_gift_typenull_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["z_bt0101_POKE_NUL"]).Type == SCTypeCode.Bool2;
    main_gift_toxel_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_005_CLEAR"]).Type == SCTypeCode.Bool2;
  }

  void SaveMain() {
    SCBlock b_pikachu_save_data = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["FSYS_PLAY_LETSGO_PIKACHU"]);
    SCBlock b_eevee_save_data = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["FSYS_PLAY_LETSGO_EEVEE"]);

    SCBlock b_geevee_caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_037_EEVEE_CLEAR"]);
    SCBlock b_gpikachu_caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_037_PIKACHU_CLEAR"]);

    SCBlock b_gift_gcharmander_caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["z_t0101_i0202_MONSBALL"]);
    SCBlock b_gift_typenull_caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["z_bt0101_POKE_NUL"]);
    SCBlock b_gift_toxel_caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["FE_SUB_005_CLEAR"]);


    b_pikachu_save_data.ChangeBooleanType(main_pikachu_save_data_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
    b_eevee_save_data.ChangeBooleanType(main_eevee_save_data_CB.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

    b_geevee_caught.ChangeBooleanType(main_geevee_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
    b_gpikachu_caught.ChangeBooleanType(main_gpikachu_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

    b_gift_gcharmander_caught.ChangeBooleanType(main_gift_gcharmander_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
    b_gift_typenull_caught.ChangeBooleanType(main_gift_typenull_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
    b_gift_toxel_caught.ChangeBooleanType(main_gift_toxel_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
  }

  #endregion

  #region Isle Of Armor

  void SetupIsleOfArmor() {
    if (SAV.SaveRevision < 1) {
      tabControl.Controls[1].Enabled = false;
      return;
    }
  }

  void SaveIsleOfArmor() {
    if (SAV.SaveRevision < 1) return;
  }

  #endregion

  #region Crown Tundra

  void SetupCrownTundra() {
    if (SAV.SaveRevision < 2) {
      tabControl.Controls[2].Enabled = false;
      return;
    }

    //Setup Birds
    ct_garticuno_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Articuno"]).Type == SCTypeCode.Bool2;
    ct_gzapdos_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Zapdos"]).Type == SCTypeCode.Bool2;
    ct_gmoltres_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Moltres"]).Type == SCTypeCode.Bool2;

    //Setup Cosmog
    ct_giftcosmog_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["z_wr0301_i0401_COSMOG"]).Type == SCTypeCode.Bool2;

    ct_gift_poipole_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["z_d0901_BEBENOM"]).Type == SCTypeCode.Bool2;
    //Setup Spiritomb
    ct_spiritomb_PB.Caught = SAV.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["FE_CAPTURE_MIKARUGE"]).Type == SCTypeCode.Bool2;
    ct_spiritomb_visible_CB.Checked = SAV.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["z_wr0321_SymbolEncountPokemonGimmickSpawner_WR03_Mikaruge"]).Type == SCTypeCode.Bool1;
    ct_spiritomb_players_NUD.Value = (uint)SAV.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["KPlayersInteractedOnline"]).GetValue()!;
  }

  void SaveCrownTundra() {
    if (SAV.SaveRevision < 2) return;

    SCBlock b_garticuno = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Articuno"]);
    SCBlock b_gzapdos = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Zapdos"]);
    SCBlock b_gmoltres = SAV.Blocks.GetBlock(Definitions.memkeys_Birds["Galarian Moltres"]);

    SCBlock b_giftcosmog = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["z_wr0301_i0401_COSMOG"]);

    SCBlock b_gift_poipole = SAV.Blocks.GetBlock(Definitions.memkeys_Gifts["z_d0901_BEBENOM"]);

    SCBlock b_spiritomb_caught = SAV.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["FE_CAPTURE_MIKARUGE"]);
    SCBlock b_spiritomb_visible = SAV.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["z_wr0321_SymbolEncountPokemonGimmickSpawner_WR03_Mikaruge"]);

    SCBlock b_playersonline = SAV.Blocks.GetBlock(Definitions.memkeys_CrownTundra_Misc["KPlayersInteractedOnline"]);

    b_garticuno.ChangeBooleanType(ct_garticuno_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
    b_gzapdos.ChangeBooleanType(ct_gzapdos_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
    b_gmoltres.ChangeBooleanType(ct_gmoltres_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

    b_giftcosmog.ChangeBooleanType(ct_giftcosmog_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

    b_gift_poipole.ChangeBooleanType(ct_gift_poipole_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

    b_spiritomb_caught.ChangeBooleanType(ct_spiritomb_PB.Caught ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
    b_spiritomb_visible.ChangeBooleanType(ct_spiritomb_visible_CB.Checked ? SCTypeCode.Bool1 : SCTypeCode.Bool2);

    b_playersonline.SetValue(Convert.ToUInt32(ct_spiritomb_players_NUD.Value));
  }

  #region Spiritomb
  private void ct_spiritomb_forcelegal_CB_CheckedChanged(object sender, EventArgs e) {
    string[] issues = ct_checklegal_Spiritomb();
    if (ct_spiritomb_forcelegal_CB.Checked)
      if (ct_spiritomb_PB.Legalility == PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal)
        ct_spiritomb_forcelegal_CB.Checked = ShowLegalMSG(issues);
  }

  private void ct_spiritomb_PB_LegaliltyCheck_OnClick(object sender, EventArgs e) {
    string[] issues = ct_checklegal_Spiritomb();
    ct_spiritomb_forcelegal_CB.Checked = ShowLegalMSG(issues);
  }


  private void ct_spiritomb_PB_Caught_OnClick(object sender, EventArgs e) {
    string[] issues = ct_checklegal_Spiritomb();
    if (ct_spiritomb_forcelegal_CB.Checked)
      if (ct_spiritomb_PB.Legalility == PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal)
        ct_spiritomb_forcelegal_CB.Checked = ShowLegalMSG(issues);
  }
  private void ct_spiritomb_visible_CB_CheckedChanged(object sender, EventArgs e) {
    string[] issues = ct_checklegal_Spiritomb();
    if (ct_spiritomb_forcelegal_CB.Checked)
      if (ct_spiritomb_PB.Legalility == PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal)
        ct_spiritomb_forcelegal_CB.Checked = ShowLegalMSG(issues);
  }

  private void ct_spiritomb_players_NUD_ValueChanged(object sender, EventArgs e) {
    string[] issues = ct_checklegal_Spiritomb();
    if (ct_spiritomb_forcelegal_CB.Checked)
      if (ct_spiritomb_PB.Legalility == PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal)
        ct_spiritomb_forcelegal_CB.Checked = ShowLegalMSG(issues);
  }

  string[] ct_checklegal_Spiritomb() {
    List<string> Issues = new List<string>();

    if (ct_spiritomb_PB.Caught && ct_spiritomb_visible_CB.Checked) {
      Issues.Add("Spiritomb cannot be caught and visible in the overworld!");
    }
    if (ct_spiritomb_visible_CB.Checked && ct_spiritomb_players_NUD.Value < 30) {
      Issues.Add("Spiritomb visible in the overworld if the player has less than 30 online interactions!");
    }
    if (ct_spiritomb_PB.Caught && ct_spiritomb_players_NUD.Value < 30) {
      Issues.Add("Spiritomb caught if the player has less than 30 online interactions!");
    }
    if (!ct_spiritomb_PB.Caught && !ct_spiritomb_visible_CB.Checked && ct_spiritomb_players_NUD.Value >= 30) {
      Issues.Add("Spiritomb is not caught or visble/spawned in the overworld but player interactions >= 30!");
    }

    if (Issues.Count == 0) ct_spiritomb_PB.Legalility = PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
    else ct_spiritomb_PB.Legalility = PluginPile.Unmaintained.SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal;

    return Issues.ToArray();
  }

  #endregion

  #region Galarian Birds
  private void ct_birds_caughtBTN_Click(object sender, EventArgs e) {
    ct_garticuno_PB.Caught = true;
    ct_gzapdos_PB.Caught = true;
    ct_gmoltres_PB.Caught = true;
  }

  private void ct_birds_uncaughtBTN_Click(object sender, EventArgs e) {
    ct_garticuno_PB.Caught = false;
    ct_gzapdos_PB.Caught = false;
    ct_gmoltres_PB.Caught = false;
  }
  #endregion

  #endregion

  bool ShowLegalMSG(string[] issues) {
    if (loading) return false;
    if (issues.Length == 0) {
      MessageBox.Show("Legal!", "Legal Status: Legal", MessageBoxButtons.OK, MessageBoxIcon.Information);
      return true;
    } else {
      string temp = "** POTENTIALLY ILLEGAL SAVE DATA **\n";
      for (int i = 0; i < issues.Length; i++) {
        temp += $"Invalid: {issues[i]}\n";
      }
      temp += "\nIf you believe this to be an error please click \"No\" and report the issue!\n" +
              "Would you like to disable show legalilty corrections?";
      if (MessageBox.Show(temp, "Legal Status: Potentially Illegal", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
        return true;
      else
        return false;
    }
  }

  private void ts_applyBTN_Click(object sender, EventArgs e) {
    SaveMain();
    SaveIsleOfArmor();
    SaveCrownTundra();
  }

}
