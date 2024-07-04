using PKHeX.Core;
using PluginPile.Common;

namespace PluginPile.Sorting; 
public class SortingPlugin : PluginBase {
  public override string Name => nameof(SortingPlugin);
  private readonly ToolStripMenuItem SortByButton;

  public SortingPlugin() {
    SortByButton = new ToolStripMenuItem() {
      Image = Properties.Images.SortIcon
    };
  }

  protected override void HandleSaveLoaded() => ReloadMenu();

  public override void NotifyDisplayLanguageChanged(string language) => ReloadMenu();

  protected override void LoadMenu(ToolStripDropDownItem tools) {
    tools.DropDownItems.Add(SortByButton);
    SetSortItems();
  }

  private void SetSortItems() {
    SortByButton.Text = Language.MenuItemName;
    SortByButton.DropDownItems.Clear();
    ToolStripItemCollection sortItems = SortByButton.DropDownItems;
    byte gen = SaveFileEditor.SAV.Generation;
    GameVersion version = SaveFileEditor.SAV.Version;
    bool isLetsGo = version == GameVersion.GP || version == GameVersion.GE;
    if (isLetsGo) {
      sortItems.Add(GetRegionalSortButton(Language.Gen7Kanto, Gen7Kanto.GetSortFunctions()));
    } else {
      bool isBDSP = version == GameVersion.BD || version == GameVersion.SP;
      bool isPLA  = version == GameVersion.PLA;

      if (gen >= 1) {
        sortItems.Add(GetRegionalSortButton(Language.Gen1Kanto, Gen1Kanto.GetSortFunctions()));
      }

      if (gen >= 2) {
        sortItems.Add(GetRegionalSortButton(Language.Gen2Johto, Gen2Johto.GetSortFunctions()));
      }

      if (gen >= 3) {
        sortItems.Add(GetRegionalSortButton(Language.Gen3Hoenn, Gen3Hoenn.GetSortFunctions()));
        sortItems.Add(GetRegionalSortButton(Language.Gen3Kanto, Gen3Kanto.GetSortFunctions()));
      }

      if (gen >= 4) {
        sortItems.Add(GetRegionalSortButton(Language.Gen4SinnohDiamondPearl, Gen4Sinnoh.GetDPSortFunctions()));
        sortItems.Add(GetRegionalSortButton(Language.Gen4SinnohPlatinum, Gen4Sinnoh.GetPtSortFunctions()));
        sortItems.Add(GetRegionalSortButton(Language.Gen4Johto, Gen4Johto.GetSortFunctions()));
      }

      if (gen >= 5 && !isBDSP) {
        sortItems.Add(GetRegionalSortButton(Language.Gen5UnovaBlackWhite, Gen5Unova.GetBWSortFunctions()));
        sortItems.Add(GetRegionalSortButton(Language.Gen5UnovaBlack2White2, Gen5Unova.GetB2W2SortFunctions()));
      }

      if (gen >= 6 && !isBDSP) {
        if (PluginSettings.Default.ShowIndividualPokedéxes) {
          sortItems.Add(GetAreaButtons(Language.Gen6KalosAreas, [
            GetRegionalSortButton(Language.Gen6KalosAreasCentralKalos, Gen6Kalos.GetCentralDexSortFunctions()),
            GetRegionalSortButton(Language.Gen6KalosAreasCostalKalos, Gen6Kalos.GetCostalDexSortFunctions()),
            GetRegionalSortButton(Language.Gen6KalosAreasMountainKalos, Gen6Kalos.GetMountainDexSortFunctions())
          ]));
        }
        sortItems.Add(GetRegionalSortButton(Language.Gen6Kalos, Gen6Kalos.GetSortFunctions()));
        sortItems.Add(GetRegionalSortButton(Language.Gen6Hoenn, Gen6Hoenn.GetSortFunctions()));
      }

      if (gen >= 7 && !isBDSP && !isPLA) {
        if (PluginSettings.Default.ShowIndividualPokedéxes) {
          sortItems.Add(GetAreaButtons(Language.Gen7AlolaSunMoonIslands, [
            GetRegionalSortButton(Language.Gen7AlolaIslandsMelemele, Gen7Alola.GetSMMelemeleSortFunctions()),
            GetRegionalSortButton(Language.Gen7AlolaIslandsAkala, Gen7Alola.GetSMAkalaSortFunctions()),
            GetRegionalSortButton(Language.Gen7AlolaIslandsUlaula, Gen7Alola.GetSMUlaulaSortFunctions()),
            GetRegionalSortButton(Language.Gen7AlolaIslandsPoni, Gen7Alola.GetSMPoniSortFunctions())
          ]));
        }
        sortItems.Add(GetRegionalSortButton(Language.Gen7AlolaSunMoon, Gen7Alola.GetSMSortFunctions()));
        if (PluginSettings.Default.ShowIndividualPokedéxes) {
          sortItems.Add(GetAreaButtons(Language.Gen7AlolaUltraSunUltraMoonIslands, [
            GetRegionalSortButton(Language.Gen7AlolaIslandsMelemele, Gen7Alola.GetUSUMMelemeleSortFunctions()),
            GetRegionalSortButton(Language.Gen7AlolaIslandsAkala, Gen7Alola.GetUSUMAkalaSortFunctions()),
            GetRegionalSortButton(Language.Gen7AlolaIslandsUlaula, Gen7Alola.GetUSUMUlaulaSortFunctions()),
            GetRegionalSortButton(Language.Gen7AlolaIslandsPoni, Gen7Alola.GetUSUMPoniSortFunctions())
          ]));
        }
        sortItems.Add(GetRegionalSortButton(Language.Gen7AlolaUltraSunUltraMoon, Gen7Alola.GetUSUMSortFunctions()));
      }

      if (gen >= 8) {
        bool isSwSh = version == GameVersion.SW || version == GameVersion.SH;
        if (!isBDSP && !isPLA) {
          bool isScVi = version == GameVersion.SL || version == GameVersion.VL;
          if (!isScVi) {
            sortItems.Add(GetRegionalSortButton(Language.Gen7Kanto, Gen7Kanto.GetSortFunctions()));
          }
          if (PluginSettings.Default.ShowIndividualPokedéxes) {
            sortItems.Add(GetAreaButtons(Language.Gen8GalarAreas, [
              GetRegionalSortButton(Language.Gen8GalarAreasGalar, Gen8Galar.GetGalarDexSortFunctions()),
              GetRegionalSortButton(Language.Gen8GalarAreasIsleofArmor, Gen8Galar.GetIoADexSortFunctions()),
              GetRegionalSortButton(Language.Gen8GalarAreasCrownTundra, Gen8Galar.GetCTDexSortFunction())
            ]));
          }
          sortItems.Add(GetRegionalSortButton(Language.Gen8Galar, Gen8Galar.GetFullGalarDexSortFunctions()));
        }
        if (!isSwSh) {
          sortItems.Add(GetRegionalSortButton(Language.Gen8Sinnoh, Gen8Sinnoh.GetSortFunctions()));
          if (!isBDSP) {
            if (PluginSettings.Default.ShowIndividualPokedéxes) {
              sortItems.Add(GetAreaButtons(Language.Gen8HisuiAreas, [
                GetRegionalSortButton(Language.Gen8HisuiAreasObsidianFieldlands, Gen8Hisui.GetObsidianFieldlandsSortFunctions()),
                GetRegionalSortButton(Language.Gen8HisuiAreasCrimsonMirelands, Gen8Hisui.GetCrimsonMirelandsSortFunctions()),
                GetRegionalSortButton(Language.Gen8HisuiAreasCobaltCoastlands, Gen8Hisui.GetCobaltCoastlandsSortFunctions()),
                GetRegionalSortButton(Language.Gen8HisuiAreasCoronetHighlands, Gen8Hisui.GetCoronetHighlandsSortFunctions()),
                GetRegionalSortButton(Language.Gen8HisuiAreasAlabasterIcelands, Gen8Hisui.GetAlabasterIcelandsSortFunctions())
              ]));
            }
            sortItems.Add(GetRegionalSortButton(Language.Gen8Hisui, Gen8Hisui.GetSortFunctions()));
          }
        }
      }

      if (gen >= 9) {
        if (PluginSettings.Default.ShowIndividualPokedéxes) {
          sortItems.Add(GetAreaButtons(Language.Gen9PaldeaRegions, [
            GetRegionalSortButton(Language.Gen9PaldeaRegionsPaldea, Gen9Paldea.GetPaldeaSortFunctions()),
            GetRegionalSortButton(Language.Gen9PaldeaRegionsKitakami, Gen9Paldea.GetKitakamiSortFunctions()),
            GetRegionalSortButton(Language.Gen9PaldeaRegionsBlueberryAcademy, Gen9Paldea.GetBlueberryAcademySortFunctions())
          ]));
        }
        sortItems.Add(GetRegionalSortButton(Language.Gen9Paldea, Gen9Paldea.GetSortFunctions()));
      }

      if (gen != 1) {
        ToolStripMenuItem nationalDexSortButton = new ToolStripMenuItem(Language.NationalPokédex);
        nationalDexSortButton.Click += (s, e) => SortByFunctions();
        sortItems.Add(nationalDexSortButton);

        if (gen >= 7 && !isBDSP) {
          ToolStripMenuItem nationalDexWithFormSortButton = new ToolStripMenuItem(Language.NationalPokédexRegionalForms);
          nationalDexWithFormSortButton.Click += (s, e) => SortByFunctions(GenNational.GetNationalDexWithRegionalFormsSortFunctions());
          sortItems.Add(nationalDexWithFormSortButton);
        }
      }
    }

    ToolStripMenuItem settingsButton = new ToolStripMenuItem(Language.Settings);
    settingsButton.Click += (s, e) => new SettingsForm(this).ShowDialogInParent();
    sortItems.Add(settingsButton);
  }

