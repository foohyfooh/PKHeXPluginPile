using PKHeX.Core;
using System.Reflection;
using System.Resources;

namespace PluginPile.Unmaintained.BWTool;

public partial class GrottoForm : Form {
  private readonly ResourceManager resources = new ResourceManager("PluginPile.Unmaintained.BWTool.GrottoForm", Assembly.GetExecutingAssembly());

  //Hidden Hollow BW2
  /* Structure:
    The block at 0x23B00 contains rival data and hidden hollow information.

    Hidden hollows start at 0xCC in that block. Each hollow takes 2 bytes (40 bytes in total),
    and afterwards there's an additional byte containing the last hidden hollow visited, probably used
    when the game is saved to know at which hollow the game saved (changing this in a save that saved at a hollow
    will warp to that hollow).

    When a hollow regenerates, both bytes for that hollow are randomly generated.

    The first byte determines the content of the hollow:
      - Group A slots range from 0x00 to 0x15
      - Group B slots range from 0x20 to 0x35
      - Group C slots range from 0x40 to 0x55
      - Group D slots range from 0x60 to 0x75
      - A hollow is marked as "used" when the last bit is set to 0 (0x06, 0x1A...)

    The second byte is used to determine the gender of the pokemon in the hollow and
    can range from 0x00 to 0x7F (at least, I haven't seen greater values).
    The gender depends on the hollow and the pokemon female/male ratio for that hollow, see the code for more information.

    To be confirmed if this second byte is used to determine the content of the hollows when
    in a special funfest mission or in the Noisy/Quiet hidden hollow funfest mission.


  */
  public const int GROTTO_START_OFFSET = 0x23B00; //Start offset of block containing rival and hollow data
  public const int HOLLOW_UNKNOWN_OFFSET = 0xC5; //This value might not be related to hidden hollows
  public const int HOLLOW_OFFSET = 0xCC; //Start offset of hollow data
  public const int GROTTO_BLOCK_SIZE = 0x100; //Size of the block
  public const int GROTTO_BLOCK_SIZE_CRC = 0x100 - 0x4; //Size of the block used to calculate CRC checksum
  public const int GROTTO_CRC_OFFSET = 0x100 - 0x2; //Location of CRC checksum
  public const int GROTTO_CRC_TABLE_OFFSET = 0x84; //Location of CRC checksum in checksum table

  //Overworld block (contains swarm byte)
  public const int OVERWORLD_START_OFFSET = 0x21900;//Start offset of block containing swarm data
  public const int SWARM_OFFSET = 0x2C; //Offset of swarm data byte
  public const int OVERWORLD_BLOCK_SIZE = 0x38; //Size of the block
  public const int OVERWORLD_BLOCK_SIZE_CRC = 0x38 - 0x04; //Size of the block used to calculate CRC checksum
  public const int OVERWORLD_CRC_OFFSET = 0x38 - 0x02; //Location of CRC checksum
  public const int OVERWORLD_CRC_TABLE_OFFSET = 0x6E; //Location of CRC checksum in checksum table

  public const int BACKUP_SAVE_OFFSET = 0x26000; //Gap between main save and backup save
  public const int CRC_TABLE = 0x25F00; //CRC table offset
  public const int CRC_TABLE_SIZE = 0x94; //CRC table size
  public const int CRC_TABLE_CRC = 0x25FA2; //CRC table's crc offset

  private readonly SAV5B2W2 SAV;

  private byte grotto = 0x00; //Variable that will hold current grotto data byte 1
  private byte grotto_fun = 0x00; //Variable that will hold current grotto data byte 2 (funfest data?)
  private byte last_grotto = 0x00; //Variable that will hold last visited grotto byte
  private byte grotto_unknown = 0x00;

  private byte swarm = 0x00;

  private readonly byte[] grottobuffer = new byte[GROTTO_BLOCK_SIZE];
  private readonly byte[] overworldbuffer = new byte[OVERWORLD_BLOCK_SIZE];

