using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(StringEnumSerializer<Carc>))]
public enum Carc
{
    [EnumMember(Value = "1")]
    Carc1,

    [EnumMember(Value = "2")]
    Carc2,

    [EnumMember(Value = "3")]
    Carc3,

    [EnumMember(Value = "4")]
    Carc4,

    [EnumMember(Value = "5")]
    Carc5,

    [EnumMember(Value = "6")]
    Carc6,

    [EnumMember(Value = "7")]
    Carc7,

    [EnumMember(Value = "8")]
    Carc8,

    [EnumMember(Value = "9")]
    Carc9,

    [EnumMember(Value = "10")]
    Carc10,

    [EnumMember(Value = "11")]
    Carc11,

    [EnumMember(Value = "12")]
    Carc12,

    [EnumMember(Value = "13")]
    Carc13,

    [EnumMember(Value = "14")]
    Carc14,

    [EnumMember(Value = "16")]
    Carc16,

    [EnumMember(Value = "18")]
    Carc18,

    [EnumMember(Value = "19")]
    Carc19,

    [EnumMember(Value = "20")]
    Carc20,

    [EnumMember(Value = "21")]
    Carc21,

    [EnumMember(Value = "22")]
    Carc22,

    [EnumMember(Value = "23")]
    Carc23,

    [EnumMember(Value = "24")]
    Carc24,

    [EnumMember(Value = "26")]
    Carc26,

    [EnumMember(Value = "27")]
    Carc27,

    [EnumMember(Value = "29")]
    Carc29,

    [EnumMember(Value = "31")]
    Carc31,

    [EnumMember(Value = "32")]
    Carc32,

    [EnumMember(Value = "33")]
    Carc33,

    [EnumMember(Value = "34")]
    Carc34,

    [EnumMember(Value = "35")]
    Carc35,

    [EnumMember(Value = "39")]
    Carc39,

    [EnumMember(Value = "40")]
    Carc40,

    [EnumMember(Value = "44")]
    Carc44,

    [EnumMember(Value = "45")]
    Carc45,

    [EnumMember(Value = "49")]
    Carc49,

    [EnumMember(Value = "50")]
    Carc50,

    [EnumMember(Value = "51")]
    Carc51,

    [EnumMember(Value = "53")]
    Carc53,

    [EnumMember(Value = "54")]
    Carc54,

    [EnumMember(Value = "55")]
    Carc55,

    [EnumMember(Value = "56")]
    Carc56,

    [EnumMember(Value = "58")]
    Carc58,

    [EnumMember(Value = "59")]
    Carc59,

    [EnumMember(Value = "60")]
    Carc60,

    [EnumMember(Value = "61")]
    Carc61,

    [EnumMember(Value = "66")]
    Carc66,

    [EnumMember(Value = "69")]
    Carc69,

    [EnumMember(Value = "70")]
    Carc70,

    [EnumMember(Value = "74")]
    Carc74,

    [EnumMember(Value = "75")]
    Carc75,

    [EnumMember(Value = "76")]
    Carc76,

    [EnumMember(Value = "78")]
    Carc78,

    [EnumMember(Value = "85")]
    Carc85,

    [EnumMember(Value = "89")]
    Carc89,

    [EnumMember(Value = "90")]
    Carc90,

    [EnumMember(Value = "91")]
    Carc91,

    [EnumMember(Value = "94")]
    Carc94,

    [EnumMember(Value = "95")]
    Carc95,

    [EnumMember(Value = "96")]
    Carc96,

    [EnumMember(Value = "97")]
    Carc97,

    [EnumMember(Value = "100")]
    Carc100,

    [EnumMember(Value = "101")]
    Carc101,

    [EnumMember(Value = "102")]
    Carc102,

    [EnumMember(Value = "103")]
    Carc103,

    [EnumMember(Value = "104")]
    Carc104,

    [EnumMember(Value = "105")]
    Carc105,

    [EnumMember(Value = "106")]
    Carc106,

