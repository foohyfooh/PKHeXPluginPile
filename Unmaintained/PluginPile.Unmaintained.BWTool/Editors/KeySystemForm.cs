using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool;

public partial class KeySystemForm : Form {
  private readonly SAV5B2W2 SAV;
  private readonly Keys keys;

  public KeySystemForm(SAV5B2W2 sav) {
    InitializeComponent();
    SAV = sav;
    keys = new Keys(SAV.GetBlock(Constants.B2W2.Keys));

    if (!keys.KeysUnlocked())
      MessageBox.Show("  Warning!\n\nThis savefile doesn't seem to have unlocked the key system yet.\nKey system is unlocked after beating the Elite Four.\n\nYou can still edit it though.");

    updatekeys();
  }
  public void updatekeys() {
    easykeybox.Checked = keys.GetKeyState(0);
    challengekeybox.Checked = keys.GetKeyState(1);
    citykeybox.Checked = keys.GetKeyState(2);
    ironkeybox.Checked = keys.GetKeyState(3);
    icebergkeybox.Checked = keys.GetKeyState(4);
    easymodebox.Checked = keys.GetKeyState(5);
    challengemodebox.Checked = keys.GetKeyState(6);
    citybox.Checked = keys.GetKeyState(7);
    ironbox.Checked = keys.GetKeyState(8);
    icebergbox.Checked = keys.GetKeyState(9);

    switch (keys.GetConfig(0)) {
      case 0:
        cfg_mode_def.Checked = true;
        break;
      case 1:
        cfg_mode_1.Checked = true;
        break;
      case 2:
        cfg_mode_2.Checked = true;
        break;
      case 3:
        cfg_mode_3.Checked = true;
        break;
    }
    switch (keys.GetConfig(1)) {
      case 0:
        cfg_city_def.Checked = true;
        break;
      case 1:
        cfg_city_game.Checked = true;
        break;
      case 2:
        cfg_city_foreing.Checked = true;
        break;
    }
    switch (keys.GetConfig(2)) {
      case 0:
        cfg_chamber_def.Checked = true;
        break;
      case 1:
        cfg_chamber_rock.Checked = true;
        break;
      case 2:
        cfg_chamber_iron.Checked = true;
        break;
      case 3:
        cfg_chamber_ice.Checked = true;
        break;
    }
  }
  public void setAllkeys() {
    keys.SetKey(easykeybox.Checked, 0);
    keys.SetKey(challengekeybox.Checked, 1);
    keys.SetKey(citykeybox.Checked, 2);
    keys.SetKey(ironkeybox.Checked, 3);
    keys.SetKey(icebergkeybox.Checked, 4);
    keys.SetKey(easymodebox.Checked, 5);
    keys.SetKey(challengemodebox.Checked, 6);
    keys.SetKey(citybox.Checked, 7);
    keys.SetKey(ironbox.Checked, 8);
    keys.SetKey(icebergbox.Checked, 9);
  }
  void Exit_butClick(object sender, EventArgs e) {
    Close();
  }
  void Saveexit_butClick(object sender, EventArgs e) {
    setAllkeys();
    SAV.SetBlock(keys.Data, Constants.B2W2.Keys);
    Close();
  }
}
