namespace PluginPile.Unmaintained.SwShEventEditor.Controls {
  public partial class PokemonRenderUC : UserControl {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public PokemonRenderUC() {
      InitializeComponent();
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    private Image pokemon;
    private string pokemonsubform;

    public string PokemonSubForm {
      get {
        return pokemonsubform;
      }
      set {
        pokemonsubform = value;
        SetupPokemon();
      }
    }


    private int pokemonID;
    public int Pokemon {
      get {
        return pokemonID;
      }
      set {
        pokemonID = value;
        SetupPokemon();
      }
    }

    public enum LegalStatus { Illegal, Legal }
    private LegalStatus legalstatus;
    public LegalStatus Legalility {
      get { return legalstatus; }
      set {
        legalstatus = value;
        this.Invalidate();
      }
    }

    private bool messageicon;
    public bool ShowMessageIcon {
      get { return messageicon; }
      set {
        messageicon = value;
      }
    }

    private bool caught;
    public bool Caught {
      get { return caught; }
      set {
        caught = value;
        this.Invalidate();
        Caught_OnClick?.Invoke(this, new EventArgs());
      }
    }

    public string ToolTip {
      get { return toolTip1.GetToolTip(this); }
      set {
        toolTip1.SetToolTip(this, value);
      }
    }
    void SetupPokemon() {
      pokemon?.Dispose();

      string pokemonstr = $"b_{pokemonID}";
      if (pokemonsubform != "" && pokemonsubform != "0")
        pokemonstr += $"_{pokemonsubform}";

      pokemon = (Bitmap)Properties.Resources.ResourceManager.GetObject(pokemonstr)!;
      if (pokemon == null)
        pokemon = (Bitmap)Properties.Resources.ResourceManager.GetObject("0")!;
      this.Invalidate();

    }

    private bool drawDyna;
    public bool DrawDynaxMaxIcon {
      get { return drawDyna; }
      set { drawDyna = value; }
    }
    public event EventHandler LegaliltyCheck_OnClick;
    public event EventHandler Caught_OnClick;

    Point MousePos = new Point();
    public bool capturedMouse;
    private void PokemonRenderUC_Load(object sender, EventArgs e) {

    }

    private void PokemonRenderUC_Paint(object sender, PaintEventArgs e) {
      e.Graphics.Clear(Color.LightGray);


      e.Graphics.DrawImage(pokemon, 0, 0);

      if (capturedMouse) {
        e.Graphics.DrawImage(Properties.Resources.slotHover68, 0, 0);
      }
      if (caught)
        e.Graphics.DrawImage(Properties.Resources._ball4, this.Width - 15, this.Height - 15, 15, 15);

      if (messageicon)
        e.Graphics.DrawImage(Properties.Resources.hint, 0, this.Height - 16);

      if (legalstatus == LegalStatus.Illegal)
        e.Graphics.DrawImage(Properties.Resources.warn, 0, 0);
      else
        e.Graphics.DrawImage(Properties.Resources.valid, 0, 0);
      if (drawDyna)
        e.Graphics.DrawImage(Properties.Resources.dyna, this.Width - 20, 0);
    }

    private void PokemonRenderUC_MouseMove(object sender, MouseEventArgs e) {
      MousePos.X = e.X;
      MousePos.Y = e.Y;
      this.Invalidate();

    }

    private void PokemonRenderUC_MouseEnter(object sender, EventArgs e) {
      capturedMouse = true;
      this.Invalidate();
    }

    private void PokemonRenderUC_MouseLeave(object sender, EventArgs e) {
      capturedMouse = false;
      this.Invalidate();
    }

    private void PokemonRenderUC_MouseDown(object sender, MouseEventArgs e) {
      MousePos.X = e.X;
      MousePos.Y = e.Y;
      if (e.Button == MouseButtons.Left && !shift && !control) {
        if ((e.X >= 0 && e.X <= 16) && (e.Y >= 0 && e.Y <= 16))
          LegaliltyCheck_OnClick?.Invoke(sender, e);
      } else if (e.Button == MouseButtons.Left && shift) {
        LegaliltyCheck_OnClick?.Invoke(sender, e);
      } else if (e.Button == MouseButtons.Left && control) {
        Caught = !Caught;
      }
      this.Invalidate();
    }

    bool shift;
    bool control;

    private void PokemonRenderUC_KeyUp(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case (Keys.LShiftKey):
          shift = false;
          break;
        case (Keys.ControlKey):
          control = false;
          break;
      }

    }

    private void PokemonRenderUC_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case (Keys.ShiftKey):
          shift = true;
          break;
        case (Keys.ControlKey):
          control = true;
          break;
      }
    }
  }
}
