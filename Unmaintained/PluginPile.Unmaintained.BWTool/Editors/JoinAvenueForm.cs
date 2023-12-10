using PKHeX.Core;
using System.Reflection;
using System.Resources;

namespace PluginPile.Unmaintained.BWTool;

public partial class JoinAvenueForm : Form {

  private readonly SAV5B2W2 SAV;
  private readonly JoinAvenue JA;
  private readonly ResourceManager resources = new ResourceManager("PluginPile.Unmaintained.BWTool.JoinAvenueForm", Assembly.GetExecutingAssembly());
  private Rectangle CloneRect;

  private int helper_value = 0;

  public JoinAvenueForm(SAV5B2W2 sav) {
    InitializeComponent();
    SAV = sav;
    JA = new JoinAvenue(SAV.GetBlock(Constants.B2W2.JoinAvenue));
    LoadData();
  }

  void LoadNPC() {
    npc_name.Text = JA.npc[(int)npc.Value].Name;
    npc_gender.SelectedIndex = JA.npc[(int)npc.Value].Gender;
    npc_text1.Text = JA.npc[(int)npc.Value].Text1;
    npc_text1.Text = JA.npc[(int)npc.Value].Text2;
    npc_spoken.Checked = JA.npc[(int)npc.Value].Spoken;
  }

  void SetNPC() {
    JA.npc[(int)npc.Value].Name = npc_name.Text;
    JA.npc[(int)npc.Value].Gender = npc_gender.SelectedIndex;
    JA.npc[(int)npc.Value].Text1 = npc_text1.Text;
    JA.npc[(int)npc.Value].Text2 = npc_text1.Text;
    JA.npc[(int)npc.Value].Spoken = npc_spoken.Checked;
  }

  void Npc_applyClick(object sender, EventArgs e) {
    SetNPC();
  }

  void NpcValueChanged(object sender, EventArgs e) {
    LoadNPC();
  }

  void LoadData() {
    rank.Value = JA.Rank;
    color.SelectedIndex = JA.Color;
    favorite.Text = JA.FavPhrase;
    Impressed.Text = JA.ImpPhrase;
    title.Text = JA.Title;
    name.Text = JA.Name;

    LoadShop();
    LoadVisitor();
    LoadNPC();
    LoadHelper();

    shop.Value = 0;
    visitor.Value = 0;
    npc.Value = 0;
    helper.SelectedIndex = 0;
  }

  void SetData() {
    JA.Rank = (ushort)rank.Value;
    JA.Color = color.SelectedIndex;
    JA.FavPhrase = favorite.Text;
    JA.ImpPhrase = Impressed.Text;
    JA.Title = title.Text;
    JA.Name = name.Text;

    JA.SetPeople();
  }
  void Exit_butClick(object sender, EventArgs e) => Close();

  void Saveexit_butClick(object sender, EventArgs e) {
    SetData();
    SAV.SetBlock(JA.Data, Constants.B2W2.JoinAvenue);
    Close();
  }

