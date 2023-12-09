using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShRaidTool;
public partial class SeedFinder : Form {
  private readonly uint TID;
  private readonly uint SID;

  public SeedFinder(uint tid, uint sid) {
    TID = tid;
    SID = sid;
    InitializeComponent();
    CenterToParent();
  }

  public void LoadPKM(PKM pkm) {
    PIDBox.Text = $"{pkm.PID:X8}";
    ECBox.Text = $"{pkm.EncryptionConstant:X8}";

    minHP.Text = $"{pkm.GetIV(0):00}";
    minAtk.Text = $"{pkm.GetIV(1):00}";
    minDef.Text = $"{pkm.GetIV(2):00}";
    MinSpe.Text = $"{pkm.GetIV(3):00}";
    minSpa.Text = $"{pkm.GetIV(4):00}";
    minSpd.Text = $"{pkm.GetIV(5):00}";
  }

  private void SeedBox_KeyPress(object sender, KeyPressEventArgs e) {
    char c = e.KeyChar;
    if (!(Util.IsHex(c) || char.IsControl(e.KeyChar)))
      e.Handled = true;
  }

  private void SeedSlow_Click(object sender, EventArgs e) {
    DialogResult result = WinFormsUtil.Prompt(MessageBoxButtons.YesNo, "This might take several minutes. This method should only be used if the fast one does not yield result. Are you sure you want to use this method?");
    if (result == DialogResult.Yes) {
      if (ECBox.Text.Length == 0) return;
      if (PIDBox.Text.Length == 0) return;
      uint ec = uint.Parse(ECBox.Text, System.Globalization.NumberStyles.HexNumber);
      uint pid = uint.Parse(PIDBox.Text, System.Globalization.NumberStyles.HexNumber);
      int[] ivs = [(int)minHP.Value, (int)minAtk.Value, (int)minDef.Value, (int)minSpa.Value, (int)minSpd.Value, (int)MinSpe.Value,];
      IEnumerable<ulong> seeds = BruteForceSearch.FindSeeds(ec, pid, TID, SID);
      SeedResult.Text = FindFirstSeed(seeds, ivs);
    }
  }

  private static string FindFirstSeed(IEnumerable<ulong> potential_seeds, int[] ivs) {
    foreach (ulong seed in potential_seeds) {
      // Verify the IVs; at most 5 can match
      for (int i = 1; i <= 5; i++) { // fixed IV count
        if (!BruteForceSearch.IsMatch(seed, ivs, i))
          continue;
        return $"{seed:X16}";
      }
    }
    return "No seed found";
  }

  private void SeedFast_Click(object sender, EventArgs e) {
    if (ECBox.Text.Length == 0) return;
    if (PIDBox.Text.Length == 0) return;
    uint ec = uint.Parse(ECBox.Text, System.Globalization.NumberStyles.HexNumber);
    uint pid = uint.Parse(PIDBox.Text, System.Globalization.NumberStyles.HexNumber);
    int[] ivs = [(int)minHP.Value, (int)minAtk.Value, (int)minDef.Value, (int)minSpa.Value, (int)minSpd.Value, (int)MinSpe.Value];
    try {
      IEnumerable<ulong> seeds = Z3Search.GetSeeds(ec, pid);
      SeedResult.Text = FindFirstSeed(seeds, ivs);
    } catch (Exception ex) {
      WinFormsUtil.Error("This method requires Z3. Please add Z3 to your path." + Environment.NewLine + ex.Message, "Cannot calculate seed");
    }
  }

  private void ECBox_Enter(object sender, EventArgs e) {
    TextBox textBox = (TextBox)sender;

    textBox.SelectAll();
  }

  private void MinHP_Enter(object sender, EventArgs e) {
    NumericUpDown numbox = (NumericUpDown)sender;
    numbox.Select(0, numbox.Text.Length);
  }
}
