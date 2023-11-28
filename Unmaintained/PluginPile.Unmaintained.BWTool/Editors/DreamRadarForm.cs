using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool;

public partial class DreamRadarForm : Form {

  private readonly SAV5B2W2 SAV;
  private readonly DreamRadarKey drkey;
  private readonly DreamRadarA dra;
  private readonly DreamRadarB drb;

  public DreamRadarForm(SAV5B2W2 sav) {
    InitializeComponent();

    SAV = sav;
    drkey = new DreamRadarKey(SAV.GetBlock(Constants.B2W2.DreamRadarKey));
    dra = new DreamRadarA(SAV.GetDSLinkA());
    drb = new DreamRadarB(SAV.GetDSLinkB()); //Get 3DS link data decrypted

    if (dra.received == false) {
      MessageBox.Show("Warning! There's unreceived data in the savegame!");
      dra.key = drb.EncKey ^ drkey.FLAGS;//This makes editing the data possible without messing up the current encryption
    }

    if (drb.illegal == true) {
      allmode.Checked = true;
      set_all_list();

    } else {
      legitmode.Checked = true;
      set_legal_list();
    }

    load_data();
  }
  void Exit_butClick(object sender, EventArgs e) => Close();

  void Saveexit_butClick(object sender, EventArgs e) {
    set_data();
    SAV.SetBlock(drkey.Data, Constants.B2W2.DreamRadarKey);
    SAV.SetDSLinkA(dra.Data);
    SAV.SetDSLinkB(drb.Data);
    Close();
  }

  void Clean_butClick(object sender, EventArgs e) { //Right now this button is disabled as we know how to edit all the data
    drkey.reinit();
    dra.reinit();
    drb.reinit();

    SAV.SetBlock(drkey.Data, Constants.B2W2.DreamRadarKey);
    SAV.SetDSLinkA(dra.Data);
    SAV.SetDSLinkB(drb.Data);
    Close();
  }

  void set_legal_list() {
    pkm1.Items.Clear();
    pkm2.Items.Clear();
    pkm3.Items.Clear();
    pkm4.Items.Clear();
    pkm5.Items.Clear();
    pkm6.Items.Clear();
    pkm1.Items.AddRange(Language.DRPkmList);
    pkm2.Items.AddRange(Language.DRPkmList);
    pkm3.Items.AddRange(Language.DRPkmList);
    pkm4.Items.AddRange(Language.DRPkmList);
    pkm5.Items.AddRange(Language.DRPkmList);
    pkm6.Items.AddRange(Language.DRPkmList);
    item1.Items.Clear();
    item2.Items.Clear();
    item3.Items.Clear();
    item4.Items.Clear();
    item5.Items.Clear();
    item6.Items.Clear();
    item1.Items.AddRange(Language.DRItemList);
    item2.Items.AddRange(Language.DRItemList);
    item3.Items.AddRange(Language.DRItemList);
    item4.Items.AddRange(Language.DRItemList);
    item5.Items.AddRange(Language.DRItemList);
    item6.Items.AddRange(Language.DRItemList);
  }

  void set_all_list() {
    pkm1.Items.Clear();
    pkm2.Items.Clear();
    pkm3.Items.Clear();
    pkm4.Items.Clear();
    pkm5.Items.Clear();
    pkm6.Items.Clear();
    pkm1.Items.AddRange(Language.PkmList);
    pkm2.Items.AddRange(Language.PkmList);
    pkm3.Items.AddRange(Language.PkmList);
    pkm4.Items.AddRange(Language.PkmList);
    pkm5.Items.AddRange(Language.PkmList);
    pkm6.Items.AddRange(Language.PkmList);
    item1.Items.Clear();
    item2.Items.Clear();
    item3.Items.Clear();
    item4.Items.Clear();
    item5.Items.Clear();
    item6.Items.Clear();
    item1.Items.AddRange(Language.ItemList);
    item2.Items.AddRange(Language.ItemList);
    item3.Items.AddRange(Language.ItemList);
    item4.Items.AddRange(Language.ItemList);
    item5.Items.AddRange(Language.ItemList);
    item6.Items.AddRange(Language.ItemList);
  }