  public GrottoForm(SAV5B2W2 sav) {
    InitializeComponent();
    SAV = sav;
    unknowngrottobox.Hexadecimal = true;
    Array.Copy(SAV.Data, SAV.AllBlocks[Constants.B2W2.Grotto].Offset, grottobuffer, 0, GROTTO_BLOCK_SIZE);
    Array.Copy(SAV.Data, SAV.AllBlocks[Constants.B2W2.Overworld].Offset, overworldbuffer, 0, OVERWORLD_BLOCK_SIZE);
    LoadGrottoData();
    LoadSwarmData();
    Grotto_route.SelectedIndex = 0;
  }

  void LoadSwarmData() {
    swarm = overworldbuffer[SWARM_OFFSET];
    swarmbox.SelectedIndex = swarm;
  }
  void LoadGrottoData() {
    grotto = grottobuffer[HOLLOW_OFFSET + (Grotto_route.SelectedIndex * 2)];
    grotto_fun = grottobuffer[HOLLOW_OFFSET + (Grotto_route.SelectedIndex * 2) + 1];
    last_grotto = grottobuffer[HOLLOW_OFFSET + 40];
    grotto_unknown = grottobuffer[HOLLOW_OFFSET - 7];

    unknowngrottobox.Value = grotto_unknown;

    lastgrottobox.SelectedIndex = last_grotto;

    //Group
    switch (grotto & 0xF0) {
      case 0x00:
      case 0x10:
        normalgrottogroupbox.SelectedIndex = 0;
        break;
      case 0x20:
      case 0x30:
        normalgrottogroupbox.SelectedIndex = 1;
        break;
      case 0x40:
      case 0x50:
        normalgrottogroupbox.SelectedIndex = 2;
        break;
      case 0x60:
      case 0x70:
        normalgrottogroupbox.SelectedIndex = 3;
        break;
      default:
        break;

    }
    //Slot
    byte check = grotto;
    while (check > 0x1F) {
      check -= 0x20;
    }
    switch (check & 0x1F) {
      case 0x00:
        normalgrottobox.SelectedIndex = 0;
        normalgrottoavailable.Checked = false;
        break;
      case 0x01:
        normalgrottobox.SelectedIndex = 0;
        normalgrottoavailable.Checked = true;
        break;
      case 0x02:
        normalgrottobox.SelectedIndex = 1;
        normalgrottoavailable.Checked = false;
        break;
      case 0x03:
        normalgrottobox.SelectedIndex = 1;
        normalgrottoavailable.Checked = true;
        break;
      case 0x04:
        normalgrottobox.SelectedIndex = 2;
        normalgrottoavailable.Checked = false;
        break;
      case 0x05:
        normalgrottobox.SelectedIndex = 2;
        normalgrottoavailable.Checked = true;
        break;
      case 0x06:
        normalgrottobox.SelectedIndex = 3;
        normalgrottoavailable.Checked = false;
        break;
      case 0x07:
        normalgrottobox.SelectedIndex = 3;
        normalgrottoavailable.Checked = true;
        break;
      case 0x08:
        normalgrottobox.SelectedIndex = 4;
        normalgrottoavailable.Checked = false;
        break;
      case 0x09:
        normalgrottobox.SelectedIndex = 4;
        normalgrottoavailable.Checked = true;
        break;
      case 0x0A:
        normalgrottobox.SelectedIndex = 5;
        normalgrottoavailable.Checked = false;
        break;
      case 0x0B:
        normalgrottobox.SelectedIndex = 5;
        normalgrottoavailable.Checked = true;
        break;
      case 0x0C:
        normalgrottobox.SelectedIndex = 6;
        normalgrottoavailable.Checked = false;
        break;
      case 0x0D:
        normalgrottobox.SelectedIndex = 6;
        normalgrottoavailable.Checked = true;
        break;
      case 0x0F:
        normalgrottobox.SelectedIndex = 7;
        normalgrottoavailable.Checked = false;
        break;
      case 0x0E:
        normalgrottobox.SelectedIndex = 7;
        normalgrottoavailable.Checked = true;
        break;
      case 0x10:
        normalgrottobox.SelectedIndex = 8;
        normalgrottoavailable.Checked = false;
        break;
      case 0x11:
        normalgrottobox.SelectedIndex = 8;
        normalgrottoavailable.Checked = true;
        break;
      case 0x12:
        normalgrottobox.SelectedIndex = 9;
        normalgrottoavailable.Checked = false;
        break;
      case 0x13:
        normalgrottobox.SelectedIndex = 9;
        normalgrottoavailable.Checked = true;
        break;
      case 0x14:
        normalgrottobox.SelectedIndex = 10;
        normalgrottoavailable.Checked = false;
        break;
      case 0x15:
        normalgrottobox.SelectedIndex = 10;
        normalgrottoavailable.Checked = true;
        break;
      case 0x16:
        normalgrottobox.SelectedIndex = 11;
        normalgrottoavailable.Checked = false;
        break;
      case 0x17:
        normalgrottobox.SelectedIndex = 11;
        normalgrottoavailable.Checked = true;
        break;
      case 0x18:
        normalgrottobox.SelectedIndex = 12;
        normalgrottoavailable.Checked = false;
        break;
      case 0x19:
        normalgrottobox.SelectedIndex = 12;
        normalgrottoavailable.Checked = true;
        break;
      case 0x1A:
        normalgrottobox.SelectedIndex = 13;
        normalgrottoavailable.Checked = false;
        break;
      case 0x1B:
        normalgrottobox.SelectedIndex = 13;
        normalgrottoavailable.Checked = true;
        break;
      case 0x1C:
        normalgrottobox.SelectedIndex = 14;
        normalgrottoavailable.Checked = false;
        break;
      case 0x1D:
        normalgrottobox.SelectedIndex = 14;
        normalgrottoavailable.Checked = true;
        break;
      case 0x1E:
        normalgrottobox.SelectedIndex = 15;
        normalgrottoavailable.Checked = false;
        break;
      case 0x1F:
        normalgrottobox.SelectedIndex = 15;
        normalgrottoavailable.Checked = true;
        break;
      default:
        break;
    }
    //Group
    switch (grotto_fun & 0xF0) {
      case 0x00:
      case 0x10:
        fungrottogroupbox.SelectedIndex = 0;
        break;
      case 0x20:
      case 0x30:
        fungrottogroupbox.SelectedIndex = 1;
        break;
      case 0x40:
      case 0x50:
        fungrottogroupbox.SelectedIndex = 2;
        break;
      case 0x60:
      case 0x70:
        fungrottogroupbox.SelectedIndex = 3;
        break;
      default:
        break;

    }
    //Slot
    check = grotto_fun;
    while (check > 0x1F) {
      check -= 0x20;
    }
    switch (check & 0x1F) {
      case 0x00:
        fungrottobox.SelectedIndex = 0;
        fungrottoavailable.Checked = false;
        break;
      case 0x01:
        fungrottobox.SelectedIndex = 0;
        fungrottoavailable.Checked = true;
        break;
      case 0x02:
        fungrottobox.SelectedIndex = 1;
        fungrottoavailable.Checked = false;
        break;
      case 0x03:
        fungrottobox.SelectedIndex = 1;
        fungrottoavailable.Checked = true;
        break;
      case 0x04:
        fungrottobox.SelectedIndex = 2;
        fungrottoavailable.Checked = false;
        break;
      case 0x05:
        fungrottobox.SelectedIndex = 2;
        fungrottoavailable.Checked = true;
        break;
      case 0x06:
        fungrottobox.SelectedIndex = 3;
        fungrottoavailable.Checked = false;
        break;
      case 0x07:
        fungrottobox.SelectedIndex = 3;
        fungrottoavailable.Checked = true;
        break;
      case 0x08:
        fungrottobox.SelectedIndex = 4;
        fungrottoavailable.Checked = false;
        break;
      case 0x09:
        fungrottobox.SelectedIndex = 4;
        fungrottoavailable.Checked = true;
        break;
      case 0x0A:
        fungrottobox.SelectedIndex = 5;
        fungrottoavailable.Checked = false;
        break;
      case 0x0B:
        fungrottobox.SelectedIndex = 5;
        fungrottoavailable.Checked = true;
        break;
      case 0x0C:
        fungrottobox.SelectedIndex = 6;
        fungrottoavailable.Checked = false;
        break;
      case 0x0D:
        fungrottobox.SelectedIndex = 6;
        fungrottoavailable.Checked = true;
        break;
      case 0x0F:
        fungrottobox.SelectedIndex = 7;
        fungrottoavailable.Checked = false;
        break;
      case 0x0E:
        fungrottobox.SelectedIndex = 7;
        fungrottoavailable.Checked = true;
        break;
      case 0x10:
        fungrottobox.SelectedIndex = 8;
        fungrottoavailable.Checked = false;
        break;
      case 0x11:
        fungrottobox.SelectedIndex = 8;
        fungrottoavailable.Checked = true;
        break;
      case 0x12:
        fungrottobox.SelectedIndex = 9;
        fungrottoavailable.Checked = false;
        break;
      case 0x13:
        fungrottobox.SelectedIndex = 9;
        fungrottoavailable.Checked = true;
        break;
      case 0x14:
        fungrottobox.SelectedIndex = 10;
        fungrottoavailable.Checked = false;
        break;
      case 0x15:
        fungrottobox.SelectedIndex = 10;
        fungrottoavailable.Checked = true;
        break;
      case 0x16:
        fungrottobox.SelectedIndex = 11;
        fungrottoavailable.Checked = false;
        break;
      case 0x17:
        fungrottobox.SelectedIndex = 11;
        fungrottoavailable.Checked = true;
        break;
      case 0x18:
        fungrottobox.SelectedIndex = 12;
        fungrottoavailable.Checked = false;
        break;
      case 0x19:
        fungrottobox.SelectedIndex = 12;
        fungrottoavailable.Checked = true;
        break;
      case 0x1A:
        fungrottobox.SelectedIndex = 13;
        fungrottoavailable.Checked = false;
        break;
      case 0x1B:
        fungrottobox.SelectedIndex = 13;
        fungrottoavailable.Checked = true;
        break;
      case 0x1C:
        fungrottobox.SelectedIndex = 14;
        fungrottoavailable.Checked = false;
        break;
      case 0x1D:
        fungrottobox.SelectedIndex = 14;
        fungrottoavailable.Checked = true;
        break;
      case 0x1E:
        fungrottobox.SelectedIndex = 15;
        fungrottoavailable.Checked = false;
        break;
      case 0x1F:
        fungrottobox.SelectedIndex = 15;
        fungrottoavailable.Checked = true;
        break;
      default:
        break;

    }
  }
  void SetSwarmData() {
    overworldbuffer[SWARM_OFFSET] = BitConverter.GetBytes(swarmbox.SelectedIndex)[0];
  }

