using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool;

public partial class KeySystemForm : Form {
  private readonly SAV5B2W2 SAV;
  private readonly Keys keys;

  public KeySystemForm(SAV5B2W2 sav) {
    InitializeComponent();
    SAV = sav;
    keys = new Keys(SAV.GetBlock(Constants.B2W2.Keys));

    if (keys.KeysUnlocked() == false)
      MessageBox.Show("  Warning!\n\nThis savefile doesn't seem to have unlocked the key system yet.\nKey system is unlocked after beating the Elite Four.\n\nYou can still edit it though.");

    updatekeys();
  }
  public void updatekeys() {
    easykeybox.Checked = keys.getKeyState(0);
    challengekeybox.Checked = keys.getKeyState(1);
    citykeybox.Checked = keys.getKeyState(2);
    ironkeybox.Checked = keys.getKeyState(3);
    icebergkeybox.Checked = keys.getKeyState(4);
    easymodebox.Checked = keys.getKeyState(5);
    challengemodebox.Checked = keys.getKeyState(6);
    citybox.Checked = keys.getKeyState(7);
    ironbox.Checked = keys.getKeyState(8);
    icebergbox.Checked = keys.getKeyState(9);

    switch (keys.getConfig(0)) {
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
    switch (keys.getConfig(1)) {
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
    switch (keys.getConfig(2)) {
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
    keys.setKey(easykeybox.Checked, 0);
    keys.setKey(challengekeybox.Checked, 1);
    keys.setKey(citykeybox.Checked, 2);
    keys.setKey(ironkeybox.Checked, 3);
    keys.setKey(icebergkeybox.Checked, 4);
    keys.setKey(easymodebox.Checked, 5);
    keys.setKey(challengemodebox.Checked, 6);
    keys.setKey(citybox.Checked, 7);
    keys.setKey(ironbox.Checked, 8);
    keys.setKey(icebergbox.Checked, 9);
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
