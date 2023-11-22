using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool;

public partial class EntralinkDreamWorldForm : Form {

  private readonly SAV5 SAV;
  private readonly ExtralinkForest forest;
  private readonly int world = 0;

  public EntralinkDreamWorldForm(SAV5 sav, ExtralinkForest forest, int DW, string Area) {
    InitializeComponent();
    SAV = sav;
    area_label.Text = Area;
    exclusive_label.Text = "";
    this.forest = forest;
    world = DW;
    setup_world();
    if (DW < 8) {
      moveboxA.Visible = true;
      moveboxC.Visible = true;
      atkA.Visible = true;
      atkB.Visible = true;
      atkC.Visible = true;

      Move.Text = "Move";

      pgl_region_box.Visible = false;
      region_lab.Visible = false;
      move_lab.Visible = false;
    } else if (DW == 8) {
      moveboxA.Visible = false;
      moveboxC.Visible = false;
      atkA.Visible = false;
      atkB.Visible = false;
      atkC.Visible = false;

      Move.Text = "Info";

      pgl_region_box.Visible = true;
      region_lab.Visible = true;
      move_lab.Visible = true;
    }
  }

  private void setup_world() {
    switch (world) {
      case 0://Pleasant forest
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange(new object[] {
          "Rattata",
          "Nidoran (F)            (BW*)",
          "Nidoran (M)            (BW*)",
          "Oddish",
          "Bellsprout",
          "Ponyta",
          "Farfetch'd",
          "Doduo",
          "Exeggcute",
          "Lickitung",
          "Tangela",
          "Kangaskhan",
          "Sentret",
          "Igglybuff              (BW*)",
          "Mareep",
          "Hoppip                 (BW*)",
          "Sunkern",
          "Stantler",
          "Poochyena",
          "Lotad                  (BW*)",
          "Taillow                (BW*)",
          "Surskit",
          "Bidoof",
          "Shinx",
          "Tympole                (B2W2*)",
          "Cottonee               (B2W2*)",
          "Petilil                (B2W2*)",
          "Karrablast             (B2W2*)",
          "Shelmet                (B2W2*)",
          "Glameow",
          "Scolipede              (B2W2*)",
          "Psyduck",
          "Growlithe",
          "Scyther",
          "Tauros",
          "Marill",
          "Sudowoodo",
          "Girafarig",
          "Miltank",
          "Zigzagoon",
          "Electrike              (BW*)",
          "Castform               (BW*)",
          "Pachirisu              (BW*)",
          "Buneary",
          "Vulpix",
          "Poliwag",
          "Natu",
          "Elekid",
          "Skitty"});
        speciesbox.SelectedIndex = 0;
        break;
      case 1://Windskept Sky
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange(new object[] {
          "Butterfree             (BW*)",
          "Pidgey",
          "Spearow",
          "Zubat",
          "Aerodactyl",
          "Hoothoot               (BW*)",
          "Ledyba",
          "Hoppip",
          "Yanma",
          "Murkrow",
          "Gligar",
          "Delibird",
          "Taillow",
          "Wingull                 (BW*)",
          "Swablu                  (BW*)",
          "Staravia",
          "Pidove                  (B2W2*)",
          "Sigilyph                (B2W2*)",
          "Ducklett                (B2W2*)",
          "Emolga                  (B2W2*)",
          "Skarmory",
          "Tropius",
          "Drifloon                (BW*)",
          "Chatot                  (BW*)"});
        speciesbox.SelectedIndex = 0;
        break;
      case 2:
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange(new object[] {
          "Slowpoke                (BW*)",
          "Seel",
          "Shellder",
          "Krabby                  (BW*)",
          "Horsea",
          "Goldeen",
          "Seaking                 (BW*)",
          "Staryu                  (BW*)",
          "Magikarp",
          "Omanyte",
          "Kabuto",
          "Chinchou",
          "Wooper",
          "Qwilfish",
          "Corsola                 (BW*)",
          "Remoraid",
          "Mantine",
          "Wailmer",
          "Barboach",
          "Clamperl",
          "Relicanth",
          "Luvdisc",
          "Buizel",
          "Finneon",
          "Basculin (Red Striped)  (B2W2*)",
          "Basculin (Blue Striped) (B2W2*)",
          "Alomomola               (B2W2*)",
          "Stunfisk                (B2W2*)",
          "Tirtouga                (B2W2*)",
          "Tentacool",
          "Carvanha",
          "Corphish",
          "Lileep",
          "Anorith",
          "Feebas",
          "Shellos (West Sea)      (BW*)",
          "Shellos (East Sea)      (BW*)",
          "Lapras",
          "Dratini"});
        speciesbox.SelectedIndex = 0;
        break;
      case 3: // Spooky Mannor
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange(new object[] {
          "Gastly",
          "Drowzee",
          "Mr. Mime",
          "Spinarak",
          "Misdreavus",
          "Wobbuffet               (BW*)",
          "Houndour",
          "Smoochum                (BW*)",
          "Mawile                  (BW*)",
          "Meditite                (BW*)",
          "Spoink",
          "Shuppet",
          "Duskull",
          "Chimecho",
          "Stunky",
          "Bronzor                 (BW*)",
          "Elgyem                  (B2W2*)",
          "Pawniard                (B2W2*)",
          "Galvantula              (B2W2*)",
          "Meowth                  (BW*)",
          "Snubbull",
          "Smeargle",
          "Volbeat",
          "Illumise",
          "Rotom                   (BW*)",
          "Abra",
          "Ralts                   (BW*)",
          "Sableye                 (BW*)",
          "Spiritomb               (BW*)",
          "Duosion                 (B2W2*)",
          "Golett                  (B2W2*)"});
        speciesbox.SelectedIndex = 0;
        break;
      case 4:
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange(new object[] {
          "Mankey                  (BW*)",
          "Machop",
          "Magnemite",
          "Koffing",
          "Rhyhorn                 (BW*)",
          "Slugma",
          "Phanpy                  (BW*)",
          "Larvitar",
          "Torkoal",
          "Trapinch",
          "Cacnea",
          "Burmy",
          "Hippopotas",
          "Skorupi                 (BW*)",
          "Heatmor                 (B2W2*)",
          "Durant                  (B2W2*)",
          "Maractus                (B2W2*)",
          "Crustle                 (B2W2*)",
          "Magby",
          "Teddiursa               (BW*)",
          "Makuhita                (BW*)",
          "Numel",
          "Spinda                  (BW*)",
          "Absol",
          "Beldum                  (BW*)",
          "Croagunk",
          "Tyrogue",
          "Bagon",
          "Krookodile              (B2W2*)",
          "Riolu                   (BW*)"});
        speciesbox.SelectedIndex = 0;
        break;
      case 5: //Icy cave
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange(new object[] {
          "Sandshrew",
          "Geodude",
          "Onix",
          "Voltorb",
          "Cubone",
          "Cleffa                  (BW*)",
          "Shuckle                 (BW*)",
          "Whismur",
          "Nosepass                (BW*)",
          "Aron",
          "Lunatone",
          "Solrock",
          "Baltoy",
          "Spheal                  (BW*)",
          "Cranidos                (BW*)",
          "Snover",
          "Drilbur                 (B2W2*)",
          "Druddigon               (B2W2*)",
          "Diglett",
          "Dunsparce               (BW*)",
          "Boldore                 (B2W2*)",
          "Vanillish               (B2W2*)",
          "Klang                   (B2W2*)",
          "Sneasel",
          "Snorunt",
          "Shieldon                (BW*)",
          "Swinub",
          "Gible",
          "Axew                    (B2W2*)"});
        speciesbox.SelectedIndex = 0;
        break;
      case 6: //Dream Park
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange(new object[] {
          "Paras",
          "Pineco",
          "Wurmple",
          "Seedot",
          "Slakoth",
          "Nincada",
          "Plusle",
          "Minun",
          "Gulpin",
          "Kecleon",
          "Kricketot",
          "Cherubi",
          "Carnivine",
          "Audino                  (B2W2*)",
          "Throh                   (B2W2*)",
          "Sawk                    (B2W2*)",
          "Scraggy                 (B2W2*)",
          "Venonat                 (BW*)",
          "Grimer                  (BW*)",
          "Combee                  (BW*)",
          "Beedrill                (BW*)",
          "Ekans",
          "Togepi",
          "Aipom",
          "Shroomish",
          "Gurdurr                 (B2W2*)",
          "Roselia",
          "Zangoose                (BW*)",
          "Seviper                 (BW*)",
          "Chansey",
          "Pinsir",
          "Eevee",
          "Snorlax",
          "Heracross"});
        speciesbox.SelectedIndex = 0;
        break;
      case 7://Pokemon Cafe forest
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange(new object[] {
          "Poliwhirl",
          "Eevee",
          "Smeargle",
          "Burmy"});
        speciesbox.SelectedIndex = 0;
        break;
      case 8://PGL Promotions
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange(new object[] {
          "Vaporeon",
          "Jolteon",
          "Flareon",
          "Espeon",
          "Umbreon",
          "Leafeon",
          "Glaceon",
          "Bulbasaur",
          "Charmander",
          "Squirtle",
          "Croagunk",
          "Turtwig",
          "Chimchar",
          "Piplup",
          "Arceus",
          "Treecko",
          "Torchic",
          "Mudkip",
          "Togekiss",
          "Mamoswine",
          "Porygon",
          "Rayquaza",
          "Banette",
          "Croagunk",
          "Altaria",
          "Blissey",
          "Lucario",
          "Gothorita",
          "Pikachu",
          "Jumpluff",
          "Pansage",
          "Pansear",
          "Panpour",
          "Turtwig",
          "Chimchar",
          "Piplup",
          "Gothorita",
          "Scizor",
          "Garchomp",
          "Dragonite",
          "Tyranitar",
          "Dragonite",
          "Metagross"});
        speciesbox.SelectedIndex = 0;
        break;
    }
    atkA.Checked = true;
    update_atk();
  }
  void Ok_butClick(object sender, EventArgs e) {
    if (world < 8) {
      //Handle forms
      if (world == 2 && (speciesbox.SelectedIndex == 25 || speciesbox.SelectedIndex == 36)) //Blue basculin, East Sea shellos
        EntralinkForm.dream_pkm = forest.create_pkm(world_species[world][speciesbox.SelectedIndex], world_attacks[world][speciesbox.SelectedIndex][atk], gender, 1, random_form_anim());
      else
        EntralinkForm.dream_pkm = forest.create_pkm(world_species[world][speciesbox.SelectedIndex], world_attacks[world][speciesbox.SelectedIndex][atk], gender, 0, random_form_anim());
    } else if (world == 8) {
      int anim = 0;
      //Random animation disabled and set to 0, as I've seen several PGL pokemon with animation 0 (Arceus, porygon, banette, croagunk, togekiss and lucario) and also a gothorita in a white 2 savegame
      //anim = random_form_anim();
      if (world_species[world][speciesbox.SelectedIndex] == 473)
        anim = 4; //But Mamoswine has, for some reason, animation 04, being the only known exception (would need more legit saves with the events)
      EntralinkForm.dream_pkm = forest.create_pkm(world_species[world][speciesbox.SelectedIndex], PGL_attacks[speciesbox.SelectedIndex], gender, 0, anim);
    }
    this.Close();
  }
  void Cancel_butClick(object sender, EventArgs e) {
    this.Close();
  }
  void SpeciesboxSelectedIndexChanged(object sender, EventArgs e) {
    //atkA.Checked = true;
    update_atk();
    update_gnd();

    bool exclusive = false;
    if (world < 8) {
      int i = 0;
      if (SAV is SAV5B2W2) {
        for (i = 0; i < world_BW1_exclusives[world].Length; i++) {
          if (world_BW1_exclusives[world][i] == world_species[world][speciesbox.SelectedIndex]) {
            exclusive = true;
          }
        }
        if (exclusive) {
          exclusive_label.Text = "BW Only";
          ok_but.Enabled = false;
        }

      } else {
        for (i = 0; i < world_BW2_exclusives[world].Length; i++) {
          if (world_BW2_exclusives[world][i] == world_species[world][speciesbox.SelectedIndex]) {
            exclusive = true;
          }
        }
        if (exclusive) {
          exclusive_label.Text = "B2W2 Only";
          ok_but.Enabled = false;
        }
      }

    } else if (world == 8) {
      if (SAV is SAV5B2W2) {
        if (PGL_exclusives[speciesbox.SelectedIndex] == 0) {
          exclusive_label.Text = "BW Only";
          ok_but.Enabled = false;
          exclusive = true;
        }
      } else {
        if (PGL_exclusives[speciesbox.SelectedIndex] == 1) {
          exclusive_label.Text = "B2W2 Only";
          ok_but.Enabled = false;
          exclusive = true;
        }
      }

      pgl_region_box.SelectedIndex = speciesbox.SelectedIndex;
    }

    if (!exclusive) {
      exclusive_label.Text = "";
      ok_but.Enabled = true;
    }

  }