    [EnumMember(Value = "107")]
    Carc107,

    [EnumMember(Value = "108")]
    Carc108,

    [EnumMember(Value = "109")]
    Carc109,

    [EnumMember(Value = "110")]
    Carc110,

    [EnumMember(Value = "111")]
    Carc111,

    [EnumMember(Value = "112")]
    Carc112,

    [EnumMember(Value = "114")]
    Carc114,

    [EnumMember(Value = "115")]
    Carc115,

    [EnumMember(Value = "116")]
    Carc116,

    [EnumMember(Value = "117")]
    Carc117,

    [EnumMember(Value = "118")]
    Carc118,

    [EnumMember(Value = "119")]
    Carc119,

    [EnumMember(Value = "121")]
    Carc121,

    [EnumMember(Value = "122")]
    Carc122,

    [EnumMember(Value = "125")]
    Carc125,

    [EnumMember(Value = "128")]
    Carc128,

    [EnumMember(Value = "129")]
    Carc129,

    [EnumMember(Value = "130")]
    Carc130,

    [EnumMember(Value = "131")]
    Carc131,

    [EnumMember(Value = "132")]
    Carc132,

    [EnumMember(Value = "133")]
    Carc133,

    [EnumMember(Value = "134")]
    Carc134,

    [EnumMember(Value = "135")]
    Carc135,

    [EnumMember(Value = "136")]
    Carc136,

    [EnumMember(Value = "137")]
    Carc137,

    [EnumMember(Value = "139")]
    Carc139,

    [EnumMember(Value = "140")]
    Carc140,

    [EnumMember(Value = "142")]
    Carc142,

    [EnumMember(Value = "143")]
    Carc143,

    [EnumMember(Value = "144")]
    Carc144,

    [EnumMember(Value = "146")]
    Carc146,

    [EnumMember(Value = "147")]
    Carc147,

    [EnumMember(Value = "148")]
    Carc148,

    [EnumMember(Value = "149")]
    Carc149,

    [EnumMember(Value = "150")]
    Carc150,

    [EnumMember(Value = "151")]
    Carc151,

    [EnumMember(Value = "152")]
    Carc152,

    [EnumMember(Value = "153")]
    Carc153,

    [EnumMember(Value = "154")]
    Carc154,

    [EnumMember(Value = "155")]
    Carc155,

    [EnumMember(Value = "157")]
    Carc157,

    [EnumMember(Value = "158")]
    Carc158,

    [EnumMember(Value = "159")]
    Carc159,

    [EnumMember(Value = "160")]
    Carc160,

    [EnumMember(Value = "161")]
    Carc161,

    [EnumMember(Value = "163")]
    Carc163,

    [EnumMember(Value = "164")]
    Carc164,

    [EnumMember(Value = "166")]
    Carc166,

    [EnumMember(Value = "167")]
    Carc167,

    [EnumMember(Value = "169")]
    Carc169,

    [EnumMember(Value = "170")]
    Carc170,

    [EnumMember(Value = "171")]
    Carc171,

    [EnumMember(Value = "172")]
    Carc172,

    [EnumMember(Value = "173")]
    Carc173,

    [EnumMember(Value = "174")]
    Carc174,

    [EnumMember(Value = "175")]
    Carc175,

    [EnumMember(Value = "176")]
    Carc176,

    [EnumMember(Value = "177")]
    Carc177,

    [EnumMember(Value = "178")]
    Carc178,

    [EnumMember(Value = "179")]
    Carc179,

    [EnumMember(Value = "180")]
    Carc180,

    [EnumMember(Value = "181")]
    Carc181,

    [EnumMember(Value = "182")]
    Carc182,

    [EnumMember(Value = "183")]
    Carc183,

    [EnumMember(Value = "184")]
    Carc184,

    [EnumMember(Value = "185")]
    Carc185,

    [EnumMember(Value = "186")]
    Carc186,

    [EnumMember(Value = "187")]
    Carc187,

    [EnumMember(Value = "188")]
    Carc188,

