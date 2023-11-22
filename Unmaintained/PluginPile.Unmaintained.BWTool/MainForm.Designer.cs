namespace PluginPile.Unmaintained.BWTool {
	partial class MainForm {
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button save_but;
		private System.Windows.Forms.Button dumper_but;
		private System.Windows.Forms.Button grotto_but;
		private System.Windows.Forms.Button trainer_records_but;
		private System.Windows.Forms.Button medal_but;
		private System.Windows.Forms.Button forest_but;
		private System.Windows.Forms.Button key_but;
		private System.Windows.Forms.Button join_but;
		private System.Windows.Forms.Button trainer_but;
		private System.Windows.Forms.Button memory_but;
		private System.Windows.Forms.Button dlc_but;
		private System.Windows.Forms.Button dr_but;

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
      save_but = new Button();
      dumper_but = new Button();
      grotto_but = new Button();
      trainer_records_but = new Button();
      medal_but = new Button();
      forest_but = new Button();
      key_but = new Button();
      join_but = new Button();
      trainer_but = new Button();
      memory_but = new Button();
      dlc_but = new Button();
      dr_but = new Button();
      prop_but = new Button();
      exit = new Button();
      SuspendLayout();
      // 
      // save_but
      // 
      save_but.Location = new Point(184, 214);
      save_but.Margin = new Padding(4, 3, 4, 3);
      save_but.Name = "save_but";
      save_but.Size = new Size(163, 27);
      save_but.TabIndex = 2;
      save_but.Text = "Save";
      save_but.UseVisualStyleBackColor = true;
      save_but.Click += Save_butClick;
      // 
      // dumper_but
      // 
      dumper_but.Location = new Point(184, 146);
      dumper_but.Margin = new Padding(4, 3, 4, 3);
      dumper_but.Name = "dumper_but";
      dumper_but.Size = new Size(163, 27);
      dumper_but.TabIndex = 4;
      dumper_but.Text = "Block dumper";
      dumper_but.UseVisualStyleBackColor = true;
      dumper_but.Click += Dumper_butClick;
      // 
      // grotto_but
      // 
      grotto_but.Location = new Point(14, 13);
      grotto_but.Margin = new Padding(4, 3, 4, 3);
      grotto_but.Name = "grotto_but";
      grotto_but.Size = new Size(163, 27);
      grotto_but.TabIndex = 7;
      grotto_but.Text = "Hidden Grotto and Swarm";
      grotto_but.UseVisualStyleBackColor = true;
      grotto_but.Click += Grotto_butClick;
      // 
      // trainer_records_but
      // 
      trainer_records_but.Location = new Point(14, 181);
      trainer_records_but.Margin = new Padding(4, 3, 4, 3);
      trainer_records_but.Name = "trainer_records_but";
      trainer_records_but.Size = new Size(163, 27);
      trainer_records_but.TabIndex = 8;
      trainer_records_but.Text = "Trainer Records";
      trainer_records_but.UseVisualStyleBackColor = true;
      trainer_records_but.Visible = false;
      trainer_records_but.Click += TrainerRecords_butClick;
      // 
      // medal_but
      // 
      medal_but.Location = new Point(14, 113);
      medal_but.Margin = new Padding(4, 3, 4, 3);
      medal_but.Name = "medal_but";
      medal_but.Size = new Size(163, 27);
      medal_but.TabIndex = 9;
      medal_but.Text = "Medals";
      medal_but.UseVisualStyleBackColor = true;
      medal_but.Click += Medal_butClick;
      // 
      // forest_but
      // 
      forest_but.Location = new Point(184, 13);
      forest_but.Margin = new Padding(4, 3, 4, 3);
      forest_but.Name = "forest_but";
      forest_but.Size = new Size(163, 27);
      forest_but.TabIndex = 10;
      forest_but.Text = "Entralink Forest";
      forest_but.UseVisualStyleBackColor = true;
      forest_but.Click += Forest_butClick;
      // 
      // key_but
      // 
      key_but.Location = new Point(184, 80);
      key_but.Margin = new Padding(4, 3, 4, 3);
      key_but.Name = "key_but";
      key_but.Size = new Size(163, 27);
      key_but.TabIndex = 11;
      key_but.Text = "Key System";
      key_but.UseVisualStyleBackColor = true;
      key_but.Click += Key_butClick;
      // 
      // join_but
      // 
      join_but.Location = new Point(14, 80);
      join_but.Margin = new Padding(4, 3, 4, 3);
      join_but.Name = "join_but";
      join_but.Size = new Size(163, 27);
      join_but.TabIndex = 12;
      join_but.Text = "Join Avenue";
      join_but.UseVisualStyleBackColor = true;
      join_but.Click += Join_butClick;
      // 
      // trainer_but
      // 
      trainer_but.Location = new Point(184, 46);
      trainer_but.Margin = new Padding(4, 3, 4, 3);
      trainer_but.Name = "trainer_but";
      trainer_but.Size = new Size(163, 27);
      trainer_but.TabIndex = 13;
      trainer_but.Text = "Trainer Info";
      trainer_but.UseVisualStyleBackColor = true;
      trainer_but.Click += Trainer_butClick;
      // 
      // memory_but
      // 
      memory_but.Location = new Point(184, 113);
      memory_but.Margin = new Padding(4, 3, 4, 3);
      memory_but.Name = "memory_but";
      memory_but.Size = new Size(163, 27);
      memory_but.TabIndex = 15;
      memory_but.Text = "Memory Link";
      memory_but.UseVisualStyleBackColor = true;
      memory_but.Click += Memory_butClick;
      // 
      // dlc_but
      // 
      dlc_but.Location = new Point(184, 181);
      dlc_but.Margin = new Padding(4, 3, 4, 3);
      dlc_but.Name = "dlc_but";
      dlc_but.Size = new Size(163, 27);
      dlc_but.TabIndex = 16;
      dlc_but.Text = "DLC";
      dlc_but.UseVisualStyleBackColor = true;
      dlc_but.Visible = false;
      dlc_but.Click += Dlc_butClick;
      // 
      // dr_but
      // 
      dr_but.Location = new Point(14, 147);
      dr_but.Margin = new Padding(4, 3, 4, 3);
      dr_but.Name = "dr_but";
      dr_but.Size = new Size(163, 27);
      dr_but.TabIndex = 17;
      dr_but.Text = "3DS Link (Dream Radar)";
      dr_but.UseVisualStyleBackColor = true;
      dr_but.Click += Dr_butClick;
      // 
      // prop_but
      // 
      prop_but.Location = new Point(14, 46);
      prop_but.Margin = new Padding(4, 3, 4, 3);
      prop_but.Name = "prop_but";
      prop_but.Size = new Size(163, 27);
      prop_but.TabIndex = 18;
      prop_but.Text = "Prop Case";
      prop_but.UseVisualStyleBackColor = true;
      prop_but.Click += Prop_butClick;
      // 
      // exit
      // 
      exit.Location = new Point(14, 214);
      exit.Name = "exit";
      exit.Size = new Size(163, 27);
      exit.TabIndex = 19;
      exit.Text = "Exit";
      exit.UseVisualStyleBackColor = true;
      exit.Click += exit_Click;
      // 
      // MainForm
      // 
      AllowDrop = true;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(375, 254);
      Controls.Add(exit);
      Controls.Add(prop_but);
      Controls.Add(dr_but);
      Controls.Add(dlc_but);
      Controls.Add(memory_but);
      Controls.Add(trainer_but);
      Controls.Add(join_but);
      Controls.Add(key_but);
      Controls.Add(forest_but);
      Controls.Add(medal_but);
      Controls.Add(trainer_records_but);
      Controls.Add(grotto_but);
      Controls.Add(dumper_but);
      Controls.Add(save_but);
      Margin = new Padding(4, 3, 4, 3);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "MainForm";
      Text = "BW Tool";
      ResumeLayout(false);
    }

    private System.Windows.Forms.Button prop_but;
    private Button exit;
  }
}
