using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.SVivillon; 
public partial class VivillonForm : Form {
  // Block Locations
  private static readonly Block VivillonEnableBlock    = 0x0C125D5C;
  private static readonly Block VivillonFormBlock      = 0x22F70BCF;
  private static readonly Block VivillonTimestampBlock = 0x867F0240;

  private readonly SAV9SV sav;
  private readonly SCBlock enableBlock, formBlock, timestampBlock;
  private byte selectedForm;

  public VivillonForm(SAV9SV sav9sv) {
    InitializeComponent();
    HandleLanguageChange();
    sav = sav9sv;
    enableBlock = sav.Accessor.GetBlock(VivillonEnableBlock);
    formBlock = sav.Accessor.GetBlock(VivillonFormBlock);
    timestampBlock = sav.Accessor.GetBlock(VivillonTimestampBlock);
    selectedForm = (byte)formBlock.GetValue();
    RadioButton initalForm = (RadioButton)formGroup.Controls.Find($"form{selectedForm:00}", true).First();
    initalForm.Checked = true;
  }

  private void HandleLanguageChange() {
    Text = Language.FormTitle;
    formGroup.Text = Language.VivillonForms;
    form00.Text = Language.VivillonForm00Name;
    form01.Text = Language.VivillonForm01Name;
    form02.Text = Language.VivillonForm02Name;
    form03.Text = Language.VivillonForm03Name;
    form04.Text = Language.VivillonForm04Name;
    form05.Text = Language.VivillonForm05Name;
    form06.Text = Language.VivillonForm06Name;
    form07.Text = Language.VivillonForm07Name;
    form08.Text = Language.VivillonForm08Name;
    form09.Text = Language.VivillonForm09Name;
    form10.Text = Language.VivillonForm10Name;
    form11.Text = Language.VivillonForm11Name;
    form12.Text = Language.VivillonForm12Name;
    form13.Text = Language.VivillonForm13Name;
    form14.Text = Language.VivillonForm14Name;
    form15.Text = Language.VivillonForm15Name;
    form16.Text = Language.VivillonForm16Name;
    form17.Text = Language.VivillonForm17Name;
    form18.Text = Language.VivillonForm18Name;
    cancel.Text = Language.Cancel;
    save.Text = Language.Save;
  }

  private void formSelected(object sender, EventArgs e) {
    if (sender == null) return;
    RadioButton radioButton = (RadioButton)sender;
    if (radioButton.Checked) {
      selectedForm = byte.Parse((string)radioButton.Tag!);
    }
  }

  private void cancel_Click(object sender, EventArgs e) => Close();

  private void save_Click(object sender, EventArgs e) {
    enableBlock.ChangeBooleanType(SCTypeCode.Bool2);
    formBlock.SetValue(selectedForm);
    timestampBlock.SetValue((ulong)DateTimeOffset.Now.ToUnixTimeSeconds());
    sav.State.Edited = true;
    Close();
  }
}
