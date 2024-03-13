namespace PluginPile.Sorting;
public record class PositionForms(int Position, HashSet<int> Forms) {
  public static implicit operator PositionForms((int, HashSet<int>) t) => new PositionForms(t.Item1, t.Item2);
  public static implicit operator PositionForms((int, int) t) => (t.Item1, new HashSet<int>() { t.Item2 });
  public static implicit operator PositionForms(int p) => (p, 0);
  public static implicit operator PositionForms((int, IEnumerable<int>) t) {
    HashSet<int> f = new HashSet<int>();
    f.UnionWith(t.Item2);
    return new PositionForms(t.Item1, f);
  }
  public static implicit operator PositionForms((int, Range) t) => (t.Item1, Enumerable.Range(t.Item2.Start.Value, t.Item2.End.Value - t.Item2.Start.Value + 1));
}
