/* Data shown in trainer card info
 *
Times Linked
Link Battles
Link Battle Wins
Link Battle Losses
Link Trades
Wild Pokémon encounters
Trainers Battled
Feeling checks


----Not on trainer records

People passed by
Usable Pass Powers
Musical Performances ? - Appears if not 0
Poké Transfer High Score ? - Appears if not 0
Battle Test High Score ? - Appears if not 0
Cleared Funfest missions
Movie Shoots ? - Appears if not 0
Wins at the PWT
Customers recommended to Join Avenue ? - Appears if not 0
*/

using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool;

public partial class TrainerRecordsForm : Form {

  private readonly SAV5 SAV;
  private readonly TrainerRecords trainerRecords;
  public TrainerRecordsForm(SAV5 sav) {
    InitializeComponent();
    SAV = sav;
    trainerRecords = new TrainerRecords(SAV.GetBlock(Constants.TrainerRecords));
    record_index.SelectedIndex = 0;
    record_value.Value = trainerRecords.WildCount;
  }

  void Record_indexSelectedIndexChanged(object sender, EventArgs e) {
    record_value.Value = trainerRecords.WildCount;
  }
}
