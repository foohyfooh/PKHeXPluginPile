namespace PluginPile.FashionEditor {
  partial class FashionPageSelector {
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
      itemsList = new ComboBox();
      itemLabel = new Label();
      owned = new CheckBox();
      SuspendLayout();
      // 
      // itemsList
      // 
      itemsList.FormattingEnabled = true;
      itemsList.Location = new Point(51, 8);
      itemsList.Name = "itemsList";
      itemsList.Size = new Size(243, 23);
      itemsList.TabIndex = 0;
      itemsList.SelectedIndexChanged += namesList_SelectedIndexChanged;
      // 
      // itemLabel
      // 
      itemLabel.AutoSize = true;
      itemLabel.Location = new Point(3, 11);
      itemLabel.Name = "itemLabel";
      itemLabel.Size = new Size(31, 15);
      itemLabel.TabIndex = 1;
      itemLabel.Text = "Item";
      // 
      // owned
      // 
      owned.AutoSize = true;
      owned.CheckAlign = ContentAlignment.MiddleRight;
      owned.Location = new Point(3, 43);
      owned.Name = "owned";
      owned.Size = new Size(64, 19);
      owned.TabIndex = 2;
      owned.Text = "Owned";
      owned.UseVisualStyleBackColor = true;
      owned.CheckedChanged += unlocked_CheckedChanged;
      // 
      // FashionPageSelector
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(owned);
      Controls.Add(itemLabel);
      Controls.Add(itemsList);
      Name = "FashionPageSelector";
      Size = new Size(307, 74);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private ComboBox itemsList;
    private Label itemLabel;
    private CheckBox owned;
  }
}