  void SetLastGrottoData() {
    grottobuffer[HOLLOW_OFFSET + 40] = BitConverter.GetBytes(lastgrottobox.SelectedIndex)[0];
  }

  void SetGrottoData() {
    byte newgrotto = 0x00;
    //Group
    switch (normalgrottobox.SelectedIndex) {
      case 0:
        newgrotto = 0x00;
        break;
      case 1:
        newgrotto = 0x02;
        break;
      case 2:
        newgrotto = 0x04;
        break;
      case 3:
        newgrotto = 0x06;
        break;
      case 4:
        newgrotto = 0x08;
        break;
      case 5:
        newgrotto = 0x0A;
        break;
      case 6:
        newgrotto = 0x0C;
        break;
      case 7:
        newgrotto = 0x0E;
        break;
      case 8:
        newgrotto = 0x10;
        break;
      case 9:
        newgrotto = 0x12;
        break;
      case 10:
        newgrotto = 0x14;
        break;
      case 11:
        newgrotto = 0x16;
        break;
      case 12:
        newgrotto = 0x18;
        break;
      case 13:
        newgrotto = 0x1A;
        break;
      case 14:
        newgrotto = 0x1C;
        break;
      case 15:
        newgrotto = 0x1E;
        break;
      default:
        break;
    }
    if (normalgrottoavailable.Checked) newgrotto += 0x01;
    switch (normalgrottogroupbox.SelectedIndex) {
      case 0:
        newgrotto += 0x00;
        break;
      case 1:
        newgrotto += 0x20;
        break;
      case 2:
        newgrotto += 0x20 * 2;
        break;
      case 3:
        newgrotto += 0x20 * 3;
        break;
      default:
        break;
    }
    grottobuffer[HOLLOW_OFFSET + (Grotto_route.SelectedIndex * 2)] = newgrotto;
  }
  void SetFunGrottoData() {
    byte newgrotto = 0x00;
    //Group
    switch (fungrottobox.SelectedIndex) {
      case 0:
        newgrotto = 0x00;
        break;
      case 1:
        newgrotto = 0x02;
        break;
      case 2:
        newgrotto = 0x04;
        break;
      case 3:
        newgrotto = 0x06;
        break;
      case 4:
        newgrotto = 0x08;
        break;
      case 5:
        newgrotto = 0x0A;
        break;
      case 6:
        newgrotto = 0x0C;
        break;
      case 7:
        newgrotto = 0x0E;
        break;
      case 8:
        newgrotto = 0x10;
        break;
      case 9:
        newgrotto = 0x12;
        break;
      case 10:
        newgrotto = 0x14;
        break;
      case 11:
        newgrotto = 0x16;
        break;
      case 12:
        newgrotto = 0x18;
        break;
      case 13:
        newgrotto = 0x1A;
        break;
      case 14:
        newgrotto = 0x1C;
        break;
      case 15:
        newgrotto = 0x1E;
        break;
    }
    if (fungrottoavailable.Checked) newgrotto += 0x01;
    switch (fungrottogroupbox.SelectedIndex) {
      case 0:
        newgrotto += 0x00;
        break;
      case 1:
        newgrotto += 0x20;
        break;
      case 2:
        newgrotto += 0x20 * 2;
        break;
      case 3:
        newgrotto += 0x20 * 3;
        break;
      default:
        break;
    }

    grottobuffer[HOLLOW_OFFSET + (Grotto_route.SelectedIndex * 2) + 1] = newgrotto;
  }

