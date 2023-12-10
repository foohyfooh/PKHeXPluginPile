using PKHeX.Core;

namespace PluginPile.FashionEditor; 
public partial class FashionFormBDSP : Form {

  private readonly SAV8BS SAV;

  public FashionFormBDSP(SAV8BS sav8bs) {
    InitializeComponent();
    HandleLanguageChange();
    SAV = sav8bs;
    //fashionEveryday.Checked = sav.FlagWork.GetFlag(BDSPConstants.FashionEveryday);
    FashionPikachu.Checked  = SAV.FlagWork.GetFlag(BDSPConstants.FashionPikachu);
    FashionPlatinum.Checked = SAV.FlagWork.GetFlag(BDSPConstants.FashionPlatinum);
    FashionOveralls.Checked = SAV.FlagWork.GetFlag(BDSPConstants.FashionOveralls);
    FashionEevee.Checked    = SAV.FlagWork.GetFlag(BDSPConstants.FashionEevee);
    FashionGengar.Checked   = SAV.FlagWork.GetFlag(BDSPConstants.FashionGengar);
    FashionCyber.Checked    = SAV.FlagWork.GetFlag(BDSPConstants.FashionCyber);
    FashionSummer.Checked   = SAV.FlagWork.GetFlag(BDSPConstants.FashionSummer);
    FashionWinter.Checked   = SAV.FlagWork.GetFlag(BDSPConstants.FashionWinter);
    FashionSpring.Checked   = SAV.FlagWork.GetFlag(BDSPConstants.FashionSpring);
    FashionCasual.Checked   = SAV.FlagWork.GetFlag(BDSPConstants.FashionCasual);
    FashionLeather.Checked  = SAV.FlagWork.GetFlag(BDSPConstants.FashionLeather);
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
    SAV.FlagWork.SetFlag(BDSPConstants.FashionPikachu,  FashionPikachu.Checked);
    SAV.FlagWork.SetFlag(BDSPConstants.FashionPlatinum, FashionPlatinum.Checked);
    SAV.FlagWork.SetFlag(BDSPConstants.FashionOveralls, FashionOveralls.Checked);
    SAV.FlagWork.SetFlag(BDSPConstants.FashionEevee,    FashionEevee.Checked);
    SAV.FlagWork.SetFlag(BDSPConstants.FashionGengar,   FashionGengar.Checked);
    SAV.FlagWork.SetFlag(BDSPConstants.FashionCyber,    FashionCyber.Checked);
    SAV.FlagWork.SetFlag(BDSPConstants.FashionSummer,   FashionSummer.Checked);
    SAV.FlagWork.SetFlag(BDSPConstants.FashionWinter,   FashionWinter.Checked);
    SAV.FlagWork.SetFlag(BDSPConstants.FashionSpring,   FashionSpring.Checked);
    SAV.FlagWork.SetFlag(BDSPConstants.FashionCasual,   FashionCasual.Checked);
    SAV.FlagWork.SetFlag(BDSPConstants.FashionLeather,  FashionLeather.Checked);
    SAV.State.Edited = true;
    Close();
  }
}
