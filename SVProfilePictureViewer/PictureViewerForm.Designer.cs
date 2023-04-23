namespace PluginPile.SVProfilePictureViewer
{
  partial class PictureViewerForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
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
      importButtonP = new Button();
      importButtonI = new Button();
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
      currentProfilePicturePage.Location = new Point(4, 29);
      currentProfilePicturePage.Margin = new Padding(3, 4, 3, 4);
      currentProfilePicturePage.Name = "currentProfilePicturePage";
      currentProfilePicturePage.Padding = new Padding(3, 4, 3, 4);
      currentProfilePicturePage.Size = new Size(566, 332);
      currentProfilePicturePage.TabIndex = 0;
      currentProfilePicturePage.Text = "Current Profile Picture";
      currentProfilePicturePage.UseVisualStyleBackColor = true;
      // 
      // currentProfilePicture
      // 
      currentProfilePicture.Location = new Point(7, 8);
      currentProfilePicture.Margin = new Padding(3, 4, 3, 4);
      currentProfilePicture.Name = "currentProfilePicture";
      currentProfilePicture.Size = new Size(411, 288);
      currentProfilePicture.TabIndex = 0;
      currentProfilePicture.TabStop = false;
      // 
      // currentProfileIconPage
      // 
      currentProfileIconPage.Controls.Add(currentProfileIcon);
      currentProfileIconPage.Location = new Point(4, 29);
      currentProfileIconPage.Margin = new Padding(3, 4, 3, 4);
      currentProfileIconPage.Name = "currentProfileIconPage";
      currentProfileIconPage.Padding = new Padding(3, 4, 3, 4);
      currentProfileIconPage.Size = new Size(566, 332);
      currentProfileIconPage.TabIndex = 1;
      currentProfileIconPage.Text = "Current Profile Icon";
      currentProfileIconPage.UseVisualStyleBackColor = true;
      // 
      // currentProfileIcon
      // 
      currentProfileIcon.Location = new Point(7, 8);
      currentProfileIcon.Margin = new Padding(3, 4, 3, 4);
      currentProfileIcon.Name = "currentProfileIcon";
      currentProfileIcon.Size = new Size(411, 288);
      currentProfileIcon.TabIndex = 1;
      currentProfileIcon.TabStop = false;
      // 
      // initialProfilePicturePage
      // 
      initialProfilePicturePage.Controls.Add(initialProfilePicture);
      initialProfilePicturePage.Location = new Point(4, 29);
      initialProfilePicturePage.Margin = new Padding(3, 4, 3, 4);
      initialProfilePicturePage.Name = "initialProfilePicturePage";
      initialProfilePicturePage.Size = new Size(566, 332);
      initialProfilePicturePage.TabIndex = 2;
      initialProfilePicturePage.Text = "Initial Profile Picture";
      initialProfilePicturePage.UseVisualStyleBackColor = true;
      // 
      // initialProfilePicture
      // 
      initialProfilePicture.Location = new Point(7, 8);
      initialProfilePicture.Margin = new Padding(3, 4, 3, 4);
      initialProfilePicture.Name = "initialProfilePicture";
      initialProfilePicture.Size = new Size(411, 288);
      initialProfilePicture.TabIndex = 2;
      initialProfilePicture.TabStop = false;
      // 
      // initialProfileIconPage
      // 
      initialProfileIconPage.Controls.Add(initialProfileIcon);
      initialProfileIconPage.Location = new Point(4, 29);
      initialProfileIconPage.Margin = new Padding(3, 4, 3, 4);
      initialProfileIconPage.Name = "initialProfileIconPage";
      initialProfileIconPage.Size = new Size(566, 332);
      initialProfileIconPage.TabIndex = 3;
      initialProfileIconPage.Text = "Initial Profile Icon";
      initialProfileIconPage.UseVisualStyleBackColor = true;
      // 
      // initialProfileIcon
      // 
      initialProfileIcon.Location = new Point(7, 8);
      initialProfileIcon.Margin = new Padding(3, 4, 3, 4);
      initialProfileIcon.Name = "initialProfileIcon";
      initialProfileIcon.Size = new Size(411, 288);
      initialProfileIcon.TabIndex = 3;
      initialProfileIcon.TabStop = false;
      // 
      // saveButton
      // 
      saveButton.Location = new Point(14, 389);
      saveButton.Margin = new Padding(3, 4, 3, 4);
      saveButton.Name = "saveButton";
      saveButton.Size = new Size(86, 31);
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
      tabs.Location = new Point(14, 16);
      tabs.Margin = new Padding(3, 4, 3, 4);
      tabs.Name = "tabs";
      tabs.SelectedIndex = 0;
      tabs.Size = new Size(574, 365);
      tabs.TabIndex = 1;
      // 
      // importButtonP
      // 
      importButtonP.Location = new Point(360, 389);
      importButtonP.Margin = new Padding(3, 4, 3, 4);
      importButtonP.Name = "importButtonP";
      importButtonP.Size = new Size(109, 31);
      importButtonP.TabIndex = 2;
      importButtonP.Text = "Import Photo";
      importButtonP.UseVisualStyleBackColor = true;
      importButtonP.Click += importButtonP_Click;
      // 
      // importButtonI
      // 
      importButtonI.Location = new Point(475, 389);
      importButtonI.Margin = new Padding(3, 4, 3, 4);
      importButtonI.Name = "importButtonI";
      importButtonI.Size = new Size(109, 31);
      importButtonI.TabIndex = 3;
      importButtonI.Text = "Import Icon";
      importButtonI.UseVisualStyleBackColor = true;
      importButtonI.Click += importButtonI_Click;
      // 
      // PictureViewerForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(599, 441);
      Controls.Add(importButtonI);
      Controls.Add(importButtonP);
      Controls.Add(tabs);
      Controls.Add(saveButton);
      Margin = new Padding(3, 4, 3, 4);
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
    private Button importButtonP;
    private Button importButtonI;
  }
}
