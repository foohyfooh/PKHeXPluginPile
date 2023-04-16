using PKHeX.Core;

namespace PluginPile.FashionEditor {
  public partial class FashionPageSelector : UserControl {

    private readonly bool[] unlocked;
    private readonly string[] text;
    private readonly bool[]? isNew;

    public FashionPageSelector(bool[] unlockedFlags, string[] text, bool[]? newFlags = null) {
      InitializeComponent();
      HandleLanguageChange();
      // TODO: Deal with this causing some of the tabs to appear different from others.
      // This is set so that selector will fill the tab since some of the items names and fashion style are long.
      Dock = DockStyle.Fill;
      unlocked = unlockedFlags;
      this.text = text;
      isNew = newFlags;
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
      newCheckbox.Text = Language.New;
    }

    private void namesList_SelectedIndexChanged(object sender, EventArgs e) {
      owned.Checked = unlocked[itemsList.SelectedIndex];
      owned.Enabled = !text[itemsList.SelectedIndex].Contains(Language.Unused);
      if (isNew != null) {
        newCheckbox.Enabled = owned.Enabled && owned.Checked;
        newCheckbox.Checked = isNew[itemsList.SelectedIndex];
      }
    }

    private void unlocked_CheckedChanged(object sender, EventArgs e) {
      unlocked[itemsList.SelectedIndex] = owned.Checked;
      newCheckbox.Enabled = isNew != null && owned.Checked;
    }

    private void newCheckbox_CheckedChanged(object sender, EventArgs e) => isNew![itemsList.SelectedIndex] = newCheckbox.Checked;

    public void PersistChange(SCBlock block, IFashionBlockConverter converter) => block.ChangeData(GetData(converter));

    public byte[] GetData(IFashionBlockConverter converter) => converter.ToBlockData(unlocked);

    public bool[] GetBools() => unlocked;

    public bool[]? GetNew() => isNew;
  }
}
