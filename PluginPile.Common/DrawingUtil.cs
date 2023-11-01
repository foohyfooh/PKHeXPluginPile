using PKHeX.Core;
using System.Reflection;

namespace PluginPile.Common;
public class DrawingUtil {

  private static readonly Type ImageUtilType = AssemblyUtil.GetTypeFromAssembly("PKHeX.Drawing", "PKHeX.Drawing.ImageUtil");
  private static readonly Type SpriteUtilType = AssemblyUtil.GetTypeFromAssembly("PKHeX.Drawing.PokeSprite", "PKHeX.Drawing.PokeSprite.SpriteUtil");

  public static Image GetSprite(PKM pkm) {
    MethodInfo getSpriteMethod = SpriteUtilType.GetMethods(BindingFlags.NonPublic | BindingFlags.Static)
      .Single(m => m.Name == "GetSprite" && m.GetParameters().Length == 1);
    return (Image)getSpriteMethod.Invoke(null, new object[] { pkm })!;
  }  

  public static Image GetSprite(ushort species, byte form, int gender, uint formarg, int item, bool isegg, Shiny shiny, EntityContext context = EntityContext.None) {
    MethodInfo getSpriteMethod = SpriteUtilType.GetMethods(BindingFlags.Public | BindingFlags.Static)
      .Single(m => m.Name == "GetSprite" && m.GetParameters().Length == 8);
    return (Image)getSpriteMethod.Invoke(null, new object[] { species, form, gender, formarg, item, isegg, shiny, context })!;
  }

  public static Image LayerImage(Image baseLayer, Image overLayer, int x, int y, double transparency) {
    MethodInfo layerImageMethod = ImageUtilType.GetMethods(BindingFlags.Public | BindingFlags.Static)
      .Single(m => m.Name == "LayerImage" && m.GetParameters().Length == 5);
    return (Image)layerImageMethod.Invoke(null, new object[] { baseLayer, overLayer, x, y, transparency })!;
  }

  public static Image LayerImage(Image baseLayer, Image overLayer, int x, int y) {
    MethodInfo layerImageMethod = ImageUtilType.GetMethods(BindingFlags.Public | BindingFlags.Static)
      .Single(m => m.Name == "LayerImage" && m.GetParameters().Length == 4);
    return (Image)layerImageMethod.Invoke(null, new object[] { baseLayer, overLayer, x, y })!;
  }

  public static Image ToGrayscale(Image img) {
    MethodInfo toGrayscaleMethod = ImageUtilType.GetMethod("ToGrayscale")!;
    return (Image)toGrayscaleMethod.Invoke(null, new object[] { img })!;
  }

}
