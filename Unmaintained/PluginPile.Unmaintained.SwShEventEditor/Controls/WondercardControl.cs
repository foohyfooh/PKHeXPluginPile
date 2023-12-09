namespace PluginPile.Unmaintained.SwShEventEditor.Controls {
  public partial class WondercardControl : UserControl {
    public WondercardControl() {
      InitializeComponent();
    }
    public string GetAtIndex(int Index) {
      return Files[Index];
    }

    public int FileCount {
      get { return Files.Count; }
    }

    readonly List<string> Files = [];

    string[] OpenWonderCardDLG() {
      string[] temp = [];
      using (OpenFileDialog dlg = new OpenFileDialog()) {
        dlg.Multiselect = true;
        dlg.Title = $"Please Select Wondercard File";
        dlg.Filter = "Gen 8 Wondercard file (*.wc8)|*.wc8";
        if (dlg.ShowDialog() == DialogResult.OK) {
          temp = dlg.FileNames;
        }
      }
      return temp;
    }

    private void WondercardControl_Resize(object sender, EventArgs e) {

    }

    private void WondercardControl_Load(object sender, EventArgs e) {

    }

    private void open_wondercard_BTN_Click(object sender, EventArgs e) {
      string[] temp = OpenWonderCardDLG();
      if (temp.Length != 0) {
        foreach (var str in temp) {
          Files.Add(str);
        }
      }
      UpdateLB();
    }

    private void clearlist_BTN_Click(object sender, EventArgs e) {
      Files.Clear();
      main_LB.Items.Clear();
      delete_BTN.Enabled = false;
      clearlist_BTN.Enabled = false;
    }

    private void delete_BTN_Click(object sender, EventArgs e) {
      Files.RemoveAt(main_LB.SelectedIndex);
      UpdateLB();
    }

    void UpdateLB() {
      main_LB.Items.Clear();

      foreach (var str in Files) {
        main_LB.Items.Add(Path.GetFileName(str));
      }

      if (main_LB.SelectedIndex != -1) {
        delete_BTN.Enabled = true;
        clearlist_BTN.Enabled = true;
      } else {
        delete_BTN.Enabled = false;
        clearlist_BTN.Enabled = false;
      }
    }

    private void main_LB_SelectedIndexChanged(object sender, EventArgs e) {
      if (main_LB.SelectedIndex != -1) {
        delete_BTN.Enabled = true;
        clearlist_BTN.Enabled = true;
      } else {
        delete_BTN.Enabled = false;
        clearlist_BTN.Enabled = false;
      }
    }
  }
}
