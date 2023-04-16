using PKHeX.Core;

namespace PluginPile.FashionEditor {
  public partial class FashionFormSwSh : Form {

    private readonly SAV8SWSH sav;

    private readonly FashionPageSelector topsSelector;
    private readonly FashionPageSelector jacketsSelector;
    private readonly FashionPageSelector bottomsSelector;
    private readonly FashionPageSelector socksSelector;
    private readonly FashionPageSelector shoesSelector;
    private readonly FashionPageSelector bagsSelector;
    private readonly FashionPageSelector hatsSelector;
    private readonly FashionPageSelector glassesSelector;
    private readonly FashionPageSelector glovesSelector;

    public FashionFormSwSh(SAV8SWSH sav8swsh) {
      InitializeComponent();
      sav = sav8swsh;
      HandleLanguageChange();

      topsSelector = NewSelector(SwShConstants.TopsRegion, Language.SwSh.TopsList);
      jacketsSelector = NewSelector(SwShConstants.JacketsRegion, Language.SwSh.JacketsList);
      bottomsSelector = NewSelector(SwShConstants.BotttomsRegion, Language.SwSh.BottomsList);
      socksSelector = NewSelector(SwShConstants.SocksRegion, Language.SwSh.SocksList);
      shoesSelector = NewSelector(SwShConstants.ShoesRegion, Language.SwSh.ShoesList);
      bagsSelector = NewSelector(SwShConstants.BagsRegion, Language.SwSh.BagsList);
      hatsSelector = NewSelector(SwShConstants.HatsRegion, Language.SwSh.HatsList);
      glassesSelector = NewSelector(SwShConstants.GlassesRegion, Language.SwSh.GlassesList);
      glovesSelector = NewSelector(SwShConstants.GlovesRegion, Language.SwSh.GlovesList);

      topsPage.Controls.Add(topsSelector);
      jacketsPage.Controls.Add(jacketsSelector);
      bottomsPage.Controls.Add(bottomsSelector);
      socksPage.Controls.Add(socksSelector);
      shoesPage.Controls.Add(shoesSelector);
      bagsPage.Controls.Add(bagsSelector);
      hatsPage.Controls.Add(hatsSelector);
      glassesPage.Controls.Add(glassesSelector);
      glovesPage.Controls.Add(glovesSelector);
    }

    private void HandleLanguageChange() {
      Text = Language.Title;
      cancelButton.Text = Language.Cancel;
      saveButton.Text = Language.Save;
      topsPage.Text = Language.SwSh.Tops;
      jacketsPage.Text = Language.SwSh.Jackets;
      bottomsPage.Text = Language.SwSh.Bottoms;
      if (sav.Gender == 1) bottomsPage.Text += $"/{Language.SwSh.Dresses}"; 
      socksPage.Text = Language.SwSh.Socks;
      shoesPage.Text = Language.SwSh.Shoes;
      bagsPage.Text = Language.SwSh.Bags;
      hatsPage.Text = Language.SwSh.Hats;
      glassesPage.Text = Language.SwSh.Glasses;
      glovesPage.Text = Language.SwSh.Gloves;
    }

    private void cancelButton_Click(object sender, EventArgs e) => Close();

    private void saveButton_Click(object sender, EventArgs e) {
      SetFlags(topsSelector, SwShConstants.TopsRegion);
      SetFlags(jacketsSelector, SwShConstants.JacketsRegion);
      SetFlags(bottomsSelector, SwShConstants.BotttomsRegion);
      SetFlags(socksSelector, SwShConstants.SocksRegion);
      SetFlags(shoesSelector, SwShConstants.ShoesRegion);
      SetFlags(bagsSelector, SwShConstants.BagsRegion);
      SetFlags(hatsSelector, SwShConstants.HatsRegion);
      SetFlags(glassesSelector, SwShConstants.GlassesRegion);
      SetFlags(glovesSelector, SwShConstants.GlovesRegion);
      sav.State.Edited = true;
      Close();
    }

    private FashionPageSelector NewSelector(int region, Func<int, string[]> textList) {
      bool[] OwnedFlags(int region) => sav.Blocks.Fashion.GetArrayOwnedFlag(region);
      bool[] NewFlags(int region) => sav.Blocks.Fashion.GetArrayNewFlag(region).Select((b, i) => !b).ToArray();
      return new FashionPageSelector(OwnedFlags(region), textList(sav.Gender), NewFlags(region));
    }

    private void SetFlags(FashionPageSelector selector, int region) {
      sav.Blocks.Fashion.SetArrayOwnedFlag(region, selector.GetBools());
      sav.Blocks.Fashion.SetArrayNewFlag(region, selector.GetNew()!.Select((b, i) => !b).ToArray());
    }

  }
}
