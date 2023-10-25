using PKHeX.Core;
using System.ComponentModel;

namespace PluginPile.Unmaintained.SwShRaidTool;
public partial class DenIVs : Form {
  private readonly RaidManager Raids;
  private static readonly int[] min_stars = { 0, 0, 0, 0, 1, 1, 2, 2, 2, 0 };
  private static readonly int[] max_stars = { 0, 1, 1, 2, 2, 2, 3, 3, 4, 4 };

  private static readonly ComboboxItem genderless = new ComboboxItem("Genderless", 2);
  private static readonly ComboboxItem female = new ComboboxItem("Female", 1);
  private static readonly ComboboxItem male = new ComboboxItem("Male", 0);
  private static readonly ComboboxItem any = new ComboboxItem("Any", -1);

  private static readonly string[] genders = { "Male", "Female", "Genderless" };
  private static readonly string[] shinytype = { "No", "Star", "Square" };
  private static readonly Dictionary<string, int> natureIdx = new Dictionary<string, int>();

  private CancellationTokenSource cts = new CancellationTokenSource();

  public DenIVs(int idx, RaidManager raids) {
    InitializeComponent();
    GameStrings gameStrings = GameInfo.Strings;
    Raids = raids;
    RaidParameters param = raids[idx];
    seedBox.Text = $"{param.Seed:X16}";
    denBox.SelectedIndex = idx;
    natureBox.Items.Clear();
    natureBox.Items.Add("Any");
    natureBox.Items.AddRange(gameStrings.natures);
    for (int i = 0; i < gameStrings.natures.Length; i++) {
      natureIdx[gameStrings.natures[i]] = i + 1;
    }
    natureBox.MaxDropDownItems = gameStrings.natures.Length;
    natureBox.DefaultValue = "Any";
    natureBox.DisplayMember = "Value";
    natureBox.SetItemChecked(0, true);
    natureBox.DropDownClosed += (sender, e) => Focus();
    shinyBox.SelectedIndex = 0;
    CenterToParent();
  }

  private static ulong Advance(ulong start, uint frames) {
    return start + (frames * Xoroshiro128Plus.XOROSHIRO_CONST);
  }

  private void DenBox_SelectedIndexChanged(object sender, EventArgs e) {
    RaidParameters raidParameters = Raids[denBox.SelectedIndex];
    seedBox.Text = raidParameters.Seed.ToString("X");
    speciesList.Items.Clear();
    GameStrings s = GameInfo.Strings;;
    if (raidParameters.IsCrystal) {
      IEnumerable<RaidTemplate> entries = Raids.GetAllTemplatesWithStarCount(raidParameters, 0);
      foreach (RaidTemplate entry in entries) {
        ComboboxItem item = new ComboboxItem($"{entry.MinRank + 1}\u2605 {s.Species[entry.Species]}", entry);
        speciesList.Items.Add(item);
      }
    } else {
      for (int stars = min_stars[Raids.BadgeCount]; stars <= max_stars[Raids.BadgeCount]; stars++) {
        IEnumerable<RaidTemplate> entries = Raids.GetAllTemplatesWithStarCount(raidParameters, stars);
        foreach (RaidTemplate entry in entries) {
          ComboboxItem item = new ComboboxItem($"{stars + 1}\u2605 {s.Species[entry.Species]}", entry);
          speciesList.Items.Add(item);
        }
      }
    }
    speciesList.SelectedIndex = 0;
  }

  private void GenerateData_Click(object sender, EventArgs e) {
    ulong start_seed = ulong.Parse(seedBox.Text, System.Globalization.NumberStyles.HexNumber);
    if (!uint.TryParse(startFrame.Text, out uint start_frame)) {
      start_frame = uint.MaxValue;
    }
    startFrame.Text = start_frame.ToString();
    if (!uint.TryParse(endFrame.Text, out uint end_frame)) {
      end_frame = uint.MaxValue;
    }
    endFrame.Text = end_frame.ToString();
    ulong current_seed = Advance(start_seed, start_frame);
    GameStrings s = GameInfo.Strings;
    RaidTemplate pkmn = (RaidTemplate)((ComboboxItem)speciesList.SelectedItem).Value;
    raidContent.Rows.Clear();
    List<DataGridViewRow> rows = new List<DataGridViewRow>();
    ((ISupportInitialize)raidContent).BeginInit();
    for (uint current_frame = start_frame; current_frame <= start_frame + end_frame; current_frame++, current_seed += Xoroshiro128Plus.XOROSHIRO_CONST) {
      RaidPKM res = pkmn.ConvertToPKM(current_seed, Raids.TID, Raids.SID);
      DataGridViewRow row = CreateRaidRow(current_frame, res, s, current_seed);
      rows.Add(row);
    }
    raidContent.Rows.AddRange(rows.ToArray());
    // Double buffering can make DGV slow in remote desktop
    if (!SystemInformation.TerminalServerSession)
      raidContent.DoubleBuffered(true);
    ((ISupportInitialize)raidContent).EndInit();
    //raidContent
  }

