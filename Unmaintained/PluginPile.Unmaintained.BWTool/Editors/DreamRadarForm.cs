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

    if (!dra.Received) {
      MessageBox.Show("Warning! There's unreceived data in the savegame!");
      dra.Key = drb.EncKey ^ drkey.FLAGS;//This makes editing the data possible without messing up the current encryption
    }

    if (drb.illegal) {
      allmode.Checked = true;
      SetAllLlist();
    } else {
      legitmode.Checked = true;
      SetLegalList();
    }

    LoadData();
  }
  void Exit_butClick(object sender, EventArgs e) => Close();

  void Saveexit_butClick(object sender, EventArgs e) {
    SetData();
    SAV.SetBlock(drkey.Data, Constants.B2W2.DreamRadarKey);
    SAV.SetDSLinkA(dra.Data);
    SAV.SetDSLinkB(drb.Data);
    Close();
  }

  void Clean_butClick(object sender, EventArgs e) { //Right now this button is disabled as we know how to edit all the data
    drkey.ReInit();
    dra.ReInit();
    drb.ReInit();

    SAV.SetBlock(drkey.Data, Constants.B2W2.DreamRadarKey);
    SAV.SetDSLinkA(dra.Data);
    SAV.SetDSLinkB(drb.Data);
    Close();
  }

  void SetLegalList() {
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

  void SetAllLlist() {
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

  int Poke2Legit(int species) {
    if (legitmode.Checked) {
      for (int i = 0; i < 19; i++) {
        if (species == drb.legit_pk_index[i])
          return i;
      }
    }
    return species;
  }

  int Item2Legit(int item) {
    if (legitmode.Checked) {
      for (int i = 0; i < 24; i++) {
        if (item == drb.legit_item_index[i])
          return i;
      }
    }
    return item;
  }

  void LoadData() {
    pkm1.SelectedIndex = Poke2Legit(drb.GePokeSpecies(0));
    pkm2.SelectedIndex = Poke2Legit(drb.GePokeSpecies(1));
    pkm3.SelectedIndex = Poke2Legit(drb.GePokeSpecies(2));
    pkm4.SelectedIndex = Poke2Legit(drb.GePokeSpecies(3));
    pkm5.SelectedIndex = Poke2Legit(drb.GePokeSpecies(4));
    pkm6.SelectedIndex = Poke2Legit(drb.GePokeSpecies(5));

    item1.SelectedIndex = Item2Legit(drb.GetItemId(0));
    item2.SelectedIndex = Item2Legit(drb.GetItemId(1));
    item3.SelectedIndex = Item2Legit(drb.GetItemId(2));
    item4.SelectedIndex = Item2Legit(drb.GetItemId(3));
    item5.SelectedIndex = Item2Legit(drb.GetItemId(4));
    item6.SelectedIndex = Item2Legit(drb.GetItemId(5));

    pkmgnd1.SelectedIndex = drb.GetPokeGender(0);
    pkmgnd2.SelectedIndex = drb.GetPokeGender(1);
    pkmgnd3.SelectedIndex = drb.GetPokeGender(2);
    pkmgnd4.SelectedIndex = drb.GetPokeGender(3);
    pkmgnd5.SelectedIndex = drb.GetPokeGender(4);
    pkmgnd6.SelectedIndex = drb.GetPokeGender(5);

    itemcnt1.Value = drb.GetItemAmount(0);
    itemcnt2.Value = drb.GetItemAmount(1);
    itemcnt3.Value = drb.GetItemAmount(2);
    itemcnt4.Value = drb.GetItemAmount(3);
    itemcnt5.Value = drb.GetItemAmount(4);
    itemcnt6.Value = drb.GetItemAmount(5);

    legend1.SelectedIndex = drb.GetLegend(0);
    legend2.SelectedIndex = drb.GetLegend(1);
    legend3.SelectedIndex = drb.GetLegend(2);
    legend4.SelectedIndex = drb.GetLegend(3);
    legend5.SelectedIndex = drb.GetLegend(4);
    legend6.SelectedIndex = drb.GetLegend(5);
    legend7.SelectedIndex = drb.GetLegend(6);
    legend8.SelectedIndex = drb.GetLegend(7);

    flag0.Checked = drkey.Tornadus;
    flag1.Checked = drkey.Thundurus;
    flag2.Checked = drkey.Landorus;
    flag3.Checked = drkey.Dialga;
    flag4.Checked = drkey.Palkia;
    flag5.Checked = drkey.Giratina;
    flag6.Checked = drkey.HoOh;
    flag7.Checked = drkey.Lugia;
  }

  void SetData() {
    //Get the correct intial key before changing the flags
    drb.EncKey = dra.Key ^ drkey.FLAGS;

    //Set the flags
    drkey.Tornadus = flag0.Checked;
    drkey.Thundurus = flag1.Checked;
    drkey.Landorus = flag2.Checked;
    drkey.Dialga = flag3.Checked;
    drkey.Palkia = flag4.Checked;
    drkey.Giratina = flag5.Checked;
    drkey.HoOh = flag6.Checked;
    drkey.Lugia = flag7.Checked;

    drb.CleanData(); //Set everything to 0 first
                     //Legendary slots
    drb.SetLegend(drb.legendary_index[legend1.SelectedIndex], 0);
    drb.SetLegend(drb.legendary_index[legend2.SelectedIndex], 1);
    drb.SetLegend(drb.legendary_index[legend3.SelectedIndex], 2);
    drb.SetLegend(drb.legendary_index[legend4.SelectedIndex], 3);
    drb.SetLegend(drb.legendary_index[legend5.SelectedIndex], 4);
    drb.SetLegend(drb.legendary_index[legend6.SelectedIndex], 5);
    drb.SetLegend(drb.legendary_index[legend7.SelectedIndex], 6);
    drb.SetLegend(drb.legendary_index[legend8.SelectedIndex], 7);

    if (legitmode.Checked) {
      drb.SetPoke(drb.legit_pk_index[pkm1.SelectedIndex], pkmgnd1.SelectedIndex, 0);
      drb.SetPoke(drb.legit_pk_index[pkm2.SelectedIndex], pkmgnd2.SelectedIndex, 1);
      drb.SetPoke(drb.legit_pk_index[pkm3.SelectedIndex], pkmgnd3.SelectedIndex, 2);
      drb.SetPoke(drb.legit_pk_index[pkm4.SelectedIndex], pkmgnd4.SelectedIndex, 3);
      drb.SetPoke(drb.legit_pk_index[pkm5.SelectedIndex], pkmgnd5.SelectedIndex, 4);
      drb.SetPoke(drb.legit_pk_index[pkm6.SelectedIndex], pkmgnd6.SelectedIndex, 5);

      drb.SetItem((int)itemcnt1.Value, drb.legit_item_index[item1.SelectedIndex], 0);
      drb.SetItem((int)itemcnt2.Value, drb.legit_item_index[item2.SelectedIndex], 1);
      drb.SetItem((int)itemcnt3.Value, drb.legit_item_index[item3.SelectedIndex], 2);
      drb.SetItem((int)itemcnt4.Value, drb.legit_item_index[item4.SelectedIndex], 3);
      drb.SetItem((int)itemcnt5.Value, drb.legit_item_index[item5.SelectedIndex], 4);
      drb.SetItem((int)itemcnt6.Value, drb.legit_item_index[item6.SelectedIndex], 5);
    } else {
      drb.SetPoke(pkm1.SelectedIndex, pkmgnd1.SelectedIndex, 0);
      drb.SetPoke(pkm2.SelectedIndex, pkmgnd2.SelectedIndex, 1);
      drb.SetPoke(pkm3.SelectedIndex, pkmgnd3.SelectedIndex, 2);
      drb.SetPoke(pkm4.SelectedIndex, pkmgnd4.SelectedIndex, 3);
      drb.SetPoke(pkm5.SelectedIndex, pkmgnd5.SelectedIndex, 4);
      drb.SetPoke(pkm6.SelectedIndex, pkmgnd6.SelectedIndex, 5);

      drb.SetItem((int)itemcnt1.Value, item1.SelectedIndex, 0);
      drb.SetItem((int)itemcnt2.Value, item2.SelectedIndex, 1);
      drb.SetItem((int)itemcnt3.Value, item3.SelectedIndex, 2);
      drb.SetItem((int)itemcnt4.Value, item4.SelectedIndex, 3);
      drb.SetItem((int)itemcnt5.Value, item5.SelectedIndex, 4);
      drb.SetItem((int)itemcnt6.Value, item6.SelectedIndex, 5);
    }

    for (int i = 0; i < DreamRadarB.Size; i++) {
      if (drb.Data[i] != 0)
        dra.Received = false; //If we have any data, mark as available to be received
    }

    //This is what Dream Radar does, not doing this makes the data be recognized as corrupted.
    dra.Unknown1 = 0;
    dra.Key = 0;
  }

  void AllmodeCheckedChanged(object sender, EventArgs e) {
    if (allmode.Checked) {
      SetAllLlist();
    } else {
      SetLegalList();
    }
    LoadData();
  }

  void LegitmodeCheckedChanged(object sender, EventArgs e) {
    if (allmode.Checked) {
      SetAllLlist();
    } else {
      SetLegalList();
    }
    LoadData();
  }

}
