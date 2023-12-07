namespace PluginPile.Unmaintained.SwShEventEditor {
  partial class WorldEventsForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      tabControl = new TabControl();
      mainPage = new TabPage();
      championGiftsGroup = new GroupBox();
      main_gift_gcharmander_PB = new Controls.PokemonBaseUC();
      main_gift_typenull_PB = new Controls.PokemonBaseUC();
      main_gift_toxel_PB = new Controls.PokemonBaseUC();
      letsGoGroup = new GroupBox();
      main_eevee_save_data_CB = new CheckBox();
      main_letsgo_forcelegal_CB = new CheckBox();
      main_geevee_PB = new Controls.PokemonBaseUC();
      main_pikachu_save_data_CB = new CheckBox();
      main_gpikachu_PB = new Controls.PokemonBaseUC();
      ioaPage = new TabPage();
      dojoGroup = new GroupBox();
      battledHoneyToday = new CheckBox();
      canBattleHoney = new CheckBox();
      vitaminsVendingMachineDisappeared = new CheckBox();
      drinksVendingMachineDisappeared = new CheckBox();
      fixedRotomiDisappeared = new CheckBox();
      brokenRotomiDisappared = new CheckBox();
      hairStylistAvailable = new CheckBox();
      tableDisappeared = new CheckBox();
      ioaWattDonationProgress = new ComboBox();
      ioaWattDonationProgressLabel = new Label();
      pokemonBaseUC7 = new Controls.PokemonBaseUC();
      ioaWattDonationTotalLabel = new Label();
      ioaWattDonationTotal = new NumericUpDown();
      pokemonBaseUC8 = new Controls.PokemonBaseUC();
      ctPage = new TabPage();
      ct_gift_poipole_PB = new Controls.PokemonBaseUC();
      spiritombGroup = new GroupBox();
      ct_spiritomb_forcelegal_CB = new CheckBox();
      playersInteractedLabel = new Label();
      ct_spiritomb_players_NUD = new NumericUpDown();
      ct_spiritomb_visible_CB = new CheckBox();
      ct_spiritomb_PB = new Controls.PokemonBaseUC();
      galarianBirdsGroup = new GroupBox();
      ct_gmoltres_PB = new Controls.PokemonBaseUC();
      ct_birds_uncaughtBTN = new Button();
      ct_birds_caughtBTN = new Button();
      ct_gzapdos_PB = new Controls.PokemonBaseUC();
      ct_garticuno_PB = new Controls.PokemonBaseUC();
      ct_giftcosmog_PB = new Controls.PokemonBaseUC();
      toolStrip1 = new ToolStrip();
      ts_applyBTN = new ToolStripButton();
      tabControl.SuspendLayout();
      mainPage.SuspendLayout();
      championGiftsGroup.SuspendLayout();
      letsGoGroup.SuspendLayout();
      ioaPage.SuspendLayout();
      dojoGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ioaWattDonationTotal).BeginInit();
      ctPage.SuspendLayout();
      spiritombGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ct_spiritomb_players_NUD).BeginInit();
      galarianBirdsGroup.SuspendLayout();
      toolStrip1.SuspendLayout();
      SuspendLayout();
      //
      // tabControl
      //
      tabControl.Controls.Add(mainPage);
      tabControl.Controls.Add(ioaPage);
      tabControl.Controls.Add(ctPage);
      tabControl.Dock = DockStyle.Fill;
      tabControl.Location = new Point(0, 25);
      tabControl.Margin = new Padding(4, 3, 4, 3);
      tabControl.Name = "tabControl";
      tabControl.SelectedIndex = 0;
      tabControl.Size = new Size(933, 494);
      tabControl.TabIndex = 0;
      //
      // mainPage
      //
      mainPage.BackColor = SystemColors.Control;
      mainPage.Controls.Add(championGiftsGroup);
      mainPage.Controls.Add(main_gift_toxel_PB);
      mainPage.Controls.Add(letsGoGroup);
      mainPage.Location = new Point(4, 24);
      mainPage.Margin = new Padding(4, 3, 4, 3);
      mainPage.Name = "mainPage";
      mainPage.Padding = new Padding(4, 3, 4, 3);
      mainPage.Size = new Size(925, 466);
      mainPage.TabIndex = 0;
      mainPage.Text = "Main Game";
      //
      // championGiftsGroup
      //
      championGiftsGroup.Controls.Add(main_gift_gcharmander_PB);
      championGiftsGroup.Controls.Add(main_gift_typenull_PB);
      championGiftsGroup.Location = new Point(298, 7);
      championGiftsGroup.Margin = new Padding(4, 3, 4, 3);
      championGiftsGroup.Name = "championGiftsGroup";
      championGiftsGroup.Padding = new Padding(4, 3, 4, 3);
      championGiftsGroup.Size = new Size(186, 231);
      championGiftsGroup.TabIndex = 25;
      championGiftsGroup.TabStop = false;
      championGiftsGroup.Text = "Champion Gifts";
      //
      // main_gift_gcharmander_PB
      //
      main_gift_gcharmander_PB.Caught = false;
      main_gift_gcharmander_PB.DrawDynaxMaxIcon = true;
      main_gift_gcharmander_PB.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
      main_gift_gcharmander_PB.Location = new Point(7, 22);
      main_gift_gcharmander_PB.Margin = new Padding(5, 3, 5, 3);
      main_gift_gcharmander_PB.MaximumSize = new Size(158, 83);
      main_gift_gcharmander_PB.MinimumSize = new Size(158, 83);
      main_gift_gcharmander_PB.Name = "main_gift_gcharmander_PB";
      main_gift_gcharmander_PB.Pokemon = 4;
      main_gift_gcharmander_PB.PokemonName = "Gigantmax Charmander Gift";
      main_gift_gcharmander_PB.PokemonSubform = "";
      main_gift_gcharmander_PB.Size = new Size(158, 83);
      main_gift_gcharmander_PB.TabIndex = 21;
      main_gift_gcharmander_PB.ToolTip = "Player must be champion";
      //
      // main_gift_typenull_PB
      //
      main_gift_typenull_PB.Caught = false;
      main_gift_typenull_PB.DrawDynaxMaxIcon = false;
      main_gift_typenull_PB.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
      main_gift_typenull_PB.Location = new Point(7, 112);
      main_gift_typenull_PB.Margin = new Padding(5, 3, 5, 3);
      main_gift_typenull_PB.MaximumSize = new Size(152, 83);
      main_gift_typenull_PB.MinimumSize = new Size(152, 83);
      main_gift_typenull_PB.Name = "main_gift_typenull_PB";
      main_gift_typenull_PB.Pokemon = 772;
      main_gift_typenull_PB.PokemonName = "Type:Null Gift";
      main_gift_typenull_PB.PokemonSubform = "";
      main_gift_typenull_PB.Size = new Size(152, 83);
      main_gift_typenull_PB.TabIndex = 23;
      main_gift_typenull_PB.ToolTip = "Player must be champion";
      //
      // main_gift_toxel_PB
      //
      main_gift_toxel_PB.Caught = false;
      main_gift_toxel_PB.DrawDynaxMaxIcon = false;
      main_gift_toxel_PB.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
      main_gift_toxel_PB.Location = new Point(490, 10);
      main_gift_toxel_PB.Margin = new Padding(5, 3, 5, 3);
      main_gift_toxel_PB.MaximumSize = new Size(152, 83);
      main_gift_toxel_PB.MinimumSize = new Size(152, 83);
      main_gift_toxel_PB.Name = "main_gift_toxel_PB";
      main_gift_toxel_PB.Pokemon = 848;
      main_gift_toxel_PB.PokemonName = "Toxel Gift";
      main_gift_toxel_PB.PokemonSubform = "";
      main_gift_toxel_PB.Size = new Size(152, 83);
      main_gift_toxel_PB.TabIndex = 24;
      main_gift_toxel_PB.ToolTip = "";
      //
      // letsGoGroup
      //
      letsGoGroup.Controls.Add(main_eevee_save_data_CB);
      letsGoGroup.Controls.Add(main_letsgo_forcelegal_CB);
      letsGoGroup.Controls.Add(main_geevee_PB);
      letsGoGroup.Controls.Add(main_pikachu_save_data_CB);
      letsGoGroup.Controls.Add(main_gpikachu_PB);
      letsGoGroup.Location = new Point(9, 7);
      letsGoGroup.Margin = new Padding(4, 3, 4, 3);
      letsGoGroup.Name = "letsGoGroup";
      letsGoGroup.Padding = new Padding(4, 3, 4, 3);
      letsGoGroup.Size = new Size(280, 231);
      letsGoGroup.TabIndex = 19;
      letsGoGroup.TabStop = false;
      letsGoGroup.Text = "Let's Go Gifts";
      //
      // main_eevee_save_data_CB
      //
      main_eevee_save_data_CB.AutoSize = true;
      main_eevee_save_data_CB.Location = new Point(93, 157);
      main_eevee_save_data_CB.Margin = new Padding(4, 3, 4, 3);
      main_eevee_save_data_CB.Name = "main_eevee_save_data_CB";
      main_eevee_save_data_CB.Size = new Size(155, 19);
      main_eevee_save_data_CB.TabIndex = 17;
      main_eevee_save_data_CB.Text = "Let's Go Eevee Save Data";
      main_eevee_save_data_CB.UseVisualStyleBackColor = true;
      main_eevee_save_data_CB.CheckedChanged += main_eevee_save_data_CB_CheckedChanged;
      //
      // main_letsgo_forcelegal_CB
      //
      main_letsgo_forcelegal_CB.AutoSize = true;
      main_letsgo_forcelegal_CB.Location = new Point(7, 202);
      main_letsgo_forcelegal_CB.Margin = new Padding(4, 3, 4, 3);
      main_letsgo_forcelegal_CB.Name = "main_letsgo_forcelegal_CB";
      main_letsgo_forcelegal_CB.Size = new Size(169, 19);
      main_letsgo_forcelegal_CB.TabIndex = 18;
      main_letsgo_forcelegal_CB.Text = "Show Legalility Corrections";
      main_letsgo_forcelegal_CB.UseVisualStyleBackColor = true;
      main_letsgo_forcelegal_CB.CheckedChanged += main_letsgo_forcelegal_CB_CheckedChanged;
      //
      // main_geevee_PB
      //
      main_geevee_PB.Caught = false;
      main_geevee_PB.DrawDynaxMaxIcon = false;
      main_geevee_PB.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
      main_geevee_PB.Location = new Point(7, 112);
      main_geevee_PB.Margin = new Padding(5, 3, 5, 3);
      main_geevee_PB.MaximumSize = new Size(152, 83);
      main_geevee_PB.MinimumSize = new Size(152, 83);
      main_geevee_PB.Name = "main_geevee_PB";
      main_geevee_PB.Pokemon = 133;
      main_geevee_PB.PokemonName = "Gigantmax Eevee Gift";
      main_geevee_PB.PokemonSubform = "gmax";
      main_geevee_PB.Size = new Size(152, 83);
      main_geevee_PB.TabIndex = 15;
      main_geevee_PB.ToolTip = "";
      main_geevee_PB.LegaliltyCheck_OnClick += main_geevee_PB_LegaliltyCheck_OnClick;
      main_geevee_PB.Caught_OnClick += main_geevee_PB_Caught_OnClick;
      //
      // main_pikachu_save_data_CB
      //
      main_pikachu_save_data_CB.AutoSize = true;
      main_pikachu_save_data_CB.Location = new Point(93, 67);
      main_pikachu_save_data_CB.Margin = new Padding(4, 3, 4, 3);
      main_pikachu_save_data_CB.Name = "main_pikachu_save_data_CB";
      main_pikachu_save_data_CB.Size = new Size(167, 19);
      main_pikachu_save_data_CB.TabIndex = 16;
      main_pikachu_save_data_CB.Text = "Let's Go Pikachu Save Data";
      main_pikachu_save_data_CB.UseVisualStyleBackColor = true;
      main_pikachu_save_data_CB.CheckedChanged += main_pikachu_save_data_CB_CheckedChanged;
      //
      // main_gpikachu_PB
      //
      main_gpikachu_PB.Caught = false;
      main_gpikachu_PB.DrawDynaxMaxIcon = false;
      main_gpikachu_PB.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
      main_gpikachu_PB.Location = new Point(7, 22);
      main_gpikachu_PB.Margin = new Padding(5, 3, 5, 3);
      main_gpikachu_PB.MaximumSize = new Size(152, 83);
      main_gpikachu_PB.MinimumSize = new Size(152, 83);
      main_gpikachu_PB.Name = "main_gpikachu_PB";
      main_gpikachu_PB.Pokemon = 25;
      main_gpikachu_PB.PokemonName = "Gigantmax Pikachu Gift";
      main_gpikachu_PB.PokemonSubform = "gmax";
      main_gpikachu_PB.Size = new Size(152, 83);
      main_gpikachu_PB.TabIndex = 14;
      main_gpikachu_PB.ToolTip = "";
      main_gpikachu_PB.LegaliltyCheck_OnClick += main_gpikachu_PB_LegaliltyCheck_OnClick;
      main_gpikachu_PB.Caught_OnClick += main_gpikachu_PB_Caught_OnClick;
      //
      // ioaPage
      //
      ioaPage.BackColor = SystemColors.Control;
      ioaPage.Controls.Add(dojoGroup);
      ioaPage.Location = new Point(4, 24);
      ioaPage.Margin = new Padding(4, 3, 4, 3);
      ioaPage.Name = "ioaPage";
      ioaPage.Padding = new Padding(4, 3, 4, 3);
      ioaPage.Size = new Size(925, 466);
      ioaPage.TabIndex = 1;
      ioaPage.Text = "Isle of Armor";
      //
      // dojoGroup
      //
      dojoGroup.Controls.Add(battledHoneyToday);
      dojoGroup.Controls.Add(canBattleHoney);
      dojoGroup.Controls.Add(vitaminsVendingMachineDisappeared);
      dojoGroup.Controls.Add(drinksVendingMachineDisappeared);
      dojoGroup.Controls.Add(fixedRotomiDisappeared);
      dojoGroup.Controls.Add(brokenRotomiDisappared);
      dojoGroup.Controls.Add(hairStylistAvailable);
      dojoGroup.Controls.Add(tableDisappeared);
      dojoGroup.Controls.Add(ioaWattDonationProgress);
      dojoGroup.Controls.Add(ioaWattDonationProgressLabel);
      dojoGroup.Controls.Add(pokemonBaseUC7);
      dojoGroup.Controls.Add(ioaWattDonationTotalLabel);
      dojoGroup.Controls.Add(ioaWattDonationTotal);
      dojoGroup.Controls.Add(pokemonBaseUC8);
      dojoGroup.Location = new Point(9, 7);
      dojoGroup.Margin = new Padding(4, 3, 4, 3);
      dojoGroup.Name = "dojoGroup";
      dojoGroup.Padding = new Padding(4, 3, 4, 3);
      dojoGroup.Size = new Size(571, 336);
      dojoGroup.TabIndex = 13;
      dojoGroup.TabStop = false;
      dojoGroup.Text = "Dojo";
      //
      // battledHoneyToday
      //
      battledHoneyToday.AutoSize = true;
      battledHoneyToday.Location = new Point(298, 296);
      battledHoneyToday.Name = "battledHoneyToday";
      battledHoneyToday.Size = new Size(135, 19);
      battledHoneyToday.TabIndex = 14;
      battledHoneyToday.Text = "Battled Honey Today";
      battledHoneyToday.UseVisualStyleBackColor = true;
      //
      // canBattleHoney
      //
      canBattleHoney.AutoSize = true;
      canBattleHoney.Location = new Point(174, 296);
      canBattleHoney.Name = "canBattleHoney";
      canBattleHoney.Size = new Size(118, 19);
      canBattleHoney.TabIndex = 32;
      canBattleHoney.Text = "Can Battle Honey";
      canBattleHoney.UseVisualStyleBackColor = true;
      //
      // vitaminsVendingMachineDisppeared
      //
      vitaminsVendingMachineDisappeared.AutoSize = true;
      vitaminsVendingMachineDisappeared.Location = new Point(174, 271);
      vitaminsVendingMachineDisappeared.Name = "vitaminsVendingMachineDisppeared";
      vitaminsVendingMachineDisappeared.Size = new Size(241, 19);
      vitaminsVendingMachineDisappeared.TabIndex = 31;
      vitaminsVendingMachineDisappeared.Text = "Vitamins Vending Machine Disappaeared";
      vitaminsVendingMachineDisappeared.UseVisualStyleBackColor = true;
      //
      // drinksVendingMachineDisppeared
      //
      drinksVendingMachineDisappeared.AutoSize = true;
      drinksVendingMachineDisappeared.Location = new Point(174, 246);
      drinksVendingMachineDisappeared.Name = "drinksVendingMachineDisppeared";
      drinksVendingMachineDisappeared.Size = new Size(228, 19);
      drinksVendingMachineDisappeared.TabIndex = 30;
      drinksVendingMachineDisappeared.Text = "Drinks Vending Machine Disappaeared";
      drinksVendingMachineDisappeared.UseVisualStyleBackColor = true;
      //
      // fixedRotomiDisappeared
      //
      fixedRotomiDisappeared.AutoSize = true;
      fixedRotomiDisappeared.Location = new Point(174, 196);
      fixedRotomiDisappeared.Name = "fixedRotomiDisappeared";
      fixedRotomiDisappeared.Size = new Size(133, 19);
      fixedRotomiDisappeared.TabIndex = 28;
      fixedRotomiDisappeared.Text = "Rotomi Disappeared";
      fixedRotomiDisappeared.UseVisualStyleBackColor = true;
      //
      // brokenRotomiDisappared
      //
      brokenRotomiDisappared.AutoSize = true;
      brokenRotomiDisappared.Location = new Point(174, 171);
      brokenRotomiDisappared.Name = "brokenRotomiDisappared";
      brokenRotomiDisappared.Size = new Size(173, 19);
      brokenRotomiDisappared.TabIndex = 27;
      brokenRotomiDisappared.Text = "Broken Rotomi Disappeared";
      brokenRotomiDisappared.UseVisualStyleBackColor = true;
      //
      // hairStylistAvailable
      //
      hairStylistAvailable.AutoSize = true;
      hairStylistAvailable.Location = new Point(174, 146);
      hairStylistAvailable.Name = "hairStylistAvailable";
      hairStylistAvailable.Size = new Size(133, 19);
      hairStylistAvailable.TabIndex = 26;
      hairStylistAvailable.Text = "Hair Stylist Available";
      hairStylistAvailable.UseVisualStyleBackColor = true;
      //
      // tableDisappeared
      //
      tableDisappeared.AutoSize = true;
      tableDisappeared.Location = new Point(174, 221);
      tableDisappeared.Name = "tableDisappeared";
      tableDisappeared.Size = new Size(121, 19);
      tableDisappeared.TabIndex = 29;
      tableDisappeared.Text = "Table Disappeared";
      tableDisappeared.UseVisualStyleBackColor = true;
      //
      // ioaWattDonationProgress
      //
      ioaWattDonationProgress.FormattingEnabled = true;
      ioaWattDonationProgress.Location = new Point(174, 40);
      ioaWattDonationProgress.Name = "ioaWattDonationProgress";
      ioaWattDonationProgress.Size = new Size(287, 23);
      ioaWattDonationProgress.TabIndex = 25;
      //
      // ioaWattDonationProgressLabel
      //
      ioaWattDonationProgressLabel.AutoSize = true;
      ioaWattDonationProgressLabel.Location = new Point(174, 19);
      ioaWattDonationProgressLabel.Name = "ioaWattDonationProgressLabel";
      ioaWattDonationProgressLabel.Size = new Size(132, 15);
      ioaWattDonationProgressLabel.TabIndex = 14;
      ioaWattDonationProgressLabel.Text = "Watt Donation Progress";
      //
      // pokemonBaseUC7
      //
      pokemonBaseUC7.Caught = false;
      pokemonBaseUC7.DrawDynaxMaxIcon = true;
      pokemonBaseUC7.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal;
      pokemonBaseUC7.Location = new Point(7, 112);
      pokemonBaseUC7.Margin = new Padding(5, 3, 5, 3);
      pokemonBaseUC7.MaximumSize = new Size(152, 83);
      pokemonBaseUC7.MinimumSize = new Size(152, 83);
      pokemonBaseUC7.Name = "pokemonBaseUC7";
      pokemonBaseUC7.Pokemon = 7;
      pokemonBaseUC7.PokemonName = "Gigantmax Bulbasaur Gift";
      pokemonBaseUC7.PokemonSubform = "";
      pokemonBaseUC7.Size = new Size(152, 83);
      pokemonBaseUC7.TabIndex = 24;
      pokemonBaseUC7.ToolTip = "";
      //
      // ioaWattDonationTotalLabel
      //
      ioaWattDonationTotalLabel.AutoSize = true;
      ioaWattDonationTotalLabel.Location = new Point(174, 76);
      ioaWattDonationTotalLabel.Margin = new Padding(4, 0, 4, 0);
      ioaWattDonationTotalLabel.Name = "ioaWattDonationTotalLabel";
      ioaWattDonationTotalLabel.Size = new Size(84, 15);
      ioaWattDonationTotalLabel.TabIndex = 11;
      ioaWattDonationTotalLabel.Text = "Watt Donation";
      //
      // ioaWattDonationTotal
      //
      ioaWattDonationTotal.Location = new Point(174, 94);
      ioaWattDonationTotal.Margin = new Padding(4, 3, 4, 3);
      ioaWattDonationTotal.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
      ioaWattDonationTotal.Name = "ioaWattDonationTotal";
      ioaWattDonationTotal.Size = new Size(130, 23);
      ioaWattDonationTotal.TabIndex = 12;
      //
      // pokemonBaseUC8
      //
      pokemonBaseUC8.Caught = false;
      pokemonBaseUC8.DrawDynaxMaxIcon = true;
      pokemonBaseUC8.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Illegal;
      pokemonBaseUC8.Location = new Point(7, 22);
      pokemonBaseUC8.Margin = new Padding(5, 3, 5, 3);
      pokemonBaseUC8.MaximumSize = new Size(152, 83);
      pokemonBaseUC8.MinimumSize = new Size(152, 83);
      pokemonBaseUC8.Name = "pokemonBaseUC8";
      pokemonBaseUC8.Pokemon = 1;
      pokemonBaseUC8.PokemonName = "Gigantmax Bulbasaur Gift";
      pokemonBaseUC8.PokemonSubform = "";
      pokemonBaseUC8.Size = new Size(152, 83);
      pokemonBaseUC8.TabIndex = 23;
      pokemonBaseUC8.ToolTip = "";
      //
      // ctPage
      //
      ctPage.BackColor = SystemColors.Control;
      ctPage.Controls.Add(ct_gift_poipole_PB);
      ctPage.Controls.Add(spiritombGroup);
      ctPage.Controls.Add(galarianBirdsGroup);
      ctPage.Controls.Add(ct_giftcosmog_PB);
      ctPage.Location = new Point(4, 24);
      ctPage.Margin = new Padding(4, 3, 4, 3);
      ctPage.Name = "ctPage";
      ctPage.Padding = new Padding(4, 3, 4, 3);
      ctPage.Size = new Size(925, 466);
      ctPage.TabIndex = 2;
      ctPage.Text = "Crown Tundra";
      //
      // ct_gift_poipole_PB
      //
      ct_gift_poipole_PB.Caught = false;
      ct_gift_poipole_PB.DrawDynaxMaxIcon = false;
      ct_gift_poipole_PB.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
      ct_gift_poipole_PB.Location = new Point(545, 97);
      ct_gift_poipole_PB.Margin = new Padding(5, 3, 5, 3);
      ct_gift_poipole_PB.MaximumSize = new Size(152, 83);
      ct_gift_poipole_PB.MinimumSize = new Size(152, 83);
      ct_gift_poipole_PB.Name = "ct_gift_poipole_PB";
      ct_gift_poipole_PB.Pokemon = 803;
      ct_gift_poipole_PB.PokemonName = "Poipole Gift";
      ct_gift_poipole_PB.PokemonSubform = "";
      ct_gift_poipole_PB.Size = new Size(152, 83);
      ct_gift_poipole_PB.TabIndex = 10;
      ct_gift_poipole_PB.ToolTip = "";
      //
      // spiritombGroup
      //
      spiritombGroup.Controls.Add(ct_spiritomb_forcelegal_CB);
      spiritombGroup.Controls.Add(playersInteractedLabel);
      spiritombGroup.Controls.Add(ct_spiritomb_players_NUD);
      spiritombGroup.Controls.Add(ct_spiritomb_visible_CB);
      spiritombGroup.Controls.Add(ct_spiritomb_PB);
      spiritombGroup.Location = new Point(304, 7);
      spiritombGroup.Margin = new Padding(4, 3, 4, 3);
      spiritombGroup.Name = "spiritombGroup";
      spiritombGroup.Padding = new Padding(4, 3, 4, 3);
      spiritombGroup.Size = new Size(233, 190);
      spiritombGroup.TabIndex = 9;
      spiritombGroup.TabStop = false;
      spiritombGroup.Text = "Spiritomb Values";
      //
      // ct_spiritomb_forcelegal_CB
      //
      ct_spiritomb_forcelegal_CB.AutoSize = true;
      ct_spiritomb_forcelegal_CB.Location = new Point(10, 160);
      ct_spiritomb_forcelegal_CB.Margin = new Padding(4, 3, 4, 3);
      ct_spiritomb_forcelegal_CB.Name = "ct_spiritomb_forcelegal_CB";
      ct_spiritomb_forcelegal_CB.Size = new Size(169, 19);
      ct_spiritomb_forcelegal_CB.TabIndex = 10;
      ct_spiritomb_forcelegal_CB.Text = "Show Legalility Corrections";
      ct_spiritomb_forcelegal_CB.UseVisualStyleBackColor = true;
      ct_spiritomb_forcelegal_CB.CheckedChanged += ct_spiritomb_forcelegal_CB_CheckedChanged;
      //
      // playersInteractedLabel
      //
      playersInteractedLabel.AutoSize = true;
      playersInteractedLabel.Location = new Point(13, 112);
      playersInteractedLabel.Margin = new Padding(4, 0, 4, 0);
      playersInteractedLabel.Name = "playersInteractedLabel";
      playersInteractedLabel.Size = new Size(126, 15);
      playersInteractedLabel.TabIndex = 10;
      playersInteractedLabel.Text = "Players Interacted with";
      //
      // ct_spiritomb_players_NUD
      //
      ct_spiritomb_players_NUD.Location = new Point(10, 130);
      ct_spiritomb_players_NUD.Margin = new Padding(4, 3, 4, 3);
      ct_spiritomb_players_NUD.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
      ct_spiritomb_players_NUD.Name = "ct_spiritomb_players_NUD";
      ct_spiritomb_players_NUD.Size = new Size(130, 23);
      ct_spiritomb_players_NUD.TabIndex = 10;
      ct_spiritomb_players_NUD.ValueChanged += ct_spiritomb_players_NUD_ValueChanged;
      //
      // ct_spiritomb_visible_CB
      //
      ct_spiritomb_visible_CB.AutoSize = true;
      ct_spiritomb_visible_CB.Location = new Point(93, 67);
      ct_spiritomb_visible_CB.Margin = new Padding(4, 3, 4, 3);
      ct_spiritomb_visible_CB.Name = "ct_spiritomb_visible_CB";
      ct_spiritomb_visible_CB.Size = new Size(60, 19);
      ct_spiritomb_visible_CB.TabIndex = 9;
      ct_spiritomb_visible_CB.Text = "Visible";
      ct_spiritomb_visible_CB.UseVisualStyleBackColor = true;
      ct_spiritomb_visible_CB.CheckedChanged += ct_spiritomb_visible_CB_CheckedChanged;
      //
      // ct_spiritomb_PB
      //
      ct_spiritomb_PB.Caught = false;
      ct_spiritomb_PB.DrawDynaxMaxIcon = false;
      ct_spiritomb_PB.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
      ct_spiritomb_PB.Location = new Point(7, 22);
      ct_spiritomb_PB.Margin = new Padding(5, 3, 5, 3);
      ct_spiritomb_PB.MaximumSize = new Size(152, 83);
      ct_spiritomb_PB.MinimumSize = new Size(152, 83);
      ct_spiritomb_PB.Name = "ct_spiritomb_PB";
      ct_spiritomb_PB.Pokemon = 442;
      ct_spiritomb_PB.PokemonName = "Spiritomb";
      ct_spiritomb_PB.PokemonSubform = "";
      ct_spiritomb_PB.Size = new Size(152, 83);
      ct_spiritomb_PB.TabIndex = 8;
      ct_spiritomb_PB.ToolTip = "";
      ct_spiritomb_PB.LegaliltyCheck_OnClick += ct_spiritomb_PB_LegaliltyCheck_OnClick;
      ct_spiritomb_PB.Caught_OnClick += ct_spiritomb_PB_Caught_OnClick;
      //
      // galarianBirdsGroup
      //
      galarianBirdsGroup.Controls.Add(ct_gmoltres_PB);
      galarianBirdsGroup.Controls.Add(ct_birds_uncaughtBTN);
      galarianBirdsGroup.Controls.Add(ct_birds_caughtBTN);
      galarianBirdsGroup.Controls.Add(ct_gzapdos_PB);
      galarianBirdsGroup.Controls.Add(ct_garticuno_PB);
      galarianBirdsGroup.Location = new Point(9, 7);
      galarianBirdsGroup.Margin = new Padding(4, 3, 4, 3);
      galarianBirdsGroup.Name = "galarianBirdsGroup";
      galarianBirdsGroup.Padding = new Padding(4, 3, 4, 3);
      galarianBirdsGroup.Size = new Size(288, 295);
      galarianBirdsGroup.TabIndex = 4;
      galarianBirdsGroup.TabStop = false;
      galarianBirdsGroup.Text = "Galarian Birds";
      //
      // ct_gmoltres_PB
      //
      ct_gmoltres_PB.Caught = false;
      ct_gmoltres_PB.DrawDynaxMaxIcon = false;
      ct_gmoltres_PB.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
      ct_gmoltres_PB.Location = new Point(7, 202);
      ct_gmoltres_PB.Margin = new Padding(5, 3, 5, 3);
      ct_gmoltres_PB.MaximumSize = new Size(152, 83);
      ct_gmoltres_PB.MinimumSize = new Size(152, 83);
      ct_gmoltres_PB.Name = "ct_gmoltres_PB";
      ct_gmoltres_PB.Pokemon = 146;
      ct_gmoltres_PB.PokemonName = "Galarian Moltres";
      ct_gmoltres_PB.PokemonSubform = "1";
      ct_gmoltres_PB.Size = new Size(152, 83);
      ct_gmoltres_PB.TabIndex = 7;
      ct_gmoltres_PB.ToolTip = "";
      //
      // ct_birds_uncaughtBTN
      //
      ct_birds_uncaughtBTN.Location = new Point(166, 66);
      ct_birds_uncaughtBTN.Margin = new Padding(4, 3, 4, 3);
      ct_birds_uncaughtBTN.Name = "ct_birds_uncaughtBTN";
      ct_birds_uncaughtBTN.Size = new Size(115, 37);
      ct_birds_uncaughtBTN.TabIndex = 6;
      ct_birds_uncaughtBTN.Text = "Un-Caught All";
      ct_birds_uncaughtBTN.UseVisualStyleBackColor = true;
      ct_birds_uncaughtBTN.Click += ct_birds_uncaughtBTN_Click;
      //
      // ct_birds_caughtBTN
      //
      ct_birds_caughtBTN.Location = new Point(166, 22);
      ct_birds_caughtBTN.Margin = new Padding(4, 3, 4, 3);
      ct_birds_caughtBTN.Name = "ct_birds_caughtBTN";
      ct_birds_caughtBTN.Size = new Size(115, 37);
      ct_birds_caughtBTN.TabIndex = 5;
      ct_birds_caughtBTN.Text = "Caught All";
      ct_birds_caughtBTN.UseVisualStyleBackColor = true;
      ct_birds_caughtBTN.Click += ct_birds_caughtBTN_Click;
      //
      // ct_gzapdos_PB
      //
      ct_gzapdos_PB.Caught = false;
      ct_gzapdos_PB.DrawDynaxMaxIcon = false;
      ct_gzapdos_PB.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
      ct_gzapdos_PB.Location = new Point(7, 112);
      ct_gzapdos_PB.Margin = new Padding(5, 3, 5, 3);
      ct_gzapdos_PB.MaximumSize = new Size(152, 83);
      ct_gzapdos_PB.MinimumSize = new Size(152, 83);
      ct_gzapdos_PB.Name = "ct_gzapdos_PB";
      ct_gzapdos_PB.Pokemon = 145;
      ct_gzapdos_PB.PokemonName = "Galarian Zapdos";
      ct_gzapdos_PB.PokemonSubform = "1";
      ct_gzapdos_PB.Size = new Size(152, 83);
      ct_gzapdos_PB.TabIndex = 6;
      ct_gzapdos_PB.ToolTip = "";
      //
      // ct_garticuno_PB
      //
      ct_garticuno_PB.Caught = false;
      ct_garticuno_PB.DrawDynaxMaxIcon = false;
      ct_garticuno_PB.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
      ct_garticuno_PB.Location = new Point(7, 22);
      ct_garticuno_PB.Margin = new Padding(5, 3, 5, 3);
      ct_garticuno_PB.MaximumSize = new Size(152, 83);
      ct_garticuno_PB.MinimumSize = new Size(152, 83);
      ct_garticuno_PB.Name = "ct_garticuno_PB";
      ct_garticuno_PB.Pokemon = 144;
      ct_garticuno_PB.PokemonName = "Galarian Articuno";
      ct_garticuno_PB.PokemonSubform = "1";
      ct_garticuno_PB.Size = new Size(152, 83);
      ct_garticuno_PB.TabIndex = 5;
      ct_garticuno_PB.ToolTip = "";
      //
      // ct_giftcosmog_PB
      //
      ct_giftcosmog_PB.Caught = false;
      ct_giftcosmog_PB.DrawDynaxMaxIcon = false;
      ct_giftcosmog_PB.Legalility = SwShEventEditor.Controls.PokemonRenderUC.LegalStatus.Legal;
      ct_giftcosmog_PB.Location = new Point(545, 7);
      ct_giftcosmog_PB.Margin = new Padding(5, 3, 5, 3);
      ct_giftcosmog_PB.MaximumSize = new Size(152, 83);
      ct_giftcosmog_PB.MinimumSize = new Size(152, 83);
      ct_giftcosmog_PB.Name = "ct_giftcosmog_PB";
      ct_giftcosmog_PB.Pokemon = 789;
      ct_giftcosmog_PB.PokemonName = "Cosmog (Fwoofy) Gift";
      ct_giftcosmog_PB.PokemonSubform = "";
      ct_giftcosmog_PB.Size = new Size(152, 83);
      ct_giftcosmog_PB.TabIndex = 6;
      ct_giftcosmog_PB.ToolTip = "";
      //
      // toolStrip1
      //
      toolStrip1.Items.AddRange(new ToolStripItem[] { ts_applyBTN });
      toolStrip1.Location = new Point(0, 0);
      toolStrip1.Name = "toolStrip1";
      toolStrip1.Size = new Size(933, 25);
      toolStrip1.TabIndex = 1;
      toolStrip1.Text = "toolStrip1";
      //
      // ts_applyBTN
      //
      ts_applyBTN.DisplayStyle = ToolStripItemDisplayStyle.Text;
      ts_applyBTN.ImageTransparentColor = Color.Magenta;
      ts_applyBTN.Name = "ts_applyBTN";
      ts_applyBTN.Size = new Size(93, 22);
      ts_applyBTN.Text = "Apply Selection";
      ts_applyBTN.Click += ts_applyBTN_Click;
      //
      // WorldEventsForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(933, 519);
      Controls.Add(tabControl);
      Controls.Add(toolStrip1);
      DoubleBuffered = true;
      FormBorderStyle = FormBorderStyle.FixedToolWindow;
      Margin = new Padding(4, 3, 4, 3);
      Name = "WorldEventsForm";
      Text = "World Events";
      Load += WorldEvents_Load;
      tabControl.ResumeLayout(false);
      mainPage.ResumeLayout(false);
      championGiftsGroup.ResumeLayout(false);
      letsGoGroup.ResumeLayout(false);
      letsGoGroup.PerformLayout();
      ioaPage.ResumeLayout(false);
      dojoGroup.ResumeLayout(false);
      dojoGroup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)ioaWattDonationTotal).EndInit();
      ctPage.ResumeLayout(false);
      spiritombGroup.ResumeLayout(false);
      spiritombGroup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)ct_spiritomb_players_NUD).EndInit();
      galarianBirdsGroup.ResumeLayout(false);
      toolStrip1.ResumeLayout(false);
      toolStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TabControl tabControl;
    private TabPage mainPage;
    private TabPage ioaPage;
    private TabPage ctPage;
    private GroupBox galarianBirdsGroup;
    private Controls.PokemonBaseUC ct_garticuno_PB;
    private Controls.PokemonBaseUC ct_gmoltres_PB;
    private Controls.PokemonBaseUC ct_gzapdos_PB;
    private Button ct_birds_uncaughtBTN;
    private Button ct_birds_caughtBTN;
    private Controls.PokemonBaseUC ct_giftcosmog_PB;
    private ToolStrip toolStrip1;
    private ToolStripButton ts_applyBTN;
    private Controls.PokemonBaseUC ct_spiritomb_PB;
    private GroupBox spiritombGroup;
    private CheckBox ct_spiritomb_visible_CB;
    private Label playersInteractedLabel;
    private NumericUpDown ct_spiritomb_players_NUD;
    private CheckBox ct_spiritomb_forcelegal_CB;
    private Controls.PokemonBaseUC main_gpikachu_PB;
    private Controls.PokemonBaseUC main_geevee_PB;
    private GroupBox dojoGroup;
    private Label ioaWattDonationTotalLabel;
    private NumericUpDown ioaWattDonationTotal;
    private GroupBox letsGoGroup;
    private CheckBox main_eevee_save_data_CB;
    private CheckBox main_letsgo_forcelegal_CB;
    private CheckBox main_pikachu_save_data_CB;
    private Controls.PokemonBaseUC main_gift_typenull_PB;
    private Controls.PokemonBaseUC main_gift_gcharmander_PB;
    private Controls.PokemonBaseUC ct_gift_poipole_PB;
    private Controls.PokemonBaseUC main_gift_toxel_PB;
    private GroupBox championGiftsGroup;
    private Controls.PokemonBaseUC pokemonBaseUC7;
    private Controls.PokemonBaseUC pokemonBaseUC8;
    private ComboBox ioaWattDonationProgress;
    private Label ioaWattDonationProgressLabel;
    private CheckBox tableDisappeared;
    private CheckBox fixedRotomiDisappeared;
    private CheckBox brokenRotomiDisappared;
    private CheckBox hairStylistAvailable;
    private CheckBox battledHoneyToday;
    private CheckBox canBattleHoney;
    private CheckBox vitaminsVendingMachineDisappeared;
    private CheckBox drinksVendingMachineDisappeared;
  }
}