  private void ApplyFilter_Click(object sender, EventArgs e) {
    DataGridViewRow[] rows = new DataGridViewRow[raidContent.Rows.Count];
    raidContent.Rows.CopyTo(rows, 0);
    raidContent.Rows.Clear();
    foreach (DataGridViewRow row in rows)
      row.Visible = GetIsRowVisible(row);
    raidContent.Rows.AddRange(rows);
  }

  private bool IsRowVisible(RaidPKM res) {
    if (res.IVs[0] < minHP.Value || res.IVs[0] > maxHP.Value)
      return false;
    if (res.IVs[1] < minAtk.Value || res.IVs[1] > maxAtk.Value)
      return false;
    if (res.IVs[2] < minDef.Value || res.IVs[2] > maxDef.Value)
      return false;
    if (res.IVs[3] < minSpa.Value || res.IVs[3] > maxSpa.Value)
      return false;
    if (res.IVs[4] < minSpd.Value || res.IVs[4] > maxSpd.Value)
      return false;
    if (res.IVs[5] < MinSpe.Value || res.IVs[5] > maxSpe.Value)
      return false;
    if (!natureBox.GetItemChecked(0) && !natureBox.GetItemChecked(res.Nature + 1))
      return false;
    if (abilityBox.SelectedIndex != 0 && (int)((ComboboxItem)abilityBox.SelectedItem).Value != res.Ability)
      return false;
    if (genderBox.SelectedIndex != 0 && (int)((ComboboxItem)genderBox.SelectedItem).Value != res.Gender)
      return false;

    return (shinyBox.SelectedIndex == 1 && res.ShinyType > 0) || shinyBox.SelectedIndex - 2 == res.ShinyType || shinyBox.SelectedIndex == 0;
  }

  private bool GetIsRowVisible(DataGridViewRow row) {
    int hp = int.Parse((string)row.Cells[1].Value);
    if (hp < minHP.Value || hp > maxHP.Value)
      return false;

    int atk = int.Parse((string)row.Cells[2].Value);
    if (atk < minAtk.Value || atk > maxAtk.Value)
      return false;

    int def = int.Parse((string)row.Cells[3].Value);
    if (def < minDef.Value || def > maxDef.Value)
      return false;

    int spa = int.Parse((string)row.Cells[4].Value);
    if (spa < minSpa.Value || spa > maxSpa.Value)
      return false;

    int spd = int.Parse((string)row.Cells[5].Value);
    if (spd < minSpd.Value || spd > maxSpd.Value)
      return false;

    int spe = int.Parse((string)row.Cells[6].Value);
    if (spe < MinSpe.Value || spe > maxSpe.Value)
      return false;

    if (!natureBox.GetItemChecked(0) && !natureBox.GetItemChecked(natureIdx[(string)row.Cells[7].Value]))
      return false;

    if (abilityBox.SelectedIndex != 0 && !abilityBox.Text.StartsWith((string)row.Cells[8].Value))
      return false;

    if (genderBox.SelectedIndex != 0 && genderBox.Text != (string)row.Cells[9].Value)
      return false;

    string shiny = (string)row.Cells[10].Value;
    return (shinyBox.SelectedIndex == 1 && shiny != "No") || shinyBox.Text == shiny || shinyBox.SelectedIndex == 0;
  }

  private void SpeciesList_SelectedIndexChanged(object sender, EventArgs e) {
    RaidTemplate pkm = (RaidTemplate)((ComboboxItem)speciesList.SelectedItem).Value;
    PersonalInfo8SWSH abilities = PersonalTable.SWSH.GetFormEntry(pkm.Species, pkm.AltForm);
    PopulateAbilityList(abilities, pkm.Ability);
    PopulateGenderList(PersonalTable.SWSH[pkm.Species].Gender);

    abilityBox.SelectedIndex = 0;
    genderBox.SelectedIndex = 0;
  }

  private static readonly string[] AbilitySuffix = { " (1)", " (2)", " (H)" };

