namespace PluginPile.RoamerTool {
  partial class Gen4RoamerForm {
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
      Tabs = new TabControl();
      Cancel = new Button();
      Save = new Button();
      SuspendLayout();
      //
      // Tabs
      //
      Tabs.Location = new Point(-2, 0);
      Tabs.Name = "Tabs";
      Tabs.SelectedIndex = 0;
      Tabs.Size = new Size(282, 300);
      Tabs.TabIndex = 0;
      //
      // Cancel
      //
      Cancel.Location = new Point(112, 306);
      Cancel.Name = "Cancel";
      Cancel.Size = new Size(75, 23);
      Cancel.TabIndex = 1;
      Cancel.Text = "Cancel";
      Cancel.UseVisualStyleBackColor = true;
      Cancel.Click += Cancel_Click;
      //
      // Save
      //
      Save.Location = new Point(193, 306);
      Save.Name = "Save";
      Save.Size = new Size(75, 23);
      Save.TabIndex = 2;
      Save.Text = "Save";
      Save.UseVisualStyleBackColor = true;
      Save.Click += Save_Click;
      //
      // Gen4RoamerForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(280, 337);
      Controls.Add(Save);
      Controls.Add(Cancel);
      Controls.Add(Tabs);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "Gen4RoamerForm";
      ShowIcon = false;
      Text = "Gen4RoamerForm";
      ResumeLayout(false);
    }

    #endregion

    private TabControl Tabs;
    private Button Cancel;
    private Button Save;
  }
}
