namespace PluginPile.StartDateEditor {
  public partial class DateEditorForm : Form {

    public DateEditorForm(DateTime startDate) {
      InitializeComponent();
      HandleLanguageChange();
      startDatePicker.Value = startDate;
      // TODO: Handle those that have full timestamp and not just a date like BDSP or LA
      // TODO: Handle bounds for picker [release date, today]?
    }

    private void HandleLanguageChange() {
      Text = Language.FormTitle;
      startDateLabel.Text = Language.StartDate;
    }

    public DateTime GetStartDate() => startDatePicker.Value;

    private void startDateLabel_Click(object sender, EventArgs e) => startDatePicker.Focus();

    private void cancelButton_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    private void saveButton_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.OK;
      Close();
    }

  }
}