  void Helper_countrySelectedIndexChanged(object sender, EventArgs e) {
    helper_subregion.SelectedIndex = 0;
    helper_subregion.Items.Clear();
    object[] a;
    switch (helper_country.SelectedIndex) {
      case 9:
        a = new object[HelperSubregion_argentina.Items.Count];
        HelperSubregion_argentina.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 12:
        a = new object[helper_subregion_australia.Items.Count];
        helper_subregion_australia.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 28:
        a = new object[helper_subregion_brazil.Items.Count];
        helper_subregion_brazil.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 36:
        a = new object[helper_subregion_canada.Items.Count];
        helper_subregion_canada.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 43:
        a = new object[helper_subregion_china.Items.Count];
        helper_subregion_china.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 72:
        a = new object[helper_subregion_finland.Items.Count];
        helper_subregion_finland.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 73:
        a = new object[helper_subregion_france.Items.Count];
        helper_subregion_france.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 79:
        a = new object[helper_subregion_germany.Items.Count];
        helper_subregion_germany.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 95:
        a = new object[helper_subregion_india.Items.Count];
        helper_subregion_india.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 102:
        a = new object[helper_subregion_italy.Items.Count];
        helper_subregion_italy.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 105:
        a = new object[helper_subregion_japan.Items.Count];
        helper_subregion_japan.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 155:
        a = new object[helper_subregion_norway.Items.Count];
        helper_subregion_norway.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 166:
        a = new object[helper_subregion_poland.Items.Count];
        helper_subregion_poland.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 174:
        a = new object[helper_subregion_russia.Items.Count];
        helper_subregion_russia.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 195:
        a = new object[helper_subregion_spain.Items.Count];
        helper_subregion_spain.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 200:
        a = new object[helper_subregion_sweeden.Items.Count];
        helper_subregion_sweeden.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 218:
        a = new object[helper_subregion_england.Items.Count];
        helper_subregion_england.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      case 220:
        a = new object[helper_subregion_USA.Items.Count];
        helper_subregion_USA.Items.CopyTo(a, 0);
        helper_subregion.Items.AddRange(a);
        break;
      default:
        helper_subregion.Items.Add("0 None");
        break;
    }
  }
  void LoadHelper() {
    helper_name.Text = JA.helper[helper_value].Name;
    helper_met.Text = JA.helper[helper_value].Text0;
    helper_greet1.Text = JA.helper[helper_value].Text1;
    helper_greet2.Text = JA.helper[helper_value].Text2;
    helper_sprite.Value = JA.helper[helper_value].Sprite;
    helper_country.SelectedIndex = JA.helper[helper_value].Country;
    helper_subregion.SelectedIndex = JA.helper[helper_value].Subregion;
    helper_date.Value = JA.helper[helper_value].Met;
  }

  void SetHelper() {
    JA.helper[helper_value].Name = helper_name.Text;
    JA.helper[helper_value].Text0 = helper_met.Text;
    JA.helper[helper_value].Text1 = helper_greet1.Text;
    JA.helper[helper_value].Text2 = helper_greet2.Text;
    JA.helper[helper_value].Sprite = (int)helper_sprite.Value;
    JA.helper[helper_value].Country = helper_country.SelectedIndex;
    JA.helper[helper_value].Subregion = helper_subregion.SelectedIndex;
    JA.helper[helper_value].Met = helper_date.Value;
  }

  void Helper_applyClick(object sender, EventArgs e) {
    SetHelper();
    LoadHelper();
  }


  void HelperSelectedIndexChanged(object sender, EventArgs e) {
    helper_value = helper.SelectedIndex;
    LoadHelper();
  }

  //SHOP
  void Shop_countrySelectedIndexChanged(object sender, EventArgs e) {
    ShopHandleCountry();
  }

  void ShopHandleCountry() {
    shop_subregion.SelectedIndex = 0;
    shop_subregion.Items.Clear();
    object[] a;
    switch (shop_country.SelectedIndex) {
      case 9:
        a = new object[HelperSubregion_argentina.Items.Count];
        HelperSubregion_argentina.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 12:
        a = new object[helper_subregion_australia.Items.Count];
        helper_subregion_australia.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 28:
        a = new object[helper_subregion_brazil.Items.Count];
        helper_subregion_brazil.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 36:
        a = new object[helper_subregion_canada.Items.Count];
        helper_subregion_canada.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 43:
        a = new object[helper_subregion_china.Items.Count];
        helper_subregion_china.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 72:
        a = new object[helper_subregion_finland.Items.Count];
        helper_subregion_finland.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 73:
        a = new object[helper_subregion_france.Items.Count];
        helper_subregion_france.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 79:
        a = new object[helper_subregion_germany.Items.Count];
        helper_subregion_germany.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 95:
        a = new object[helper_subregion_india.Items.Count];
        helper_subregion_india.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 102:
        a = new object[helper_subregion_italy.Items.Count];
        helper_subregion_italy.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 105:
        a = new object[helper_subregion_japan.Items.Count];
        helper_subregion_japan.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 155:
        a = new object[helper_subregion_norway.Items.Count];
        helper_subregion_norway.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 166:
        a = new object[helper_subregion_poland.Items.Count];
        helper_subregion_poland.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 174:
        a = new object[helper_subregion_russia.Items.Count];
        helper_subregion_russia.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 195:
        a = new object[helper_subregion_spain.Items.Count];
        helper_subregion_spain.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 200:
        a = new object[helper_subregion_sweeden.Items.Count];
        helper_subregion_sweeden.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 218:
        a = new object[helper_subregion_england.Items.Count];
        helper_subregion_england.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      case 220:
        a = new object[helper_subregion_USA.Items.Count];
        helper_subregion_USA.Items.CopyTo(a, 0);
        shop_subregion.Items.AddRange(a);
        break;
      default:
        shop_subregion.Items.Add("0 None");
        break;
    }
  }

