using PKHeX.Core;

namespace PluginPile.FashionEditor; 
public partial class FashionFormLA : Form {

  private readonly SAV8LA sav;
  private readonly SCBlock hatsBlock;
  private readonly SCBlock topsBlock;
  private readonly SCBlock bottomsBlock;
  private readonly SCBlock uniformsBlock;
  private readonly SCBlock shoesBlock;
  private readonly SCBlock glassesBlock;

  private readonly FashionBlockConverterLA converter;
  private readonly FashionPageSelector hatSelector;
  private readonly FashionPageSelector topsSelector;
  private readonly FashionPageSelector bottomsSelector;
  private readonly FashionPageSelector uniformsSelector;
  private readonly FashionPageSelector shoesSelector;
  private readonly FashionPageSelector glassesSelector;

  public FashionFormLA(SAV8LA sav8la) {
    InitializeComponent();
    HandleLanguageChange();
    sav = sav8la;
    hatsBlock = sav.Blocks.GetBlock(LAConstants.FashionHats);
    topsBlock = sav.Blocks.GetBlock(LAConstants.FashionTops);
    bottomsBlock = sav.Blocks.GetBlock(LAConstants.FashionBottoms);
    uniformsBlock = sav.Blocks.GetBlock(LAConstants.FashionUniforms);
    shoesBlock = sav.Blocks.GetBlock(LAConstants.FashionShoes);
    glassesBlock = sav.Blocks.GetBlock(LAConstants.FashionGlasses);

    converter = new FashionBlockConverterLA();
    hatSelector = new FashionPageSelector(converter.FromBlockData(hatsBlock.Data), Language.LA.HatsList);
    topsSelector = new FashionPageSelector(converter.FromBlockData(topsBlock.Data), Language.LA.TopsList);
    bottomsSelector = new FashionPageSelector(converter.FromBlockData(bottomsBlock.Data), Language.LA.BottomsList);
    uniformsSelector = new FashionPageSelector(converter.FromBlockData(uniformsBlock.Data), Language.LA.UniformsList);
    shoesSelector = new FashionPageSelector(converter.FromBlockData(shoesBlock.Data), Language.LA.ShoesList);
    glassesSelector = new FashionPageSelector(converter.FromBlockData(glassesBlock.Data), Language.LA.GlassesList);

    hatsPage.Controls.Add(hatSelector);
    topsPage.Controls.Add(topsSelector);
    bottomsPage.Controls.Add(bottomsSelector);
    uniformsPage.Controls.Add(uniformsSelector);
    shoesPage.Controls.Add(shoesSelector);
    glassesPage.Controls.Add(glassesSelector);
  }

  private void HandleLanguageChange() {
    Text = Language.Title;
    cancelButton.Text = Language.Cancel;
    saveButton.Text = Language.Save;
    hatsPage.Text = Language.LA.Hats;
    topsPage.Text = Language.LA.Tops;
    bottomsPage.Text = Language.LA.Bottoms;
    uniformsPage.Text = Language.LA.Uniforms;
    shoesPage.Text = Language.LA.Shoes;
    glassesPage.Text = Language.LA.Glasses;
  }

  private void cancelButton_Click(object sender, EventArgs e) => Close();

  private void saveButton_Click(object sender, EventArgs e) {
    hatSelector.PersistChange(hatsBlock, converter);
    topsSelector.PersistChange(topsBlock, converter);
    bottomsSelector.PersistChange(bottomsBlock, converter);
    uniformsSelector.PersistChange(uniformsBlock, converter);
    shoesSelector.PersistChange(shoesBlock, converter);
    glassesSelector.PersistChange(glassesBlock, converter);
    sav.State.Edited = true;
    Close();
  }

}
