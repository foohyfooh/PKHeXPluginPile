using PKHeX.Core;
using PluginPile.Common;
using System.Reflection;

namespace PluginPile.Unmaintained.SwShRaidTool;
public class SwShRaidPlugin : PluginBase {
  public override string Name => nameof(SwShRaidPlugin);
  protected override Assembly PluginAssembly => typeof(SwShRaidPlugin).Assembly;

  private readonly ToolStripMenuItem RaidsViewer;
  private bool IsCompatibleSave => SaveFileEditor.SAV is SAV8SWSH;

  public SwShRaidPlugin() {
    RaidsViewer = new ToolStripMenuItem(Language.DisplayRaids) { Visible = false };
    RaidsViewer.Click += (s, e) => Open();
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    tools.DropDownItems.Add(RaidsViewer);
  }

  private void Open() {
    SAV8SWSH sav = (SAV8SWSH)SaveFileEditor.SAV;
    RaidList f = new RaidList(sav.Blocks, sav.Version, sav.Badges, sav.TID16, sav.SID16);
    f.Show();
  }

  protected override void LoadContextMenu(ContextMenuStrip contextMenu) {
    contextMenu.Opening += (s, e) => {
      SlotViewInfo<PictureBox> info = GetSenderInfo(ref s!);
      if (IsCompatibleSave) {
        ToolStripMenuItem findSeedButton = new ToolStripMenuItem(Language.SeedFinder);
        findSeedButton.Click += (s, e) => {
          SeedFinder sf = new SeedFinder(SaveFileEditor.SAV.TID16, SaveFileEditor.SAV.SID16);
          int slotIndex = SaveFileEditor.CurrentBox * SaveFileEditor.SAV.BoxSlotCount + info.Slot.Slot;
          PK8 mon = (PK8)SaveFileEditor.SAV.GetBoxSlotAtIndex(slotIndex);
          sf.LoadPKM(mon);
          sf.Show();
        };
        contextMenu.Items.Add(findSeedButton);
        contextMenu.Closing += (s, e) => contextMenu.Items.Remove(findSeedButton);
      }
    };
  }

  public override void NotifySaveLoaded() {
    RaidsViewer.Visible = IsCompatibleSave;
  }
}
