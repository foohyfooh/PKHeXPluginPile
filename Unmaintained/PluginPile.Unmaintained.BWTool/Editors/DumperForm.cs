using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool;

public partial class DumperForm : Form {

  private readonly SAV5 SAV;
  private int blockindex = 0;

  public DumperForm(SAV5 sav) {
    InitializeComponent();
    SAV = sav;
    if (sav is SAV5BW) {
      selectedblock.Visible = false;
      BW_blocklist.Visible = true;
      BW_blocklist.SelectedIndex = 0;
      BW_blocklist.DropDownStyle = ComboBoxStyle.DropDownList;
      blockindex = BW_blocklist.SelectedIndex;
    } else { // sav is SAV5B2W2
      selectedblock.Visible = true;
      BW_blocklist.Visible = false;
      selectedblock.SelectedIndex = 0;
      selectedblock.DropDownStyle = ComboBoxStyle.DropDownList;
      blockindex = selectedblock.SelectedIndex;
    }
  }

  public string binaryfilter = "Binary data|*.bin|All Files (*.*)|*.*";
  void Dump_butClick(object sender, EventArgs e) {
    SaveFileDialog saveFD = new SaveFileDialog();
    saveFD.Filter = binaryfilter;
    if (saveFD.ShowDialog() == DialogResult.OK) {
      System.IO.FileStream saveFile;
      saveFile = new FileStream(saveFD.FileName, FileMode.Create);
      //Write file
      saveFile.Write(SAV.GetBlock(blockindex)!, 0, SAV.GetBlockLength(blockindex));
      saveFile.Close();
      MessageBox.Show("File Saved.", "Save file");
    }
  }
  
  void Inject_butClick(object sender, EventArgs e) {
    byte[]? injectfile = null;
    string? path = null;
    int res = FileIO.LoadFile(ref injectfile, ref path, binaryfilter);
    if (res != -1)
      SAV.SetBlock(injectfile!, blockindex);
  }
  void Dump_dec_butClick(object sender, EventArgs e) {
    SaveFileDialog saveFD = new SaveFileDialog();
    saveFD.Filter = binaryfilter;
    if (saveFD.ShowDialog() == DialogResult.OK) {
      System.IO.FileStream saveFile;
      saveFile = new FileStream(saveFD.FileName, FileMode.Create);
      //Write file
      saveFile.Write(SAV.GetBlockDec(blockindex)!, 0, SAV.GetBlockLength(blockindex));
      saveFile.Close();
      MessageBox.Show("File Saved.", "Save file");
    }
  }
  void Inject_crypt_butClick(object sender, EventArgs e) {
    byte[]? injectfile = null;
    string? path = null;
    int res = FileIO.LoadFile(ref injectfile, ref path, binaryfilter);
    if (res != -1)
      SAV.SetBlock(injectfile!, blockindex);
  }

  void Crypt_checkCheckedChanged(object sender, EventArgs e) {
    if (SAV.GetEnc().ContainsKey(blockindex)) {
      dump_dec_but.Enabled = true;
      inject_crypt_but.Enabled = true;
    } else {
      dump_dec_but.Enabled = false;
      inject_crypt_but.Enabled = false;
    }
  }

  void SelectedblockSelectedIndexChanged(object sender, EventArgs e) {
    blockindex = selectedblock.SelectedIndex;
    crypt_check.Checked = SAV.GetEnc().ContainsKey(blockindex);
  }

  void BW_blocklistSelectedIndexChanged(object sender, EventArgs e) {
    blockindex = BW_blocklist.SelectedIndex;
    crypt_check.Checked = SAV.GetEnc().ContainsKey(blockindex);
  }
}
