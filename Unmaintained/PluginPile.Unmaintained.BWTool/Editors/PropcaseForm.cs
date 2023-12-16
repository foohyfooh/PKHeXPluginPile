using PKHeX.Core;
using System.Reflection;
using System.Resources;

namespace PluginPile.Unmaintained.BWTool;

public partial class PropcaseForm : Form {
  private readonly SAV5 Origin, SAV;
  private readonly Musical5 Musical;
  private readonly ResourceManager resources = new ResourceManager("PluginPile.Unmaintained.BWTool.PropcaseForm", Assembly.GetExecutingAssembly());

  public PropcaseForm(SAV5 sav) {
    InitializeComponent();
    SAV = (SAV5)(Origin = sav).Clone();
    Musical = SAV.Musical;
    Proplist.SelectedIndex = 0;
    HasPropCheckbox.Checked = Musical.GetHasProp(Proplist.SelectedIndex);
    PropHex.Text = "0x" + BitConverter.ToString(Musical.Data);
  }

  void ShowProp() {
    string cur_sprite = "Prop_" + Proplist.Text + "_Sprite";
    cur_sprite = cur_sprite.Replace(" ", "_");
    cur_sprite = cur_sprite.Replace("'", string.Empty);
    SpriteBox.Image = (Bitmap)resources.GetObject(cur_sprite)!;
  }

  void ProplistSelectedIndexChanged(object sender, EventArgs e) {
    HasPropCheckbox.Checked = Musical.GetHasProp(Proplist.SelectedIndex);
    ShowProp();
  }

  void Hasprop_checkboxCheckedChanged(object sender, EventArgs e) {
    Musical.SetHasProp(Proplist.SelectedIndex, HasPropCheckbox.Checked);
    PropHex.Text = "0x" + BitConverter.ToString(Musical.Data);
  }

  void Exit_Click(object sender, EventArgs e) => Close();

  void Save_Click(object sender, EventArgs e) {
    //Check that there's at least one prop
    int i = 0;
    while (i < 100) {
      if (Musical.GetHasProp(i)) break;
      i++;
      if (i == 100) {
        MessageBox.Show("Warning! Game will freeze if you have no props. Pink Barrette has been set by default.");
        Musical.SetHasProp(0, true); //Set at least one prop
      }
    }
    Origin.CopyChangesFrom(SAV);
    Close();
  }

  void UnlockAll_Click(object sender, EventArgs e) {
    Musical.UnlockAllMusicalProps();
    ShowProp();
  }

  void RemoveAll_Click(object sender, EventArgs e) {
    for (int i = 0; i < 100; i++)
      Musical.SetHasProp(i, false);
    PropHex.Text = "0x" + BitConverter.ToString(Musical.Data);
    HasPropCheckbox.Checked = Musical.GetHasProp(Proplist.SelectedIndex);
    ShowProp();
  }
}