    [EnumMember(Value = "189")]
    Carc189,

    [EnumMember(Value = "190")]
    Carc190,

    [EnumMember(Value = "192")]
    Carc192,

    [EnumMember(Value = "193")]
    Carc193,

    [EnumMember(Value = "194")]
    Carc194,

    [EnumMember(Value = "195")]
    Carc195,

    [EnumMember(Value = "197")]
    Carc197,

    [EnumMember(Value = "198")]
    Carc198,

    [EnumMember(Value = "199")]
    Carc199,

    [EnumMember(Value = "200")]
    Carc200,

    [EnumMember(Value = "201")]
    Carc201,

    [EnumMember(Value = "202")]
    Carc202,

    [EnumMember(Value = "203")]
    Carc203,

    [EnumMember(Value = "204")]
    Carc204,

    [EnumMember(Value = "205")]
    Carc205,

    [EnumMember(Value = "206")]
    Carc206,

    [EnumMember(Value = "207")]
    Carc207,

    [EnumMember(Value = "208")]
    Carc208,

    [EnumMember(Value = "209")]
    Carc209,

    [EnumMember(Value = "210")]
    Carc210,

    [EnumMember(Value = "211")]
    Carc211,

    [EnumMember(Value = "212")]
    Carc212,

    [EnumMember(Value = "213")]
    Carc213,

    [EnumMember(Value = "215")]
    Carc215,

    [EnumMember(Value = "216")]
    Carc216,

    [EnumMember(Value = "219")]
    Carc219,

    [EnumMember(Value = "222")]
    Carc222,

    [EnumMember(Value = "223")]
    Carc223,

    [EnumMember(Value = "224")]
    Carc224,

    [EnumMember(Value = "225")]
    Carc225,

    [EnumMember(Value = "226")]
    Carc226,

    [EnumMember(Value = "227")]
    Carc227,

    [EnumMember(Value = "228")]
    Carc228,

    [EnumMember(Value = "229")]
    Carc229,

    [EnumMember(Value = "231")]
    Carc231,

    [EnumMember(Value = "232")]
    Carc232,

    [EnumMember(Value = "233")]
    Carc233,

    [EnumMember(Value = "234")]
    Carc234,

    [EnumMember(Value = "235")]
    Carc235,

    [EnumMember(Value = "236")]
    Carc236,

    [EnumMember(Value = "237")]
    Carc237,

    [EnumMember(Value = "238")]
    Carc238,

    [EnumMember(Value = "239")]
    Carc239,

    [EnumMember(Value = "240")]
    Carc240,

    [EnumMember(Value = "241")]
    Carc241,

    [EnumMember(Value = "242")]
    Carc242,

    [EnumMember(Value = "243")]
    Carc243,

    [EnumMember(Value = "245")]
    Carc245,

    [EnumMember(Value = "246")]
    Carc246,

    [EnumMember(Value = "247")]
    Carc247,

    [EnumMember(Value = "248")]
    Carc248,

    [EnumMember(Value = "249")]
    Carc249,

    [EnumMember(Value = "250")]
    Carc250,

    [EnumMember(Value = "251")]
    Carc251,

    [EnumMember(Value = "252")]
    Carc252,

    [EnumMember(Value = "253")]
    Carc253,

    [EnumMember(Value = "254")]
    Carc254,

    [EnumMember(Value = "256")]
    Carc256,

    [EnumMember(Value = "257")]
    Carc257,

    [EnumMember(Value = "258")]
    Carc258,

    [EnumMember(Value = "259")]
    Carc259,

    [EnumMember(Value = "260")]
    Carc260,

    [EnumMember(Value = "261")]
    Carc261,

    [EnumMember(Value = "262")]
    Carc262,

    [EnumMember(Value = "263")]
    Carc263,

    [EnumMember(Value = "264")]
    Carc264,

    [EnumMember(Value = "265")]
    Carc265,

    [EnumMember(Value = "266")]
    Carc266,

    [EnumMember(Value = "267")]
    Carc267,

