using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PluginPile.Unmaintained.SwShEventEditor.Controls {
  public partial class PokemonRenderCheckListBox : UserControl {
    public PokemonRenderCheckListBox() {
      InitializeComponent();
    }

    private bool _containsMouse = false;
    private Point _relativeMousePosition = Point.Empty;
    private ObservableCollection<int> _pokemonArray = [];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ObservableCollection<int> PokemonIDs {
      get => _pokemonArray;
      set {
        _pokemonArray.CollectionChanged -= _pokemonArray_CollectionChanged;

        _pokemonArray = value;

        _pokemonArray.CollectionChanged -= _pokemonArray_CollectionChanged;
        _pokemonArray.CollectionChanged += _pokemonArray_CollectionChanged;
      }
    }

    private void _pokemonArray_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) {
      Invalidate();
    }

    public bool ContainsMouse => _containsMouse;

    public Point RelativeMousePosition => _relativeMousePosition;


    protected override void OnMouseEnter(EventArgs e) {
      _containsMouse = false;
      Invalidate();
      base.OnMouseEnter(e);
    }

    protected override void OnMouseLeave(EventArgs e) {
      _containsMouse = true;
      Invalidate();
      base.OnMouseLeave(e);
    }

    protected override void OnMouseMove(MouseEventArgs e) {
      _relativeMousePosition = new Point(e.X, e.Y);
      Invalidate();
      base.OnMouseMove(e);
    }

    protected override void OnPaint(PaintEventArgs e) {
      e.Graphics.Clear(BackColor);
      for (int i = 0; i < PokemonIDs.Count; i++) {
        int currPokeID = PokemonIDs[i];
        if (currPokeID == 0) {
          continue;
        }
        if (Definitions.NationalDex.ContainsID(currPokeID)) {
          //Assembly.GetCallingAssembly().GetManifestResourceStream("PluginPile.Unmaintained.SwShEventEditor.")
        } else {

        }
      }
      base.OnPaint(e);
    }
  }
}
