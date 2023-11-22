using PKHeX.Core;
using System.Reflection;
using System.Resources;

namespace PluginPile.Unmaintained.BWTool;

public partial class JoinAvenueForm : Form {

  private readonly SAV5B2W2 SAV;
  private readonly JoinAvenue ja;
  private readonly ResourceManager resources = new ResourceManager("PluginPile.Unmaintained.BWTool.JoinAvenueForm", Assembly.GetExecutingAssembly());
  private Rectangle cloneRect;

  private int helper_value = 0;

  public JoinAvenueForm(SAV5B2W2 sav) {
    InitializeComponent();

    SAV = sav;
    ja = new JoinAvenue(SAV.GetBlock(Constants.B2W2.JoinAvenue));
    load_data();
  }

  void load_npc() {
    npc_name.Text = ja.npc[(int)npc.Value].name;
    npc_gender.SelectedIndex = ja.npc[(int)npc.Value].gender;
    npc_text1.Text = ja.npc[(int)npc.Value].text1;
    npc_text1.Text = ja.npc[(int)npc.Value].text2;
    npc_spoken.Checked = ja.npc[(int)npc.Value].spoken;
  }

  void set_npc() {
    ja.npc[(int)npc.Value].name = npc_name.Text;
    ja.npc[(int)npc.Value].gender = npc_gender.SelectedIndex;
    ja.npc[(int)npc.Value].text1 = npc_text1.Text;
    ja.npc[(int)npc.Value].text2 = npc_text1.Text;
    ja.npc[(int)npc.Value].spoken = npc_spoken.Checked;
  }

  void Npc_applyClick(object sender, EventArgs e) {
    set_npc();
  }

  void NpcValueChanged(object sender, EventArgs e) {
    load_npc();
  }

  void load_data() {
    rank.Value = ja.rank;
    color.SelectedIndex = ja.color;
    favorite.Text = ja.fav_phrase;
    Impressed.Text = ja.imp_phrase;
    title.Text = ja.title;
    name.Text = ja.name;

    load_shop();
    load_visitor();
    load_npc();
    load_helper();

    shop.Value = 0;
    visitor.Value = 0;
    npc.Value = 0;
    helper.SelectedIndex = 0;
  }

  void set_data() {
    ja.rank = (ushort)rank.Value;
    ja.color = color.SelectedIndex;
    ja.fav_phrase = favorite.Text;
    ja.imp_phrase = Impressed.Text;
    ja.title = title.Text;
    ja.name = name.Text;

    ja.set_people();
  }
  void Exit_butClick(object sender, EventArgs e) => Close();

  void Saveexit_butClick(object sender, EventArgs e) {
    set_data();
    SAV.SetBlock(ja.Data, Constants.B2W2.JoinAvenue);
    Close();
  }

