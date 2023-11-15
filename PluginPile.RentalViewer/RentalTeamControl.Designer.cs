namespace PluginPile.RentalViewer {
  partial class RentalTeamControl {
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
      pokemon1Image = new PictureBox();
      pokemon2Image = new PictureBox();
      pokemon3Image = new PictureBox();
      pokemon4Image = new PictureBox();
      pokemon5Image = new PictureBox();
      pokemon6Image = new PictureBox();
      teamName = new Label();
      teamInfo = new Label();
      BoxCopy = new Button();
      PartyCopy = new Button();
      ((System.ComponentModel.ISupportInitialize)pokemon1Image).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pokemon2Image).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pokemon3Image).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pokemon4Image).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pokemon5Image).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pokemon6Image).BeginInit();
      SuspendLayout();
      //
      // pokemon1Image
      //
      pokemon1Image.Location = new Point(5, 65);
      pokemon1Image.Name = "pokemon1Image";
      pokemon1Image.Size = new Size(75, 75);
      pokemon1Image.TabIndex = 2;
      pokemon1Image.TabStop = false;
      //
      // pokemon2Image
      //
      pokemon2Image.Location = new Point(85, 65);
      pokemon2Image.Name = "pokemon2Image";
      pokemon2Image.Size = new Size(75, 75);
      pokemon2Image.TabIndex = 3;
      pokemon2Image.TabStop = false;
      //
      // pokemon3Image
      //
      pokemon3Image.Location = new Point(165, 65);
      pokemon3Image.Name = "pokemon3Image";
      pokemon3Image.Size = new Size(75, 75);
      pokemon3Image.TabIndex = 4;
      pokemon3Image.TabStop = false;
      //
      // pokemon4Image
      //
      pokemon4Image.Location = new Point(245, 65);
      pokemon4Image.Name = "pokemon4Image";
      pokemon4Image.Size = new Size(75, 75);
      pokemon4Image.TabIndex = 5;
      pokemon4Image.TabStop = false;
      //
      // pokemon5Image
      //
      pokemon5Image.Location = new Point(325, 65);
      pokemon5Image.Name = "pokemon5Image";
      pokemon5Image.Size = new Size(75, 75);
      pokemon5Image.TabIndex = 6;
      pokemon5Image.TabStop = false;
      //
      // pokemon6Image
      //
      pokemon6Image.Location = new Point(405, 65);
      pokemon6Image.Name = "pokemon6Image";
      pokemon6Image.Size = new Size(75, 75);
      pokemon6Image.TabIndex = 7;
      pokemon6Image.TabStop = false;
      //
      // teamName
      //
      teamName.AutoSize = true;
      teamName.Location = new Point(5, 20);
      teamName.Name = "teamName";
      teamName.Size = new Size(70, 15);
      teamName.TabIndex = 0;
      teamName.Text = "Team Name";
      //
      // teamInfo
      //
      teamInfo.AutoSize = true;
      teamInfo.Location = new Point(5, 45);
      teamInfo.Name = "teamInfo";
      teamInfo.Size = new Size(145, 15);
      teamInfo.TabIndex = 1;
      teamInfo.Text = "Team Creator | Team Code";
      //
      // BoxCopy
      //
      BoxCopy.Location = new Point(165, 16);
      BoxCopy.Name = "BoxCopy";
      BoxCopy.Size = new Size(155, 23);
      BoxCopy.TabIndex = 8;
      BoxCopy.Text = "Box Copy";
      BoxCopy.UseVisualStyleBackColor = true;
      BoxCopy.Click += BoxCopy_Click;
      //
      // PartyCopy
      //
      PartyCopy.Location = new Point(325, 16);
      PartyCopy.Name = "PartyCopy";
      PartyCopy.Size = new Size(155, 23);
      PartyCopy.TabIndex = 9;
      PartyCopy.Text = "Party Copy";
      PartyCopy.UseVisualStyleBackColor = true;
      PartyCopy.Click += PartyCopy_Click;
      //
      // RentalTeamControl
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(PartyCopy);
      Controls.Add(BoxCopy);
      Controls.Add(teamInfo);
      Controls.Add(teamName);
      Controls.Add(pokemon6Image);
      Controls.Add(pokemon5Image);
      Controls.Add(pokemon4Image);
      Controls.Add(pokemon3Image);
      Controls.Add(pokemon2Image);
      Controls.Add(pokemon1Image);
      Name = "RentalTeamControl";
      Size = new Size(485, 150);
      ((System.ComponentModel.ISupportInitialize)pokemon1Image).EndInit();
      ((System.ComponentModel.ISupportInitialize)pokemon2Image).EndInit();
      ((System.ComponentModel.ISupportInitialize)pokemon3Image).EndInit();
      ((System.ComponentModel.ISupportInitialize)pokemon4Image).EndInit();
      ((System.ComponentModel.ISupportInitialize)pokemon5Image).EndInit();
      ((System.ComponentModel.ISupportInitialize)pokemon6Image).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label teamName;
    private Label teamInfo;
    private PictureBox pokemon1Image;
    private PictureBox pokemon2Image;
    private PictureBox pokemon3Image;
    private PictureBox pokemon4Image;
    private PictureBox pokemon5Image;
    private PictureBox pokemon6Image;
    private Button BoxCopy;
    private Button PartyCopy;
  }
}
