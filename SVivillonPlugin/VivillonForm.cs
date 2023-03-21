using PKHeX.Core;

namespace PluginPile.SVivillonPlugin {
  public partial class VivillonForm : Form {
    // Block Locations
    private static readonly uint VivillonEnableBlock = 0x0C125D5C;
    private static readonly uint VivillonFormBlock = 0x22F70BCF;
    private static readonly uint VivillonExpirationBlock = 0x867F0240;

    private readonly SAV9SV sav;
    private readonly SCBlock enableBlock, formBlock, expirationBlock;
    private byte selectedForm;

    public VivillonForm(SAV9SV sav9sv) {
      InitializeComponent();
      sav = sav9sv;
      enableBlock = sav.Accessor.GetBlock(VivillonEnableBlock);
      formBlock = sav.Accessor.GetBlock(VivillonFormBlock);
      expirationBlock = sav.Accessor.GetBlock(VivillonExpirationBlock);
      selectedForm = (byte)formBlock.GetValue();
      RadioButton initalForm = (RadioButton)formGroup.Controls.Find($"form{selectedForm:00}", true).First();
      initalForm.Checked = true;
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
      expirationBlock.SetValue((ulong)DateTime.Now.AddDays(1).Ticks);
      sav.State.Edited = true;
      Close();
    }
  }
}
