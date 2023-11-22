using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool;

public partial class EntralinkForm : Form {
  private readonly SAV5 SAV;
  public readonly ExtralinkForest forest;
  private readonly List<RadioButton> checkboxlist = new List<RadioButton>();
  public EntralinkForm(SAV5 sav) {
    InitializeComponent();
    SAV = sav;
    sprite_warning.Text = "";

    checkboxlist.Add(checkdeep);
    checkboxlist.Add(check9c);
    checkboxlist.Add(check9l);
    checkboxlist.Add(check9r);
    checkboxlist.Add(check1c);
    checkboxlist.Add(check1l);
    checkboxlist.Add(check1r);
    checkboxlist.Add(check2c);
    checkboxlist.Add(check2l);
    checkboxlist.Add(check2r);
    checkboxlist.Add(check3c);
    checkboxlist.Add(check3l);
    checkboxlist.Add(check3r);
    checkboxlist.Add(check4c);
    checkboxlist.Add(check4l);
    checkboxlist.Add(check4r);
    checkboxlist.Add(check5c);
    checkboxlist.Add(check5l);
    checkboxlist.Add(check5r);
    checkboxlist.Add(check6c);
    checkboxlist.Add(check6l);
    checkboxlist.Add(check6r);
    checkboxlist.Add(check7c);
    checkboxlist.Add(check7l);
    checkboxlist.Add(check7r);
    checkboxlist.Add(check8c);
    checkboxlist.Add(check8l);
    checkboxlist.Add(check8r);

    dataGridView1.Rows.Add(19);

    forest = new ExtralinkForest(SAV is SAV5BW ? SAV.GetBlockDec(Constants.BW.Forest) : SAV.GetBlockDec(Constants.B2W2.Forest));
    unlock8box.SelectedIndex = forest.Unlock8;
    unlock9.SelectedIndex = forest.Unlock9;
    forest.Area = 4;
    forest.Indexpkm = 0;
    slot.Value = forest.Indexpkm;
    slot.Maximum = 19;
    check1c.Checked = true;
    updateslot();
    updatearea();
  }

  void updatearea() {
    int i = 0;
    foreach (RadioButton item in checkboxlist) {
      if (forest.Unlock9 == 1 && (i > 0 && i < 4)) {
        item.Enabled = true;
      } else if (forest.Unlock9 == 0 && (i > 0 && i < 4)) {
        item.Enabled = false;
      }
      switch (forest.Unlock8) {
        case 0x0:
          if (i > 3 && i < 10)
            item.Enabled = true;
          else if (i > 9)
            item.Enabled = false;
          break;
        case 0x1:
          if (i > 9 && i < 13)
            item.Enabled = true;
          else if (i >= 13)
            item.Enabled = false;
          break;
        case 0x2:
          if (i > 9 && i < 16)
            item.Enabled = true;
          else if (i >= 16)
            item.Enabled = false;
          break;
        case 0x3:
          if (i > 9 && i < 19)
            item.Enabled = true;
          else if (i >= 19)
            item.Enabled = false;
          break;
        case 0x4:
          if (i > 9 && i < 22)
            item.Enabled = true;
          else if (i >= 22)
            item.Enabled = false;
          break;
        case 0x5:
          if (i > 9 && i < 25)
            item.Enabled = true;
          else if (i >= 25)
            item.Enabled = false;
          break;
        case 0x6:
          if (i > 9 && i < 28)
            item.Enabled = true;
          else if (i >= 28)
            //We should never reach this point
            MessageBox.Show("Updatearea error 1");
          break;
        default:
          MessageBox.Show("Updatearea error 2");
          break;

      }
      i++;
    }

    i = 0;
    foreach (RadioButton item in checkboxlist) {
      if (item.Checked) {
        forest.Area = i;
      }

      i++;
    }
    if (forest.Area > 0 && forest.Area < 4)
      slot.Maximum = 9;
    else
      slot.Maximum = 19;

    forest.Indexpkm = 0;
    slot.Value = forest.Indexpkm;

    if (forest.Area > 0 && forest.Area < 4) { //Area 9 ony holds 10 pokes
      hiderows.Visible = true;
      /*
      if (dataGridView1.Rows.Count == 20) {
        for (i = 18; int i > 9; i--)
          dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
      }*/

    } else {
      hiderows.Visible = false;
      /*
      if (dataGridView1.Rows.Count == 10) {
        for (i = 0; i < 10; i++)
          dataGridView1.Rows.Add();
      }
      */
    }

    updateGrid();
    updateslot();

  }

