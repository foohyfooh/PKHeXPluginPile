using PKHeX.Core;

namespace PluginPile.FashionEditor;
public partial class FashionPageSelector : UserControl {

  private readonly bool[] Unlocked;
  private readonly string[] ItemText;
  private readonly bool[]? IsNew;

  public FashionPageSelector(bool[] unlockedFlags, string[] text, bool[]? newFlags = null) {
    InitializeComponent();
    HandleLanguageChange();
    // TODO: Deal with this causing some of the tabs to appear different from others.
    // This is set so that selector will fill the tab since some of the items names and fashion style are long.
    Dock = DockStyle.Fill;
    Unlocked = unlockedFlags;
    ItemText = text;
    IsNew = newFlags;
    ItemsList.DataSource = ItemText;
    if (ItemText.Length > 0) {
      // Explicitly set since the SelectedIndexChanged is not firing after setting data source, if the first item is unused it can be accidentally set.
      ItemsList.SelectedIndex = 0;
    } else {
      Owned.Enabled = false;
    }
  }

  private void HandleLanguageChange() {
    ItemLabel.Text = Language.Item;
    Owned.Text = Language.Unlocked;
    NewCheckbox.Text = Language.New;
  }

  private void NamesList_SelectedIndexChanged(object sender, EventArgs e) {
    Owned.Checked = Unlocked[ItemsList.SelectedIndex];
    Owned.Enabled = !ItemText[ItemsList.SelectedIndex].Contains(Language.Unused);
    if (IsNew != null) {
      NewCheckbox.Enabled = Owned.Enabled && Owned.Checked;
      NewCheckbox.Checked = IsNew[ItemsList.SelectedIndex];
    }
  }

  private void Unlocked_CheckedChanged(object sender, EventArgs e) {
    Unlocked[ItemsList.SelectedIndex] = Owned.Checked;
    NewCheckbox.Enabled = IsNew != null && Owned.Checked;
  }

  private void NewCheckbox_CheckedChanged(object sender, EventArgs e) => IsNew![ItemsList.SelectedIndex] = NewCheckbox.Checked;

  public void PersistChange(SCBlock block, IFashionBlockConverter converter) => block.ChangeData(GetData(converter));

  public byte[] GetData(IFashionBlockConverter converter) => converter.ToBlockData(Unlocked);

  public bool[] GetBools() => Unlocked;

  public bool[]? GetNew() => IsNew;
}
