using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShEventEditor;
public partial class Wonder2FashionForm : Form {
  public readonly SAV8SWSH SAV;
  string[] fashionItems;

  public Wonder2FashionForm(SAV8SWSH sav) {
    SAV = sav;
    InitializeComponent();
    fashionItems = [];
  }

  string[] OpenWonderCardDLG(string type) {
    string[] temp = [];
    using (OpenFileDialog dlg = new OpenFileDialog()) {
      dlg.Multiselect = true;
      dlg.Title = $"Please Select Wondercard {type} File";
      dlg.Filter = "Gen 8 Wondercard file (*.wc8)|*.wc8";
      if (dlg.ShowDialog() == DialogResult.OK) {
        temp = dlg.FileNames;
      }
    }
    return temp;
  }

  #region Fashion

  private void fash_openwc8_BTN_Click(object sender, EventArgs e) {
    fashionItems = OpenWonderCardDLG("Fasion");
    foreach (var str in fashionItems) {
      // fash_files_LB.Items.Add(Path.GetFileName(str));
    }
  }

  private void fash_applywc8_BTN_Click(object sender, EventArgs e) {
    fashion_Convert();
  }

  void fashion_Convert() {
    List<KeyValuePair<int, int>> pairs = [];
    //byte blocksize = 0x80;
    int startingpos = 0x20;

    if (SAV.Gender == 1) //female
      startingpos += 0x30;

    foreach (var item in fashionItems) {
      using (BinaryReader br = new BinaryReader(File.Open(item, FileMode.Open))) {
        br.BaseStream.Position = startingpos;
        for (int i = 0; i < 6; i++) { //we only need 12 read operations
          int key = br.ReadInt32(); //index
          int value = br.ReadInt32(); //Binary spot
          pairs.Add(new KeyValuePair<int, int>(key, value));
        }
        br.Close();
      }

      //now we apply the actual data

      for (int i = 0; i < 6; i++) {
        if (pairs[i].Value != -1) {
          //TODO: FIX ME!!!
          //bool[] arr = SAV.Blocks.Fashion.GetArrayOwned(pairs[i].Key);

          //arr[pairs[i].Value] = true;

          //SAV.Blocks.Fashion.SetArrayOwned(9, arr);
        }
      }

    }
  }

  #endregion

  private void ts_apply_BTN_Click(object sender, EventArgs e) {
    Close();
  }
}
