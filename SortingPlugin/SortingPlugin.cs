using PKHeX.Core;

namespace PluginPile.SortingPlugin {
  public class SortingPlugin : Common.PluginBase {
    public override string Name => nameof(SortingPlugin);

    protected override void HandleSaveLoaded() => ReloadMenu();

    protected override void LoadMenu(ToolStripDropDownItem tools) {
      tools.DropDownItems.RemoveByKey(Properties.Text.MenuItemKey);
      ToolStripMenuItem sortBoxesItem = new ToolStripMenuItem(Properties.Text.MenuItemName) {
        Name = Properties.Text.MenuItemKey,
        Image = Properties.Images.SortIcon
      };
      tools.DropDownItems.Add(sortBoxesItem);
      ToolStripItemCollection sortItems = sortBoxesItem.DropDownItems;

      int gen = SaveFileEditor.SAV.Generation;
      GameVersion version = SaveFileEditor.SAV.Version;
      bool isLetsGo = version == GameVersion.GP || version == GameVersion.GE;
      if (isLetsGo) {
        sortItems.Add(GetRegionalSortButton(Properties.Text.Gen7Kanto, Gen7_Kanto.GetSortFunctions()));
      } else {
        bool isBDSP = version == GameVersion.BD || version == GameVersion.SP;
        bool isPLA  = version == GameVersion.PLA;

        if (gen >= 1) {
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen1Kanto, Gen1_Kanto.GetSortFunctions()));
        }

