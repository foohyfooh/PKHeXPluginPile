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

    TopsSelector = NewSelector(Constants.SwSh.TopsRegion, Language.SwSh.TopsList);
    JacketsSelector = NewSelector(Constants.SwSh.JacketsRegion, Language.SwSh.JacketsList);
    BottomsSelector = NewSelector(Constants.SwSh.BotttomsRegion, Language.SwSh.BottomsList);
    SocksSelector = NewSelector(Constants.SwSh.SocksRegion, Language.SwSh.SocksList);
    ShoesSelector = NewSelector(Constants.SwSh.ShoesRegion, Language.SwSh.ShoesList);
    BagsSelector = NewSelector(Constants.SwSh.BagsRegion, Language.SwSh.BagsList);
    HatsSelector = NewSelector(Constants.SwSh.HatsRegion, Language.SwSh.HatsList);
    GlassesSelector = NewSelector(Constants.SwSh.GlassesRegion, Language.SwSh.GlassesList);
    GlovesSelector = NewSelector(Constants.SwSh.GlovesRegion, Language.SwSh.GlovesList);

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
    SetFlags(TopsSelector, Constants.SwSh.TopsRegion);
    SetFlags(JacketsSelector, Constants.SwSh.JacketsRegion);
    SetFlags(BottomsSelector, Constants.SwSh.BotttomsRegion);
    SetFlags(SocksSelector, Constants.SwSh.SocksRegion);
    SetFlags(ShoesSelector, Constants.SwSh.ShoesRegion);
    SetFlags(BagsSelector, Constants.SwSh.BagsRegion);
    SetFlags(HatsSelector, Constants.SwSh.HatsRegion);
    SetFlags(GlassesSelector, Constants.SwSh.GlassesRegion);
    SetFlags(GlovesSelector, Constants.SwSh.GlovesRegion);
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
