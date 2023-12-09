using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.Unmaintained.SwShEventEditor;
public partial class DynamaxResetForm : Form {

  private readonly SAV8SWSH SAV;

  public DynamaxResetForm(SAV8SWSH sav) {
    InitializeComponent();
    SAV = sav;
  }

  public uint[] Gen1Keys = [
    0xF75E52CF, //Articuno
    0xF75E5635, //Zapdos
    0xF75E511C, //Moltres
    0xF75E4DB6 //Mewtwo
  ];

  public uint[] Gen2Keys = [
    0xF75E4C03, //Raikou
    0xF75E4A50, //Entei
    0xF75E4F69, //Suicune
    0xF75E621A, //Lugia
    0xF75E63CD //Ho-Oh
  ];

  public uint[] Gen3Keys = [
    0xF760963E, //Kyogre
    0xF76097F1, //Groudon
    0xF7609B57, //Rayquaza
    0xF760948B, //Latias
    0xF76092D8, //Latios
  ];

  public uint[] Gen4Keys = [
    0xF76086F3, //Dialga
    0xF7608540, //Palkia
    0xF7582170, //Giratina
    0xF76099A4, //Uxie
    0xF7609D0A, //Mesprit
    0xF7609EBD, //Azelf
    0xF7582323, //Heatran
    0xF75824D6, //Cresselia
  ];

  public uint[] Gen5Keys = [
    0xF7582BA2, //Reshiram
    0xF7582D55, //Zekrom
    0xF7582F08, //Kyurem
    0xF7582689, //Tornadus
    0xF758283C, //Thundurus
    0xF75829EF, //Landorus
  ];

  public uint[] Gen6Keys = [
    0xF75830BB, //Xerneas
    0xF75B3AF9, //Yveltal
    0xF75B3946, //Zygarde
  ];

  public uint[] Gen7Keys = [
    0xF75B3E5F, //Solgaleo
    0xF75B3CAC, //Lunala
    0xF75B3793, //Tapu Koko
    0xF75B35E0, //Tapu Lele
    0xF75B41C5, //Tapu Bulu
    0xF75B4012, //Tapu Fini
  ];

  public uint[] Gen7UBKeys = [
    0xF75B46DE, //Nihilego
    0xF769AAC6, //Buzzwole
    0xF769AC79, //Pheromosa
    0xF769A760, //Xurkitree
    0xF769B192, //Celesteela
    0xF769A913, //Kartana
    0xF769B345, //Guzzlord
    0xF75B4891, //Necrozma
    0xF769B85E, //Stakataka
    0xF769AFDF, //Blacephalon
  ];


  private void DynamaxResetForm_Load(object sender, EventArgs e) {
    //Check gen 1
    for (int i = 0; i < Gen1Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen1Keys[i]);
      gen1_clistbox.SetItemChecked(i, block.GetBooleanValue());
    }