  void updateslot() {
    spbox1.SelectedIndex = forest.Species;
    move1box.SelectedIndex = forest.Move;
    genderbox1.SelectedIndex = forest.Gender;
    formbox1.SelectedIndex = forest.Form;
    animbox1.SelectedIndex = (forest.Animation / 2);
  }

  void SlotValueChanged(object sender, EventArgs e) {
    forest.Indexpkm = (int)slot.Value;
    updateslot();

  }
  void areaChanged(object sender, EventArgs e) {
    updatearea();
    updateslot();
  }
  void Unlock8boxSelectedIndexChanged(object sender, EventArgs e) {
    forest.Unlock8 = (byte)unlock8box.SelectedIndex;
    updatearea();
    updateslot();
  }
  void Unlock9SelectedIndexChanged(object sender, EventArgs e) {
    forest.Unlock9 = (byte)unlock9.SelectedIndex;
    updatearea();
    updateslot();
  }
  void updateGrid() {
    int i;
    int temp = forest.Indexpkm;
    for (i = 0; i <= slot.Maximum; i++) {
      if (forest.Area > 0 && forest.Area <= 3 && i > 9) {
        dataGridView1.Rows[i].Cells[0].Value = " ";
        dataGridView1.Rows[i].Cells[1].Value = " ";
        dataGridView1.Rows[i].Cells[2].Value = " ";
        dataGridView1.Rows[i].Cells[3].Value = " ";
        dataGridView1.Rows[i].Cells[4].Value = " ";
      } else {
        forest.Indexpkm = i;
        if (forest.Species == 0) {
          dataGridView1.Rows[i].Cells[0].Value = " ";
          dataGridView1.Rows[i].Cells[1].Value = " ";
          dataGridView1.Rows[i].Cells[2].Value = " ";
          dataGridView1.Rows[i].Cells[3].Value = " ";
          dataGridView1.Rows[i].Cells[4].Value = " ";
        } else {
          dataGridView1.Rows[i].Cells[0].Value = BWTool.Text.pkmlist[forest.Species];
          dataGridView1.Rows[i].Cells[1].Value = BWTool.Text.movelist[forest.Move];
          switch (forest.Gender) {
            case 0:
              dataGridView1.Rows[i].Cells[2].Value = "Male";
              break;
            case 1:
              dataGridView1.Rows[i].Cells[2].Value = "Female";
              break;
            case 2:
              dataGridView1.Rows[i].Cells[2].Value = "Genderless";
              break;
          }
          dataGridView1.Rows[i].Cells[3].Value = forest.Form;
          //dataGridView1.Rows[i].Cells[4].Value = forest.Animation;
          switch (forest.Animation) {
            case 0:
              dataGridView1.Rows[i].Cells[4].Value = "0" + forest.Animation.ToString() + "- " + "Randomly turning around";

              break;
            case 2:
              dataGridView1.Rows[i].Cells[4].Value = "0" + forest.Animation.ToString() + "- " + "Randomly walking";
              break;
            case 4:
              dataGridView1.Rows[i].Cells[4].Value = "0" + forest.Animation.ToString() + "- " + "Randomly walking";
              break;
            case 6:
              dataGridView1.Rows[i].Cells[4].Value = "0" + forest.Animation.ToString() + "- " + "Walking up/down";
              break;
            case 8:
              dataGridView1.Rows[i].Cells[4].Value = "0" + forest.Animation.ToString() + "- " + "Walking left/right";
              break;
            case 10:
              dataGridView1.Rows[i].Cells[4].Value = forest.Animation.ToString() + "- " + "Walking left/right and randomly looking up/down";
              break;
            case 12:
              dataGridView1.Rows[i].Cells[4].Value = forest.Animation.ToString() + "- " + "Turning around clockwise";
              break;
            case 14:
              dataGridView1.Rows[i].Cells[4].Value = forest.Animation.ToString() + "- " + "Turning around counterclockwise";
              break;
            default:
              dataGridView1.Rows[i].Cells[4].Value = forest.Animation.ToString() + "- " + "Invalid (odd)";
              break;
          }

        }

      }
    }
    forest.Indexpkm = temp;
  }
  void DataGridView1CurrentCellChanged(object sender, EventArgs e) {
    slot.Value = dataGridView1.CurrentRow.Index;
  }
  int animation() {
    //MessageBox.Show(animbox1.SelectedIndex.ToString());
    if (animbox1.SelectedIndex > 7)
      return EntralinkDreamWorldForm.random_form_anim();
    else {
      //MessageBox.Show((animbox1.SelectedIndex*2).ToString());
      return (animbox1.SelectedIndex * 2);
    }
  }
  void Add_pkmClick(object sender, EventArgs e) {
    forest.add_pkm(forest.create_pkm(spbox1.SelectedIndex, move1box.SelectedIndex, genderbox1.SelectedIndex, formbox1.SelectedIndex, animation()));
    updateGrid();
  }
  void Del_pkmClick(object sender, EventArgs e) {
    forest.delete_pkm();
    updateGrid();
  }
  void Edit_pkmClick(object sender, EventArgs e) {
    //If slot is empty, add pokemon instead
    if (forest.is_pkm_empty() == true) {
      forest.add_pkm(forest.create_pkm(spbox1.SelectedIndex, move1box.SelectedIndex, genderbox1.SelectedIndex, formbox1.SelectedIndex, animation()));
      updateGrid();
    } else {
      forest.edit_pkm(forest.create_pkm(spbox1.SelectedIndex, move1box.SelectedIndex, genderbox1.SelectedIndex, formbox1.SelectedIndex, animation()));
      updateGrid();
    }
  }
  void Exit_butClick(object sender, EventArgs e) {
    Close();
  }
  void Saveexit_butClick(object sender, EventArgs e) {
    if (SAV is SAV5BW)
      SAV.SetBlockCrypt(forest.Data, Constants.BW.Forest);
    else
      SAV.SetBlockCrypt(forest.Data, Constants.B2W2.Forest);
    Close();
  }
  void Export_areaClick(object sender, EventArgs e) {
    forest.dump_area();
  }
  void Import_areaClick(object sender, EventArgs e) {
    forest.import_area();
    updatearea();
  }
  void Export_forestClick(object sender, EventArgs e) {
    forest.export_forest();
    updatearea();
  }
  void Import_forestClick(object sender, EventArgs e) {
    forest.import_forest();
    updatearea();
  }

