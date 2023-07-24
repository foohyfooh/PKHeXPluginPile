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
      exportButton = new Button();
      tabs = new TabControl();
      importCurrentProfilePictureButton = new Button();
      importCurrentProfileIconButton = new Button();
      importInitialProfilePictureButton = new Button();
      importInitialProfileIconButton = new Button();
      currentProfilePicturePage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(currentProfilePicture)).BeginInit();
      currentProfileIconPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(currentProfileIcon)).BeginInit();
      initialProfilePicturePage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(initialProfilePicture)).BeginInit();
      initialProfileIconPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(initialProfileIcon)).BeginInit();
      tabs.SuspendLayout();
      SuspendLayout();
      // 
      // currentProfilePicturePage
      // 
      currentProfilePicturePage.Controls.Add(currentProfilePicture);
      currentProfilePicturePage.Location = new Point(4, 26);
      currentProfilePicturePage.Name = "currentProfilePicturePage";
      currentProfilePicturePage.Padding = new Padding(3);
      currentProfilePicturePage.Size = new Size(494, 244);
      currentProfilePicturePage.TabIndex = 0;
      currentProfilePicturePage.Text = "Current Profile Picture";
      currentProfilePicturePage.UseVisualStyleBackColor = true;
      // 
      // currentProfilePicture
      // 
      currentProfilePicture.Location = new Point(6, 6);
      currentProfilePicture.Name = "currentProfilePicture";
      currentProfilePicture.Size = new Size(360, 216);
      currentProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
      currentProfilePicture.TabIndex = 0;
      currentProfilePicture.TabStop = false;
      // 
      // currentProfileIconPage
      // 
      currentProfileIconPage.Controls.Add(currentProfileIcon);
      currentProfileIconPage.Location = new Point(4, 26);
      currentProfileIconPage.Name = "currentProfileIconPage";
      currentProfileIconPage.Padding = new Padding(3);
      currentProfileIconPage.Size = new Size(494, 244);
      currentProfileIconPage.TabIndex = 1;
      currentProfileIconPage.Text = "Current Profile Icon";
      currentProfileIconPage.UseVisualStyleBackColor = true;
      // 
      // currentProfileIcon
      // 
      currentProfileIcon.Location = new Point(6, 6);
      currentProfileIcon.Name = "currentProfileIcon";
      currentProfileIcon.Size = new Size(360, 216);
      currentProfileIcon.SizeMode = PictureBoxSizeMode.Zoom;
      currentProfileIcon.TabIndex = 1;
      currentProfileIcon.TabStop = false;
      // 
      // initialProfilePicturePage
      // 
      initialProfilePicturePage.Controls.Add(initialProfilePicture);
      initialProfilePicturePage.Location = new Point(4, 26);
      initialProfilePicturePage.Name = "initialProfilePicturePage";
      initialProfilePicturePage.Size = new Size(494, 244);
      initialProfilePicturePage.TabIndex = 2;
      initialProfilePicturePage.Text = "Initial Profile Picture";
      initialProfilePicturePage.UseVisualStyleBackColor = true;
      // 
      // initialProfilePicture
      // 
      initialProfilePicture.Location = new Point(6, 6);
      initialProfilePicture.Name = "initialProfilePicture";
      initialProfilePicture.Size = new Size(360, 216);
      initialProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
      initialProfilePicture.TabIndex = 2;
      initialProfilePicture.TabStop = false;
      // 
      // initialProfileIconPage
      // 
      initialProfileIconPage.Controls.Add(initialProfileIcon);
      initialProfileIconPage.Location = new Point(4, 26);
      initialProfileIconPage.Name = "initialProfileIconPage";
      initialProfileIconPage.Size = new Size(494, 244);
      initialProfileIconPage.TabIndex = 3;
      initialProfileIconPage.Text = "Initial Profile Icon";
      initialProfileIconPage.UseVisualStyleBackColor = true;
      // 
      // initialProfileIcon
      // 
      initialProfileIcon.Location = new Point(6, 6);
      initialProfileIcon.Name = "initialProfileIcon";
      initialProfileIcon.Size = new Size(360, 216);
      initialProfileIcon.SizeMode = PictureBoxSizeMode.Zoom;
      initialProfileIcon.TabIndex = 3;
      initialProfileIcon.TabStop = false;
      // 
      // exportButton
      // 
      exportButton.Location = new Point(12, 292);
      exportButton.Name = "exportButton";
      exportButton.Size = new Size(75, 23);
      exportButton.TabIndex = 0;
      exportButton.Text = "Export";
      exportButton.UseVisualStyleBackColor = true;
      exportButton.Click += saveButton_Click;
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
      // importCurrentProfilePictureButton
      // 
      importCurrentProfilePictureButton.Location = new Point(315, 292);
      importCurrentProfilePictureButton.Name = "importCurrentProfilePictureButton";
      importCurrentProfilePictureButton.Size = new Size(95, 23);
      importCurrentProfilePictureButton.TabIndex = 2;
      importCurrentProfilePictureButton.Text = "Import Current Picture";
      importCurrentProfilePictureButton.UseVisualStyleBackColor = true;
      importCurrentProfilePictureButton.Click += importCurrentProfilePictureButton_Click;
      // 
      // importCurrentProfileIconButton
      // 
      importCurrentProfileIconButton.Location = new Point(416, 292);
      importCurrentProfileIconButton.Name = "importCurrentProfileIconButton";
      importCurrentProfileIconButton.Size = new Size(95, 23);
      importCurrentProfileIconButton.TabIndex = 3;
      importCurrentProfileIconButton.Text = "Import Current Icon";
      importCurrentProfileIconButton.UseVisualStyleBackColor = true;
      importCurrentProfileIconButton.Click += importCurrentProfileIconButton_Click;
      // 
      // importInitialProfilePictureButton
      // 
      importInitialProfilePictureButton.Location = new Point(315, 321);
      importInitialProfilePictureButton.Name = "importInitialProfilePictureButton";
      importInitialProfilePictureButton.Size = new Size(95, 26);
      importInitialProfilePictureButton.TabIndex = 4;
      importInitialProfilePictureButton.Text = "Import Initial Picture";
      importInitialProfilePictureButton.UseVisualStyleBackColor = true;
      importInitialProfilePictureButton.Click += importInitialProfilePictureButton_Click;
      // 
      // importInitialProfileIconButton
      // 
      importInitialProfileIconButton.Location = new Point(416, 321);
      importInitialProfileIconButton.Name = "importInitialProfileIconButton";
      importInitialProfileIconButton.Size = new Size(95, 26);
      importInitialProfileIconButton.TabIndex = 5;
      importInitialProfileIconButton.Text = "Import Initial Icon";
      importInitialProfileIconButton.UseVisualStyleBackColor = true;
      importInitialProfileIconButton.Click += importInitialProfileIconButton_Click;
      // 
      // PictureViewerForm
      // 
      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(524, 375);
      Controls.Add(importInitialProfilePictureButton);
      Controls.Add(importInitialProfileIconButton);
      Controls.Add(importCurrentProfileIconButton);
      Controls.Add(importCurrentProfilePictureButton);
      Controls.Add(tabs);
      Controls.Add(exportButton);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "PictureViewerForm";
      ShowIcon = false;
      Text = "PictureViewerForm";
      currentProfilePicturePage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(currentProfilePicture)).EndInit();
      currentProfileIconPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(currentProfileIcon)).EndInit();
      initialProfilePicturePage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(initialProfilePicture)).EndInit();
      initialProfileIconPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(initialProfileIcon)).EndInit();
      tabs.ResumeLayout(false);
      ResumeLayout(false);

    }

    #endregion

    private Button exportButton;
    private TabControl tabs;
    private TabPage currentProfilePicturePage;
    private PictureBox currentProfilePicture;
    private TabPage currentProfileIconPage;
    private PictureBox currentProfileIcon;
    private TabPage initialProfilePicturePage;
    private PictureBox initialProfilePicture;
    private TabPage initialProfileIconPage;
    private PictureBox initialProfileIcon;
    private Button importCurrentProfilePictureButton;
    private Button importCurrentProfileIconButton;
    private Button importInitialProfilePictureButton;
    private Button importInitialProfileIconButton;
  }
}
