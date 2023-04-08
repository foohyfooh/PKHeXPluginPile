using PKHeX.Core;

namespace PluginPile.FashionEditor {
  public partial class FashionFormLA : Form {

    private readonly SAV8LA sav;
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
      SCBlock hatsBlock     = sav.Blocks.GetBlock(LAConstants.FashionHats);
      SCBlock topsBlock     = sav.Blocks.GetBlock(LAConstants.FashionTops);
      SCBlock bottomsBlock  = sav.Blocks.GetBlock(LAConstants.FashionBottoms);
      SCBlock uniformsBlock = sav.Blocks.GetBlock(LAConstants.FashionUniforms);
      SCBlock shoesBlock    = sav.Blocks.GetBlock(LAConstants.FashionShoes);
      SCBlock glassesBlock  = sav.Blocks.GetBlock(LAConstants.FashionGlasses);

      hatSelector = new FashionPageSelector(hatsBlock, Language.LA.HatsList);
      topsSelector = new FashionPageSelector(topsBlock, Language.LA.TopsList);
      bottomsSelector = new FashionPageSelector(bottomsBlock, Language.LA.BottomsList);
      uniformsSelector = new FashionPageSelector(uniformsBlock, Language.LA.UniformsList);
      shoesSelector = new FashionPageSelector(shoesBlock, Language.LA.ShoesList);
      glassesSelector = new FashionPageSelector(glassesBlock, Language.LA.GlassesList);

      hatsPage.Controls.Add(hatSelector);
      topsPage.Controls.Add(topsSelector);
      bottomsPage.Controls.Add(bottomsSelector);
      uniformsPage.Controls.Add(uniformsSelector);
      shoesPage.Controls.Add(shoesSelector);
      glassesPage.Controls.Add(glassesSelector);
    }

    private void HandleLanguageChange() {
      Text = Language.Title;
      hatsPage.Text = Language.LA.Hats;
      topsPage.Text = Language.LA.Tops;
      bottomsPage.Text = Language.LA.Bottoms;
      uniformsPage.Text = Language.LA.Uniforms;
      shoesPage.Text = Language.LA.Shoes;
      glassesPage.Text = Language.LA.Glasses;
    }

    private void cancelButton_Click(object sender, EventArgs e) => Close();

    private void saveButton_Click(object sender, EventArgs e) {
      hatSelector.PersistChange();
      topsSelector.PersistChange();
      bottomsSelector.PersistChange();
      uniformsSelector.PersistChange();
      shoesSelector.PersistChange();
      glassesSelector.PersistChange();
      sav.State.Edited = true;
      Close();
    }

  }
}
