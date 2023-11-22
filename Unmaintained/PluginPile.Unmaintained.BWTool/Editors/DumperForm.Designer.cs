namespace PluginPile.Unmaintained.BWTool {
  partial class DumperForm {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button dump_but;
    private System.Windows.Forms.Button inject_but;
    private System.Windows.Forms.Button dump_dec_but;
    private System.Windows.Forms.Button inject_crypt_but;
    private System.Windows.Forms.ComboBox selectedblock;
    private System.Windows.Forms.CheckBox crypt_check;
    private System.Windows.Forms.ComboBox BW_blocklist;

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
    private void InitializeComponent()
    {
      this.dump_but = new System.Windows.Forms.Button();
      this.inject_but = new System.Windows.Forms.Button();
      this.dump_dec_but = new System.Windows.Forms.Button();
      this.inject_crypt_but = new System.Windows.Forms.Button();
      this.selectedblock = new System.Windows.Forms.ComboBox();
      this.crypt_check = new System.Windows.Forms.CheckBox();
      this.BW_blocklist = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      //
      // dump_but
      //
      this.dump_but.Location = new System.Drawing.Point(254, 39);
      this.dump_but.Name = "dump_but";
      this.dump_but.Size = new System.Drawing.Size(75, 23);
      this.dump_but.TabIndex = 1;
      this.dump_but.Text = "Dump";
      this.dump_but.UseVisualStyleBackColor = true;
      this.dump_but.Click += new System.EventHandler(this.Dump_butClick);
      //
      // inject_but
      //
      this.inject_but.Location = new System.Drawing.Point(353, 39);
      this.inject_but.Name = "inject_but";
      this.inject_but.Size = new System.Drawing.Size(75, 23);
      this.inject_but.TabIndex = 2;
      this.inject_but.Text = "Inject";
      this.inject_but.UseVisualStyleBackColor = true;
      this.inject_but.Click += new System.EventHandler(this.Inject_butClick);
      //
      // dump_dec_but
      //
      this.dump_dec_but.Enabled = false;
      this.dump_dec_but.Location = new System.Drawing.Point(204, 68);
      this.dump_dec_but.Name = "dump_dec_but";
      this.dump_dec_but.Size = new System.Drawing.Size(125, 23);
      this.dump_dec_but.TabIndex = 3;
      this.dump_dec_but.Text = "Dump and Decrypt";
      this.dump_dec_but.UseVisualStyleBackColor = true;
      this.dump_dec_but.Click += new System.EventHandler(this.Dump_dec_butClick);
      //
      // inject_crypt_but
      //
      this.inject_crypt_but.Enabled = false;
      this.inject_crypt_but.Location = new System.Drawing.Point(353, 68);
      this.inject_crypt_but.Name = "inject_crypt_but";
      this.inject_crypt_but.Size = new System.Drawing.Size(125, 23);
      this.inject_crypt_but.TabIndex = 4;
      this.inject_crypt_but.Text = "Inject and Recrypt";
      this.inject_crypt_but.UseVisualStyleBackColor = true;
      this.inject_crypt_but.Click += new System.EventHandler(this.Inject_crypt_butClick);
      //
      // selectedblock
      //
      this.selectedblock.FormattingEnabled = true;
      this.selectedblock.Items.AddRange(new object[] {
      "00 - Box Names",
      "01 - Box 1",
      "02 - Box 2",
      "03 - Box 3",
      "04 - Box 4",
      "05 - Box 5",
      "06 - Box 6",
      "07 - Box 7",
      "08 - Box 8",
      "09 - Box 9",
      "10 - Box 10",
      "11 - Box 11",
      "12 - Box 12",
      "13 - Box 13",
      "14 - Box 14",
      "15 - Box 15",
      "16 - Box 16",
      "17 - Box 17",
      "18 - Box 18",
      "19 - Box 19",
      "20 - Box 20",
      "21 - Box 21",
      "22 - Box 22",
      "23 - Box 23",
      "24 - Box 24",
      "25 - Inventory",
      "26 - Party Pokemon",
      "27 - Trainer Data",
      "28 - Trainer Position",
      "29 - Unity Tower and survey stuff",
      "30 - Pal Pad Player Data (30d)",
      "31 - Pal Pad Friend Data",
      "32 - Options / Skin Info, C-Gear",
      "33 - Trainer Card",
      "34 - Mystery Gift",
      "35 - Dream World Stuff (Catalog)",
      "36 - Chatter",
      "37 - Adventure data",
      "38 - Trainer Card Records",
      "39 - ???",
      "40 - Mail (40d)",
      "41 - ???",
      "42 - Contains flags and references for downloaded data (Musical)",
      "43 - Fused Reshiram/Zekrom Storage",
      "44 - IR",
      "45 - Const Data Block and Event Flag Block (0x35E is the split)",
      "46 - ???",
      "47 - Tournament Block",
      "48 - Gimmick",
      "49 - Battle Box Block",
      "50 - Daycare Block (50d)",
      "51 - Strength Boulder Status Block",
      "52 - Badge Flags, Money, Trainer Sayings",
      "53 - Entralink (Level & Powers etc)",
      "54 - Pokedex",
      "55 - Swarm and other overworld info - 2C - swarm, 2D - repel steps, 2E repel type",
      "56 - Battle Subway Play Info",
      "57 - Battle Subway Score Info",
      "58 - Battle Subway WiFi Info",
      "59 - Online Records",
      "60 - Entralink Forest - encrypted (60d)",
      "61 - ???",
      "62 - ???",
      "63 - PWT related data",
      "64 - ???",
      "65 - ???",
      "66 - Hollow/Rival Block",
      "67 - Join Avenue Block",
      "68 - Medal data",
      "69 - Key-related data",
      "70 - Festa Missions (70d)",
      "71 - ???",
      "72 - 3DS Link related data",
      "73 - Checksum Block (73d)"});
      this.selectedblock.Location = new System.Drawing.Point(12, 12);
      this.selectedblock.MaxDropDownItems = 10;
      this.selectedblock.Name = "selectedblock";
      this.selectedblock.Size = new System.Drawing.Size(692, 21);
      this.selectedblock.TabIndex = 5;
      this.selectedblock.SelectedIndexChanged += new System.EventHandler(this.SelectedblockSelectedIndexChanged);
      //
      // crypt_check
      //
      this.crypt_check.AutoCheck = false;
      this.crypt_check.Location = new System.Drawing.Point(12, 38);
      this.crypt_check.Name = "crypt_check";
      this.crypt_check.Size = new System.Drawing.Size(104, 24);
      this.crypt_check.TabIndex = 6;
      this.crypt_check.Text = "Encripted";
      this.crypt_check.UseVisualStyleBackColor = true;
      this.crypt_check.CheckedChanged += new System.EventHandler(this.Crypt_checkCheckedChanged);
      //
      // BW_blocklist
      //
      this.BW_blocklist.FormattingEnabled = true;
      this.BW_blocklist.Items.AddRange(new object[] {
      "00 - Box Names",
      "01 - Box 1",
      "02 - Box 2",
      "03 - Box 3",
      "04 - Box 4",
      "05 - Box 5",
      "06 - Box 6",
      "07 - Box 7",
      "08 - Box 8",
      "09 - Box 9",
      "10 - Box 10",
      "11 - Box 11",
      "12 - Box 12",
      "13 - Box 13",
      "14 - Box 14",
      "15 - Box 15",
      "16 - Box 16",
      "17 - Box 17",
      "18 - Box 18",
      "19 - Box 19",
      "20 - Box 20",
      "21 - Box 21",
      "22 - Box 22",
      "23 - Box 23",
      "24 - Box 24",
      "25 - Inventory",
      "26 - Party Pokemon",
      "27 - Trainer Data",
      "28 - Trainer Position",
      "29 - Unity Tower and survey stuff",
      "30 - Pal Pad Player Data",
      "31 - Pal Pad Friend Data",
      "32 - Skin Info",
      "33 - ??? - Gym badge data",
      "34 - Mystert Gift",
      "35 - Dream World Stuff (Catalog)",
      "36 - Chatter",
      "37 - Adventure Info",
      "38 - Trainer Card Records",
      "39 - ???",
      "40 - ???",
      "41 - ???",
      "42 - Contains flags and references for downloaded data (Musical)",
      "43 - ???",
      "44 - ???",
      "45 - ???",
      "46 - ???",
      "47 - Tournament Block",
      "48 - ???",
      "49 - Battle Box Block",
      "50 - Daycare Block",
      "51 - Strength Boulder Status Block",
      "52 - Badge Flags, Money, Trainer Sayings",
      "53 - Entralink (Level & Powers etc)",
      "54 - ???",
      "55 - Pokedex",
      "56 - Swarm and other overworld info - 2C - swarm, 2D - repel steps, 2E repel type",
      "57 - ???",
      "58 - Battle Subway",
      "59 - ???",
      "60 - Online Records",
      "61 - Entralink Forest pokémon data",
      "62 - ???",
      "63 - ???",
      "64 - ???",
      "65 - ???",
      "66 - ???",
      "67 - ???",
      "68 - ???",
      "69 - Checksum Block (73d)"});
      this.BW_blocklist.Location = new System.Drawing.Point(12, 12);
      this.BW_blocklist.MaxDropDownItems = 10;
      this.BW_blocklist.Name = "BW_blocklist";
      this.BW_blocklist.Size = new System.Drawing.Size(692, 21);
      this.BW_blocklist.TabIndex = 7;
      this.BW_blocklist.SelectedIndexChanged += new System.EventHandler(this.BW_blocklistSelectedIndexChanged);
      //
      // Dumper
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(716, 103);
      this.Controls.Add(this.BW_blocklist);
      this.Controls.Add(this.crypt_check);
      this.Controls.Add(this.selectedblock);
      this.Controls.Add(this.inject_crypt_but);
      this.Controls.Add(this.dump_dec_but);
      this.Controls.Add(this.inject_but);
      this.Controls.Add(this.dump_but);
      this.Name = "Dumper";
      this.Text = "Block Dumper&Injector";
      this.ResumeLayout(false);

    }
  }
}