    //Check gen 2
    for (int i = 0; i < Gen2Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen2Keys[i]);
      gen2_clistbox.SetItemChecked(i, block.GetBooleanValue());
    }
    //Check gen 3
    for (int i = 0; i < Gen3Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen3Keys[i]);
      gen3_clistbox.SetItemChecked(i, block.GetBooleanValue());
    }

    //Check gen 4
    for (int i = 0; i < Gen4Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen4Keys[i]);
      gen4_clistbox.SetItemChecked(i, block.GetBooleanValue());
    }

    //Check gen 5
    for (int i = 0; i < Gen5Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen5Keys[i]);
      gen5_clistbox.SetItemChecked(i, block.GetBooleanValue());
    }

    //Check gen 6
    for (int i = 0; i < Gen6Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen6Keys[i]);
      gen6_clistbox.SetItemChecked(i, block.GetBooleanValue());
    }

    //Check gen 7
    for (int i = 0; i < Gen7Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen7Keys[i]);
      gen7_clistbox.SetItemChecked(i, block.GetBooleanValue());
    }

    //Check gen 7 Ultra beasts
    for (int i = 0; i < Gen7UBKeys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen7UBKeys[i]);
      UB_clistbox.SetItemChecked(i, block.GetBooleanValue());
    }

    //Get Misc
    dstreak_NUD.Value = Convert.ToInt32(SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairDisconnectStreak"]).GetValue());
    estreak_NUD.Value = Convert.ToInt32(SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairEndlessStreak"]).GetValue());

    int notes1 = Convert.ToInt32(SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairSpeciesID1Noted"]).GetValue());
    int notes2 = Convert.ToInt32(SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairSpeciesID2Noted"]).GetValue());
    int notes3 = Convert.ToInt32(SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairSpeciesID3Noted"]).GetValue());

    int hint = Convert.ToInt32(SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairPeoniaSpeciesHint"]).GetValue());

    mlspecies1_CMB.SelectedIndex = Definitions.NationalDex.GetIDIndex(notes1);
    mlspecies2_CMB.SelectedIndex = Definitions.NationalDex.GetIDIndex(notes2);
    mlspecies3_CMB.SelectedIndex = Definitions.NationalDex.GetIDIndex(notes3);

    mlhint_CMB.SelectedIndex = Definitions.NationalDex.GetIDIndex(hint);
  }


  private void applyBTN_Click(object sender, EventArgs e) {
    //Check gen 1
    for (int i = 0; i < Gen1Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen1Keys[i]);
      block.ChangeBooleanValue(gen1_clistbox.GetItemChecked(i));
    }

    //Check gen 2
    for (int i = 0; i < Gen2Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen2Keys[i]);
      block.ChangeBooleanValue(gen2_clistbox.GetItemChecked(i));
    }

    //Check gen 3
    for (int i = 0; i < Gen3Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen3Keys[i]);
      block.ChangeBooleanValue(gen3_clistbox.GetItemChecked(i));
    }

    //Check gen 4
    for (int i = 0; i < Gen4Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen4Keys[i]);
      block.ChangeBooleanValue(gen4_clistbox.GetItemChecked(i));
    }

    //Check gen 5
    for (int i = 0; i < Gen5Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen5Keys[i]);
      block.ChangeBooleanValue(gen5_clistbox.GetItemChecked(i));
    }

    //Check gen 6
    for (int i = 0; i < Gen6Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen6Keys[i]);
      block.ChangeBooleanValue(gen6_clistbox.GetItemChecked(i));
    }

    //Check gen 7
    for (int i = 0; i < Gen7Keys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen7Keys[i]);
      block.ChangeBooleanValue(gen7_clistbox.GetItemChecked(i));
    }

    //Check gen 7 Ultra Beasts
    for (int i = 0; i < Gen7UBKeys.Length; i++) {
      SCBlock block = SAV.Blocks.GetBlock(Gen7UBKeys[i]);
      block.ChangeBooleanValue(UB_clistbox.GetItemChecked(i));
    }

    //apply misc changes
    SCBlock b_notes1 = SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairSpeciesID1Noted"]);
    SCBlock b_notes2 = SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairSpeciesID2Noted"]);
    SCBlock b_notes3 = SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairSpeciesID3Noted"]);

    SCBlock b_hint = SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairPeoniaSpeciesHint"]);

    b_notes1.SetValue(Convert.ToUInt32(Definitions.NationalDex.GetID(mlspecies1_CMB.SelectedItem!.ToString()!)));
    b_notes2.SetValue(Convert.ToUInt32(Definitions.NationalDex.GetID(mlspecies2_CMB.SelectedItem!.ToString()!)));
    b_notes3.SetValue(Convert.ToUInt32(Definitions.NationalDex.GetID(mlspecies3_CMB.SelectedItem!.ToString()!)));

    b_hint.SetValue(Convert.ToUInt32(Definitions.NationalDex.GetID(mlhint_CMB.SelectedItem!.ToString()!)));

    SCBlock b_dstreak = SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairDisconnectStreak"]);
    SCBlock b_estreak = SAV.Blocks.GetBlock(Definitions.memkeys_MaxLairMisc["KMaxLairEndlessStreak"]);

    b_dstreak.SetValue(Convert.ToUInt32(dstreak_NUD.Value));
    b_estreak.SetValue(Convert.ToUInt32(estreak_NUD.Value));

    DialogResult = DialogResult.OK;
    Close();
  }

  //Quori: This was a pain to set-up, there was probably a better way to do it, but oh well I'll do it later.
  enum Generations { Gen1, Gen2, Gen3, Gen4, Gen5, Gen6, Gen7, Gen7_UB }
  void SetValue(Generations Generation, bool Value) {
    switch (Generation) {
      case Generations.Gen1:
        for (int i = 0; i < gen1_clistbox.Items.Count; i++) gen1_clistbox.SetItemChecked(i, Value);
        break;
      case Generations.Gen2:
        for (int i = 0; i < gen2_clistbox.Items.Count; i++) gen2_clistbox.SetItemChecked(i, Value);
        break;
      case Generations.Gen3:
        for (int i = 0; i < gen3_clistbox.Items.Count; i++) gen3_clistbox.SetItemChecked(i, Value);
        break;
      case Generations.Gen4:
        for (int i = 0; i < gen4_clistbox.Items.Count; i++) gen4_clistbox.SetItemChecked(i, Value);
        break;
      case Generations.Gen5:
        for (int i = 0; i < gen5_clistbox.Items.Count; i++) gen5_clistbox.SetItemChecked(i, Value);
        break;
      case Generations.Gen6:
        for (int i = 0; i < gen6_clistbox.Items.Count; i++) gen6_clistbox.SetItemChecked(i, Value);
        break;
      case Generations.Gen7:
        for (int i = 0; i < gen7_clistbox.Items.Count; i++) gen7_clistbox.SetItemChecked(i, Value);
        break;
      case Generations.Gen7_UB:
        for (int i = 0; i < UB_clistbox.Items.Count; i++) UB_clistbox.SetItemChecked(i, Value);
        break;
    }

  }

  #region Found All / Reset All Buttons

  private void g1FA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen1, true);
  }
  private void g1RA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen1, false);
  }


  private void g2FA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen2, true);
  }
  private void g2RA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen2, false);
  }


  private void g3FA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen3, true);
  }
  private void g3RA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen3, false);
  }


  private void g4FA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen4, true);
  }
  private void g4RA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen4, false);
  }


  private void g5FA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen5, true);
  }
  private void g5RA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen5, false);
  }




  private void g6FA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen6, true);
  }
  private void g6RA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen6, false);
  }


  private void g7FA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen7, true);
  }
  private void g7RA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen7, false);
  }


  private void g7ubFA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen7_UB, true);
  }
  private void g7ubRA_BTN_Click(object sender, EventArgs e) {
    SetValue(Generations.Gen7_UB, false);
  }
  #endregion

  private void glFA_BTN_Click(object sender, EventArgs e) {
    var result = MessageBox.Show("Are you sure you want to check everything?", "Alert", MessageBoxButtons.YesNo);
    if (result == DialogResult.Yes) for (int i = 0; i < (int)Generations.Gen7_UB + 1; i++) SetValue((Generations)i, true);
  }

  private void glRA_BTN_Click(object sender, EventArgs e) {
    var result = MessageBox.Show("Are you sure you want to un-check everything?", "Alert", MessageBoxButtons.YesNo);
    if (result == DialogResult.Yes) for (int i = 0; i < (int)Generations.Gen7_UB + 1; i++) SetValue((Generations)i, false);
  }

  private void report_BTN_Click(object sender, EventArgs e) {
    MessageBox.Show("For help or to report issues and/or bugs, please contact \"Reshiquori#8124\" and/or \"Darthfiggy#9205\" on Discord.", "Help");
  }

  #region Notes
  private void mlspecies1_CMB_SelectedIndexChanged(object sender, EventArgs e) {
    CheckSpeciesNotes1();
    CheckLegality();
  }

  private void mlspecies2_CMB_SelectedIndexChanged(object sender, EventArgs e) {
    CheckSpeciesNotes2();
    CheckLegality();
  }

  private void mlspecies3_CMB_SelectedIndexChanged(object sender, EventArgs e) {
    CheckSpeciesNotes3();
    CheckLegality();
  }

  bool CheckSpeciesNotes1() {
    if (!ml_legality_CB.Checked) return false;
    if (mlspecies1_CMB.SelectedIndex != 0) {
      //Radix Programming note:
      //this looks complicated but it's very simple, and all 3 note checks follow this example
      //first it makes sure that the value its checking against isn't equal to 0 (this would give us a false positive)
      //then it simply makes sure that there aren't any duplicates
      if (mlspecies1_CMB.SelectedIndex == mlspecies3_CMB.SelectedIndex && mlspecies3_CMB.SelectedIndex > 0 || mlspecies1_CMB.SelectedIndex == mlspecies2_CMB.SelectedIndex && mlspecies2_CMB.SelectedIndex > 0) {
        if (DialogResult.Yes == MessageBox.Show("Notes Value 1 is already set, would you like to disable auto-legality?", "Error", MessageBoxButtons.YesNo)) {
          ml_legality_CB.Checked = false;
          return false;
        } else mlspecies1_CMB.SelectedIndex = 0;

      }
    }
    return true;
  }

  bool CheckSpeciesNotes2() {
    if (!ml_legality_CB.Checked) return false;
    if (mlspecies1_CMB.SelectedIndex != 0) {
      if (mlspecies2_CMB.SelectedIndex == mlspecies3_CMB.SelectedIndex && mlspecies3_CMB.SelectedIndex > 0 || mlspecies2_CMB.SelectedIndex == mlspecies1_CMB.SelectedIndex && mlspecies1_CMB.SelectedIndex > 0) {
        if (DialogResult.Yes == MessageBox.Show("Notes Value 2 is already set, would you like to disable auto-legality?", "Error", MessageBoxButtons.YesNo)) {
          ml_legality_CB.Checked = false;
          return false;
        } else mlspecies2_CMB.SelectedIndex = 0;
      }
    }
    return true;
  }

  bool CheckSpeciesNotes3() {
    if (!ml_legality_CB.Checked) return false;
    if (mlspecies3_CMB.SelectedIndex != 0) {
      if (mlspecies3_CMB.SelectedIndex == mlspecies2_CMB.SelectedIndex && mlspecies2_CMB.SelectedIndex > 0 || mlspecies3_CMB.SelectedIndex == mlspecies1_CMB.SelectedIndex && mlspecies1_CMB.SelectedIndex > 0) {
        if (DialogResult.Yes == MessageBox.Show("Notes Value 3 is already set, would you like to disable auto-legality?", "Error", MessageBoxButtons.YesNo)) {
          ml_legality_CB.Checked = false;
          return false;
        } else mlspecies3_CMB.SelectedIndex = 0;

      }
    }
    return true;
  }

  bool CheckPeoniaNotes() {
    if ((string)mlhint_CMB.SelectedItem! == "None")
      return false;

    if (!ml_legality_CB.Checked)
      return false;

    if (SAV.Version == GameVersion.SW) {
      //Check the opposing game for an entry
      if (Definitions.MaxLairExclusives.Shield.Contains(mlhint_CMB.SelectedItem)) {
        if (DialogResult.Yes == ShowWrongGameMSG()) {
          mlhint_CMB.SelectedItem = Definitions.MaxLairExclusives.Sword[Definitions.MaxLairExclusives.Shield.IndexOf(mlhint_CMB.SelectedItem!.ToString()!)];
        } else ml_legality_CB.Checked = false;
      }
    } else if (SAV.Version == GameVersion.SH) {
      //Check the opposing game for an entry
      if (Definitions.MaxLairExclusives.Sword.Contains(mlhint_CMB.SelectedItem)) {
        if (DialogResult.Yes == ShowWrongGameMSG()) {
          mlhint_CMB.SelectedItem = Definitions.MaxLairExclusives.Shield[Definitions.MaxLairExclusives.Sword.IndexOf(mlhint_CMB.SelectedItem!.ToString()!)];
        } else ml_legality_CB.Checked = false;
      }
    }


    return true;
  }

  private void ml_legality_CB_CheckedChanged(object sender, EventArgs e) {
    CheckSpeciesNotes1();
    CheckSpeciesNotes2();
    CheckSpeciesNotes3();

    CheckPeoniaNotes();

    CheckLegality();
  }

  void CheckLegality() {
    if (CheckSpeciesNotes1() && CheckSpeciesNotes2() && CheckSpeciesNotes3()) mlnotes_legal_LBL.Text = "Legal Status: Legal";
    else mlnotes_legal_LBL.Text = "Legal Status: Potentially Illegal";
  }

  #endregion

  private void mlhint_CMB_SelectedIndexChanged(object sender, EventArgs e) {
    CheckPeoniaNotes();


  }

  private static DialogResult ShowWrongGameMSG() {
    return MessageBox.Show("You have chosen a legendary that you cannot have notes for! Would you like to correct this to the legendary for your game?", "Error", MessageBoxButtons.YesNo);
  }

  private void mlnotes_legal_LBL_Click(object sender, EventArgs e) {

  }

}
