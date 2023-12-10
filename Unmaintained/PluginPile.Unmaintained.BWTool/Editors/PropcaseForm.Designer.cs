namespace PluginPile.Unmaintained.BWTool {
  partial class PropcaseForm {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent() {
      Proplist = new ComboBox();
      HasPropCheckbox = new CheckBox();
      unloackAllBut = new Button();
      HexValueLabel = new Label();
      PropHex = new Label();
      ExitButton = new Button();
      SaveExitButton = new Button();
      SpriteBox = new PictureBox();
      RemoveAllBut = new Button();
      ((System.ComponentModel.ISupportInitialize)SpriteBox).BeginInit();
      SuspendLayout();
      //
      // Proplist
      //
      Proplist.FormattingEnabled = true;
      Proplist.Items.AddRange(new object[] { "Pink Barrette", "Blue Barrette", "Red Barrette", "Blue Flower", "Crimson Scarf", "Red Flower", "Big Barrette", "Headband", "Square Glasses", "Striped Barrette", "Small Barrette", "Decorative Ribbon", "Purse", "Necklace", "Gorgeous Flower", "Round Button", "Green Barrette", "Straw Hat", "Snow Crystal", "Lonely Flower", "Paintbrush", "Beret", "Whisk", "Ladle", "Toy Cake", "Chef's Hat", "Frying Pan", "Bib", "Red Parasol", "Germ Mask", "Mallet", "Colorful Parasol", "Wrench", "Lantern", "Windup Key", "Helmet", "Frilly Apron", "Dressy Tie", "Lace Cap", "Scarlet Cape", "Toy Cutlass", "Toy Sword", "Pirate Hat", "Cowboy Hat", "Rigid Shield", "Black Wings", "Witchy Hat", "White Wings", "Umber Belt", "Horned Helm", "Trident", "Magic Wand", "Red Nose", "Jester's Cap", "Googly Specs", "Crown", "Black Tie", "Black Cape", "Gorgeous Specs", "Top Hat", "White Domino Mask", "White Cape", "Gentleman's Hat", "Cane", "Striped Tie", "Pocket Watch", "Bowtie", "Tiara", "Rose", "Monocle", "Tie", "Wig", "Standing Mike", "Tambourine", "Fedora", "Microphone", "Maraca", "Trumpet", "Laurel Wreath", "White Pompom", "Pennant", "Football", "Winner's Belt", "Racket", "Electric Guitar", "Toy Fishing Rod", "Smiley-Face Mask", "Fake Belly Button", "Professor Hat", "Hula Skirt", "Thick Book", "Bouquet", "Fake Bone", "Round Mushroom", "Shuriken", "Scarlet Hat", "Big Bag", "Candy", "Fluffy Beard", "Gift Box" });
      Proplist.Location = new Point(30, 32);
      Proplist.Margin = new Padding(4, 3, 4, 3);
      Proplist.Name = "Proplist";
      Proplist.Size = new Size(140, 23);
      Proplist.TabIndex = 0;
      Proplist.SelectedIndexChanged += ProplistSelectedIndexChanged;
      //
      // HasPropCheckbox
      //
      HasPropCheckbox.Location = new Point(196, 32);
      HasPropCheckbox.Margin = new Padding(4, 3, 4, 3);
      HasPropCheckbox.Name = "HasPropCheckbox";
      HasPropCheckbox.Size = new Size(121, 28);
      HasPropCheckbox.TabIndex = 1;
      HasPropCheckbox.Text = "Obtained";
      HasPropCheckbox.UseVisualStyleBackColor = true;
      HasPropCheckbox.CheckedChanged += Hasprop_checkboxCheckedChanged;
      //
      // unloackAllBut
      //
      unloackAllBut.Location = new Point(30, 78);
      unloackAllBut.Margin = new Padding(4, 3, 4, 3);
      unloackAllBut.Name = "unloackAllBut";
      unloackAllBut.Size = new Size(119, 27);
      unloackAllBut.TabIndex = 2;
      unloackAllBut.Text = "Unlock all";
      unloackAllBut.UseVisualStyleBackColor = true;
      unloackAllBut.Click += UnlockAllButClick;
      //
      // HexValueLabel
      //
      HexValueLabel.Location = new Point(30, 108);
      HexValueLabel.Margin = new Padding(4, 0, 4, 0);
      HexValueLabel.Name = "HexValueLabel";
      HexValueLabel.Size = new Size(117, 27);
      HexValueLabel.TabIndex = 3;
      HexValueLabel.Text = "Hex value:";
      //
      // PropHex
      //
      PropHex.Location = new Point(108, 108);
      PropHex.Margin = new Padding(4, 0, 4, 0);
      PropHex.Name = "PropHex";
      PropHex.Size = new Size(338, 27);
      PropHex.TabIndex = 4;
      PropHex.Text = "0x";
      //
      // ExitButton
      //
      ExitButton.Location = new Point(30, 128);
      ExitButton.Margin = new Padding(4, 3, 4, 3);
      ExitButton.Name = "ExitButton";
      ExitButton.Size = new Size(119, 27);
      ExitButton.TabIndex = 21;
      ExitButton.Text = "Exit";
      ExitButton.UseVisualStyleBackColor = true;
      ExitButton.Click += Exit_butClick;
      //
      // SaveExitButton
      //
      SaveExitButton.Location = new Point(155, 128);
      SaveExitButton.Margin = new Padding(4, 3, 4, 3);
      SaveExitButton.Name = "SaveExitButton";
      SaveExitButton.Size = new Size(119, 27);
      SaveExitButton.TabIndex = 20;
      SaveExitButton.Text = "Save and Exit";
      SaveExitButton.UseVisualStyleBackColor = true;
      SaveExitButton.Click += Saveexit_butClick;
      //
      // SpriteBox
      //
      SpriteBox.Location = new Point(296, 21);
      SpriteBox.Margin = new Padding(4, 3, 4, 3);
      SpriteBox.Name = "SpriteBox";
      SpriteBox.Size = new Size(129, 73);
      SpriteBox.SizeMode = PictureBoxSizeMode.AutoSize;
      SpriteBox.TabIndex = 22;
      SpriteBox.TabStop = false;
      //
      // RemoveAllBut
      //
      RemoveAllBut.Location = new Point(155, 78);
      RemoveAllBut.Margin = new Padding(4, 3, 4, 3);
      RemoveAllBut.Name = "RemoveAllBut";
      RemoveAllBut.Size = new Size(119, 27);
      RemoveAllBut.TabIndex = 23;
      RemoveAllBut.Text = "Remove all";
      RemoveAllBut.UseVisualStyleBackColor = true;
      RemoveAllBut.Click += RemoveAllButClick;
      //
      // PropcaseForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(458, 163);
      Controls.Add(RemoveAllBut);
      Controls.Add(unloackAllBut);
      Controls.Add(SpriteBox);
      Controls.Add(ExitButton);
      Controls.Add(SaveExitButton);
      Controls.Add(PropHex);
      Controls.Add(HexValueLabel);
      Controls.Add(HasPropCheckbox);
      Controls.Add(Proplist);
      Margin = new Padding(4, 3, 4, 3);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "PropcaseForm";
      Text = "Props Case Editor";
      ((System.ComponentModel.ISupportInitialize)SpriteBox).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private System.Windows.Forms.Button RemoveAllBut;
    private System.Windows.Forms.PictureBox SpriteBox;
    private System.Windows.Forms.Button SaveExitButton;
    private System.Windows.Forms.Button ExitButton;
    private System.Windows.Forms.Label PropHex;
    private System.Windows.Forms.Label HexValueLabel;
    private System.Windows.Forms.Button unloackAllBut;
    private System.Windows.Forms.CheckBox HasPropCheckbox;
    private System.Windows.Forms.ComboBox Proplist;
  }
}
