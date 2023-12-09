namespace PluginPile.Unmaintained.SwShRaidTool;
public class NestHashDetail(ulong common, ulong rare, int location, int mapX, int mapY) {
  public readonly ulong CommonHash = common;
  public readonly ulong RareHash = rare;
  public readonly int Location = location;
  public readonly int MapX = mapX;
  public readonly int MapY = mapY;
}

public static class NestLocations {
  public const ulong EventHash = 1721953670860364124;
  public const ulong EventHash_Rigel1 = 968916678281972007;
  public const ulong EventHash_Rigel2 = 968917777793600218;

  public static readonly NestHashDetail[] Nests = [
    new NestHashDetail(0x173f0456dc5dfc52, 0xba83e1671012ebcd, 12, 185, 977), //16 52
    new NestHashDetail(0x17458556dc634333, 0xba8745671015cb90, 12, 125,1005), //37 64
    new NestHashDetail(0x17458b56dc634d65, 0x450421d99cf882c1, 12, 114, 936), //31 90
    new NestHashDetail(0x17428156dc610690, 0xba805467100fc65f, 12, 311, 998), //03 51
    new NestHashDetail(0x17428856dc611275, 0xba805767100fcb78, 12, 233, 948), //04 46
    new NestHashDetail(0x17458956dc6349ff, 0xba8747671015cef6, 12, 337, 996), //33 62
    new NestHashDetail(0x17459356dc635afd, 0xba8746671015cd43, 12, 209, 976), //39 65
    new NestHashDetail(0x17428356dc6109f6, 0xba805967100fcede, 12, 136, 906), //01 48
    new NestHashDetail(0x17458b56dc634d65, 0x450421d99cf882c1, 12, 252, 905), //31 90
    new NestHashDetail(0x17491656dc666f6d, 0xba83da671012dfe8, 02, 030, 927), //26 59
    new NestHashDetail(0x17490856dc6657a3, 0x4500a2d99cf5751d, 02, 012, 851), //28 79
    new NestHashDetail(0x17491656dc666f6d, 0xba83db671012e19b, 02, 012, 861), //26 58
    new NestHashDetail(0x17428856dc611275, 0x45041fd99cf87f5b, 02, 020, 913), //04 92
    new NestHashDetail(0x17491656dc666f6d, 0xba83da671012dfe8, 02, 040, 878), //26 59
    new NestHashDetail(0x17428256dc610843, 0xba805367100fc4ac, 15, 052, 776), //02 50
    new NestHashDetail(0x17428656dc610f0f, 0xba805867100fcd2b, 15, 068, 652), //06 47
    new NestHashDetail(0x0000000000000000, 0x0000000000000000, 15, 050, 700), //Special
    new NestHashDetail(0x17428556dc610d5c, 0xba805d67100fd5aa, 04, 217, 913), //07 44
    new NestHashDetail(0x17459356dc635afd, 0xba8746671015cd43, 04, 158, 705), //39 65
    new NestHashDetail(0x17458b56dc634d65, 0xba83d8671012dc82, 04, 220, 759), //31 61
    new NestHashDetail(0x17458b56dc634d65, 0xba83d8671012dc82, 04, 248, 852), //31 61
    new NestHashDetail(0x17428b56dc61178e, 0xba8a4e67101810b2, 16, 129, 818), //09 75
    new NestHashDetail(0x17428b56dc61178e, 0xba8a4e67101810b2, 16, 131, 735), //09 75
    new NestHashDetail(0x17501a56dc6c94e7, 0xba805d67100fd5aa, 16, 105, 907), //42 44
    new NestHashDetail(0x17428556dc610d5c, 0xba805d67100fd5aa, 16, 050, 909), //07 44
    new NestHashDetail(0x17428b56dc61178e, 0x450420d99cf8810e, 16, 098, 750), //09 91
    new NestHashDetail(0x17458756dc634699, 0xba8748671015d0a9, 16, 107, 652), //35 63
    new NestHashDetail(0x17459256dc63594a, 0xba8745671015cb90, 00, 186, 816), //38 64
    new NestHashDetail(0x17428c56dc611941, 0x450420d99cf8810e, 13, 310, 824), //08 91
    new NestHashDetail(0x17501b56dc6c969a, 0xba8a496710180833, 13, 359, 980), //41 76
    new NestHashDetail(0x17501b56dc6c969a, 0xba8a496710180833, 13, 393, 962), //41 76
    new NestHashDetail(0x17428756dc6110c2, 0xba805767100fcb78, 13, 328, 761), //05 46
    new NestHashDetail(0x17428356dc6109f6, 0xba805c67100fd3f7, 13, 352, 765), //01 43
    new NestHashDetail(0x173f0356dc5dfa9f, 0xba805467100fc65f, 07, 443, 895), //15 51
    new NestHashDetail(0x173f0056dc5df586, 0xba805e67100fd75d, 07, 388, 817), //12 45
    new NestHashDetail(0x173eff56dc5df3d3, 0xba805a67100fd091, 07, 443, 830), //11 49
    new NestHashDetail(0x173f0356dc5dfa9f, 0x45009ed99cf56e51, 07, 410, 952), //15 83
    new NestHashDetail(0x173eff56dc5df3d3, 0x450097d99cf5626c, 07, 447, 815), //11 84
    new NestHashDetail(0x173efe56dc5df220, 0xba805967100fcede, 11, 393, 781), //10 48
    new NestHashDetail(0x17501b56dc6c969a, 0xba8a496710180833, 11, 314, 755), //41 76
    new NestHashDetail(0x17490756dc6655f0, 0xba83d9671012de35, 11, 440, 658), //29 60
    new NestHashDetail(0x17501b56dc6c969a, 0xba8a496710180833, 11, 281, 717), //41 76
    new NestHashDetail(0x17490756dc6655f0, 0xba83d9671012de35, 11, 440, 703), //29 60
    new NestHashDetail(0x17490756dc6655f0, 0x450425d99cf8898d, 04, 310, 654), //29 86
    new NestHashDetail(0x173efe56dc5df220, 0xba805967100fcede, 11, 443, 792), //10 48
    new NestHashDetail(0x173f0256dc5df8ec, 0xba805367100fc4ac, 10, 412, 533), //14 50
    new NestHashDetail(0x17458a56dc634bb2, 0xba83d9671012de35, 10, 345, 537), //30 60
    new NestHashDetail(0x17491456dc666c07, 0xba83dd671012e501, 10, 365, 559), //24 56
    new NestHashDetail(0x17501c56dc6c984d, 0xba8746671015cd43, 10, 408, 570), //40 65
    new NestHashDetail(0x17458656dc6344e6, 0x45009dd99cf56c9e, 01, 193, 295), //34 82
    new NestHashDetail(0x173f0156dc5df739, 0x450424d99cf887da, 01, 274, 321), //13 87
    new NestHashDetail(0x17428c56dc611941, 0xba805d67100fd5aa, 01, 328, 330), //08 44
    new NestHashDetail(0x173f0456dc5dfc52, 0xba83e1671012ebcd, 01, 370, 452), //16 52
    new NestHashDetail(0x17501c56dc6c984d, 0xba8746671015cd43, 01, 224, 282), //40 65
    new NestHashDetail(0x17428856dc611275, 0x45041fd99cf87f5b, 01, 342, 312), //04 92
    new NestHashDetail(0x17428756dc6110c2, 0xba805767100fcb78, 01, 340, 269), //05 46
    new NestHashDetail(0x17458456dc634180, 0xba8748671015d0a9, 01, 305, 323), //36 63
    new NestHashDetail(0x17491556dc666dba, 0xba83da671012dfe8, 01, 334, 368), //27 59
    new NestHashDetail(0x17501c56dc6c984d, 0xba874b671015d5c2, 14, 343, 222), //40 66
    new NestHashDetail(0x17428356dc6109f6, 0x45009cd99cf56aeb, 14, 348, 195), //01 81
    new NestHashDetail(0x17428156dc610690, 0xba805467100fc65f, 14, 200, 244), //03 51
    new NestHashDetail(0x173f0756dc5e016b, 0x45009bd99cf56938, 14, 305, 183), //19 80
    new NestHashDetail(0x17428656dc610f0f, 0xba805c67100fd3f7, 14, 348, 180), //06 43
    new NestHashDetail(0x17491556dc666dba, 0xba83da671012dfe8, 14, 260, 199), //27 59
    new NestHashDetail(0x17428256dc610843, 0xba805367100fc4ac, 14, 211, 205), //02 50
    new NestHashDetail(0x173f0056dc5df586, 0x450098d99cf5641f, 14, 303, 242), //12 85
    new NestHashDetail(0x17491256dc6668a1, 0xba83de671012e6b4, 14, 324, 209), //22 55
    new NestHashDetail(0x173f0256dc5df8ec, 0xba805367100fc4ac, 14, 326, 219), //14 50
    new NestHashDetail(0x173f0656dc5dffb8, 0xba83df671012e867, 14, 330, 215), //18 54
    new NestHashDetail(0x17458756dc634699, 0xba8748671015d0a9, 14, 282, 195), //35 63
    new NestHashDetail(0x173f0556dc5dfe05, 0x45041ed99cf87da8, 03, 265, 139), //17 93
    new NestHashDetail(0x173f0556dc5dfe05, 0xba83e1671012ebcd, 03, 307, 093), //17 52
    new NestHashDetail(0x173f0356dc5dfa9f, 0x45041ed99cf87da8, 03, 331, 084), //15 93
    new NestHashDetail(0x17428b56dc61178e, 0xba8a4e67101810b2, 03, 219, 099), //09 75
    new NestHashDetail(0x173eff56dc5df3d3, 0xba805a67100fd091, 03, 243, 120), //11 49
    new NestHashDetail(0x173efe56dc5df220, 0xba805967100fcede, 03, 262, 174), //10 48
    new NestHashDetail(0x17490f56dc666388, 0xba83de671012e6b4, 03, 283, 098), //21 55
    new NestHashDetail(0x17491056dc66653b, 0xba83df671012e867, 03, 304, 112), //20 54
    new NestHashDetail(0x17490856dc6657a3, 0xba805c67100fd3f7, 06, 306, 145), //28 43
    new NestHashDetail(0x17458456dc634180, 0x450423d99cf88627, 03, 214, 168), //36 88
    new NestHashDetail(0x17501a56dc6c94e7, 0xba874c671015d775, 06, 334, 145), //42 67
    new NestHashDetail(0x17458456dc634180, 0xba874a671015d40f, 06, 347, 103), //36 69
    new NestHashDetail(0x17491556dc666dba, 0xba874f671015dc8e, 06, 363, 088), //27 70
    new NestHashDetail(0x17491356dc666a54, 0xba8a4d6710180eff, 06, 338, 122), //25 72
    new NestHashDetail(0x173f0056dc5df586, 0xba805e67100fd75d, 08, 339, 035), //12 45
    new NestHashDetail(0x17458856dc63484c, 0xba83d8671012dc82, 08, 310, 065), //32 61
    new NestHashDetail(0x17458a56dc634bb2, 0xba83dc671012e34e, 08, 202, 034), //30 57
    new NestHashDetail(0x173f0756dc5e016b, 0xba83e0671012ea1a, 08, 237, 067), //19 53
    new NestHashDetail(0x17491156dc6666ee, 0xba8a4c6710180d4c, 08, 183, 047), //23 73
    new NestHashDetail(0x17458956dc6349ff, 0xba8747671015cef6, 08, 221, 050), //33 62
    new NestHashDetail(0x173f0256dc5df8ec, 0xba8749671015d25c, 08, 354, 060), //14 68
    new NestHashDetail(0x17458a56dc634bb2, 0xba83d9671012de35, 05, 181, 185), //30 60
    new NestHashDetail(0x17491156dc6666ee, 0xba83de671012e6b4, 05, 199, 145), //23 55
    new NestHashDetail(0x173f0656dc5dffb8, 0xba8750671015de41, 05, 193, 173), //18 71
    new NestHashDetail(0x17458856dc63484c, 0x450422d99cf88474, 05, 202, 095), //32 89
    new NestHashDetail(0x17491456dc666c07, 0x4500a1d99cf5736a, 05, 185, 135), //24 78
    new NestHashDetail(0x17491356dc666a54, 0xba83dd671012e501, 09, 170, 035), //25 56
    new NestHashDetail(0x173f0656dc5dffb8, 0x4500a0d99cf571b7, 09, 128, 058), //18 77
    new NestHashDetail(0x17428c56dc611941, 0xba805d67100fd5aa, 09, 161, 080), //08 44
    new NestHashDetail(0x17458656dc6344e6, 0xba8a4f6710181265, 09, 143, 039), //34 74
    new NestHashDetail(0x79b25a4f80255a38, 0xc8ea8c1618ab0a58, 17, 643, 822), //115 116
    new NestHashDetail(0xe2c6e5e725342f4a, 0x89955cc3a594e51a, 17, 770, 794), //125 126
    new NestHashDetail(0x6d015b7858eb5119, 0x53441b80e563ef1f, 17, 723, 812), //109 110
    new NestHashDetail(0x4257e50e1c471596, 0xfe9697f9799c65be, 17, 862, 770), //133 134
    new NestHashDetail(0x2998f2424d0353eb, 0xae57b2a84974c3a1, 17, 673, 766), //111 112
    new NestHashDetail(0x5b72bfac0ff3f885, 0x316e6b5e74bc7aa3, 17, 882, 745), //113 114
    new NestHashDetail(0x21f6c965b3513d5e, 0xd8f100cde5822516, 17, 661, 838), //99  100
    new NestHashDetail(0x6e6b46639f77f0c8, 0x1c1962488c012ee8, 17, 683, 792), //105 106
    new NestHashDetail(0xbc3d01fff751cde4, 0x6f948f09933cdfc, 17, 831, 770),  //123 124
    new NestHashDetail(0x4257e30e1c471230, 0xfe9695f9799c6258, 17, 727, 779), //137 138
    new NestHashDetail(0x4257e40e1c4713e3, 0xfe9696f9799c640b, 18, 662, 681), //135 136
    new NestHashDetail(0x2998f2424d0353eb, 0xae57b2a84974c3a1, 18, 741, 680), //111 112
    new NestHashDetail(0xe2c6e5e725342f4a, 0x89955cc3a594e51a, 18, 697, 645), //125 126
    new NestHashDetail(0xc63dec8a65b5c540, 0x6aebee2a2d6d8470, 18, 732, 631), //121 122
    new NestHashDetail(0x5c9a35ca819b38c8, 0xf9222e1acdf486e8, 18, 634, 623), //119 120
    new NestHashDetail(0xb8a5e528bfee71bc, 0xdf017f3fefba2704, 18, 603, 591), //117 118
    new NestHashDetail(0x21f6c865b3513bab, 0xd8f0ffcde5822363, 18, 667, 614), //101 102
    new NestHashDetail(0x21f6c965b3513d5e, 0xd8f100cde5822516, 18, 609, 668), //99  100
    new NestHashDetail(0x4257e50e1c471596, 0xfe9697f9799c65be, 18, 554, 577), //133 134
    new NestHashDetail(0x6d015b7858eb5119, 0x53441b80e563ef1f, 19, 533, 524), //109 110
    new NestHashDetail(0xdb8629cba3383296, 0x4f1e561dd73ed3d8, 19, 687, 535), //154 145
    new NestHashDetail(0x6e6b46639f77f0c8, 0x1c1962488c012ee8, 19, 622, 521), //105 106
    new NestHashDetail(0xe2c6e5e725342f4a, 0x89955cc3a594e51a, 19, 578, 512), //125 126
    new NestHashDetail(0x5c9a35ca819b38c8, 0xf9222e1acdf486e8, 19, 636, 492), //119 120
    new NestHashDetail(0x4257e40e1c4713e3, 0xfe9696f9799c640b, 19, 553, 529), //135 136
    new NestHashDetail(0x5b72bfac0ff3f885, 0x316e6b5e74bc7aa3, 20, 488, 480), //113 114
    new NestHashDetail(0x4257e40e1c4713e3, 0xfe9696f9799c640b, 20, 483, 556), //135 136
    new NestHashDetail(0x6e6b46639f77f0c8, 0x1c1962488c012ee8, 20, 465, 605), //105 106
    new NestHashDetail(0xbc3d01fff751cde4, 0x6f948f09933cdfc, 20, 446, 649),  //123 124
    new NestHashDetail(0x60ef1d711ae30cf0, 0xc80756327d5de060, 20, 453, 561), //117 118
    new NestHashDetail(0x4257e30e1c471230, 0xfe9695f9799c6258, 20, 320, 526), //137 138
    new NestHashDetail(0xb8a5e528bfee71bc, 0xdf017f3fefba2704, 20, 442, 609), //103 104
    new NestHashDetail(0x4c12cee7784c8b8, 0x7288f0346fd3cdd8, 20, 412, 566),  //127 128
    new NestHashDetail(0x50eaf4685fa07085, 0xf9280759d6cc62a3, 21, 947, 506), //129 130
    new NestHashDetail(0xbc3d01fff751cde4, 0x6f948f09933cdfc, 22, 912, 467),  //123 124
    new NestHashDetail(0x5584521f1e549486, 0x55846e1f1e54c41a, 22, 925, 433), //156 157
    new NestHashDetail(0xa178d4769765abac, 0xf4a830850f51d034, 22, 913, 408), //107 108
    new NestHashDetail(0xc63dec8a65b5c540, 0x6aebee2a2d6d8470, 22, 895, 365), //121 122
    new NestHashDetail(0x60ef1d711ae30cf0, 0xc80756327d5de060, 23, 526, 650), //103 104
    new NestHashDetail(0x4257e40e1c4713e3, 0x4f1e5b1dd73edc57, 23, 576, 714), //135 148
    new NestHashDetail(0x4c12cee7784c8b8, 0x7288f0346fd3cdd8, 23, 565, 726),  //127 128
    new NestHashDetail(0x50eaf4685fa07085, 0xf9280759d6cc62a3, 23, 586, 726), //129 130
    new NestHashDetail(0x4257e50e1c471596, 0xfe9697f9799c65be, 23, 621, 749), //133 134
    new NestHashDetail(0x21f6c865b3513bab, 0xd8f0ffcde5822363, 23, 528, 695), //101 102
    new NestHashDetail(0x5b72bfac0ff3f885, 0x316e6b5e74bc7aa3, 24, 408, 809), //113 114
    new NestHashDetail(0xb0c9af2202b0a19e, 0x4f1e5c1dd73ede0a, 24, 426, 790), //131 151
    new NestHashDetail(0x4257e30e1c471230, 0xfe9695f9799c6258, 24, 360, 850), //137 138
    new NestHashDetail(0xa178d4769765abac, 0xf4a830850f51d034, 24, 327, 787), //107 108
    new NestHashDetail(0x5c9a35ca819b38c8, 0xf9222e1acdf486e8, 25, 707, 421), //119 120
    new NestHashDetail(0xdb8629cba3383296, 0x4f1e561dd73ed3d8, 25, 832, 398), //154 145
    new NestHashDetail(0xb8a5e528bfee71bc, 0xdf017f3fefba2704, 25, 591, 430), //117 118
    new NestHashDetail(0x79b25a4f80255a38, 0xc8ea8c1618ab0a58, 25, 666, 334), //115 116
    new NestHashDetail(0x2998f2424d0353eb, 0xae57b2a84974c3a1, 25, 758, 338), //111 112
    new NestHashDetail(0x6d015b7858eb5119, 0x4f1e5a1dd73edaa4, 25, 719, 377), //109 149
    new NestHashDetail(0x21f6c865b3513bab, 0xd8f0ffcde5822363, 25, 659, 397), //101 102
    new NestHashDetail(0x60ef1d711ae30cf0, 0x4f1e5d1dd73edfbd, 26, 665, 243), //103 150
    new NestHashDetail(0x5b72bfac0ff3f885, 0x316e6b5e74bc7aa3, 26, 784, 212), //113 114
    new NestHashDetail(0x79b25a4f80255a38, 0xc8ea8c1618ab0a58, 26, 881, 235), //115 116
    new NestHashDetail(0x6b37a94863bf68c0, 0x4f1e591dd73ed8f1, 27, 321, 1004),//155 146
    new NestHashDetail(0x4257ea0e1c471e15, 0xfe969cf9799c6e3d, 27, 782, 962), //139 140
    new NestHashDetail(0x40bdbe4f3bcbac86, 0x9fdf11a0cde96b2e, 27, 1040, 752),//152 153
    new NestHashDetail(0xc63dec8a65b5c540, 0x6aebee2a2d6d8470, 27, 970, 701), //121 122
    new NestHashDetail(0x6d015b7858eb5119, 0x53441b80e563ef1f, 27, 759, 1015),//109 110
    new NestHashDetail(0xa178d4769765abac, 0xf4a830850f51d034, 27, 558, 1082),//107 108
    new NestHashDetail(0xb0c9af2202b0a19e, 0x3d6f1fcb3898d356, 27, 523, 993), //131 132
    new NestHashDetail(0x60ef1d711ae30cf0, 0xc80756327d5de060, 28, 129, 797), //103 104
    new NestHashDetail(0xb8a5e528bfee71bc, 0xdf017f3fefba2704, 28, 75, 658),  //117 118
    new NestHashDetail(0x6b37a94863bf68c0, 0x4f1e591dd73ed8f1, 28, 120, 523), //155 146
    new NestHashDetail(0x5c9a35ca819b38c8, 0xf9222e1acdf486e8, 28, 120, 547), //119 120
    new NestHashDetail(0x50eaf4685fa07085, 0xf9280759d6cc62a3, 28, 287, 559), //129 130
    new NestHashDetail(0x21f6c965b3513d5e, 0xd8f100cde5822516, 28, 258, 654), //99  100
    new NestHashDetail(0x4c12cee7784c8b8, 0x7288f0346fd3cdd8, 28, 174, 852),  //127 128
    new NestHashDetail(0x4257ea0e1c471e15, 0xfe969cf9799c6e3d, 28, 162, 808), //139 140
    new NestHashDetail(0xa178d4769765abac, 0xf4a830850f51d034, 28, 162, 763), //107 108
    new NestHashDetail(0xe2c6e5e725342f4a, 0x89955cc3a594e51a, 29, 299, 356), //125 126
    new NestHashDetail(0x21f6c965b3513d5e, 0xd8f100cde5822516, 29, 214, 349), //99  100
    new NestHashDetail(0x2998f2424d0353eb, 0xae57b2a84974c3a1, 29, 185, 302), //111 112
    new NestHashDetail(0x4257ea0e1c471e15, 0xfe969cf9799c6e3d, 29, 247, 298), //139 140
    new NestHashDetail(0x4257e30e1c471230, 0x4f1e581dd73ed73e, 29, 271, 273), //137 147
    new NestHashDetail(0xb0c9af2202b0a19e, 0x3d6f1fcb3898d356, 30, 468, 451), //131 132
    new NestHashDetail(0xbc3d01fff751cde4, 0x6f948f09933cdfc, 30, 605, 166),  //123 124
    new NestHashDetail(0xc63dec8a65b5c540, 0x6aebee2a2d6d8470, 30, 672, 120), //121 122
    new NestHashDetail(0x4257ea0e1c471e15, 0xfe969cf9799c6e3d, 30, 716, 91),  //139 140
    new NestHashDetail(0x6e6b46639f77f0c8, 0x1c1962488c012ee8, 30, 597, 105), //105 106
    new NestHashDetail(0xea4c3915ea6f95a0, 0x3ea9df3b7b2b5990, 31, 471, 152), //143 144
    new NestHashDetail(0xea4c3915ea6f95a0, 0x3ea9df3b7b2b5990, 31, 490, 194), //143 144
    new NestHashDetail(0xea4c3915ea6f95a0, 0x3ea9df3b7b2b5990, 31, 464, 237), //143 144
    new NestHashDetail(0xea4c3915ea6f95a0, 0x3ea9df3b7b2b5990, 31, 413, 237), //143 144
    new NestHashDetail(0xea4c3915ea6f95a0, 0x3ea9df3b7b2b5990, 31, 386, 195), //143 144
    new NestHashDetail(0xea4c3915ea6f95a0, 0x3ea9df3b7b2b5990, 31, 414, 148), //143 144

    new NestHashDetail(0x779e9eb99c1292c, 0x93a637943a964e41, 32, 455, 710), //166 167
    new NestHashDetail(0x55e4467f01ec60bb, 0xa5696e4aa8d625a, 32, 571, 697), //180 181
    new NestHashDetail(0x685db02aaedbcf61, 0x2cd8cf9a88739f98, 32, 550, 705), //168 169
    new NestHashDetail(0x2640fa844b19c3cf, 0x422f95fb66a95706, 32, 654, 775), //158 159
    new NestHashDetail(0x47a5d8b98dd573ab, 0xa23ec426e4e9430a, 32, 699, 765), //182 183
    new NestHashDetail(0x685db02aaedbcf61, 0x2cd8cf9a88739f98, 32, 624, 737), //168 169
    new NestHashDetail(0xc862667fc72ee059, 0x72f9d87337338120, 33, 431, 903), //190 191
    new NestHashDetail(0x42b21efc37c7b974, 0x9d415f6a7a841dd9, 33, 458, 887), //176 177
    new NestHashDetail(0x9ab5727f28c3d593, 0x1928030ad989ad02, 33, 514, 925), //186 187
    new NestHashDetail(0x75319113c8c3b924, 0x314acb827c75109, 33, 461, 925), //172 173
    new NestHashDetail(0xe234e939402a736b, 0x3b3c0865d15b0aca, 33, 598, 936), //164 165
    new NestHashDetail(0x7ea57d4a1ef4c796, 0xe0236c3b91edbebb, 34, 443, 1088), //188 189
    new NestHashDetail(0x3a41c5c485d3edee, 0x6c364ecc3616af63, 34, 550, 1088), //160 161
    new NestHashDetail(0x52a7dfe87897d15d, 0xc88b8a5990a8ea5c, 34, 811, 1048), //174 175
    new NestHashDetail(0xf01dfb231a467c06, 0x8b5a3178ae3f236b, 34, 817, 974), //192 193
    new NestHashDetail(0x2640fa844b19c3cf, 0x422f95fb66a95706, 34, 921, 996), //158 159
    new NestHashDetail(0xf6389ad0bc9aaeb, 0x277effbe0b116e4a, 34, 889, 1048), //162 163
    new NestHashDetail(0x3d2f6b02fc6dd797, 0xf9d3242b837d627e, 34, 993, 971), //184 185
    new NestHashDetail(0x75319113c8c3b924, 0x314acb827c75109, 34, 1082, 974), //172 173
    new NestHashDetail(0x779e9eb99c1292c, 0x93a637943a964e41, 34, 1566, 1015), //166 167
    new NestHashDetail(0x55e4467f01ec60bb, 0xa5696e4aa8d625a, 34, 642, 1067), //180 181
    new NestHashDetail(0x52a7dfe87897d15d, 0xc88b8a5990a8ea5c, 34, 675, 1197), //174 175 tbc
    new NestHashDetail(0x9ab5727f28c3d593, 0x1928030ad989ad02, 34, 761, 1086), //186 187
    new NestHashDetail(0xc862667fc72ee059, 0x72f9d87337338120, 34, 1450, 1175), //190 191
    new NestHashDetail(0x55e4467f01ec60bb, 0xa5696e4aa8d625a, 34, 1628, 1162), //180 181
    new NestHashDetail(0x685dad2aaedbca48, 0x12ad4e9a799417a5, 34, 969, 988), //170 171 tbc
    new NestHashDetail(0xf6389ad0bc9aaeb, 0x277effbe0b116e4a, 34, 975, 1284), //162 163
    new NestHashDetail(0x685dad2aaedbca48, 0x12ad4e9a799417a5, 34, 788, 1284), //170 171 tbc
    new NestHashDetail(0x17d327792698d15f, 0xb20a5ed251cd0456, 34, 1480, 1121), //178 179
    new NestHashDetail(0xe234e939402a736b, 0x3b3c0865d15b0aca, 34, 1399, 1205), //164 165
    new NestHashDetail(0x3a41c5c485d3edee, 0x6c364ecc3616af63, 34, 1423, 1102), //160 161
    new NestHashDetail(0x42b21efc37c7b974, 0x9d415f6a7a841dd9, 34, 1542, 1254), //176 177

    new NestHashDetail(0x47a5d8b98dd573ab, 0xa23ec426e4e9430a, 35, 856, 1135), //182 183
    new NestHashDetail(0xf01dfb231a467c06, 0x8b5a3178ae3f236b, 35, 969, 1129), //192 193

    new NestHashDetail(0x55e4467f01ec60bb, 0xa5696e4aa8d625a, 36, 1581, 914), //180 181
    new NestHashDetail(0x75319113c8c3b924, 0x314acb827c75109, 36, 1462,  827), //172 173
    new NestHashDetail(0x7ea57d4a1ef4c796, 0xe0236c3b91edbebb, 36, 1426, 637), //188 189
    new NestHashDetail(0x17d327792698d15f, 0xb20a5ed251cd0456, 36, 1310, 558), //178 179
    new NestHashDetail(0x9ab5727f28c3d593, 0x1928030ad989ad02, 36, 1263, 773), //186 187
    new NestHashDetail(0x685db02aaedbcf61, 0x2cd8cf9a88739f98, 36, 1328, 669), //168 169
    new NestHashDetail(0xc862667fc72ee059, 0x72f9d87337338120, 36, 1221, 683), //190 191
    new NestHashDetail(0x3a41c5c485d3edee, 0x6c364ecc3616af63, 36, 1379, 558), //160 161
    new NestHashDetail(0x58c3011eda59ea53, 0xb4dbd8428706d1c2, 36, 1539, 585), //196 197

    new NestHashDetail(0x7ea57d4a1ef4c796, 0xe0236c3b91edbebb, 37, 1444, 299), //188 189
    new NestHashDetail(0x3d2f6b02fc6dd797, 0xf9d3242b837d627e, 37, 1474, 329), //184 185
    new NestHashDetail(0x17d327792698d15f, 0xb20a5ed251cd0456, 37, 1402, 299), //178 179

    new NestHashDetail(0x779e9eb99c1292c, 0x93a637943a964e41, 38, 1325, 237), //166 167

    new NestHashDetail(0x2640fa844b19c3cf, 0x422f95fb66a95706, 39, 1604, 1058), //158 159
    new NestHashDetail(0xf6389ad0bc9aaeb, 0x277effbe0b116e4a, 39, 1634, 1056), //162 163
    new NestHashDetail(0x9ab5727f28c3d593, 0x1928030ad989ad02, 39, 1720, 1075), //186 187
    new NestHashDetail(0x779e9eb99c1292c, 0x93a637943a964e41, 39, 1655, 999), //166 167
    new NestHashDetail(0x47a5d8b98dd573ab, 0xa23ec426e4e9430a, 39, 1711, 1042), //182 183

    new NestHashDetail(0x685dad2aaedbca48, 0x12ad4e9a799417a5, 40, 2207, 862), //170 171 tbc
    new NestHashDetail(0x3d2f6b02fc6dd797, 0xf9d3242b837d627e, 40, 2201, 716), //184 185
    new NestHashDetail(0xf6389ad0bc9aaeb, 0x277effbe0b116e4a, 40, 2525,  637), //162 163
    new NestHashDetail(0x75319113c8c3b924, 0x314acb827c75109, 40, 2579,  849), //172 173
    new NestHashDetail(0x7ea57d4a1ef4c796, 0xe0236c3b91edbebb, 40, 2579, 762), //188 189
    new NestHashDetail(0x685dad2aaedbca48, 0x12ad4e9a799417a5, 40, 2599, 669), //170 171 tbc
    new NestHashDetail(0x52a7dfe87897d15d, 0xc88b8a5990a8ea5c, 40, 2460, 865), //174 175
    new NestHashDetail(0x47a5d8b98dd573ab, 0xa23ec426e4e9430a, 40, 2632, 634), //182 183
    new NestHashDetail(0x9ab5727f28c3d593, 0x1928030ad989ad02, 40, 2466, 767), //186 187
    new NestHashDetail(0xc862667fc72ee059, 0x72f9d87337338120, 40, 2489, 686), //190 191
    new NestHashDetail(0x685db02aaedbcf61, 0x2cd8cf9a88739f98, 40, 2665, 718), //168 169
    new NestHashDetail(0xe234e939402a736b, 0x3b3c0865d15b0aca, 40, 2614, 599), //164 165
    new NestHashDetail(0x42b21efc37c7b974, 0x9d415f6a7a841dd9, 40, 2442, 620), //176 177
    new NestHashDetail(0x685dad2aaedbca48, 0x12ad4e9a799417a5, 40, 2602, 914), //170 171

    new NestHashDetail(0x3d2f6b02fc6dd797, 0xf9d3242b837d627e, 41, 2293, 933), //184 185
    new NestHashDetail(0xe234e939402a736b, 0x3b3c0865d15b0aca, 41, 2320, 963), //164 165

    new NestHashDetail(0x2640fa844b19c3cf, 0x422f95fb66a95706, 42, 871, 1317), //158 159
    new NestHashDetail(0x42b21efc37c7b974, 0x9d415f6a7a841dd9, 42, 1254, 1418), //176 177
    new NestHashDetail(0x52a7dfe87897d15d, 0xc88b8a5990a8ea5c, 42, 1361, 1412), //174 175 tbc
    new NestHashDetail(0x55e4467f01ec60bb, 0xa5696e4aa8d625a, 42, 1468, 1412), //180 181
    new NestHashDetail(0x3a41c5c485d3edee, 0x6c364ecc3616af63, 42, 1515, 1404), //160 161 tbc
    new NestHashDetail(0x3a41c5c485d3edee, 0x6c364ecc3616af63, 42, 1598, 1646), //160 161 tbc
    new NestHashDetail(0x779e9eb99c1292c, 0x93a637943a964e41, 42, 1679, 1526), //166 167
    new NestHashDetail(0x52a7dfe87897d15d, 0xc88b8a5990a8ea5c, 42, 1432, 1641), //174 175 tbc
    new NestHashDetail(0xe234e939402a736b, 0x3b3c0865d15b0aca, 42, 1379, 1662), //164 165
    new NestHashDetail(0x75319113c8c3b924, 0x314acb827c75109, 42, 811, 1665), //172 173
    new NestHashDetail(0xe78d0a25d0c67a32, 0xbdf065bb6332909f, 42, 681, 1641), //194 195
    new NestHashDetail(0xf01dfb231a467c06, 0x8b5a3178ae3f236b, 42, 761, 1627), //192 193
    new NestHashDetail(0xc862667fc72ee059, 0x72f9d87337338120, 42, 773, 1575), //190 191
    new NestHashDetail(0xf6389ad0bc9aaeb, 0x277effbe0b116e4a, 42, 1462, 1578), //162 163
    new NestHashDetail(0x17d327792698d15f, 0xb20a5ed251cd0456, 42, 1319, 1608), //178 179
    new NestHashDetail(0x47a5d8b98dd573ab, 0xa23ec426e4e9430a, 42, 1290, 1456), //182 183
    new NestHashDetail(0x3d2f6b02fc6dd797, 0xf9d3242b837d627e, 42, 1462, 1472), //184 185

    new NestHashDetail(0x42b21efc37c7b974, 0x9d415f6a7a841dd9, 43, 993, 1565), //176 177
  ];

  internal static ulong GetEventHash(RaidParameters raidParameters) {
    if (raidParameters.Index >= PKHeX.Core.RaidSpawnList8.RaidCountLegal_O0 + PKHeX.Core.RaidSpawnList8.RaidCountLegal_R1) return EventHash_Rigel2;
    if (raidParameters.Index >= PKHeX.Core.RaidSpawnList8.RaidCountLegal_O0) return EventHash_Rigel1;
    return EventHash;
  }
}