  private void PopulateAbilityList(IPersonalAbility12H abilities, int a) {
    abilityBox.Items.Clear();
    abilityBox.Items.Add("Any");
    GameStrings s = GameInfo.Strings;
    for (int i = 0; i < abilities.AbilityCount; i++) {
      int ability = abilities.GetAbilityAtIndex(i);
      if (a == 3 && abilityBox.Items.Count == 3)
        break;

      string name = s.Ability[ability] + AbilitySuffix[i];
      ComboboxItem ab = new ComboboxItem(name, ability);
      abilityBox.Items.Add(ab);
    }
  }

  private void PopulateGenderList(int gt) {
    genderBox.Items.Clear();
    switch (gt) {
      case 255:
        genderBox.Items.Add(genderless); // Genderless
        break;
      case 254:
        genderBox.Items.Add(female); // Female-Only
        break;
      case 0:
        genderBox.Items.Add(male); // Male-Only
        break;
      default:
        genderBox.Items.Add(any);
        genderBox.Items.Add(female);
        genderBox.Items.Add(male);
        break;
    }
  }

  private void SeedBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !Util.IsHexOrControl(e.KeyChar);
  private void IsNumberPressed(object sender, KeyPressEventArgs e) => e.Handled = !Util.IsDigitOrControl(e.KeyChar);

  private void ResetFilter_Click(object sender, EventArgs e) {
    DataGridViewRow[] rows = new DataGridViewRow[raidContent.Rows.Count];
    raidContent.Rows.CopyTo(rows, 0);
    raidContent.Rows.Clear();
    foreach (DataGridViewRow row in rows)
      row.Visible = true;
    raidContent.Rows.AddRange(rows);
  }

  private async void SearchButton_Click(object sender, EventArgs e) {
    if (searchButton.Text == "Stop") {
      cts.Cancel();
      searchButton.Text = "Search";
      return;
    }
    DialogResult result = WinFormsUtil.Prompt(MessageBoxButtons.YesNo, "This might take a long time. Are you sure you want to start the search?");
    if (result != DialogResult.Yes)
      return;

    ulong start_seed = ulong.Parse(seedBox.Text, System.Globalization.NumberStyles.HexNumber);
    if (!uint.TryParse(startFrame.Text, out uint start_frame)) {
      start_frame = uint.MaxValue;
    }
    startFrame.Text = start_frame.ToString();
    // uint end_frame = uint.Parse(endFrame.Text);
    raidContent.Rows.Clear();
    searchButton.Text = "Stop";
    cts = new CancellationTokenSource();
    try {
      var row = await SearchTask(start_seed, start_frame, cts.Token);
      //((ISupportInitialize)raidContent).BeginInit();
      raidContent.Rows.Add(row);
      searchButton.Text = "Search";
      //((ISupportInitialize)raidContent).EndInit();
    } catch (OperationCanceledException) {
      WinFormsUtil.Alert("Stop Search!");
    }
  }

  private async Task<DataGridViewRow> SearchTask(ulong start_seed, uint start_frame, CancellationToken cancelToken) {
    ulong current_seed = Advance(start_seed, start_frame);
    RaidTemplate template = (RaidTemplate)((ComboboxItem)speciesList.SelectedItem).Value;
    GameStrings s = GameInfo.Strings;;
    return await Task.Run(() => {
      for (uint current_frame = start_frame; ; current_frame++, current_seed += Xoroshiro128Plus.XOROSHIRO_CONST) {
        cancelToken.ThrowIfCancellationRequested();
        RaidPKM pkm = template.ConvertToPKM(current_seed, Raids.TID, Raids.SID);
        if (!IsRowVisible(pkm))
          continue;
        return CreateRaidRow(current_frame, pkm, s, current_seed);
      }
    }, cancelToken);
  }

  private DataGridViewRow CreateRaidRow(uint current_frame, RaidPKM res, GameStrings s, ulong current_seed) {
    DataGridViewRow row = new DataGridViewRow();
    row.CreateCells(raidContent);
    row.Cells[0].Value = current_frame.ToString();
    row.Cells[1].Value = $"{res.IVs[0]:00}";
    row.Cells[2].Value = $"{res.IVs[1]:00}";
    row.Cells[3].Value = $"{res.IVs[2]:00}";
    row.Cells[4].Value = $"{res.IVs[3]:00}";
    row.Cells[5].Value = $"{res.IVs[4]:00}";
    row.Cells[6].Value = $"{res.IVs[5]:00}";
    row.Cells[7].Value = s.Natures[res.Nature];
    row.Cells[8].Value = s.Ability[res.Ability];
    row.Cells[9].Value = genders[res.Gender];
    row.Cells[10].Value = shinytype[res.ShinyType];
    row.Cells[11].Value = $"{current_seed:X16}";
    return row;
  }
}