  int poke2legit(int species) {
    if (legitmode.Checked) {
      for (int i = 0; i < 19; i++) {
        if (species == drb.legit_pk_index[i])
          return i;
      }
    }
    return species;
  }

  int item2legit(int item) {
    if (legitmode.Checked) {
      for (int i = 0; i < 24; i++) {
        if (item == drb.legit_item_index[i])
          return i;
      }
    }
    return item;
  }

  void load_data() {
    pkm1.SelectedIndex = poke2legit(drb.get_poke_species(0));
    pkm2.SelectedIndex = poke2legit(drb.get_poke_species(1));
    pkm3.SelectedIndex = poke2legit(drb.get_poke_species(2));
    pkm4.SelectedIndex = poke2legit(drb.get_poke_species(3));
    pkm5.SelectedIndex = poke2legit(drb.get_poke_species(4));
    pkm6.SelectedIndex = poke2legit(drb.get_poke_species(5));

    item1.SelectedIndex = item2legit(drb.get_item_id(0));
    item2.SelectedIndex = item2legit(drb.get_item_id(1));
    item3.SelectedIndex = item2legit(drb.get_item_id(2));
    item4.SelectedIndex = item2legit(drb.get_item_id(3));
    item5.SelectedIndex = item2legit(drb.get_item_id(4));
    item6.SelectedIndex = item2legit(drb.get_item_id(5));

    pkmgnd1.SelectedIndex = drb.get_poke_gender(0);
    pkmgnd2.SelectedIndex = drb.get_poke_gender(1);
    pkmgnd3.SelectedIndex = drb.get_poke_gender(2);
    pkmgnd4.SelectedIndex = drb.get_poke_gender(3);
    pkmgnd5.SelectedIndex = drb.get_poke_gender(4);
    pkmgnd6.SelectedIndex = drb.get_poke_gender(5);

    itemcnt1.Value = drb.get_item_amount(0);
    itemcnt2.Value = drb.get_item_amount(1);
    itemcnt3.Value = drb.get_item_amount(2);
    itemcnt4.Value = drb.get_item_amount(3);
    itemcnt5.Value = drb.get_item_amount(4);
    itemcnt6.Value = drb.get_item_amount(5);

    legend1.SelectedIndex = drb.get_legend(0);
    legend2.SelectedIndex = drb.get_legend(1);
    legend3.SelectedIndex = drb.get_legend(2);
    legend4.SelectedIndex = drb.get_legend(3);
    legend5.SelectedIndex = drb.get_legend(4);
    legend6.SelectedIndex = drb.get_legend(5);
    legend7.SelectedIndex = drb.get_legend(6);
    legend8.SelectedIndex = drb.get_legend(7);

    flag0.Checked = drkey.Tornadus;
    flag1.Checked = drkey.Thundurus;
    flag2.Checked = drkey.Landorus;
    flag3.Checked = drkey.Dialga;
    flag4.Checked = drkey.Palkia;
    flag5.Checked = drkey.Giratina;
    flag6.Checked = drkey.HoOh;
    flag7.Checked = drkey.Lugia;
  }

