using PKHeX.Core;

namespace PluginPile.RoamerTool;
public partial class Gen4RoamerControl : UserControl {

  private readonly Roamer4 Roamer;

  public Gen4RoamerControl(Roamer4 roamer) {
    InitializeComponent();
    Roamer = roamer;
    PID.Text = Roamer.PID.ToString("X8");
    Level.Text = Roamer.Level.ToString();
    CurrentHP.Value = Roamer.Stat_HPCurrent;
    NumericUpDown[] formIVs = [HP, Atk, Def, Spa, Spd, Spe];
    int[] roamerIVs = Roamer.IVs;
    for (int i = 0; i < formIVs.Length; i++)
      formIVs[i].Value = roamerIVs[i];
  }

  public void Save() {
    Roamer.PID = Util.GetHexValue(PID.Text);
    Roamer.Level = (byte)Level.Value;
    Roamer.Stat_HPCurrent = (ushort)CurrentHP.Value;
    NumericUpDown[] formIVs = [HP, Atk, Def, Spa, Spd, Spe];
    Roamer.SetIVs(formIVs.Select(nud => (int)nud.Value).ToArray());
  }
}