  public void ReloadMenu() => SetSortItems();

  private void SortByFunctions(Func<PKM, IComparable>[]? sortFunctions = null) {
    int beginIndex = PluginSettings.Default.SortBeginBox - 1;
    int endIndex = PluginSettings.Default.SortEndBox < 0 ? -1 : PluginSettings.Default.SortEndBox - 1;
    if (sortFunctions != null) {
      IEnumerable<PKM> sortMethod(IEnumerable<PKM> pkms, int start) => pkms.OrderByCustom(sortFunctions);
      SaveFileEditor.SAV.SortBoxes(beginIndex, endIndex, sortMethod);
    } else {
      SaveFileEditor.SAV.SortBoxes(beginIndex, endIndex);
    }
    SaveFileEditor.ReloadSlots();
  }

  private ToolStripMenuItem GetRegionalSortButton(string dex, Func<PKM, IComparable>[] sortFunctions) {
    ToolStripMenuItem dexSortButton = new ToolStripMenuItem(string.Format(Language.RegionalPokédexTemplate, dex));
    dexSortButton.Click += (s, e) => SortByFunctions(sortFunctions);
    return dexSortButton;
  }

  private static ToolStripMenuItem GetAreaButtons(string name, ToolStripItem[] sortButtons) {
    ToolStripMenuItem areas = new ToolStripMenuItem(name);
    areas.DropDownItems.AddRange(sortButtons);
    return areas;
  }