  void LoadShop() {
    shop_name.Text = JA.shop[(int)shop.Value].Name;
    shop_shout.Text = JA.shop[(int)shop.Value].Shout;
    shop_greeting.Text = JA.shop[(int)shop.Value].Greeting;
    shop_farewell.Text = JA.shop[(int)shop.Value].Farewell;
    shop_gender.SelectedIndex = JA.shop[(int)shop.Value].Gender;

    shop_country.SelectedIndex = JA.shop[(int)shop.Value].Country;
    ShopHandleCountry();;
    for (int i = 0; i < CountrySubbed.Length; i++) {
      if (JA.shop[(int)shop.Value].Country == CountrySubbed[i])
        shop_subregion.SelectedIndex = JA.shop[(int)shop.Value].Subregion;
    }
    shop_subregion.SelectedIndex = JA.shop[(int)shop.Value].Subregion;
    shop_sprite.Value = JA.shop[(int)shop.Value].Sprite;

    LoadShopSprite();

    shop_date.Value = JA.shop[(int)shop.Value].Met;
    shop_recruit.Value = JA.shop[(int)shop.Value].RecruitLvl;

    shop_type.SelectedIndex = JA.shop[(int)shop.Value].ShopVersion;
    shop_rank.SelectedIndex = JA.shop[(int)shop.Value].ShopLevel;
    shop_store.SelectedIndex = JA.shop[(int)shop.Value].ShopType;
    shop_exp.Value = JA.shop[(int)shop.Value].ShopExp;
    shop_ishuman.Checked = JA.shop[(int)shop.Value].IsPlayer;
    shop_inventory.Checked = JA.shop[(int)shop.Value].Inventory;

    shop_debug.Text = JA.shop[(int)shop.Value].GetShopBytes().ToString("X");

  }
  void SetShop() {
    JA.shop[(int)shop.Value].Name = shop_name.Text;
    JA.shop[(int)shop.Value].Shout = shop_shout.Text;
    JA.shop[(int)shop.Value].Greeting = shop_greeting.Text;
    JA.shop[(int)shop.Value].Farewell = shop_farewell.Text;
    JA.shop[(int)shop.Value].Gender = shop_gender.SelectedIndex;


    JA.shop[(int)shop.Value].Country = shop_country.SelectedIndex;
    JA.shop[(int)shop.Value].Subregion = shop_subregion.SelectedIndex;
    JA.shop[(int)shop.Value].Sprite = (int)shop_sprite.Value;
    JA.shop[(int)shop.Value].Met = shop_date.Value;
    JA.shop[(int)shop.Value].RecruitLvl = (int)shop_recruit.Value;

    JA.shop[(int)shop.Value].ShopVersion = shop_type.SelectedIndex;
    JA.shop[(int)shop.Value].ShopLevel = shop_rank.SelectedIndex;
    JA.shop[(int)shop.Value].ShopType = shop_store.SelectedIndex;
    JA.shop[(int)shop.Value].ShopExp = (int)shop_exp.Value;
    JA.shop[(int)shop.Value].IsPlayer = shop_ishuman.Checked;
    JA.shop[(int)shop.Value].Inventory = shop_inventory.Checked;

    JA.shop[(int)shop.Value].SetShopBytes();
  }
  void Shop_applyClick(object sender, EventArgs e) {
    SetShop();
  }

