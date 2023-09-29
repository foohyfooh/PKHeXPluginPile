using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.StartDateEditor {
  public class StartDateEditor: PluginBase {
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
        else if (SaveFileEditor.SAV is SAV8BS)   EditBDSPAdventureStart();
        else if (SaveFileEditor.SAV is SAV8LA)   EditLAAdventureStart();
        else if (SaveFileEditor.SAV is SAV9SV)   EditSVEnrollmentDate();
      };
      tools.DropDownItems.Add(StartDateEditorButton);
    }
    protected override void HandleSaveLoaded() => StartDateEditorButton.Available = IsCompatibleSave;

    private void EditSwShStartDate() {
      SAV8SWSH sav = (SAV8SWSH)SaveFileEditor.SAV;
      TrainerCard8 trainerCard = sav.TrainerCard;
      DateTime startDate = new DateTime(trainerCard.StartedYear, trainerCard.StartedMonth, trainerCard.StartedDay);
      DateEditorForm dateEditorForm = new DateEditorForm(startDate);
      if (dateEditorForm.ShowDialogInParent() == DialogResult.OK) {
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
      if (dateEditorForm.ShowDialogInParent() == DialogResult.OK) {
        sav.System.TimestampStart = dateEditorForm.GetStartDate();
        sav.State.Edited = true;
      }
    }

    private void EditLAAdventureStart() {
      SAV8LA sav = (SAV8LA)SaveFileEditor.SAV;
      DateEditorForm dateEditorForm = new DateEditorForm(sav.AdventureStart.Timestamp);
      if (dateEditorForm.ShowDialogInParent() == DialogResult.OK) {
        sav.AdventureStart.Timestamp = dateEditorForm.GetStartDate();
        sav.State.Edited = true;
      }
    }

    private void EditSVEnrollmentDate() {
      SAV9SV sav = (SAV9SV)SaveFileEditor.SAV;
      DateEditorForm dateEditorForm = new DateEditorForm(sav.EnrollmentDate.Timestamp);
      if (dateEditorForm.ShowDialogInParent() == DialogResult.OK) {
        sav.EnrollmentDate.Timestamp = dateEditorForm.GetStartDate();
        sav.State.Edited = true;
      }
    }

  }
}