  void Helper_countrySelectedIndexChanged(object sender, EventArgs e) {
    helper_subregion.SelectedIndex = 0;
    helper_subregion.Items.Clear();
    object[] a;
    switch (helper_country.SelectedIndex) {
      case 9:
        a = new object[helper_subregion_argentina.Items.Count];
        helper_subregion_argentina.Items.CopyTo(a, 0);
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
  void load_helper() {
    helper_name.Text = ja.helper[helper_value].name;
    helper_met.Text = ja.helper[helper_value].text0;
    helper_greet1.Text = ja.helper[helper_value].text1;
    helper_greet2.Text = ja.helper[helper_value].text2;
    helper_sprite.Value = ja.helper[helper_value].sprite;
    helper_country.SelectedIndex = ja.helper[helper_value].country;
    helper_subregion.SelectedIndex = ja.helper[helper_value].subregion;
    helper_date.Value = ja.helper[helper_value].met;
  }

  void set_helper() {
    ja.helper[helper_value].name = helper_name.Text;
    ja.helper[helper_value].text0 = helper_met.Text;
    ja.helper[helper_value].text1 = helper_greet1.Text;
    ja.helper[helper_value].text2 = helper_greet2.Text;
    ja.helper[helper_value].sprite = (int)helper_sprite.Value;
    ja.helper[helper_value].country = helper_country.SelectedIndex;
    ja.helper[helper_value].subregion = helper_subregion.SelectedIndex;
    ja.helper[helper_value].met = helper_date.Value;
  }

  void Helper_applyClick(object sender, EventArgs e) {
    set_helper();
    load_helper();
  }


  void HelperSelectedIndexChanged(object sender, EventArgs e) {
    helper_value = helper.SelectedIndex;
    load_helper();
  }

  //SHOP
  void Shop_countrySelectedIndexChanged(object sender, EventArgs e) {
    shop_handleCountry();
  }

  void shop_handleCountry() {
    shop_subregion.SelectedIndex = 0;
    shop_subregion.Items.Clear();
    object[] a;
    switch (shop_country.SelectedIndex) {
      case 9:
        a = new object[helper_subregion_argentina.Items.Count];
        helper_subregion_argentina.Items.CopyTo(a, 0);
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

  void load_shop() {
    shop_name.Text = ja.shop[(int)shop.Value].name;
    shop_shout.Text = ja.shop[(int)shop.Value].shout;
    shop_greeting.Text = ja.shop[(int)shop.Value].greeting;
    shop_farewell.Text = ja.shop[(int)shop.Value].farewell;
    shop_gender.SelectedIndex = ja.shop[(int)shop.Value].gender;

    shop_country.SelectedIndex = ja.shop[(int)shop.Value].country;
    shop_handleCountry();;
    for (int i = 0; i < country_subbed.Length; i++) {
      if (ja.shop[(int)shop.Value].country == country_subbed[i])
        shop_subregion.SelectedIndex = ja.shop[(int)shop.Value].subregion;
    }
    shop_subregion.SelectedIndex = ja.shop[(int)shop.Value].subregion;
    shop_sprite.Value = ja.shop[(int)shop.Value].sprite;

    load_shop_sprite();

    shop_date.Value = ja.shop[(int)shop.Value].met;
    shop_recruit.Value = ja.shop[(int)shop.Value].recruitlvl;

    shop_type.SelectedIndex = ja.shop[(int)shop.Value].shop_version;
    shop_rank.SelectedIndex = ja.shop[(int)shop.Value].shop_level;
    shop_store.SelectedIndex = ja.shop[(int)shop.Value].shop_type;
    shop_exp.Value = ja.shop[(int)shop.Value].shop_exp;
    shop_ishuman.Checked = ja.shop[(int)shop.Value].isplayer;
    shop_inventory.Checked = ja.shop[(int)shop.Value].inventory;

    shop_debug.Text = ja.shop[(int)shop.Value].ShopBytes().ToString("X");

  }
  void set_shop() {
    ja.shop[(int)shop.Value].name = shop_name.Text;
    ja.shop[(int)shop.Value].shout = shop_shout.Text;
    ja.shop[(int)shop.Value].greeting = shop_greeting.Text;
    ja.shop[(int)shop.Value].farewell = shop_farewell.Text;
    ja.shop[(int)shop.Value].gender = shop_gender.SelectedIndex;


    ja.shop[(int)shop.Value].country = shop_country.SelectedIndex;
    ja.shop[(int)shop.Value].subregion = shop_subregion.SelectedIndex;
    ja.shop[(int)shop.Value].sprite = (int)shop_sprite.Value;
    ja.shop[(int)shop.Value].met = shop_date.Value;
    ja.shop[(int)shop.Value].recruitlvl = (int)shop_recruit.Value;

    ja.shop[(int)shop.Value].shop_version = shop_type.SelectedIndex;
    ja.shop[(int)shop.Value].shop_level = shop_rank.SelectedIndex;
    ja.shop[(int)shop.Value].shop_type = shop_store.SelectedIndex;
    ja.shop[(int)shop.Value].shop_exp = (int)shop_exp.Value;
    ja.shop[(int)shop.Value].isplayer = shop_ishuman.Checked;
    ja.shop[(int)shop.Value].inventory = shop_inventory.Checked;

    ja.shop[(int)shop.Value].set_ShopBytes();
  }
  void Shop_applyClick(object sender, EventArgs e) {
    set_shop();
  }

  void ShopValueChanged(object sender, EventArgs e) {
    load_shop();
  }
  void load_shop_sprite() {
    // Create a Bitmap object from a file.
    Bitmap sprites_data = (Bitmap)resources.GetObject("sprites")!;
    if (((int)shop_sprite.Value) < 32) {
      cloneRect = new Rectangle((int)((shop_sprite.Value) * 32), 0, 32, 32);
    } else if (((int)shop_sprite.Value) < 64) {
      cloneRect = new Rectangle((int)((shop_sprite.Value - 32) * 32), 32, 32, 32);
    } else if (((int)shop_sprite.Value) < 96) {
      cloneRect = new Rectangle((int)((shop_sprite.Value - 64) * 32), 64, 32, 32);
    } else if (((int)shop_sprite.Value) < 128) {
      cloneRect = new Rectangle((int)((shop_sprite.Value - 96) * 32), 96, 32, 32);
    } else if (((int)shop_sprite.Value) < 160) {
      cloneRect = new Rectangle((int)((shop_sprite.Value - 128) * 32), 128, 32, 32);
    } else if (((int)shop_sprite.Value) < 192) {
      cloneRect = new Rectangle((int)((shop_sprite.Value - 160) * 32), 160, 32, 32);
    } else if (((int)shop_sprite.Value) < 224) {
      cloneRect = new Rectangle((int)((shop_sprite.Value - 192) * 32), 192, 32, 32);
    } else if (((int)shop_sprite.Value) < 256) {
      cloneRect = new Rectangle((int)((shop_sprite.Value - 224) * 32), 224, 32, 32);
    }
    shop_pic.Image = sprites_data.Clone(cloneRect, sprites_data.PixelFormat);
  }
  void Shop_spriteValueChanged(object sender, EventArgs e) {
    load_shop_sprite();
  }

  //VISITOR
  void Visitor_countrySelectedIndexChanged(object sender, EventArgs e) {
    visitor_handleCountry();
  }
  void visitor_handleCountry() {

    visitor_subregion.SelectedIndex = 0;
    visitor_subregion.Items.Clear();
    object[] a;
    switch (visitor_country.SelectedIndex) {
      case 9:
        a = new object[helper_subregion_argentina.Items.Count];
        helper_subregion_argentina.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 12:
        a = new object[helper_subregion_australia.Items.Count];
        helper_subregion_australia.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 28:
        a = new object[helper_subregion_brazil.Items.Count];
        helper_subregion_brazil.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 36:
        a = new object[helper_subregion_canada.Items.Count];
        helper_subregion_canada.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 43:
        a = new object[helper_subregion_china.Items.Count];
        helper_subregion_china.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 72:
        a = new object[helper_subregion_finland.Items.Count];
        helper_subregion_finland.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 73:
        a = new object[helper_subregion_france.Items.Count];
        helper_subregion_france.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 79:
        a = new object[helper_subregion_germany.Items.Count];
        helper_subregion_germany.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 95:
        a = new object[helper_subregion_india.Items.Count];
        helper_subregion_india.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 102:
        a = new object[helper_subregion_italy.Items.Count];
        helper_subregion_italy.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 105:
        a = new object[helper_subregion_japan.Items.Count];
        helper_subregion_japan.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 155:
        a = new object[helper_subregion_norway.Items.Count];
        helper_subregion_norway.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 166:
        a = new object[helper_subregion_poland.Items.Count];
        helper_subregion_poland.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 174:
        a = new object[helper_subregion_russia.Items.Count];
        helper_subregion_russia.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 195:
        a = new object[helper_subregion_spain.Items.Count];
        helper_subregion_spain.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 200:
        a = new object[helper_subregion_sweeden.Items.Count];
        helper_subregion_sweeden.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 218:
        a = new object[helper_subregion_england.Items.Count];
        helper_subregion_england.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      case 220:
        a = new object[helper_subregion_USA.Items.Count];
        helper_subregion_USA.Items.CopyTo(a, 0);
        visitor_subregion.Items.AddRange(a);
        break;
      default:
        visitor_subregion.Items.Add("0 None");
        break;
    }
  }

  int[] country_subbed = new int[] {
    009, 012, 028, 036, 043, 072, 073, 079, 095, 102,
    105, 155, 166, 174, 195, 200, 218, 220
  };

  void load_visitor() {
    visitor_name.Text = ja.visitor[(int)visitor.Value].name;
    visitor_shout.Text = ja.visitor[(int)visitor.Value].shout;
    visitor_greeting.Text = ja.visitor[(int)visitor.Value].greeting;
    visitor_farewell.Text = ja.visitor[(int)visitor.Value].farewell;
    visitor_gender.SelectedIndex = ja.visitor[(int)visitor.Value].gender;

    visitor_country.SelectedIndex = ja.visitor[(int)visitor.Value].country;
    visitor_handleCountry();;
    for (int i = 0; i < country_subbed.Length; i++) {
      if (ja.visitor[(int)visitor.Value].country == country_subbed[i]) {
        visitor_subregion.SelectedIndex = ja.visitor[(int)visitor.Value].subregion;
        break;
      }
    }
    visitor_sprite.Value = ja.visitor[(int)visitor.Value].sprite;
    load_visitor_sprite();

    visitor_date.Value = ja.visitor[(int)visitor.Value].met;
    visitor_recruit.Value = ja.visitor[(int)visitor.Value].recruitlvl;

    visitor_ishuman.Checked = ja.visitor[(int)visitor.Value].isplayer;
  }

  void set_visitor() {
    ja.visitor[(int)visitor.Value].name = visitor_name.Text;
    ja.visitor[(int)visitor.Value].shout = visitor_shout.Text;
    ja.visitor[(int)visitor.Value].greeting = visitor_greeting.Text;
    ja.visitor[(int)visitor.Value].farewell = visitor_farewell.Text;
    ja.visitor[(int)visitor.Value].gender = visitor_gender.SelectedIndex;


    ja.visitor[(int)visitor.Value].country = visitor_country.SelectedIndex;
    ja.visitor[(int)visitor.Value].subregion = visitor_subregion.SelectedIndex;
    ja.visitor[(int)visitor.Value].sprite = (int)visitor_sprite.Value;
    ja.visitor[(int)visitor.Value].met = visitor_date.Value;
    ja.visitor[(int)visitor.Value].recruitlvl = (int)visitor_recruit.Value;

    ja.visitor[(int)visitor.Value].isplayer = visitor_ishuman.Checked;
  }

  void Visitor_applyClick(object sender, EventArgs e) {
    set_visitor();
  }

  void VisitorValueChanged(object sender, EventArgs e) {
    load_visitor();
  }

  void Visitor_importClick(object sender, EventArgs e) {
    JoinAvenueOccupant import = new JoinAvenueOccupant();
    string? path = null;
    int filesize = FileIO.LoadFile(ref import.Data!, ref path, "Poke JoinAvenue Visitor|*.pjv|All Files (*.*)|*.*");
    if (filesize == 0xC4) {
      ja.set_visitor(import, (int)visitor.Value);
      ja.load_people();
      load_visitor();
    } else if (filesize != -1) {
      MessageBox.Show("Invalid file.");
    }
  }
  void Visitor_exportClick(object sender, EventArgs e) {
    FileIO.SaveFile(ja.visitor[(int)visitor.Value].Data, "Poke JoinAvenue Visitor|*.pjv|All Files (*.*)|*.*");
  }

  void load_visitor_sprite() {
    // Create a Bitmap object from a file.
    Bitmap sprites_data = (Bitmap)resources.GetObject("sprites")!;
    if (((int)visitor_sprite.Value) < 32) {
      cloneRect = new Rectangle((int)((visitor_sprite.Value) * 32), 0, 32, 32);
    } else if (((int)visitor_sprite.Value) < 64) {
      cloneRect = new Rectangle((int)((visitor_sprite.Value - 32) * 32), 32, 32, 32);
    } else if (((int)visitor_sprite.Value) < 96) {
      cloneRect = new Rectangle((int)((visitor_sprite.Value - 64) * 32), 64, 32, 32);
    } else if (((int)visitor_sprite.Value) < 128) {
      cloneRect = new Rectangle((int)((visitor_sprite.Value - 96) * 32), 96, 32, 32);
    } else if (((int)visitor_sprite.Value) < 160) {
      cloneRect = new Rectangle((int)((visitor_sprite.Value - 128) * 32), 128, 32, 32);
    } else if (((int)visitor_sprite.Value) < 192) {
      cloneRect = new Rectangle((int)((visitor_sprite.Value - 160) * 32), 160, 32, 32);
    } else if (((int)visitor_sprite.Value) < 224) {
      cloneRect = new Rectangle((int)((visitor_sprite.Value - 192) * 32), 192, 32, 32);
    } else if (((int)visitor_sprite.Value) < 256) {
      cloneRect = new Rectangle((int)((visitor_sprite.Value - 224) * 32), 224, 32, 32);
    }
    visitor_pic.Image = sprites_data.Clone(cloneRect, sprites_data.PixelFormat);
  }

}