    [EnumMember(Value = "268")]
    Carc268,

    [EnumMember(Value = "269")]
    Carc269,

    [EnumMember(Value = "270")]
    Carc270,

    [EnumMember(Value = "271")]
    Carc271,

    [EnumMember(Value = "272")]
    Carc272,

    [EnumMember(Value = "273")]
    Carc273,

    [EnumMember(Value = "274")]
    Carc274,

    [EnumMember(Value = "275")]
    Carc275,

    [EnumMember(Value = "276")]
    Carc276,

    [EnumMember(Value = "277")]
    Carc277,

    [EnumMember(Value = "278")]
    Carc278,

    [EnumMember(Value = "279")]
    Carc279,

    [EnumMember(Value = "280")]
    Carc280,

    [EnumMember(Value = "281")]
    Carc281,

    [EnumMember(Value = "282")]
    Carc282,

    [EnumMember(Value = "283")]
    Carc283,

    [EnumMember(Value = "284")]
    Carc284,

    [EnumMember(Value = "285")]
    Carc285,

    [EnumMember(Value = "286")]
    Carc286,

    [EnumMember(Value = "287")]
    Carc287,

    [EnumMember(Value = "288")]
    Carc288,

    [EnumMember(Value = "289")]
    Carc289,

    [EnumMember(Value = "290")]
    Carc290,

    [EnumMember(Value = "291")]
    Carc291,

    [EnumMember(Value = "292")]
    Carc292,

    [EnumMember(Value = "293")]
    Carc293,

    [EnumMember(Value = "294")]
    Carc294,

    [EnumMember(Value = "295")]
    Carc295,

    [EnumMember(Value = "296")]
    Carc296,

    [EnumMember(Value = "297")]
    Carc297,

    [EnumMember(Value = "298")]
    Carc298,

    [EnumMember(Value = "299")]
    Carc299,

    [EnumMember(Value = "300")]
    Carc300,

    [EnumMember(Value = "301")]
    Carc301,

    [EnumMember(Value = "302")]
    Carc302,

    [EnumMember(Value = "303")]
    Carc303,

    [EnumMember(Value = "304")]
    Carc304,

    [EnumMember(Value = "305")]
    Carc305,

    [EnumMember(Value = "A0")]
    CarcA0,

    [EnumMember(Value = "A1")]
    CarcA1,

    [EnumMember(Value = "A5")]
    CarcA5,

    [EnumMember(Value = "A6")]
    CarcA6,

    [EnumMember(Value = "A8")]
    CarcA8,

    [EnumMember(Value = "B1")]
    CarcB1,

    [EnumMember(Value = "B4")]
    CarcB4,

    [EnumMember(Value = "B7")]
    CarcB7,

    [EnumMember(Value = "B8")]
    CarcB8,

    [EnumMember(Value = "B9")]
    CarcB9,

    [EnumMember(Value = "B10")]
    CarcB10,

    [EnumMember(Value = "B11")]
    CarcB11,

    [EnumMember(Value = "B12")]
    CarcB12,

    [EnumMember(Value = "B13")]
    CarcB13,

    [EnumMember(Value = "B14")]
    CarcB14,

    [EnumMember(Value = "B15")]
    CarcB15,

    [EnumMember(Value = "B16")]
    CarcB16,

    [EnumMember(Value = "B20")]
    CarcB20,

    [EnumMember(Value = "B22")]
    CarcB22,

    [EnumMember(Value = "B23")]
    CarcB23,

    [EnumMember(Value = "P1")]
    CarcP1,

    [EnumMember(Value = "P2")]
    CarcP2,

    [EnumMember(Value = "P3")]
    CarcP3,

    [EnumMember(Value = "P4")]
    CarcP4,

    [EnumMember(Value = "P5")]
    CarcP5,

    [EnumMember(Value = "P6")]
    CarcP6,

    [EnumMember(Value = "P7")]
    CarcP7,

    [EnumMember(Value = "P8")]
    CarcP8,

