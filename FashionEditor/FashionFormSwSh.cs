using PKHeX.Core;

namespace PluginPile.FashionEditor {
  public partial class FashionFormSwSh : Form {

    private readonly SAV8SWSH sav;
    private readonly SCBlock block;
    private readonly FashionBlockConverterSwSh converter;

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
      block = sav.Blocks.GetBlock(SwShConstants.Fashion);
      int gender = sav.Gender;

      converter = new FashionBlockConverterSwSh();
      bool[] Convert(int start) => converter.FromBlockData(block.Data[start..(start + SwShConstants.RegionSize)]);
      topsSelector = new FashionPageSelector(Convert(SwShConstants.TopsOffset), Language.SwSh.TopsList(gender));
      jacketsSelector = new FashionPageSelector(Convert(SwShConstants.JacketsOffset), Language.SwSh.JacketsList(gender));
      bottomsSelector = new FashionPageSelector(Convert(SwShConstants.BotttomsOffset), Language.SwSh.BottomsList(gender));
      socksSelector = new FashionPageSelector(Convert(SwShConstants.SocksOffset), Language.SwSh.SocksList(gender));
      shoesSelector = new FashionPageSelector(Convert(SwShConstants.ShoesOffset), Language.SwSh.ShoesList(gender));
      bagsSelector = new FashionPageSelector(Convert(SwShConstants.BagsOffset), Language.SwSh.BagsList(gender));
      hatsSelector = new FashionPageSelector(Convert(SwShConstants.HatsOffset), Language.SwSh.HatsList(gender));
      glassesSelector = new FashionPageSelector(Convert(SwShConstants.GlassesOffset), Language.SwSh.GlassesList(gender));
      glovesSelector = new FashionPageSelector(Convert(SwShConstants.GlovesOffset), Language.SwSh.GlovesList(gender));

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
      topsSelector.GetData(converter).CopyTo(block.Data, SwShConstants.TopsOffset);
      jacketsSelector.GetData(converter).CopyTo(block.Data, SwShConstants.JacketsOffset);
      bottomsSelector.GetData(converter).CopyTo(block.Data, SwShConstants.BotttomsOffset);
      socksSelector.GetData(converter).CopyTo(block.Data, SwShConstants.SocksOffset);
      shoesSelector.GetData(converter).CopyTo(block.Data, SwShConstants.ShoesOffset);
      bagsSelector.GetData(converter).CopyTo(block.Data, SwShConstants.BagsOffset);
      hatsSelector.GetData(converter).CopyTo(block.Data, SwShConstants.HatsOffset);
      glassesSelector.GetData(converter).CopyTo(block.Data, SwShConstants.GlassesOffset);
      glovesSelector.GetData(converter).CopyTo(block.Data, SwShConstants.GlovesOffset);
      sav.State.Edited = true;
      Close();
    }
  }
}
