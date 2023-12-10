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
      ItemsList = new ComboBox();
      ItemLabel = new Label();
      Owned = new CheckBox();
      NewCheckbox = new CheckBox();
      SuspendLayout();
      //
      // ItemsList
      //
      ItemsList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ItemsList.FormattingEnabled = true;
      ItemsList.Location = new Point(51, 8);
      ItemsList.Name = "ItemsList";
      ItemsList.Size = new Size(243, 23);
      ItemsList.TabIndex = 0;
      ItemsList.SelectedIndexChanged += NamesList_SelectedIndexChanged;
      //
      // ItemLabel
      //
      ItemLabel.AutoSize = true;
      ItemLabel.Location = new Point(3, 11);
      ItemLabel.Name = "ItemLabel";
      ItemLabel.Size = new Size(31, 15);
      ItemLabel.TabIndex = 1;
      ItemLabel.Text = "Item";
      //
      // Owned
      //
      Owned.AutoSize = true;
      Owned.CheckAlign = ContentAlignment.MiddleRight;
      Owned.Location = new Point(3, 43);
      Owned.Name = "Owned";
      Owned.Size = new Size(64, 19);
      Owned.TabIndex = 2;
      Owned.Text = "Owned";
      Owned.UseVisualStyleBackColor = true;
      Owned.CheckedChanged += Unlocked_CheckedChanged;
      //
      // NewCheckbox
      //
      NewCheckbox.AutoSize = true;
      NewCheckbox.CheckAlign = ContentAlignment.MiddleRight;
      NewCheckbox.Enabled = false;
      NewCheckbox.Location = new Point(85, 43);
      NewCheckbox.Name = "NewCheckbox";
      NewCheckbox.Size = new Size(50, 19);
      NewCheckbox.TabIndex = 3;
      NewCheckbox.Text = "New";
      NewCheckbox.UseVisualStyleBackColor = true;
      NewCheckbox.CheckedChanged += NewCheckbox_CheckedChanged;
      //
      // FashionPageSelector
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(NewCheckbox);
      Controls.Add(Owned);
      Controls.Add(ItemLabel);
      Controls.Add(ItemsList);
      Name = "FashionPageSelector";
      Size = new Size(307, 74);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private ComboBox ItemsList;
    private Label ItemLabel;
    private CheckBox Owned;
    private CheckBox NewCheckbox;
  }
}
