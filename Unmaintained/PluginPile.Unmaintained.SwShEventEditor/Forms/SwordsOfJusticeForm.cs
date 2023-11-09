using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShEventEditor;
public partial class SwordsOfJusticeForm : Form {
  private readonly SAV8SWSH SAV;

  public SwordsOfJusticeForm(SAV8SWSH sav) {
    InitializeComponent();
    HandleLanguageChange();
    SAV = sav;

    SCBlock statusBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeQuestStatus);
    questStatus.SelectedIndex = Convert.ToInt32(statusBlock.GetValue()) / 10;

    SCBlock progressBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeQuestProgress);
    int progressValue = Convert.ToInt32(progressBlock.GetValue());
    questProgress.SelectedIndex = progressValue < 4 ? progressValue : progressValue == 4 ? 3 : progressValue - 3; // Account for skips in value range

    SCBlock cobalionProgressBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeProgress[Species.Cobalion]);
    SCBlock cobalionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeDisappeared[Species.Cobalion]);
    SCBlock cobalionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeFootprintPercentage[Species.Cobalion]);
    cobalionProgress.SelectedIndex = Convert.ToInt32(cobalionProgressBlock.GetValue());
    cobalionDisappeared.Checked = cobalionDisappearedBlock.Type == SCTypeCode.Bool2;
    cobalionFootprints.Value = Convert.ToInt32(cobalionFootprintsBlock.GetValue());

    SCBlock terrakionProgressBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeProgress[Species.Terrakion]);
    SCBlock terrakionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeDisappeared[Species.Terrakion]);
    SCBlock terrakionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeFootprintPercentage[Species.Terrakion]);
    terrakionProgress.SelectedIndex = Convert.ToInt32(terrakionProgressBlock.GetValue());
    terrakionDisappeared.Checked = terrakionDisappearedBlock.Type == SCTypeCode.Bool2;
    terrakionFootprints.Value = Convert.ToInt32(terrakionFootprintsBlock.GetValue());

    SCBlock virizionProgressBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeProgress[Species.Virizion]);
    SCBlock virizionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeDisappeared[Species.Virizion]);
    SCBlock virizionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeFootprintPercentage[Species.Virizion]);
    virizionProgress.SelectedIndex = Convert.ToInt32(virizionProgressBlock.GetValue());
    virizionDisappeared.Checked = virizionDisappearedBlock.Type == SCTypeCode.Bool2;
    virizionFootprints.Value = Convert.ToInt32(virizionFootprintsBlock.GetValue());

    SCBlock keldeoProgressBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeProgress[Species.Keldeo]);
    SCBlock keldeoDisappearedBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeDisappeared[Species.Keldeo]);
    int keldeoProgressValue = Convert.ToInt32(keldeoProgressBlock.GetValue());
    keldeoProgress.SelectedIndex = keldeoProgressValue == 0 ? keldeoProgressValue : keldeoProgressValue - 1; // Account for skips in value range
    keldeoDisappeared.Checked = keldeoDisappearedBlock.Type == SCTypeCode.Bool2;
  }

  private void HandleLanguageChange() {
    questStatus.Items.AddRange(Language.SwordsOfJusticeQuestStatus);
    questProgress.Items.AddRange(Language.SwordsOfJusticeQuestProgress);
    cobalionGroup.Text = GameInfo.Strings.specieslist[(int)Species.Cobalion];
    cobalionProgress.Items.AddRange(Language.SwordsOfJusticeProgress);
    terrakionGroup.Text = GameInfo.Strings.specieslist[(int)Species.Terrakion];
    terrakionProgress.Items.AddRange(Language.SwordsOfJusticeProgress);
    virizionGroup.Text = GameInfo.Strings.specieslist[(int)Species.Virizion];
    virizionProgress.Items.AddRange(Language.SwordsOfJusticeProgress);
    keldeoGroup.Text = GameInfo.Strings.specieslist[(int)Species.Keldeo];
    keldeoProgress.Items.AddRange(Language.KeldeoProgress);
  }

  private void apply_BTN_Click(object sender, EventArgs e) {
    SCBlock statusBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeQuestStatus);
    statusBlock.SetValue(Convert.ToUInt32(questStatus.SelectedIndex * 10));

    SCBlock progressBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeQuestProgress);
    int progressValue = questProgress.SelectedIndex < 3 ? questProgress.SelectedIndex : questProgress.SelectedIndex == 3 ? 4 : questProgress.SelectedIndex + 3; // Account for skips in value range
    progressBlock.SetValue(Convert.ToUInt32(progressValue));

    SCBlock cobalionProgressBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeProgress[Species.Cobalion]);
    SCBlock cobalionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeDisappeared[Species.Cobalion]);
    SCBlock cobalionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeFootprintPercentage[Species.Cobalion]);
    cobalionProgressBlock.SetValue(Convert.ToUInt32(cobalionProgress.SelectedIndex));
    cobalionDisappearedBlock.ChangeBooleanType(cobalionDisappeared.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
    cobalionFootprintsBlock.SetValue(Convert.ToUInt32(cobalionFootprints.Value));

    SCBlock terrakionProgressBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeProgress[Species.Terrakion]);
    SCBlock terrakionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeDisappeared[Species.Terrakion]);
    SCBlock terrakionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeFootprintPercentage[Species.Terrakion]);
    terrakionProgressBlock.SetValue(Convert.ToUInt32(terrakionProgress.SelectedIndex));
    terrakionDisappearedBlock.ChangeBooleanType(terrakionDisappeared.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
    terrakionFootprintsBlock.SetValue(Convert.ToUInt32(terrakionFootprints.Value));

    SCBlock virizionProgressBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeProgress[Species.Virizion]);
    SCBlock virizionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeDisappeared[Species.Virizion]);
    SCBlock virizionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeFootprintPercentage[Species.Virizion]);
    virizionProgressBlock.SetValue(Convert.ToUInt32(virizionProgress.SelectedIndex));
    virizionDisappearedBlock.ChangeBooleanType(virizionDisappeared.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);
    virizionFootprintsBlock.SetValue(Convert.ToUInt32(virizionFootprints.Value));

    SCBlock keldeoProgressBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeProgress[Species.Keldeo]);
    SCBlock keldeoDisappearedBlock = SAV.Blocks.GetBlock(Definitions.memkeys_SwordsOfJusticeDisappeared[Species.Keldeo]);
    int keldeoProgressValue = keldeoProgress.SelectedIndex == 0 ? keldeoProgress.SelectedIndex : keldeoProgress.SelectedIndex + 1; // Account for skips in value range
    keldeoProgressBlock.SetValue(Convert.ToUInt32(keldeoProgressValue));
    keldeoDisappearedBlock.ChangeBooleanType(keldeoDisappeared.Checked ? SCTypeCode.Bool2 : SCTypeCode.Bool1);

    SAV.State.Edited = true;
    DialogResult = DialogResult.OK;
    Close();
  }
}
