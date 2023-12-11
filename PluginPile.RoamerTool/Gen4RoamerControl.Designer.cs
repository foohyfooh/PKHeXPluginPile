namespace PluginPile.RoamerTool {
  partial class Gen4RoamerControl {
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      PIDLabel = new Label();
      PID = new TextBox();
      Level = new NumericUpDown();
      LevelLabel = new Label();
      CurrentHPLabel = new Label();
      CurrentHP = new NumericUpDown();
      HPLabel = new Label();
      HP = new NumericUpDown();
      AtkLabel = new Label();
      Atk = new NumericUpDown();
      DefLabel = new Label();
      Def = new NumericUpDown();
      SpaLabel = new Label();
      Spa = new NumericUpDown();
      SpdLabel = new Label();
      Spd = new NumericUpDown();
      SpeLabel = new Label();
      Spe = new NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)Level).BeginInit();
      ((System.ComponentModel.ISupportInitialize)CurrentHP).BeginInit();
      ((System.ComponentModel.ISupportInitialize)HP).BeginInit();
      ((System.ComponentModel.ISupportInitialize)Atk).BeginInit();
      ((System.ComponentModel.ISupportInitialize)Def).BeginInit();
      ((System.ComponentModel.ISupportInitialize)Spa).BeginInit();
      ((System.ComponentModel.ISupportInitialize)Spd).BeginInit();
      ((System.ComponentModel.ISupportInitialize)Spe).BeginInit();
      SuspendLayout();
      //
      // PIDLabel
      //
      PIDLabel.AutoSize = true;
      PIDLabel.Location = new Point(3, 8);
      PIDLabel.Name = "PIDLabel";
      PIDLabel.Size = new Size(25, 15);
      PIDLabel.TabIndex = 0;
      PIDLabel.Text = "PID";
      //
      // PID
      //
      PID.Location = new Point(84, 8);
      PID.MaxLength = 8;
      PID.Name = "PID";
      PID.Size = new Size(100, 23);
      PID.TabIndex = 1;
      //
      // Level
      //
      Level.Location = new Point(84, 37);
      Level.Name = "Level";
      Level.Size = new Size(100, 23);
      Level.TabIndex = 2;
      //
      // LevelLabel
      //
      LevelLabel.AutoSize = true;
      LevelLabel.Location = new Point(3, 37);
      LevelLabel.Name = "LevelLabel";
      LevelLabel.Size = new Size(34, 15);
      LevelLabel.TabIndex = 3;
      LevelLabel.Text = "Level";
      //
      // CurrentHPLabel
      //
      CurrentHPLabel.AutoSize = true;
      CurrentHPLabel.Location = new Point(3, 66);
      CurrentHPLabel.Name = "CurrentHPLabel";
      CurrentHPLabel.Size = new Size(66, 15);
      CurrentHPLabel.TabIndex = 4;
      CurrentHPLabel.Text = "Current HP";
      //
      // CurrentHP
      //
      CurrentHP.Location = new Point(84, 66);
      CurrentHP.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
      CurrentHP.Name = "CurrentHP";
      CurrentHP.Size = new Size(100, 23);
      CurrentHP.TabIndex = 5;
      //
      // HPLabel
      //
      HPLabel.AutoSize = true;
      HPLabel.Location = new Point(3, 95);
      HPLabel.Name = "HPLabel";
      HPLabel.Size = new Size(36, 15);
      HPLabel.TabIndex = 6;
      HPLabel.Text = "HP IV";
      //
      // HP
      //
      HP.Location = new Point(84, 95);
      HP.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
      HP.Name = "HP";
      HP.Size = new Size(100, 23);
      HP.TabIndex = 7;
      //
      // AtkLabel
      //
      AtkLabel.AutoSize = true;
      AtkLabel.Location = new Point(4, 124);
      AtkLabel.Name = "AtkLabel";
      AtkLabel.Size = new Size(38, 15);
      AtkLabel.TabIndex = 8;
      AtkLabel.Text = "Atk IV";
      //
      // Atk
      //
      Atk.Location = new Point(84, 124);
      Atk.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
      Atk.Name = "Atk";
      Atk.Size = new Size(100, 23);
      Atk.TabIndex = 9;
      //
      // DefLabel
      //
      DefLabel.AutoSize = true;
      DefLabel.Location = new Point(3, 153);
      DefLabel.Name = "DefLabel";
      DefLabel.Size = new Size(38, 15);
      DefLabel.TabIndex = 10;
      DefLabel.Text = "Def IV";
      //
      // Def
      //
      Def.Location = new Point(84, 153);
      Def.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
      Def.Name = "Def";
      Def.Size = new Size(100, 23);
      Def.TabIndex = 11;
      //
      // SpaLabel
      //
      SpaLabel.AutoSize = true;
      SpaLabel.Location = new Point(3, 182);
      SpaLabel.Name = "SpaLabel";
      SpaLabel.Size = new Size(41, 15);
      SpaLabel.TabIndex = 12;
      SpaLabel.Text = "SpA IV";
      //
      // Spa
      //
      Spa.Location = new Point(84, 182);
      Spa.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
      Spa.Name = "Spa";
      Spa.Size = new Size(100, 23);
      Spa.TabIndex = 13;
      //
      // SpdLabel
      //
      SpdLabel.AutoSize = true;
      SpdLabel.Location = new Point(3, 211);
      SpdLabel.Name = "SpdLabel";
      SpdLabel.Size = new Size(41, 15);
      SpdLabel.TabIndex = 14;
      SpdLabel.Text = "SpD IV";
      //
      // Spd
      //
      Spd.Location = new Point(84, 211);
      Spd.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
      Spd.Name = "Spd";
      Spd.Size = new Size(100, 23);
      Spd.TabIndex = 15;
      //
      // SpeLabel
      //
      SpeLabel.AutoSize = true;
      SpeLabel.Location = new Point(3, 240);
      SpeLabel.Name = "SpeLabel";
      SpeLabel.Size = new Size(39, 15);
      SpeLabel.TabIndex = 16;
      SpeLabel.Text = "Spe IV";
      //
      // Spe
      //
      Spe.Location = new Point(84, 240);
      Spe.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
      Spe.Name = "Spe";
      Spe.Size = new Size(100, 23);
      Spe.TabIndex = 17;
      //
      // Gen4RoamerControl
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(Level);
      Controls.Add(LevelLabel);
      Controls.Add(Spe);
      Controls.Add(SpeLabel);
      Controls.Add(Spd);
      Controls.Add(SpdLabel);
      Controls.Add(Spa);
      Controls.Add(SpaLabel);
      Controls.Add(Def);
      Controls.Add(DefLabel);
      Controls.Add(Atk);
      Controls.Add(AtkLabel);
      Controls.Add(HP);
      Controls.Add(HPLabel);
      Controls.Add(CurrentHP);
      Controls.Add(CurrentHPLabel);
      Controls.Add(PID);
      Controls.Add(PIDLabel);
      Name = "Gen4RoamerControl";
      Size = new Size(195, 275);
      ((System.ComponentModel.ISupportInitialize)Level).EndInit();
      ((System.ComponentModel.ISupportInitialize)CurrentHP).EndInit();
      ((System.ComponentModel.ISupportInitialize)HP).EndInit();
      ((System.ComponentModel.ISupportInitialize)Atk).EndInit();
      ((System.ComponentModel.ISupportInitialize)Def).EndInit();
      ((System.ComponentModel.ISupportInitialize)Spa).EndInit();
      ((System.ComponentModel.ISupportInitialize)Spd).EndInit();
      ((System.ComponentModel.ISupportInitialize)Spe).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label PIDLabel;
    private TextBox PID;
    private Label LevelLabel;
    private NumericUpDown Level;
    private Label CurrentHPLabel;
    private NumericUpDown CurrentHP;
    private Label HPLabel;
    private NumericUpDown HP;
    private Label AtkLabel;
    private NumericUpDown Atk;
    private Label DefLabel;
    private NumericUpDown Def;
    private Label SpaLabel;
    private NumericUpDown Spa;
    private Label SpdLabel;
    private NumericUpDown Spd;
    private Label SpeLabel;
    private NumericUpDown Spe;


  }
}
