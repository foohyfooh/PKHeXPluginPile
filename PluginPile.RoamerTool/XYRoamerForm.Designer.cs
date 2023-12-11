namespace PluginPile.RoamerTool {
  partial class XYRoamerForm {
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
      RoamerSpeciesLabel = new Label();
      RoamerSpecies = new ComboBox();
      EncounteredLabel = new Label();
      Encountered = new NumericUpDown();
      StateLabel = new Label();
      State = new ComboBox();
      Cancel = new Button();
      Save = new Button();
      ((System.ComponentModel.ISupportInitialize)Encountered).BeginInit();
      SuspendLayout();
      //
      // RoamerSpeciesLabel
      //
      RoamerSpeciesLabel.AutoSize = true;
      RoamerSpeciesLabel.Location = new Point(12, 9);
      RoamerSpeciesLabel.Name = "RoamerSpeciesLabel";
      RoamerSpeciesLabel.Size = new Size(90, 15);
      RoamerSpeciesLabel.TabIndex = 0;
      RoamerSpeciesLabel.Text = "Roamer Species";
      RoamerSpeciesLabel.Click += RoamerSpeciesLabel_Click;
      //
      // RoamerSpecies
      //
      RoamerSpecies.FormattingEnabled = true;
      RoamerSpecies.Location = new Point(12, 27);
      RoamerSpecies.Name = "RoamerSpecies";
      RoamerSpecies.Size = new Size(162, 23);
      RoamerSpecies.TabIndex = 1;
      //
      // EncounteredLabel
      //
      EncounteredLabel.AutoSize = true;
      EncounteredLabel.Location = new Point(194, 9);
      EncounteredLabel.Name = "EncounteredLabel";
      EncounteredLabel.Size = new Size(67, 15);
      EncounteredLabel.TabIndex = 2;
      EncounteredLabel.Text = "Ecountered";
      EncounteredLabel.Click += EncounteredLabel_Click;
      //
      // Encountered
      //
      Encountered.Location = new Point(194, 28);
      Encountered.Maximum = new decimal(new int[] { 11, 0, 0, 0 });
      Encountered.Name = "Encountered";
      Encountered.Size = new Size(120, 23);
      Encountered.TabIndex = 3;
      //
      // StateLabel
      //
      StateLabel.AutoSize = true;
      StateLabel.Location = new Point(329, 9);
      StateLabel.Name = "StateLabel";
      StateLabel.Size = new Size(33, 15);
      StateLabel.TabIndex = 4;
      StateLabel.Text = "State";
      StateLabel.Click += StateLabel_Click;
      //
      // State
      //
      State.FormattingEnabled = true;
      State.Location = new Point(329, 28);
      State.Name = "State";
      State.Size = new Size(121, 23);
      State.TabIndex = 5;
      //
      // Cancel
      //
      Cancel.Location = new Point(287, 66);
      Cancel.Name = "Cancel";
      Cancel.Size = new Size(75, 23);
      Cancel.TabIndex = 6;
      Cancel.Text = "Cancel";
      Cancel.UseVisualStyleBackColor = true;
      Cancel.Click += Cancel_Click;
      //
      // Save
      //
      Save.Location = new Point(375, 66);
      Save.Name = "Save";
      Save.Size = new Size(75, 23);
      Save.TabIndex = 7;
      Save.Text = "Save";
      Save.UseVisualStyleBackColor = true;
      Save.Click += Save_Click;
      //
      // XYRoamerForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(468, 101);
      Controls.Add(Save);
      Controls.Add(Cancel);
      Controls.Add(State);
      Controls.Add(StateLabel);
      Controls.Add(Encountered);
      Controls.Add(EncounteredLabel);
      Controls.Add(RoamerSpecies);
      Controls.Add(RoamerSpeciesLabel);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "XYRoamerForm";
      ShowIcon = false;
      Text = "XYRoamerForm";
      ((System.ComponentModel.ISupportInitialize)Encountered).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label RoamerSpeciesLabel;
    private ComboBox RoamerSpecies;
    private Label EncounteredLabel;
    private NumericUpDown Encountered;
    private Label StateLabel;
    private ComboBox State;
    private Button Cancel;
    private Button Save;
  }
}