    [EnumMember(Value = "P9")]
    CarcP9,

    [EnumMember(Value = "P10")]
    CarcP10,

    [EnumMember(Value = "P11")]
    CarcP11,

    [EnumMember(Value = "P12")]
    CarcP12,

    [EnumMember(Value = "P13")]
    CarcP13,

    [EnumMember(Value = "P14")]
    CarcP14,

    [EnumMember(Value = "P15")]
    CarcP15,

    [EnumMember(Value = "P16")]
    CarcP16,

    [EnumMember(Value = "P17")]
    CarcP17,

    [EnumMember(Value = "P18")]
    CarcP18,

    [EnumMember(Value = "P19")]
    CarcP19,

    [EnumMember(Value = "P20")]
    CarcP20,

    [EnumMember(Value = "P21")]
    CarcP21,

    [EnumMember(Value = "P22")]
    CarcP22,

    [EnumMember(Value = "P23")]
    CarcP23,

    [EnumMember(Value = "P24")]
    CarcP24,

    [EnumMember(Value = "P25")]
    CarcP25,

    [EnumMember(Value = "P26")]
    CarcP26,

    [EnumMember(Value = "P27")]
    CarcP27,

    [EnumMember(Value = "P28")]
    CarcP28,

    [EnumMember(Value = "P29")]
    CarcP29,

    [EnumMember(Value = "P30")]
    CarcP30,

    [EnumMember(Value = "P31")]
    CarcP31,

    [EnumMember(Value = "P32")]
    CarcP32,

    [EnumMember(Value = "17")]
    Carc17,

    [EnumMember(Value = "25")]
    Carc25,

    [EnumMember(Value = "28")]
    Carc28,

    [EnumMember(Value = "30")]
    Carc30,

    [EnumMember(Value = "36")]
    Carc36,

    [EnumMember(Value = "37")]
    Carc37,

    [EnumMember(Value = "38")]
    Carc38,

    [EnumMember(Value = "41")]
    Carc41,

    [EnumMember(Value = "42")]
    Carc42,

    [EnumMember(Value = "43")]
    Carc43,

    [EnumMember(Value = "46")]
    Carc46,

    [EnumMember(Value = "47")]
    Carc47,

    [EnumMember(Value = "48")]
    Carc48,

    [EnumMember(Value = "52")]
    Carc52,

    [EnumMember(Value = "57")]
    Carc57,

    [EnumMember(Value = "62")]
    Carc62,

    [EnumMember(Value = "63")]
    Carc63,

    [EnumMember(Value = "64")]
    Carc64,

    [EnumMember(Value = "65")]
    Carc65,

    [EnumMember(Value = "67")]
    Carc67,

    [EnumMember(Value = "68")]
    Carc68,

    [EnumMember(Value = "71")]
    Carc71,

    [EnumMember(Value = "72")]
    Carc72,

    [EnumMember(Value = "73")]
    Carc73,

    [EnumMember(Value = "77")]
    Carc77,

    [EnumMember(Value = "79")]
    Carc79,

    [EnumMember(Value = "80")]
    Carc80,

    [EnumMember(Value = "81")]
    Carc81,

    [EnumMember(Value = "82")]
    Carc82,

    [EnumMember(Value = "83")]
    Carc83,

    [EnumMember(Value = "84")]
    Carc84,

    [EnumMember(Value = "86")]
    Carc86,

    [EnumMember(Value = "87")]
    Carc87,

    [EnumMember(Value = "88")]
    Carc88,

    [EnumMember(Value = "92")]
    Carc92,

    [EnumMember(Value = "93")]
    Carc93,

    [EnumMember(Value = "98")]
    Carc98,

    [EnumMember(Value = "99")]
    Carc99,

    [EnumMember(Value = "113")]
    Carc113,

    [EnumMember(Value = "120")]
    Carc120,

    [EnumMember(Value = "123")]
    Carc123,

    [EnumMember(Value = "124")]
    Carc124,

    [EnumMember(Value = "126")]
    Carc126,

