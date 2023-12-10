using PKHeX.Core;

namespace PluginPile.FashionEditor; 
public partial class FashionFormSwSh : Form {

  private readonly SAV8SWSH SAV;

  private readonly FashionPageSelector TopsSelector;
  private readonly FashionPageSelector JacketsSelector;
  private readonly FashionPageSelector BottomsSelector;
  private readonly FashionPageSelector SocksSelector;
  private readonly FashionPageSelector ShoesSelector;
  private readonly FashionPageSelector BagsSelector;
  private readonly FashionPageSelector HatsSelector;
  private readonly FashionPageSelector GlassesSelector;
  private readonly FashionPageSelector GlovesSelector;

  public FashionFormSwSh(SAV8SWSH sav8swsh) {
    InitializeComponent();
    SAV = sav8swsh;
    HandleLanguageChange();

    TopsSelector = NewSelector(SwShConstants.TopsRegion, Language.SwSh.TopsList);
    JacketsSelector = NewSelector(SwShConstants.JacketsRegion, Language.SwSh.JacketsList);
    BottomsSelector = NewSelector(SwShConstants.BotttomsRegion, Language.SwSh.BottomsList);
    SocksSelector = NewSelector(SwShConstants.SocksRegion, Language.SwSh.SocksList);
    ShoesSelector = NewSelector(SwShConstants.ShoesRegion, Language.SwSh.ShoesList);
    BagsSelector = NewSelector(SwShConstants.BagsRegion, Language.SwSh.BagsList);
    HatsSelector = NewSelector(SwShConstants.HatsRegion, Language.SwSh.HatsList);
    GlassesSelector = NewSelector(SwShConstants.GlassesRegion, Language.SwSh.GlassesList);
    GlovesSelector = NewSelector(SwShConstants.GlovesRegion, Language.SwSh.GlovesList);

    TopsPage.Controls.Add(TopsSelector);
    JacketsPage.Controls.Add(JacketsSelector);
    BottomsPage.Controls.Add(BottomsSelector);
    SocksPage.Controls.Add(SocksSelector);
    ShoesPage.Controls.Add(ShoesSelector);
    BagsPage.Controls.Add(BagsSelector);
    HatsPage.Controls.Add(HatsSelector);
    GlassesPage.Controls.Add(GlassesSelector);
    GlovesPage.Controls.Add(GlovesSelector);
  }

  private void HandleLanguageChange() {
    Text = Language.Title;
    Cancel.Text = Language.Cancel;
    SaveButton.Text = Language.Save;
    TopsPage.Text = Language.SwSh.Tops;
    JacketsPage.Text = Language.SwSh.Jackets;
    BottomsPage.Text = Language.SwSh.Bottoms;
    if (SAV.Gender == 1) BottomsPage.Text += $"/{Language.SwSh.Dresses}";
    SocksPage.Text = Language.SwSh.Socks;
    ShoesPage.Text = Language.SwSh.Shoes;
    BagsPage.Text = Language.SwSh.Bags;
    HatsPage.Text = Language.SwSh.Hats;
    GlassesPage.Text = Language.SwSh.Glasses;
    GlovesPage.Text = Language.SwSh.Gloves;
  }

  private void CancelButton_Click(object sender, EventArgs e) => Close();

  private void SaveButton_Click(object sender, EventArgs e) {
    SetFlags(TopsSelector, SwShConstants.TopsRegion);
    SetFlags(JacketsSelector, SwShConstants.JacketsRegion);
    SetFlags(BottomsSelector, SwShConstants.BotttomsRegion);
    SetFlags(SocksSelector, SwShConstants.SocksRegion);
    SetFlags(ShoesSelector, SwShConstants.ShoesRegion);
    SetFlags(BagsSelector, SwShConstants.BagsRegion);
    SetFlags(HatsSelector, SwShConstants.HatsRegion);
    SetFlags(GlassesSelector, SwShConstants.GlassesRegion);
    SetFlags(GlovesSelector, SwShConstants.GlovesRegion);
    SAV.State.Edited = true;
    Close();
  }

  private FashionPageSelector NewSelector(int region, Func<int, string[]> textList) {
    bool[] OwnedFlags(int region) => SAV.Blocks.Fashion.GetArrayOwnedFlag(region);
    bool[] NewFlags(int region) => SAV.Blocks.Fashion.GetArrayNewFlag(region).Select(b => !b).ToArray();
    return new FashionPageSelector(OwnedFlags(region), textList(SAV.Gender), NewFlags(region));
  }

  private void SetFlags(FashionPageSelector selector, int region) {
    SAV.Blocks.Fashion.SetArrayOwnedFlag(region, selector.GetBools());
    SAV.Blocks.Fashion.SetArrayNewFlag(region, selector.GetNew()!.Select(b => !b).ToArray());
  }

}