  void UpdateGenders() {
    switch (fungrottogroupbox.SelectedIndex) {
      case 0:
        if (fungrottobox.SelectedIndex < 15 && fungrottobox.SelectedIndex > 4) {
          gender5.Text = gender10.Text = "M";
          gender30.Text = gender60.Text = "F";
        } else if (fungrottobox.SelectedIndex < 5 && fungrottobox.SelectedIndex > 2) {
          gender5.Text = "M";
          gender10.Text = gender30.Text = gender60.Text = "F";
        } else if (fungrottobox.SelectedIndex < 3) {
          gender5.Text = gender10.Text = gender30.Text = gender60.Text = "F";
        } else {
          gender5.Text = gender10.Text = gender30.Text = gender60.Text = "M";
        }
        break;
      case 1:
        if (fungrottobox.SelectedIndex < 14) {
          gender5.Text = gender10.Text = gender30.Text = "M";
          gender60.Text = "F";
        } else {
          gender5.Text = gender10.Text = gender30.Text = gender60.Text = "M";
        }
        break;
      case 2:
      case 3:
        gender5.Text = gender10.Text = gender30.Text = gender60.Text = "M";
        break;
    }
  }

  void Grotto_routeSelectedIndexChanged(object sender, EventArgs e) {
    LoadGrottoData();
    if (Grotto_route.SelectedIndex > -1) table_but.Enabled = true;
  }