  protected override void LoadContextMenu(ContextMenuStrip contextMenu) {
    contextMenu.Opening += (s, e) => {
      SlotViewInfo<PictureBox> info = GetSenderInfo(ref s!);
      if (info.IsNonEmptyWriteableBoxSlot() && !SaveFileEditor.SAV.IsBoxSlotOverwriteProtected(info.View.ViewIndex, info.Slot.Slot)) {
        ToolStripMenuItem insertSlotButton = new ToolStripMenuItem(Language.InsertSlot);
        insertSlotButton.Click += (s, e) => InsertSlot(info.View.ViewIndex, info.Slot.Slot);
        contextMenu.Items.Add(insertSlotButton);
        contextMenu.Closing += (s, e) => contextMenu.Items.Remove(insertSlotButton);
      }
    };
  }

  private void InsertSlot(int boxNum, int slotNum) {
    int startIndex = boxNum * SaveFileEditor.SAV.BoxSlotCount + slotNum;
    int boxIndex = startIndex + 1;
    PKM currMon, nextMon;
    while (boxIndex < SaveFileEditor.SAV.SlotCount) {
      currMon = SaveFileEditor.SAV.GetBoxSlotAtIndex(boxIndex);
      if (currMon.Species == (int)Species.None) break;
      boxIndex++;
    }
    if (boxIndex == SaveFileEditor.SAV.SlotCount) {
      MessageBox.Show(string.Format(Language.NoEmptySlotsError, boxNum + 1, slotNum + 1), Language.InsertSlot, MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }
    currMon = SaveFileEditor.SAV.GetBoxSlotAtIndex(startIndex);
    SaveFileEditor.SAV.SetBoxSlotAtIndex(SaveFileEditor.SAV.BlankPKM, startIndex);
    for (int index = startIndex + 1; index <= boxIndex; index++) {
      StorageSlotSource slotSource = SaveFileEditor.SAV.GetBoxSlotFlags(index);
      if (slotSource.IsOverwriteProtected()) continue;
      nextMon = SaveFileEditor.SAV.GetBoxSlotAtIndex(index);
      SaveFileEditor.SAV.SetBoxSlotAtIndex(currMon, index, PKMImportSetting.UseDefault, PKMImportSetting.Skip);
      currMon = nextMon;
    }
    SaveFileEditor.ReloadSlots();
  }

}