    [EnumMember(Value = "127")]
    Carc127,

    [EnumMember(Value = "138")]
    Carc138,

    [EnumMember(Value = "141")]
    Carc141,

    [EnumMember(Value = "145")]
    Carc145,

    [EnumMember(Value = "156")]
    Carc156,

    [EnumMember(Value = "162")]
    Carc162,

    [EnumMember(Value = "165")]
    Carc165,

    [EnumMember(Value = "168")]
    Carc168,

    [EnumMember(Value = "191")]
    Carc191,

    [EnumMember(Value = "196")]
    Carc196,

    [EnumMember(Value = "214")]
    Carc214,

    [EnumMember(Value = "217")]
    Carc217,

    [EnumMember(Value = "218")]
    Carc218,

    [EnumMember(Value = "220")]
    Carc220,

    [EnumMember(Value = "221")]
    Carc221,

    [EnumMember(Value = "230")]
    Carc230,

    [EnumMember(Value = "244")]
    Carc244,

    [EnumMember(Value = "255")]
    Carc255,

    [EnumMember(Value = "A2")]
    CarcA2,

    [EnumMember(Value = "A3")]
    CarcA3,

    [EnumMember(Value = "A4")]
    CarcA4,

    [EnumMember(Value = "A7")]
    CarcA7,

    [EnumMember(Value = "B2")]
    CarcB2,

    [EnumMember(Value = "B3")]
    CarcB3,

    [EnumMember(Value = "B5")]
    CarcB5,

    [EnumMember(Value = "B6")]
    CarcB6,

    [EnumMember(Value = "B17")]
    CarcB17,

    [EnumMember(Value = "B18")]
    CarcB18,

    [EnumMember(Value = "B19")]
    CarcB19,

    [EnumMember(Value = "B21")]
    CarcB21,

    [EnumMember(Value = "D1")]
    CarcD1,

    [EnumMember(Value = "D2")]
    CarcD2,

    [EnumMember(Value = "D3")]
    CarcD3,

    [EnumMember(Value = "D4")]
    CarcD4,

    [EnumMember(Value = "D5")]
    CarcD5,

    [EnumMember(Value = "D6")]
    CarcD6,

    [EnumMember(Value = "D7")]
    CarcD7,

    [EnumMember(Value = "D8")]
    CarcD8,

    [EnumMember(Value = "D9")]
    CarcD9,

    [EnumMember(Value = "D10")]
    CarcD10,

    [EnumMember(Value = "D11")]
    CarcD11,

    [EnumMember(Value = "D12")]
    CarcD12,

    [EnumMember(Value = "D14")]
    CarcD14,

    [EnumMember(Value = "D15")]
    CarcD15,

    [EnumMember(Value = "D16")]
    CarcD16,

    [EnumMember(Value = "D17")]
    CarcD17,

    [EnumMember(Value = "D18")]
    CarcD18,

    [EnumMember(Value = "D19")]
    CarcD19,

    [EnumMember(Value = "D20")]
    CarcD20,

    [EnumMember(Value = "D21")]
    CarcD21,

    [EnumMember(Value = "D22")]
    CarcD22,

    [EnumMember(Value = "D23")]
    CarcD23,

    [EnumMember(Value = "W1")]
    CarcW1,

    [EnumMember(Value = "W2")]
    CarcW2,

    [EnumMember(Value = "W3")]
    CarcW3,

    [EnumMember(Value = "W4")]
    CarcW4,

    [EnumMember(Value = "W5")]
    CarcW5,

    [EnumMember(Value = "W6")]
    CarcW6,

    [EnumMember(Value = "W7")]
    CarcW7,

    [EnumMember(Value = "W8")]
    CarcW8,

    [EnumMember(Value = "W9")]
    CarcW9,

    [EnumMember(Value = "Y1")]
    CarcY1,

    [EnumMember(Value = "Y2")]
    CarcY2,

    [EnumMember(Value = "Y3")]
    CarcY3,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,
}
