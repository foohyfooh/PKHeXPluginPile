using PKHeX.Core;

namespace PluginPile.FashionEditor;
public partial class FashionFormBDSP : Form {

  private readonly SAV8BS SAV;

  public FashionFormBDSP(SAV8BS sav8bs) {
    InitializeComponent();
    HandleLanguageChange();
    SAV = sav8bs;
    //fashionEveryday.Checked = sav.FlagWork.GetFlag(BDSPConstants.FashionEveryday);
    FashionPikachu.Checked  = SAV.FlagWork.GetFlag(Constants.BDSP.FashionPikachu);
    FashionPlatinum.Checked = SAV.FlagWork.GetFlag(Constants.BDSP.FashionPlatinum);
    FashionOveralls.Checked = SAV.FlagWork.GetFlag(Constants.BDSP.FashionOveralls);
    FashionEevee.Checked    = SAV.FlagWork.GetFlag(Constants.BDSP.FashionEevee);
    FashionGengar.Checked   = SAV.FlagWork.GetFlag(Constants.BDSP.FashionGengar);
    FashionCyber.Checked    = SAV.FlagWork.GetFlag(Constants.BDSP.FashionCyber);
    FashionSummer.Checked   = SAV.FlagWork.GetFlag(Constants.BDSP.FashionSummer);
    FashionWinter.Checked   = SAV.FlagWork.GetFlag(Constants.BDSP.FashionWinter);
    FashionSpring.Checked   = SAV.FlagWork.GetFlag(Constants.BDSP.FashionSpring);
    FashionCasual.Checked   = SAV.FlagWork.GetFlag(Constants.BDSP.FashionCasual);
    FashionLeather.Checked  = SAV.FlagWork.GetFlag(Constants.BDSP.FashionLeather);
  }

  private void HandleLanguageChange() {
    Text = Language.Title;
    Cancel.Text = Language.Cancel;
    SaveButton.Text = Language.Save;
    FashionEveryday.Text = Language.BDSP.FashionEveryday;
    FashionPikachu.Text  = Language.BDSP.FashionPikachu;
    FashionPlatinum.Text = Language.BDSP.FashionPlatinum;
    FashionOveralls.Text = Language.BDSP.FashionOveralls;
    FashionEevee.Text    = Language.BDSP.FashionEevee;
    FashionGengar.Text   = Language.BDSP.FashionGengar;
    FashionCyber.Text    = Language.BDSP.FashionCyber;
    FashionSummer.Text   = Language.BDSP.FashionSummer;
    FashionWinter.Text   = Language.BDSP.FashionWinter;
    FashionSpring.Text   = Language.BDSP.FashionSpring;
    FashionCasual.Text   = Language.BDSP.FashionCasual;
    FashionLeather.Text  = Language.BDSP.FashionLeather;
  }

  private void CancelButton_Click(object sender, EventArgs e) => Close();

  private void SaveButton_Click(object sender, EventArgs e) {
    //sav.FlagWork.SetFlag(BDSPConstants.FashionEveryday, fashionEveryday.Checked);
    SAV.FlagWork.SetFlag(Constants.BDSP.FashionPikachu,  FashionPikachu.Checked);
    SAV.FlagWork.SetFlag(Constants.BDSP.FashionPlatinum, FashionPlatinum.Checked);
    SAV.FlagWork.SetFlag(Constants.BDSP.FashionOveralls, FashionOveralls.Checked);
    SAV.FlagWork.SetFlag(Constants.BDSP.FashionEevee,    FashionEevee.Checked);
    SAV.FlagWork.SetFlag(Constants.BDSP.FashionGengar,   FashionGengar.Checked);
    SAV.FlagWork.SetFlag(Constants.BDSP.FashionCyber,    FashionCyber.Checked);
    SAV.FlagWork.SetFlag(Constants.BDSP.FashionSummer,   FashionSummer.Checked);
    SAV.FlagWork.SetFlag(Constants.BDSP.FashionWinter,   FashionWinter.Checked);
    SAV.FlagWork.SetFlag(Constants.BDSP.FashionSpring,   FashionSpring.Checked);
    SAV.FlagWork.SetFlag(Constants.BDSP.FashionCasual,   FashionCasual.Checked);
    SAV.FlagWork.SetFlag(Constants.BDSP.FashionLeather,  FashionLeather.Checked);
    SAV.State.Edited = true;
    Close();
  }
}