  void FungrottoboxSelectedIndexChanged(object sender, EventArgs e) {
    UpdateGenders();
  }

  void FungrottoavailableCheckedChanged(object sender, EventArgs e) {
    UpdateGenders();
  }

  void FungrottogroupboxSelectedIndexChanged(object sender, EventArgs e) {
    UpdateGenders();
  }

  void Save_buttonClick(object sender, EventArgs e) {
    SetSwarmData();
    //PDR_fix_overworld_checksum();
    SetGrottoData();
    SetFunGrottoData();
    SetLastGrottoData();
    //PDR_fix_grotto_checksum();
    //PDR_injectNsave();

    Array.Copy(grottobuffer, 0, SAV.Data, SAV.AllBlocks[Constants.B2W2.Grotto].Offset, GROTTO_BLOCK_SIZE);
    Array.Copy(grottobuffer, 0, SAV.Data, SAV.AllBlocks[Constants.B2W2.Grotto].Offset + 0x26000, GROTTO_BLOCK_SIZE); //Should not hardcode value...
    Array.Copy(overworldbuffer, 0, SAV.Data, SAV.AllBlocks[Constants.B2W2.Overworld].Offset, OVERWORLD_BLOCK_SIZE);
    Array.Copy(overworldbuffer, 0, SAV.Data, SAV.AllBlocks[Constants.B2W2.Overworld].Offset + 0x26000, OVERWORLD_BLOCK_SIZE); //Should not hardcode value...
    SAV.State.Edited = true;
    Close();
  }

