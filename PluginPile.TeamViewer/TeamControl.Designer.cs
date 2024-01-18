namespace PluginPile.TeamViewer {
  partial class TeamControl {
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
      Pokemon1Image = new PictureBox();
      Pokemon2Image = new PictureBox();
      Pokemon3Image = new PictureBox();
      Pokemon4Image = new PictureBox();
      Pokemon5Image = new PictureBox();
      Pokemon6Image = new PictureBox();
      TeamName = new Label();
      TeamInfo = new Label();
      CopyToBox = new Button();
      CopyToParty = new Button();
      CopyPaste = new Button();
      ((System.ComponentModel.ISupportInitialize)Pokemon1Image).BeginInit();
      ((System.ComponentModel.ISupportInitialize)Pokemon2Image).BeginInit();
      ((System.ComponentModel.ISupportInitialize)Pokemon3Image).BeginInit();
      ((System.ComponentModel.ISupportInitialize)Pokemon4Image).BeginInit();
      ((System.ComponentModel.ISupportInitialize)Pokemon5Image).BeginInit();
      ((System.ComponentModel.ISupportInitialize)Pokemon6Image).BeginInit();
      SuspendLayout();
      //
      // Pokemon1Image
      //
      Pokemon1Image.Location = new Point(5, 65);
      Pokemon1Image.Name = "Pokemon1Image";
      Pokemon1Image.Size = new Size(75, 75);
      Pokemon1Image.TabIndex = 2;
      Pokemon1Image.TabStop = false;
      //
      // Pokemon2Image
      //
      Pokemon2Image.Location = new Point(85, 65);
      Pokemon2Image.Name = "Pokemon2Image";
      Pokemon2Image.Size = new Size(75, 75);
      Pokemon2Image.TabIndex = 3;
      Pokemon2Image.TabStop = false;
      //
      // Pokemon3Image
      //
      Pokemon3Image.Location = new Point(165, 65);
      Pokemon3Image.Name = "Pokemon3Image";
      Pokemon3Image.Size = new Size(75, 75);
      Pokemon3Image.TabIndex = 4;
      Pokemon3Image.TabStop = false;
      //
      // Pokemon4Image
      //
      Pokemon4Image.Location = new Point(245, 65);
      Pokemon4Image.Name = "Pokemon4Image";
      Pokemon4Image.Size = new Size(75, 75);
      Pokemon4Image.TabIndex = 5;
      Pokemon4Image.TabStop = false;
      //
      // Pokemon5Image
      //
      Pokemon5Image.Location = new Point(325, 65);
      Pokemon5Image.Name = "Pokemon5Image";
      Pokemon5Image.Size = new Size(75, 75);
      Pokemon5Image.TabIndex = 6;
      Pokemon5Image.TabStop = false;
      //
      // Pokemon6Image
      //
      Pokemon6Image.Location = new Point(405, 65);
      Pokemon6Image.Name = "Pokemon6Image";
      Pokemon6Image.Size = new Size(75, 75);
      Pokemon6Image.TabIndex = 7;
      Pokemon6Image.TabStop = false;
      //
      // TeamName
      //
      TeamName.AutoSize = true;
      TeamName.Location = new Point(5, 20);
      TeamName.Name = "TeamName";
      TeamName.Size = new Size(70, 15);
      TeamName.TabIndex = 0;
      TeamName.Text = "Team Name";
      //
      // TeamInfo
      //
      TeamInfo.AutoSize = true;
      TeamInfo.Location = new Point(5, 45);
      TeamInfo.Name = "TeamInfo";
      TeamInfo.Size = new Size(145, 15);
      TeamInfo.TabIndex = 1;
      TeamInfo.Text = "Team Creator | Team Code";
      //
      // CopyToBox
      //
      CopyToBox.Location = new Point(325, 8);
      CopyToBox.Name = "CopyToBox";
      CopyToBox.Size = new Size(155, 23);
      CopyToBox.TabIndex = 9;
      CopyToBox.Text = "Copy To Box";
      CopyToBox.UseVisualStyleBackColor = true;
      CopyToBox.Click += CopyToBox_Click;
      //
      // CopyToParty
      //
      CopyToParty.Location = new Point(325, 37);
      CopyToParty.Name = "CopyToParty";
      CopyToParty.Size = new Size(155, 23);
      CopyToParty.TabIndex = 10;
      CopyToParty.Text = "Copy To Party";
      CopyToParty.UseVisualStyleBackColor = true;
      CopyToParty.Click += CopyToParty_Click;
      //
      // CopyPaste
      //
      CopyPaste.Location = new Point(165, 8);
      CopyPaste.Name = "CopyPaste";
      CopyPaste.Size = new Size(155, 23);
      CopyPaste.TabIndex = 8;
      CopyPaste.Text = "Copy Paste";
      CopyPaste.UseVisualStyleBackColor = true;
      CopyPaste.Click += CopyPaste_Click;
      //
      // RentalTeamControl
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(CopyPaste);
      Controls.Add(CopyToParty);
      Controls.Add(CopyToBox);
      Controls.Add(TeamInfo);
      Controls.Add(TeamName);
      Controls.Add(Pokemon6Image);
      Controls.Add(Pokemon5Image);
      Controls.Add(Pokemon4Image);
      Controls.Add(Pokemon3Image);
      Controls.Add(Pokemon2Image);
      Controls.Add(Pokemon1Image);
      Name = "RentalTeamControl";
      Size = new Size(485, 150);
      ((System.ComponentModel.ISupportInitialize)Pokemon1Image).EndInit();
      ((System.ComponentModel.ISupportInitialize)Pokemon2Image).EndInit();
      ((System.ComponentModel.ISupportInitialize)Pokemon3Image).EndInit();
      ((System.ComponentModel.ISupportInitialize)Pokemon4Image).EndInit();
      ((System.ComponentModel.ISupportInitialize)Pokemon5Image).EndInit();
      ((System.ComponentModel.ISupportInitialize)Pokemon6Image).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label TeamName;
    private Label TeamInfo;
    private PictureBox Pokemon1Image;
    private PictureBox Pokemon2Image;
    private PictureBox Pokemon3Image;
    private PictureBox Pokemon4Image;
    private PictureBox Pokemon5Image;
    private PictureBox Pokemon6Image;
    private Button CopyToBox;
    private Button CopyToParty;
    private Button CopyPaste;
  }
}
