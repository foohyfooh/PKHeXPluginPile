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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionForm));
      boxNumberLabel = new Label();
      boxNumber = new TextBox();
      slotNumberLabel = new Label();
      slotNumber = new TextBox();
      insertSpotButton = new Button();
      SuspendLayout();
      // 
      // boxNumberLabel
      // 
      resources.ApplyResources(boxNumberLabel, "boxNumberLabel");
      boxNumberLabel.Name = "boxNumberLabel";
      boxNumberLabel.Click += boxNumberLabel_Click;
      // 
      // boxNumber
      // 
      resources.ApplyResources(boxNumber, "boxNumber");
      boxNumber.Name = "boxNumber";
      boxNumber.TextChanged += boxNumber_TextChanged;
      // 
      // slotNumberLabel
      // 
      resources.ApplyResources(slotNumberLabel, "slotNumberLabel");
      slotNumberLabel.Name = "slotNumberLabel";
      slotNumberLabel.Click += slotNumberLabel_Click;
      // 
      // slotNumber
      // 
      resources.ApplyResources(slotNumber, "slotNumber");
      slotNumber.Name = "slotNumber";
      slotNumber.TextChanged += slotNumber_TextChanged;
      // 
      // insertSpotButton
      // 
      resources.ApplyResources(insertSpotButton, "insertSpotButton");
      insertSpotButton.Name = "insertSpotButton";
      insertSpotButton.UseVisualStyleBackColor = true;
      insertSpotButton.Click += insertSpotButton_Click;
      // 
      // PositionForm
      // 
      resources.ApplyResources(this, "$this");
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(insertSpotButton);
      Controls.Add(slotNumber);
      Controls.Add(slotNumberLabel);
      Controls.Add(boxNumber);
      Controls.Add(boxNumberLabel);
      FormBorderStyle = FormBorderStyle.FixedToolWindow;
      MaximizeBox = false;
      Name = "PositionForm";
      ShowIcon = false;
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
