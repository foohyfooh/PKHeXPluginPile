using PKHeX.Core;

namespace PluginPile.FashionEditor; 
public partial class FashionFormBDSP : Form {

  private readonly SAV8BS sav;

  public FashionFormBDSP(SAV8BS sav8bs) {
    InitializeComponent();
    HandleLanguageChange();
    sav = sav8bs;
    //fashionEveryday.Checked = sav.FlagWork.GetFlag(BDSPConstants.FashionEveryday);
    fashionPikachu.Checked  = sav.FlagWork.GetFlag(BDSPConstants.FashionPikachu);
    fashionPlatinum.Checked = sav.FlagWork.GetFlag(BDSPConstants.FashionPlatinum);
    fashionOveralls.Checked = sav.FlagWork.GetFlag(BDSPConstants.FashionOveralls);
    fashionEevee.Checked    = sav.FlagWork.GetFlag(BDSPConstants.FashionEevee);
    fashionGengar.Checked   = sav.FlagWork.GetFlag(BDSPConstants.FashionGengar);
    fashionCyber.Checked    = sav.FlagWork.GetFlag(BDSPConstants.FashionCyber);
    fashionSummer.Checked   = sav.FlagWork.GetFlag(BDSPConstants.FashionSummer);
    fashionWinter.Checked   = sav.FlagWork.GetFlag(BDSPConstants.FashionWinter);
    fashionSpring.Checked   = sav.FlagWork.GetFlag(BDSPConstants.FashionSpring);
    fashionCasual.Checked   = sav.FlagWork.GetFlag(BDSPConstants.FashionCasual);
    fashionLeather.Checked  = sav.FlagWork.GetFlag(BDSPConstants.FashionLeather);
  }

  private void HandleLanguageChange() {
    Text = Language.Title;
    cancelButton.Text = Language.Cancel;
    saveButton.Text = Language.Save;
    fashionEveryday.Text = Language.BDSP.FashionEveryday;
    fashionPikachu.Text  = Language.BDSP.FashionPikachu;
    fashionPlatinum.Text = Language.BDSP.FashionPlatinum;
    fashionOveralls.Text = Language.BDSP.FashionOveralls;
    fashionEevee.Text    = Language.BDSP.FashionEevee;
    fashionGengar.Text   = Language.BDSP.FashionGengar;
    fashionCyber.Text    = Language.BDSP.FashionCyber;
    fashionSummer.Text   = Language.BDSP.FashionSummer;
    fashionWinter.Text   = Language.BDSP.FashionWinter;
    fashionSpring.Text   = Language.BDSP.FashionSpring;
    fashionCasual.Text   = Language.BDSP.FashionCasual;
    fashionLeather.Text  = Language.BDSP.FashionLeather;
  }

  private void cancelButton_Click(object sender, EventArgs e) => Close();

  private void saveButton_Click(object sender, EventArgs e) {
    //sav.FlagWork.SetFlag(BDSPConstants.FashionEveryday, fashionEveryday.Checked);
    sav.FlagWork.SetFlag(BDSPConstants.FashionPikachu,  fashionPikachu.Checked);
    sav.FlagWork.SetFlag(BDSPConstants.FashionPlatinum, fashionPlatinum.Checked);
    sav.FlagWork.SetFlag(BDSPConstants.FashionOveralls, fashionOveralls.Checked);
    sav.FlagWork.SetFlag(BDSPConstants.FashionEevee,    fashionEevee.Checked);
    sav.FlagWork.SetFlag(BDSPConstants.FashionGengar,   fashionGengar.Checked);
    sav.FlagWork.SetFlag(BDSPConstants.FashionCyber,    fashionCyber.Checked);
    sav.FlagWork.SetFlag(BDSPConstants.FashionSummer,   fashionSummer.Checked);
    sav.FlagWork.SetFlag(BDSPConstants.FashionWinter,   fashionWinter.Checked);
    sav.FlagWork.SetFlag(BDSPConstants.FashionSpring,   fashionSpring.Checked);
    sav.FlagWork.SetFlag(BDSPConstants.FashionCasual,   fashionCasual.Checked);
    sav.FlagWork.SetFlag(BDSPConstants.FashionLeather,  fashionLeather.Checked);
    sav.State.Edited = true;
    Close();
  }
}