  public static int[] BW2_sprites = {
    505, 507, 510, 511, 513, 515, 519, 523, 525, 527,
    529, 531, 533, 535, 538, 539, 542, 545, 546, 548,
    550, 553, 556, 558, 559, 531, 564, 569, 572, 575,
    578, 580, 582, 587, 588, 594, 596, 600, 605, 607,
    610, 613, 616, 618, 619, 621, 622, 624, 626, 628,
    630, 631, 632
  };

  public static int[] BW_femaleonly = {
    029, 030, 031, 113, 115, 124, 238, 241, 242, 314,
    380, 413, 416, 440, 478, 488, 548, 549, 629, 630
  };

  public static int[] BW_maleonly = {
    032, 033, 034, 106, 107, 128, 236, 237, 313, 381,
    414, 475, 538, 539, 627, 628, 641, 642, 645
  };

  public static int[] BW_genderless = {
    081, 082, 100, 101, 120, 121, 132, 137, 144, 145,
    146, 150, 151, 201, 233, 243, 244, 245, 249, 250,
    251, 292, 337, 338, 343, 344, 374, 375, 376, 377,
    378, 379, 382, 383, 384, 385, 386, 436, 437, 462,
    474, 479, 480, 481, 482, 483, 484, 486, 487, 489,
    490, 491, 492, 493, 494, 599, 600, 601, 615, 622,
    623, 638, 639, 640, 643, 644, 646, 647, 648, 649
  };

  public static int[] BW_forms = {
    201, 386, 412, 413, 422, 423, 479, 487, 492, 550,
    585, 586, 648
  };

