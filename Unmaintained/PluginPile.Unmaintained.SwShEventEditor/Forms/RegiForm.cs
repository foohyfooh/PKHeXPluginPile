using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.Unmaintained.SwShEventEditor;
public partial class RegiForm : Form {

  private readonly SAV8SWSH SAV;
  public RegiForm(SAV8SWSH sav) {
    SAV = sav;
    InitializeComponent();
  }

  private void RegiForm_Load(object sender, EventArgs e) {
    //Check Regi values
    for (int i = 0; i < Definitions.memkeys_Regis.Count - 2; i++) { //-2 so we do all of them except for Regieleki and regidrago
      regi_clistbox.SetItemChecked(i, SAV.Blocks.GetBlock(Definitions.memkeys_Regis.ElementAt(i).Value).GetBooleanValue());
    }
    legailty_CB.Checked = true;

    SCBlock eleki = SAV.Blocks.GetBlock(Definitions.memkeys_Regis[Species.Regieleki]);
    SCBlock drago = SAV.Blocks.GetBlock(Definitions.memkeys_Regis[Species.Regidrago]);
    SCBlock pattern = SAV.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern);

    if (eleki.GetBooleanValue()) {
      regieleki_RBTN.Checked = true;
      //Check if the pattern provided by the player matches the regi
      if (Convert.ToInt32(pattern.GetValue()) != 1) { // 1 = regieleki pattern
        if (ShowPatternMisMatchMSG() == DialogResult.Yes) pattern.SetValue((uint)1);
        else legailty_CB.Checked = false;
      }
    }

    if (drago.GetBooleanValue()) {
      regidrago_RBTN.Checked = true;
      //Check if the pattern provided by the player matches the regi
      if (Convert.ToInt32(pattern.GetValue()) != 2) { // 2 = regidrago pattern
        if (ShowPatternMisMatchMSG() == DialogResult.Yes) pattern.SetValue((uint)2);
        else legailty_CB.Checked = false;
      }
    }

    MatchRegiPattern();
    regipatternNUD.Value = Convert.ToInt32(pattern.GetValue());
  }

  void CheckLegality() {
    if (CheckElekiLegal() || CheckDragoLegal() || CheckNeitherLegal())
      legalLBL.Text = "Legal Status: Legal";
    else legalLBL.Text = "Legal Status: Potentially Illegal";
  }

  bool CheckNeitherLegal() {
    return GetRegiPattern() <= 2 && reginone_RBTN.Checked;
  }

  bool CheckElekiLegal() {
    return GetRegiPattern() == 1 && regieleki_RBTN.Checked && !(GetRegiPattern() == 2 && regidrago_RBTN.Checked) || regieleki_patrBTN.Checked;
  }

  bool CheckDragoLegal() {
    return GetRegiPattern() == 2 && regidrago_RBTN.Checked && !(GetRegiPattern() == 1 && regieleki_RBTN.Checked) || regidrago_patrBTN.Checked;
  }

  /// <summary>
  /// 0 - None
  /// <para>1 - Regieleki</para>
  /// <para>2 - Regidrago</para>
  /// </summary>
  /// <returns></returns>
  int GetRegiPattern() {
    if (regiother_patrBTN.Checked) return (int)regipatternNUD.Value;
    else return regidrago_patrBTN.Checked ? 2 : regieleki_patrBTN.Checked ? 1 : 0;
  }

  /// <summary>
  /// Match the regi (drago or eleki or neither) to the pattern value
  /// </summary>
  void MatchRegiPattern() {
    if (regieleki_RBTN.Checked) {
      regieleki_patrBTN.Checked = true;
    } else if (regidrago_RBTN.Checked) {
      regidrago_patrBTN.Checked = true;
    }
  }

  DialogResult ShowPatternMisMatchMSG() {
    return MessageBox.Show($"Discrepancy detected with the Regi received and the pattern required for it.\nDo you wish to autocorrect this?", "Error", MessageBoxButtons.YesNo);
  }

  private void regiother_patrBTN_CheckedChanged(object sender, EventArgs e) {
    regipatternNUD.Enabled = regiother_patrBTN.Checked;
  }

  private void reginone_patrBTN_CheckedChanged(object sender, EventArgs e) {
    if (legailty_CB.Checked) MatchRegiPattern();
    CheckLegality();
  }

  private void regidrago_patrBTN_CheckedChanged(object sender, EventArgs e) {
    if (legailty_CB.Checked) MatchRegiPattern();
    CheckLegality();
  }

  private void regieleki_patrBTN_CheckedChanged(object sender, EventArgs e) {
    if (legailty_CB.Checked) MatchRegiPattern();
    CheckLegality();
  }

  private void regipatternNUD_ValueChanged(object sender, EventArgs e) {
    if (legailty_CB.Checked) MatchRegiPattern();
    CheckLegality();
  }

  private void reginone_RBTN_CheckedChanged(object sender, EventArgs e) {
    if (legailty_CB.Checked) MatchRegiPattern();
    CheckLegality();
  }

  private void regidrago_RBTN_CheckedChanged(object sender, EventArgs e) {
    if (legailty_CB.Checked) MatchRegiPattern();
    CheckLegality();
  }

  private void regieleki_RBTN_CheckedChanged(object sender, EventArgs e) {
    if (legailty_CB.Checked) MatchRegiPattern();
    CheckLegality();
  }

  private void forcematchCB_CheckedChanged(object sender, EventArgs e) {
    if (legailty_CB.Checked) MatchRegiPattern();
    CheckLegality();
  }

  private void applyBTN_Click(object sender, EventArgs e) {
    for (int i = 0; i < Definitions.memkeys_Regis.Count - 2; i++) { //do all except for eleki and drago
      SAV.Blocks.GetBlock(Definitions.memkeys_Regis.ElementAt(i).Value).ChangeBooleanValue(regi_clistbox.GetItemChecked(i));
    }

    SAV.Blocks.GetBlock(Definitions.memkeys_Regis[Species.Regieleki]).ChangeBooleanValue(regieleki_RBTN.Checked);
    SAV.Blocks.GetBlock(Definitions.memkeys_Regis[Species.Regidrago]).ChangeBooleanValue(regidrago_RBTN.Checked);

    if (regieleki_patrBTN.Checked) SAV.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)1);
    else if (regidrago_patrBTN.Checked) SAV.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)2);
    else if (reginone_patrBTN.Checked) SAV.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)0);
    else SAV.Blocks.GetBlock(Definitions.KRegielekiOrRegidragoPattern).SetValue((uint)regipatternNUD.Value);
    DialogResult = DialogResult.OK;
    Close();
  }
}