  int[][] world_species = new int[][] {
    new int[]{019, 029, 032, 043, 069, 077, 083, 084, 102, 108, 114, 115, 161, 174, 179, 187, 191, 234, 261, 270, 276, 283, 399, 403, 535, 546, 548, 588, 616, 431, 545, 054, 058, 123, 128, 183, 185, 203, 241, 263, 309, 351, 417, 427, 037, 060, 177, 239, 300},
    new int[]{12, 16, 21, 41, 142, 163, 165, 187, 193, 198, 207, 225, 276, 278, 333, 397, 519, 561, 580, 587, 227, 357, 425, 441},
    new int[]{79, 86, 90, 98, 116, 118, 119, 120, 129, 138, 140, 170, 194, 211, 222, 223, 226, 320, 339, 366, 369, 370, 418, 456, 550, 550, 594, 618, 564, 72, 318, 341, 345, 347, 349, 422, 422, 131, 147},
    new int[]{92, 96, 122, 167, 200, 202, 228, 238, 303, 307, 325, 353, 355, 358, 434, 436, 605, 624, 596, 52, 209, 235, 313, 314, 479, 63, 280, 302, 442, 578, 622},
    new int[]{56, 66, 81, 109, 111, 218, 231, 246, 324, 328, 331, 412, 449, 451, 631, 632, 556, 558, 240, 216, 296, 322, 327, 359, 374, 453, 236, 371, 553, 447},
    new int[]{27, 74, 95, 100, 104, 173, 213, 293, 299, 304, 337, 338, 343, 363, 408, 459, 529, 621, 50, 206, 525, 583, 600, 215, 361, 410, 220, 443, 610},
    new int[]{46, 204, 265, 273, 287, 290, 311, 312, 316, 352, 401, 420, 455, 531, 538, 539, 559, 48, 88, 415, 15, 23, 175, 190, 285, 533, 315, 335, 336, 113, 127, 133, 143, 214},
    new int[]{061, 133, 235, 412}, //Pokemon Cafe forest
			new int[]{134, 135, 136, 196, 197, 470, 471, 1, 4, 7, 453, 387, 390, 393, 493, 252, 255, 258, 468, 473, 137, 384, 354, 453, 334, 242, 448, 575, 25, 189, 511, 513, 515, 387, 390, 393, 575, 212, 445, 149, 248, 149, 376, 376}
  };