  void set_data() {
    //Get the correct intial key before changing the flags
    drb.EncKey = dra.key ^ drkey.FLAGS;

    //Set the flags
    drkey.Tornadus = flag0.Checked;
    drkey.Thundurus = flag1.Checked;
    drkey.Landorus = flag2.Checked;
    drkey.Dialga = flag3.Checked;
    drkey.Palkia = flag4.Checked;
    drkey.Giratina = flag5.Checked;
    drkey.HoOh = flag6.Checked;
    drkey.Lugia = flag7.Checked;

    drb.clean_data();//Set everything to 0 first
                     //Legendary slots
    drb.set_legend(drb.legendary_index[legend1.SelectedIndex], 0);
    drb.set_legend(drb.legendary_index[legend2.SelectedIndex], 1);
    drb.set_legend(drb.legendary_index[legend3.SelectedIndex], 2);
    drb.set_legend(drb.legendary_index[legend4.SelectedIndex], 3);
    drb.set_legend(drb.legendary_index[legend5.SelectedIndex], 4);
    drb.set_legend(drb.legendary_index[legend6.SelectedIndex], 5);
    drb.set_legend(drb.legendary_index[legend7.SelectedIndex], 6);
    drb.set_legend(drb.legendary_index[legend8.SelectedIndex], 7);

    if (legitmode.Checked) {
      drb.set_poke(drb.legit_pk_index[pkm1.SelectedIndex], pkmgnd1.SelectedIndex, 0);
      drb.set_poke(drb.legit_pk_index[pkm2.SelectedIndex], pkmgnd2.SelectedIndex, 1);
      drb.set_poke(drb.legit_pk_index[pkm3.SelectedIndex], pkmgnd3.SelectedIndex, 2);
      drb.set_poke(drb.legit_pk_index[pkm4.SelectedIndex], pkmgnd4.SelectedIndex, 3);
      drb.set_poke(drb.legit_pk_index[pkm5.SelectedIndex], pkmgnd5.SelectedIndex, 4);
      drb.set_poke(drb.legit_pk_index[pkm6.SelectedIndex], pkmgnd6.SelectedIndex, 5);

      drb.set_item((int)itemcnt1.Value, drb.legit_item_index[item1.SelectedIndex], 0);
      drb.set_item((int)itemcnt2.Value, drb.legit_item_index[item2.SelectedIndex], 1);
      drb.set_item((int)itemcnt3.Value, drb.legit_item_index[item3.SelectedIndex], 2);
      drb.set_item((int)itemcnt4.Value, drb.legit_item_index[item4.SelectedIndex], 3);
      drb.set_item((int)itemcnt5.Value, drb.legit_item_index[item5.SelectedIndex], 4);
      drb.set_item((int)itemcnt6.Value, drb.legit_item_index[item6.SelectedIndex], 5);
    } else {
      drb.set_poke(pkm1.SelectedIndex, pkmgnd1.SelectedIndex, 0);
      drb.set_poke(pkm2.SelectedIndex, pkmgnd2.SelectedIndex, 1);
      drb.set_poke(pkm3.SelectedIndex, pkmgnd3.SelectedIndex, 2);
      drb.set_poke(pkm4.SelectedIndex, pkmgnd4.SelectedIndex, 3);
      drb.set_poke(pkm5.SelectedIndex, pkmgnd5.SelectedIndex, 4);
      drb.set_poke(pkm6.SelectedIndex, pkmgnd6.SelectedIndex, 5);

      drb.set_item((int)itemcnt1.Value, item1.SelectedIndex, 0);
      drb.set_item((int)itemcnt2.Value, item2.SelectedIndex, 1);
      drb.set_item((int)itemcnt3.Value, item3.SelectedIndex, 2);
      drb.set_item((int)itemcnt4.Value, item4.SelectedIndex, 3);
      drb.set_item((int)itemcnt5.Value, item5.SelectedIndex, 4);
      drb.set_item((int)itemcnt6.Value, item6.SelectedIndex, 5);
    }

    for (int i = 0; i < DreamRadarB.Size; i++) {
      if (drb.Data[i] != 0)
        dra.received = false; //If we have any data, mark as available to be received
    }

    //This is what Dream Radar does, not doing this makes the data be recognized as corrupted.
    dra.unknown1 = 0;
    dra.key = 0;
  }

  void AllmodeCheckedChanged(object sender, EventArgs e) {
    if (allmode.Checked == true) {
      set_all_list();
    } else {
      set_legal_list();
    }
    load_data();
  }

  void LegitmodeCheckedChanged(object sender, EventArgs e) {
    if (allmode.Checked == true) {
      set_all_list();
    } else {
      set_legal_list();
    }
    load_data();
  }

}
