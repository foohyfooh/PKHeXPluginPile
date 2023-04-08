using PKHeX.Core;
namespace PluginPile.FashionEditor {
  public partial class FashionPageSelector : UserControl {
    private const byte NOT_OWNED = 1;
    private const byte OWNED = 2;

    private readonly SCBlock block;
    private readonly byte[] data;
    private readonly string[] text;

    public FashionPageSelector(SCBlock scblock, string[] text) {
      InitializeComponent();
      HandleLanguageChange();
      block = scblock;
      data = scblock.Data.ToArray();
      this.text = text;
      itemsList.DataSource = this.text;
    }

    private void HandleLanguageChange() {
      itemLabel.Text = Language.Item;
      owned.Text = Language.Unlocked;
    }

    private void namesList_SelectedIndexChanged(object sender, EventArgs e) {
      owned.Checked = data[itemsList.SelectedIndex] == OWNED;
      owned.Enabled = !text[itemsList.SelectedIndex].Contains(Language.Unused);
    }

    private void unlocked_CheckedChanged(object sender, EventArgs e) {
      data[itemsList.SelectedIndex] = owned.Checked ? OWNED : NOT_OWNED;
    }

    public void PersistChange() => block.ChangeData(data);

  }
}
