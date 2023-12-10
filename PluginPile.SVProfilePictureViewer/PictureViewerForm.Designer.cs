namespace PluginPile.SVProfilePictureViewer {
  partial class PictureViewerForm {
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
      CurrentProfilePicturePage = new TabPage();
      CrrentProfilePicture = new PictureBox();
      CurrentProfileIconPage = new TabPage();
      CurrentProfileIcon = new PictureBox();
      InitialProfilePicturePage = new TabPage();
      InitialProfilePicture = new PictureBox();
      InitialProfileIconPage = new TabPage();
      InitialProfileIcon = new PictureBox();
      ExportButton = new Button();
      Tabs = new TabControl();
      CurrentProfilePicturePage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)CrrentProfilePicture).BeginInit();
      CurrentProfileIconPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)CurrentProfileIcon).BeginInit();
      InitialProfilePicturePage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)InitialProfilePicture).BeginInit();
      InitialProfileIconPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)InitialProfileIcon).BeginInit();
      Tabs.SuspendLayout();
      SuspendLayout();
      //
      // CurrentProfilePicturePage
      //
      CurrentProfilePicturePage.Controls.Add(CrrentProfilePicture);
      CurrentProfilePicturePage.Location = new Point(4, 24);
      CurrentProfilePicturePage.Name = "CurrentProfilePicturePage";
      CurrentProfilePicturePage.Padding = new Padding(3);
      CurrentProfilePicturePage.Size = new Size(494, 246);
      CurrentProfilePicturePage.TabIndex = 0;
      CurrentProfilePicturePage.Text = "Current Profile Picture";
      CurrentProfilePicturePage.UseVisualStyleBackColor = true;
      //
      // CurrentProfilePicture
      //
      CrrentProfilePicture.Location = new Point(6, 6);
      CrrentProfilePicture.Name = "CurrentProfilePicture";
      CrrentProfilePicture.Size = new Size(360, 216);
      CrrentProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
      CrrentProfilePicture.TabIndex = 0;
      CrrentProfilePicture.TabStop = false;
      //
      // CurrentProfileIconPage
      //
      CurrentProfileIconPage.Controls.Add(CurrentProfileIcon);
      CurrentProfileIconPage.Location = new Point(4, 24);
      CurrentProfileIconPage.Name = "CurrentProfileIconPage";
      CurrentProfileIconPage.Padding = new Padding(3);
      CurrentProfileIconPage.Size = new Size(494, 246);
      CurrentProfileIconPage.TabIndex = 1;
      CurrentProfileIconPage.Text = "Current Profile Icon";
      CurrentProfileIconPage.UseVisualStyleBackColor = true;
      //
      // CurrentProfileIcon
      //
      CurrentProfileIcon.Location = new Point(6, 6);
      CurrentProfileIcon.Name = "CurrentProfileIcon";
      CurrentProfileIcon.Size = new Size(360, 216);
      CurrentProfileIcon.SizeMode = PictureBoxSizeMode.Zoom;
      CurrentProfileIcon.TabIndex = 1;
      CurrentProfileIcon.TabStop = false;
      //
      // InitialProfilePicturePage
      //
      InitialProfilePicturePage.Controls.Add(InitialProfilePicture);
      InitialProfilePicturePage.Location = new Point(4, 24);
      InitialProfilePicturePage.Name = "InitialProfilePicturePage";
      InitialProfilePicturePage.Size = new Size(494, 246);
      InitialProfilePicturePage.TabIndex = 2;
      InitialProfilePicturePage.Text = "Initial Profile Picture";
      InitialProfilePicturePage.UseVisualStyleBackColor = true;
      //
      // InitialProfilePicture
      //
      InitialProfilePicture.Location = new Point(6, 6);
      InitialProfilePicture.Name = "InitialProfilePicture";
      InitialProfilePicture.Size = new Size(360, 216);
      InitialProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
      InitialProfilePicture.TabIndex = 2;
      InitialProfilePicture.TabStop = false;
      //
      // InitialProfileIconPage
      //
      InitialProfileIconPage.Controls.Add(InitialProfileIcon);
      InitialProfileIconPage.Location = new Point(4, 24);
      InitialProfileIconPage.Name = "InitialProfileIconPage";
      InitialProfileIconPage.Size = new Size(494, 246);
      InitialProfileIconPage.TabIndex = 3;
      InitialProfileIconPage.Text = "Initial Profile Icon";
      InitialProfileIconPage.UseVisualStyleBackColor = true;
      //
      // InitialProfileIcon
      //
      InitialProfileIcon.Location = new Point(6, 6);
      InitialProfileIcon.Name = "InitialProfileIcon";
      InitialProfileIcon.Size = new Size(360, 216);
      InitialProfileIcon.SizeMode = PictureBoxSizeMode.Zoom;
      InitialProfileIcon.TabIndex = 3;
      InitialProfileIcon.TabStop = false;
      //
      // ExportButton
      //
      ExportButton.Location = new Point(12, 292);
      ExportButton.Name = "ExportButton";
      ExportButton.Size = new Size(75, 23);
      ExportButton.TabIndex = 0;
      ExportButton.Text = "Export";
      ExportButton.UseVisualStyleBackColor = true;
      ExportButton.Click += ExportButton_Click;
      //
      // Tabs
      //
      Tabs.Controls.Add(CurrentProfilePicturePage);
      Tabs.Controls.Add(CurrentProfileIconPage);
      Tabs.Controls.Add(InitialProfilePicturePage);
      Tabs.Controls.Add(InitialProfileIconPage);
      Tabs.Location = new Point(12, 12);
      Tabs.Name = "Tabs";
      Tabs.SelectedIndex = 0;
      Tabs.Size = new Size(502, 274);
      Tabs.TabIndex = 1;
      //
      // PictureViewerForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(524, 331);
      Controls.Add(Tabs);
      Controls.Add(ExportButton);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "PictureViewerForm";
      ShowIcon = false;
      Text = "PictureViewerForm";
      CurrentProfilePicturePage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)CrrentProfilePicture).EndInit();
      CurrentProfileIconPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)CurrentProfileIcon).EndInit();
      InitialProfilePicturePage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)InitialProfilePicture).EndInit();
      InitialProfileIconPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)InitialProfileIcon).EndInit();
      Tabs.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Button ExportButton;
    private TabControl Tabs;
    private TabPage CurrentProfilePicturePage;
    private PictureBox CrrentProfilePicture;
    private TabPage CurrentProfileIconPage;
    private PictureBox CurrentProfileIcon;
    private TabPage InitialProfilePicturePage;
    private PictureBox InitialProfilePicture;
    private TabPage InitialProfileIconPage;
    private PictureBox InitialProfileIcon;
  }
}
