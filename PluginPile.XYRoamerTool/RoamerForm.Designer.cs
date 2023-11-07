namespace PluginPile.XYRoamerTool {
  partial class RoamerForm {
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
      roamerSpeciesLabel = new Label();
      roamerSpecies = new ComboBox();
      encounteredLabel = new Label();
      encountered = new NumericUpDown();
      stateLabel = new Label();
      state = new ComboBox();
      cancel = new Button();
      save = new Button();
      ((System.ComponentModel.ISupportInitialize)encountered).BeginInit();
      SuspendLayout();
      //
      // roamerSpeciesLabel
      //
      roamerSpeciesLabel.AutoSize = true;
      roamerSpeciesLabel.Location = new Point(12, 9);
      roamerSpeciesLabel.Name = "roamerSpeciesLabel";
      roamerSpeciesLabel.Size = new Size(90, 15);
      roamerSpeciesLabel.TabIndex = 0;
      roamerSpeciesLabel.Text = "Roamer Species";
      roamerSpeciesLabel.Click += roamerSpeciesLabel_Click;
      //
      // roamerSpecies
      //
      roamerSpecies.FormattingEnabled = true;
      roamerSpecies.Location = new Point(12, 27);
      roamerSpecies.Name = "roamerSpecies";
      roamerSpecies.Size = new Size(162, 23);
      roamerSpecies.TabIndex = 1;
      //
      // encounteredLabel
      //
      encounteredLabel.AutoSize = true;
      encounteredLabel.Location = new Point(194, 9);
      encounteredLabel.Name = "encounteredLabel";
      encounteredLabel.Size = new Size(67, 15);
      encounteredLabel.TabIndex = 2;
      encounteredLabel.Text = "Ecountered";
      encounteredLabel.Click += encounteredLabel_Click;
      //
      // encountered
      //
      encountered.Location = new Point(194, 28);
      encountered.Maximum = new decimal(new int[] { 11, 0, 0, 0 });
      encountered.Name = "encountered";
      encountered.Size = new Size(120, 23);
      encountered.TabIndex = 3;
      //
      // stateLabel
      //
      stateLabel.AutoSize = true;
      stateLabel.Location = new Point(329, 9);
      stateLabel.Name = "stateLabel";
      stateLabel.Size = new Size(33, 15);
      stateLabel.TabIndex = 4;
      stateLabel.Text = "State";
      stateLabel.Click += stateLabel_Click;
      //
      // state
      //
      state.FormattingEnabled = true;
      state.Location = new Point(329, 28);
      state.Name = "state";
      state.Size = new Size(121, 23);
      state.TabIndex = 5;
      //
      // cancel
      //
      cancel.Location = new Point(287, 66);
      cancel.Name = "cancel";
      cancel.Size = new Size(75, 23);
      cancel.TabIndex = 6;
      cancel.Text = "Cancel";
      cancel.UseVisualStyleBackColor = true;
      cancel.Click += cancel_Click;
      //
      // save
      //
      save.Location = new Point(375, 66);
      save.Name = "save";
      save.Size = new Size(75, 23);
      save.TabIndex = 7;
      save.Text = "Save";
      save.UseVisualStyleBackColor = true;
      save.Click += save_Click;
      //
      // RoamerForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(468, 101);
      Controls.Add(save);
      Controls.Add(cancel);
      Controls.Add(state);
      Controls.Add(stateLabel);
      Controls.Add(encountered);
      Controls.Add(encounteredLabel);
      Controls.Add(roamerSpecies);
      Controls.Add(roamerSpeciesLabel);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "RoamerForm";
      ShowIcon = false;
      Text = "RoamerForm";
      ((System.ComponentModel.ISupportInitialize)encountered).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label roamerSpeciesLabel;
    private ComboBox roamerSpecies;
    private Label encounteredLabel;
    private NumericUpDown encountered;
    private Label stateLabel;
    private ComboBox state;
    private Button cancel;
    private Button save;
  }
}
