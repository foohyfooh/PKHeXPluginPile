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
      tabPage1 = new TabPage();
      groupBox5 = new GroupBox();
      main_gift_gcharmander_PB = new Controls.PokemonBaseUC();
      main_gift_typenull_PB = new Controls.PokemonBaseUC();
      main_gift_toxel_PB = new Controls.PokemonBaseUC();
      groupBox4 = new GroupBox();
      main_eevee_save_data_CB = new CheckBox();
      main_letsgo_forcelegal_CB = new CheckBox();
      main_geevee_PB = new Controls.PokemonBaseUC();
      main_pikachu_save_data_CB = new CheckBox();
      main_gpikachu_PB = new Controls.PokemonBaseUC();
      tabPage2 = new TabPage();
      label3 = new Label();
      groupBox2 = new GroupBox();
      pokemonBaseUC7 = new Controls.PokemonBaseUC();
      label2 = new Label();
      numericUpDown1 = new NumericUpDown();
      pokemonBaseUC8 = new Controls.PokemonBaseUC();
      tabPage3 = new TabPage();
      ct_gift_poipole_PB = new Controls.PokemonBaseUC();
      groupBox3 = new GroupBox();
      ct_spiritomb_forcelegal_CB = new CheckBox();
      label1 = new Label();
      ct_spiritomb_players_NUD = new NumericUpDown();
      ct_spiritomb_visible_CB = new CheckBox();
      ct_spiritomb_PB = new Controls.PokemonBaseUC();
      groupBox1 = new GroupBox();
      ct_gmoltres_PB = new Controls.PokemonBaseUC();
      ct_birds_uncaughtBTN = new Button();
      ct_birds_caughtBTN = new Button();
      ct_gzapdos_PB = new Controls.PokemonBaseUC();
      ct_garticuno_PB = new Controls.PokemonBaseUC();
      ct_giftcosmog_PB = new Controls.PokemonBaseUC();
      toolStrip1 = new ToolStrip();
      ts_applyBTN = new ToolStripButton();
      tabControl.SuspendLayout();
      tabPage1.SuspendLayout();
      groupBox5.SuspendLayout();
      groupBox4.SuspendLayout();
      tabPage2.SuspendLayout();
      groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
      tabPage3.SuspendLayout();
      groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ct_spiritomb_players_NUD).BeginInit();
      groupBox1.SuspendLayout();
      toolStrip1.SuspendLayout();
      SuspendLayout();
      //
      // tabControl
      //
      tabControl.Controls.Add(tabPage1);
      tabControl.Controls.Add(tabPage2);
      tabControl.Controls.Add(tabPage3);
      tabControl.Dock = DockStyle.Fill;
      tabControl.Location = new Point(0, 25);
      tabControl.Margin = new Padding(4, 3, 4, 3);
      tabControl.Name = "tabControl";
      tabControl.SelectedIndex = 0;
      tabControl.Size = new Size(933, 494);
      tabControl.TabIndex = 0;
      //
      // tabPage1
      //
      tabPage1.BackColor = SystemColors.Control;
      tabPage1.Controls.Add(groupBox5);
      tabPage1.Controls.Add(main_gift_toxel_PB);
      tabPage1.Controls.Add(groupBox4);
      tabPage1.Location = new Point(4, 24);
      tabPage1.Margin = new Padding(4, 3, 4, 3);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(4, 3, 4, 3);
      tabPage1.Size = new Size(925, 466);
      tabPage1.TabIndex = 0;
      tabPage1.Text = "Main Game";
      //
      // groupBox5
      //
      groupBox5.Controls.Add(main_gift_gcharmander_PB);
      groupBox5.Controls.Add(main_gift_typenull_PB);
      groupBox5.Location = new Point(298, 7);
      groupBox5.Margin = new Padding(4, 3, 4, 3);
      groupBox5.Name = "groupBox5";
      groupBox5.Padding = new Padding(4, 3, 4, 3);
      groupBox5.Size = new Size(186, 231);
      groupBox5.TabIndex = 25;
      groupBox5.TabStop = false;
      groupBox5.Text = "Champion Gifts";
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
      // groupBox4
      //
      groupBox4.Controls.Add(main_eevee_save_data_CB);
      groupBox4.Controls.Add(main_letsgo_forcelegal_CB);
      groupBox4.Controls.Add(main_geevee_PB);
      groupBox4.Controls.Add(main_pikachu_save_data_CB);
      groupBox4.Controls.Add(main_gpikachu_PB);
      groupBox4.Location = new Point(9, 7);
      groupBox4.Margin = new Padding(4, 3, 4, 3);
      groupBox4.Name = "groupBox4";
      groupBox4.Padding = new Padding(4, 3, 4, 3);
      groupBox4.Size = new Size(280, 231);
      groupBox4.TabIndex = 19;
      groupBox4.TabStop = false;
      groupBox4.Text = "Let's Go Gifts";
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
      // tabPage2
      //
      tabPage2.BackColor = SystemColors.Control;
      tabPage2.Controls.Add(label3);
      tabPage2.Controls.Add(groupBox2);
      tabPage2.Location = new Point(4, 24);
      tabPage2.Margin = new Padding(4, 3, 4, 3);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(4, 3, 4, 3);
      tabPage2.Size = new Size(925, 462);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "Isle of Armor";
      //
      // label3
      //
      label3.AutoSize = true;
      label3.Location = new Point(331, 7);
      label3.Margin = new Padding(4, 0, 4, 0);
      label3.Name = "label3";
      label3.Size = new Size(143, 15);
      label3.TabIndex = 14;
      label3.Text = "Page not done yet! TODO!";
      //
      // groupBox2
      //
      groupBox2.Controls.Add(pokemonBaseUC7);
      groupBox2.Controls.Add(label2);
      groupBox2.Controls.Add(numericUpDown1);
      groupBox2.Controls.Add(pokemonBaseUC8);
      groupBox2.Location = new Point(9, 7);
      groupBox2.Margin = new Padding(4, 3, 4, 3);
      groupBox2.Name = "groupBox2";
      groupBox2.Padding = new Padding(4, 3, 4, 3);
      groupBox2.Size = new Size(315, 238);
      groupBox2.TabIndex = 13;
      groupBox2.TabStop = false;
      groupBox2.Text = "Dojo";
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
      // label2
      //
      label2.AutoSize = true;
      label2.Location = new Point(166, 22);
      label2.Margin = new Padding(4, 0, 4, 0);
      label2.Name = "label2";
      label2.Size = new Size(84, 15);
      label2.TabIndex = 11;
      label2.Text = "Watt Donation";
      //
      // numericUpDown1
      //
      numericUpDown1.Location = new Point(169, 40);
      numericUpDown1.Margin = new Padding(4, 3, 4, 3);
      numericUpDown1.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
      numericUpDown1.Name = "numericUpDown1";
      numericUpDown1.Size = new Size(130, 23);
      numericUpDown1.TabIndex = 12;
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
      // tabPage3
      //
      tabPage3.BackColor = SystemColors.Control;
      tabPage3.Controls.Add(ct_gift_poipole_PB);
      tabPage3.Controls.Add(groupBox3);
      tabPage3.Controls.Add(groupBox1);
      tabPage3.Controls.Add(ct_giftcosmog_PB);
      tabPage3.Location = new Point(4, 24);
      tabPage3.Margin = new Padding(4, 3, 4, 3);
      tabPage3.Name = "tabPage3";
      tabPage3.Padding = new Padding(4, 3, 4, 3);
      tabPage3.Size = new Size(925, 462);
      tabPage3.TabIndex = 2;
      tabPage3.Text = "Crown Tundra";
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
      // groupBox3
      //
      groupBox3.Controls.Add(ct_spiritomb_forcelegal_CB);
      groupBox3.Controls.Add(label1);
      groupBox3.Controls.Add(ct_spiritomb_players_NUD);
      groupBox3.Controls.Add(ct_spiritomb_visible_CB);
      groupBox3.Controls.Add(ct_spiritomb_PB);
      groupBox3.Location = new Point(304, 7);
      groupBox3.Margin = new Padding(4, 3, 4, 3);
      groupBox3.Name = "groupBox3";
      groupBox3.Padding = new Padding(4, 3, 4, 3);
      groupBox3.Size = new Size(233, 190);
      groupBox3.TabIndex = 9;
      groupBox3.TabStop = false;
      groupBox3.Text = "Spiritomb Values";
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
      // label1
      //
      label1.AutoSize = true;
      label1.Location = new Point(7, 112);
      label1.Margin = new Padding(4, 0, 4, 0);
      label1.Name = "label1";
      label1.Size = new Size(126, 15);
      label1.TabIndex = 10;
      label1.Text = "Players Interacted with";
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
      // groupBox1
      //
      groupBox1.Controls.Add(ct_gmoltres_PB);
      groupBox1.Controls.Add(ct_birds_uncaughtBTN);
      groupBox1.Controls.Add(ct_birds_caughtBTN);
      groupBox1.Controls.Add(ct_gzapdos_PB);
      groupBox1.Controls.Add(ct_garticuno_PB);
      groupBox1.Location = new Point(9, 7);
      groupBox1.Margin = new Padding(4, 3, 4, 3);
      groupBox1.Name = "groupBox1";
      groupBox1.Padding = new Padding(4, 3, 4, 3);
      groupBox1.Size = new Size(288, 295);
      groupBox1.TabIndex = 4;
      groupBox1.TabStop = false;
      groupBox1.Text = "Galarian Birds";
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
      tabPage1.ResumeLayout(false);
      groupBox5.ResumeLayout(false);
      groupBox4.ResumeLayout(false);
      groupBox4.PerformLayout();
      tabPage2.ResumeLayout(false);
      tabPage2.PerformLayout();
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
      tabPage3.ResumeLayout(false);
      groupBox3.ResumeLayout(false);
      groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)ct_spiritomb_players_NUD).EndInit();
      groupBox1.ResumeLayout(false);
      toolStrip1.ResumeLayout(false);
      toolStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TabControl tabControl;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private GroupBox groupBox1;
    private Controls.PokemonBaseUC ct_garticuno_PB;
    private Controls.PokemonBaseUC ct_gmoltres_PB;
    private Controls.PokemonBaseUC ct_gzapdos_PB;
    private Button ct_birds_uncaughtBTN;
    private Button ct_birds_caughtBTN;
    private Controls.PokemonBaseUC ct_giftcosmog_PB;
    private ToolStrip toolStrip1;
    private ToolStripButton ts_applyBTN;
    private Controls.PokemonBaseUC ct_spiritomb_PB;
    private GroupBox groupBox3;
    private CheckBox ct_spiritomb_visible_CB;
    private Label label1;
    private NumericUpDown ct_spiritomb_players_NUD;
    private CheckBox ct_spiritomb_forcelegal_CB;
    private Controls.PokemonBaseUC main_gpikachu_PB;
    private Controls.PokemonBaseUC main_geevee_PB;
    private GroupBox groupBox2;
    private Label label2;
    private NumericUpDown numericUpDown1;
    private GroupBox groupBox4;
    private CheckBox main_eevee_save_data_CB;
    private CheckBox main_letsgo_forcelegal_CB;
    private CheckBox main_pikachu_save_data_CB;
    private Controls.PokemonBaseUC main_gift_typenull_PB;
    private Controls.PokemonBaseUC main_gift_gcharmander_PB;
    private Controls.PokemonBaseUC ct_gift_poipole_PB;
    private Controls.PokemonBaseUC main_gift_toxel_PB;
    private GroupBox groupBox5;
    private Controls.PokemonBaseUC pokemonBaseUC7;
    private Controls.PokemonBaseUC pokemonBaseUC8;
    private Label label3;
  }
}
