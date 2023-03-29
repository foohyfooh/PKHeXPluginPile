using PKHeX.Core;
using System.Reflection;

namespace PluginPile.StartDateEditor {
  public class StartDateEditor: Common.PluginBase {
    public override string Name => nameof(StartDateEditor);
    protected override Assembly PluginAssembly => typeof(StartDateEditor).Assembly;
    private ToolStripMenuItem StartDateEditorButton = null!;
    private bool IsCompatibleSave {
      get { return SaveFileEditor.SAV is SAV8SWSH or SAV8BS or SAV8LA or SAV9SV && SaveFileEditor.SAV.State.Exportable; }
    }

    protected override void LoadMenu(ToolStripDropDownItem tools) {
      StartDateEditorButton = new ToolStripMenuItem(Language.MenuItemName);
      StartDateEditorButton.Available = IsCompatibleSave;
      StartDateEditorButton.Click += (s, e) => {
        if (SaveFileEditor.SAV is SAV8SWSH) EditSwShStartDate();
        else if (SaveFileEditor.SAV is SAV8BS) EditBDSPAdventureStart();
        else if (SaveFileEditor.SAV is SAV8LA) EditLAAdventureStart();
        else if (SaveFileEditor.SAV is SAV9SV) EditSVEnrollmentDate();
      };
      tools.DropDownItems.Add(StartDateEditorButton);
    }
    protected override void HandleSaveLoaded() => StartDateEditorButton.Available = IsCompatibleSave;

    private void EditSwShStartDate() {
      SAV8SWSH sav = (SAV8SWSH)SaveFileEditor.SAV;
      TrainerCard8 trainerCard = sav.TrainerCard;
      DateTime startDate = new DateTime(trainerCard.StartedYear, trainerCard.StartedMonth, trainerCard.StartedDay);
      DateEditorForm dateEditorForm = new DateEditorForm(startDate);
      if (dateEditorForm.ShowDialog() == DialogResult.OK) {
        startDate = dateEditorForm.GetStartDate();
        trainerCard.StartedYear = (ushort)startDate.Year;
        trainerCard.StartedMonth = (byte)startDate.Month;
        trainerCard.StartedDay = (byte)startDate.Day;
        sav.State.Edited = true;
      }
    }

    private void EditBDSPAdventureStart() {
      SAV8BS sav = (SAV8BS)SaveFileEditor.SAV;
      DateEditorForm dateEditorForm = new DateEditorForm(sav.System.TimestampStart);
      if (dateEditorForm.ShowDialog() == DialogResult.OK) {
        sav.System.TimestampStart = dateEditorForm.GetStartDate();
        sav.State.Edited = true;
      }
    }

    private void EditLAAdventureStart() {
      SAV8LA sav = (SAV8LA)SaveFileEditor.SAV;
      DateEditorForm dateEditorForm = new DateEditorForm(sav.AdventureStart.Timestamp);
      if (dateEditorForm.ShowDialog() == DialogResult.OK) {
        sav.AdventureStart.Timestamp = dateEditorForm.GetStartDate();
        sav.State.Edited = true;
      }
    }

    private void EditSVEnrollmentDate() {
      SAV9SV sav = (SAV9SV)SaveFileEditor.SAV;
      SCBlock startTimeBlock = sav.Accessor.GetBlock(SVConstants.EnrollmentDate);
      byte[] data = startTimeBlock.Data.ToArray();
      Array.Reverse(data);
      // Ignore first byte since it should just be 00
      // First 6 bits (first 6 bits of data[1]) are 1 index day
      // Second 6 bits (last 2 bits of data[1] and first 4 bites of data[2]) are 0 index month
      // Last 12 bytes (last 4 bits of data[2] and all bits of data[3]) are year offset from 1900
      int startDay = data[1] >> 2;
      int startMonth = ((data[1] & 0b0000_0011) << 2) | ((data[2] & 0b1111_0000) >> 4);
      int startYear = ((data[2] & 0b0000_1111) << 4) | data[3];
      DateTime startDate = new DateTime(1900 + startYear, startMonth + 1, startDay);
      DateEditorForm dateEditorForm = new DateEditorForm(startDate);
      if (dateEditorForm.ShowDialog() == DialogResult.OK) {
        startDate = dateEditorForm.GetStartDate();
        startDay = startDate.Day;
        startMonth = startDate.Month - 1;
        startYear = startDate.Year - 1900;
        // data[1] is last 6 bits of day and 3rd+4th bits of month
        // data[2] is the last 4 bits of month and first 4 bits of year
        // data[3] is last 4 bits of year
        data[1] = (byte)(((startDay & 0b0011_1111) << 2) | ((startMonth & 0b0011_0000) >> 4));
        data[2] = (byte)(((startMonth & 0b0000_1111) << 4) | ((startYear & 0b1111_0000_00000) >> 8));
        data[3] = (byte)(startYear & 0b1111_1111);
        Array.Reverse(data);
        startTimeBlock.ChangeData(data);
        sav.State.Edited = true;
      }
    }

  }
}
