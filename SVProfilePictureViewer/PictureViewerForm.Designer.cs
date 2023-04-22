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
      currentProfilePicturePage = new TabPage();
      currentProfilePicture = new PictureBox();
      currentProfileIconPage = new TabPage();
      currentProfileIcon = new PictureBox();
      initialProfilePicturePage = new TabPage();
      initialProfilePicture = new PictureBox();
      initialProfileIconPage = new TabPage();
      initialProfileIcon = new PictureBox();
      saveButton = new Button();
      tabs = new TabControl();
      currentProfilePicturePage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)currentProfilePicture).BeginInit();
      currentProfileIconPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)currentProfileIcon).BeginInit();
      initialProfilePicturePage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)initialProfilePicture).BeginInit();
      initialProfileIconPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)initialProfileIcon).BeginInit();
      tabs.SuspendLayout();
      SuspendLayout();
      // 
      // currentProfilePicturePage
      // 
      currentProfilePicturePage.Controls.Add(currentProfilePicture);
      currentProfilePicturePage.Location = new Point(4, 24);
      currentProfilePicturePage.Name = "currentProfilePicturePage";
      currentProfilePicturePage.Padding = new Padding(3);
      currentProfilePicturePage.Size = new Size(494, 246);
      currentProfilePicturePage.TabIndex = 0;
      currentProfilePicturePage.Text = "Current Profile Picture";
      currentProfilePicturePage.UseVisualStyleBackColor = true;
      // 
      // currentProfilePicture
      // 
      currentProfilePicture.Location = new Point(6, 6);
      currentProfilePicture.Name = "currentProfilePicture";
      currentProfilePicture.Size = new Size(360, 216);
      currentProfilePicture.TabIndex = 0;
      currentProfilePicture.TabStop = false;
      // 
      // currentProfileIconPage
      // 
      currentProfileIconPage.Controls.Add(currentProfileIcon);
      currentProfileIconPage.Location = new Point(4, 24);
      currentProfileIconPage.Name = "currentProfileIconPage";
      currentProfileIconPage.Padding = new Padding(3);
      currentProfileIconPage.Size = new Size(494, 246);
      currentProfileIconPage.TabIndex = 1;
      currentProfileIconPage.Text = "Current Profile Icon";
      currentProfileIconPage.UseVisualStyleBackColor = true;
      // 
      // currentProfileIcon
      // 
      currentProfileIcon.Location = new Point(6, 6);
      currentProfileIcon.Name = "currentProfileIcon";
      currentProfileIcon.Size = new Size(360, 216);
      currentProfileIcon.TabIndex = 1;
      currentProfileIcon.TabStop = false;
      // 
      // initialProfilePicturePage
      // 
      initialProfilePicturePage.Controls.Add(initialProfilePicture);
      initialProfilePicturePage.Location = new Point(4, 24);
      initialProfilePicturePage.Name = "initialProfilePicturePage";
      initialProfilePicturePage.Size = new Size(494, 246);
      initialProfilePicturePage.TabIndex = 2;
      initialProfilePicturePage.Text = "Initial Profile Picture";
      initialProfilePicturePage.UseVisualStyleBackColor = true;
      // 
      // initialProfilePicture
      // 
      initialProfilePicture.Location = new Point(6, 6);
      initialProfilePicture.Name = "initialProfilePicture";
      initialProfilePicture.Size = new Size(360, 216);
      initialProfilePicture.TabIndex = 2;
      initialProfilePicture.TabStop = false;
      // 
      // initialProfileIconPage
      // 
      initialProfileIconPage.Controls.Add(initialProfileIcon);
      initialProfileIconPage.Location = new Point(4, 24);
      initialProfileIconPage.Name = "initialProfileIconPage";
      initialProfileIconPage.Size = new Size(494, 246);
      initialProfileIconPage.TabIndex = 3;
      initialProfileIconPage.Text = "Initial Profile Icon";
      initialProfileIconPage.UseVisualStyleBackColor = true;
      // 
      // initialProfileIcon
      // 
      initialProfileIcon.Location = new Point(6, 6);
      initialProfileIcon.Name = "initialProfileIcon";
      initialProfileIcon.Size = new Size(360, 216);
      initialProfileIcon.TabIndex = 3;
      initialProfileIcon.TabStop = false;
      // 
      // saveButton
      // 
      saveButton.Location = new Point(12, 292);
      saveButton.Name = "saveButton";
      saveButton.Size = new Size(75, 23);
      saveButton.TabIndex = 0;
      saveButton.Text = "Save";
      saveButton.UseVisualStyleBackColor = true;
      saveButton.Click += saveButton_Click;
      // 
      // tabs
      // 
      tabs.Controls.Add(currentProfilePicturePage);
      tabs.Controls.Add(currentProfileIconPage);
      tabs.Controls.Add(initialProfilePicturePage);
      tabs.Controls.Add(initialProfileIconPage);
      tabs.Location = new Point(12, 12);
      tabs.Name = "tabs";
      tabs.SelectedIndex = 0;
      tabs.Size = new Size(502, 274);
      tabs.TabIndex = 1;
      // 
      // PictureViewerForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(524, 331);
      Controls.Add(tabs);
      Controls.Add(saveButton);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "PictureViewerForm";
      ShowIcon = false;
      Text = "PictureViewerForm";
      currentProfilePicturePage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)currentProfilePicture).EndInit();
      currentProfileIconPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)currentProfileIcon).EndInit();
      initialProfilePicturePage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)initialProfilePicture).EndInit();
      initialProfileIconPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)initialProfileIcon).EndInit();
      tabs.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Button saveButton;
    private TabControl tabs;
    private TabPage currentProfilePicturePage;
    private PictureBox currentProfilePicture;
    private TabPage currentProfileIconPage;
    private PictureBox currentProfileIcon;
    private TabPage initialProfilePicturePage;
    private PictureBox initialProfilePicture;
    private TabPage initialProfileIconPage;
    private PictureBox initialProfileIcon;
  }
}
