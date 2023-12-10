using PKHeX.Core;

namespace PluginPile.FashionEditor; 
public partial class FashionFormLA : Form {

  private readonly SAV8LA SAV;
  private readonly SCBlock HatsBlock;
  private readonly SCBlock TopsBlock;
  private readonly SCBlock BottomsBlock;
  private readonly SCBlock UniformsBlock;
  private readonly SCBlock ShoesBlock;
  private readonly SCBlock GlassesBlock;

  private readonly FashionBlockConverterLA Converter;
  private readonly FashionPageSelector HatSelector;
  private readonly FashionPageSelector TopsSelector;
  private readonly FashionPageSelector BottomsSelector;
  private readonly FashionPageSelector UniformsSelector;
  private readonly FashionPageSelector ShoesSelector;
  private readonly FashionPageSelector GlassesSelector;

  public FashionFormLA(SAV8LA sav8la) {
    InitializeComponent();
    HandleLanguageChange();
    SAV = sav8la;
    HatsBlock = SAV.Blocks.GetBlock(LAConstants.FashionHats);
    TopsBlock = SAV.Blocks.GetBlock(LAConstants.FashionTops);
    BottomsBlock = SAV.Blocks.GetBlock(LAConstants.FashionBottoms);
    UniformsBlock = SAV.Blocks.GetBlock(LAConstants.FashionUniforms);
    ShoesBlock = SAV.Blocks.GetBlock(LAConstants.FashionShoes);
    GlassesBlock = SAV.Blocks.GetBlock(LAConstants.FashionGlasses);

    Converter = new FashionBlockConverterLA();
    HatSelector = new FashionPageSelector(Converter.FromBlockData(HatsBlock.Data), Language.LA.HatsList);
    TopsSelector = new FashionPageSelector(Converter.FromBlockData(TopsBlock.Data), Language.LA.TopsList);
    BottomsSelector = new FashionPageSelector(Converter.FromBlockData(BottomsBlock.Data), Language.LA.BottomsList);
    UniformsSelector = new FashionPageSelector(Converter.FromBlockData(UniformsBlock.Data), Language.LA.UniformsList);
    ShoesSelector = new FashionPageSelector(Converter.FromBlockData(ShoesBlock.Data), Language.LA.ShoesList);
    GlassesSelector = new FashionPageSelector(Converter.FromBlockData(GlassesBlock.Data), Language.LA.GlassesList);

    HatsPage.Controls.Add(HatSelector);
    TopsPage.Controls.Add(TopsSelector);
    BottomsPage.Controls.Add(BottomsSelector);
    UniformsPage.Controls.Add(UniformsSelector);
    ShoesPage.Controls.Add(ShoesSelector);
    GlassesPage.Controls.Add(GlassesSelector);
  }

  private void HandleLanguageChange() {
    Text = Language.Title;
    Cancel.Text = Language.Cancel;
    SaveButton.Text = Language.Save;
    HatsPage.Text = Language.LA.Hats;
    TopsPage.Text = Language.LA.Tops;
    BottomsPage.Text = Language.LA.Bottoms;
    UniformsPage.Text = Language.LA.Uniforms;
    ShoesPage.Text = Language.LA.Shoes;
    GlassesPage.Text = Language.LA.Glasses;
  }

  private void CancelButton_Click(object sender, EventArgs e) => Close();

  private void SaveButton_Click(object sender, EventArgs e) {
    HatSelector.PersistChange(HatsBlock, Converter);
    TopsSelector.PersistChange(TopsBlock, Converter);
    BottomsSelector.PersistChange(BottomsBlock, Converter);
    UniformsSelector.PersistChange(UniformsBlock, Converter);
    ShoesSelector.PersistChange(ShoesBlock, Converter);
    GlassesSelector.PersistChange(GlassesBlock, Converter);
    SAV.State.Edited = true;
    Close();
  }

}
