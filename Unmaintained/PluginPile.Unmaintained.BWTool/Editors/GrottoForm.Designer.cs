namespace PluginPile.Unmaintained.BWTool {
  partial class GrottoForm {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ComboBox Grotto_route;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox normalgrottobox;
    private System.Windows.Forms.ComboBox fungrottobox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox normalgrottogroupbox;
    private System.Windows.Forms.ComboBox fungrottogroupbox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckBox normalgrottoavailable;
    private System.Windows.Forms.CheckBox fungrottoavailable;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button save_button;
    private System.Windows.Forms.ComboBox swarmbox;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox lastgrottobox;
    private System.Windows.Forms.Button lastvisitedhelp;
    private System.Windows.Forms.Button fungrottohelp;
    private System.Windows.Forms.NumericUpDown unknowngrottobox;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox gender5;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox gender10;
    private System.Windows.Forms.TextBox gender30;
    private System.Windows.Forms.TextBox gender60;
    private System.Windows.Forms.Button forceMale_but;
    private System.Windows.Forms.Button forceFemale_but;
    private System.Windows.Forms.Button note_but;
    private System.Windows.Forms.Button grotto_help;
    private System.Windows.Forms.Button table_but;
    private System.Windows.Forms.Button exit_but;

    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent() {
      Grotto_route = new ComboBox();
      label2 = new Label();
      label3 = new Label();
      normalgrottobox = new ComboBox();
      fungrottobox = new ComboBox();
      label4 = new Label();
      normalgrottogroupbox = new ComboBox();
      fungrottogroupbox = new ComboBox();
      label5 = new Label();
      normalgrottoavailable = new CheckBox();
      fungrottoavailable = new CheckBox();
      groupBox1 = new GroupBox();
      groupBox2 = new GroupBox();
      fungrottohelp = new Button();
      note_but = new Button();
      save_button = new Button();
      swarmbox = new ComboBox();
      groupBox3 = new GroupBox();
      grotto_help = new Button();
      table_but = new Button();
      forceMale_but = new Button();
      groupBox5 = new GroupBox();
      label9 = new Label();
      label6 = new Label();
      label8 = new Label();
      gender5 = new TextBox();
      label7 = new Label();
      gender10 = new TextBox();
      gender60 = new TextBox();
      gender30 = new TextBox();
      forceFemale_but = new Button();
      lastvisitedhelp = new Button();
      label1 = new Label();
      lastgrottobox = new ComboBox();
      unknowngrottobox = new NumericUpDown();
      groupBox4 = new GroupBox();
      exit_but = new Button();
      groupBox1.SuspendLayout();
      groupBox2.SuspendLayout();
      groupBox3.SuspendLayout();
      groupBox5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)unknowngrottobox).BeginInit();
      groupBox4.SuspendLayout();
      SuspendLayout();
      //
      // Grotto_route
      //
      Grotto_route.FormattingEnabled = true;
      Grotto_route.Items.AddRange(new object[] { "Sangi Ranch (10-15)", "Route 5 (20-25)", "Lostlorn Forest (20-25)", "Route 6 [Field] (25-30)", "Route 6 [Cave] (25-30)", "Route 7 (30-35)", "Route 13 [StairLeft] (35-40)", "Route 13 [StairDown] (35-40)", "Route 9 (35-40)", "Giant Chasm (45-50)", "Route 22 (40-45)", "Route 23 (50-55)", "Abundant [Field] (35-40)", "Abundant [Pond] (35-40)", "Pinwheel [Interior] (55-60)", "Pinwheel [Exterior] (55-60)", "Route 3 [Daycare] (55-60)", "Route 3 [Pond] (55-60)", "Route 2 (55-60)", "Route 18 (55-60)" });
      Grotto_route.Location = new Point(27, 35);
      Grotto_route.Margin = new Padding(4, 3, 4, 3);
      Grotto_route.Name = "Grotto_route";
      Grotto_route.Size = new Size(229, 23);
      Grotto_route.TabIndex = 6;
      Grotto_route.SelectedIndexChanged += Grotto_routeSelectedIndexChanged;
      //
      // label2
      //
      label2.Location = new Point(79, 21);
      label2.Margin = new Padding(4, 0, 4, 0);
      label2.Name = "label2";
      label2.Size = new Size(117, 27);
      label2.TabIndex = 8;
      label2.Text = "Slot";
      //
      // label3
      //
      label3.Location = new Point(79, 20);
      label3.Margin = new Padding(4, 0, 4, 0);
      label3.Name = "label3";
      label3.Size = new Size(117, 27);
      label3.TabIndex = 9;
      label3.Text = "Slot";
      //
      // normalgrottobox
      //
      normalgrottobox.FormattingEnabled = true;
      normalgrottobox.Items.AddRange(new object[] { "Pokemon 1", "Pokemon 2", "Pokemon 3", "Item 1", "Item 2", "Item 3", "Item 4", "Dowsing 1", "Dowsing 2", "Dowsing 3", "Dowsing 4", "Unknown/Not used/Buggy 1", "Unknown/Not used/Buggy 2", "Unknown/Not used/Buggy 3", "Unknown/Not used/Buggy 4", "Unknown/Not used/Buggy 5" });
      normalgrottobox.Location = new Point(79, 39);
      normalgrottobox.Margin = new Padding(4, 3, 4, 3);
      normalgrottobox.Name = "normalgrottobox";
      normalgrottobox.Size = new Size(140, 23);
      normalgrottobox.TabIndex = 10;
      //
      // fungrottobox
      //
      fungrottobox.FormattingEnabled = true;
      fungrottobox.Items.AddRange(new object[] { "Pokemon 1", "Pokemon 2", "Pokemon 3 - GROUP A FEMALE 5% ^^^^", "Item 1", "Item 2 - GROUP A FEMALE 10% ^^^^", "Item 3", "Item 4", "Dowsing 1", "Dowsing 2", "Dowsing 3", "Dowsing 4", "Unknown/Not used/Buggy 1", "Unknown/Not used/Buggy 2", "Unknown - GROUP B FEMALE 60% ^^^^", "Unknown - GROUP A FEMALE 30% ^^^^", "Unknown/Not used/Buggy 5" });
      fungrottobox.Location = new Point(79, 38);
      fungrottobox.Margin = new Padding(4, 3, 4, 3);
      fungrottobox.Name = "fungrottobox";
      fungrottobox.Size = new Size(237, 23);
      fungrottobox.TabIndex = 11;
      fungrottobox.SelectedIndexChanged += FungrottoboxSelectedIndexChanged;
      //
      // label4
      //
      label4.Location = new Point(16, 21);
      label4.Margin = new Padding(4, 0, 4, 0);
      label4.Name = "label4";
      label4.Size = new Size(56, 27);
      label4.TabIndex = 12;
      label4.Text = "Group";
      //
      // normalgrottogroupbox
      //
      normalgrottogroupbox.FormattingEnabled = true;
      normalgrottogroupbox.Items.AddRange(new object[] { "A", "B", "C", "D" });
      normalgrottogroupbox.Location = new Point(16, 39);
      normalgrottogroupbox.Margin = new Padding(4, 3, 4, 3);
      normalgrottogroupbox.Name = "normalgrottogroupbox";
      normalgrottogroupbox.Size = new Size(55, 23);
      normalgrottogroupbox.TabIndex = 13;
      //
      // fungrottogroupbox
      //
      fungrottogroupbox.FormattingEnabled = true;
      fungrottogroupbox.Items.AddRange(new object[] { "A", "B", "C", "D" });
      fungrottogroupbox.Location = new Point(16, 38);
      fungrottogroupbox.Margin = new Padding(4, 3, 4, 3);
      fungrottogroupbox.Name = "fungrottogroupbox";
      fungrottogroupbox.Size = new Size(55, 23);
      fungrottogroupbox.TabIndex = 15;
      fungrottogroupbox.SelectedIndexChanged += FungrottogroupboxSelectedIndexChanged;
      //
      // label5
      //
      label5.Location = new Point(16, 20);
      label5.Margin = new Padding(4, 0, 4, 0);
      label5.Name = "label5";
      label5.Size = new Size(56, 27);
      label5.TabIndex = 14;
      label5.Text = "Group";
      //
      // normalgrottoavailable
      //
      normalgrottoavailable.Location = new Point(79, 70);
      normalgrottoavailable.Margin = new Padding(4, 3, 4, 3);
      normalgrottoavailable.Name = "normalgrottoavailable";
      normalgrottoavailable.Size = new Size(121, 28);
      normalgrottoavailable.TabIndex = 16;
      normalgrottoavailable.Text = "Available";
      normalgrottoavailable.UseVisualStyleBackColor = true;
      //
      // fungrottoavailable
      //
      fungrottoavailable.Location = new Point(79, 69);
      fungrottoavailable.Margin = new Padding(4, 3, 4, 3);
      fungrottoavailable.Name = "fungrottoavailable";
      fungrottoavailable.Size = new Size(121, 28);
      fungrottoavailable.TabIndex = 17;
      fungrottoavailable.Text = "Available";
      fungrottoavailable.UseVisualStyleBackColor = true;
      fungrottoavailable.CheckedChanged += FungrottoavailableCheckedChanged;
      //
      // groupBox1
      //
      groupBox1.Controls.Add(normalgrottoavailable);
      groupBox1.Controls.Add(normalgrottogroupbox);
      groupBox1.Controls.Add(label4);
      groupBox1.Controls.Add(normalgrottobox);
      groupBox1.Controls.Add(label2);
      groupBox1.Location = new Point(27, 76);
      groupBox1.Margin = new Padding(4, 3, 4, 3);
      groupBox1.Name = "groupBox1";
      groupBox1.Padding = new Padding(4, 3, 4, 3);
      groupBox1.Size = new Size(227, 113);
      groupBox1.TabIndex = 18;
      groupBox1.TabStop = false;
      groupBox1.Text = "Normal Grotto";
      //
      // groupBox2
      //
      groupBox2.Controls.Add(fungrottohelp);
      groupBox2.Controls.Add(fungrottoavailable);
      groupBox2.Controls.Add(fungrottogroupbox);
      groupBox2.Controls.Add(label5);
      groupBox2.Controls.Add(fungrottobox);
      groupBox2.Controls.Add(label3);
      groupBox2.Location = new Point(261, 77);
      groupBox2.Margin = new Padding(4, 3, 4, 3);
      groupBox2.Name = "groupBox2";
      groupBox2.Padding = new Padding(4, 3, 4, 3);
      groupBox2.Size = new Size(324, 112);
      groupBox2.TabIndex = 19;
      groupBox2.TabStop = false;
      groupBox2.Text = "Funfest Grotto ?";
      //
      // fungrottohelp
      //
      fungrottohelp.Location = new Point(299, 0);
      fungrottohelp.Margin = new Padding(4, 3, 4, 3);
      fungrottohelp.Name = "fungrottohelp";
      fungrottohelp.Size = new Size(26, 27);
      fungrottohelp.TabIndex = 23;
      fungrottohelp.Text = "?";
      fungrottohelp.UseVisualStyleBackColor = true;
      fungrottohelp.Click += FungrottohelpClick;
      //
      // note_but
      //
      note_but.Location = new Point(27, 196);
      note_but.Margin = new Padding(4, 3, 4, 3);
      note_but.Name = "note_but";
      note_but.Size = new Size(88, 27);
      note_but.TabIndex = 24;
      note_but.Text = "Note";
      note_but.UseVisualStyleBackColor = true;
      note_but.Click += Note_butClick;
      //
      // save_button
      //
      save_button.Location = new Point(626, 275);
      save_button.Margin = new Padding(4, 3, 4, 3);
      save_button.Name = "save_button";
      save_button.Size = new Size(189, 27);
      save_button.TabIndex = 20;
      save_button.Text = "Save and Exit";
      save_button.UseVisualStyleBackColor = true;
      save_button.Click += Save_buttonClick;
      //
      // swarmbox
      //
      swarmbox.FormattingEnabled = true;
      swarmbox.Items.AddRange(new object[] { "Route 1", "Dreamyard", "Route 6", "Route 3", "Route 9", "Resort Desert", "Route 5", "Route 7", "Route 12", "Route 8", "Route 11", "Route 13", "Abundant Shrine", "Route 15", "Route 16", "Route 18", "Rebirth Mountain", "Route 20", "Route 22" });
      swarmbox.Location = new Point(7, 35);
      swarmbox.Margin = new Padding(4, 3, 4, 3);
      swarmbox.Name = "swarmbox";
      swarmbox.Size = new Size(187, 23);
      swarmbox.TabIndex = 22;
      //
      // groupBox3
      //
      groupBox3.Controls.Add(grotto_help);
      groupBox3.Controls.Add(table_but);
      groupBox3.Controls.Add(note_but);
      groupBox3.Controls.Add(forceMale_but);
      groupBox3.Controls.Add(groupBox5);
      groupBox3.Controls.Add(forceFemale_but);
      groupBox3.Controls.Add(lastvisitedhelp);
      groupBox3.Controls.Add(label1);
      groupBox3.Controls.Add(lastgrottobox);
      groupBox3.Controls.Add(groupBox2);
      groupBox3.Controls.Add(groupBox1);
      groupBox3.Controls.Add(Grotto_route);
      groupBox3.Location = new Point(15, 8);
      groupBox3.Margin = new Padding(4, 3, 4, 3);
      groupBox3.Name = "groupBox3";
      groupBox3.Padding = new Padding(4, 3, 4, 3);
      groupBox3.Size = new Size(593, 293);
      groupBox3.TabIndex = 23;
      groupBox3.TabStop = false;
      groupBox3.Text = "Hidden Grotto";
      //
      // grotto_help
      //
      grotto_help.Location = new Point(358, 35);
      grotto_help.Margin = new Padding(4, 3, 4, 3);
      grotto_help.Name = "grotto_help";
      grotto_help.Size = new Size(21, 27);
      grotto_help.TabIndex = 25;
      grotto_help.Text = "?";
      grotto_help.UseVisualStyleBackColor = true;
      grotto_help.Click += Grotto_helpClick;
      //
      // table_but
      //
      table_but.Enabled = false;
      table_but.Location = new Point(264, 35);
      table_but.Margin = new Padding(4, 3, 4, 3);
      table_but.Name = "table_but";
      table_but.Size = new Size(88, 27);
      table_but.TabIndex = 25;
      table_but.Text = "Grotto Table";
      table_but.UseVisualStyleBackColor = true;
      table_but.Click += Black2table_butClick;
      //
      // forceMale_but
      //
      forceMale_but.Location = new Point(426, 50);
      forceMale_but.Margin = new Padding(4, 3, 4, 3);
      forceMale_but.Name = "forceMale_but";
      forceMale_but.Size = new Size(120, 27);
      forceMale_but.TabIndex = 26;
      forceMale_but.Text = "Force Male";
      forceMale_but.UseVisualStyleBackColor = true;
      forceMale_but.Click += ForceMale_butClick;
      //
      // groupBox5
      //
      groupBox5.Controls.Add(label9);
      groupBox5.Controls.Add(label6);
      groupBox5.Controls.Add(label8);
      groupBox5.Controls.Add(gender5);
      groupBox5.Controls.Add(label7);
      groupBox5.Controls.Add(gender10);
      groupBox5.Controls.Add(gender60);
      groupBox5.Controls.Add(gender30);
      groupBox5.Location = new Point(429, 196);
      groupBox5.Margin = new Padding(4, 3, 4, 3);
      groupBox5.Name = "groupBox5";
      groupBox5.Padding = new Padding(4, 3, 4, 3);
      groupBox5.Size = new Size(156, 88);
      groupBox5.TabIndex = 24;
      groupBox5.TabStop = false;
      groupBox5.Text = "Gender";
      //
      // label9
      //
      label9.Location = new Point(74, 53);
      label9.Margin = new Padding(4, 0, 4, 0);
      label9.Name = "label9";
      label9.Size = new Size(31, 27);
      label9.TabIndex = 31;
      label9.Text = "60%";
      //
      // label6
      //
      label6.Location = new Point(7, 25);
      label6.Margin = new Padding(4, 0, 4, 0);
      label6.Name = "label6";
      label6.Size = new Size(29, 27);
      label6.TabIndex = 28;
      label6.Text = "5%";
      //
      // label8
      //
      label8.Location = new Point(2, 53);
      label8.Margin = new Padding(4, 0, 4, 0);
      label8.Name = "label8";
      label8.Size = new Size(31, 27);
      label8.TabIndex = 30;
      label8.Text = "30%";
      //
      // gender5
      //
      gender5.Enabled = false;
      gender5.Location = new Point(41, 25);
      gender5.Margin = new Padding(4, 3, 4, 3);
      gender5.Name = "gender5";
      gender5.Size = new Size(25, 23);
      gender5.TabIndex = 24;
      //
      // label7
      //
      label7.Location = new Point(76, 22);
      label7.Margin = new Padding(4, 0, 4, 0);
      label7.Name = "label7";
      label7.Size = new Size(31, 27);
      label7.TabIndex = 29;
      label7.Text = "10%";
      //
      // gender10
      //
      gender10.Enabled = false;
      gender10.Location = new Point(112, 22);
      gender10.Margin = new Padding(4, 3, 4, 3);
      gender10.Name = "gender10";
      gender10.Size = new Size(25, 23);
      gender10.TabIndex = 25;
      //
      // gender60
      //
      gender60.Enabled = false;
      gender60.Location = new Point(112, 53);
      gender60.Margin = new Padding(4, 3, 4, 3);
      gender60.Name = "gender60";
      gender60.Size = new Size(25, 23);
      gender60.TabIndex = 27;
      //
      // gender30
      //
      gender30.Enabled = false;
      gender30.Location = new Point(41, 53);
      gender30.Margin = new Padding(4, 3, 4, 3);
      gender30.Name = "gender30";
      gender30.Size = new Size(25, 23);
      gender30.TabIndex = 26;
      //
      // forceFemale_but
      //
      forceFemale_but.Location = new Point(426, 16);
      forceFemale_but.Margin = new Padding(4, 3, 4, 3);
      forceFemale_but.Name = "forceFemale_but";
      forceFemale_but.Size = new Size(120, 27);
      forceFemale_but.TabIndex = 25;
      forceFemale_but.Text = "Force Female";
      forceFemale_but.UseVisualStyleBackColor = true;
      forceFemale_but.Click += ForceFemale_butClick;
      //
      // lastvisitedhelp
      //
      lastvisitedhelp.Location = new Point(377, 232);
      lastvisitedhelp.Margin = new Padding(4, 3, 4, 3);
      lastvisitedhelp.Name = "lastvisitedhelp";
      lastvisitedhelp.Size = new Size(26, 27);
      lastvisitedhelp.TabIndex = 22;
      lastvisitedhelp.Text = "?";
      lastvisitedhelp.UseVisualStyleBackColor = true;
      lastvisitedhelp.Click += LastvisitedhelpClick;
      //
      // label1
      //
      label1.Location = new Point(23, 235);
      label1.Margin = new Padding(4, 0, 4, 0);
      label1.Name = "label1";
      label1.Size = new Size(110, 27);
      label1.TabIndex = 21;
      label1.Text = "Last Visited Grotto";
      //
      // lastgrottobox
      //
      lastgrottobox.FormattingEnabled = true;
      lastgrottobox.Items.AddRange(new object[] { "Sangi Ranch (10-15)", "Route 5 (20-25)", "Lostlorn Forest (20-25)", "Route 6 [Field] (25-30)", "Route 6 [Cave] (25-30)", "Route 7 (30-35)", "Route 13 [StairLeft] (35-40)", "Route 13 [StairDown] (35-40)", "Route 9 (35-40)", "Giant Chasm (45-50)", "Route 22 (40-45)", "Route 23 (50-55)", "Abundant [Field] (35-40)", "Abundant [Pond] (35-40)", "Pinwheel [Interior] (55-60)", "Pinwheel [Exterior] (55-60)", "Route 3 [Daycare] (55-60)", "Route 3 [Pond] (55-60)", "Route 2 (55-60)", "Route 18 (55-60)" });
      lastgrottobox.Location = new Point(140, 232);
      lastgrottobox.Margin = new Padding(4, 3, 4, 3);
      lastgrottobox.Name = "lastgrottobox";
      lastgrottobox.Size = new Size(229, 23);
      lastgrottobox.TabIndex = 20;
      //
      // unknowngrottobox
      //
      unknowngrottobox.Location = new Point(628, 103);
      unknowngrottobox.Margin = new Padding(4, 3, 4, 3);
      unknowngrottobox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
      unknowngrottobox.Name = "unknowngrottobox";
      unknowngrottobox.Size = new Size(61, 23);
      unknowngrottobox.TabIndex = 23;
      unknowngrottobox.Visible = false;
      //
      // groupBox4
      //
      groupBox4.Controls.Add(swarmbox);
      groupBox4.Location = new Point(621, 8);
      groupBox4.Margin = new Padding(4, 3, 4, 3);
      groupBox4.Name = "groupBox4";
      groupBox4.Padding = new Padding(4, 3, 4, 3);
      groupBox4.Size = new Size(204, 75);
      groupBox4.TabIndex = 24;
      groupBox4.TabStop = false;
      groupBox4.Text = "Current Swarm";
      //
      // exit_but
      //
      exit_but.Location = new Point(626, 243);
      exit_but.Margin = new Padding(4, 3, 4, 3);
      exit_but.Name = "exit_but";
      exit_but.Size = new Size(189, 27);
      exit_but.TabIndex = 25;
      exit_but.Text = "Exit";
      exit_but.UseVisualStyleBackColor = true;
      exit_but.Click += Exit_butClick;
      //
      // GrottoForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(842, 312);
      Controls.Add(exit_but);
      Controls.Add(groupBox4);
      Controls.Add(groupBox3);
      Controls.Add(save_button);
      Controls.Add(unknowngrottobox);
      Margin = new Padding(4, 3, 4, 3);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "GrottoForm";
      Text = "B2W2 Grotto & Swarm";
      groupBox1.ResumeLayout(false);
      groupBox2.ResumeLayout(false);
      groupBox3.ResumeLayout(false);
      groupBox5.ResumeLayout(false);
      groupBox5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)unknowngrottobox).EndInit();
      groupBox4.ResumeLayout(false);
      ResumeLayout(false);
    }
  }
}
