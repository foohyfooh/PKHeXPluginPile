using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.Unmaintained.BWTool {

  public partial class MainForm : Form {

    public readonly SAV5 SAV, Origin;

    public MainForm(SAV5 sav) {
      InitializeComponent();
      SAV = (SAV5)(Origin = sav).Clone();

      if (SAV is SAV5BW) {
        grotto_but.Enabled = false;
        trainer_records_but.Enabled = false;
        medal_but.Enabled = false;
        forest_but.Enabled = true;
        key_but.Enabled = false;
        join_but.Enabled = false;
        memory_but.Enabled = false;
        dlc_but.Enabled = true;
        dr_but.Enabled = false;
      }
    }

    void Save_butClick(object sender, EventArgs e) {
      Origin.CopyChangesFrom(SAV);
      Close();
    }

    void Dumper_butClick(object sender, EventArgs e) => new DumperForm(SAV).ShowDialogInParent();

    void Grotto_butClick(object sender, EventArgs e) => new GrottoForm((SAV5B2W2)SAV).ShowDialogInParent();

    void TrainerRecords_butClick(object sender, EventArgs e) => new TrainerRecordsForm(SAV).ShowDialogInParent();

    void Medal_butClick(object sender, EventArgs e) => new MedalsForm((SAV5B2W2)SAV).ShowDialogInParent();

    void Forest_butClick(object sender, EventArgs e) => new EntralinkForm(SAV).ShowDialogInParent();

    void Key_butClick(object sender, EventArgs e) => new KeySystemForm((SAV5B2W2)SAV).ShowDialogInParent();

    void Join_butClick(object sender, EventArgs e) => new JoinAvenueForm((SAV5B2W2)SAV).ShowDialogInParent();

    void Trainer_butClick(object sender, EventArgs e) => new TrainerInfoForm(SAV).ShowDialogInParent();

    void Memory_butClick(object sender, EventArgs e) => new MemoryLinkForm((SAV5B2W2)SAV).ShowDialogInParent();

    void Dlc_butClick(object sender, EventArgs e) => new DLCForm(SAV).ShowDialogInParent();

    void Dr_butClick(object sender, EventArgs e) => new DreamRadarForm((SAV5B2W2)SAV).ShowDialogInParent();

    void Prop_butClick(object sender, EventArgs e) => new PropcaseForm(SAV).ShowDialogInParent();

    private void exit_Click(object sender, EventArgs e) => Close();
  }
}