  int[][][] world_attacks = new int[][][] {
    new int[][]{ new int[]{98, 382, 231}, new int[]{10, 389, 162}, new int[]{64, 68, 162}, new int[]{230, 298, 202}, new int[]{22, 235, 402}, new int[]{33, 37, 257}, new int[]{210, 355, 348}, new int[]{45, 175, 355}, new int[]{140, 235, 202}, new int[]{122, 214, 431}, new int[]{79, 73, 402}, new int[]{252, 68, 409}, new int[]{10, 203, 343}, new int[]{47, 313, 270}, new int[]{84, 115, 351}, new int[]{235, 270, 331}, new int[]{72, 230, 414}, new int[]{33, 50, 285}, new int[]{336, 305, 399}, new int[]{71, 73, 352}, new int[]{64, 119, 366}, new int[]{145, 56, 202}, new int[]{33, 401, 290}, new int[]{268, 393, 400}, new int[]{496, 414, 352}, new int[]{73, 227, 388}, new int[]{79, 204, 230}, new int[]{203, 224, 450}, new int[]{51, 226, 227}, new int[]{252, 372, 290}, new int[]{342, 390, 276}, new int[]{346, 227, 362}, new int[]{44, 34, 203}, new int[]{98, 226, 366}, new int[]{99, 231, 431}, new int[]{111, 453, 8}, new int[]{175, 205, 272}, new int[]{93, 243, 285}, new int[]{111, 174, 231}, new int[]{33, 271, 387}, new int[]{86, 423, 324}, new int[]{52, 466, 352}, new int[]{98, 343, 351}, new int[]{193, 252, 409}, new int[]{46, 257, 399}, new int[]{95, 54, 214}, new int[]{101, 297, 202}, new int[]{84, 238, 393}, new int[]{193, 321, 445} },
    new int[][]{ new int[]{93, 355, 314}, new int[]{16, 211, 290}, new int[]{64, 185, 211}, new int[]{48, 95, 162}, new int[]{44, 372, 446}, new int[]{193, 101, 278}, new int[]{4, 450, 9}, new int[]{235, 227, 340}, new int[]{98, 364, 202}, new int[]{64, 109, 355}, new int[]{28, 364, 366}, new int[]{217, 420, 264}, new int[]{64, 203, 413}, new int[]{55, 239, 351}, new int[]{64, 297, 355}, new int[]{17, 297, 366}, new int[]{16, 95, 234}, new int[]{95, 500, 257}, new int[]{432, 362, 382}, new int[]{98, 403, 204}, new int[]{64, 65, 355}, new int[]{16, 73, 318}, new int[]{107, 95, 285}, new int[]{119, 417, 272} },
    new int[][]{ new int[]{281, 335, 362}, new int[]{29, 333, 214}, new int[]{110, 112, 196}, new int[]{11, 133, 290}, new int[]{145, 190, 362}, new int[]{64, 60, 352}, new int[]{352, 214, 203}, new int[]{55, 278, 196}, new int[]{150, 175, 340}, new int[]{44, 330, 196}, new int[]{71, 175, 446}, new int[]{86, 133, 351}, new int[]{55, 34, 401}, new int[]{40, 453, 290}, new int[]{145, 109, 446}, new int[]{199, 350, 362}, new int[]{48, 243, 314}, new int[]{55, 214, 340}, new int[]{189, 214, 209}, new int[]{250, 445, 392}, new int[]{55, 214, 414}, new int[]{204, 300, 196}, new int[]{346, 163, 352}, new int[]{213, 186, 352}, new int[]{29, 97, 428}, new int[]{29, 97, 428}, new int[]{392, 243, 220}, new int[]{189, 174, 281}, new int[]{205, 175, 334}, new int[]{48, 367, 202}, new int[]{44, 37, 399}, new int[]{106, 232, 283}, new int[]{51, 243, 202}, new int[]{10, 446, 440}, new int[]{150, 445, 243}, new int[]{189, 281, 290}, new int[]{189, 281, 290}, new int[]{109, 32, 196}, new int[]{86, 352, 225} },
    new int[][]{ new int[]{95, 50, 482}, new int[]{95, 427, 409}, new int[]{112, 298, 285}, new int[]{40, 527, 450}, new int[]{149, 194, 517}, new int[]{243, 204, 227}, new int[]{336, 364, 399}, new int[]{186, 445, 285}, new int[]{313, 424, 8}, new int[]{96, 409, 203}, new int[]{149, 285, 278}, new int[]{101, 194, 220}, new int[]{50, 220, 271}, new int[]{35, 95, 304}, new int[]{103, 492, 389}, new int[]{95, 285, 356}, new int[]{377, 112, 417}, new int[]{210, 427, 389}, new int[]{486, 50, 228}, new int[]{10, 95, 290}, new int[]{204, 370, 38}, new int[]{166, 445, 214}, new int[]{148, 271, 366}, new int[]{204, 313, 366}, new int[]{86, 351, 324}, new int[]{100, 285, 356}, new int[]{93, 194, 270}, new int[]{193, 389, 180}, new int[]{180, 220, 196}, new int[]{105, 286, 271}, new int[]{205, 7, 9} },
    new int[][]{ new int[]{67, 179, 9}, new int[]{67, 418, 270}, new int[]{319, 278, 356}, new int[]{123, 399, 482}, new int[]{30, 68, 38}, new int[]{52, 517, 257}, new int[]{175, 484, 402}, new int[]{44, 399, 446}, new int[]{52, 90, 446}, new int[]{44, 324, 202}, new int[]{71, 298, 9}, new int[]{182, 450, 173}, new int[]{44, 254, 276}, new int[]{44, 97, 401}, new int[]{510, 257, 202}, new int[]{210, 203, 422}, new int[]{42, 73, 191}, new int[]{157, 68, 400}, new int[]{52, 9, 257}, new int[]{313, 242, 264}, new int[]{292, 270, 8}, new int[]{52, 34, 257}, new int[]{383, 252, 276}, new int[]{364, 224, 276}, new int[]{36, 428, 442}, new int[]{40, 409, 441}, new int[]{252, 364, 183}, new int[]{44, 349, 200}, new int[]{242, 68, 212}, new int[]{203, 418, 264} },
    new int[][]{ new int[]{28, 68, 162}, new int[]{111, 446, 431}, new int[]{20, 446, 431}, new int[]{268, 324, 363}, new int[]{125, 195, 67}, new int[]{227, 312, 214}, new int[]{227, 270, 504}, new int[]{253, 283, 428}, new int[]{33, 446, 246}, new int[]{106, 283, 457}, new int[]{93, 414, 236}, new int[]{93, 428, 234}, new int[]{229, 356, 428}, new int[]{181, 90, 401}, new int[]{29, 442, 7}, new int[]{75, 419, 202}, new int[]{229, 319, 431}, new int[]{44, 424, 389}, new int[]{28, 251, 446}, new int[]{111, 277, 446}, new int[]{479, 174, 484}, new int[]{429, 420, 286}, new int[]{451, 356, 393}, new int[]{269, 8, 67}, new int[]{181, 311, 352}, new int[]{182, 68, 90}, new int[]{316, 246, 333}, new int[]{82, 200, 203}, new int[]{82, 68, 400} },
    new int[][]{ new int[]{78, 440, 235}, new int[]{120, 390, 356}, new int[]{40, 450, 173}, new int[]{74, 331, 492}, new int[]{281, 400, 389}, new int[]{141, 203, 400}, new int[]{86, 435, 324}, new int[]{86, 435, 324}, new int[]{139, 151, 202}, new int[]{185, 285, 513}, new int[]{522, 283, 253}, new int[]{73, 505, 331}, new int[]{44, 476, 380}, new int[]{270, 227, 281}, new int[]{20, 8, 276}, new int[]{249, 9, 530}, new int[]{67, 252, 409}, new int[]{50, 226, 285}, new int[]{139, 114, 425}, new int[]{16, 366, 314}, new int[]{31, 314, 210}, new int[]{40, 251, 399}, new int[]{118, 381, 253}, new int[]{10, 252, 7}, new int[]{78, 331, 264}, new int[]{67, 183, 409}, new int[]{74, 79, 129}, new int[]{98, 458, 67}, new int[]{44, 34, 401}, new int[]{45, 68, 270}, new int[]{11, 370, 382}, new int[]{28, 204, 129}, new int[]{133, 7, 278}, new int[]{30, 175, 264} },
    new int[][]{ new int[]{240, 114, 352}, new int[]{ 270, 204, 129}, new int[]{ 166, 445, 214}, new int[]{ 182, 450, 173} } //Pokemon Cafe forest
		};

