using PKHeX.Core;
namespace PluginPile.FashionEditor {
  public partial class FashionPageSelector : UserControl {
    
    private readonly SCBlock block;
    private readonly bool[] unlocked;
    private readonly string[] text;
    private readonly IFashionBlockConverter converter;

    public FashionPageSelector(SCBlock scblock, string[] text, IFashionBlockConverter converter) {
      InitializeComponent();
      HandleLanguageChange();
      block = scblock;
      this.converter = converter;
      this.text = text;
      unlocked = converter.FromBlockData(block.Data);
      itemsList.DataSource = this.text;
    }

    private void HandleLanguageChange() {
      itemLabel.Text = Language.Item;
      owned.Text = Language.Unlocked;
    }

    private void namesList_SelectedIndexChanged(object sender, EventArgs e) {
      owned.Checked = unlocked[itemsList.SelectedIndex];
      owned.Enabled = !text[itemsList.SelectedIndex].Contains(Language.Unused);
    }

    private void unlocked_CheckedChanged(object sender, EventArgs e) => unlocked[itemsList.SelectedIndex] = owned.Checked;

    public void PersistChange() => block.ChangeData(converter.ToBlockData(unlocked));

  }
}