        if (gen >= 2) {
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen2Johto, Gen2_Johto.GetSortFunctions()));
        }

        if (gen >= 3) {
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen3Hoenn, Gen3_Hoenn.GetSortFunctions()));
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen3Kanto, Gen3_Kanto.GetSortFunctions()));
        }

        if (gen >= 4) {
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen4SinnohDiamondPearl, Gen4_Sinnoh.GetDPSortFunctions()));
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen4SinnohPlatinum, Gen4_Sinnoh.GetPtSortFunctions()));
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen4Johto, Gen4_Johto.GetSortFunctions()));
        }

        if (gen >= 5 && !isBDSP) {
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen5UnovaBlackWhite, Gen5_Unova.GetBWSortFunctions()));
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen5UnovaBlack2White2, Gen5_Unova.GetB2W2SortFunctions()));
        }

        if (gen >= 6 && !isBDSP) {
          if (PluginSettings.Default.ShowIndividualPokedéxes) {
            sortItems.Add(GetAreaButtons(Properties.Text.Gen6KalosAreas, new ToolStripItem[] {
              GetRegionalSortButton(Properties.Text.Gen6KalosAreasCentralKalos, Gen6_Kalos.GetCentralDexSortFunctions()),
              GetRegionalSortButton(Properties.Text.Gen6KalosAreasCostalKalos, Gen6_Kalos.GetCostalDexSortFunctions()),
              GetRegionalSortButton(Properties.Text.Gen6KalosAreasMountainKalos, Gen6_Kalos.GetMountainDexSortFunctions())
            }));
          }
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen6Kalos, Gen6_Kalos.GetSortFunctions()));
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen6Hoenn, Gen6_Hoenn.GetSortFunctions()));
        }

        if (gen >= 7 && !isBDSP && !isPLA) {
          if (PluginSettings.Default.ShowIndividualPokedéxes) {
            sortItems.Add(GetAreaButtons(Properties.Text.Gen7AlolaSunMoonIslands, new ToolStripItem[] {
              GetRegionalSortButton(Properties.Text.Gen7AlolaIslandsMelemele, Gen7_Alola.GetSMMelemeleSortFunctions()),
              GetRegionalSortButton(Properties.Text.Gen7AlolaIslandsAkala, Gen7_Alola.GetSMAkalaSortFunctions()),
              GetRegionalSortButton(Properties.Text.Gen7AlolaIslandsUlaula, Gen7_Alola.GetSMUlaulaSortFunctions()),
              GetRegionalSortButton(Properties.Text.Gen7AlolaIslandsPoni, Gen7_Alola.GetSMPoniSortFunctions())
            }));
          }
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen7AlolaSunMoon, Gen7_Alola.GetSMSortFunctions()));
          if (PluginSettings.Default.ShowIndividualPokedéxes) {
            sortItems.Add(GetAreaButtons(Properties.Text.Gen7AlolaUltraSunUltraMoonIslands, new ToolStripItem[] {
              GetRegionalSortButton(Properties.Text.Gen7AlolaIslandsMelemele, Gen7_Alola.GetUSUMMelemeleSortFunctions()),
              GetRegionalSortButton(Properties.Text.Gen7AlolaIslandsAkala, Gen7_Alola.GetUSUMAkalaSortFunctions()),
              GetRegionalSortButton(Properties.Text.Gen7AlolaIslandsUlaula, Gen7_Alola.GetUSUMUlaulaSortFunctions()),
              GetRegionalSortButton(Properties.Text.Gen7AlolaIslandsPoni, Gen7_Alola.GetUSUMPoniSortFunctions())
            }));
          }
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen7AlolaUltraSunUltraMoon, Gen7_Alola.GetUSUMSortFunctions()));
        }

        if (gen >= 8) {
          bool isSwSh = version == GameVersion.SW || version == GameVersion.SH;
          if (!isBDSP && !isPLA) {
            bool isScVi = version == GameVersion.SL || version == GameVersion.VL;
            if (!isScVi) {
              sortItems.Add(GetRegionalSortButton(Properties.Text.Gen7Kanto, Gen7_Kanto.GetSortFunctions()));
            }
            if (PluginSettings.Default.ShowIndividualPokedéxes) {
              sortItems.Add(GetAreaButtons(Properties.Text.Gen8GalarAreas, new ToolStripItem[] {
                GetRegionalSortButton(Properties.Text.Gen8GalarAreasGalar, Gen8_Galar.GetGalarDexSortFunctions()),
                GetRegionalSortButton(Properties.Text.Gen8GalarAreasIsleofArmor, Gen8_Galar.GetIoADexSortFunctions()),
                GetRegionalSortButton(Properties.Text.Gen8GalarAreasCrownTundra, Gen8_Galar.GetCTDexSortFunction())
              }));
            }
            sortItems.Add(GetRegionalSortButton(Properties.Text.Gen8Galar, Gen8_Galar.GetFullGalarDexSortFunctions()));
          }
          if (!isSwSh) {
            sortItems.Add(GetRegionalSortButton(Properties.Text.Gen8Sinnoh, Gen8_Sinnoh.GetSortFunctions()));
            if (!isBDSP) {
              if (PluginSettings.Default.ShowIndividualPokedéxes) {
                sortItems.Add(GetAreaButtons(Properties.Text.Gen8HisuiAreas, new ToolStripItem[] {
                  GetRegionalSortButton(Properties.Text.Gen8HisuiAreasObsidianFieldlands, Gen8_Hisui.GetObsidianFieldlandsSortFunctions()),
                  GetRegionalSortButton(Properties.Text.Gen8HisuiAreasCrimsonMirelands, Gen8_Hisui.GetCrimsonMirelandsSortFunctions()),
                  GetRegionalSortButton(Properties.Text.Gen8HisuiAreasCobaltCoastlands, Gen8_Hisui.GetCobaltCoastlandsSortFunctions()),
                  GetRegionalSortButton(Properties.Text.Gen8HisuiAreasCoronetHighlands, Gen8_Hisui.GetCoronetHighlandsSortFunctions()),
                  GetRegionalSortButton(Properties.Text.Gen8HisuiAreasAlabasterIcelands, Gen8_Hisui.GetAlabasterIcelandsSortFunctions())
                }));
              }
              sortItems.Add(GetRegionalSortButton(Properties.Text.Gen8Hisui, Gen8_Hisui.GetSortFunctions()));
            }
          }
        }

        if (gen >= 9) {
          sortItems.Add(GetRegionalSortButton(Properties.Text.Gen9Paldea, Gen9_Paldea.GetSortFunctions()));
        }

        if(gen != 1) {
          ToolStripMenuItem nationalDexSortButton = new ToolStripMenuItem(Properties.Text.NationalPokédex);
          nationalDexSortButton.Click += (s, e) => SortByFunctions();
          sortItems.Add(nationalDexSortButton);

          if(gen >= 7 && !isBDSP) {
            ToolStripMenuItem nationalDexWithFormSortButton = new ToolStripMenuItem(Properties.Text.NationalPokédexRegionalForms);
            nationalDexWithFormSortButton.Click += (s, e) => SortByFunctions(Gen_National.GetNationalDexWithRegionalFormsSortFunctions());
            sortItems.Add(nationalDexWithFormSortButton);
          }
        }
      }

      ToolStripMenuItem settingsButton = new ToolStripMenuItem(Properties.Text.Settings);
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
      ToolStripMenuItem dexSortButton = new ToolStripMenuItem(string.Format(Properties.Text.RegionalPokédexTemplate, dex));
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
