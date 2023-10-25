using PKHeX.Core;
using System.Reflection;
using PluginPile.Common;

namespace PluginPile.Unmaintained.SwShEventEditor;
public class SwShEventEditorPlugin : PluginBase {
  public override string Name => nameof(SwShEventEditorPlugin);
  protected override Assembly PluginAssembly => throw new NotImplementedException();
  private readonly ToolStripMenuItem RootToolStripMenuItem;
  private readonly ToolStripMenuItem BaseGameMenuItem;
  private readonly ToolStripMenuItem IsleOfArmorMenuItem;
  private readonly ToolStripMenuItem CrownTundraMenuItem;
  private bool IsGameSwordShield => SaveFileEditor.SAV is SAV8SWSH;

  public SwShEventEditorPlugin() {
    RootToolStripMenuItem = new ToolStripMenuItem(Language.MenuItemName);
    BaseGameMenuItem = new ToolStripMenuItem(Language.EditorBaseGameWorldEvent);
    BaseGameMenuItem.Click += (s, e) => new WorldEventsForm((SAV8SWSH)SaveFileEditor.SAV, WorldEventsForm.Pages.Main).ShowDialogInParent();
    IsleOfArmorMenuItem = new ToolStripMenuItem(Language.EditIsleOfArmorWorldEvents, Properties.Resources.Armor);
    IsleOfArmorMenuItem.Click += (s, e) => new WorldEventsForm((SAV8SWSH)SaveFileEditor.SAV, WorldEventsForm.Pages.IsleOfArmor).ShowDialogInParent();

    CrownTundraMenuItem = new ToolStripMenuItem(Language.CrownTundra, Properties.Resources.Crown);
    ToolStripMenuItem crownTundraWorldEvents = new ToolStripMenuItem(Language.CrownTundraEditWorldEvents);
    crownTundraWorldEvents.Click += (s, e) => new WorldEventsForm((SAV8SWSH)SaveFileEditor.SAV, WorldEventsForm.Pages.CrownTundra).ShowDialogInParent();
    CrownTundraMenuItem.DropDownItems.Add(crownTundraWorldEvents);
    ToolStripMenuItem maxLair = new ToolStripMenuItem(Language.CrownTundraEditMaxLair);
    maxLair.Click += (s, e) => new DynamaxResetForm((SAV8SWSH)SaveFileEditor.SAV).ShowDialogInParent();
    CrownTundraMenuItem.DropDownItems.Add(maxLair);
    ToolStripMenuItem regis = new ToolStripMenuItem(Language.CrownTundraEditRegis);
    regis.Click += (s, e) => new RegiForm((SAV8SWSH)SaveFileEditor.SAV).ShowDialogInParent();
    CrownTundraMenuItem.DropDownItems.Add(regis);
    ToolStripMenuItem swordsOfJustice = new ToolStripMenuItem(Language.CrownTundraEditSwordsOfJustice);
    swordsOfJustice.Click += (s, e) => new SwordsOfJusticeForm((SAV8SWSH)SaveFileEditor.SAV).ShowDialogInParent();
    CrownTundraMenuItem.DropDownItems.Add(swordsOfJustice);

    ToolStripMenuItem curryCamp = new ToolStripMenuItem(Language.EditCurrydexAndPokecamp);
    curryCamp.Click += (s, e) => new PokeCampCurrydexForm((SAV8SWSH)SaveFileEditor.SAV).ShowDialogInParent();
    ToolStripMenuItem wondercard = new ToolStripMenuItem(Language.ConvertWondercard);
    wondercard.Click += (s, e) => new Wonder2FashionForm((SAV8SWSH)SaveFileEditor.SAV).ShowDialogInParent();

    RootToolStripMenuItem.DropDownItems.Add(BaseGameMenuItem);
    RootToolStripMenuItem.DropDownItems.Add(IsleOfArmorMenuItem);
    RootToolStripMenuItem.DropDownItems.Add(CrownTundraMenuItem);
    RootToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
    RootToolStripMenuItem.DropDownItems.Add(curryCamp);
    RootToolStripMenuItem.DropDownItems.Add(wondercard);
  }

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    tools.DropDownItems.Add(RootToolStripMenuItem);
  }

  public override void NotifySaveLoaded() {
    RootToolStripMenuItem.Available = IsGameSwordShield;
    BaseGameMenuItem.Image = SaveFileEditor.SAV.Version == GameVersion.SW ? Properties.Resources.Sword : Properties.Resources.Shield;
    IsleOfArmorMenuItem.Available = IsGameSwordShield && ((SAV8SWSH)SaveFileEditor.SAV).SaveRevision >= 1;
    CrownTundraMenuItem.Available = IsGameSwordShield && ((SAV8SWSH)SaveFileEditor.SAV).SaveRevision >= 2;
  }
}
