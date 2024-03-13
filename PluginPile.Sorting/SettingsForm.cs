namespace PluginPile.Sorting;
public partial class SettingsForm : Form {
  private readonly SortingPlugin Plugin;

  public SettingsForm(SortingPlugin plugin) {
    InitializeComponent();
    HandleLanguageChange();
    Plugin = plugin;
    PropertyGrid.SelectedObject = PluginSettings.Default;
    FormClosing += new FormClosingEventHandler(SettingsForm_FormClosing);
  }

  private void HandleLanguageChange() {
    Text = Language.Settings;
  }

  private void SettingsForm_FormClosing(object? sender, FormClosingEventArgs e) {
    PluginSettings.Default.Save();
    Plugin.ReloadMenu();
  }

}
