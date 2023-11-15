namespace PluginPile.Unmaintained.SwShEventEditor {
  partial class SwordsOfJusticeForm {
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
      questStatusLabel = new Label();
      questStatus = new ComboBox();
      questProgressLabel = new Label();
      questProgress = new ComboBox();
      cobalionGroup = new GroupBox();
      cobalionProgress = new ComboBox();
      cobalionDisappeared = new CheckBox();
      cobalionFootsprintsLabel = new Label();
      cobalionFootprints = new NumericUpDown();
      terrakionGroup = new GroupBox();
      terrakionProgress = new ComboBox();
      terrakionDisappeared = new CheckBox();
      terrakionFootprintsLabel = new Label();
      terrakionFootprints = new NumericUpDown();
      virizionGroup = new GroupBox();
      virizionProgress = new ComboBox();
      virizionDisappeared = new CheckBox();
      virizionFootprintsLabel = new Label();
      virizionFootprints = new NumericUpDown();
      keldeoGroup = new GroupBox();
      keldeoProgress = new ComboBox();
      keldeoDisappeared = new CheckBox();
      apply_BTN = new Button();
      cobalionGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)cobalionFootprints).BeginInit();
      terrakionGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)terrakionFootprints).BeginInit();
      virizionGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)virizionFootprints).BeginInit();
      keldeoGroup.SuspendLayout();
      SuspendLayout();
      // 
      // questStatusLabel
      // 
      questStatusLabel.AutoSize = true;
      questStatusLabel.Location = new Point(18, 10);
      questStatusLabel.Name = "questStatusLabel";
      questStatusLabel.Size = new Size(73, 15);
      questStatusLabel.TabIndex = 0;
      questStatusLabel.Text = "Quest Status";
      // 
      // questStatus
      // 
      questStatus.FormattingEnabled = true;
      questStatus.Location = new Point(18, 28);
      questStatus.Name = "questStatus";
      questStatus.Size = new Size(319, 23);
      questStatus.TabIndex = 1;
      // 
      // questProgressLabel
      // 
      questProgressLabel.AutoSize = true;
      questProgressLabel.Location = new Point(18, 65);
      questProgressLabel.Name = "questProgressLabel";
      questProgressLabel.Size = new Size(86, 15);
      questProgressLabel.TabIndex = 2;
      questProgressLabel.Text = "Quest Progress";
      // 
      // questProgress
      // 
      questProgress.FormattingEnabled = true;
      questProgress.Location = new Point(18, 83);
      questProgress.Name = "questProgress";
      questProgress.Size = new Size(319, 23);
      questProgress.TabIndex = 3;
      // 
      // cobalionGroup
      // 
      cobalionGroup.Controls.Add(cobalionProgress);
      cobalionGroup.Controls.Add(cobalionDisappeared);
      cobalionGroup.Controls.Add(cobalionFootsprintsLabel);
      cobalionGroup.Controls.Add(cobalionFootprints);
      cobalionGroup.Location = new Point(12, 121);
      cobalionGroup.Name = "cobalionGroup";
      cobalionGroup.Size = new Size(338, 80);
      cobalionGroup.TabIndex = 4;
      cobalionGroup.TabStop = false;
      cobalionGroup.Text = "Cobalion";
      // 
      // cobalionProgress
      // 
      cobalionProgress.FormattingEnabled = true;
      cobalionProgress.Location = new Point(6, 20);
      cobalionProgress.Name = "cobalionProgress";
      cobalionProgress.Size = new Size(319, 23);
      cobalionProgress.TabIndex = 5;
      // 
      // cobalionDisappeared
      // 
      cobalionDisappeared.AutoSize = true;
      cobalionDisappeared.Location = new Point(8, 49);
      cobalionDisappeared.Margin = new Padding(4, 3, 4, 3);
      cobalionDisappeared.Name = "cobalionDisappeared";
      cobalionDisappeared.Size = new Size(91, 19);
      cobalionDisappeared.TabIndex = 8;
      cobalionDisappeared.Text = "Disappeared";
      cobalionDisappeared.UseVisualStyleBackColor = true;
      // 
      // cobalionFootsprintsLabel
      // 
      cobalionFootsprintsLabel.AutoSize = true;
      cobalionFootsprintsLabel.Location = new Point(110, 49);
      cobalionFootsprintsLabel.Margin = new Padding(4, 0, 4, 0);
      cobalionFootsprintsLabel.Name = "cobalionFootsprintsLabel";
      cobalionFootsprintsLabel.Size = new Size(69, 15);
      cobalionFootsprintsLabel.TabIndex = 6;
      cobalionFootsprintsLabel.Text = "Footprint %";
      // 
      // cobalionFootprints
      // 
      cobalionFootprints.Increment = new decimal(new int[] { 2, 0, 0, 0 });
      cobalionFootprints.Location = new Point(187, 45);
      cobalionFootprints.Margin = new Padding(4, 3, 4, 3);
      cobalionFootprints.Name = "cobalionFootprints";
      cobalionFootprints.Size = new Size(58, 23);
      cobalionFootprints.TabIndex = 7;
      // 
      // terrakionGroup
      // 
      terrakionGroup.Controls.Add(terrakionProgress);
      terrakionGroup.Controls.Add(terrakionDisappeared);
      terrakionGroup.Controls.Add(terrakionFootprintsLabel);
      terrakionGroup.Controls.Add(terrakionFootprints);
      terrakionGroup.Location = new Point(12, 207);
      terrakionGroup.Name = "terrakionGroup";
      terrakionGroup.Size = new Size(338, 80);
      terrakionGroup.TabIndex = 9;
      terrakionGroup.TabStop = false;
      terrakionGroup.Text = "Terrakion";
      // 
      // terrakionProgress
      // 
      terrakionProgress.FormattingEnabled = true;
      terrakionProgress.Location = new Point(6, 22);
      terrakionProgress.Name = "terrakionProgress";
      terrakionProgress.Size = new Size(319, 23);
      terrakionProgress.TabIndex = 10;
      // 
      // terrakionDisappeared
      // 
      terrakionDisappeared.AutoSize = true;
      terrakionDisappeared.Location = new Point(8, 55);
      terrakionDisappeared.Margin = new Padding(4, 3, 4, 3);
      terrakionDisappeared.Name = "terrakionDisappeared";
      terrakionDisappeared.Size = new Size(91, 19);
      terrakionDisappeared.TabIndex = 11;
      terrakionDisappeared.Text = "Disappeared";
      terrakionDisappeared.UseVisualStyleBackColor = true;
      // 
      // terrakionFootprintsLabel
      // 
      terrakionFootprintsLabel.AutoSize = true;
      terrakionFootprintsLabel.Location = new Point(110, 55);
      terrakionFootprintsLabel.Margin = new Padding(4, 0, 4, 0);
      terrakionFootprintsLabel.Name = "terrakionFootprintsLabel";
      terrakionFootprintsLabel.Size = new Size(69, 15);
      terrakionFootprintsLabel.TabIndex = 12;
      terrakionFootprintsLabel.Text = "Footprint %";
      // 
      // terrakionFootprints
      // 
      terrakionFootprints.Increment = new decimal(new int[] { 2, 0, 0, 0 });
      terrakionFootprints.Location = new Point(187, 47);
      terrakionFootprints.Margin = new Padding(4, 3, 4, 3);
      terrakionFootprints.Name = "terrakionFootprints";
      terrakionFootprints.Size = new Size(58, 23);
      terrakionFootprints.TabIndex = 13;
      // 
      // virizionGroup
      // 
      virizionGroup.Controls.Add(virizionProgress);
      virizionGroup.Controls.Add(virizionDisappeared);
      virizionGroup.Controls.Add(virizionFootprintsLabel);
      virizionGroup.Controls.Add(virizionFootprints);
      virizionGroup.Location = new Point(12, 293);
      virizionGroup.Name = "virizionGroup";
      virizionGroup.Size = new Size(338, 80);
      virizionGroup.TabIndex = 14;
      virizionGroup.TabStop = false;
      virizionGroup.Text = "Virizion";
      // 
      // virizionProgress
      // 
      virizionProgress.FormattingEnabled = true;
      virizionProgress.Location = new Point(3, 21);
      virizionProgress.Name = "virizionProgress";
      virizionProgress.Size = new Size(322, 23);
      virizionProgress.TabIndex = 15;
      // 
      // virizionDisappeared
      // 
      virizionDisappeared.AutoSize = true;
      virizionDisappeared.Location = new Point(5, 53);
      virizionDisappeared.Margin = new Padding(4, 3, 4, 3);
      virizionDisappeared.Name = "virizionDisappeared";
      virizionDisappeared.Size = new Size(91, 19);
      virizionDisappeared.TabIndex = 16;
      virizionDisappeared.Text = "Disappeared";
      virizionDisappeared.UseVisualStyleBackColor = true;
      // 
      // virizionFootprintsLabel
      // 
      virizionFootprintsLabel.AutoSize = true;
      virizionFootprintsLabel.Location = new Point(107, 54);
      virizionFootprintsLabel.Margin = new Padding(4, 0, 4, 0);
      virizionFootprintsLabel.Name = "virizionFootprintsLabel";
      virizionFootprintsLabel.Size = new Size(69, 15);
      virizionFootprintsLabel.TabIndex = 17;
      virizionFootprintsLabel.Text = "Footprint %";
      // 
      // virizionFootprints
      // 
      virizionFootprints.Increment = new decimal(new int[] { 2, 0, 0, 0 });
      virizionFootprints.Location = new Point(184, 49);
      virizionFootprints.Margin = new Padding(4, 3, 4, 3);
      virizionFootprints.Name = "virizionFootprints";
      virizionFootprints.Size = new Size(58, 23);
      virizionFootprints.TabIndex = 18;
      // 
      // keldeoGroup
      // 
      keldeoGroup.Controls.Add(keldeoProgress);
      keldeoGroup.Controls.Add(keldeoDisappeared);
      keldeoGroup.Location = new Point(12, 379);
      keldeoGroup.Name = "keldeoGroup";
      keldeoGroup.Size = new Size(338, 80);
      keldeoGroup.TabIndex = 19;
      keldeoGroup.TabStop = false;
      keldeoGroup.Text = "Keldeo";
      // 
      // keldeoProgress
      // 
      keldeoProgress.FormattingEnabled = true;
      keldeoProgress.Location = new Point(3, 22);
      keldeoProgress.Name = "keldeoProgress";
      keldeoProgress.Size = new Size(322, 23);
      keldeoProgress.TabIndex = 20;
      // 
      // keldeoDisappeared
      // 
      keldeoDisappeared.AutoSize = true;
      keldeoDisappeared.Location = new Point(5, 51);
      keldeoDisappeared.Margin = new Padding(4, 3, 4, 3);
      keldeoDisappeared.Name = "keldeoDisappeared";
      keldeoDisappeared.Size = new Size(91, 19);
      keldeoDisappeared.TabIndex = 21;
      keldeoDisappeared.Text = "Disappeared";
      keldeoDisappeared.UseVisualStyleBackColor = true;
      // 
      // apply_BTN
      // 
      apply_BTN.Location = new Point(196, 465);
      apply_BTN.Margin = new Padding(4, 3, 4, 3);
      apply_BTN.Name = "apply_BTN";
      apply_BTN.Size = new Size(154, 55);
      apply_BTN.TabIndex = 22;
      apply_BTN.Text = "Apply Selection";
      apply_BTN.UseVisualStyleBackColor = true;
      apply_BTN.Click += apply_BTN_Click;
      // 
      // SwordsOfJusticeForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(357, 536);
      Controls.Add(questProgress);
      Controls.Add(questProgressLabel);
      Controls.Add(questStatus);
      Controls.Add(questStatusLabel);
      Controls.Add(cobalionGroup);
      Controls.Add(terrakionGroup);
      Controls.Add(virizionGroup);
      Controls.Add(keldeoGroup);
      Controls.Add(apply_BTN);
      FormBorderStyle = FormBorderStyle.FixedToolWindow;
      Margin = new Padding(4, 3, 4, 3);
      Name = "SwordsOfJusticeForm";
      Text = "Swords of Justice Editor";
      cobalionGroup.ResumeLayout(false);
      cobalionGroup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)cobalionFootprints).EndInit();
      terrakionGroup.ResumeLayout(false);
      terrakionGroup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)terrakionFootprints).EndInit();
      virizionGroup.ResumeLayout(false);
      virizionGroup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)virizionFootprints).EndInit();
      keldeoGroup.ResumeLayout(false);
      keldeoGroup.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Label questStatusLabel;
    private ComboBox questStatus;
    private Label questProgressLabel;
    private ComboBox questProgress;
    private GroupBox cobalionGroup;
    private ComboBox cobalionProgress;
    private CheckBox cobalionDisappeared;
    private Label cobalionFootsprintsLabel;
    private NumericUpDown cobalionFootprints;
    private GroupBox terrakionGroup;
    private ComboBox terrakionProgress;
    private CheckBox terrakionDisappeared;
    private Label terrakionFootprintsLabel;
    private NumericUpDown terrakionFootprints;
    private GroupBox virizionGroup;
    private ComboBox virizionProgress;
    private CheckBox virizionDisappeared;
    private Label virizionFootprintsLabel;
    private NumericUpDown virizionFootprints;
    private GroupBox keldeoGroup;
    private ComboBox keldeoProgress;
    private CheckBox keldeoDisappeared;
    private Button apply_BTN;
  }
}
