namespace PluginPile.SortingPlugin {
  public partial class SettingsForm : Form {
    private readonly SortingPlugin sortingPlugin;

    public SettingsForm(SortingPlugin plugin) {
      InitializeComponent();
      sortingPlugin = plugin;
      propertyGrid.SelectedObject = PluginSettings.Default;
      FormClosing += new FormClosingEventHandler(SettingsForm_FormClosing);
    }

    private void SettingsForm_FormClosing(object? sender, FormClosingEventArgs e) {
      PluginSettings.Default.Save();
      sortingPlugin.ReloadMenu();
    }

  }
}
