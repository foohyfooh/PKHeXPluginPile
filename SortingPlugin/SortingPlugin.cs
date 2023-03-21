using PKHeX.Core;

namespace PluginPile.SortingPlugin {
  public class SortingPlugin : Common.PluginBase {
    public override string Name => nameof(SortingPlugin);

    protected override void HandleSaveLoaded() => ReloadMenu();

    protected override void LoadMenu(ToolStripDropDownItem tools) {
      tools.DropDownItems.RemoveByKey("SortBoxesBy");
      ToolStripMenuItem sortBoxesItem = new ToolStripMenuItem("Sort Boxes By") {
        Name = "SortBoxesBy",
        Image = Properties.Resources.SortIcon
      };
      tools.DropDownItems.Add(sortBoxesItem);
      ToolStripItemCollection sortItems = sortBoxesItem.DropDownItems;

      int gen = SaveFileEditor.SAV.Generation;
      GameVersion version = SaveFileEditor.SAV.Version;
      bool isLetsGo = version == GameVersion.GP || version == GameVersion.GE;
      if (isLetsGo) {
        sortItems.Add(GetRegionalSortButton("Gen 7 Kanto", Gen7_Kanto.GetSortFunctions()));
      } else {
        bool isBDSP = version == GameVersion.BD || version == GameVersion.SP;
        bool isPLA  = version == GameVersion.PLA;

        if (gen >= 1) {
          sortItems.Add(GetRegionalSortButton("Gen 1 Kanto", Gen1_Kanto.GetSortFunctions()));
        }

        if (gen >= 2) {
          sortItems.Add(GetRegionalSortButton("Gen 2 Johto", Gen2_Johto.GetSortFunctions()));
        }

        if (gen >= 3) {
          sortItems.Add(GetRegionalSortButton("Gen 3 Hoenn", Gen3_Hoenn.GetSortFunctions()));
          sortItems.Add(GetRegionalSortButton("Gen 3 Kanto", Gen3_Kanto.GetSortFunctions()));
        }

        if (gen >= 4) {
          sortItems.Add(GetRegionalSortButton("Gen 4 Sinnoh Diamond/Pearl", Gen4_Sinnoh.GetDPSortFunctions()));
          sortItems.Add(GetRegionalSortButton("Gen 4 Sinnoh Platinum", Gen4_Sinnoh.GetPtSortFunctions()));
          sortItems.Add(GetRegionalSortButton("Gen 4 Johto", Gen4_Johto.GetSortFunctions()));
        }

        if (gen >= 5 && !isBDSP) {
          sortItems.Add(GetRegionalSortButton("Gen 5 Unova Black/White", Gen5_Unova.GetBWSortFunctions()));
          sortItems.Add(GetRegionalSortButton("Gen 5 Unova Black 2/White 2", Gen5_Unova.GetB2W2SortFunctions()));
        }

        if (gen >= 6 && !isBDSP) {
          if (PluginSettings.Default.ShowIndividualPokedéxes) {
            sortItems.Add(GetAreaButtons("Gen 6 Kalos Areas", new ToolStripItem[] {
              GetRegionalSortButton("Central Kalos", Gen6_Kalos.GetCentralDexSortFunctions()),
              GetRegionalSortButton("Costal Kalos", Gen6_Kalos.GetCostalDexSortFunctions()),
              GetRegionalSortButton("Mountain Kalos", Gen6_Kalos.GetMountainDexSortFunctions())
            }));
          }
          sortItems.Add(GetRegionalSortButton("Gen 6 Kalos", Gen6_Kalos.GetSortFunctions()));
          sortItems.Add(GetRegionalSortButton("Gen 6 Hoenn", Gen6_Hoenn.GetSortFunctions()));
        }

        if (gen >= 7 && !isBDSP && !isPLA) {
          if (PluginSettings.Default.ShowIndividualPokedéxes) {
            sortItems.Add(GetAreaButtons("Gen 7 Alola Sun/Moon Islands", new ToolStripItem[] {
              GetRegionalSortButton("Melemele Island", Gen7_Alola.GetSMMelemeleSortFunctions()),
              GetRegionalSortButton("Akala Island", Gen7_Alola.GetSMAkalaSortFunctions()),
              GetRegionalSortButton("Ula'ula Island", Gen7_Alola.GetSMUlaulaSortFunctions()),
              GetRegionalSortButton("Poni Island", Gen7_Alola.GetSMPoniSortFunctions())
            }));
          }
          sortItems.Add(GetRegionalSortButton("Gen 7 Alola Sun/Moon", Gen7_Alola.GetSMSortFunctions()));
          if (PluginSettings.Default.ShowIndividualPokedéxes) {
            sortItems.Add(GetAreaButtons("Gen 7 Alola Ultra Sun/Ultra Moon Islands", new ToolStripItem[] {
              GetRegionalSortButton("Melemele Island", Gen7_Alola.GetUSUMMelemeleSortFunctions()),
              GetRegionalSortButton("Akala Island", Gen7_Alola.GetUSUMAkalaSortFunctions()),
              GetRegionalSortButton("Ula'ula Island", Gen7_Alola.GetUSUMUlaulaSortFunctions()),
              GetRegionalSortButton("Poni Island", Gen7_Alola.GetUSUMPoniSortFunctions())
            }));
          }
          sortItems.Add(GetRegionalSortButton("Gen 7 Alola Ultra Sun/Ultra Moon", Gen7_Alola.GetUSUMSortFunctions()));
        }

        if (gen >= 8) {
          bool isSwSh = version == GameVersion.SW || version == GameVersion.SH;
          if (!isBDSP && !isPLA) {
            bool isScVi = version == GameVersion.SL || version == GameVersion.VL;
            if (!isScVi) {
              sortItems.Add(GetRegionalSortButton("Gen 7 Kanto", Gen7_Kanto.GetSortFunctions()));
            }
            if (PluginSettings.Default.ShowIndividualPokedéxes) {
              sortItems.Add(GetAreaButtons("Gen 8 Galar Areas", new ToolStripItem[] {
                GetRegionalSortButton("Galar", Gen8_Galar.GetGalarDexSortFunctions()),
                GetRegionalSortButton("Isle of Armor", Gen8_Galar.GetIoADexSortFunctions()),
                GetRegionalSortButton("Crown Tundra", Gen8_Galar.GetCTDexSortFunction())
              }));
            }
            sortItems.Add(GetRegionalSortButton("Gen 8 Galar", Gen8_Galar.GetFullGalarDexSortFunctions()));
          }
          if (!isSwSh) {
            sortItems.Add(GetRegionalSortButton("Gen 8 Sinnoh", Gen8_Sinnoh.GetSortFunctions()));
            if (!isBDSP) {
              if (PluginSettings.Default.ShowIndividualPokedéxes) {
                sortItems.Add(GetAreaButtons("Gen 8 Hisui Areas", new ToolStripItem[] {
                  GetRegionalSortButton("Obsidian Fieldlands", Gen8_Hisui.GetObsidianFieldlandsSortFunctions()),
                  GetRegionalSortButton("Crimson Mirelands", Gen8_Hisui.GetCrimsonMirelandsSortFunctions()),
                  GetRegionalSortButton("Cobalt Coastlands", Gen8_Hisui.GetCobaltCoastlandsSortFunctions()),
                  GetRegionalSortButton("Coronet Highlands", Gen8_Hisui.GetCoronetHighlandsSortFunctions()),
                  GetRegionalSortButton("Alabaster Icelands", Gen8_Hisui.GetAlabasterIcelandsSortFunctions())
                }));
              }
              sortItems.Add(GetRegionalSortButton("Gen 8 Hisui", Gen8_Hisui.GetSortFunctions()));
            }
          }
        }

        if (gen >= 9) {
          sortItems.Add(GetRegionalSortButton("Gen 9 Paldea", Gen9_Paldea.GetSortFunctions()));
        }

        if(gen != 1) {
          ToolStripMenuItem nationalDexSortButton = new ToolStripMenuItem("National Pokédex");
          nationalDexSortButton.Click += (s, e) => SortByFunctions();
          sortItems.Add(nationalDexSortButton);

          if(gen >= 7 && !isBDSP) {
            ToolStripMenuItem nationalDexWithFormSortButton = new ToolStripMenuItem("National Pokédex (Regional Forms With Generation)");
            nationalDexWithFormSortButton.Click += (s, e) => SortByFunctions(Gen_National.GetNationalDexWithRegionalFormsSortFunctions());
            sortItems.Add(nationalDexWithFormSortButton);
          }
        }
      }

      ToolStripMenuItem settingsButton = new ToolStripMenuItem("Settings");
      settingsButton.Click += (s, e) => new SettingsForm(this).ShowDialog();
      sortItems.Add(settingsButton);
    }

    public void ReloadMenu() {
      ToolStripDropDownItem tools = ObtainToolsMenu();
      LoadMenu(tools);
    }

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

    private ToolStripItem GetRegionalSortButton(string dex, Func<PKM, IComparable>[] sortFunctions) {
      ToolStripMenuItem dexSortButton = new ToolStripMenuItem($"{dex} Regional Pokédex");
      dexSortButton.Click += (s, e) => SortByFunctions(sortFunctions);
      return dexSortButton;
    }

    private ToolStripMenuItem GetAreaButtons(string name, ToolStripItem[] sortButtons) {
      ToolStripMenuItem areas = new ToolStripMenuItem(name);
      areas.DropDownItems.AddRange(sortButtons);
      return areas;
    }

  }
}
