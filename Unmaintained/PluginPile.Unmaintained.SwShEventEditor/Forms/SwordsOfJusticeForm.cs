using PKHeX.Core;
using PluginPile.Common;

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

    SCBlock cobalionProgressBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeProgressKeys[Species.Cobalion]);
    SCBlock cobalionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeDisappearedKeys[Species.Cobalion]);
    SCBlock cobalionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeFootprintPercentageKeys[Species.Cobalion]);
    cobalionProgress.SelectedIndex = Convert.ToInt32(cobalionProgressBlock.GetValue());
    cobalionDisappeared.Checked = cobalionDisappearedBlock.GetBooleanValue();
    cobalionFootprints.Value = Convert.ToInt32(cobalionFootprintsBlock.GetValue());

    SCBlock terrakionProgressBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeProgressKeys[Species.Terrakion]);
    SCBlock terrakionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeDisappearedKeys[Species.Terrakion]);
    SCBlock terrakionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeFootprintPercentageKeys[Species.Terrakion]);
    terrakionProgress.SelectedIndex = Convert.ToInt32(terrakionProgressBlock.GetValue());
    terrakionDisappeared.Checked = terrakionDisappearedBlock.GetBooleanValue();
    terrakionFootprints.Value = Convert.ToInt32(terrakionFootprintsBlock.GetValue());

    SCBlock virizionProgressBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeProgressKeys[Species.Virizion]);
    SCBlock virizionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeDisappearedKeys[Species.Virizion]);
    SCBlock virizionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeFootprintPercentageKeys[Species.Virizion]);
    virizionProgress.SelectedIndex = Convert.ToInt32(virizionProgressBlock.GetValue());
    virizionDisappeared.Checked = virizionDisappearedBlock.GetBooleanValue();
    virizionFootprints.Value = Convert.ToInt32(virizionFootprintsBlock.GetValue());

    SCBlock keldeoProgressBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeProgressKeys[Species.Keldeo]);
    SCBlock keldeoDisappearedBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeDisappearedKeys[Species.Keldeo]);
    int keldeoProgressValue = Convert.ToInt32(keldeoProgressBlock.GetValue());
    keldeoProgress.SelectedIndex = keldeoProgressValue == 0 ? keldeoProgressValue : keldeoProgressValue - 1; // Account for skips in value range
    keldeoDisappeared.Checked = keldeoDisappearedBlock.GetBooleanValue();
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

    SCBlock cobalionProgressBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeProgressKeys[Species.Cobalion]);
    SCBlock cobalionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeDisappearedKeys[Species.Cobalion]);
    SCBlock cobalionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeFootprintPercentageKeys[Species.Cobalion]);
    cobalionProgressBlock.SetValue(Convert.ToUInt32(cobalionProgress.SelectedIndex));
    cobalionDisappearedBlock.ChangeBooleanValue(cobalionDisappeared.Checked);
    cobalionFootprintsBlock.SetValue(Convert.ToUInt32(cobalionFootprints.Value));

    SCBlock terrakionProgressBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeProgressKeys[Species.Terrakion]);
    SCBlock terrakionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeDisappearedKeys[Species.Terrakion]);
    SCBlock terrakionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeFootprintPercentageKeys[Species.Terrakion]);
    terrakionProgressBlock.SetValue(Convert.ToUInt32(terrakionProgress.SelectedIndex));
    terrakionDisappearedBlock.ChangeBooleanValue(terrakionDisappeared.Checked);
    terrakionFootprintsBlock.SetValue(Convert.ToUInt32(terrakionFootprints.Value));

    SCBlock virizionProgressBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeProgressKeys[Species.Virizion]);
    SCBlock virizionDisappearedBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeDisappearedKeys[Species.Virizion]);
    SCBlock virizionFootprintsBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeFootprintPercentageKeys[Species.Virizion]);
    virizionProgressBlock.SetValue(Convert.ToUInt32(virizionProgress.SelectedIndex));
    virizionDisappearedBlock.ChangeBooleanValue(virizionDisappeared.Checked);
    virizionFootprintsBlock.SetValue(Convert.ToUInt32(virizionFootprints.Value));

    SCBlock keldeoProgressBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeProgressKeys[Species.Keldeo]);
    SCBlock keldeoDisappearedBlock = SAV.Blocks.GetBlock(Definitions.SwordsOfJusticeDisappearedKeys[Species.Keldeo]);
    int keldeoProgressValue = keldeoProgress.SelectedIndex == 0 ? keldeoProgress.SelectedIndex : keldeoProgress.SelectedIndex + 1; // Account for skips in value range
    keldeoProgressBlock.SetValue(Convert.ToUInt32(keldeoProgressValue));
    keldeoDisappearedBlock.ChangeBooleanValue(keldeoDisappeared.Checked);

    SAV.State.Edited = true;
    DialogResult = DialogResult.OK;
    Close();
  }
}