  void ShopValueChanged(object sender, EventArgs e) {
    LoadShop();
  }
  void LoadShopSprite() {
    // Create a Bitmap object from a file.
    Bitmap sprites_data = (Bitmap)resources.GetObject("sprites")!;
    if (((int)shop_sprite.Value) < 32) {
      CloneRect = new Rectangle((int)((shop_sprite.Value) * 32), 0, 32, 32);
    } else if (((int)shop_sprite.Value) < 64) {
      CloneRect = new Rectangle((int)((shop_sprite.Value - 32) * 32), 32, 32, 32);
    } else if (((int)shop_sprite.Value) < 96) {
      CloneRect = new Rectangle((int)((shop_sprite.Value - 64) * 32), 64, 32, 32);
    } else if (((int)shop_sprite.Value) < 128) {
      CloneRect = new Rectangle((int)((shop_sprite.Value - 96) * 32), 96, 32, 32);
    } else if (((int)shop_sprite.Value) < 160) {
      CloneRect = new Rectangle((int)((shop_sprite.Value - 128) * 32), 128, 32, 32);
    } else if (((int)shop_sprite.Value) < 192) {
      CloneRect = new Rectangle((int)((shop_sprite.Value - 160) * 32), 160, 32, 32);
    } else if (((int)shop_sprite.Value) < 224) {
      CloneRect = new Rectangle((int)((shop_sprite.Value - 192) * 32), 192, 32, 32);
    } else if (((int)shop_sprite.Value) < 256) {
      CloneRect = new Rectangle((int)((shop_sprite.Value - 224) * 32), 224, 32, 32);
    }
    shop_pic.Image = sprites_data.Clone(CloneRect, sprites_data.PixelFormat);
  }
  void Shop_spriteValueChanged(object sender, EventArgs e) {
    LoadShopSprite();
  }

  //VISITOR
  void VisitorCountrySelectedIndexChanged(object sender, EventArgs e) {
    Visitor_HandleCountry();
  }

  void Visitor_HandleCountry() {
    VisitorSubregion.SelectedIndex = 0;
    VisitorSubregion.Items.Clear();
    object[] a;
    switch (visitor_country.SelectedIndex) {
      case 9:
        a = new object[HelperSubregion_argentina.Items.Count];
        HelperSubregion_argentina.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 12:
        a = new object[helper_subregion_australia.Items.Count];
        helper_subregion_australia.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 28:
        a = new object[helper_subregion_brazil.Items.Count];
        helper_subregion_brazil.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 36:
        a = new object[helper_subregion_canada.Items.Count];
        helper_subregion_canada.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 43:
        a = new object[helper_subregion_china.Items.Count];
        helper_subregion_china.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 72:
        a = new object[helper_subregion_finland.Items.Count];
        helper_subregion_finland.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 73:
        a = new object[helper_subregion_france.Items.Count];
        helper_subregion_france.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 79:
        a = new object[helper_subregion_germany.Items.Count];
        helper_subregion_germany.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 95:
        a = new object[helper_subregion_india.Items.Count];
        helper_subregion_india.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 102:
        a = new object[helper_subregion_italy.Items.Count];
        helper_subregion_italy.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 105:
        a = new object[helper_subregion_japan.Items.Count];
        helper_subregion_japan.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 155:
        a = new object[helper_subregion_norway.Items.Count];
        helper_subregion_norway.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 166:
        a = new object[helper_subregion_poland.Items.Count];
        helper_subregion_poland.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 174:
        a = new object[helper_subregion_russia.Items.Count];
        helper_subregion_russia.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 195:
        a = new object[helper_subregion_spain.Items.Count];
        helper_subregion_spain.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 200:
        a = new object[helper_subregion_sweeden.Items.Count];
        helper_subregion_sweeden.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 218:
        a = new object[helper_subregion_england.Items.Count];
        helper_subregion_england.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      case 220:
        a = new object[helper_subregion_USA.Items.Count];
        helper_subregion_USA.Items.CopyTo(a, 0);
        VisitorSubregion.Items.AddRange(a);
        break;
      default:
        VisitorSubregion.Items.Add("0 None");
        break;
    }
  }

  readonly int[] CountrySubbed = [
    009, 012, 028, 036, 043, 072, 073, 079, 095, 102,
    105, 155, 166, 174, 195, 200, 218, 220
  ];

  void LoadVisitor() {
    visitor_name.Text = JA.visitor[(int)visitor.Value].Name;
    visitor_shout.Text = JA.visitor[(int)visitor.Value].Shout;
    visitor_greeting.Text = JA.visitor[(int)visitor.Value].Greeting;
    visitor_farewell.Text = JA.visitor[(int)visitor.Value].Farewell;
    visitor_gender.SelectedIndex = JA.visitor[(int)visitor.Value].Gender;

    visitor_country.SelectedIndex = JA.visitor[(int)visitor.Value].Country;
    Visitor_HandleCountry();;
    for (int i = 0; i < CountrySubbed.Length; i++) {
      if (JA.visitor[(int)visitor.Value].Country == CountrySubbed[i]) {
        VisitorSubregion.SelectedIndex = JA.visitor[(int)visitor.Value].Subregion;
        break;
      }
    }
    visitor_sprite.Value = JA.visitor[(int)visitor.Value].Sprite;
    LoadVisitorSprite();

    visitor_date.Value = JA.visitor[(int)visitor.Value].Met;
    visitor_recruit.Value = JA.visitor[(int)visitor.Value].RecruitLvl;

    visitor_ishuman.Checked = JA.visitor[(int)visitor.Value].IsPlayer;
  }