  void Spbox1SelectedIndexChanged(object sender, EventArgs e) {
    //Handle species without sprites
    if (SAV is SAV5B2W2 && spbox1.SelectedIndex > 493) {
      for (int i = 0; i < 53; i++) {
        if (spbox1.SelectedIndex == BW2_sprites[i]) {
          sprite_warning.Text = "";
          break;
        } else
          sprite_warning.Text = "Selected species does not have a sprite for BW2";
      }
    } else if (spbox1.SelectedIndex > 493) {
      sprite_warning.Text = "Selected species does not have a sprite for BW";
    } else {
      sprite_warning.Text = "";
    }

    //Handle genders
    bool special_gender = false;
    for (int i = 0; i < BW_femaleonly.Length; i++) {
      if (spbox1.SelectedIndex == BW_femaleonly[i]) {
        //Only female
        special_gender = true;
        genderbox1.SelectedIndex = 1;
        genderbox1.Enabled = false;
      }
    }

    for (int i = 0; i < BW_maleonly.Length; i++) {
      if (spbox1.SelectedIndex == BW_maleonly[i]) {
        //Only male
        special_gender = true;
        genderbox1.SelectedIndex = 0;
        genderbox1.Enabled = false;
      }
    }

    for (int i = 0; i < BW_genderless.Length; i++) {
      if (spbox1.SelectedIndex == BW_genderless[i]) {
        //Only genderless
        special_gender = true;
        genderbox1.Items.Clear();
        genderbox1.Items.AddRange(new object[] { "Male", "Female", "Genderless" });
        genderbox1.SelectedIndex = 2;
        genderbox1.Enabled = false;
      }
    }

    if (special_gender == false) {
      //Re-enable list
      genderbox1.Enabled = true;
      genderbox1.Items.Clear();
      genderbox1.Items.AddRange(new object[] { "Male", "Female" });
    }

    //Handle forms
    formbox1.Enabled = true;
    formbox1.Items.Clear();
    switch (spbox1.SelectedIndex) {
      case 201:
        formbox1.Items.AddRange(new object[] {
              "A",
              "B",
              "C",
              "D",
              "E",
              "F",
              "G",
              "H",
              "I",
              "J",
              "K",
              "L",
              "M",
              "N",
              "O",
              "P",
              "Q",
              "R",
              "S",
              "T",
              "U",
              "V",
              "W",
              "X",
              "Y",
              "Z",
              "!",
              "?"});
        if (forest.Form > 27)
          formbox1.SelectedIndex = 0;
        else
          formbox1.SelectedIndex = forest.Form;
        break;
      case 386:

        formbox1.Items.AddRange(new object[] {
          "Normal",
          "Attack",
          "Defense",
          "Speed"});
        if (forest.Form > 4)
          formbox1.SelectedIndex = 0;
        else
          formbox1.SelectedIndex = forest.Form;
        break;
      case 412:
      case 413:
        formbox1.Items.AddRange(new object[] {
          "Plant",
          "Sand",
          "Trash"});
        if (forest.Form > 3)
          formbox1.SelectedIndex = 0;
        else
          formbox1.SelectedIndex = forest.Form;
        break;
      case 422:
      case 423:
        formbox1.Items.AddRange(new object[] {
          "West Sea",
          "East Sea"});
        if (forest.Form > 2)
          formbox1.SelectedIndex = 0;
        else
          formbox1.SelectedIndex = forest.Form;
        break;
      case 479:
        formbox1.Items.AddRange(new object[] {
          "Normal",
          "Heat",
          "Wash",
          "Frost",
          "Fan",
          "Mow"});
        if (forest.Form > 6)
          formbox1.SelectedIndex = 0;
        else
          formbox1.SelectedIndex = forest.Form;
        break;
      case 487:
        formbox1.Items.AddRange(new object[] {
          "Altered",
          "Origin"});
        if (forest.Form > 2)
          formbox1.SelectedIndex = 0;
        else
          formbox1.SelectedIndex = forest.Form;
        break;
      case 492:
        formbox1.Items.AddRange(new object[] {
          "Land",
          "Sky"});
        if (forest.Form > 2)
          formbox1.SelectedIndex = 0;
        else
          formbox1.SelectedIndex = forest.Form;
        break;
      case 550:
        formbox1.Items.AddRange(new object[] {
          "Red",
          "Blue"});
        if (forest.Form > 2)
          formbox1.SelectedIndex = 0;
        else
          formbox1.SelectedIndex = forest.Form;
        break;
      case 585:
      case 586:
        formbox1.Items.AddRange(new object[] {
          "Winter",
          "Spring",
          "Summer",
          "Autumn"});
        if (forest.Form > 4)
          formbox1.SelectedIndex = 0;
        else
          formbox1.SelectedIndex = forest.Form;
        break;
      case 648:
        formbox1.Items.AddRange(new object[] {
          "Aria",
          "Pirouette"});
        if (forest.Form > 2)
          formbox1.SelectedIndex = 0;
        else
          formbox1.SelectedIndex = forest.Form;
        break;
      default:
        formbox1.Enabled = false;
        formbox1.Items.Add("");
        formbox1.SelectedIndex = 0;
        break;
    }

  }
  public static uint dream_pkm = 0;
  void add_dw_pkm() {
    //Add dream pokemon!
    if (dream_pkm != 0) {

      //Arceus warning
      if ((dream_pkm & 0x7FF) == 493 && forest.Area != 1)
        MessageBox.Show("Warning! PGL Arceus was a special event and is supposed to reside at area 9 center!\n\nI don't know if any other PGL Pokémon was distributed at special areas, I only know that Mamoswine and Porygon were download alongside other Dream World Pokémon, so Arceus might be the only special case. Any information on the topic is welcome.");

      //If slot is empty, add pokemon instead
      if (forest.is_pkm_empty() == true) {
        forest.add_pkm(dream_pkm);
        updateGrid();
      } else {
        forest.edit_pkm(dream_pkm);
        updateGrid();
      }
    }
    dream_pkm = 0;
  }

