using System.ComponentModel;

namespace PluginPile.Unmaintained.SwShEventEditor.Controls;
public partial class PokemonBaseUC : UserControl {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
  public PokemonBaseUC() {
    InitializeComponent();
  }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

  public int Pokemon {
    get => pokemonRenderUC1.Pokemon;
    set => pokemonRenderUC1.Pokemon = value;
  }
  public string PokemonSubform {
    get => pokemonRenderUC1.PokemonSubForm;
    set => pokemonRenderUC1.PokemonSubForm = value;
  }

  public PokemonRenderUC.LegalStatus Legalility {
    get => pokemonRenderUC1.Legalility;
    set => pokemonRenderUC1.Legalility = value;
  }

  public bool Caught {
    get => pokemonRenderUC1.Caught;
    set {
      pokemonRenderUC1.Caught = value;
      caught_CB.Checked = value;
      pokemonRenderUC1.Invalidate();
    }
  }

  private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
    //Just to make sure the values are correct
    caughtToolStripMenuItem.Checked = Caught;
    illegalToolStripMenuItem.Text = Legalility == PokemonRenderUC.LegalStatus.Illegal ? "Illegal" : "Legal";
    illegalToolStripMenuItem.Image = Legalility == PokemonRenderUC.LegalStatus.Illegal ? Properties.Resources.warn : Properties.Resources.valid;
  }

  public bool DrawDynaxMaxIcon {
    get => pokemonRenderUC1.DrawDynaxMaxIcon;
    set => pokemonRenderUC1.DrawDynaxMaxIcon = value;
  }

  public string ToolTip {
    get => pokemonRenderUC1.ToolTip;
    set => pokemonRenderUC1.ToolTip = value;
  }

  public string PokemonName {
    get => pokeName.Text;
    set => pokeName.Text = value;
  }

  public event EventHandler LegaliltyCheck_OnClick;

  public event EventHandler Caught_OnClick;

  private void PokemonBaseUC_Load(object sender, EventArgs e) {

  }
  private void caught_CB_CheckedChanged(object sender, EventArgs e) {
    Caught = caught_CB.Checked;
  }

  private void caughtToolStripMenuItem_Click(object sender, EventArgs e) {
    Caught = caughtToolStripMenuItem.Checked;
  }

  private void pokemonRenderUC1_LegaliltyCheck_OnClick(object sender, EventArgs e) {
    LegaliltyCheck_OnClick?.Invoke(sender, e);
  }

  private void illegalToolStripMenuItem_Click(object sender, EventArgs e) {
    LegaliltyCheck_OnClick?.Invoke(sender, e);
  }

  private void pokemonRenderUC1_Caught_OnClick(object sender, EventArgs e) {
    caught_CB.Checked = Caught;
    Caught_OnClick?.Invoke(sender, e);
  }
}
