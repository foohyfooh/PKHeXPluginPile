using PKHeX.Core;

namespace PluginPile.FashionEditor {
  public partial class FashionPageSelector : UserControl {

    private readonly bool[] unlocked;
    private readonly string[] text;

    public FashionPageSelector(bool[] unlocked, string[] text) {
      InitializeComponent();
      HandleLanguageChange();
      this.unlocked = unlocked;
      this.text = text;
      itemsList.DataSource = this.text;
      owned.Enabled = this.text.Length > 0;
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

    public void PersistChange(SCBlock block, IFashionBlockConverter converter) => block.ChangeData(GetData(converter));

    public byte[] GetData(IFashionBlockConverter converter) => converter.ToBlockData(unlocked);

  }
}
