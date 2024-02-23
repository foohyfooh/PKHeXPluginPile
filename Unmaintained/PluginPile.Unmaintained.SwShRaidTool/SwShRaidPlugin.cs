using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.Unmaintained.SwShRaidTool;
public class SwShRaidPlugin : PluginBase {
  public override string Name => nameof(SwShRaidPlugin);

  private readonly ToolStripMenuItem RaidsViewer;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV8SWSH;

  public SwShRaidPlugin() {
    RaidsViewer = new ToolStripMenuItem(Language.DisplayRaids);
    RaidsViewer.Click += (s, e) => new RaidList((SAV8SWSH)SaveFileEditor.SAV).Show();
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    tools.DropDownItems.Add(RaidsViewer);
  }

  protected override void LoadContextMenu(ContextMenuStrip contextMenu) {
    contextMenu.Opening += (s, e) => {
      SlotViewInfo<PictureBox> info = GetSenderInfo(ref s!);
      int slotIndex = info.View.ViewIndex * SaveFileEditor.SAV.BoxSlotCount + info.Slot.Slot;
      PKM mon = SaveFileEditor.SAV.GetBoxSlotAtIndex(slotIndex);
      if (IsCompatibleSave && (Species)mon.Species != Species.None && mon.Generation == 8) {
        ToolStripMenuItem findSeedButton = new ToolStripMenuItem(Language.SeedFinder);
        findSeedButton.Click += (s, e) => {
          SeedFinder sf = new SeedFinder(SaveFileEditor.SAV.TID16, SaveFileEditor.SAV.SID16);
          sf.LoadPKM(mon);
          sf.Show();
        };
        contextMenu.Items.Add(findSeedButton);
        contextMenu.Closing += (s, e) => contextMenu.Items.Remove(findSeedButton);
      }
    };
  }

  protected override void HandleSaveLoaded() => RaidsViewer.Visible = IsCompatibleSave;

  public override void NotifyDisplayLanguageChanged(string language) => RaidsViewer.Text = Language.DisplayRaids;
}
