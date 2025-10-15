using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(StringEnumSerializer<Carc>))]
[Serializable]
public readonly record struct Carc : IStringEnum
{
    public static readonly Carc Carc1 = new(Values.Carc1);

    public static readonly Carc Carc2 = new(Values.Carc2);

    public static readonly Carc Carc3 = new(Values.Carc3);

    public static readonly Carc Carc4 = new(Values.Carc4);

    public static readonly Carc Carc5 = new(Values.Carc5);

    public static readonly Carc Carc6 = new(Values.Carc6);

    public static readonly Carc Carc7 = new(Values.Carc7);

    public static readonly Carc Carc8 = new(Values.Carc8);

    public static readonly Carc Carc9 = new(Values.Carc9);

    public static readonly Carc Carc10 = new(Values.Carc10);

    public static readonly Carc Carc11 = new(Values.Carc11);

    public static readonly Carc Carc12 = new(Values.Carc12);

    public static readonly Carc Carc13 = new(Values.Carc13);

    public static readonly Carc Carc14 = new(Values.Carc14);

    public static readonly Carc Carc16 = new(Values.Carc16);

    public static readonly Carc Carc18 = new(Values.Carc18);

    public static readonly Carc Carc19 = new(Values.Carc19);

    public static readonly Carc Carc20 = new(Values.Carc20);

    public static readonly Carc Carc21 = new(Values.Carc21);

    public static readonly Carc Carc22 = new(Values.Carc22);

    public static readonly Carc Carc23 = new(Values.Carc23);

    public static readonly Carc Carc24 = new(Values.Carc24);

    public static readonly Carc Carc26 = new(Values.Carc26);

    public static readonly Carc Carc27 = new(Values.Carc27);

    public static readonly Carc Carc29 = new(Values.Carc29);

    public static readonly Carc Carc31 = new(Values.Carc31);

    public static readonly Carc Carc32 = new(Values.Carc32);

    public static readonly Carc Carc33 = new(Values.Carc33);

    public static readonly Carc Carc34 = new(Values.Carc34);

    public static readonly Carc Carc35 = new(Values.Carc35);

    public static readonly Carc Carc39 = new(Values.Carc39);

    public static readonly Carc Carc40 = new(Values.Carc40);

    public static readonly Carc Carc44 = new(Values.Carc44);

    public static readonly Carc Carc45 = new(Values.Carc45);

    public static readonly Carc Carc49 = new(Values.Carc49);

    public static readonly Carc Carc50 = new(Values.Carc50);

    public static readonly Carc Carc51 = new(Values.Carc51);

    public static readonly Carc Carc53 = new(Values.Carc53);

    public static readonly Carc Carc54 = new(Values.Carc54);

    public static readonly Carc Carc55 = new(Values.Carc55);

    public static readonly Carc Carc56 = new(Values.Carc56);

    public static readonly Carc Carc58 = new(Values.Carc58);

    public static readonly Carc Carc59 = new(Values.Carc59);

    public static readonly Carc Carc60 = new(Values.Carc60);

    public static readonly Carc Carc61 = new(Values.Carc61);

    public static readonly Carc Carc66 = new(Values.Carc66);

    public static readonly Carc Carc69 = new(Values.Carc69);

    public static readonly Carc Carc70 = new(Values.Carc70);

    public static readonly Carc Carc74 = new(Values.Carc74);

    public static readonly Carc Carc75 = new(Values.Carc75);

    public static readonly Carc Carc76 = new(Values.Carc76);

    public static readonly Carc Carc78 = new(Values.Carc78);

    public static readonly Carc Carc85 = new(Values.Carc85);

    public static readonly Carc Carc89 = new(Values.Carc89);

    public static readonly Carc Carc90 = new(Values.Carc90);

    public static readonly Carc Carc91 = new(Values.Carc91);

    public static readonly Carc Carc94 = new(Values.Carc94);

    public static readonly Carc Carc95 = new(Values.Carc95);

    public static readonly Carc Carc96 = new(Values.Carc96);

    public static readonly Carc Carc97 = new(Values.Carc97);

    public static readonly Carc Carc100 = new(Values.Carc100);

    public static readonly Carc Carc101 = new(Values.Carc101);

    public static readonly Carc Carc102 = new(Values.Carc102);

    public static readonly Carc Carc103 = new(Values.Carc103);

    public static readonly Carc Carc104 = new(Values.Carc104);

    public static readonly Carc Carc105 = new(Values.Carc105);

    public static readonly Carc Carc106 = new(Values.Carc106);

    public static readonly Carc Carc107 = new(Values.Carc107);

    public static readonly Carc Carc108 = new(Values.Carc108);

    public static readonly Carc Carc109 = new(Values.Carc109);

    public static readonly Carc Carc110 = new(Values.Carc110);

    public static readonly Carc Carc111 = new(Values.Carc111);

    public static readonly Carc Carc112 = new(Values.Carc112);

    public static readonly Carc Carc114 = new(Values.Carc114);

    public static readonly Carc Carc115 = new(Values.Carc115);

    public static readonly Carc Carc116 = new(Values.Carc116);

    public static readonly Carc Carc117 = new(Values.Carc117);

    public static readonly Carc Carc118 = new(Values.Carc118);

    public static readonly Carc Carc119 = new(Values.Carc119);

    public static readonly Carc Carc121 = new(Values.Carc121);

    public static readonly Carc Carc122 = new(Values.Carc122);

    public static readonly Carc Carc125 = new(Values.Carc125);

    public static readonly Carc Carc128 = new(Values.Carc128);

    public static readonly Carc Carc129 = new(Values.Carc129);

    public static readonly Carc Carc130 = new(Values.Carc130);

    public static readonly Carc Carc131 = new(Values.Carc131);

    public static readonly Carc Carc132 = new(Values.Carc132);

    public static readonly Carc Carc133 = new(Values.Carc133);

    public static readonly Carc Carc134 = new(Values.Carc134);

    public static readonly Carc Carc135 = new(Values.Carc135);

    public static readonly Carc Carc136 = new(Values.Carc136);

    public static readonly Carc Carc137 = new(Values.Carc137);

    public static readonly Carc Carc139 = new(Values.Carc139);

    public static readonly Carc Carc140 = new(Values.Carc140);

    public static readonly Carc Carc142 = new(Values.Carc142);

    public static readonly Carc Carc143 = new(Values.Carc143);

    public static readonly Carc Carc144 = new(Values.Carc144);

    public static readonly Carc Carc146 = new(Values.Carc146);

    public static readonly Carc Carc147 = new(Values.Carc147);

    public static readonly Carc Carc148 = new(Values.Carc148);

    public static readonly Carc Carc149 = new(Values.Carc149);

    public static readonly Carc Carc150 = new(Values.Carc150);

    public static readonly Carc Carc151 = new(Values.Carc151);

    public static readonly Carc Carc152 = new(Values.Carc152);

    public static readonly Carc Carc153 = new(Values.Carc153);

    public static readonly Carc Carc154 = new(Values.Carc154);

    public static readonly Carc Carc155 = new(Values.Carc155);

    public static readonly Carc Carc157 = new(Values.Carc157);

    public static readonly Carc Carc158 = new(Values.Carc158);

    public static readonly Carc Carc159 = new(Values.Carc159);

    public static readonly Carc Carc160 = new(Values.Carc160);

    public static readonly Carc Carc161 = new(Values.Carc161);

    public static readonly Carc Carc163 = new(Values.Carc163);

    public static readonly Carc Carc164 = new(Values.Carc164);

    public static readonly Carc Carc166 = new(Values.Carc166);

    public static readonly Carc Carc167 = new(Values.Carc167);

    public static readonly Carc Carc169 = new(Values.Carc169);

    public static readonly Carc Carc170 = new(Values.Carc170);

    public static readonly Carc Carc171 = new(Values.Carc171);

    public static readonly Carc Carc172 = new(Values.Carc172);

    public static readonly Carc Carc173 = new(Values.Carc173);

    public static readonly Carc Carc174 = new(Values.Carc174);

    public static readonly Carc Carc175 = new(Values.Carc175);

    public static readonly Carc Carc176 = new(Values.Carc176);

    public static readonly Carc Carc177 = new(Values.Carc177);

    public static readonly Carc Carc178 = new(Values.Carc178);

    public static readonly Carc Carc179 = new(Values.Carc179);

    public static readonly Carc Carc180 = new(Values.Carc180);

    public static readonly Carc Carc181 = new(Values.Carc181);

    public static readonly Carc Carc182 = new(Values.Carc182);

    public static readonly Carc Carc183 = new(Values.Carc183);

    public static readonly Carc Carc184 = new(Values.Carc184);

    public static readonly Carc Carc185 = new(Values.Carc185);

    public static readonly Carc Carc186 = new(Values.Carc186);

    public static readonly Carc Carc187 = new(Values.Carc187);

    public static readonly Carc Carc188 = new(Values.Carc188);

    public static readonly Carc Carc189 = new(Values.Carc189);

    public static readonly Carc Carc190 = new(Values.Carc190);

    public static readonly Carc Carc192 = new(Values.Carc192);

    public static readonly Carc Carc193 = new(Values.Carc193);

    public static readonly Carc Carc194 = new(Values.Carc194);

    public static readonly Carc Carc195 = new(Values.Carc195);

    public static readonly Carc Carc197 = new(Values.Carc197);

    public static readonly Carc Carc198 = new(Values.Carc198);

    public static readonly Carc Carc199 = new(Values.Carc199);

    public static readonly Carc Carc200 = new(Values.Carc200);

    public static readonly Carc Carc201 = new(Values.Carc201);

    public static readonly Carc Carc202 = new(Values.Carc202);

    public static readonly Carc Carc203 = new(Values.Carc203);

    public static readonly Carc Carc204 = new(Values.Carc204);

    public static readonly Carc Carc205 = new(Values.Carc205);

    public static readonly Carc Carc206 = new(Values.Carc206);

    public static readonly Carc Carc207 = new(Values.Carc207);

    public static readonly Carc Carc208 = new(Values.Carc208);

    public static readonly Carc Carc209 = new(Values.Carc209);

    public static readonly Carc Carc210 = new(Values.Carc210);

    public static readonly Carc Carc211 = new(Values.Carc211);

    public static readonly Carc Carc212 = new(Values.Carc212);

    public static readonly Carc Carc213 = new(Values.Carc213);

    public static readonly Carc Carc215 = new(Values.Carc215);

    public static readonly Carc Carc216 = new(Values.Carc216);

    public static readonly Carc Carc219 = new(Values.Carc219);

    public static readonly Carc Carc222 = new(Values.Carc222);

    public static readonly Carc Carc223 = new(Values.Carc223);

    public static readonly Carc Carc224 = new(Values.Carc224);

    public static readonly Carc Carc225 = new(Values.Carc225);

    public static readonly Carc Carc226 = new(Values.Carc226);

    public static readonly Carc Carc227 = new(Values.Carc227);

    public static readonly Carc Carc228 = new(Values.Carc228);

    public static readonly Carc Carc229 = new(Values.Carc229);

    public static readonly Carc Carc231 = new(Values.Carc231);

    public static readonly Carc Carc232 = new(Values.Carc232);

    public static readonly Carc Carc233 = new(Values.Carc233);

    public static readonly Carc Carc234 = new(Values.Carc234);

    public static readonly Carc Carc235 = new(Values.Carc235);

    public static readonly Carc Carc236 = new(Values.Carc236);

    public static readonly Carc Carc237 = new(Values.Carc237);

    public static readonly Carc Carc238 = new(Values.Carc238);

    public static readonly Carc Carc239 = new(Values.Carc239);

    public static readonly Carc Carc240 = new(Values.Carc240);

    public static readonly Carc Carc241 = new(Values.Carc241);

    public static readonly Carc Carc242 = new(Values.Carc242);

    public static readonly Carc Carc243 = new(Values.Carc243);

    public static readonly Carc Carc245 = new(Values.Carc245);

    public static readonly Carc Carc246 = new(Values.Carc246);

    public static readonly Carc Carc247 = new(Values.Carc247);

    public static readonly Carc Carc248 = new(Values.Carc248);

    public static readonly Carc Carc249 = new(Values.Carc249);

    public static readonly Carc Carc250 = new(Values.Carc250);

    public static readonly Carc Carc251 = new(Values.Carc251);

    public static readonly Carc Carc252 = new(Values.Carc252);

    public static readonly Carc Carc253 = new(Values.Carc253);

    public static readonly Carc Carc254 = new(Values.Carc254);

    public static readonly Carc Carc256 = new(Values.Carc256);

    public static readonly Carc Carc257 = new(Values.Carc257);

    public static readonly Carc Carc258 = new(Values.Carc258);

    public static readonly Carc Carc259 = new(Values.Carc259);

    public static readonly Carc Carc260 = new(Values.Carc260);

    public static readonly Carc Carc261 = new(Values.Carc261);

    public static readonly Carc Carc262 = new(Values.Carc262);

    public static readonly Carc Carc263 = new(Values.Carc263);

    public static readonly Carc Carc264 = new(Values.Carc264);

    public static readonly Carc Carc265 = new(Values.Carc265);

    public static readonly Carc Carc266 = new(Values.Carc266);

    public static readonly Carc Carc267 = new(Values.Carc267);

    public static readonly Carc Carc268 = new(Values.Carc268);

    public static readonly Carc Carc269 = new(Values.Carc269);

    public static readonly Carc Carc270 = new(Values.Carc270);

    public static readonly Carc Carc271 = new(Values.Carc271);

    public static readonly Carc Carc272 = new(Values.Carc272);

    public static readonly Carc Carc273 = new(Values.Carc273);

    public static readonly Carc Carc274 = new(Values.Carc274);

    public static readonly Carc Carc275 = new(Values.Carc275);

    public static readonly Carc Carc276 = new(Values.Carc276);

    public static readonly Carc Carc277 = new(Values.Carc277);

    public static readonly Carc Carc278 = new(Values.Carc278);

    public static readonly Carc Carc279 = new(Values.Carc279);

    public static readonly Carc Carc280 = new(Values.Carc280);

    public static readonly Carc Carc281 = new(Values.Carc281);

    public static readonly Carc Carc282 = new(Values.Carc282);

    public static readonly Carc Carc283 = new(Values.Carc283);

    public static readonly Carc Carc284 = new(Values.Carc284);

    public static readonly Carc Carc285 = new(Values.Carc285);

    public static readonly Carc Carc286 = new(Values.Carc286);

    public static readonly Carc Carc287 = new(Values.Carc287);

    public static readonly Carc Carc288 = new(Values.Carc288);

    public static readonly Carc Carc289 = new(Values.Carc289);

    public static readonly Carc Carc290 = new(Values.Carc290);

    public static readonly Carc Carc291 = new(Values.Carc291);

    public static readonly Carc Carc292 = new(Values.Carc292);

    public static readonly Carc Carc293 = new(Values.Carc293);

    public static readonly Carc Carc294 = new(Values.Carc294);

    public static readonly Carc Carc295 = new(Values.Carc295);

    public static readonly Carc Carc296 = new(Values.Carc296);

    public static readonly Carc Carc297 = new(Values.Carc297);

    public static readonly Carc Carc298 = new(Values.Carc298);

    public static readonly Carc Carc299 = new(Values.Carc299);

    public static readonly Carc Carc300 = new(Values.Carc300);

    public static readonly Carc Carc301 = new(Values.Carc301);

    public static readonly Carc Carc302 = new(Values.Carc302);

    public static readonly Carc Carc303 = new(Values.Carc303);

    public static readonly Carc Carc304 = new(Values.Carc304);

    public static readonly Carc Carc305 = new(Values.Carc305);

    public static readonly Carc CarcA0 = new(Values.CarcA0);

    public static readonly Carc CarcA1 = new(Values.CarcA1);

    public static readonly Carc CarcA5 = new(Values.CarcA5);

    public static readonly Carc CarcA6 = new(Values.CarcA6);

    public static readonly Carc CarcA8 = new(Values.CarcA8);

    public static readonly Carc CarcB1 = new(Values.CarcB1);

    public static readonly Carc CarcB4 = new(Values.CarcB4);

    public static readonly Carc CarcB7 = new(Values.CarcB7);

    public static readonly Carc CarcB8 = new(Values.CarcB8);

    public static readonly Carc CarcB9 = new(Values.CarcB9);

    public static readonly Carc CarcB10 = new(Values.CarcB10);

    public static readonly Carc CarcB11 = new(Values.CarcB11);

    public static readonly Carc CarcB12 = new(Values.CarcB12);

    public static readonly Carc CarcB13 = new(Values.CarcB13);

    public static readonly Carc CarcB14 = new(Values.CarcB14);

    public static readonly Carc CarcB15 = new(Values.CarcB15);

    public static readonly Carc CarcB16 = new(Values.CarcB16);

    public static readonly Carc CarcB20 = new(Values.CarcB20);

    public static readonly Carc CarcB22 = new(Values.CarcB22);

    public static readonly Carc CarcB23 = new(Values.CarcB23);

    public static readonly Carc CarcP1 = new(Values.CarcP1);

    public static readonly Carc CarcP2 = new(Values.CarcP2);

    public static readonly Carc CarcP3 = new(Values.CarcP3);

    public static readonly Carc CarcP4 = new(Values.CarcP4);

    public static readonly Carc CarcP5 = new(Values.CarcP5);

    public static readonly Carc CarcP6 = new(Values.CarcP6);

    public static readonly Carc CarcP7 = new(Values.CarcP7);

    public static readonly Carc CarcP8 = new(Values.CarcP8);

    public static readonly Carc CarcP9 = new(Values.CarcP9);

    public static readonly Carc CarcP10 = new(Values.CarcP10);

    public static readonly Carc CarcP11 = new(Values.CarcP11);

    public static readonly Carc CarcP12 = new(Values.CarcP12);

    public static readonly Carc CarcP13 = new(Values.CarcP13);

    public static readonly Carc CarcP14 = new(Values.CarcP14);

    public static readonly Carc CarcP15 = new(Values.CarcP15);

    public static readonly Carc CarcP16 = new(Values.CarcP16);

    public static readonly Carc CarcP17 = new(Values.CarcP17);

    public static readonly Carc CarcP18 = new(Values.CarcP18);

    public static readonly Carc CarcP19 = new(Values.CarcP19);

    public static readonly Carc CarcP20 = new(Values.CarcP20);

    public static readonly Carc CarcP21 = new(Values.CarcP21);

    public static readonly Carc CarcP22 = new(Values.CarcP22);

    public static readonly Carc CarcP23 = new(Values.CarcP23);

    public static readonly Carc CarcP24 = new(Values.CarcP24);

    public static readonly Carc CarcP25 = new(Values.CarcP25);

    public static readonly Carc CarcP26 = new(Values.CarcP26);

    public static readonly Carc CarcP27 = new(Values.CarcP27);

    public static readonly Carc CarcP28 = new(Values.CarcP28);

    public static readonly Carc CarcP29 = new(Values.CarcP29);

    public static readonly Carc CarcP30 = new(Values.CarcP30);

    public static readonly Carc CarcP31 = new(Values.CarcP31);

    public static readonly Carc CarcP32 = new(Values.CarcP32);

    public static readonly Carc Carc17 = new(Values.Carc17);

    public static readonly Carc Carc25 = new(Values.Carc25);

    public static readonly Carc Carc28 = new(Values.Carc28);

    public static readonly Carc Carc30 = new(Values.Carc30);

    public static readonly Carc Carc36 = new(Values.Carc36);

    public static readonly Carc Carc37 = new(Values.Carc37);

    public static readonly Carc Carc38 = new(Values.Carc38);

    public static readonly Carc Carc41 = new(Values.Carc41);

    public static readonly Carc Carc42 = new(Values.Carc42);

    public static readonly Carc Carc43 = new(Values.Carc43);

    public static readonly Carc Carc46 = new(Values.Carc46);

    public static readonly Carc Carc47 = new(Values.Carc47);

    public static readonly Carc Carc48 = new(Values.Carc48);

    public static readonly Carc Carc52 = new(Values.Carc52);

    public static readonly Carc Carc57 = new(Values.Carc57);

    public static readonly Carc Carc62 = new(Values.Carc62);

    public static readonly Carc Carc63 = new(Values.Carc63);

    public static readonly Carc Carc64 = new(Values.Carc64);

    public static readonly Carc Carc65 = new(Values.Carc65);

    public static readonly Carc Carc67 = new(Values.Carc67);

    public static readonly Carc Carc68 = new(Values.Carc68);

    public static readonly Carc Carc71 = new(Values.Carc71);

    public static readonly Carc Carc72 = new(Values.Carc72);

    public static readonly Carc Carc73 = new(Values.Carc73);

    public static readonly Carc Carc77 = new(Values.Carc77);

    public static readonly Carc Carc79 = new(Values.Carc79);

    public static readonly Carc Carc80 = new(Values.Carc80);

    public static readonly Carc Carc81 = new(Values.Carc81);

    public static readonly Carc Carc82 = new(Values.Carc82);

    public static readonly Carc Carc83 = new(Values.Carc83);

    public static readonly Carc Carc84 = new(Values.Carc84);

    public static readonly Carc Carc86 = new(Values.Carc86);

    public static readonly Carc Carc87 = new(Values.Carc87);

    public static readonly Carc Carc88 = new(Values.Carc88);

    public static readonly Carc Carc92 = new(Values.Carc92);

    public static readonly Carc Carc93 = new(Values.Carc93);

    public static readonly Carc Carc98 = new(Values.Carc98);

    public static readonly Carc Carc99 = new(Values.Carc99);

    public static readonly Carc Carc113 = new(Values.Carc113);

    public static readonly Carc Carc120 = new(Values.Carc120);

    public static readonly Carc Carc123 = new(Values.Carc123);

    public static readonly Carc Carc124 = new(Values.Carc124);

    public static readonly Carc Carc126 = new(Values.Carc126);

    public static readonly Carc Carc127 = new(Values.Carc127);

    public static readonly Carc Carc138 = new(Values.Carc138);

    public static readonly Carc Carc141 = new(Values.Carc141);

    public static readonly Carc Carc145 = new(Values.Carc145);

    public static readonly Carc Carc156 = new(Values.Carc156);

    public static readonly Carc Carc162 = new(Values.Carc162);

    public static readonly Carc Carc165 = new(Values.Carc165);

    public static readonly Carc Carc168 = new(Values.Carc168);

    public static readonly Carc Carc191 = new(Values.Carc191);

    public static readonly Carc Carc196 = new(Values.Carc196);

    public static readonly Carc Carc214 = new(Values.Carc214);

    public static readonly Carc Carc217 = new(Values.Carc217);

    public static readonly Carc Carc218 = new(Values.Carc218);

    public static readonly Carc Carc220 = new(Values.Carc220);

    public static readonly Carc Carc221 = new(Values.Carc221);

    public static readonly Carc Carc230 = new(Values.Carc230);

    public static readonly Carc Carc244 = new(Values.Carc244);

    public static readonly Carc Carc255 = new(Values.Carc255);

    public static readonly Carc CarcA2 = new(Values.CarcA2);

    public static readonly Carc CarcA3 = new(Values.CarcA3);

    public static readonly Carc CarcA4 = new(Values.CarcA4);

    public static readonly Carc CarcA7 = new(Values.CarcA7);

    public static readonly Carc CarcB2 = new(Values.CarcB2);

    public static readonly Carc CarcB3 = new(Values.CarcB3);

    public static readonly Carc CarcB5 = new(Values.CarcB5);

    public static readonly Carc CarcB6 = new(Values.CarcB6);

    public static readonly Carc CarcB17 = new(Values.CarcB17);

    public static readonly Carc CarcB18 = new(Values.CarcB18);

    public static readonly Carc CarcB19 = new(Values.CarcB19);

    public static readonly Carc CarcB21 = new(Values.CarcB21);

    public static readonly Carc CarcD1 = new(Values.CarcD1);

    public static readonly Carc CarcD2 = new(Values.CarcD2);

    public static readonly Carc CarcD3 = new(Values.CarcD3);

    public static readonly Carc CarcD4 = new(Values.CarcD4);

    public static readonly Carc CarcD5 = new(Values.CarcD5);

    public static readonly Carc CarcD6 = new(Values.CarcD6);

    public static readonly Carc CarcD7 = new(Values.CarcD7);

    public static readonly Carc CarcD8 = new(Values.CarcD8);

    public static readonly Carc CarcD9 = new(Values.CarcD9);

    public static readonly Carc CarcD10 = new(Values.CarcD10);

    public static readonly Carc CarcD11 = new(Values.CarcD11);

    public static readonly Carc CarcD12 = new(Values.CarcD12);

    public static readonly Carc CarcD14 = new(Values.CarcD14);

    public static readonly Carc CarcD15 = new(Values.CarcD15);

    public static readonly Carc CarcD16 = new(Values.CarcD16);

    public static readonly Carc CarcD17 = new(Values.CarcD17);

    public static readonly Carc CarcD18 = new(Values.CarcD18);

    public static readonly Carc CarcD19 = new(Values.CarcD19);

    public static readonly Carc CarcD20 = new(Values.CarcD20);

    public static readonly Carc CarcD21 = new(Values.CarcD21);

    public static readonly Carc CarcD22 = new(Values.CarcD22);

    public static readonly Carc CarcD23 = new(Values.CarcD23);

    public static readonly Carc CarcW1 = new(Values.CarcW1);

    public static readonly Carc CarcW2 = new(Values.CarcW2);

    public static readonly Carc CarcW3 = new(Values.CarcW3);

    public static readonly Carc CarcW4 = new(Values.CarcW4);

    public static readonly Carc CarcW5 = new(Values.CarcW5);

    public static readonly Carc CarcW6 = new(Values.CarcW6);

    public static readonly Carc CarcW7 = new(Values.CarcW7);

    public static readonly Carc CarcW8 = new(Values.CarcW8);

    public static readonly Carc CarcW9 = new(Values.CarcW9);

    public static readonly Carc CarcY1 = new(Values.CarcY1);

    public static readonly Carc CarcY2 = new(Values.CarcY2);

    public static readonly Carc CarcY3 = new(Values.CarcY3);

    public static readonly Carc Unknown = new(Values.Unknown);

    public Carc(string value)
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
    public static Carc FromCustom(string value)
    {
        return new Carc(value);
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

    public static bool operator ==(Carc value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(Carc value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(Carc value) => value.Value;

    public static explicit operator Carc(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Carc1 = "1";

        public const string Carc2 = "2";

        public const string Carc3 = "3";

        public const string Carc4 = "4";

        public const string Carc5 = "5";

        public const string Carc6 = "6";

        public const string Carc7 = "7";

        public const string Carc8 = "8";

        public const string Carc9 = "9";

        public const string Carc10 = "10";

        public const string Carc11 = "11";

        public const string Carc12 = "12";

        public const string Carc13 = "13";

        public const string Carc14 = "14";

        public const string Carc16 = "16";

        public const string Carc18 = "18";

        public const string Carc19 = "19";

        public const string Carc20 = "20";

        public const string Carc21 = "21";

        public const string Carc22 = "22";

        public const string Carc23 = "23";

        public const string Carc24 = "24";

        public const string Carc26 = "26";

        public const string Carc27 = "27";

        public const string Carc29 = "29";

        public const string Carc31 = "31";

        public const string Carc32 = "32";

        public const string Carc33 = "33";

        public const string Carc34 = "34";

        public const string Carc35 = "35";

        public const string Carc39 = "39";

        public const string Carc40 = "40";

        public const string Carc44 = "44";

        public const string Carc45 = "45";

        public const string Carc49 = "49";

        public const string Carc50 = "50";

        public const string Carc51 = "51";

        public const string Carc53 = "53";

        public const string Carc54 = "54";

        public const string Carc55 = "55";

        public const string Carc56 = "56";

        public const string Carc58 = "58";

        public const string Carc59 = "59";

        public const string Carc60 = "60";

        public const string Carc61 = "61";

        public const string Carc66 = "66";

        public const string Carc69 = "69";

        public const string Carc70 = "70";

        public const string Carc74 = "74";

        public const string Carc75 = "75";

        public const string Carc76 = "76";

        public const string Carc78 = "78";

        public const string Carc85 = "85";

        public const string Carc89 = "89";

        public const string Carc90 = "90";

        public const string Carc91 = "91";

        public const string Carc94 = "94";

        public const string Carc95 = "95";

        public const string Carc96 = "96";

        public const string Carc97 = "97";

        public const string Carc100 = "100";

        public const string Carc101 = "101";

        public const string Carc102 = "102";

        public const string Carc103 = "103";

        public const string Carc104 = "104";

        public const string Carc105 = "105";

        public const string Carc106 = "106";

        public const string Carc107 = "107";

        public const string Carc108 = "108";

        public const string Carc109 = "109";

        public const string Carc110 = "110";

        public const string Carc111 = "111";

        public const string Carc112 = "112";

        public const string Carc114 = "114";

        public const string Carc115 = "115";

        public const string Carc116 = "116";

        public const string Carc117 = "117";

        public const string Carc118 = "118";

        public const string Carc119 = "119";

        public const string Carc121 = "121";

        public const string Carc122 = "122";

        public const string Carc125 = "125";

        public const string Carc128 = "128";

        public const string Carc129 = "129";

        public const string Carc130 = "130";

        public const string Carc131 = "131";

        public const string Carc132 = "132";

        public const string Carc133 = "133";

        public const string Carc134 = "134";

        public const string Carc135 = "135";

        public const string Carc136 = "136";

        public const string Carc137 = "137";

        public const string Carc139 = "139";

        public const string Carc140 = "140";

        public const string Carc142 = "142";

        public const string Carc143 = "143";

        public const string Carc144 = "144";

        public const string Carc146 = "146";

        public const string Carc147 = "147";

        public const string Carc148 = "148";

        public const string Carc149 = "149";

        public const string Carc150 = "150";

        public const string Carc151 = "151";

        public const string Carc152 = "152";

        public const string Carc153 = "153";

        public const string Carc154 = "154";

        public const string Carc155 = "155";

        public const string Carc157 = "157";

        public const string Carc158 = "158";

        public const string Carc159 = "159";

        public const string Carc160 = "160";

        public const string Carc161 = "161";

        public const string Carc163 = "163";

        public const string Carc164 = "164";

        public const string Carc166 = "166";

        public const string Carc167 = "167";

        public const string Carc169 = "169";

        public const string Carc170 = "170";

        public const string Carc171 = "171";

        public const string Carc172 = "172";

        public const string Carc173 = "173";

        public const string Carc174 = "174";

        public const string Carc175 = "175";

        public const string Carc176 = "176";

        public const string Carc177 = "177";

        public const string Carc178 = "178";

        public const string Carc179 = "179";

        public const string Carc180 = "180";

        public const string Carc181 = "181";

        public const string Carc182 = "182";

        public const string Carc183 = "183";

        public const string Carc184 = "184";

        public const string Carc185 = "185";

        public const string Carc186 = "186";

        public const string Carc187 = "187";

        public const string Carc188 = "188";

        public const string Carc189 = "189";

        public const string Carc190 = "190";

        public const string Carc192 = "192";

        public const string Carc193 = "193";

        public const string Carc194 = "194";

        public const string Carc195 = "195";

        public const string Carc197 = "197";

        public const string Carc198 = "198";

        public const string Carc199 = "199";

        public const string Carc200 = "200";

        public const string Carc201 = "201";

        public const string Carc202 = "202";

        public const string Carc203 = "203";

        public const string Carc204 = "204";

        public const string Carc205 = "205";

        public const string Carc206 = "206";

        public const string Carc207 = "207";

        public const string Carc208 = "208";

        public const string Carc209 = "209";

        public const string Carc210 = "210";

        public const string Carc211 = "211";

        public const string Carc212 = "212";

        public const string Carc213 = "213";

        public const string Carc215 = "215";

        public const string Carc216 = "216";

        public const string Carc219 = "219";

        public const string Carc222 = "222";

        public const string Carc223 = "223";

        public const string Carc224 = "224";

        public const string Carc225 = "225";

        public const string Carc226 = "226";

        public const string Carc227 = "227";

        public const string Carc228 = "228";

        public const string Carc229 = "229";

        public const string Carc231 = "231";

        public const string Carc232 = "232";

        public const string Carc233 = "233";

        public const string Carc234 = "234";

        public const string Carc235 = "235";

        public const string Carc236 = "236";

        public const string Carc237 = "237";

        public const string Carc238 = "238";

        public const string Carc239 = "239";

        public const string Carc240 = "240";

        public const string Carc241 = "241";

        public const string Carc242 = "242";

        public const string Carc243 = "243";

        public const string Carc245 = "245";

        public const string Carc246 = "246";

        public const string Carc247 = "247";

        public const string Carc248 = "248";

        public const string Carc249 = "249";

        public const string Carc250 = "250";

        public const string Carc251 = "251";

        public const string Carc252 = "252";

        public const string Carc253 = "253";

        public const string Carc254 = "254";

        public const string Carc256 = "256";

        public const string Carc257 = "257";

        public const string Carc258 = "258";

        public const string Carc259 = "259";

        public const string Carc260 = "260";

        public const string Carc261 = "261";

        public const string Carc262 = "262";

        public const string Carc263 = "263";

        public const string Carc264 = "264";

        public const string Carc265 = "265";

        public const string Carc266 = "266";

        public const string Carc267 = "267";

        public const string Carc268 = "268";

        public const string Carc269 = "269";

        public const string Carc270 = "270";

        public const string Carc271 = "271";

        public const string Carc272 = "272";

        public const string Carc273 = "273";

        public const string Carc274 = "274";

        public const string Carc275 = "275";

        public const string Carc276 = "276";

        public const string Carc277 = "277";

        public const string Carc278 = "278";

        public const string Carc279 = "279";

        public const string Carc280 = "280";

        public const string Carc281 = "281";

        public const string Carc282 = "282";

        public const string Carc283 = "283";

        public const string Carc284 = "284";

        public const string Carc285 = "285";

        public const string Carc286 = "286";

        public const string Carc287 = "287";

        public const string Carc288 = "288";

        public const string Carc289 = "289";

        public const string Carc290 = "290";

        public const string Carc291 = "291";

        public const string Carc292 = "292";

        public const string Carc293 = "293";

        public const string Carc294 = "294";

        public const string Carc295 = "295";

        public const string Carc296 = "296";

        public const string Carc297 = "297";

        public const string Carc298 = "298";

        public const string Carc299 = "299";

        public const string Carc300 = "300";

        public const string Carc301 = "301";

        public const string Carc302 = "302";

        public const string Carc303 = "303";

        public const string Carc304 = "304";

        public const string Carc305 = "305";

        public const string CarcA0 = "A0";

        public const string CarcA1 = "A1";

        public const string CarcA5 = "A5";

        public const string CarcA6 = "A6";

        public const string CarcA8 = "A8";

        public const string CarcB1 = "B1";

        public const string CarcB4 = "B4";

        public const string CarcB7 = "B7";

        public const string CarcB8 = "B8";

        public const string CarcB9 = "B9";

        public const string CarcB10 = "B10";

        public const string CarcB11 = "B11";

        public const string CarcB12 = "B12";

        public const string CarcB13 = "B13";

        public const string CarcB14 = "B14";

        public const string CarcB15 = "B15";

        public const string CarcB16 = "B16";

        public const string CarcB20 = "B20";

        public const string CarcB22 = "B22";

        public const string CarcB23 = "B23";

        public const string CarcP1 = "P1";

        public const string CarcP2 = "P2";

        public const string CarcP3 = "P3";

        public const string CarcP4 = "P4";

        public const string CarcP5 = "P5";

        public const string CarcP6 = "P6";

        public const string CarcP7 = "P7";

        public const string CarcP8 = "P8";

        public const string CarcP9 = "P9";

        public const string CarcP10 = "P10";

        public const string CarcP11 = "P11";

        public const string CarcP12 = "P12";

        public const string CarcP13 = "P13";

        public const string CarcP14 = "P14";

        public const string CarcP15 = "P15";

        public const string CarcP16 = "P16";

        public const string CarcP17 = "P17";

        public const string CarcP18 = "P18";

        public const string CarcP19 = "P19";

        public const string CarcP20 = "P20";

        public const string CarcP21 = "P21";

        public const string CarcP22 = "P22";

        public const string CarcP23 = "P23";

        public const string CarcP24 = "P24";

        public const string CarcP25 = "P25";

        public const string CarcP26 = "P26";

        public const string CarcP27 = "P27";

        public const string CarcP28 = "P28";

        public const string CarcP29 = "P29";

        public const string CarcP30 = "P30";

        public const string CarcP31 = "P31";

        public const string CarcP32 = "P32";

        public const string Carc17 = "17";

        public const string Carc25 = "25";

        public const string Carc28 = "28";

        public const string Carc30 = "30";

        public const string Carc36 = "36";

        public const string Carc37 = "37";

        public const string Carc38 = "38";

        public const string Carc41 = "41";

        public const string Carc42 = "42";

        public const string Carc43 = "43";

        public const string Carc46 = "46";

        public const string Carc47 = "47";

        public const string Carc48 = "48";

        public const string Carc52 = "52";

        public const string Carc57 = "57";

        public const string Carc62 = "62";

        public const string Carc63 = "63";

        public const string Carc64 = "64";

        public const string Carc65 = "65";

        public const string Carc67 = "67";

        public const string Carc68 = "68";

        public const string Carc71 = "71";

        public const string Carc72 = "72";

        public const string Carc73 = "73";

        public const string Carc77 = "77";

        public const string Carc79 = "79";

        public const string Carc80 = "80";

        public const string Carc81 = "81";

        public const string Carc82 = "82";

        public const string Carc83 = "83";

        public const string Carc84 = "84";

        public const string Carc86 = "86";

        public const string Carc87 = "87";

        public const string Carc88 = "88";

        public const string Carc92 = "92";

        public const string Carc93 = "93";

        public const string Carc98 = "98";

        public const string Carc99 = "99";

        public const string Carc113 = "113";

        public const string Carc120 = "120";

        public const string Carc123 = "123";

        public const string Carc124 = "124";

        public const string Carc126 = "126";

        public const string Carc127 = "127";

        public const string Carc138 = "138";

        public const string Carc141 = "141";

        public const string Carc145 = "145";

        public const string Carc156 = "156";

        public const string Carc162 = "162";

        public const string Carc165 = "165";

        public const string Carc168 = "168";

        public const string Carc191 = "191";

        public const string Carc196 = "196";

        public const string Carc214 = "214";

        public const string Carc217 = "217";

        public const string Carc218 = "218";

        public const string Carc220 = "220";

        public const string Carc221 = "221";

        public const string Carc230 = "230";

        public const string Carc244 = "244";

        public const string Carc255 = "255";

        public const string CarcA2 = "A2";

        public const string CarcA3 = "A3";

        public const string CarcA4 = "A4";

        public const string CarcA7 = "A7";

        public const string CarcB2 = "B2";

        public const string CarcB3 = "B3";

        public const string CarcB5 = "B5";

        public const string CarcB6 = "B6";

        public const string CarcB17 = "B17";

        public const string CarcB18 = "B18";

        public const string CarcB19 = "B19";

        public const string CarcB21 = "B21";

        public const string CarcD1 = "D1";

        public const string CarcD2 = "D2";

        public const string CarcD3 = "D3";

        public const string CarcD4 = "D4";

        public const string CarcD5 = "D5";

        public const string CarcD6 = "D6";

        public const string CarcD7 = "D7";

        public const string CarcD8 = "D8";

        public const string CarcD9 = "D9";

        public const string CarcD10 = "D10";

        public const string CarcD11 = "D11";

        public const string CarcD12 = "D12";

        public const string CarcD14 = "D14";

        public const string CarcD15 = "D15";

        public const string CarcD16 = "D16";

        public const string CarcD17 = "D17";

        public const string CarcD18 = "D18";

        public const string CarcD19 = "D19";

        public const string CarcD20 = "D20";

        public const string CarcD21 = "D21";

        public const string CarcD22 = "D22";

        public const string CarcD23 = "D23";

        public const string CarcW1 = "W1";

        public const string CarcW2 = "W2";

        public const string CarcW3 = "W3";

        public const string CarcW4 = "W4";

        public const string CarcW5 = "W5";

        public const string CarcW6 = "W6";

        public const string CarcW7 = "W7";

        public const string CarcW8 = "W8";

        public const string CarcW9 = "W9";

        public const string CarcY1 = "Y1";

        public const string CarcY2 = "Y2";

        public const string CarcY3 = "Y3";

        public const string Unknown = "UNKNOWN";
    }
}
