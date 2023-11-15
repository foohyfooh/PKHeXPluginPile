namespace PluginPile.RentalViewer {
  partial class RentalTeamsForm {
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
      team1Box = new GroupBox();
      team2Box = new GroupBox();
      team3Box = new GroupBox();
      team4Box = new GroupBox();
      team5Box = new GroupBox();
      SuspendLayout();
      //
      // team1Box
      //
      team1Box.Location = new Point(15, 15);
      team1Box.Name = "team1Box";
      team1Box.Size = new Size(485, 150);
      team1Box.TabIndex = 0;
      team1Box.TabStop = false;
      team1Box.Text = "Team 1";
      //
      // team2Box
      //
      team2Box.Location = new Point(15, 170);
      team2Box.Name = "team2Box";
      team2Box.Size = new Size(485, 150);
      team2Box.TabIndex = 1;
      team2Box.TabStop = false;
      team2Box.Text = "Team 2";
      //
      // team3Box
      //
      team3Box.Location = new Point(15, 326);
      team3Box.Name = "team3Box";
      team3Box.Size = new Size(485, 150);
      team3Box.TabIndex = 2;
      team3Box.TabStop = false;
      team3Box.Text = "Team 3";
      //
      // team4Box
      //
      team4Box.Location = new Point(15, 482);
      team4Box.Name = "team4Box";
      team4Box.Size = new Size(485, 150);
      team4Box.TabIndex = 2;
      team4Box.TabStop = false;
      team4Box.Text = "Team 4";
      //
      // team5Box
      //
      team5Box.Location = new Point(15, 638);
      team5Box.Name = "team5Box";
      team5Box.Size = new Size(485, 150);
      team5Box.TabIndex = 2;
      team5Box.TabStop = false;
      team5Box.Text = "Team 5";
      //
      // RentalTeamsForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(514, 811);
      Controls.Add(team5Box);
      Controls.Add(team4Box);
      Controls.Add(team3Box);
      Controls.Add(team2Box);
      Controls.Add(team1Box);
      MaximizeBox = false;
      Name = "RentalTeamsForm";
      ShowIcon = false;
      Text = "Rental Teams";
      ResumeLayout(false);
    }

    #endregion

    private GroupBox team1Box;
    private GroupBox team2Box;
    private GroupBox team3Box;
    private GroupBox team4Box;
    private GroupBox team5Box;
  }
}
