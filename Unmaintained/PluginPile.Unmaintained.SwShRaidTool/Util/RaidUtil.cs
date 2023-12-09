using PKHeX.Core;
using PluginPile.Common;
using PluginPile.Unmaintained.SwShRaidTool.Properties;

namespace PluginPile.Unmaintained.SwShRaidTool;
public static class RaidUtil {
  private static readonly Shiny[] shinies = [Shiny.Random, Shiny.AlwaysStar, Shiny.AlwaysSquare, Shiny.Never];
  public static string GetStarString(RaidParameters raidParameters) {
    const string star = "\u2605";
    string output = star;
    for (int i = 0; i < raidParameters.Stars; i++)
      output += star;
    return output;
  }

  public static Image GetRaidResultSprite(RaidPKM raidPkm, bool active) {
    Image sprite = DrawingUtil.GetSprite(raidPkm.Species, raidPkm.AltForm, raidPkm.Gender, 0, 0, false, shinies[raidPkm.ShinyType], EntityContext.Gen8);

    if (raidPkm.IsGigantamax) {
      Bitmap gm = Resources.dyna;
      sprite = DrawingUtil.LayerImage(sprite, gm, (sprite.Width - gm.Width) / 2, 0);
    }

    if (raidPkm.ShinyType == 3) {
      // No Shiny
      Bitmap icon = Resources.no_shiny;
      sprite = DrawingUtil.LayerImage(sprite, icon, 0, 0, 0.7);
    }

    if (!active) {
      sprite = DrawingUtil.ToGrayscale(sprite);
    }

    return sprite;
  }

  public static Bitmap GetNestMap(RaidParameters raidParameters) {
    Pen redPen = new Pen(Color.Red, 10);
    Bitmap map = Resources.map;
    if (raidParameters.Index >= 100) {
      if (raidParameters.Index >= 190) {
        map = Resources.map_ct;
      } else {
        map = Resources.map_ioa;
      }
      using Graphics graphics = Graphics.FromImage(map);
      graphics.DrawArc(redPen, raidParameters.X - 1, raidParameters.Y - 1, 2, 2, 0, 360);
      int start_point_x = raidParameters.X - 172 / 2;
      int start_point_y = raidParameters.Y - 402 / 2;
      if (start_point_x < 0) start_point_x = 0;
      if (start_point_x + 172 > map.Width) start_point_x = map.Width - 172;
      if (start_point_y < 0) start_point_y = 0;
      if (start_point_y + 402 > map.Width) start_point_y = map.Height - 402;
      Rectangle cropRect = new Rectangle(start_point_x, start_point_y, 172, 402);
      Bitmap src = map;
      Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

      using (Graphics g = Graphics.FromImage(target)) {
        g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                         cropRect,
                         GraphicsUnit.Pixel);
      }
      map = target;
    } else {
      using Graphics graphics = Graphics.FromImage(map);
      graphics.DrawArc(redPen, raidParameters.X - 5, raidParameters.Y - 5, 15, 15, 0, 360);
    }

    return map;
  }
}
