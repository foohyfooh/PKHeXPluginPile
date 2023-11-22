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
      hasprop_checkbox = new CheckBox();
      unloackAllBut = new Button();
      label1 = new Label();
      propHex = new Label();
      Exit_but = new Button();
      Saveexit_but = new Button();
      spriteBox = new PictureBox();
      removeAllBut = new Button();
      ((System.ComponentModel.ISupportInitialize)spriteBox).BeginInit();
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
      // hasprop_checkbox
      //
      hasprop_checkbox.Location = new Point(196, 32);
      hasprop_checkbox.Margin = new Padding(4, 3, 4, 3);
      hasprop_checkbox.Name = "hasprop_checkbox";
      hasprop_checkbox.Size = new Size(121, 28);
      hasprop_checkbox.TabIndex = 1;
      hasprop_checkbox.Text = "Obtained";
      hasprop_checkbox.UseVisualStyleBackColor = true;
      hasprop_checkbox.CheckedChanged += Hasprop_checkboxCheckedChanged;
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
      // label1
      //
      label1.Location = new Point(30, 108);
      label1.Margin = new Padding(4, 0, 4, 0);
      label1.Name = "label1";
      label1.Size = new Size(117, 27);
      label1.TabIndex = 3;
      label1.Text = "Hex value:";
      //
      // propHex
      //
      propHex.Location = new Point(108, 108);
      propHex.Margin = new Padding(4, 0, 4, 0);
      propHex.Name = "propHex";
      propHex.Size = new Size(338, 27);
      propHex.TabIndex = 4;
      propHex.Text = "0x";
      //
      // Exit_but
      //
      Exit_but.Location = new Point(30, 128);
      Exit_but.Margin = new Padding(4, 3, 4, 3);
      Exit_but.Name = "Exit_but";
      Exit_but.Size = new Size(119, 27);
      Exit_but.TabIndex = 21;
      Exit_but.Text = "Exit";
      Exit_but.UseVisualStyleBackColor = true;
      Exit_but.Click += Exit_butClick;
      //
      // Saveexit_but
      //
      Saveexit_but.Location = new Point(155, 128);
      Saveexit_but.Margin = new Padding(4, 3, 4, 3);
      Saveexit_but.Name = "Saveexit_but";
      Saveexit_but.Size = new Size(119, 27);
      Saveexit_but.TabIndex = 20;
      Saveexit_but.Text = "Save and Exit";
      Saveexit_but.UseVisualStyleBackColor = true;
      Saveexit_but.Click += Saveexit_butClick;
      //
      // spriteBox
      //
      spriteBox.Location = new Point(296, 21);
      spriteBox.Margin = new Padding(4, 3, 4, 3);
      spriteBox.Name = "spriteBox";
      spriteBox.Size = new Size(129, 73);
      spriteBox.SizeMode = PictureBoxSizeMode.AutoSize;
      spriteBox.TabIndex = 22;
      spriteBox.TabStop = false;
      //
      // removeAllBut
      //
      removeAllBut.Location = new Point(155, 78);
      removeAllBut.Margin = new Padding(4, 3, 4, 3);
      removeAllBut.Name = "removeAllBut";
      removeAllBut.Size = new Size(119, 27);
      removeAllBut.TabIndex = 23;
      removeAllBut.Text = "Remove all";
      removeAllBut.UseVisualStyleBackColor = true;
      removeAllBut.Click += RemoveAllButClick;
      //
      // PropcaseForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(458, 163);
      Controls.Add(removeAllBut);
      Controls.Add(unloackAllBut);
      Controls.Add(spriteBox);
      Controls.Add(Exit_but);
      Controls.Add(Saveexit_but);
      Controls.Add(propHex);
      Controls.Add(label1);
      Controls.Add(hasprop_checkbox);
      Controls.Add(Proplist);
      Margin = new Padding(4, 3, 4, 3);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "PropcaseForm";
      Text = "Props Case Editor";
      ((System.ComponentModel.ISupportInitialize)spriteBox).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private System.Windows.Forms.Button removeAllBut;
    private System.Windows.Forms.PictureBox spriteBox;
    private System.Windows.Forms.Button Saveexit_but;
    private System.Windows.Forms.Button Exit_but;
    private System.Windows.Forms.Label propHex;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button unloackAllBut;
    private System.Windows.Forms.CheckBox hasprop_checkbox;
    private System.Windows.Forms.ComboBox Proplist;
  }
}
