using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(StringEnumSerializer<Rarc>))]
[Serializable]
public readonly record struct Rarc : IStringEnum
{
    public static readonly Rarc M1 = new(Values.M1);

    public static readonly Rarc M2 = new(Values.M2);

    public static readonly Rarc M3 = new(Values.M3);

    public static readonly Rarc M4 = new(Values.M4);

    public static readonly Rarc M5 = new(Values.M5);

    public static readonly Rarc M6 = new(Values.M6);

    public static readonly Rarc M7 = new(Values.M7);

    public static readonly Rarc M8 = new(Values.M8);

    public static readonly Rarc M9 = new(Values.M9);

    public static readonly Rarc M10 = new(Values.M10);

    public static readonly Rarc M11 = new(Values.M11);

    public static readonly Rarc M12 = new(Values.M12);

    public static readonly Rarc M13 = new(Values.M13);

    public static readonly Rarc M14 = new(Values.M14);

    public static readonly Rarc M15 = new(Values.M15);

    public static readonly Rarc M16 = new(Values.M16);

    public static readonly Rarc M17 = new(Values.M17);

    public static readonly Rarc M18 = new(Values.M18);

    public static readonly Rarc M19 = new(Values.M19);

    public static readonly Rarc M20 = new(Values.M20);

    public static readonly Rarc M21 = new(Values.M21);

    public static readonly Rarc M22 = new(Values.M22);

    public static readonly Rarc M23 = new(Values.M23);

    public static readonly Rarc M24 = new(Values.M24);

    public static readonly Rarc M25 = new(Values.M25);

    public static readonly Rarc M26 = new(Values.M26);

    public static readonly Rarc M27 = new(Values.M27);

    public static readonly Rarc M28 = new(Values.M28);

    public static readonly Rarc M29 = new(Values.M29);

    public static readonly Rarc M30 = new(Values.M30);

    public static readonly Rarc M31 = new(Values.M31);

    public static readonly Rarc M32 = new(Values.M32);

    public static readonly Rarc M33 = new(Values.M33);

    public static readonly Rarc M34 = new(Values.M34);

    public static readonly Rarc M35 = new(Values.M35);

    public static readonly Rarc M36 = new(Values.M36);

    public static readonly Rarc M37 = new(Values.M37);

    public static readonly Rarc M38 = new(Values.M38);

    public static readonly Rarc M39 = new(Values.M39);

    public static readonly Rarc M40 = new(Values.M40);

    public static readonly Rarc M41 = new(Values.M41);

    public static readonly Rarc M42 = new(Values.M42);

    public static readonly Rarc M43 = new(Values.M43);

    public static readonly Rarc M44 = new(Values.M44);

    public static readonly Rarc M45 = new(Values.M45);

    public static readonly Rarc M46 = new(Values.M46);

    public static readonly Rarc M47 = new(Values.M47);

    public static readonly Rarc M48 = new(Values.M48);

    public static readonly Rarc M49 = new(Values.M49);

    public static readonly Rarc M50 = new(Values.M50);

    public static readonly Rarc M51 = new(Values.M51);

    public static readonly Rarc M52 = new(Values.M52);

    public static readonly Rarc M53 = new(Values.M53);

    public static readonly Rarc M54 = new(Values.M54);

    public static readonly Rarc M55 = new(Values.M55);

    public static readonly Rarc M56 = new(Values.M56);

    public static readonly Rarc M57 = new(Values.M57);

    public static readonly Rarc M58 = new(Values.M58);

    public static readonly Rarc M59 = new(Values.M59);

    public static readonly Rarc M60 = new(Values.M60);

    public static readonly Rarc M61 = new(Values.M61);

    public static readonly Rarc M62 = new(Values.M62);

    public static readonly Rarc M63 = new(Values.M63);

    public static readonly Rarc M64 = new(Values.M64);

    public static readonly Rarc M65 = new(Values.M65);

    public static readonly Rarc M66 = new(Values.M66);

    public static readonly Rarc M67 = new(Values.M67);

    public static readonly Rarc M68 = new(Values.M68);

    public static readonly Rarc M69 = new(Values.M69);

    public static readonly Rarc M70 = new(Values.M70);

    public static readonly Rarc M71 = new(Values.M71);

    public static readonly Rarc M72 = new(Values.M72);

    public static readonly Rarc M73 = new(Values.M73);

    public static readonly Rarc M74 = new(Values.M74);

    public static readonly Rarc M75 = new(Values.M75);

    public static readonly Rarc M76 = new(Values.M76);

    public static readonly Rarc M77 = new(Values.M77);

    public static readonly Rarc M78 = new(Values.M78);

    public static readonly Rarc M79 = new(Values.M79);

    public static readonly Rarc M80 = new(Values.M80);

    public static readonly Rarc M81 = new(Values.M81);

    public static readonly Rarc M82 = new(Values.M82);

    public static readonly Rarc M83 = new(Values.M83);

    public static readonly Rarc M84 = new(Values.M84);

    public static readonly Rarc M85 = new(Values.M85);

    public static readonly Rarc M86 = new(Values.M86);

    public static readonly Rarc M87 = new(Values.M87);

    public static readonly Rarc M88 = new(Values.M88);

    public static readonly Rarc M89 = new(Values.M89);

    public static readonly Rarc M90 = new(Values.M90);

    public static readonly Rarc M91 = new(Values.M91);

    public static readonly Rarc M92 = new(Values.M92);

    public static readonly Rarc M93 = new(Values.M93);

    public static readonly Rarc M94 = new(Values.M94);

    public static readonly Rarc M95 = new(Values.M95);

    public static readonly Rarc M96 = new(Values.M96);

    public static readonly Rarc M97 = new(Values.M97);

    public static readonly Rarc M98 = new(Values.M98);

    public static readonly Rarc M99 = new(Values.M99);

    public static readonly Rarc M100 = new(Values.M100);

    public static readonly Rarc M101 = new(Values.M101);

    public static readonly Rarc M102 = new(Values.M102);

    public static readonly Rarc M103 = new(Values.M103);

    public static readonly Rarc M104 = new(Values.M104);

    public static readonly Rarc M105 = new(Values.M105);

    public static readonly Rarc M106 = new(Values.M106);

    public static readonly Rarc M107 = new(Values.M107);

    public static readonly Rarc M108 = new(Values.M108);

    public static readonly Rarc M109 = new(Values.M109);

    public static readonly Rarc M110 = new(Values.M110);

    public static readonly Rarc M111 = new(Values.M111);

    public static readonly Rarc M112 = new(Values.M112);

    public static readonly Rarc M113 = new(Values.M113);

    public static readonly Rarc M114 = new(Values.M114);

    public static readonly Rarc M115 = new(Values.M115);

    public static readonly Rarc M116 = new(Values.M116);

    public static readonly Rarc M117 = new(Values.M117);

    public static readonly Rarc M118 = new(Values.M118);

    public static readonly Rarc M119 = new(Values.M119);

    public static readonly Rarc M120 = new(Values.M120);

    public static readonly Rarc M121 = new(Values.M121);

    public static readonly Rarc M122 = new(Values.M122);

    public static readonly Rarc M123 = new(Values.M123);

    public static readonly Rarc M124 = new(Values.M124);

    public static readonly Rarc M125 = new(Values.M125);

    public static readonly Rarc M126 = new(Values.M126);

    public static readonly Rarc M127 = new(Values.M127);

    public static readonly Rarc M128 = new(Values.M128);

    public static readonly Rarc M129 = new(Values.M129);

    public static readonly Rarc M130 = new(Values.M130);

    public static readonly Rarc M131 = new(Values.M131);

    public static readonly Rarc M132 = new(Values.M132);

    public static readonly Rarc M133 = new(Values.M133);

    public static readonly Rarc M134 = new(Values.M134);

    public static readonly Rarc M135 = new(Values.M135);

    public static readonly Rarc M136 = new(Values.M136);

    public static readonly Rarc M137 = new(Values.M137);

    public static readonly Rarc M138 = new(Values.M138);

    public static readonly Rarc M139 = new(Values.M139);

    public static readonly Rarc M140 = new(Values.M140);

    public static readonly Rarc M141 = new(Values.M141);

    public static readonly Rarc M142 = new(Values.M142);

    public static readonly Rarc M143 = new(Values.M143);

    public static readonly Rarc M144 = new(Values.M144);

    public static readonly Rarc Ma01 = new(Values.Ma01);

    public static readonly Rarc Ma02 = new(Values.Ma02);

    public static readonly Rarc Ma03 = new(Values.Ma03);

    public static readonly Rarc Ma04 = new(Values.Ma04);

    public static readonly Rarc Ma05 = new(Values.Ma05);

    public static readonly Rarc Ma06 = new(Values.Ma06);

    public static readonly Rarc Ma07 = new(Values.Ma07);

    public static readonly Rarc Ma08 = new(Values.Ma08);

    public static readonly Rarc Ma09 = new(Values.Ma09);

    public static readonly Rarc Ma10 = new(Values.Ma10);

    public static readonly Rarc Ma11 = new(Values.Ma11);

    public static readonly Rarc Ma12 = new(Values.Ma12);

    public static readonly Rarc Ma13 = new(Values.Ma13);

    public static readonly Rarc Ma14 = new(Values.Ma14);

    public static readonly Rarc Ma15 = new(Values.Ma15);

    public static readonly Rarc Ma16 = new(Values.Ma16);

    public static readonly Rarc Ma17 = new(Values.Ma17);

    public static readonly Rarc Ma18 = new(Values.Ma18);

    public static readonly Rarc Ma19 = new(Values.Ma19);

    public static readonly Rarc Ma20 = new(Values.Ma20);

    public static readonly Rarc Ma21 = new(Values.Ma21);

    public static readonly Rarc Ma22 = new(Values.Ma22);

    public static readonly Rarc Ma23 = new(Values.Ma23);

    public static readonly Rarc Ma24 = new(Values.Ma24);

    public static readonly Rarc Ma25 = new(Values.Ma25);

    public static readonly Rarc Ma26 = new(Values.Ma26);

    public static readonly Rarc Ma27 = new(Values.Ma27);

    public static readonly Rarc Ma28 = new(Values.Ma28);

    public static readonly Rarc Ma29 = new(Values.Ma29);

    public static readonly Rarc Ma30 = new(Values.Ma30);

    public static readonly Rarc Ma31 = new(Values.Ma31);

    public static readonly Rarc Ma32 = new(Values.Ma32);

    public static readonly Rarc Ma33 = new(Values.Ma33);

    public static readonly Rarc Ma34 = new(Values.Ma34);

    public static readonly Rarc Ma35 = new(Values.Ma35);

    public static readonly Rarc Ma36 = new(Values.Ma36);

    public static readonly Rarc Ma37 = new(Values.Ma37);

    public static readonly Rarc Ma38 = new(Values.Ma38);

    public static readonly Rarc Ma39 = new(Values.Ma39);

    public static readonly Rarc Ma40 = new(Values.Ma40);

    public static readonly Rarc Ma41 = new(Values.Ma41);

    public static readonly Rarc Ma42 = new(Values.Ma42);

    public static readonly Rarc Ma43 = new(Values.Ma43);

    public static readonly Rarc Ma44 = new(Values.Ma44);

    public static readonly Rarc Ma45 = new(Values.Ma45);

    public static readonly Rarc Ma46 = new(Values.Ma46);

    public static readonly Rarc Ma47 = new(Values.Ma47);

    public static readonly Rarc Ma48 = new(Values.Ma48);

    public static readonly Rarc Ma49 = new(Values.Ma49);

    public static readonly Rarc Ma50 = new(Values.Ma50);

    public static readonly Rarc Ma51 = new(Values.Ma51);

    public static readonly Rarc Ma52 = new(Values.Ma52);

    public static readonly Rarc Ma53 = new(Values.Ma53);

    public static readonly Rarc Ma54 = new(Values.Ma54);

    public static readonly Rarc Ma55 = new(Values.Ma55);

    public static readonly Rarc Ma56 = new(Values.Ma56);

    public static readonly Rarc Ma57 = new(Values.Ma57);

    public static readonly Rarc Ma58 = new(Values.Ma58);

    public static readonly Rarc Ma59 = new(Values.Ma59);

    public static readonly Rarc Ma60 = new(Values.Ma60);

    public static readonly Rarc Ma61 = new(Values.Ma61);

    public static readonly Rarc Ma62 = new(Values.Ma62);

    public static readonly Rarc Ma63 = new(Values.Ma63);

    public static readonly Rarc Ma64 = new(Values.Ma64);

    public static readonly Rarc Ma65 = new(Values.Ma65);

    public static readonly Rarc Ma66 = new(Values.Ma66);

    public static readonly Rarc Ma67 = new(Values.Ma67);

    public static readonly Rarc Ma68 = new(Values.Ma68);

    public static readonly Rarc Ma69 = new(Values.Ma69);

    public static readonly Rarc Ma70 = new(Values.Ma70);

    public static readonly Rarc Ma71 = new(Values.Ma71);

    public static readonly Rarc Ma72 = new(Values.Ma72);

    public static readonly Rarc Ma73 = new(Values.Ma73);

    public static readonly Rarc Ma74 = new(Values.Ma74);

    public static readonly Rarc Ma75 = new(Values.Ma75);

    public static readonly Rarc Ma76 = new(Values.Ma76);

    public static readonly Rarc Ma77 = new(Values.Ma77);

    public static readonly Rarc Ma78 = new(Values.Ma78);

    public static readonly Rarc Ma79 = new(Values.Ma79);

    public static readonly Rarc Ma80 = new(Values.Ma80);

    public static readonly Rarc Ma81 = new(Values.Ma81);

    public static readonly Rarc Ma82 = new(Values.Ma82);

    public static readonly Rarc Ma83 = new(Values.Ma83);

    public static readonly Rarc Ma84 = new(Values.Ma84);

    public static readonly Rarc Ma85 = new(Values.Ma85);

    public static readonly Rarc Ma86 = new(Values.Ma86);

    public static readonly Rarc Ma87 = new(Values.Ma87);

    public static readonly Rarc Ma88 = new(Values.Ma88);

    public static readonly Rarc Ma89 = new(Values.Ma89);

    public static readonly Rarc Ma90 = new(Values.Ma90);

    public static readonly Rarc Ma91 = new(Values.Ma91);

    public static readonly Rarc Ma92 = new(Values.Ma92);

    public static readonly Rarc Ma93 = new(Values.Ma93);

    public static readonly Rarc Ma94 = new(Values.Ma94);

    public static readonly Rarc Ma95 = new(Values.Ma95);

    public static readonly Rarc Ma96 = new(Values.Ma96);

    public static readonly Rarc Ma97 = new(Values.Ma97);

    public static readonly Rarc Ma98 = new(Values.Ma98);

    public static readonly Rarc Ma99 = new(Values.Ma99);

    public static readonly Rarc Ma100 = new(Values.Ma100);

    public static readonly Rarc Ma101 = new(Values.Ma101);

    public static readonly Rarc Ma102 = new(Values.Ma102);

    public static readonly Rarc Ma103 = new(Values.Ma103);

    public static readonly Rarc Ma104 = new(Values.Ma104);

    public static readonly Rarc Ma105 = new(Values.Ma105);

    public static readonly Rarc Ma106 = new(Values.Ma106);

    public static readonly Rarc Ma107 = new(Values.Ma107);

    public static readonly Rarc Ma108 = new(Values.Ma108);

    public static readonly Rarc Ma109 = new(Values.Ma109);

    public static readonly Rarc Ma110 = new(Values.Ma110);

    public static readonly Rarc Ma111 = new(Values.Ma111);

    public static readonly Rarc Ma112 = new(Values.Ma112);

    public static readonly Rarc Ma113 = new(Values.Ma113);

    public static readonly Rarc Ma114 = new(Values.Ma114);

    public static readonly Rarc Ma115 = new(Values.Ma115);

    public static readonly Rarc Ma116 = new(Values.Ma116);

    public static readonly Rarc Ma117 = new(Values.Ma117);

    public static readonly Rarc Ma118 = new(Values.Ma118);

    public static readonly Rarc Ma119 = new(Values.Ma119);

    public static readonly Rarc Ma120 = new(Values.Ma120);

    public static readonly Rarc Ma121 = new(Values.Ma121);

    public static readonly Rarc Ma122 = new(Values.Ma122);

    public static readonly Rarc Ma123 = new(Values.Ma123);

    public static readonly Rarc Ma124 = new(Values.Ma124);

    public static readonly Rarc Ma125 = new(Values.Ma125);

    public static readonly Rarc Ma126 = new(Values.Ma126);

    public static readonly Rarc Ma127 = new(Values.Ma127);

    public static readonly Rarc Ma128 = new(Values.Ma128);

    public static readonly Rarc Ma129 = new(Values.Ma129);

    public static readonly Rarc Ma130 = new(Values.Ma130);

    public static readonly Rarc Ma131 = new(Values.Ma131);

    public static readonly Rarc Ma132 = new(Values.Ma132);

    public static readonly Rarc Ma133 = new(Values.Ma133);

    public static readonly Rarc Ma134 = new(Values.Ma134);

    public static readonly Rarc N1 = new(Values.N1);

    public static readonly Rarc N2 = new(Values.N2);

    public static readonly Rarc N3 = new(Values.N3);

    public static readonly Rarc N4 = new(Values.N4);

    public static readonly Rarc N5 = new(Values.N5);

    public static readonly Rarc N6 = new(Values.N6);

    public static readonly Rarc N7 = new(Values.N7);

    public static readonly Rarc N8 = new(Values.N8);

    public static readonly Rarc N9 = new(Values.N9);

    public static readonly Rarc N10 = new(Values.N10);

    public static readonly Rarc N11 = new(Values.N11);

    public static readonly Rarc N12 = new(Values.N12);

    public static readonly Rarc N13 = new(Values.N13);

    public static readonly Rarc N14 = new(Values.N14);

    public static readonly Rarc N15 = new(Values.N15);

    public static readonly Rarc N16 = new(Values.N16);

    public static readonly Rarc N17 = new(Values.N17);

    public static readonly Rarc N18 = new(Values.N18);

    public static readonly Rarc N19 = new(Values.N19);

    public static readonly Rarc N20 = new(Values.N20);

    public static readonly Rarc N21 = new(Values.N21);

    public static readonly Rarc N22 = new(Values.N22);

    public static readonly Rarc N23 = new(Values.N23);

    public static readonly Rarc N24 = new(Values.N24);

    public static readonly Rarc N25 = new(Values.N25);

    public static readonly Rarc N26 = new(Values.N26);

    public static readonly Rarc N27 = new(Values.N27);

    public static readonly Rarc N28 = new(Values.N28);

    public static readonly Rarc N29 = new(Values.N29);

    public static readonly Rarc N30 = new(Values.N30);

    public static readonly Rarc N31 = new(Values.N31);

    public static readonly Rarc N32 = new(Values.N32);

    public static readonly Rarc N33 = new(Values.N33);

    public static readonly Rarc N34 = new(Values.N34);

    public static readonly Rarc N35 = new(Values.N35);

    public static readonly Rarc N36 = new(Values.N36);

    public static readonly Rarc N37 = new(Values.N37);

    public static readonly Rarc N38 = new(Values.N38);

    public static readonly Rarc N39 = new(Values.N39);

    public static readonly Rarc N40 = new(Values.N40);

    public static readonly Rarc N41 = new(Values.N41);

    public static readonly Rarc N42 = new(Values.N42);

    public static readonly Rarc N43 = new(Values.N43);

    public static readonly Rarc N44 = new(Values.N44);

    public static readonly Rarc N45 = new(Values.N45);

    public static readonly Rarc N46 = new(Values.N46);

    public static readonly Rarc N47 = new(Values.N47);

    public static readonly Rarc N48 = new(Values.N48);

    public static readonly Rarc N49 = new(Values.N49);

    public static readonly Rarc N50 = new(Values.N50);

    public static readonly Rarc N51 = new(Values.N51);

    public static readonly Rarc N52 = new(Values.N52);

    public static readonly Rarc N53 = new(Values.N53);

    public static readonly Rarc N54 = new(Values.N54);

    public static readonly Rarc N55 = new(Values.N55);

    public static readonly Rarc N56 = new(Values.N56);

    public static readonly Rarc N57 = new(Values.N57);

    public static readonly Rarc N58 = new(Values.N58);

    public static readonly Rarc N59 = new(Values.N59);

    public static readonly Rarc N60 = new(Values.N60);

    public static readonly Rarc N61 = new(Values.N61);

    public static readonly Rarc N62 = new(Values.N62);

    public static readonly Rarc N63 = new(Values.N63);

    public static readonly Rarc N64 = new(Values.N64);

    public static readonly Rarc N65 = new(Values.N65);

    public static readonly Rarc N66 = new(Values.N66);

    public static readonly Rarc N67 = new(Values.N67);

    public static readonly Rarc N68 = new(Values.N68);

    public static readonly Rarc N69 = new(Values.N69);

    public static readonly Rarc N70 = new(Values.N70);

    public static readonly Rarc N71 = new(Values.N71);

    public static readonly Rarc N72 = new(Values.N72);

    public static readonly Rarc N73 = new(Values.N73);

    public static readonly Rarc N74 = new(Values.N74);

    public static readonly Rarc N75 = new(Values.N75);

    public static readonly Rarc N76 = new(Values.N76);

    public static readonly Rarc N77 = new(Values.N77);

    public static readonly Rarc N78 = new(Values.N78);

    public static readonly Rarc N79 = new(Values.N79);

    public static readonly Rarc N80 = new(Values.N80);

    public static readonly Rarc N81 = new(Values.N81);

    public static readonly Rarc N82 = new(Values.N82);

    public static readonly Rarc N83 = new(Values.N83);

    public static readonly Rarc N84 = new(Values.N84);

    public static readonly Rarc N85 = new(Values.N85);

    public static readonly Rarc N86 = new(Values.N86);

    public static readonly Rarc N87 = new(Values.N87);

    public static readonly Rarc N88 = new(Values.N88);

    public static readonly Rarc N89 = new(Values.N89);

    public static readonly Rarc N90 = new(Values.N90);

    public static readonly Rarc N91 = new(Values.N91);

    public static readonly Rarc N92 = new(Values.N92);

    public static readonly Rarc N93 = new(Values.N93);

    public static readonly Rarc N94 = new(Values.N94);

    public static readonly Rarc N95 = new(Values.N95);

    public static readonly Rarc N96 = new(Values.N96);

    public static readonly Rarc N97 = new(Values.N97);

    public static readonly Rarc N98 = new(Values.N98);

    public static readonly Rarc N99 = new(Values.N99);

    public static readonly Rarc N100 = new(Values.N100);

    public static readonly Rarc N101 = new(Values.N101);

    public static readonly Rarc N102 = new(Values.N102);

    public static readonly Rarc N103 = new(Values.N103);

    public static readonly Rarc N104 = new(Values.N104);

    public static readonly Rarc N105 = new(Values.N105);

    public static readonly Rarc N106 = new(Values.N106);

    public static readonly Rarc N107 = new(Values.N107);

    public static readonly Rarc N108 = new(Values.N108);

    public static readonly Rarc N109 = new(Values.N109);

    public static readonly Rarc N110 = new(Values.N110);

    public static readonly Rarc N111 = new(Values.N111);

    public static readonly Rarc N112 = new(Values.N112);

    public static readonly Rarc N113 = new(Values.N113);

    public static readonly Rarc N114 = new(Values.N114);

    public static readonly Rarc N115 = new(Values.N115);

    public static readonly Rarc N116 = new(Values.N116);

    public static readonly Rarc N117 = new(Values.N117);

    public static readonly Rarc N118 = new(Values.N118);

    public static readonly Rarc N119 = new(Values.N119);

    public static readonly Rarc N120 = new(Values.N120);

    public static readonly Rarc N121 = new(Values.N121);

    public static readonly Rarc N122 = new(Values.N122);

    public static readonly Rarc N123 = new(Values.N123);

    public static readonly Rarc N124 = new(Values.N124);

    public static readonly Rarc N125 = new(Values.N125);

    public static readonly Rarc N126 = new(Values.N126);

    public static readonly Rarc N127 = new(Values.N127);

    public static readonly Rarc N128 = new(Values.N128);

    public static readonly Rarc N129 = new(Values.N129);

    public static readonly Rarc N130 = new(Values.N130);

    public static readonly Rarc N131 = new(Values.N131);

    public static readonly Rarc N132 = new(Values.N132);

    public static readonly Rarc N133 = new(Values.N133);

    public static readonly Rarc N134 = new(Values.N134);

    public static readonly Rarc N135 = new(Values.N135);

    public static readonly Rarc N136 = new(Values.N136);

    public static readonly Rarc N137 = new(Values.N137);

    public static readonly Rarc N138 = new(Values.N138);

    public static readonly Rarc N139 = new(Values.N139);

    public static readonly Rarc N140 = new(Values.N140);

    public static readonly Rarc N141 = new(Values.N141);

    public static readonly Rarc N142 = new(Values.N142);

    public static readonly Rarc N143 = new(Values.N143);

    public static readonly Rarc N144 = new(Values.N144);

    public static readonly Rarc N145 = new(Values.N145);

    public static readonly Rarc N146 = new(Values.N146);

    public static readonly Rarc N147 = new(Values.N147);

    public static readonly Rarc N148 = new(Values.N148);

    public static readonly Rarc N149 = new(Values.N149);

    public static readonly Rarc N150 = new(Values.N150);

    public static readonly Rarc N151 = new(Values.N151);

    public static readonly Rarc N152 = new(Values.N152);

    public static readonly Rarc N153 = new(Values.N153);

    public static readonly Rarc N154 = new(Values.N154);

    public static readonly Rarc N155 = new(Values.N155);

    public static readonly Rarc N156 = new(Values.N156);

    public static readonly Rarc N157 = new(Values.N157);

    public static readonly Rarc N158 = new(Values.N158);

    public static readonly Rarc N159 = new(Values.N159);

    public static readonly Rarc N160 = new(Values.N160);

    public static readonly Rarc N161 = new(Values.N161);

    public static readonly Rarc N162 = new(Values.N162);

    public static readonly Rarc N163 = new(Values.N163);

    public static readonly Rarc N164 = new(Values.N164);

    public static readonly Rarc N165 = new(Values.N165);

    public static readonly Rarc N166 = new(Values.N166);

    public static readonly Rarc N167 = new(Values.N167);

    public static readonly Rarc N168 = new(Values.N168);

    public static readonly Rarc N169 = new(Values.N169);

    public static readonly Rarc N170 = new(Values.N170);

    public static readonly Rarc N171 = new(Values.N171);

    public static readonly Rarc N172 = new(Values.N172);

    public static readonly Rarc N173 = new(Values.N173);

    public static readonly Rarc N174 = new(Values.N174);

    public static readonly Rarc N175 = new(Values.N175);

    public static readonly Rarc N176 = new(Values.N176);

    public static readonly Rarc N177 = new(Values.N177);

    public static readonly Rarc N178 = new(Values.N178);

    public static readonly Rarc N179 = new(Values.N179);

    public static readonly Rarc N180 = new(Values.N180);

    public static readonly Rarc N181 = new(Values.N181);

    public static readonly Rarc N182 = new(Values.N182);

    public static readonly Rarc N183 = new(Values.N183);

    public static readonly Rarc N184 = new(Values.N184);

    public static readonly Rarc N185 = new(Values.N185);

    public static readonly Rarc N186 = new(Values.N186);

    public static readonly Rarc N187 = new(Values.N187);

    public static readonly Rarc N188 = new(Values.N188);

    public static readonly Rarc N189 = new(Values.N189);

    public static readonly Rarc N190 = new(Values.N190);

    public static readonly Rarc N191 = new(Values.N191);

    public static readonly Rarc N192 = new(Values.N192);

    public static readonly Rarc N193 = new(Values.N193);

    public static readonly Rarc N194 = new(Values.N194);

    public static readonly Rarc N195 = new(Values.N195);

    public static readonly Rarc N196 = new(Values.N196);

    public static readonly Rarc N197 = new(Values.N197);

    public static readonly Rarc N198 = new(Values.N198);

    public static readonly Rarc N199 = new(Values.N199);

    public static readonly Rarc N200 = new(Values.N200);

    public static readonly Rarc N201 = new(Values.N201);

    public static readonly Rarc N202 = new(Values.N202);

    public static readonly Rarc N203 = new(Values.N203);

    public static readonly Rarc N204 = new(Values.N204);

    public static readonly Rarc N205 = new(Values.N205);

    public static readonly Rarc N206 = new(Values.N206);

    public static readonly Rarc N207 = new(Values.N207);

    public static readonly Rarc N208 = new(Values.N208);

    public static readonly Rarc N209 = new(Values.N209);

    public static readonly Rarc N210 = new(Values.N210);

    public static readonly Rarc N211 = new(Values.N211);

    public static readonly Rarc N212 = new(Values.N212);

    public static readonly Rarc N213 = new(Values.N213);

    public static readonly Rarc N214 = new(Values.N214);

    public static readonly Rarc N215 = new(Values.N215);

    public static readonly Rarc N216 = new(Values.N216);

    public static readonly Rarc N217 = new(Values.N217);

    public static readonly Rarc N218 = new(Values.N218);

    public static readonly Rarc N219 = new(Values.N219);

    public static readonly Rarc N220 = new(Values.N220);

    public static readonly Rarc N221 = new(Values.N221);

    public static readonly Rarc N222 = new(Values.N222);

    public static readonly Rarc N223 = new(Values.N223);

    public static readonly Rarc N224 = new(Values.N224);

    public static readonly Rarc N225 = new(Values.N225);

    public static readonly Rarc N226 = new(Values.N226);

    public static readonly Rarc N227 = new(Values.N227);

    public static readonly Rarc N228 = new(Values.N228);

    public static readonly Rarc N229 = new(Values.N229);

    public static readonly Rarc N230 = new(Values.N230);

    public static readonly Rarc N231 = new(Values.N231);

    public static readonly Rarc N232 = new(Values.N232);

    public static readonly Rarc N233 = new(Values.N233);

    public static readonly Rarc N234 = new(Values.N234);

    public static readonly Rarc N235 = new(Values.N235);

    public static readonly Rarc N236 = new(Values.N236);

    public static readonly Rarc N237 = new(Values.N237);

    public static readonly Rarc N238 = new(Values.N238);

    public static readonly Rarc N239 = new(Values.N239);

    public static readonly Rarc N240 = new(Values.N240);

    public static readonly Rarc N241 = new(Values.N241);

    public static readonly Rarc N242 = new(Values.N242);

    public static readonly Rarc N243 = new(Values.N243);

    public static readonly Rarc N244 = new(Values.N244);

    public static readonly Rarc N245 = new(Values.N245);

    public static readonly Rarc N246 = new(Values.N246);

    public static readonly Rarc N247 = new(Values.N247);

    public static readonly Rarc N248 = new(Values.N248);

    public static readonly Rarc N249 = new(Values.N249);

    public static readonly Rarc N250 = new(Values.N250);

    public static readonly Rarc N251 = new(Values.N251);

    public static readonly Rarc N252 = new(Values.N252);

    public static readonly Rarc N253 = new(Values.N253);

    public static readonly Rarc N254 = new(Values.N254);

    public static readonly Rarc N255 = new(Values.N255);

    public static readonly Rarc N256 = new(Values.N256);

    public static readonly Rarc N257 = new(Values.N257);

    public static readonly Rarc N258 = new(Values.N258);

    public static readonly Rarc N259 = new(Values.N259);

    public static readonly Rarc N260 = new(Values.N260);

    public static readonly Rarc N261 = new(Values.N261);

    public static readonly Rarc N262 = new(Values.N262);

    public static readonly Rarc N263 = new(Values.N263);

    public static readonly Rarc N264 = new(Values.N264);

    public static readonly Rarc N265 = new(Values.N265);

    public static readonly Rarc N266 = new(Values.N266);

    public static readonly Rarc N267 = new(Values.N267);

    public static readonly Rarc N268 = new(Values.N268);

    public static readonly Rarc N269 = new(Values.N269);

    public static readonly Rarc N270 = new(Values.N270);

    public static readonly Rarc N271 = new(Values.N271);

    public static readonly Rarc N272 = new(Values.N272);

    public static readonly Rarc N273 = new(Values.N273);

    public static readonly Rarc N274 = new(Values.N274);

    public static readonly Rarc N275 = new(Values.N275);

    public static readonly Rarc N276 = new(Values.N276);

    public static readonly Rarc N277 = new(Values.N277);

    public static readonly Rarc N278 = new(Values.N278);

    public static readonly Rarc N279 = new(Values.N279);

    public static readonly Rarc N280 = new(Values.N280);

    public static readonly Rarc N281 = new(Values.N281);

    public static readonly Rarc N282 = new(Values.N282);

    public static readonly Rarc N283 = new(Values.N283);

    public static readonly Rarc N284 = new(Values.N284);

    public static readonly Rarc N285 = new(Values.N285);

    public static readonly Rarc N286 = new(Values.N286);

    public static readonly Rarc N287 = new(Values.N287);

    public static readonly Rarc N288 = new(Values.N288);

    public static readonly Rarc N289 = new(Values.N289);

    public static readonly Rarc N290 = new(Values.N290);

    public static readonly Rarc N291 = new(Values.N291);

    public static readonly Rarc N292 = new(Values.N292);

    public static readonly Rarc N293 = new(Values.N293);

    public static readonly Rarc N294 = new(Values.N294);

    public static readonly Rarc N295 = new(Values.N295);

    public static readonly Rarc N296 = new(Values.N296);

    public static readonly Rarc N297 = new(Values.N297);

    public static readonly Rarc N298 = new(Values.N298);

    public static readonly Rarc N299 = new(Values.N299);

    public static readonly Rarc N300 = new(Values.N300);

    public static readonly Rarc N301 = new(Values.N301);

    public static readonly Rarc N302 = new(Values.N302);

    public static readonly Rarc N303 = new(Values.N303);

    public static readonly Rarc N304 = new(Values.N304);

    public static readonly Rarc N305 = new(Values.N305);

    public static readonly Rarc N306 = new(Values.N306);

    public static readonly Rarc N307 = new(Values.N307);

    public static readonly Rarc N308 = new(Values.N308);

    public static readonly Rarc N309 = new(Values.N309);

    public static readonly Rarc N310 = new(Values.N310);

    public static readonly Rarc N311 = new(Values.N311);

    public static readonly Rarc N312 = new(Values.N312);

    public static readonly Rarc N313 = new(Values.N313);

    public static readonly Rarc N314 = new(Values.N314);

    public static readonly Rarc N315 = new(Values.N315);

    public static readonly Rarc N316 = new(Values.N316);

    public static readonly Rarc N317 = new(Values.N317);

    public static readonly Rarc N318 = new(Values.N318);

    public static readonly Rarc N319 = new(Values.N319);

    public static readonly Rarc N320 = new(Values.N320);

    public static readonly Rarc N321 = new(Values.N321);

    public static readonly Rarc N322 = new(Values.N322);

    public static readonly Rarc N323 = new(Values.N323);

    public static readonly Rarc N324 = new(Values.N324);

    public static readonly Rarc N325 = new(Values.N325);

    public static readonly Rarc N326 = new(Values.N326);

    public static readonly Rarc N327 = new(Values.N327);

    public static readonly Rarc N328 = new(Values.N328);

    public static readonly Rarc N329 = new(Values.N329);

    public static readonly Rarc N330 = new(Values.N330);

    public static readonly Rarc N331 = new(Values.N331);

    public static readonly Rarc N332 = new(Values.N332);

    public static readonly Rarc N333 = new(Values.N333);

    public static readonly Rarc N334 = new(Values.N334);

    public static readonly Rarc N335 = new(Values.N335);

    public static readonly Rarc N336 = new(Values.N336);

    public static readonly Rarc N337 = new(Values.N337);

    public static readonly Rarc N338 = new(Values.N338);

    public static readonly Rarc N339 = new(Values.N339);

    public static readonly Rarc N340 = new(Values.N340);

    public static readonly Rarc N341 = new(Values.N341);

    public static readonly Rarc N342 = new(Values.N342);

    public static readonly Rarc N343 = new(Values.N343);

    public static readonly Rarc N344 = new(Values.N344);

    public static readonly Rarc N345 = new(Values.N345);

    public static readonly Rarc N346 = new(Values.N346);

    public static readonly Rarc N347 = new(Values.N347);

    public static readonly Rarc N348 = new(Values.N348);

    public static readonly Rarc N349 = new(Values.N349);

    public static readonly Rarc N350 = new(Values.N350);

    public static readonly Rarc N351 = new(Values.N351);

    public static readonly Rarc N352 = new(Values.N352);

    public static readonly Rarc N353 = new(Values.N353);

    public static readonly Rarc N354 = new(Values.N354);

    public static readonly Rarc N355 = new(Values.N355);

    public static readonly Rarc N356 = new(Values.N356);

    public static readonly Rarc N357 = new(Values.N357);

    public static readonly Rarc N358 = new(Values.N358);

    public static readonly Rarc N359 = new(Values.N359);

    public static readonly Rarc N360 = new(Values.N360);

    public static readonly Rarc N361 = new(Values.N361);

    public static readonly Rarc N362 = new(Values.N362);

    public static readonly Rarc N363 = new(Values.N363);

    public static readonly Rarc N364 = new(Values.N364);

    public static readonly Rarc N365 = new(Values.N365);

    public static readonly Rarc N366 = new(Values.N366);

    public static readonly Rarc N367 = new(Values.N367);

    public static readonly Rarc N368 = new(Values.N368);

    public static readonly Rarc N369 = new(Values.N369);

    public static readonly Rarc N370 = new(Values.N370);

    public static readonly Rarc N371 = new(Values.N371);

    public static readonly Rarc N372 = new(Values.N372);

    public static readonly Rarc N373 = new(Values.N373);

    public static readonly Rarc N374 = new(Values.N374);

    public static readonly Rarc N375 = new(Values.N375);

    public static readonly Rarc N376 = new(Values.N376);

    public static readonly Rarc N377 = new(Values.N377);

    public static readonly Rarc N378 = new(Values.N378);

    public static readonly Rarc N379 = new(Values.N379);

    public static readonly Rarc N380 = new(Values.N380);

    public static readonly Rarc N381 = new(Values.N381);

    public static readonly Rarc N382 = new(Values.N382);

    public static readonly Rarc N383 = new(Values.N383);

    public static readonly Rarc N384 = new(Values.N384);

    public static readonly Rarc N385 = new(Values.N385);

    public static readonly Rarc N386 = new(Values.N386);

    public static readonly Rarc N387 = new(Values.N387);

    public static readonly Rarc N388 = new(Values.N388);

    public static readonly Rarc N389 = new(Values.N389);

    public static readonly Rarc N390 = new(Values.N390);

    public static readonly Rarc N391 = new(Values.N391);

    public static readonly Rarc N392 = new(Values.N392);

    public static readonly Rarc N393 = new(Values.N393);

    public static readonly Rarc N394 = new(Values.N394);

    public static readonly Rarc N395 = new(Values.N395);

    public static readonly Rarc N396 = new(Values.N396);

    public static readonly Rarc N397 = new(Values.N397);

    public static readonly Rarc N398 = new(Values.N398);

    public static readonly Rarc N399 = new(Values.N399);

    public static readonly Rarc N400 = new(Values.N400);

    public static readonly Rarc N401 = new(Values.N401);

    public static readonly Rarc N402 = new(Values.N402);

    public static readonly Rarc N403 = new(Values.N403);

    public static readonly Rarc N404 = new(Values.N404);

    public static readonly Rarc N405 = new(Values.N405);

    public static readonly Rarc N406 = new(Values.N406);

    public static readonly Rarc N407 = new(Values.N407);

    public static readonly Rarc N408 = new(Values.N408);

    public static readonly Rarc N409 = new(Values.N409);

    public static readonly Rarc N410 = new(Values.N410);

    public static readonly Rarc N411 = new(Values.N411);

    public static readonly Rarc N412 = new(Values.N412);

    public static readonly Rarc N413 = new(Values.N413);

    public static readonly Rarc N414 = new(Values.N414);

    public static readonly Rarc N415 = new(Values.N415);

    public static readonly Rarc N416 = new(Values.N416);

    public static readonly Rarc N417 = new(Values.N417);

    public static readonly Rarc N418 = new(Values.N418);

    public static readonly Rarc N419 = new(Values.N419);

    public static readonly Rarc N420 = new(Values.N420);

    public static readonly Rarc N421 = new(Values.N421);

    public static readonly Rarc N422 = new(Values.N422);

    public static readonly Rarc N423 = new(Values.N423);

    public static readonly Rarc N424 = new(Values.N424);

    public static readonly Rarc N425 = new(Values.N425);

    public static readonly Rarc N426 = new(Values.N426);

    public static readonly Rarc N427 = new(Values.N427);

    public static readonly Rarc N428 = new(Values.N428);

    public static readonly Rarc N429 = new(Values.N429);

    public static readonly Rarc N430 = new(Values.N430);

    public static readonly Rarc N431 = new(Values.N431);

    public static readonly Rarc N432 = new(Values.N432);

    public static readonly Rarc N433 = new(Values.N433);

    public static readonly Rarc N434 = new(Values.N434);

    public static readonly Rarc N435 = new(Values.N435);

    public static readonly Rarc N436 = new(Values.N436);

    public static readonly Rarc N437 = new(Values.N437);

    public static readonly Rarc N438 = new(Values.N438);

    public static readonly Rarc N439 = new(Values.N439);

    public static readonly Rarc N440 = new(Values.N440);

    public static readonly Rarc N441 = new(Values.N441);

    public static readonly Rarc N442 = new(Values.N442);

    public static readonly Rarc N443 = new(Values.N443);

    public static readonly Rarc N444 = new(Values.N444);

    public static readonly Rarc N445 = new(Values.N445);

    public static readonly Rarc N446 = new(Values.N446);

    public static readonly Rarc N447 = new(Values.N447);

    public static readonly Rarc N448 = new(Values.N448);

    public static readonly Rarc N449 = new(Values.N449);

    public static readonly Rarc N450 = new(Values.N450);

    public static readonly Rarc N451 = new(Values.N451);

    public static readonly Rarc N452 = new(Values.N452);

    public static readonly Rarc N453 = new(Values.N453);

    public static readonly Rarc N454 = new(Values.N454);

    public static readonly Rarc N455 = new(Values.N455);

    public static readonly Rarc N456 = new(Values.N456);

    public static readonly Rarc N457 = new(Values.N457);

    public static readonly Rarc N458 = new(Values.N458);

    public static readonly Rarc N459 = new(Values.N459);

    public static readonly Rarc N460 = new(Values.N460);

    public static readonly Rarc N461 = new(Values.N461);

    public static readonly Rarc N462 = new(Values.N462);

    public static readonly Rarc N463 = new(Values.N463);

    public static readonly Rarc N464 = new(Values.N464);

    public static readonly Rarc N465 = new(Values.N465);

    public static readonly Rarc N466 = new(Values.N466);

    public static readonly Rarc N467 = new(Values.N467);

    public static readonly Rarc N468 = new(Values.N468);

    public static readonly Rarc N469 = new(Values.N469);

    public static readonly Rarc N470 = new(Values.N470);

    public static readonly Rarc N471 = new(Values.N471);

    public static readonly Rarc N472 = new(Values.N472);

    public static readonly Rarc N473 = new(Values.N473);

    public static readonly Rarc N474 = new(Values.N474);

    public static readonly Rarc N475 = new(Values.N475);

    public static readonly Rarc N476 = new(Values.N476);

    public static readonly Rarc N477 = new(Values.N477);

    public static readonly Rarc N478 = new(Values.N478);

    public static readonly Rarc N479 = new(Values.N479);

    public static readonly Rarc N480 = new(Values.N480);

    public static readonly Rarc N481 = new(Values.N481);

    public static readonly Rarc N482 = new(Values.N482);

    public static readonly Rarc N483 = new(Values.N483);

    public static readonly Rarc N484 = new(Values.N484);

    public static readonly Rarc N485 = new(Values.N485);

    public static readonly Rarc N486 = new(Values.N486);

    public static readonly Rarc N487 = new(Values.N487);

    public static readonly Rarc N488 = new(Values.N488);

    public static readonly Rarc N489 = new(Values.N489);

    public static readonly Rarc N490 = new(Values.N490);

    public static readonly Rarc N491 = new(Values.N491);

    public static readonly Rarc N492 = new(Values.N492);

    public static readonly Rarc N493 = new(Values.N493);

    public static readonly Rarc N494 = new(Values.N494);

    public static readonly Rarc N495 = new(Values.N495);

    public static readonly Rarc N496 = new(Values.N496);

    public static readonly Rarc N497 = new(Values.N497);

    public static readonly Rarc N498 = new(Values.N498);

    public static readonly Rarc N499 = new(Values.N499);

    public static readonly Rarc N500 = new(Values.N500);

    public static readonly Rarc N501 = new(Values.N501);

    public static readonly Rarc N502 = new(Values.N502);

    public static readonly Rarc N503 = new(Values.N503);

    public static readonly Rarc N504 = new(Values.N504);

    public static readonly Rarc N505 = new(Values.N505);

    public static readonly Rarc N506 = new(Values.N506);

    public static readonly Rarc N507 = new(Values.N507);

    public static readonly Rarc N508 = new(Values.N508);

    public static readonly Rarc N509 = new(Values.N509);

    public static readonly Rarc N510 = new(Values.N510);

    public static readonly Rarc N511 = new(Values.N511);

    public static readonly Rarc N512 = new(Values.N512);

    public static readonly Rarc N513 = new(Values.N513);

    public static readonly Rarc N514 = new(Values.N514);

    public static readonly Rarc N515 = new(Values.N515);

    public static readonly Rarc N516 = new(Values.N516);

    public static readonly Rarc N517 = new(Values.N517);

    public static readonly Rarc N518 = new(Values.N518);

    public static readonly Rarc N519 = new(Values.N519);

    public static readonly Rarc N520 = new(Values.N520);

    public static readonly Rarc N521 = new(Values.N521);

    public static readonly Rarc N522 = new(Values.N522);

    public static readonly Rarc N523 = new(Values.N523);

    public static readonly Rarc N524 = new(Values.N524);

    public static readonly Rarc N525 = new(Values.N525);

    public static readonly Rarc N526 = new(Values.N526);

    public static readonly Rarc N527 = new(Values.N527);

    public static readonly Rarc N528 = new(Values.N528);

    public static readonly Rarc N529 = new(Values.N529);

    public static readonly Rarc N530 = new(Values.N530);

    public static readonly Rarc N531 = new(Values.N531);

    public static readonly Rarc N532 = new(Values.N532);

    public static readonly Rarc N533 = new(Values.N533);

    public static readonly Rarc N534 = new(Values.N534);

    public static readonly Rarc N535 = new(Values.N535);

    public static readonly Rarc N536 = new(Values.N536);

    public static readonly Rarc N537 = new(Values.N537);

    public static readonly Rarc N538 = new(Values.N538);

    public static readonly Rarc N539 = new(Values.N539);

    public static readonly Rarc N540 = new(Values.N540);

    public static readonly Rarc N541 = new(Values.N541);

    public static readonly Rarc N542 = new(Values.N542);

    public static readonly Rarc N543 = new(Values.N543);

    public static readonly Rarc N544 = new(Values.N544);

    public static readonly Rarc N545 = new(Values.N545);

    public static readonly Rarc N546 = new(Values.N546);

    public static readonly Rarc N547 = new(Values.N547);

    public static readonly Rarc N548 = new(Values.N548);

    public static readonly Rarc N549 = new(Values.N549);

    public static readonly Rarc N550 = new(Values.N550);

    public static readonly Rarc N551 = new(Values.N551);

    public static readonly Rarc N552 = new(Values.N552);

    public static readonly Rarc N553 = new(Values.N553);

    public static readonly Rarc N554 = new(Values.N554);

    public static readonly Rarc N555 = new(Values.N555);

    public static readonly Rarc N556 = new(Values.N556);

    public static readonly Rarc N557 = new(Values.N557);

    public static readonly Rarc N558 = new(Values.N558);

    public static readonly Rarc N559 = new(Values.N559);

    public static readonly Rarc N560 = new(Values.N560);

    public static readonly Rarc N561 = new(Values.N561);

    public static readonly Rarc N562 = new(Values.N562);

    public static readonly Rarc N563 = new(Values.N563);

    public static readonly Rarc N564 = new(Values.N564);

    public static readonly Rarc N565 = new(Values.N565);

    public static readonly Rarc N566 = new(Values.N566);

    public static readonly Rarc N567 = new(Values.N567);

    public static readonly Rarc N568 = new(Values.N568);

    public static readonly Rarc N569 = new(Values.N569);

    public static readonly Rarc N570 = new(Values.N570);

    public static readonly Rarc N571 = new(Values.N571);

    public static readonly Rarc N572 = new(Values.N572);

    public static readonly Rarc N573 = new(Values.N573);

    public static readonly Rarc N574 = new(Values.N574);

    public static readonly Rarc N575 = new(Values.N575);

    public static readonly Rarc N576 = new(Values.N576);

    public static readonly Rarc N577 = new(Values.N577);

    public static readonly Rarc N578 = new(Values.N578);

    public static readonly Rarc N579 = new(Values.N579);

    public static readonly Rarc N580 = new(Values.N580);

    public static readonly Rarc N581 = new(Values.N581);

    public static readonly Rarc N582 = new(Values.N582);

    public static readonly Rarc N583 = new(Values.N583);

    public static readonly Rarc N584 = new(Values.N584);

    public static readonly Rarc N585 = new(Values.N585);

    public static readonly Rarc N586 = new(Values.N586);

    public static readonly Rarc N587 = new(Values.N587);

    public static readonly Rarc N588 = new(Values.N588);

    public static readonly Rarc N589 = new(Values.N589);

    public static readonly Rarc N590 = new(Values.N590);

    public static readonly Rarc N591 = new(Values.N591);

    public static readonly Rarc N592 = new(Values.N592);

    public static readonly Rarc N593 = new(Values.N593);

    public static readonly Rarc N594 = new(Values.N594);

    public static readonly Rarc N595 = new(Values.N595);

    public static readonly Rarc N596 = new(Values.N596);

    public static readonly Rarc N597 = new(Values.N597);

    public static readonly Rarc N598 = new(Values.N598);

    public static readonly Rarc N599 = new(Values.N599);

    public static readonly Rarc N600 = new(Values.N600);

    public static readonly Rarc N601 = new(Values.N601);

    public static readonly Rarc N602 = new(Values.N602);

    public static readonly Rarc N603 = new(Values.N603);

    public static readonly Rarc N604 = new(Values.N604);

    public static readonly Rarc N605 = new(Values.N605);

    public static readonly Rarc N606 = new(Values.N606);

    public static readonly Rarc N607 = new(Values.N607);

    public static readonly Rarc N608 = new(Values.N608);

    public static readonly Rarc N609 = new(Values.N609);

    public static readonly Rarc N610 = new(Values.N610);

    public static readonly Rarc N611 = new(Values.N611);

    public static readonly Rarc N612 = new(Values.N612);

    public static readonly Rarc N613 = new(Values.N613);

    public static readonly Rarc N614 = new(Values.N614);

    public static readonly Rarc N615 = new(Values.N615);

    public static readonly Rarc N616 = new(Values.N616);

    public static readonly Rarc N617 = new(Values.N617);

    public static readonly Rarc N618 = new(Values.N618);

    public static readonly Rarc N619 = new(Values.N619);

    public static readonly Rarc N620 = new(Values.N620);

    public static readonly Rarc N621 = new(Values.N621);

    public static readonly Rarc N622 = new(Values.N622);

    public static readonly Rarc N623 = new(Values.N623);

    public static readonly Rarc N624 = new(Values.N624);

    public static readonly Rarc N625 = new(Values.N625);

    public static readonly Rarc N626 = new(Values.N626);

    public static readonly Rarc N627 = new(Values.N627);

    public static readonly Rarc N628 = new(Values.N628);

    public static readonly Rarc N629 = new(Values.N629);

    public static readonly Rarc N630 = new(Values.N630);

    public static readonly Rarc N631 = new(Values.N631);

    public static readonly Rarc N632 = new(Values.N632);

    public static readonly Rarc N633 = new(Values.N633);

    public static readonly Rarc N634 = new(Values.N634);

    public static readonly Rarc N635 = new(Values.N635);

    public static readonly Rarc N636 = new(Values.N636);

    public static readonly Rarc N637 = new(Values.N637);

    public static readonly Rarc N638 = new(Values.N638);

    public static readonly Rarc N639 = new(Values.N639);

    public static readonly Rarc N640 = new(Values.N640);

    public static readonly Rarc N641 = new(Values.N641);

    public static readonly Rarc N642 = new(Values.N642);

    public static readonly Rarc N643 = new(Values.N643);

    public static readonly Rarc N644 = new(Values.N644);

    public static readonly Rarc N645 = new(Values.N645);

    public static readonly Rarc N646 = new(Values.N646);

    public static readonly Rarc N647 = new(Values.N647);

    public static readonly Rarc N648 = new(Values.N648);

    public static readonly Rarc N649 = new(Values.N649);

    public static readonly Rarc N650 = new(Values.N650);

    public static readonly Rarc N651 = new(Values.N651);

    public static readonly Rarc N652 = new(Values.N652);

    public static readonly Rarc N653 = new(Values.N653);

    public static readonly Rarc N654 = new(Values.N654);

    public static readonly Rarc N655 = new(Values.N655);

    public static readonly Rarc N656 = new(Values.N656);

    public static readonly Rarc N657 = new(Values.N657);

    public static readonly Rarc N658 = new(Values.N658);

    public static readonly Rarc N659 = new(Values.N659);

    public static readonly Rarc N660 = new(Values.N660);

    public static readonly Rarc N661 = new(Values.N661);

    public static readonly Rarc N662 = new(Values.N662);

    public static readonly Rarc N663 = new(Values.N663);

    public static readonly Rarc N664 = new(Values.N664);

    public static readonly Rarc N665 = new(Values.N665);

    public static readonly Rarc N666 = new(Values.N666);

    public static readonly Rarc N667 = new(Values.N667);

    public static readonly Rarc N668 = new(Values.N668);

    public static readonly Rarc N669 = new(Values.N669);

    public static readonly Rarc N670 = new(Values.N670);

    public static readonly Rarc N671 = new(Values.N671);

    public static readonly Rarc N672 = new(Values.N672);

    public static readonly Rarc N673 = new(Values.N673);

    public static readonly Rarc N674 = new(Values.N674);

    public static readonly Rarc N675 = new(Values.N675);

    public static readonly Rarc N676 = new(Values.N676);

    public static readonly Rarc N677 = new(Values.N677);

    public static readonly Rarc N678 = new(Values.N678);

    public static readonly Rarc N679 = new(Values.N679);

    public static readonly Rarc N680 = new(Values.N680);

    public static readonly Rarc N681 = new(Values.N681);

    public static readonly Rarc N682 = new(Values.N682);

    public static readonly Rarc N683 = new(Values.N683);

    public static readonly Rarc N684 = new(Values.N684);

    public static readonly Rarc N685 = new(Values.N685);

    public static readonly Rarc N686 = new(Values.N686);

    public static readonly Rarc N687 = new(Values.N687);

    public static readonly Rarc N688 = new(Values.N688);

    public static readonly Rarc N689 = new(Values.N689);

    public static readonly Rarc N690 = new(Values.N690);

    public static readonly Rarc N691 = new(Values.N691);

    public static readonly Rarc N692 = new(Values.N692);

    public static readonly Rarc N693 = new(Values.N693);

    public static readonly Rarc N694 = new(Values.N694);

    public static readonly Rarc N695 = new(Values.N695);

    public static readonly Rarc N696 = new(Values.N696);

    public static readonly Rarc N697 = new(Values.N697);

    public static readonly Rarc N698 = new(Values.N698);

    public static readonly Rarc N699 = new(Values.N699);

    public static readonly Rarc N700 = new(Values.N700);

    public static readonly Rarc N701 = new(Values.N701);

    public static readonly Rarc N702 = new(Values.N702);

    public static readonly Rarc N703 = new(Values.N703);

    public static readonly Rarc N704 = new(Values.N704);

    public static readonly Rarc N705 = new(Values.N705);

    public static readonly Rarc N706 = new(Values.N706);

    public static readonly Rarc N707 = new(Values.N707);

    public static readonly Rarc N708 = new(Values.N708);

    public static readonly Rarc N709 = new(Values.N709);

    public static readonly Rarc N710 = new(Values.N710);

    public static readonly Rarc N711 = new(Values.N711);

    public static readonly Rarc N712 = new(Values.N712);

    public static readonly Rarc N713 = new(Values.N713);

    public static readonly Rarc N714 = new(Values.N714);

    public static readonly Rarc N715 = new(Values.N715);

    public static readonly Rarc N716 = new(Values.N716);

    public static readonly Rarc N717 = new(Values.N717);

    public static readonly Rarc N718 = new(Values.N718);

    public static readonly Rarc N719 = new(Values.N719);

    public static readonly Rarc N720 = new(Values.N720);

    public static readonly Rarc N721 = new(Values.N721);

    public static readonly Rarc N722 = new(Values.N722);

    public static readonly Rarc N723 = new(Values.N723);

    public static readonly Rarc N724 = new(Values.N724);

    public static readonly Rarc N725 = new(Values.N725);

    public static readonly Rarc N726 = new(Values.N726);

    public static readonly Rarc N727 = new(Values.N727);

    public static readonly Rarc N728 = new(Values.N728);

    public static readonly Rarc N729 = new(Values.N729);

    public static readonly Rarc N730 = new(Values.N730);

    public static readonly Rarc N731 = new(Values.N731);

    public static readonly Rarc N732 = new(Values.N732);

    public static readonly Rarc N733 = new(Values.N733);

    public static readonly Rarc N734 = new(Values.N734);

    public static readonly Rarc N735 = new(Values.N735);

    public static readonly Rarc N736 = new(Values.N736);

    public static readonly Rarc N737 = new(Values.N737);

    public static readonly Rarc N738 = new(Values.N738);

    public static readonly Rarc N739 = new(Values.N739);

    public static readonly Rarc N740 = new(Values.N740);

    public static readonly Rarc N741 = new(Values.N741);

    public static readonly Rarc N742 = new(Values.N742);

    public static readonly Rarc N743 = new(Values.N743);

    public static readonly Rarc N744 = new(Values.N744);

    public static readonly Rarc N745 = new(Values.N745);

    public static readonly Rarc N746 = new(Values.N746);

    public static readonly Rarc N747 = new(Values.N747);

    public static readonly Rarc N748 = new(Values.N748);

    public static readonly Rarc N749 = new(Values.N749);

    public static readonly Rarc N750 = new(Values.N750);

    public static readonly Rarc N751 = new(Values.N751);

    public static readonly Rarc N752 = new(Values.N752);

    public static readonly Rarc N753 = new(Values.N753);

    public static readonly Rarc N754 = new(Values.N754);

    public static readonly Rarc N755 = new(Values.N755);

    public static readonly Rarc N756 = new(Values.N756);

    public static readonly Rarc N757 = new(Values.N757);

    public static readonly Rarc N758 = new(Values.N758);

    public static readonly Rarc N759 = new(Values.N759);

    public static readonly Rarc N760 = new(Values.N760);

    public static readonly Rarc N761 = new(Values.N761);

    public static readonly Rarc N762 = new(Values.N762);

    public static readonly Rarc N763 = new(Values.N763);

    public static readonly Rarc N764 = new(Values.N764);

    public static readonly Rarc N765 = new(Values.N765);

    public static readonly Rarc N766 = new(Values.N766);

    public static readonly Rarc N767 = new(Values.N767);

    public static readonly Rarc N768 = new(Values.N768);

    public static readonly Rarc N769 = new(Values.N769);

    public static readonly Rarc N770 = new(Values.N770);

    public static readonly Rarc N771 = new(Values.N771);

    public static readonly Rarc N772 = new(Values.N772);

    public static readonly Rarc N773 = new(Values.N773);

    public static readonly Rarc N774 = new(Values.N774);

    public static readonly Rarc N775 = new(Values.N775);

    public static readonly Rarc N776 = new(Values.N776);

    public static readonly Rarc N777 = new(Values.N777);

    public static readonly Rarc N778 = new(Values.N778);

    public static readonly Rarc N779 = new(Values.N779);

    public static readonly Rarc N780 = new(Values.N780);

    public static readonly Rarc N781 = new(Values.N781);

    public static readonly Rarc N782 = new(Values.N782);

    public static readonly Rarc N783 = new(Values.N783);

    public static readonly Rarc N784 = new(Values.N784);

    public static readonly Rarc N785 = new(Values.N785);

    public static readonly Rarc N786 = new(Values.N786);

    public static readonly Rarc N787 = new(Values.N787);

    public static readonly Rarc N788 = new(Values.N788);

    public static readonly Rarc N789 = new(Values.N789);

    public static readonly Rarc N790 = new(Values.N790);

    public static readonly Rarc N791 = new(Values.N791);

    public static readonly Rarc N792 = new(Values.N792);

    public static readonly Rarc N793 = new(Values.N793);

    public static readonly Rarc N794 = new(Values.N794);

    public static readonly Rarc N795 = new(Values.N795);

    public static readonly Rarc N796 = new(Values.N796);

    public static readonly Rarc N797 = new(Values.N797);

    public static readonly Rarc N798 = new(Values.N798);

    public static readonly Rarc N799 = new(Values.N799);

    public static readonly Rarc N800 = new(Values.N800);

    public static readonly Rarc N801 = new(Values.N801);

    public static readonly Rarc N802 = new(Values.N802);

    public static readonly Rarc N803 = new(Values.N803);

    public static readonly Rarc N804 = new(Values.N804);

    public static readonly Rarc N805 = new(Values.N805);

    public static readonly Rarc N806 = new(Values.N806);

    public static readonly Rarc N807 = new(Values.N807);

    public static readonly Rarc N808 = new(Values.N808);

    public static readonly Rarc N809 = new(Values.N809);

    public static readonly Rarc N810 = new(Values.N810);

    public static readonly Rarc N811 = new(Values.N811);

    public static readonly Rarc N812 = new(Values.N812);

    public static readonly Rarc N815 = new(Values.N815);

    public static readonly Rarc N816 = new(Values.N816);

    public static readonly Rarc N817 = new(Values.N817);

    public static readonly Rarc N818 = new(Values.N818);

    public static readonly Rarc N819 = new(Values.N819);

    public static readonly Rarc N820 = new(Values.N820);

    public static readonly Rarc N821 = new(Values.N821);

    public static readonly Rarc N822 = new(Values.N822);

    public static readonly Rarc N823 = new(Values.N823);

    public static readonly Rarc N824 = new(Values.N824);

    public static readonly Rarc N825 = new(Values.N825);

    public static readonly Rarc N826 = new(Values.N826);

    public static readonly Rarc N827 = new(Values.N827);

    public static readonly Rarc N828 = new(Values.N828);

    public static readonly Rarc N829 = new(Values.N829);

    public static readonly Rarc N830 = new(Values.N830);

    public static readonly Rarc N831 = new(Values.N831);

    public static readonly Rarc N832 = new(Values.N832);

    public static readonly Rarc N833 = new(Values.N833);

    public static readonly Rarc N834 = new(Values.N834);

    public static readonly Rarc N835 = new(Values.N835);

    public static readonly Rarc N836 = new(Values.N836);

    public static readonly Rarc N837 = new(Values.N837);

    public static readonly Rarc N838 = new(Values.N838);

    public static readonly Rarc N839 = new(Values.N839);

    public static readonly Rarc N840 = new(Values.N840);

    public static readonly Rarc N841 = new(Values.N841);

    public static readonly Rarc N842 = new(Values.N842);

    public static readonly Rarc N843 = new(Values.N843);

    public static readonly Rarc N844 = new(Values.N844);

    public static readonly Rarc N845 = new(Values.N845);

    public static readonly Rarc N846 = new(Values.N846);

    public static readonly Rarc N847 = new(Values.N847);

    public static readonly Rarc N848 = new(Values.N848);

    public static readonly Rarc N849 = new(Values.N849);

    public static readonly Rarc N850 = new(Values.N850);

    public static readonly Rarc N851 = new(Values.N851);

    public static readonly Rarc N852 = new(Values.N852);

    public static readonly Rarc N853 = new(Values.N853);

    public static readonly Rarc N854 = new(Values.N854);

    public static readonly Rarc N855 = new(Values.N855);

    public static readonly Rarc N856 = new(Values.N856);

    public static readonly Rarc N857 = new(Values.N857);

    public static readonly Rarc N858 = new(Values.N858);

    public static readonly Rarc N859 = new(Values.N859);

    public static readonly Rarc N860 = new(Values.N860);

    public static readonly Rarc N861 = new(Values.N861);

    public static readonly Rarc N862 = new(Values.N862);

    public static readonly Rarc N863 = new(Values.N863);

    public static readonly Rarc N864 = new(Values.N864);

    public static readonly Rarc N865 = new(Values.N865);

    public static readonly Rarc N866 = new(Values.N866);

    public static readonly Rarc N867 = new(Values.N867);

    public static readonly Rarc N868 = new(Values.N868);

    public static readonly Rarc N869 = new(Values.N869);

    public static readonly Rarc N870 = new(Values.N870);

    public static readonly Rarc N871 = new(Values.N871);

    public static readonly Rarc N872 = new(Values.N872);

    public static readonly Rarc N873 = new(Values.N873);

    public static readonly Rarc N874 = new(Values.N874);

    public static readonly Rarc N875 = new(Values.N875);

    public static readonly Rarc N876 = new(Values.N876);

    public static readonly Rarc N877 = new(Values.N877);

    public static readonly Rarc N878 = new(Values.N878);

    public static readonly Rarc N879 = new(Values.N879);

    public static readonly Rarc N880 = new(Values.N880);

    public static readonly Rarc N881 = new(Values.N881);

    public static readonly Rarc N882 = new(Values.N882);

    public static readonly Rarc N883 = new(Values.N883);

    public static readonly Rarc N884 = new(Values.N884);

    public static readonly Rarc N885 = new(Values.N885);

    public static readonly Rarc N886 = new(Values.N886);

    public static readonly Rarc N887 = new(Values.N887);

    public static readonly Rarc N888 = new(Values.N888);

    public static readonly Rarc N889 = new(Values.N889);

    public static readonly Rarc N890 = new(Values.N890);

    public static readonly Rarc N891 = new(Values.N891);

    public static readonly Rarc N892 = new(Values.N892);

    public static readonly Rarc N893 = new(Values.N893);

    public static readonly Rarc N894 = new(Values.N894);

    public static readonly Rarc N895 = new(Values.N895);

    public static readonly Rarc N896 = new(Values.N896);

    public static readonly Rarc N897 = new(Values.N897);

    public static readonly Rarc N898 = new(Values.N898);

    public static readonly Rarc N899 = new(Values.N899);

    public static readonly Rarc N900 = new(Values.N900);

    public static readonly Rarc N901 = new(Values.N901);

    public static readonly Rarc N902 = new(Values.N902);

    public static readonly Rarc N903 = new(Values.N903);

    public static readonly Rarc N904 = new(Values.N904);

    public static readonly Rarc N905 = new(Values.N905);

    public static readonly Rarc N906 = new(Values.N906);

    public static readonly Rarc N907 = new(Values.N907);

    public static readonly Rarc N908 = new(Values.N908);

    public static readonly Rarc N909 = new(Values.N909);

    public static readonly Rarc N910 = new(Values.N910);

    public static readonly Rarc N911 = new(Values.N911);

    public Rarc(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static Rarc FromCustom(string value)
    {
        return new Rarc(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(Rarc value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(Rarc value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(Rarc value) => value.Value;

    public static explicit operator Rarc(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string M1 = "M1";

        public const string M2 = "M2";

        public const string M3 = "M3";

        public const string M4 = "M4";

        public const string M5 = "M5";

        public const string M6 = "M6";

        public const string M7 = "M7";

        public const string M8 = "M8";

        public const string M9 = "M9";

        public const string M10 = "M10";

        public const string M11 = "M11";

        public const string M12 = "M12";

        public const string M13 = "M13";

        public const string M14 = "M14";

        public const string M15 = "M15";

        public const string M16 = "M16";

        public const string M17 = "M17";

        public const string M18 = "M18";

        public const string M19 = "M19";

        public const string M20 = "M20";

        public const string M21 = "M21";

        public const string M22 = "M22";

        public const string M23 = "M23";

        public const string M24 = "M24";

        public const string M25 = "M25";

        public const string M26 = "M26";

        public const string M27 = "M27";

        public const string M28 = "M28";

        public const string M29 = "M29";

        public const string M30 = "M30";

        public const string M31 = "M31";

        public const string M32 = "M32";

        public const string M33 = "M33";

        public const string M34 = "M34";

        public const string M35 = "M35";

        public const string M36 = "M36";

        public const string M37 = "M37";

        public const string M38 = "M38";

        public const string M39 = "M39";

        public const string M40 = "M40";

        public const string M41 = "M41";

        public const string M42 = "M42";

        public const string M43 = "M43";

        public const string M44 = "M44";

        public const string M45 = "M45";

        public const string M46 = "M46";

        public const string M47 = "M47";

        public const string M48 = "M48";

        public const string M49 = "M49";

        public const string M50 = "M50";

        public const string M51 = "M51";

        public const string M52 = "M52";

        public const string M53 = "M53";

        public const string M54 = "M54";

        public const string M55 = "M55";

        public const string M56 = "M56";

        public const string M57 = "M57";

        public const string M58 = "M58";

        public const string M59 = "M59";

        public const string M60 = "M60";

        public const string M61 = "M61";

        public const string M62 = "M62";

        public const string M63 = "M63";

        public const string M64 = "M64";

        public const string M65 = "M65";

        public const string M66 = "M66";

        public const string M67 = "M67";

        public const string M68 = "M68";

        public const string M69 = "M69";

        public const string M70 = "M70";

        public const string M71 = "M71";

        public const string M72 = "M72";

        public const string M73 = "M73";

        public const string M74 = "M74";

        public const string M75 = "M75";

        public const string M76 = "M76";

        public const string M77 = "M77";

        public const string M78 = "M78";

        public const string M79 = "M79";

        public const string M80 = "M80";

        public const string M81 = "M81";

        public const string M82 = "M82";

        public const string M83 = "M83";

        public const string M84 = "M84";

        public const string M85 = "M85";

        public const string M86 = "M86";

        public const string M87 = "M87";

        public const string M88 = "M88";

        public const string M89 = "M89";

        public const string M90 = "M90";

        public const string M91 = "M91";

        public const string M92 = "M92";

        public const string M93 = "M93";

        public const string M94 = "M94";

        public const string M95 = "M95";

        public const string M96 = "M96";

        public const string M97 = "M97";

        public const string M98 = "M98";

        public const string M99 = "M99";

        public const string M100 = "M100";

        public const string M101 = "M101";

        public const string M102 = "M102";

        public const string M103 = "M103";

        public const string M104 = "M104";

        public const string M105 = "M105";

        public const string M106 = "M106";

        public const string M107 = "M107";

        public const string M108 = "M108";

        public const string M109 = "M109";

        public const string M110 = "M110";

        public const string M111 = "M111";

        public const string M112 = "M112";

        public const string M113 = "M113";

        public const string M114 = "M114";

        public const string M115 = "M115";

        public const string M116 = "M116";

        public const string M117 = "M117";

        public const string M118 = "M118";

        public const string M119 = "M119";

        public const string M120 = "M120";

        public const string M121 = "M121";

        public const string M122 = "M122";

        public const string M123 = "M123";

        public const string M124 = "M124";

        public const string M125 = "M125";

        public const string M126 = "M126";

        public const string M127 = "M127";

        public const string M128 = "M128";

        public const string M129 = "M129";

        public const string M130 = "M130";

        public const string M131 = "M131";

        public const string M132 = "M132";

        public const string M133 = "M133";

        public const string M134 = "M134";

        public const string M135 = "M135";

        public const string M136 = "M136";

        public const string M137 = "M137";

        public const string M138 = "M138";

        public const string M139 = "M139";

        public const string M140 = "M140";

        public const string M141 = "M141";

        public const string M142 = "M142";

        public const string M143 = "M143";

        public const string M144 = "M144";

        public const string Ma01 = "MA01";

        public const string Ma02 = "MA02";

        public const string Ma03 = "MA03";

        public const string Ma04 = "MA04";

        public const string Ma05 = "MA05";

        public const string Ma06 = "MA06";

        public const string Ma07 = "MA07";

        public const string Ma08 = "MA08";

        public const string Ma09 = "MA09";

        public const string Ma10 = "MA10";

        public const string Ma11 = "MA11";

        public const string Ma12 = "MA12";

        public const string Ma13 = "MA13";

        public const string Ma14 = "MA14";

        public const string Ma15 = "MA15";

        public const string Ma16 = "MA16";

        public const string Ma17 = "MA17";

        public const string Ma18 = "MA18";

        public const string Ma19 = "MA19";

        public const string Ma20 = "MA20";

        public const string Ma21 = "MA21";

        public const string Ma22 = "MA22";

        public const string Ma23 = "MA23";

        public const string Ma24 = "MA24";

        public const string Ma25 = "MA25";

        public const string Ma26 = "MA26";

        public const string Ma27 = "MA27";

        public const string Ma28 = "MA28";

        public const string Ma29 = "MA29";

        public const string Ma30 = "MA30";

        public const string Ma31 = "MA31";

        public const string Ma32 = "MA32";

        public const string Ma33 = "MA33";

        public const string Ma34 = "MA34";

        public const string Ma35 = "MA35";

        public const string Ma36 = "MA36";

        public const string Ma37 = "MA37";

        public const string Ma38 = "MA38";

        public const string Ma39 = "MA39";

        public const string Ma40 = "MA40";

        public const string Ma41 = "MA41";

        public const string Ma42 = "MA42";

        public const string Ma43 = "MA43";

        public const string Ma44 = "MA44";

        public const string Ma45 = "MA45";

        public const string Ma46 = "MA46";

        public const string Ma47 = "MA47";

        public const string Ma48 = "MA48";

        public const string Ma49 = "MA49";

        public const string Ma50 = "MA50";

        public const string Ma51 = "MA51";

        public const string Ma52 = "MA52";

        public const string Ma53 = "MA53";

        public const string Ma54 = "MA54";

        public const string Ma55 = "MA55";

        public const string Ma56 = "MA56";

        public const string Ma57 = "MA57";

        public const string Ma58 = "MA58";

        public const string Ma59 = "MA59";

        public const string Ma60 = "MA60";

        public const string Ma61 = "MA61";

        public const string Ma62 = "MA62";

        public const string Ma63 = "MA63";

        public const string Ma64 = "MA64";

        public const string Ma65 = "MA65";

        public const string Ma66 = "MA66";

        public const string Ma67 = "MA67";

        public const string Ma68 = "MA68";

        public const string Ma69 = "MA69";

        public const string Ma70 = "MA70";

        public const string Ma71 = "MA71";

        public const string Ma72 = "MA72";

        public const string Ma73 = "MA73";

        public const string Ma74 = "MA74";

        public const string Ma75 = "MA75";

        public const string Ma76 = "MA76";

        public const string Ma77 = "MA77";

        public const string Ma78 = "MA78";

        public const string Ma79 = "MA79";

        public const string Ma80 = "MA80";

        public const string Ma81 = "MA81";

        public const string Ma82 = "MA82";

        public const string Ma83 = "MA83";

        public const string Ma84 = "MA84";

        public const string Ma85 = "MA85";

        public const string Ma86 = "MA86";

        public const string Ma87 = "MA87";

        public const string Ma88 = "MA88";

        public const string Ma89 = "MA89";

        public const string Ma90 = "MA90";

        public const string Ma91 = "MA91";

        public const string Ma92 = "MA92";

        public const string Ma93 = "MA93";

        public const string Ma94 = "MA94";

        public const string Ma95 = "MA95";

        public const string Ma96 = "MA96";

        public const string Ma97 = "MA97";

        public const string Ma98 = "MA98";

        public const string Ma99 = "MA99";

        public const string Ma100 = "MA100";

        public const string Ma101 = "MA101";

        public const string Ma102 = "MA102";

        public const string Ma103 = "MA103";

        public const string Ma104 = "MA104";

        public const string Ma105 = "MA105";

        public const string Ma106 = "MA106";

        public const string Ma107 = "MA107";

        public const string Ma108 = "MA108";

        public const string Ma109 = "MA109";

        public const string Ma110 = "MA110";

        public const string Ma111 = "MA111";

        public const string Ma112 = "MA112";

        public const string Ma113 = "MA113";

        public const string Ma114 = "MA114";

        public const string Ma115 = "MA115";

        public const string Ma116 = "MA116";

        public const string Ma117 = "MA117";

        public const string Ma118 = "MA118";

        public const string Ma119 = "MA119";

        public const string Ma120 = "MA120";

        public const string Ma121 = "MA121";

        public const string Ma122 = "MA122";

        public const string Ma123 = "MA123";

        public const string Ma124 = "MA124";

        public const string Ma125 = "MA125";

        public const string Ma126 = "MA126";

        public const string Ma127 = "MA127";

        public const string Ma128 = "MA128";

        public const string Ma129 = "MA129";

        public const string Ma130 = "MA130";

        public const string Ma131 = "MA131";

        public const string Ma132 = "MA132";

        public const string Ma133 = "MA133";

        public const string Ma134 = "MA134";

        public const string N1 = "N1";

        public const string N2 = "N2";

        public const string N3 = "N3";

        public const string N4 = "N4";

        public const string N5 = "N5";

        public const string N6 = "N6";

        public const string N7 = "N7";

        public const string N8 = "N8";

        public const string N9 = "N9";

        public const string N10 = "N10";

        public const string N11 = "N11";

        public const string N12 = "N12";

        public const string N13 = "N13";

        public const string N14 = "N14";

        public const string N15 = "N15";

        public const string N16 = "N16";

        public const string N17 = "N17";

        public const string N18 = "N18";

        public const string N19 = "N19";

        public const string N20 = "N20";

        public const string N21 = "N21";

        public const string N22 = "N22";

        public const string N23 = "N23";

        public const string N24 = "N24";

        public const string N25 = "N25";

        public const string N26 = "N26";

        public const string N27 = "N27";

        public const string N28 = "N28";

        public const string N29 = "N29";

        public const string N30 = "N30";

        public const string N31 = "N31";

        public const string N32 = "N32";

        public const string N33 = "N33";

        public const string N34 = "N34";

        public const string N35 = "N35";

        public const string N36 = "N36";

        public const string N37 = "N37";

        public const string N38 = "N38";

        public const string N39 = "N39";

        public const string N40 = "N40";

        public const string N41 = "N41";

        public const string N42 = "N42";

        public const string N43 = "N43";

        public const string N44 = "N44";

        public const string N45 = "N45";

        public const string N46 = "N46";

        public const string N47 = "N47";

        public const string N48 = "N48";

        public const string N49 = "N49";

        public const string N50 = "N50";

        public const string N51 = "N51";

        public const string N52 = "N52";

        public const string N53 = "N53";

        public const string N54 = "N54";

        public const string N55 = "N55";

        public const string N56 = "N56";

        public const string N57 = "N57";

        public const string N58 = "N58";

        public const string N59 = "N59";

        public const string N60 = "N60";

        public const string N61 = "N61";

        public const string N62 = "N62";

        public const string N63 = "N63";

        public const string N64 = "N64";

        public const string N65 = "N65";

        public const string N66 = "N66";

        public const string N67 = "N67";

        public const string N68 = "N68";

        public const string N69 = "N69";

        public const string N70 = "N70";

        public const string N71 = "N71";

        public const string N72 = "N72";

        public const string N73 = "N73";

        public const string N74 = "N74";

        public const string N75 = "N75";

        public const string N76 = "N76";

        public const string N77 = "N77";

        public const string N78 = "N78";

        public const string N79 = "N79";

        public const string N80 = "N80";

        public const string N81 = "N81";

        public const string N82 = "N82";

        public const string N83 = "N83";

        public const string N84 = "N84";

        public const string N85 = "N85";

        public const string N86 = "N86";

        public const string N87 = "N87";

        public const string N88 = "N88";

        public const string N89 = "N89";

        public const string N90 = "N90";

        public const string N91 = "N91";

        public const string N92 = "N92";

        public const string N93 = "N93";

        public const string N94 = "N94";

        public const string N95 = "N95";

        public const string N96 = "N96";

        public const string N97 = "N97";

        public const string N98 = "N98";

        public const string N99 = "N99";

        public const string N100 = "N100";

        public const string N101 = "N101";

        public const string N102 = "N102";

        public const string N103 = "N103";

        public const string N104 = "N104";

        public const string N105 = "N105";

        public const string N106 = "N106";

        public const string N107 = "N107";

        public const string N108 = "N108";

        public const string N109 = "N109";

        public const string N110 = "N110";

        public const string N111 = "N111";

        public const string N112 = "N112";

        public const string N113 = "N113";

        public const string N114 = "N114";

        public const string N115 = "N115";

        public const string N116 = "N116";

        public const string N117 = "N117";

        public const string N118 = "N118";

        public const string N119 = "N119";

        public const string N120 = "N120";

        public const string N121 = "N121";

        public const string N122 = "N122";

        public const string N123 = "N123";

        public const string N124 = "N124";

        public const string N125 = "N125";

        public const string N126 = "N126";

        public const string N127 = "N127";

        public const string N128 = "N128";

        public const string N129 = "N129";

        public const string N130 = "N130";

        public const string N131 = "N131";

        public const string N132 = "N132";

        public const string N133 = "N133";

        public const string N134 = "N134";

        public const string N135 = "N135";

        public const string N136 = "N136";

        public const string N137 = "N137";

        public const string N138 = "N138";

        public const string N139 = "N139";

        public const string N140 = "N140";

        public const string N141 = "N141";

        public const string N142 = "N142";

        public const string N143 = "N143";

        public const string N144 = "N144";

        public const string N145 = "N145";

        public const string N146 = "N146";

        public const string N147 = "N147";

        public const string N148 = "N148";

        public const string N149 = "N149";

        public const string N150 = "N150";

        public const string N151 = "N151";

        public const string N152 = "N152";

        public const string N153 = "N153";

        public const string N154 = "N154";

        public const string N155 = "N155";

        public const string N156 = "N156";

        public const string N157 = "N157";

        public const string N158 = "N158";

        public const string N159 = "N159";

        public const string N160 = "N160";

        public const string N161 = "N161";

        public const string N162 = "N162";

        public const string N163 = "N163";

        public const string N164 = "N164";

        public const string N165 = "N165";

        public const string N166 = "N166";

        public const string N167 = "N167";

        public const string N168 = "N168";

        public const string N169 = "N169";

        public const string N170 = "N170";

        public const string N171 = "N171";

        public const string N172 = "N172";

        public const string N173 = "N173";

        public const string N174 = "N174";

        public const string N175 = "N175";

        public const string N176 = "N176";

        public const string N177 = "N177";

        public const string N178 = "N178";

        public const string N179 = "N179";

        public const string N180 = "N180";

        public const string N181 = "N181";

        public const string N182 = "N182";

        public const string N183 = "N183";

        public const string N184 = "N184";

        public const string N185 = "N185";

        public const string N186 = "N186";

        public const string N187 = "N187";

        public const string N188 = "N188";

        public const string N189 = "N189";

        public const string N190 = "N190";

        public const string N191 = "N191";

        public const string N192 = "N192";

        public const string N193 = "N193";

        public const string N194 = "N194";

        public const string N195 = "N195";

        public const string N196 = "N196";

        public const string N197 = "N197";

        public const string N198 = "N198";

        public const string N199 = "N199";

        public const string N200 = "N200";

        public const string N201 = "N201";

        public const string N202 = "N202";

        public const string N203 = "N203";

        public const string N204 = "N204";

        public const string N205 = "N205";

        public const string N206 = "N206";

        public const string N207 = "N207";

        public const string N208 = "N208";

        public const string N209 = "N209";

        public const string N210 = "N210";

        public const string N211 = "N211";

        public const string N212 = "N212";

        public const string N213 = "N213";

        public const string N214 = "N214";

        public const string N215 = "N215";

        public const string N216 = "N216";

        public const string N217 = "N217";

        public const string N218 = "N218";

        public const string N219 = "N219";

        public const string N220 = "N220";

        public const string N221 = "N221";

        public const string N222 = "N222";

        public const string N223 = "N223";

        public const string N224 = "N224";

        public const string N225 = "N225";

        public const string N226 = "N226";

        public const string N227 = "N227";

        public const string N228 = "N228";

        public const string N229 = "N229";

        public const string N230 = "N230";

        public const string N231 = "N231";

        public const string N232 = "N232";

        public const string N233 = "N233";

        public const string N234 = "N234";

        public const string N235 = "N235";

        public const string N236 = "N236";

        public const string N237 = "N237";

        public const string N238 = "N238";

        public const string N239 = "N239";

        public const string N240 = "N240";

        public const string N241 = "N241";

        public const string N242 = "N242";

        public const string N243 = "N243";

        public const string N244 = "N244";

        public const string N245 = "N245";

        public const string N246 = "N246";

        public const string N247 = "N247";

        public const string N248 = "N248";

        public const string N249 = "N249";

        public const string N250 = "N250";

        public const string N251 = "N251";

        public const string N252 = "N252";

        public const string N253 = "N253";

        public const string N254 = "N254";

        public const string N255 = "N255";

        public const string N256 = "N256";

        public const string N257 = "N257";

        public const string N258 = "N258";

        public const string N259 = "N259";

        public const string N260 = "N260";

        public const string N261 = "N261";

        public const string N262 = "N262";

        public const string N263 = "N263";

        public const string N264 = "N264";

        public const string N265 = "N265";

        public const string N266 = "N266";

        public const string N267 = "N267";

        public const string N268 = "N268";

        public const string N269 = "N269";

        public const string N270 = "N270";

        public const string N271 = "N271";

        public const string N272 = "N272";

        public const string N273 = "N273";

        public const string N274 = "N274";

        public const string N275 = "N275";

        public const string N276 = "N276";

        public const string N277 = "N277";

        public const string N278 = "N278";

        public const string N279 = "N279";

        public const string N280 = "N280";

        public const string N281 = "N281";

        public const string N282 = "N282";

        public const string N283 = "N283";

        public const string N284 = "N284";

        public const string N285 = "N285";

        public const string N286 = "N286";

        public const string N287 = "N287";

        public const string N288 = "N288";

        public const string N289 = "N289";

        public const string N290 = "N290";

        public const string N291 = "N291";

        public const string N292 = "N292";

        public const string N293 = "N293";

        public const string N294 = "N294";

        public const string N295 = "N295";

        public const string N296 = "N296";

        public const string N297 = "N297";

        public const string N298 = "N298";

        public const string N299 = "N299";

        public const string N300 = "N300";

        public const string N301 = "N301";

        public const string N302 = "N302";

        public const string N303 = "N303";

        public const string N304 = "N304";

        public const string N305 = "N305";

        public const string N306 = "N306";

        public const string N307 = "N307";

        public const string N308 = "N308";

        public const string N309 = "N309";

        public const string N310 = "N310";

        public const string N311 = "N311";

        public const string N312 = "N312";

        public const string N313 = "N313";

        public const string N314 = "N314";

        public const string N315 = "N315";

        public const string N316 = "N316";

        public const string N317 = "N317";

        public const string N318 = "N318";

        public const string N319 = "N319";

        public const string N320 = "N320";

        public const string N321 = "N321";

        public const string N322 = "N322";

        public const string N323 = "N323";

        public const string N324 = "N324";

        public const string N325 = "N325";

        public const string N326 = "N326";

        public const string N327 = "N327";

        public const string N328 = "N328";

        public const string N329 = "N329";

        public const string N330 = "N330";

        public const string N331 = "N331";

        public const string N332 = "N332";

        public const string N333 = "N333";

        public const string N334 = "N334";

        public const string N335 = "N335";

        public const string N336 = "N336";

        public const string N337 = "N337";

        public const string N338 = "N338";

        public const string N339 = "N339";

        public const string N340 = "N340";

        public const string N341 = "N341";

        public const string N342 = "N342";

        public const string N343 = "N343";

        public const string N344 = "N344";

        public const string N345 = "N345";

        public const string N346 = "N346";

        public const string N347 = "N347";

        public const string N348 = "N348";

        public const string N349 = "N349";

        public const string N350 = "N350";

        public const string N351 = "N351";

        public const string N352 = "N352";

        public const string N353 = "N353";

        public const string N354 = "N354";

        public const string N355 = "N355";

        public const string N356 = "N356";

        public const string N357 = "N357";

        public const string N358 = "N358";

        public const string N359 = "N359";

        public const string N360 = "N360";

        public const string N361 = "N361";

        public const string N362 = "N362";

        public const string N363 = "N363";

        public const string N364 = "N364";

        public const string N365 = "N365";

        public const string N366 = "N366";

        public const string N367 = "N367";

        public const string N368 = "N368";

        public const string N369 = "N369";

        public const string N370 = "N370";

        public const string N371 = "N371";

        public const string N372 = "N372";

        public const string N373 = "N373";

        public const string N374 = "N374";

        public const string N375 = "N375";

        public const string N376 = "N376";

        public const string N377 = "N377";

        public const string N378 = "N378";

        public const string N379 = "N379";

        public const string N380 = "N380";

        public const string N381 = "N381";

        public const string N382 = "N382";

        public const string N383 = "N383";

        public const string N384 = "N384";

        public const string N385 = "N385";

        public const string N386 = "N386";

        public const string N387 = "N387";

        public const string N388 = "N388";

        public const string N389 = "N389";

        public const string N390 = "N390";

        public const string N391 = "N391";

        public const string N392 = "N392";

        public const string N393 = "N393";

        public const string N394 = "N394";

        public const string N395 = "N395";

        public const string N396 = "N396";

        public const string N397 = "N397";

        public const string N398 = "N398";

        public const string N399 = "N399";

        public const string N400 = "N400";

        public const string N401 = "N401";

        public const string N402 = "N402";

        public const string N403 = "N403";

        public const string N404 = "N404";

        public const string N405 = "N405";

        public const string N406 = "N406";

        public const string N407 = "N407";

        public const string N408 = "N408";

        public const string N409 = "N409";

        public const string N410 = "N410";

        public const string N411 = "N411";

        public const string N412 = "N412";

        public const string N413 = "N413";

        public const string N414 = "N414";

        public const string N415 = "N415";

        public const string N416 = "N416";

        public const string N417 = "N417";

        public const string N418 = "N418";

        public const string N419 = "N419";

        public const string N420 = "N420";

        public const string N421 = "N421";

        public const string N422 = "N422";

        public const string N423 = "N423";

        public const string N424 = "N424";

        public const string N425 = "N425";

        public const string N426 = "N426";

        public const string N427 = "N427";

        public const string N428 = "N428";

        public const string N429 = "N429";

        public const string N430 = "N430";

        public const string N431 = "N431";

        public const string N432 = "N432";

        public const string N433 = "N433";

        public const string N434 = "N434";

        public const string N435 = "N435";

        public const string N436 = "N436";

        public const string N437 = "N437";

        public const string N438 = "N438";

        public const string N439 = "N439";

        public const string N440 = "N440";

        public const string N441 = "N441";

        public const string N442 = "N442";

        public const string N443 = "N443";

        public const string N444 = "N444";

        public const string N445 = "N445";

        public const string N446 = "N446";

        public const string N447 = "N447";

        public const string N448 = "N448";

        public const string N449 = "N449";

        public const string N450 = "N450";

        public const string N451 = "N451";

        public const string N452 = "N452";

        public const string N453 = "N453";

        public const string N454 = "N454";

        public const string N455 = "N455";

        public const string N456 = "N456";

        public const string N457 = "N457";

        public const string N458 = "N458";

        public const string N459 = "N459";

        public const string N460 = "N460";

        public const string N461 = "N461";

        public const string N462 = "N462";

        public const string N463 = "N463";

        public const string N464 = "N464";

        public const string N465 = "N465";

        public const string N466 = "N466";

        public const string N467 = "N467";

        public const string N468 = "N468";

        public const string N469 = "N469";

        public const string N470 = "N470";

        public const string N471 = "N471";

        public const string N472 = "N472";

        public const string N473 = "N473";

        public const string N474 = "N474";

        public const string N475 = "N475";

        public const string N476 = "N476";

        public const string N477 = "N477";

        public const string N478 = "N478";

        public const string N479 = "N479";

        public const string N480 = "N480";

        public const string N481 = "N481";

        public const string N482 = "N482";

        public const string N483 = "N483";

        public const string N484 = "N484";

        public const string N485 = "N485";

        public const string N486 = "N486";

        public const string N487 = "N487";

        public const string N488 = "N488";

        public const string N489 = "N489";

        public const string N490 = "N490";

        public const string N491 = "N491";

        public const string N492 = "N492";

        public const string N493 = "N493";

        public const string N494 = "N494";

        public const string N495 = "N495";

        public const string N496 = "N496";

        public const string N497 = "N497";

        public const string N498 = "N498";

        public const string N499 = "N499";

        public const string N500 = "N500";

        public const string N501 = "N501";

        public const string N502 = "N502";

        public const string N503 = "N503";

        public const string N504 = "N504";

        public const string N505 = "N505";

        public const string N506 = "N506";

        public const string N507 = "N507";

        public const string N508 = "N508";

        public const string N509 = "N509";

        public const string N510 = "N510";

        public const string N511 = "N511";

        public const string N512 = "N512";

        public const string N513 = "N513";

        public const string N514 = "N514";

        public const string N515 = "N515";

        public const string N516 = "N516";

        public const string N517 = "N517";

        public const string N518 = "N518";

        public const string N519 = "N519";

        public const string N520 = "N520";

        public const string N521 = "N521";

        public const string N522 = "N522";

        public const string N523 = "N523";

        public const string N524 = "N524";

        public const string N525 = "N525";

        public const string N526 = "N526";

        public const string N527 = "N527";

        public const string N528 = "N528";

        public const string N529 = "N529";

        public const string N530 = "N530";

        public const string N531 = "N531";

        public const string N532 = "N532";

        public const string N533 = "N533";

        public const string N534 = "N534";

        public const string N535 = "N535";

        public const string N536 = "N536";

        public const string N537 = "N537";

        public const string N538 = "N538";

        public const string N539 = "N539";

        public const string N540 = "N540";

        public const string N541 = "N541";

        public const string N542 = "N542";

        public const string N543 = "N543";

        public const string N544 = "N544";

        public const string N545 = "N545";

        public const string N546 = "N546";

        public const string N547 = "N547";

        public const string N548 = "N548";

        public const string N549 = "N549";

        public const string N550 = "N550";

        public const string N551 = "N551";

        public const string N552 = "N552";

        public const string N553 = "N553";

        public const string N554 = "N554";

        public const string N555 = "N555";

        public const string N556 = "N556";

        public const string N557 = "N557";

        public const string N558 = "N558";

        public const string N559 = "N559";

        public const string N560 = "N560";

        public const string N561 = "N561";

        public const string N562 = "N562";

        public const string N563 = "N563";

        public const string N564 = "N564";

        public const string N565 = "N565";

        public const string N566 = "N566";

        public const string N567 = "N567";

        public const string N568 = "N568";

        public const string N569 = "N569";

        public const string N570 = "N570";

        public const string N571 = "N571";

        public const string N572 = "N572";

        public const string N573 = "N573";

        public const string N574 = "N574";

        public const string N575 = "N575";

        public const string N576 = "N576";

        public const string N577 = "N577";

        public const string N578 = "N578";

        public const string N579 = "N579";

        public const string N580 = "N580";

        public const string N581 = "N581";

        public const string N582 = "N582";

        public const string N583 = "N583";

        public const string N584 = "N584";

        public const string N585 = "N585";

        public const string N586 = "N586";

        public const string N587 = "N587";

        public const string N588 = "N588";

        public const string N589 = "N589";

        public const string N590 = "N590";

        public const string N591 = "N591";

        public const string N592 = "N592";

        public const string N593 = "N593";

        public const string N594 = "N594";

        public const string N595 = "N595";

        public const string N596 = "N596";

        public const string N597 = "N597";

        public const string N598 = "N598";

        public const string N599 = "N599";

        public const string N600 = "N600";

        public const string N601 = "N601";

        public const string N602 = "N602";

        public const string N603 = "N603";

        public const string N604 = "N604";

        public const string N605 = "N605";

        public const string N606 = "N606";

        public const string N607 = "N607";

        public const string N608 = "N608";

        public const string N609 = "N609";

        public const string N610 = "N610";

        public const string N611 = "N611";

        public const string N612 = "N612";

        public const string N613 = "N613";

        public const string N614 = "N614";

        public const string N615 = "N615";

        public const string N616 = "N616";

        public const string N617 = "N617";

        public const string N618 = "N618";

        public const string N619 = "N619";

        public const string N620 = "N620";

        public const string N621 = "N621";

        public const string N622 = "N622";

        public const string N623 = "N623";

        public const string N624 = "N624";

        public const string N625 = "N625";

        public const string N626 = "N626";

        public const string N627 = "N627";

        public const string N628 = "N628";

        public const string N629 = "N629";

        public const string N630 = "N630";

        public const string N631 = "N631";

        public const string N632 = "N632";

        public const string N633 = "N633";

        public const string N634 = "N634";

        public const string N635 = "N635";

        public const string N636 = "N636";

        public const string N637 = "N637";

        public const string N638 = "N638";

        public const string N639 = "N639";

        public const string N640 = "N640";

        public const string N641 = "N641";

        public const string N642 = "N642";

        public const string N643 = "N643";

        public const string N644 = "N644";

        public const string N645 = "N645";

        public const string N646 = "N646";

        public const string N647 = "N647";

        public const string N648 = "N648";

        public const string N649 = "N649";

        public const string N650 = "N650";

        public const string N651 = "N651";

        public const string N652 = "N652";

        public const string N653 = "N653";

        public const string N654 = "N654";

        public const string N655 = "N655";

        public const string N656 = "N656";

        public const string N657 = "N657";

        public const string N658 = "N658";

        public const string N659 = "N659";

        public const string N660 = "N660";

        public const string N661 = "N661";

        public const string N662 = "N662";

        public const string N663 = "N663";

        public const string N664 = "N664";

        public const string N665 = "N665";

        public const string N666 = "N666";

        public const string N667 = "N667";

        public const string N668 = "N668";

        public const string N669 = "N669";

        public const string N670 = "N670";

        public const string N671 = "N671";

        public const string N672 = "N672";

        public const string N673 = "N673";

        public const string N674 = "N674";

        public const string N675 = "N675";

        public const string N676 = "N676";

        public const string N677 = "N677";

        public const string N678 = "N678";

        public const string N679 = "N679";

        public const string N680 = "N680";

        public const string N681 = "N681";

        public const string N682 = "N682";

        public const string N683 = "N683";

        public const string N684 = "N684";

        public const string N685 = "N685";

        public const string N686 = "N686";

        public const string N687 = "N687";

        public const string N688 = "N688";

        public const string N689 = "N689";

        public const string N690 = "N690";

        public const string N691 = "N691";

        public const string N692 = "N692";

        public const string N693 = "N693";

        public const string N694 = "N694";

        public const string N695 = "N695";

        public const string N696 = "N696";

        public const string N697 = "N697";

        public const string N698 = "N698";

        public const string N699 = "N699";

        public const string N700 = "N700";

        public const string N701 = "N701";

        public const string N702 = "N702";

        public const string N703 = "N703";

        public const string N704 = "N704";

        public const string N705 = "N705";

        public const string N706 = "N706";

        public const string N707 = "N707";

        public const string N708 = "N708";

        public const string N709 = "N709";

        public const string N710 = "N710";

        public const string N711 = "N711";

        public const string N712 = "N712";

        public const string N713 = "N713";

        public const string N714 = "N714";

        public const string N715 = "N715";

        public const string N716 = "N716";

        public const string N717 = "N717";

        public const string N718 = "N718";

        public const string N719 = "N719";

        public const string N720 = "N720";

        public const string N721 = "N721";

        public const string N722 = "N722";

        public const string N723 = "N723";

        public const string N724 = "N724";

        public const string N725 = "N725";

        public const string N726 = "N726";

        public const string N727 = "N727";

        public const string N728 = "N728";

        public const string N729 = "N729";

        public const string N730 = "N730";

        public const string N731 = "N731";

        public const string N732 = "N732";

        public const string N733 = "N733";

        public const string N734 = "N734";

        public const string N735 = "N735";

        public const string N736 = "N736";

        public const string N737 = "N737";

        public const string N738 = "N738";

        public const string N739 = "N739";

        public const string N740 = "N740";

        public const string N741 = "N741";

        public const string N742 = "N742";

        public const string N743 = "N743";

        public const string N744 = "N744";

        public const string N745 = "N745";

        public const string N746 = "N746";

        public const string N747 = "N747";

        public const string N748 = "N748";

        public const string N749 = "N749";

        public const string N750 = "N750";

        public const string N751 = "N751";

        public const string N752 = "N752";

        public const string N753 = "N753";

        public const string N754 = "N754";

        public const string N755 = "N755";

        public const string N756 = "N756";

        public const string N757 = "N757";

        public const string N758 = "N758";

        public const string N759 = "N759";

        public const string N760 = "N760";

        public const string N761 = "N761";

        public const string N762 = "N762";

        public const string N763 = "N763";

        public const string N764 = "N764";

        public const string N765 = "N765";

        public const string N766 = "N766";

        public const string N767 = "N767";

        public const string N768 = "N768";

        public const string N769 = "N769";

        public const string N770 = "N770";

        public const string N771 = "N771";

        public const string N772 = "N772";

        public const string N773 = "N773";

        public const string N774 = "N774";

        public const string N775 = "N775";

        public const string N776 = "N776";

        public const string N777 = "N777";

        public const string N778 = "N778";

        public const string N779 = "N779";

        public const string N780 = "N780";

        public const string N781 = "N781";

        public const string N782 = "N782";

        public const string N783 = "N783";

        public const string N784 = "N784";

        public const string N785 = "N785";

        public const string N786 = "N786";

        public const string N787 = "N787";

        public const string N788 = "N788";

        public const string N789 = "N789";

        public const string N790 = "N790";

        public const string N791 = "N791";

        public const string N792 = "N792";

        public const string N793 = "N793";

        public const string N794 = "N794";

        public const string N795 = "N795";

        public const string N796 = "N796";

        public const string N797 = "N797";

        public const string N798 = "N798";

        public const string N799 = "N799";

        public const string N800 = "N800";

        public const string N801 = "N801";

        public const string N802 = "N802";

        public const string N803 = "N803";

        public const string N804 = "N804";

        public const string N805 = "N805";

        public const string N806 = "N806";

        public const string N807 = "N807";

        public const string N808 = "N808";

        public const string N809 = "N809";

        public const string N810 = "N810";

        public const string N811 = "N811";

        public const string N812 = "N812";

        public const string N815 = "N815";

        public const string N816 = "N816";

        public const string N817 = "N817";

        public const string N818 = "N818";

        public const string N819 = "N819";

        public const string N820 = "N820";

        public const string N821 = "N821";

        public const string N822 = "N822";

        public const string N823 = "N823";

        public const string N824 = "N824";

        public const string N825 = "N825";

        public const string N826 = "N826";

        public const string N827 = "N827";

        public const string N828 = "N828";

        public const string N829 = "N829";

        public const string N830 = "N830";

        public const string N831 = "N831";

        public const string N832 = "N832";

        public const string N833 = "N833";

        public const string N834 = "N834";

        public const string N835 = "N835";

        public const string N836 = "N836";

        public const string N837 = "N837";

        public const string N838 = "N838";

        public const string N839 = "N839";

        public const string N840 = "N840";

        public const string N841 = "N841";

        public const string N842 = "N842";

        public const string N843 = "N843";

        public const string N844 = "N844";

        public const string N845 = "N845";

        public const string N846 = "N846";

        public const string N847 = "N847";

        public const string N848 = "N848";

        public const string N849 = "N849";

        public const string N850 = "N850";

        public const string N851 = "N851";

        public const string N852 = "N852";

        public const string N853 = "N853";

        public const string N854 = "N854";

        public const string N855 = "N855";

        public const string N856 = "N856";

        public const string N857 = "N857";

        public const string N858 = "N858";

        public const string N859 = "N859";

        public const string N860 = "N860";

        public const string N861 = "N861";

        public const string N862 = "N862";

        public const string N863 = "N863";

        public const string N864 = "N864";

        public const string N865 = "N865";

        public const string N866 = "N866";

        public const string N867 = "N867";

        public const string N868 = "N868";

        public const string N869 = "N869";

        public const string N870 = "N870";

        public const string N871 = "N871";

        public const string N872 = "N872";

        public const string N873 = "N873";

        public const string N874 = "N874";

        public const string N875 = "N875";

        public const string N876 = "N876";

        public const string N877 = "N877";

        public const string N878 = "N878";

        public const string N879 = "N879";

        public const string N880 = "N880";

        public const string N881 = "N881";

        public const string N882 = "N882";

        public const string N883 = "N883";

        public const string N884 = "N884";

        public const string N885 = "N885";

        public const string N886 = "N886";

        public const string N887 = "N887";

        public const string N888 = "N888";

        public const string N889 = "N889";

        public const string N890 = "N890";

        public const string N891 = "N891";

        public const string N892 = "N892";

        public const string N893 = "N893";

        public const string N894 = "N894";

        public const string N895 = "N895";

        public const string N896 = "N896";

        public const string N897 = "N897";

        public const string N898 = "N898";

        public const string N899 = "N899";

        public const string N900 = "N900";

        public const string N901 = "N901";

        public const string N902 = "N902";

        public const string N903 = "N903";

        public const string N904 = "N904";

        public const string N905 = "N905";

        public const string N906 = "N906";

        public const string N907 = "N907";

        public const string N908 = "N908";

        public const string N909 = "N909";

        public const string N910 = "N910";

        public const string N911 = "N911";
    }
}
