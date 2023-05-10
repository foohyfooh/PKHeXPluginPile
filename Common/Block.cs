namespace PluginPile.Common {
  public record class Block(uint Location, string Path) {
    public static implicit operator Block((uint, string) t) => new Block(t.Item1, t.Item2);
    public static implicit operator Block(uint l) => new Block(l, string.Empty);
    public static implicit operator uint(Block b) => b.Location;
  }

  public static class BlockExtensions {
    public static bool FilesExist(this IReadOnlyList<Block> blocks, Func<string, string> pathModifier) => blocks.All(b => File.Exists(pathModifier(b.Path)));
  }
}