  void Pleasant_butClick(object sender, EventArgs e) {
    Form dreamworld = new EntralinkDreamWorldForm(SAV, forest, 0, "Pleasant Forest");
    dreamworld.ShowDialog();
    add_dw_pkm();
  }
  void Wind_butClick(object sender, EventArgs e) {
    Form dreamworld = new EntralinkDreamWorldForm(SAV, forest, 1, "Windswept Sky");
    dreamworld.ShowDialog();
    add_dw_pkm();
  }
  void Spark_butClick(object sender, EventArgs e) {
    Form dreamworld = new EntralinkDreamWorldForm(SAV, forest, 2, "Sparkling Sea");
    dreamworld.ShowDialog();
    add_dw_pkm();
  }
  void Spooky_butClick(object sender, EventArgs e) {
    Form dreamworld = new EntralinkDreamWorldForm(SAV, forest, 3, "Spooky Manor");
    dreamworld.ShowDialog();
    add_dw_pkm();
  }
  void Rugged_butClick(object sender, EventArgs e) {
    Form dreamworld = new EntralinkDreamWorldForm(SAV, forest, 4, "Rugged Mountain");
    dreamworld.ShowDialog();
    add_dw_pkm();
  }
  void Icy_butClick(object sender, EventArgs e) {
    Form dreamworld = new EntralinkDreamWorldForm(SAV, forest, 5, "Icy Cave");
    dreamworld.ShowDialog();
    add_dw_pkm();
  }
  void Dream_butClick(object sender, EventArgs e) {
    Form dreamworld = new EntralinkDreamWorldForm(SAV, forest, 6, "Dream Park");
    dreamworld.ShowDialog();
    add_dw_pkm();
  }
  void pkmcafe_butClick(object sender, EventArgs e) {
    Form dreamworld = new EntralinkDreamWorldForm(SAV, forest, 7, "Pokémon Café Forest");
    dreamworld.ShowDialog();
    add_dw_pkm();
  }
  void Pgl_butClick(object sender, EventArgs e) {
    Form dreamworld = new EntralinkDreamWorldForm(SAV, forest, 8, "PGL Promotions");
    dreamworld.ShowDialog();
    add_dw_pkm();
  }

}
