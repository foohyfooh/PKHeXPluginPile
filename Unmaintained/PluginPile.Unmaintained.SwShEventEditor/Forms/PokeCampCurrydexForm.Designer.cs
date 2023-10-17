namespace PluginPile.Unmaintained.SwShEventEditor {
    partial class PokeCampCurrydexForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokeCampCurrydexForm));
            this.type_CLB = new System.Windows.Forms.CheckedListBox();
            this.mainingredient_CLB = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.camp_has_golden_CB = new System.Windows.Forms.CheckBox();
            this.camp_use_golden_CB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.camp_type_CMB = new System.Windows.Forms.ComboBox();
            this.camp_type_PB = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.camp_ball_champion_CB = new System.Windows.Forms.CheckBox();
            this.camp_ball_mirror_CB = new System.Windows.Forms.CheckBox();
            this.camp_ball_tympole_CB = new System.Windows.Forms.CheckBox();
            this.camp_ball_soothe_CB = new System.Windows.Forms.CheckBox();
            this.camp_ball_weighted_CB = new System.Windows.Forms.CheckBox();
            this.camp_ball_fresh_CB = new System.Windows.Forms.CheckBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ts_applyBTN = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camp_type_PB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            //
            // type_CLB
            //
            this.type_CLB.FormattingEnabled = true;
            this.type_CLB.Items.AddRange(new object[] {
            "Normal",
            "Spicy",
            "Dry",
            "Sweet",
            "Bitter",
            "Sour"});
            this.type_CLB.Location = new System.Drawing.Point(148, 6);
            this.type_CLB.Name = "type_CLB";
            this.type_CLB.Size = new System.Drawing.Size(61, 94);
            this.type_CLB.TabIndex = 0;
            //
            // mainingredient_CLB
            //
            this.mainingredient_CLB.FormattingEnabled = true;
            this.mainingredient_CLB.Items.AddRange(new object[] {
            "None",
            "Sausage",
            "Bob\'s Tin Food",
            "Bach\'s Tin Food",
            "Tin of Beans",
            "Bread",
            "Pasta",
            "Mixed Mushrooms",
            "Smoke-Poke Tail",
            "Large Leek",
            "Fancy Apple",
            "Brittle Bones",
            "Pack of Potatoes",
            "Pungent Root",
            "Salad Mix",
            "Fried Food",
            "Boiled Egg",
            "Fruit Bunch",
            "Moomoo Cheese",
            "Spice Mix",
            "Fresh Cream",
            "Packaged Curry",
            "Coconut Milk",
            "Instant Noodles",
            "Precooked Burger"});
            this.mainingredient_CLB.Location = new System.Drawing.Point(6, 6);
            this.mainingredient_CLB.Name = "mainingredient_CLB";
            this.mainingredient_CLB.Size = new System.Drawing.Size(136, 379);
            this.mainingredient_CLB.TabIndex = 1;
            //
            // toolStrip1
            //
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_applyBTN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(381, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            //
            // toolStripButton1
            //
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripButton1.Text = "Apply Selection";
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 425);
            this.tabControl1.TabIndex = 3;
            //
            // tabPage1
            //
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.type_CLB);
            this.tabPage1.Controls.Add(this.mainingredient_CLB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Curry Dex";
            //
            // tabPage2
            //
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pokecamp";
            //
            // groupBox3
            //
            this.groupBox3.Controls.Add(this.camp_has_golden_CB);
            this.groupBox3.Controls.Add(this.camp_use_golden_CB);
            this.groupBox3.Location = new System.Drawing.Point(8, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 60);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cooking";
            //
            // camp_has_golden_CB
            //
            this.camp_has_golden_CB.AutoSize = true;
            this.camp_has_golden_CB.Location = new System.Drawing.Point(6, 15);
            this.camp_has_golden_CB.Name = "camp_has_golden_CB";
            this.camp_has_golden_CB.Size = new System.Drawing.Size(144, 17);
            this.camp_has_golden_CB.TabIndex = 3;
            this.camp_has_golden_CB.Text = "Has Golden Kitchenware";
            this.camp_has_golden_CB.UseVisualStyleBackColor = true;
            //
            // camp_use_golden_CB
            //
            this.camp_use_golden_CB.AutoSize = true;
            this.camp_use_golden_CB.Location = new System.Drawing.Point(6, 38);
            this.camp_use_golden_CB.Name = "camp_use_golden_CB";
            this.camp_use_golden_CB.Size = new System.Drawing.Size(144, 17);
            this.camp_use_golden_CB.TabIndex = 4;
            this.camp_use_golden_CB.Text = "Use Golden Kitchenware";
            this.camp_use_golden_CB.UseVisualStyleBackColor = true;
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.camp_type_CMB);
            this.groupBox2.Controls.Add(this.camp_type_PB);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tent Colour";
            //
            // camp_type_CMB
            //
            this.camp_type_CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camp_type_CMB.FormattingEnabled = true;
            this.camp_type_CMB.Items.AddRange(new object[] {
            "Normal",
            "Fighting",
            "Flying",
            "Poison",
            "Ground",
            "Rock",
            "Bug",
            "Ghost",
            "Steel",
            "Fire",
            "Water",
            "Grass",
            "Electric",
            "Pyschic",
            "Ice",
            "Dragon",
            "Dark",
            "Fairy"});
            this.camp_type_CMB.Location = new System.Drawing.Point(6, 19);
            this.camp_type_CMB.Name = "camp_type_CMB";
            this.camp_type_CMB.Size = new System.Drawing.Size(82, 21);
            this.camp_type_CMB.TabIndex = 5;
            this.camp_type_CMB.SelectedIndexChanged += new System.EventHandler(this.camp_type_CMB_SelectedIndexChanged);
            //
            // camp_type_PB
            //
            this.camp_type_PB.Location = new System.Drawing.Point(94, 19);
            this.camp_type_PB.Name = "camp_type_PB";
            this.camp_type_PB.Size = new System.Drawing.Size(100, 22);
            this.camp_type_PB.TabIndex = 5;
            this.camp_type_PB.TabStop = false;
            this.camp_type_PB.Paint += new System.Windows.Forms.PaintEventHandler(this.camp_type_PB_Paint);
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.camp_ball_champion_CB);
            this.groupBox1.Controls.Add(this.camp_ball_mirror_CB);
            this.groupBox1.Controls.Add(this.camp_ball_tympole_CB);
            this.groupBox1.Controls.Add(this.camp_ball_soothe_CB);
            this.groupBox1.Controls.Add(this.camp_ball_weighted_CB);
            this.groupBox1.Controls.Add(this.camp_ball_fresh_CB);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balls/Toys";
            //
            // camp_ball_champion_CB
            //
            this.camp_ball_champion_CB.AutoSize = true;
            this.camp_ball_champion_CB.Location = new System.Drawing.Point(44, 209);
            this.camp_ball_champion_CB.Name = "camp_ball_champion_CB";
            this.camp_ball_champion_CB.Size = new System.Drawing.Size(93, 17);
            this.camp_ball_champion_CB.TabIndex = 8;
            this.camp_ball_champion_CB.Text = "Champion Ball";
            this.camp_ball_champion_CB.UseVisualStyleBackColor = true;
            //
            // camp_ball_mirror_CB
            //
            this.camp_ball_mirror_CB.AutoSize = true;
            this.camp_ball_mirror_CB.Location = new System.Drawing.Point(44, 133);
            this.camp_ball_mirror_CB.Name = "camp_ball_mirror_CB";
            this.camp_ball_mirror_CB.Size = new System.Drawing.Size(72, 17);
            this.camp_ball_mirror_CB.TabIndex = 7;
            this.camp_ball_mirror_CB.Text = "Mirror Ball";
            this.camp_ball_mirror_CB.UseVisualStyleBackColor = true;
            //
            // camp_ball_tympole_CB
            //
            this.camp_ball_tympole_CB.AutoSize = true;
            this.camp_ball_tympole_CB.Location = new System.Drawing.Point(44, 171);
            this.camp_ball_tympole_CB.Name = "camp_ball_tympole_CB";
            this.camp_ball_tympole_CB.Size = new System.Drawing.Size(86, 17);
            this.camp_ball_tympole_CB.TabIndex = 7;
            this.camp_ball_tympole_CB.Text = "Tympole Ball";
            this.camp_ball_tympole_CB.UseVisualStyleBackColor = true;
            //
            // camp_ball_soothe_CB
            //
            this.camp_ball_soothe_CB.AutoSize = true;
            this.camp_ball_soothe_CB.Location = new System.Drawing.Point(44, 95);
            this.camp_ball_soothe_CB.Name = "camp_ball_soothe_CB";
            this.camp_ball_soothe_CB.Size = new System.Drawing.Size(80, 17);
            this.camp_ball_soothe_CB.TabIndex = 6;
            this.camp_ball_soothe_CB.Text = "Soothe Ball";
            this.camp_ball_soothe_CB.UseVisualStyleBackColor = true;
            //
            // camp_ball_weighted_CB
            //
            this.camp_ball_weighted_CB.AutoSize = true;
            this.camp_ball_weighted_CB.Location = new System.Drawing.Point(44, 57);
            this.camp_ball_weighted_CB.Name = "camp_ball_weighted_CB";
            this.camp_ball_weighted_CB.Size = new System.Drawing.Size(92, 17);
            this.camp_ball_weighted_CB.TabIndex = 3;
            this.camp_ball_weighted_CB.Text = "Weighted Ball";
            this.camp_ball_weighted_CB.UseVisualStyleBackColor = true;
            //
            // camp_ball_fresh_CB
            //
            this.camp_ball_fresh_CB.AutoSize = true;
            this.camp_ball_fresh_CB.Location = new System.Drawing.Point(44, 19);
            this.camp_ball_fresh_CB.Name = "camp_ball_fresh_CB";
            this.camp_ball_fresh_CB.Size = new System.Drawing.Size(72, 17);
            this.camp_ball_fresh_CB.TabIndex = 2;
            this.camp_ball_fresh_CB.Text = "Fresh Ball";
            this.camp_ball_fresh_CB.UseVisualStyleBackColor = true;
            //
            // pictureBox6
            //
            this.pictureBox6.BackgroundImage = global::PluginPile.Unmaintained.SwShEventEditor.Properties.Resources.ball_champion;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(6, 209);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            //
            // pictureBox5
            //
            this.pictureBox5.BackgroundImage = global::PluginPile.Unmaintained.SwShEventEditor.Properties.Resources.ball_Tympole;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(6, 171);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            //
            // pictureBox4
            //
            this.pictureBox4.BackgroundImage = global::PluginPile.Unmaintained.SwShEventEditor.Properties.Resources.ball_mirror;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(6, 133);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            //
            // pictureBox3
            //
            this.pictureBox3.BackgroundImage = global::PluginPile.Unmaintained.SwShEventEditor.Properties.Resources.ball_soothe;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(6, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            //
            // pictureBox2
            //
            this.pictureBox2.BackgroundImage = global::PluginPile.Unmaintained.SwShEventEditor.Properties.Resources.ball_weighted;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(6, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            //
            // pictureBox1
            //
            this.pictureBox1.BackgroundImage = global::PluginPile.Unmaintained.SwShEventEditor.Properties.Resources.ball_fresh;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //
            // ts_applyBTN
            //
            this.ts_applyBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_applyBTN.Image = ((System.Drawing.Image)(resources.GetObject("ts_applyBTN.Image")));
            this.ts_applyBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_applyBTN.Name = "ts_applyBTN";
            this.ts_applyBTN.Size = new System.Drawing.Size(93, 22);
            this.ts_applyBTN.Text = "Apply Selection";
            this.ts_applyBTN.Click += new System.EventHandler(this.ts_applyBTN_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TODO: This page";
            //
            // PokeCampCurrydexForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PokeCampCurrydexForm";
            this.Text = "Pokemon Camp/Currydex Form";
            this.Load += new System.EventHandler(this.CurrdexForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.camp_type_PB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckedListBox type_CLB;
        private System.Windows.Forms.CheckedListBox mainingredient_CLB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox camp_ball_champion_CB;
        private System.Windows.Forms.CheckBox camp_ball_mirror_CB;
        private System.Windows.Forms.CheckBox camp_ball_tympole_CB;
        private System.Windows.Forms.CheckBox camp_ball_soothe_CB;
        private System.Windows.Forms.CheckBox camp_ball_weighted_CB;
        private System.Windows.Forms.CheckBox camp_ball_fresh_CB;
        private System.Windows.Forms.CheckBox camp_has_golden_CB;
        private System.Windows.Forms.CheckBox camp_use_golden_CB;
        private System.Windows.Forms.PictureBox camp_type_PB;
        private System.Windows.Forms.ComboBox camp_type_CMB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripButton ts_applyBTN;
        private System.Windows.Forms.Label label1;
    }
}
