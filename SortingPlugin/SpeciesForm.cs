using PKHeX.Core;

namespace PluginPile.SortingPlugin {
  public record class SpeciesForm(Species Species, int Form) {
    public static implicit operator SpeciesForm((Species, int) t) => new SpeciesForm(t.Item1, t.Item2);
    public static implicit operator SpeciesForm((ushort, byte) t) => new SpeciesForm((Species)t.Item1, t.Item2);
    public static implicit operator SpeciesForm(Species s) => new SpeciesForm(s, 0);
  }
}
