namespace PluginPile.InsertionPlugin {
  partial class PositionForm {
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
      boxNumberLabel = new Label();
      boxNumber = new TextBox();
      slotNumberLabel = new Label();
      slotNumber = new TextBox();
      insertSpotButton = new Button();
      SuspendLayout();
      // 
      // boxNumberLabel
      // 
      boxNumberLabel.AutoSize = true;
      boxNumberLabel.Location = new Point(12, 12);
      boxNumberLabel.Name = "boxNumberLabel";
      boxNumberLabel.Size = new Size(74, 15);
      boxNumberLabel.TabIndex = 0;
      boxNumberLabel.Text = "Box Number";
      boxNumberLabel.Click += boxNumberLabel_Click;
      // 
      // boxNumber
      // 
      boxNumber.Location = new Point(133, 12);
      boxNumber.Name = "boxNumber";
      boxNumber.PlaceholderText = "Box Number";
      boxNumber.Size = new Size(100, 23);
      boxNumber.TabIndex = 1;
      boxNumber.TextChanged += boxNumber_TextChanged;
      // 
      // slotNumberLabel
      // 
      slotNumberLabel.AutoSize = true;
      slotNumberLabel.Location = new Point(12, 41);
      slotNumberLabel.Name = "slotNumberLabel";
      slotNumberLabel.Size = new Size(74, 15);
      slotNumberLabel.TabIndex = 2;
      slotNumberLabel.Text = "Slot Number";
      slotNumberLabel.Click += slotNumberLabel_Click;
      // 
      // slotNumber
      // 
      slotNumber.Location = new Point(133, 41);
      slotNumber.Name = "slotNumber";
      slotNumber.PlaceholderText = "Slot Number";
      slotNumber.Size = new Size(100, 23);
      slotNumber.TabIndex = 3;
      slotNumber.TextChanged += slotNumber_TextChanged;
      // 
      // insertSpotButton
      // 
      insertSpotButton.Location = new Point(12, 70);
      insertSpotButton.Name = "insertSpotButton";
      insertSpotButton.Size = new Size(221, 23);
      insertSpotButton.TabIndex = 4;
      insertSpotButton.Text = "Insert Spot";
      insertSpotButton.UseVisualStyleBackColor = true;
      insertSpotButton.Click += insertSpotButton_Click;
      // 
      // PositionForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(253, 103);
      Controls.Add(insertSpotButton);
      Controls.Add(slotNumber);
      Controls.Add(slotNumberLabel);
      Controls.Add(boxNumber);
      Controls.Add(boxNumberLabel);
      FormBorderStyle = FormBorderStyle.FixedToolWindow;
      MaximizeBox = false;
      Name = "PositionForm";
      ShowIcon = false;
      Text = "Insertion Plugin";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label boxNumberLabel;
    private TextBox boxNumber;
    private Label slotNumberLabel;
    private TextBox slotNumber;
    private Button insertSpotButton;
  }
}