  void SetVisitor() {
    JA.visitor[(int)visitor.Value].Name = visitor_name.Text;
    JA.visitor[(int)visitor.Value].Shout = visitor_shout.Text;
    JA.visitor[(int)visitor.Value].Greeting = visitor_greeting.Text;
    JA.visitor[(int)visitor.Value].Farewell = visitor_farewell.Text;
    JA.visitor[(int)visitor.Value].Gender = visitor_gender.SelectedIndex;


    JA.visitor[(int)visitor.Value].Country = visitor_country.SelectedIndex;
    JA.visitor[(int)visitor.Value].Subregion = VisitorSubregion.SelectedIndex;
    JA.visitor[(int)visitor.Value].Sprite = (int)visitor_sprite.Value;
    JA.visitor[(int)visitor.Value].Met = visitor_date.Value;
    JA.visitor[(int)visitor.Value].RecruitLvl = (int)visitor_recruit.Value;

    JA.visitor[(int)visitor.Value].IsPlayer = visitor_ishuman.Checked;
  }

  void Visitor_applyClick(object sender, EventArgs e) {
    SetVisitor();
  }

  void VisitorValueChanged(object sender, EventArgs e) {
    LoadVisitor();
  }

  void Visitor_importClick(object sender, EventArgs e) {
    JoinAvenueOccupant import = new JoinAvenueOccupant();
    string? path = null;
    int filesize = FileIO.LoadFile(ref import.Data!, ref path, "Poke JoinAvenue Visitor|*.pjv|All Files (*.*)|*.*");
    if (filesize == 0xC4) {
      JA.SetVisitor(import, (int)visitor.Value);
      JA.LoadPeople();
      LoadVisitor();
    } else if (filesize != -1) {
      MessageBox.Show("Invalid file.");
    }
  }
  void Visitor_exportClick(object sender, EventArgs e) {
    FileIO.SaveFile(JA.visitor[(int)visitor.Value].Data, "Poke JoinAvenue Visitor|*.pjv|All Files (*.*)|*.*");
  }

  void LoadVisitorSprite() {
    // Create a Bitmap object from a file.
    Bitmap sprites_data = (Bitmap)resources.GetObject("sprites")!;
    if (((int)visitor_sprite.Value) < 32) {
      CloneRect = new Rectangle((int)((visitor_sprite.Value) * 32), 0, 32, 32);
    } else if (((int)visitor_sprite.Value) < 64) {
      CloneRect = new Rectangle((int)((visitor_sprite.Value - 32) * 32), 32, 32, 32);
    } else if (((int)visitor_sprite.Value) < 96) {
      CloneRect = new Rectangle((int)((visitor_sprite.Value - 64) * 32), 64, 32, 32);
    } else if (((int)visitor_sprite.Value) < 128) {
      CloneRect = new Rectangle((int)((visitor_sprite.Value - 96) * 32), 96, 32, 32);
    } else if (((int)visitor_sprite.Value) < 160) {
      CloneRect = new Rectangle((int)((visitor_sprite.Value - 128) * 32), 128, 32, 32);
    } else if (((int)visitor_sprite.Value) < 192) {
      CloneRect = new Rectangle((int)((visitor_sprite.Value - 160) * 32), 160, 32, 32);
    } else if (((int)visitor_sprite.Value) < 224) {
      CloneRect = new Rectangle((int)((visitor_sprite.Value - 192) * 32), 192, 32, 32);
    } else if (((int)visitor_sprite.Value) < 256) {
      CloneRect = new Rectangle((int)((visitor_sprite.Value - 224) * 32), 224, 32, 32);
    }
    visitor_pic.Image = sprites_data.Clone(CloneRect, sprites_data.PixelFormat);
  }

}
