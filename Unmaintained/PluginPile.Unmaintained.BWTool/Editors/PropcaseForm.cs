using PKHeX.Core;
using System.Reflection;
using System.Resources;

namespace PluginPile.Unmaintained.BWTool;

public partial class PropcaseForm : Form {
  private readonly SAV5 SAV;
  private readonly Propcase myProps;
  private readonly ResourceManager resources = new ResourceManager("PluginPile.Unmaintained.BWTool.PropcaseForm", Assembly.GetExecutingAssembly());

  public PropcaseForm(SAV5 sav) {
    InitializeComponent();
    SAV = sav;
    myProps = new Propcase(SAV.GetData(0x1F958, 13)); //Same offset for BW1 and BW2. Should update to block management...
    Proplist.SelectedIndex = 0;
    hasprop_checkbox.Checked = myProps.getProp(Proplist.SelectedIndex);
    propHex.Text = "0x" + BitConverter.ToString(myProps.Data);
  }

  void showProp() {
    string cur_sprite = "Prop_" + Proplist.Text + "_Sprite";
    cur_sprite = cur_sprite.Replace(" ", "_");
    cur_sprite = cur_sprite.Replace("'", string.Empty);
    spriteBox.Image = (Bitmap)resources.GetObject(cur_sprite)!;
  }

  void ProplistSelectedIndexChanged(object sender, EventArgs e) {
    hasprop_checkbox.Checked = myProps.getProp(Proplist.SelectedIndex);
    showProp();
  }

  void Hasprop_checkboxCheckedChanged(object sender, EventArgs e) {
    myProps.setProp(Proplist.SelectedIndex, hasprop_checkbox.Checked);
    propHex.Text = "0x" + BitConverter.ToString(myProps.Data);
  }

  void Exit_butClick(object sender, EventArgs e) => Close();

  void Saveexit_butClick(object sender, EventArgs e) {
    //Check that there's at least one prop
    int i = 0;
    while (i < 100) {
      if (myProps.getProp(i) == true) break;
      i++;
      if (i == 100) {
        MessageBox.Show("Warning! Game will freeze if you have no props. Pink Barrette has been set by default.");
        myProps.setProp(0, true); //Set at least one prop
      }
    }

    SAV5Extensions.SetData(SAV, myProps.Data, 0x1F958);
    //Mirror
    SAV5Extensions.SetData(SAV, myProps.Data, 0x45958);
    //Update Checksum
    SAV.SetBlock(SAV.GetBlock(Constants.Musical), Constants.Musical);
    Close();
  }

  void UnlockAllButClick(object sender, EventArgs e) {
    for (int i = 0; i < 100; i++)
      myProps.setProp(i, true);
    propHex.Text = "0x" + BitConverter.ToString(myProps.Data);
    hasprop_checkbox.Checked = myProps.getProp(Proplist.SelectedIndex);
    showProp();
  }

  void RemoveAllButClick(object sender, EventArgs e) {;
    for (int i = 0; i < 100; i++)
      myProps.setProp(i, false);
    propHex.Text = "0x" + BitConverter.ToString(myProps.Data);
    hasprop_checkbox.Checked = myProps.getProp(Proplist.SelectedIndex);
    showProp();
  }
}