  void LastvisitedhelpClick(object sender, EventArgs e) {
    MessageBox.Show("This value stores the last visited grotto. If you saved within a hidden grotto and modify this value, your savegame will warp its location to the selected hidden grotto.\n\nBeware you can get stuck if you don't have some HM moves in your team required to reach the grotto.");
  }

  void FungrottohelpClick(object sender, EventArgs e) {
    MessageBox.Show("This value seems to be used to determine if there will be a stunky/glameaow in the noisy/quiet grotto funfest mission. Maybe it is only used on special funfest mission like this one (and the event funfest missions for eevee and its evolutions. On this mission, if funfest value has a pokemon 1, 2 or 3 value, a pokemon will appear, if not, the normal grotto item will appear." +
                    "\n\nThis value is randomly set alongside with the normal grotto value when the grotto is regenerated." +
                    "\n\nUnknown/Not used/Buggy: if normal grotto is unavailable and one of this funfest(?) grotto values is available, a ghost dowsing machine item will appear (dowsing detects an item, but it can't be retrieved)." +
                    "\n\nMore testing needed.");
  }

  void ForceFemale_butClick(object sender, EventArgs e) {
    //Input a setting that will make all grotto pokemon female
    fungrottogroupbox.SelectedIndex = 0;
    fungrottobox.SelectedIndex = 0;
  }

  void ForceMale_butClick(object sender, EventArgs e) {
    //Input a setting that will make all grotto pokemon male
    fungrottogroupbox.SelectedIndex = 3;
  }

  void Note_butClick(object sender, EventArgs e) {
    MessageBox.Show("Note: if you have saved inside a grotto that has a pokemon and modify the grotto slot to hold an item, after you load the save you can still trigger a battle with the pokemon. In this case you will battle a level 1 Gurdur (which isn't a pokemon available at hidden grottoes).");
  }

  void Black2table_butClick(object sender, EventArgs e) {
    Form form = new Form();

    PictureBox pictureBox = new PictureBox();
    try {
      pictureBox.Dock = DockStyle.Fill;
      pictureBox.Image = (Bitmap)resources.GetObject("b2_" + Grotto_route.SelectedIndex)!;
      pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
      form.Controls.Add(pictureBox);
      Size size = new Size(720, 300);
      form.Size = size;
      form.Show();
    } catch (FileNotFoundException) {
      MessageBox.Show("There was an error opening the table.\n" +
          "Please check you have included grotto_tables folder in the same path as PluginPile.Unmaintained.BWTool.exe.");
    }
  }

  void Grotto_helpClick(object sender, EventArgs e) {
    if (MessageBox.Show(
            "Open pokemon slots Hidden Grotto spreadsheet in web browser?", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
        ) == DialogResult.Yes) {
      System.Diagnostics.Process.Start("https://sites.google.com/site/pokemonslots/gen-v/hidden-grottos");
    }
  }

  void Exit_butClick(object sender, EventArgs e) => Close();

}
