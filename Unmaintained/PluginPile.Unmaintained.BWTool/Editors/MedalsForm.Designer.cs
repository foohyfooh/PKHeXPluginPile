namespace PluginPile.Unmaintained.BWTool {
  partial class MedalsForm {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox indexbox;
    private System.Windows.Forms.Button exit_but;
    private System.Windows.Forms.Button saveexit_but;
    private System.Windows.Forms.CheckBox unreadFlag;
    private System.Windows.Forms.DateTimePicker medal_date;
    private System.Windows.Forms.CheckBox obtained;
    private System.Windows.Forms.Panel red_panel;
    private System.Windows.Forms.Button delete_but;
    private System.Windows.Forms.TextBox date_hex;
    private System.Windows.Forms.TextBox flag_hex;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox medalState;

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
    private void InitializeComponent() {
      indexbox = new ComboBox();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      unreadFlag = new CheckBox();
      medal_date = new DateTimePicker();
      obtained = new CheckBox();
      red_panel = new Panel();
      delete_but = new Button();
      date_hex = new TextBox();
      flag_hex = new TextBox();
      label4 = new Label();
      label5 = new Label();
      exit_but = new Button();
      saveexit_but = new Button();
      medalState = new ComboBox();
      SuspendLayout();
      //
      // indexbox
      //
      indexbox.FormattingEnabled = true;
      indexbox.Items.AddRange(new object[] { " ======= Special Medaling medals =======", "000 - First Step", "001 - Participation Prize", "002 - Rookie Medalist", "003 - Elite Medalist", "004 - Master Medalist", "005 - Legend Medalist", "006 - Top Medalist", "======= Adventure Medal =======", "007 - Light Walker", "008 - Middle Walker", "009 - Heavy Walker", "010 - Honored Footprints", "011 - Step-by-Step Saver", "012 - Busy Saver", "013 - Experienced Saver", "014 - Wonder Writer", "015 - Pokémon Center Fan", "016 - Signboard Starter", "017 - Signboard Savvy", "018 - Graffiti Gazer", "019 - Starter Cycling", "020 - Easy Cycling", "021 - Hard Cycling", "022 - Pedaling Legend", "023 - Old Rod Fisherman", "024 - Good Rod Fisherman", "025 - Super Rod Fisherman", "026 - Mighty Fisher", "027 - Normal-type Catcher", "028 - Fire-type Catcher", "029 - Water-type Catcher", "030 - Electric-type Catcher", "031 - Grass-type Catcher", "032 - Ice-type Catcher", "033 - Fighting-type Catcher", "034 - Poison-type Catcher", "035 - Ground-type Catcher", "036 - Flying-type Catcher", "037 - Psychic-type Catcher", "038 - Bug-type Catcher", "039 - Rock-type Catcher", "040 - Ghost-type Catcher", "041 - Dragon-type Catcher", "042 - Dark-type Catcher", "043 - Steel-type Catcher", "044 - Unova Catcher", "045 - National Catcher", "046 - 30 Boxed", "047 - 120 Boxed", "048 - 360 Boxed", "049 - Boxes Max", "050 - Capturing Spree", "051 - Vending Virtuoso", "052 - Lucky Drink", "053 - Evolution Hopeful", "054 - Evolution Tech", "055 - Evolution Expert", "056 - Evolution Authority", "057 - Ace Pilot", "058 - Hustle Muscle", "059 - Trash Master", "060 - Dowsing Beginner", "061 - Dowsing Specialist", "062 - Dowsing Collector", "063 - Dowsing Wizard", "064 - Naming Champ", "065 - Television Kid", "066 - Regular Customer", "067 - Moderate Customer", "068 - Great Customer", "069 - Indulgent Customer", "070 - Super Rich", "071 - Smart Shopper", "072 - Sweet Home", "073 - The First Passerby", "074 - 30 Passersby", "075 - 100 Passersby", "076 - Heavy Traffic", "077 - Pass Power+", "078 - Pass Power++", "079 - Pass Power+++", "080 - Pass Power MAX", "081 - Dozing Capture", "082 - Sleeping Capture", "083 - Deep Sleep Capture", "084 - Sweet Dreamer", "085 - Hidden Grotto Adept", "086 - Egg Beginner", "087 - Egg Breeder", "088 - Egg Elite ", "089 - Hatching Aficionado", "090 - Day-Care Faithful", "091 - Archeology Lover", "092 - Pure Youth", "093 - Lucky Colour", "094 - Pokerus Discoverer", "095 - Castelia Boss", "096 - Rail Enthusiast", "097 - Wailord Watcher", "098 - Face Board Memorial", "099 - Heavy Machinery Pro", "Ruins Raider", "Diamond Dust", "Bridge Enthusiast", "Around Unova", "Great Adventurer", "======= Battle Medal =======", "Battle Learner", "Battle Teacher", "Battle Veteran", "Battle Virtuoso", "Link Battle Amateur", "Link Battle Pioneer", "Link Battle Expert", "Born To Battle", "Magikarp Award", "Never Give Up", "Noneffective Artist", "Supereffective Savant", "Subway Low Gear", "Subway Accelerator", "Subway Top Gear", "Runaway Express", "Single Express", "Double Express", "Multi Express", "Test Novice", "Test Fan", "Test Enthusiast", "Exam Genius", "Exp. Millionaire", "BP Wealthy", "Superb Locator", "Battle Repeater", "Cruise Connoisseur", "Driftveil Mightiest", "Rental Champ", "Mix Champ", "Unova Mightiest", "Kanto Mightiest", "Johto Mightiest", "Hoenn Mightiest", "Sinnoh Mightiest", "Mightiest Leader", "World's Mightiest", "Rental Master", "Mix Master", "All Types Champ", "Tower Junior", "Tower Master", "Treehollow Junior", "Treehollow Master", "20 Victories", "50 Victories", "100 Victories", "1,000 Wins", "Undefeated: Easy", "Undefeated: Hard", "Pinpoint: Easy", "Pinpoint: Hard", "Quick Clear: Easy", "Quick Clear: Hard", "Battle Guru", "======= Entertainment Medal =======", "Beginning Trader", "Occasional Trader", "Frequent Trader", "Great Trade-Up", "Opposite Trader", "Pen Pal", "Talented Cast Member", "Rising Star", "Big Star", "Superstar", "Musical Prima Donna", "Musical Star", "10 Followers", "First Friend", "Broad Friendship", "Extensive Friendship", "Global Connection", "Spin Trade Whiz", "Feeling Master", "Ace of Hearts", "Ferris Wheel Fan", "New Guide", "Elite Guide", "Veteran Guide", "======= Challenge Medal =======", "Guiding Champ", "Shop Starter", "Shop Builder", "Shop Constructor", "Extreme Developer", "OK Souvenir Getter", "Good Souvenir Getter", "Great Souvenir Getter", "Tycoon of Souvenirs", "Avenue of Fame", "Minigame Fan", "Minigame Buff", "Minigame Expert", "Best Minigamer", "Balloon Rookie", "Balloon Technician", "Balloon Expert", "Balloon Conqueror", "New Face Hero", "Hero Movie Star", "Cop Movie Master", "UFO Movie Master", "Monster Movie Master", "Sci-Fi Movie Master", "Romantic Movie Star", "Fantasy Movie Master", "Comedic Movie Star", "Horror Movie Star", "Robot Movie Master", "Ghost Movie Master", "Hero Ending", "Popular Movie Star", "Blockbuster Star", "Masterpiece Star", "First Cult Classic", "Cult Classic Star", "10 People Funfest", "30 People Funfest", "Scored 100", "Scored 1,000", "Mission Host Lv1", "Mission Host Lv 2", "Participant Lv 1", "Participant Lv 2", "Achiever Lv 1", "Achiever Lv 2", "Funfest Complete", "Good Night", "Beginning of Memory", "Memory Master", "Entertainment Master", "Normal-type Champ", "Fire-type Champ", "Water-type Champ", "Electric-type Champ", "Grass-type Champ", "Ice-type Champ", "Fighting-type Champ", "Poison-type Champ", "Ground-type Champ", "Flying-type Champ", "Psychic-type Champ", "Bug-type Champ", "Rock-type Champ", "Ghost-type Champ", "Dragon-type Champ", "Dark-type Champ", "Steel-type Champ", "One and Only", "Supreme Challenger" });
      indexbox.Location = new Point(14, 14);
      indexbox.Margin = new Padding(4, 3, 4, 3);
      indexbox.MaxDropDownItems = 10;
      indexbox.Name = "indexbox";
      indexbox.Size = new Size(306, 23);
      indexbox.TabIndex = 4;
      indexbox.SelectedIndexChanged += indexbox_SelectedIndexChanged;
      //
      // label1
      //
      label1.Location = new Point(14, 80);
      label1.Margin = new Padding(4, 0, 4, 0);
      label1.Name = "label1";
      label1.Size = new Size(36, 23);
      label1.TabIndex = 5;
      label1.Text = "Day";
      //
      // label2
      //
      label2.Location = new Point(118, 80);
      label2.Margin = new Padding(4, 0, 4, 0);
      label2.Name = "label2";
      label2.Size = new Size(43, 27);
      label2.TabIndex = 6;
      label2.Text = "Month";
      //
      // label3
      //
      label3.Location = new Point(224, 80);
      label3.Margin = new Padding(4, 0, 4, 0);
      label3.Name = "label3";
      label3.Size = new Size(36, 27);
      label3.TabIndex = 7;
      label3.Text = "Year";
      //
      // unreadFlag
      //
      unreadFlag.Location = new Point(14, 118);
      unreadFlag.Margin = new Padding(4, 3, 4, 3);
      unreadFlag.Name = "unreadFlag";
      unreadFlag.Size = new Size(121, 28);
      unreadFlag.TabIndex = 13;
      unreadFlag.Text = "Unread";
      unreadFlag.UseVisualStyleBackColor = true;
      unreadFlag.CheckedChanged += Flag4boxCheckedChanged;
      //
      // medal_date
      //
      medal_date.Location = new Point(14, 77);
      medal_date.Margin = new Padding(4, 3, 4, 3);
      medal_date.Name = "medal_date";
      medal_date.RightToLeft = RightToLeft.No;
      medal_date.Size = new Size(306, 23);
      medal_date.TabIndex = 14;
      medal_date.ValueChanged += Medal_dateValueChanged;
      //
      // obtained
      //
      obtained.AutoCheck = false;
      obtained.Location = new Point(14, 142);
      obtained.Margin = new Padding(4, 3, 4, 3);
      obtained.Name = "obtained";
      obtained.Size = new Size(128, 27);
      obtained.TabIndex = 15;
      obtained.Text = "Obtained";
      obtained.UseVisualStyleBackColor = true;
      obtained.Visible = false;
      //
      // red_panel
      //
      red_panel.Location = new Point(14, 78);
      red_panel.Margin = new Padding(4, 3, 4, 3);
      red_panel.Name = "red_panel";
      red_panel.Size = new Size(271, 21);
      red_panel.TabIndex = 16;
      //
      // delete_but
      //
      delete_but.Location = new Point(14, 204);
      delete_but.Margin = new Padding(4, 3, 4, 3);
      delete_but.Name = "delete_but";
      delete_but.Size = new Size(97, 23);
      delete_but.TabIndex = 17;
      delete_but.Text = "Delete Medal";
      delete_but.UseVisualStyleBackColor = true;
      delete_but.Click += Delete_butClick;
      //
      // date_hex
      //
      date_hex.Location = new Point(243, 120);
      date_hex.Margin = new Padding(4, 3, 4, 3);
      date_hex.Name = "date_hex";
      date_hex.Size = new Size(74, 23);
      date_hex.TabIndex = 18;
      //
      // flag_hex
      //
      flag_hex.Location = new Point(243, 150);
      flag_hex.Margin = new Padding(4, 3, 4, 3);
      flag_hex.Name = "flag_hex";
      flag_hex.Size = new Size(74, 23);
      flag_hex.TabIndex = 19;
      //
      // label4
      //
      label4.Location = new Point(160, 118);
      label4.Margin = new Padding(4, 0, 4, 0);
      label4.Name = "label4";
      label4.Size = new Size(76, 27);
      label4.TabIndex = 20;
      label4.Text = "Date hex:";
      label4.TextAlign = ContentAlignment.MiddleRight;
      //
      // label5
      //
      label5.Location = new Point(176, 148);
      label5.Margin = new Padding(4, 0, 4, 0);
      label5.Name = "label5";
      label5.Size = new Size(59, 27);
      label5.TabIndex = 21;
      label5.Text = "Flag hex:";
      label5.TextAlign = ContentAlignment.MiddleRight;
      //
      // exit_but
      //
      exit_but.Location = new Point(208, 212);
      exit_but.Margin = new Padding(4, 3, 4, 3);
      exit_but.Name = "exit_but";
      exit_but.Size = new Size(113, 31);
      exit_but.TabIndex = 8;
      exit_but.Text = "Exit";
      exit_but.UseVisualStyleBackColor = true;
      exit_but.Click += Exit_butClick;
      //
      // saveexit_but
      //
      saveexit_but.Location = new Point(208, 250);
      saveexit_but.Margin = new Padding(4, 3, 4, 3);
      saveexit_but.Name = "saveexit_but";
      saveexit_but.Size = new Size(115, 33);
      saveexit_but.TabIndex = 9;
      saveexit_but.Text = "Save and Exit";
      saveexit_but.UseVisualStyleBackColor = true;
      saveexit_but.Click += Saveexit_butClick;
      //
      // medalState
      //
      medalState.FormattingEnabled = true;
      medalState.Items.AddRange(new object[] { "Unobtained", "Can Receive Hint Medal", "Hint Medal Obtained", "Can Receive Medal", "Medal Obtained" });
      medalState.Location = new Point(14, 45);
      medalState.Margin = new Padding(4, 3, 4, 3);
      medalState.Name = "medalState";
      medalState.Size = new Size(306, 23);
      medalState.TabIndex = 22;
      medalState.SelectedIndexChanged += medalState_SelectedIndexChanged;
      //
      // MedalsForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(331, 298);
      Controls.Add(medalState);
      Controls.Add(flag_hex);
      Controls.Add(date_hex);
      Controls.Add(label5);
      Controls.Add(label4);
      Controls.Add(delete_but);
      Controls.Add(red_panel);
      Controls.Add(obtained);
      Controls.Add(medal_date);
      Controls.Add(unreadFlag);
      Controls.Add(saveexit_but);
      Controls.Add(exit_but);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(indexbox);
      Margin = new Padding(4, 3, 4, 3);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "MedalsForm";
      Text = "Medals";
      ResumeLayout(false);
      PerformLayout();
    }
  }
}
