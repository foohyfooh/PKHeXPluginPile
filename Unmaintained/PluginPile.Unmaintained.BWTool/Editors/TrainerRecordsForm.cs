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
  private readonly TrainerRecords TrainerRecords;
  public TrainerRecordsForm(SAV5 sav) {
    InitializeComponent();
    SAV = sav;
    TrainerRecords = new TrainerRecords(SAV.GetBlock(Constants.TrainerRecords));
    RecordIndex.SelectedIndex = 0;
    RecordValue.Value = TrainerRecords.WildCount;
  }

  void Record_indexSelectedIndexChanged(object sender, EventArgs e) {
    RecordValue.Value = TrainerRecords.WildCount;
  }
}
