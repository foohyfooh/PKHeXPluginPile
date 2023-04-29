namespace PluginPile.SVProfilePictureViewer {

  public static class ColorUtils {

    public static int AveragedGreyscale(this Color color) {
      return (color.R + color.G + color.B) / 3;
    }
    
    public static int LuminosityGreyscale(this Color color) {
      return (int)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B);
    }

    public static int LightnessGreyscale(this Color color) {
      int min = Math.Min(color.R, Math.Min(color.G, color.B));
      int max = Math.Max(color.R, Math.Max(color.G, color.B));
      return (min + max) / 2;
    }

  }
}
