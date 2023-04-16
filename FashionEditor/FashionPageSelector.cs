using PKHeX.Core;

namespace PluginPile.FashionEditor {
  public partial class FashionPageSelector : UserControl {

    private readonly bool[] unlocked;
    private readonly string[] text;

    public FashionPageSelector(bool[] unlocked, string[] text) {
      InitializeComponent();
      HandleLanguageChange();
      // TODO: Deal with this causing some of the tabs to appear different from others.
      // This is set so that selector will fill the tab since some of the items names and fashion style are long.
      Dock = DockStyle.Fill;
      this.unlocked = unlocked;
      this.text = text;
      itemsList.DataSource = this.text;
      if (this.text.Length > 0) {
        // Explicitly set since the SelectedIndexChanged is not firing after setting data source, if the first item is unused it can be accidentally set.
        itemsList.SelectedIndex = 0;
      } else {
        owned.Enabled = false;
      }
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
