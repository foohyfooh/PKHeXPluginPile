namespace PluginPile.TeamViewer {
  partial class TeamsForm {
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
      Team1Box = new GroupBox();
      Team2Box = new GroupBox();
      Team3Box = new GroupBox();
      Team4Box = new GroupBox();
      Team5Box = new GroupBox();
      Team6Box = new GroupBox();
      SuspendLayout();
      //
      // Team1Box
      //
      Team1Box.Location = new Point(15, 15);
      Team1Box.Name = "Team1Box";
      Team1Box.Size = new Size(485, 150);
      Team1Box.TabIndex = 0;
      Team1Box.TabStop = false;
      Team1Box.Text = "Team 1";
      //
      // Team2Box
      //
      Team2Box.Location = new Point(15, 170);
      Team2Box.Name = "Team2Box";
      Team2Box.Size = new Size(485, 150);
      Team2Box.TabIndex = 1;
      Team2Box.TabStop = false;
      Team2Box.Text = "Team 2";
      //
      // Team3Box
      //
      Team3Box.Location = new Point(15, 325);
      Team3Box.Name = "Team3Box";
      Team3Box.Size = new Size(485, 150);
      Team3Box.TabIndex = 2;
      Team3Box.TabStop = false;
      Team3Box.Text = "Team 3";
      //
      // Team4Box
      //
      Team4Box.Location = new Point(15, 475);
      Team4Box.Name = "Team4Box";
      Team4Box.Size = new Size(485, 150);
      Team4Box.TabIndex = 3;
      Team4Box.TabStop = false;
      Team4Box.Text = "Team 4";
      //
      // Team5Box
      //
      Team5Box.Location = new Point(15, 630);
      Team5Box.Name = "Team5Box";
      Team5Box.Size = new Size(485, 150);
      Team5Box.TabIndex = 4;
      Team5Box.TabStop = false;
      Team5Box.Text = "Team 5";
      //
      // Team6Box
      //
      Team6Box.Location = new Point(17, 785);
      Team6Box.Name = "Team6Box";
      Team6Box.Size = new Size(485, 150);
      Team6Box.TabIndex = 5;
      Team6Box.TabStop = false;
      Team6Box.Text = "Team 6";
      //
      // TeamsForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(514, 941);
      Controls.Add(Team6Box);
      Controls.Add(Team5Box);
      Controls.Add(Team4Box);
      Controls.Add(Team3Box);
      Controls.Add(Team2Box);
      Controls.Add(Team1Box);
      MaximizeBox = false;
      Name = "TeamsForm";
      ShowIcon = false;
      Text = "Teams";
      ResumeLayout(false);
    }

    #endregion

    private GroupBox Team1Box;
    private GroupBox Team2Box;
    private GroupBox Team3Box;
    private GroupBox Team4Box;
    private GroupBox Team5Box;
    private GroupBox Team6Box;
  }
}