  int[] PGL_attacks = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 217, 0, 0, 0, 538, 398, 206, 0, 418, 243, 29, 206, 437, 257, 56, 254, 252, 297, 286, 211, 0, 9, 69, 245, 38 };

  /* Method deprecated, it seems there's no gender restriction outside pokemon being male/female only or genderless
		int[][] world_gender = new int[][] {
			// 0: only male, 1: only female, 2: genderless, 3: male/female
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{3, 3, 3, 3} //Pokemon Cafe forest
		};
		*/
  int[][] world_BW1_exclusives = new int[][] {
    new int[]{029, 032, 174, 187, 270, 276, 283, 309, 351, 417},//Pleasant Forest
			new int[]{012, 163, 278, 333, 425, 441},//Windswept Sky
			new int[]{079, 098, 119, 120, 222, 422, 422},
      new int[]{202, 238, 303, 307, 436, 052, 479, 280, 302, 442},
      new int[]{056, 111, 231, 451, 216, 296, 327, 374, 447},
      new int[]{173, 213, 299, 363, 408, 206, 410},
      new int[]{048, 88, 415, 15, 335, 336},
      new int[]{0} //Pokemon Cafe forest
		};

  int[][] world_BW2_exclusives = new int[][] {
    new int[]{535, 546, 548, 588, 616, 545},//Pleasant Forest
		new int[]{519, 561, 580, 587},//Windswept Sky
		new int[]{550, 550, 594, 618, 564},
    new int[]{605, 624, 596, 578},
    new int[]{631, 632, 556, 558, 553},
    new int[]{529, 621, 525, 583, 600, 610},
    new int[]{531, 538, 539, 559, 533},
    new int[]{0} //Pokemon Cafe forest
		};

  int[] PGL_exclusives = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 };

  public static int random_form_anim() {
    Random rnd = new Random(Guid.NewGuid().GetHashCode());
    int anim = rnd.Next(15);
    if (IsOdd(anim) == true)
      anim = anim - 1;
    return anim;
  }
  public static bool IsOdd(int value) {
    return value % 2 != 0;
  }

  private int atk = 0;
  private void update_atk() {
    if (world < 8) {
      if (atkA.Checked == true)
        atk = 0;
      else if (atkB.Checked == true)
        atk = 1;
      else if (atkC.Checked == true)
        atk = 2;

      moveboxA.SelectedIndex = world_attacks[world][speciesbox.SelectedIndex][0];
      movebox.SelectedIndex = world_attacks[world][speciesbox.SelectedIndex][1];
      moveboxC.SelectedIndex = world_attacks[world][speciesbox.SelectedIndex][2];
    } else if (world == 8) {
      movebox.SelectedIndex = PGL_attacks[speciesbox.SelectedIndex];
    }

  }
  void AtkACheckedChanged(object sender, EventArgs e) {
    update_atk();
  }
  void AtkBCheckedChanged(object sender, EventArgs e) {
    update_atk();
  }
  void AtkCCheckedChanged(object sender, EventArgs e) {
    update_atk();
  }

  private int gender = 0;
  private void update_gnd() {
    //Handle genders
    bool special_gender = false;
    for (int i = 0; i < EntralinkForm.BW_femaleonly.Length; i++) {
      if (world_species[world][speciesbox.SelectedIndex] == EntralinkForm.BW_femaleonly[i]) {
        //Only female
        special_gender = true;
        gnd_female.Checked = true;
        gnd_male.Enabled = false;
        gnd_female.Enabled = true;
        gnd_none.Enabled = false;
      }
    }

    for (int i = 0; i < EntralinkForm.BW_maleonly.Length; i++) {
      if (world_species[world][speciesbox.SelectedIndex] == EntralinkForm.BW_maleonly[i]) {
        //Only male
        special_gender = true;
        gnd_male.Checked = true;
        gnd_male.Enabled = true;
        gnd_female.Enabled = false;
        gnd_none.Enabled = false;
      }
    }

    for (int i = 0; i < EntralinkForm.BW_genderless.Length; i++) {
      if (world_species[world][speciesbox.SelectedIndex] == EntralinkForm.BW_genderless[i]) {
        //Only genderless
        special_gender = true;
        gnd_none.Checked = true;
        gnd_male.Enabled = false;
        gnd_female.Enabled = false;
        gnd_none.Enabled = true;
      }
    }

    if (special_gender == false) {
      //Male/female
      if (gender == 2 || (world == 8)) {
        if (world == 8 && speciesbox.SelectedIndex == 22) { //Banette is the only female pokemon distributed via PGL
          gnd_female.Checked = true;
          gnd_male.Enabled = false;
          gnd_female.Enabled = true;
        } else {
          if (world == 8)
            gnd_female.Enabled = false;
          gnd_male.Checked = true;
          gnd_male.Enabled = true;
        }
      }
      if (gnd_male.Checked == false && gnd_female.Checked == false && gnd_none.Checked == false) {
        if (world == 8 && speciesbox.SelectedIndex == 22) { //Banette is the only female pokemon distributed via PGL
          gnd_female.Enabled = true;
          gnd_female.Checked = true;
          gnd_male.Enabled = false;
        } else {
          if (world == 8)
            gnd_female.Enabled = false;
          gnd_male.Checked = true;
          gnd_male.Enabled = true;
        }
      }
      if (world != 8)
        gnd_male.Enabled = true;
      if (world != 8)
        gnd_female.Enabled = true;
      gnd_none.Enabled = false;
    }

    /*
			switch(world_gender[world][speciesbox.SelectedIndex])
			{
				case 0://male only
					gnd_male.Checked = true;
					gnd_male.Enabled = true;
					gnd_female.Enabled = false;
					gnd_none.Enabled = false;
					break;
				case 1://female only
					gnd_female.Checked = true;
					gnd_male.Enabled = false;
					gnd_female.Enabled = true;
					gnd_none.Enabled = false;
					break;
				case 2://genderless
					gnd_none.Checked = true;
					gnd_male.Enabled = false;
					gnd_female.Enabled = false;
					gnd_none.Enabled = true;
					break;
				default://male/female
					if (gender == 2)
						gnd_male.Checked = true;
					if (gnd_male.Checked == false && gnd_female.Checked == false && gnd_none.Checked == false)
						gnd_male.Checked = true;
					gnd_male.Enabled = true;
					gnd_female.Enabled = true;
					gnd_none.Enabled = false;
					break;
			}
		 */

    if (gnd_male.Checked == true)
      gender = 0;
    else if (gnd_female.Checked == true)
      gender = 1;
    else if (gnd_none.Checked == true)
      gender = 2;

  }

  void Gnd_maleCheckedChanged(object sender, EventArgs e) {
    update_gnd();
  }
  void Gnd_femaleCheckedChanged(object sender, EventArgs e) {
    update_gnd();
  }
  void Gnd_noneCheckedChanged(object sender, EventArgs e) {
    update_gnd();
  }

}
