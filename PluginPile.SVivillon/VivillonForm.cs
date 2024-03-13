using PKHeX.Core;

namespace PluginPile.SVivillon;
public partial class VivillonForm : Form {

  private readonly SAV9SV SAV;
  private readonly SCBlock EnableBlock, FormBlock, TimestampBlock;
  private byte SelectedForm;

  public VivillonForm(SAV9SV sav9sv) {
    InitializeComponent();
    HandleLanguageChange();
    SAV = sav9sv;
    EnableBlock = SAV.Accessor.GetBlock(Constants.VivillonEnableBlock);
    FormBlock = SAV.Accessor.GetBlock(Constants.VivillonFormBlock);
    TimestampBlock = SAV.Accessor.GetBlock(Constants.VivillonTimestampBlock);
    SelectedForm = (byte)FormBlock.GetValue();
    RadioButton initalForm = (RadioButton)FormGroup.Controls.Find($"form{SelectedForm:00}", true).First();
    initalForm.Checked = true;
  }

  private void HandleLanguageChange() {
    Text = Language.FormTitle;
    FormGroup.Text = Language.VivillonForms;
    Form00.Text = Language.VivillonForm00Name;
    Form01.Text = Language.VivillonForm01Name;
    Form02.Text = Language.VivillonForm02Name;
    Form03.Text = Language.VivillonForm03Name;
    Form04.Text = Language.VivillonForm04Name;
    Form05.Text = Language.VivillonForm05Name;
    Form06.Text = Language.VivillonForm06Name;
    Form07.Text = Language.VivillonForm07Name;
    Form08.Text = Language.VivillonForm08Name;
    Form09.Text = Language.VivillonForm09Name;
    Form10.Text = Language.VivillonForm10Name;
    Form11.Text = Language.VivillonForm11Name;
    Form12.Text = Language.VivillonForm12Name;
    Form13.Text = Language.VivillonForm13Name;
    Form14.Text = Language.VivillonForm14Name;
    Form15.Text = Language.VivillonForm15Name;
    Form16.Text = Language.VivillonForm16Name;
    Form17.Text = Language.VivillonForm17Name;
    Form18.Text = Language.VivillonForm18Name;
    Cancel.Text = Language.Cancel;
    Save.Text = Language.Save;
  }

  private void FormSelected(object sender, EventArgs e) {
    if (sender == null) return;
    RadioButton radioButton = (RadioButton)sender;
    if (radioButton.Checked) {
      SelectedForm = byte.Parse((string)radioButton.Tag!);
    }
  }

  private void Cancel_Click(object sender, EventArgs e) => Close();

  private void Save_Click(object sender, EventArgs e) {
    EnableBlock.ChangeBooleanType(SCTypeCode.Bool2);
    FormBlock.SetValue(SelectedForm);
    TimestampBlock.SetValue((ulong)DateTimeOffset.Now.ToUnixTimeSeconds());
    SAV.State.Edited = true;
    Close();
  }
}
