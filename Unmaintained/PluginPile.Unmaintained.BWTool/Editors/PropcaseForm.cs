using PKHeX.Core;
using System.Reflection;
using System.Resources;

namespace PluginPile.Unmaintained.BWTool;

public partial class PropcaseForm : Form {
  private readonly SAV5 SAV;
  private readonly Propcase MyProps;
  private readonly ResourceManager resources = new ResourceManager("PluginPile.Unmaintained.BWTool.PropcaseForm", Assembly.GetExecutingAssembly());

  public PropcaseForm(SAV5 sav) {
    InitializeComponent();
    SAV = sav;
    MyProps = new Propcase(SAV.GetData(0x1F958, 13)); //Same offset for BW1 and BW2. Should update to block management...
    Proplist.SelectedIndex = 0;
    HasPropCheckbox.Checked = MyProps.GetProp(Proplist.SelectedIndex);
    PropHex.Text = "0x" + BitConverter.ToString(MyProps.Data);
  }

  void ShowProp() {
    string cur_sprite = "Prop_" + Proplist.Text + "_Sprite";
    cur_sprite = cur_sprite.Replace(" ", "_");
    cur_sprite = cur_sprite.Replace("'", string.Empty);
    SpriteBox.Image = (Bitmap)resources.GetObject(cur_sprite)!;
  }

  void ProplistSelectedIndexChanged(object sender, EventArgs e) {
    HasPropCheckbox.Checked = MyProps.GetProp(Proplist.SelectedIndex);
    ShowProp();
  }

  void Hasprop_checkboxCheckedChanged(object sender, EventArgs e) {
    MyProps.SetProp(Proplist.SelectedIndex, HasPropCheckbox.Checked);
    PropHex.Text = "0x" + BitConverter.ToString(MyProps.Data);
  }

  void Exit_butClick(object sender, EventArgs e) => Close();

  void Saveexit_butClick(object sender, EventArgs e) {
    //Check that there's at least one prop
    int i = 0;
    while (i < 100) {
      if (MyProps.GetProp(i) == true) break;
      i++;
      if (i == 100) {
        MessageBox.Show("Warning! Game will freeze if you have no props. Pink Barrette has been set by default.");
        MyProps.SetProp(0, true); //Set at least one prop
      }
    }

    SAV.SetData(MyProps.Data, 0x1F958);
    //Mirror
    SAV.SetData(MyProps.Data, 0x45958);
    //Update Checksum
    SAV.SetBlock(SAV.GetBlock(Constants.Musical), Constants.Musical);
    Close();
  }

  void UnlockAllButClick(object sender, EventArgs e) {
    for (int i = 0; i < 100; i++)
      MyProps.SetProp(i, true);
    PropHex.Text = "0x" + BitConverter.ToString(MyProps.Data);
    HasPropCheckbox.Checked = MyProps.GetProp(Proplist.SelectedIndex);
    ShowProp();
  }

  void RemoveAllButClick(object sender, EventArgs e) {
    for (int i = 0; i < 100; i++)
      MyProps.SetProp(i, false);
    PropHex.Text = "0x" + BitConverter.ToString(MyProps.Data);
    HasPropCheckbox.Checked = MyProps.GetProp(Proplist.SelectedIndex);
    ShowProp();
  }
}
