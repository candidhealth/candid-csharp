using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<CodeListQualifierCode>))]
public enum CodeListQualifierCode
{
    [EnumMember(Value = "0")]
    C0,

    [EnumMember(Value = "1")]
    C1,

    [EnumMember(Value = "2")]
    C2,

    [EnumMember(Value = "3")]
    C3,

    [EnumMember(Value = "4")]
    C4,

    [EnumMember(Value = "5")]
    C5,

    [EnumMember(Value = "7")]
    C7,

    [EnumMember(Value = "8")]
    C8,

    [EnumMember(Value = "10")]
    C10,

    [EnumMember(Value = "11")]
    C11,

    [EnumMember(Value = "12")]
    C12,

    [EnumMember(Value = "13")]
    C13,

    [EnumMember(Value = "14")]
    C14,

    [EnumMember(Value = "15")]
    C15,

    [EnumMember(Value = "16")]
    C16,

    [EnumMember(Value = "17")]
    C17,

    [EnumMember(Value = "18")]
    C18,

    [EnumMember(Value = "19")]
    C19,

    [EnumMember(Value = "20")]
    C20,

    [EnumMember(Value = "21")]
    C21,

    [EnumMember(Value = "22")]
    C22,

    [EnumMember(Value = "23")]
    C23,

    [EnumMember(Value = "24")]
    C24,

    [EnumMember(Value = "25")]
    C25,

    [EnumMember(Value = "26")]
    C26,

    [EnumMember(Value = "27")]
    C27,

    [EnumMember(Value = "28")]
    C28,

    [EnumMember(Value = "29")]
    C29,

    [EnumMember(Value = "30")]
    C30,

    [EnumMember(Value = "31")]
    C31,

    [EnumMember(Value = "32")]
    C32,

    [EnumMember(Value = "33")]
    C33,

    [EnumMember(Value = "34")]
    C34,

    [EnumMember(Value = "35")]
    C35,

    [EnumMember(Value = "36")]
    C36,

    [EnumMember(Value = "37")]
    C37,

    [EnumMember(Value = "38")]
    C38,

    [EnumMember(Value = "39")]
    C39,

    [EnumMember(Value = "40")]
    C40,

    [EnumMember(Value = "41")]
    C41,

    [EnumMember(Value = "42")]
    C42,

    [EnumMember(Value = "43")]
    C43,

    [EnumMember(Value = "44")]
    C44,

    [EnumMember(Value = "45")]
    C45,

    [EnumMember(Value = "46")]
    C46,

    [EnumMember(Value = "47")]
    C47,

    [EnumMember(Value = "48")]
    C48,

    [EnumMember(Value = "49")]
    C49,

    [EnumMember(Value = "50")]
    C50,

    [EnumMember(Value = "52")]
    C52,

    [EnumMember(Value = "53")]
    C53,

    [EnumMember(Value = "54")]
    C54,

    [EnumMember(Value = "55")]
    C55,

    [EnumMember(Value = "56")]
    C56,

    [EnumMember(Value = "57")]
    C57,

    [EnumMember(Value = "58")]
    C58,

    [EnumMember(Value = "59")]
    C59,

    [EnumMember(Value = "60")]
    C60,

    [EnumMember(Value = "61")]
    C61,

    [EnumMember(Value = "62")]
    C62,

    [EnumMember(Value = "63")]
    C63,

    [EnumMember(Value = "65")]
    C65,

    [EnumMember(Value = "66")]
    C66,

    [EnumMember(Value = "67")]
    C67,

    [EnumMember(Value = "68")]
    C68,

    [EnumMember(Value = "69")]
    C69,

    [EnumMember(Value = "71")]
    C71,

    [EnumMember(Value = "72")]
    C72,

    [EnumMember(Value = "73")]
    C73,

    [EnumMember(Value = "74")]
    C74,

    [EnumMember(Value = "75")]
    C75,

    [EnumMember(Value = "78")]
    C78,

    [EnumMember(Value = "79")]
    C79,

    [EnumMember(Value = "80")]
    C80,

    [EnumMember(Value = "81")]
    C81,

    [EnumMember(Value = "82")]
    C82,

    [EnumMember(Value = "83")]
    C83,

    [EnumMember(Value = "84")]
    C84,

    [EnumMember(Value = "85")]
    C85,

    [EnumMember(Value = "87")]
    C87,

    [EnumMember(Value = "88")]
    C88,

    [EnumMember(Value = "89")]
    C89,

    [EnumMember(Value = "90")]
    C90,

    [EnumMember(Value = "91")]
    C91,

    [EnumMember(Value = "92")]
    C92,

    [EnumMember(Value = "93")]
    C93,

    [EnumMember(Value = "94")]
    C94,

    [EnumMember(Value = "95")]
    C95,

    [EnumMember(Value = "96")]
    C96,

    [EnumMember(Value = "97")]
    C97,

    [EnumMember(Value = "98")]
    C98,

    [EnumMember(Value = "99")]
    C99,

    [EnumMember(Value = "100")]
    C100,

    [EnumMember(Value = "101")]
    C101,

    [EnumMember(Value = "102")]
    C102,

    [EnumMember(Value = "103")]
    C103,

    [EnumMember(Value = "104")]
    C104,

    [EnumMember(Value = "105")]
    C105,

    [EnumMember(Value = "106")]
    C106,

    [EnumMember(Value = "107")]
    C107,

    [EnumMember(Value = "108")]
    C108,

    [EnumMember(Value = "109")]
    C109,

    [EnumMember(Value = "A")]
    Ca,

    [EnumMember(Value = "B")]
    Cb,

    [EnumMember(Value = "C")]
    Cc,

    [EnumMember(Value = "D")]
    Cd,

    [EnumMember(Value = "E")]
    Ce,

    [EnumMember(Value = "F")]
    Cf,

    [EnumMember(Value = "G")]
    Cg,

    [EnumMember(Value = "H")]
    Ch,

    [EnumMember(Value = "I")]
    Ci,

    [EnumMember(Value = "J")]
    Cj,

    [EnumMember(Value = "K")]
    Ck,

    [EnumMember(Value = "L")]
    Cl,

    [EnumMember(Value = "M")]
    Cm,

    [EnumMember(Value = "N")]
    Cn,

    [EnumMember(Value = "O")]
    Co,

    [EnumMember(Value = "P")]
    Cp,

    [EnumMember(Value = "Q")]
    Cq,

    [EnumMember(Value = "R")]
    Cr,

    [EnumMember(Value = "S")]
    Cs,

    [EnumMember(Value = "T")]
    Ct,

    [EnumMember(Value = "U")]
    Cu,

    [EnumMember(Value = "V")]
    Cv,

    [EnumMember(Value = "W")]
    Cw,

    [EnumMember(Value = "X")]
    Cx,

    [EnumMember(Value = "Y")]
    Cy,

    [EnumMember(Value = "Z")]
    Cz,

    [EnumMember(Value = "A1")]
    Ca1,

    [EnumMember(Value = "A2")]
    Ca2,

    [EnumMember(Value = "A3")]
    Ca3,

    [EnumMember(Value = "A4")]
    Ca4,

    [EnumMember(Value = "A5")]
    Ca5,

    [EnumMember(Value = "A6")]
    Ca6,

    [EnumMember(Value = "A7")]
    Ca7,

    [EnumMember(Value = "A8")]
    Ca8,

    [EnumMember(Value = "A9")]
    Ca9,

    [EnumMember(Value = "AA")]
    Caa,

    [EnumMember(Value = "AB")]
    Cab,

    [EnumMember(Value = "AC")]
    Cac,

    [EnumMember(Value = "AD")]
    Cad,

    [EnumMember(Value = "AE")]
    Cae,

    [EnumMember(Value = "AF")]
    Caf,

    [EnumMember(Value = "AG")]
    Cag,

    [EnumMember(Value = "AH")]
    Cah,

    [EnumMember(Value = "AI")]
    Cai,

    [EnumMember(Value = "AJ")]
    Caj,

    [EnumMember(Value = "AK")]
    Cak,

    [EnumMember(Value = "AL")]
    Cal,

    [EnumMember(Value = "AM")]
    Cam,

    [EnumMember(Value = "AN")]
    Can,

    [EnumMember(Value = "AO")]
    Cao,

    [EnumMember(Value = "AQ")]
    Caq,

    [EnumMember(Value = "AR")]
    Car,

    [EnumMember(Value = "AS")]
    Cas,

    [EnumMember(Value = "AT")]
    Cat,

    [EnumMember(Value = "AU")]
    Cau,

    [EnumMember(Value = "AV")]
    Cav,

    [EnumMember(Value = "AW")]
    Caw,

    [EnumMember(Value = "AX")]
    Cax,

    [EnumMember(Value = "AY")]
    Cay,

    [EnumMember(Value = "AZ")]
    Caz,

    [EnumMember(Value = "BA")]
    Cba,

    [EnumMember(Value = "BB")]
    Cbb,

    [EnumMember(Value = "BC")]
    Cbc,

    [EnumMember(Value = "BD")]
    Cbd,

    [EnumMember(Value = "BE")]
    Cbe,

    [EnumMember(Value = "BF")]
    Cbf,

    [EnumMember(Value = "BG")]
    Cbg,

    [EnumMember(Value = "BH")]
    Cbh,

    [EnumMember(Value = "BI")]
    Cbi,

    [EnumMember(Value = "BJ")]
    Cbj,

    [EnumMember(Value = "BK")]
    Cbk,

    [EnumMember(Value = "BL")]
    Cbl,

    [EnumMember(Value = "BN")]
    Cbn,

    [EnumMember(Value = "BO")]
    Cbo,

    [EnumMember(Value = "BP")]
    Cbp,

    [EnumMember(Value = "BQ")]
    Cbq,

    [EnumMember(Value = "BR")]
    Cbr,

    [EnumMember(Value = "BS")]
    Cbs,

    [EnumMember(Value = "BT")]
    Cbt,

    [EnumMember(Value = "BU")]
    Cbu,

    [EnumMember(Value = "BV")]
    Cbv,

    [EnumMember(Value = "BW")]
    Cbw,

    [EnumMember(Value = "BX")]
    Cbx,

    [EnumMember(Value = "BY")]
    Cby,

    [EnumMember(Value = "BZ")]
    Cbz,

    [EnumMember(Value = "C1")]
    Cc1,

    [EnumMember(Value = "C2")]
    Cc2,

    [EnumMember(Value = "C3")]
    Cc3,

    [EnumMember(Value = "CA")]
    Cca,

    [EnumMember(Value = "CB")]
    Ccb,

    [EnumMember(Value = "CC")]
    Ccc,

    [EnumMember(Value = "CD")]
    Ccd,

    [EnumMember(Value = "CE")]
    Cce,

    [EnumMember(Value = "CF")]
    Ccf,

    [EnumMember(Value = "CG")]
    Ccg,

    [EnumMember(Value = "CH")]
    Cch,

    [EnumMember(Value = "CI")]
    Cci,

    [EnumMember(Value = "CJ")]
    Ccj,

    [EnumMember(Value = "CK")]
    Cck,

    [EnumMember(Value = "CL")]
    Ccl,

    [EnumMember(Value = "CM")]
    Ccm,

    [EnumMember(Value = "CN")]
    Ccn,

    [EnumMember(Value = "CO")]
    Cco,

    [EnumMember(Value = "CP")]
    Ccp,

    [EnumMember(Value = "CQ")]
    Ccq,

    [EnumMember(Value = "CR")]
    Ccr,

    [EnumMember(Value = "CS")]
    Ccs,

    [EnumMember(Value = "CT")]
    Cct,

    [EnumMember(Value = "CU")]
    Ccu,

    [EnumMember(Value = "CV")]
    Ccv,

    [EnumMember(Value = "CW")]
    Ccw,

    [EnumMember(Value = "CZ")]
    Ccz,

    [EnumMember(Value = "D1")]
    Cd1,

    [EnumMember(Value = "D2")]
    Cd2,

    [EnumMember(Value = "D3")]
    Cd3,

    [EnumMember(Value = "D4")]
    Cd4,

    [EnumMember(Value = "D5")]
    Cd5,

    [EnumMember(Value = "DA")]
    Cda,

    [EnumMember(Value = "DB")]
    Cdb,

    [EnumMember(Value = "DC")]
    Cdc,

    [EnumMember(Value = "DD")]
    Cdd,

    [EnumMember(Value = "DE")]
    Cde,

    [EnumMember(Value = "DF")]
    Cdf,

    [EnumMember(Value = "DG")]
    Cdg,

    [EnumMember(Value = "DH")]
    Cdh,

    [EnumMember(Value = "DI")]
    Cdi,

    [EnumMember(Value = "DJ")]
    Cdj,

    [EnumMember(Value = "DK")]
    Cdk,

    [EnumMember(Value = "DL")]
    Cdl,

    [EnumMember(Value = "DM")]
    Cdm,

    [EnumMember(Value = "DN")]
    Cdn,

    [EnumMember(Value = "DO")]
    Cdo,

    [EnumMember(Value = "DP")]
    Cdp,

    [EnumMember(Value = "DQ")]
    Cdq,

    [EnumMember(Value = "DR")]
    Cdr,

    [EnumMember(Value = "DS")]
    Cds,

    [EnumMember(Value = "DT")]
    Cdt,

    [EnumMember(Value = "DU")]
    Cdu,

    [EnumMember(Value = "DW")]
    Cdw,

    [EnumMember(Value = "DX")]
    Cdx,

    [EnumMember(Value = "DY")]
    Cdy,

    [EnumMember(Value = "DZ")]
    Cdz,

    [EnumMember(Value = "EA")]
    Cea,

    [EnumMember(Value = "EB")]
    Ceb,

    [EnumMember(Value = "EC")]
    Cec,

    [EnumMember(Value = "ED")]
    Ced,

    [EnumMember(Value = "EE")]
    Cee,

    [EnumMember(Value = "EF")]
    Cef,

    [EnumMember(Value = "EG")]
    Ceg,

    [EnumMember(Value = "EH")]
    Ceh,

    [EnumMember(Value = "EI")]
    Cei,

    [EnumMember(Value = "EJ")]
    Cej,

    [EnumMember(Value = "EK")]
    Cek,

    [EnumMember(Value = "EL")]
    Cel,

    [EnumMember(Value = "EM")]
    Cem,

    [EnumMember(Value = "EN")]
    Cen,

    [EnumMember(Value = "EO")]
    Ceo,

    [EnumMember(Value = "EQ")]
    Ceq,

    [EnumMember(Value = "ER")]
    Cer,

    [EnumMember(Value = "ES")]
    Ces,

    [EnumMember(Value = "ET")]
    Cet,

    [EnumMember(Value = "EU")]
    Ceu,

    [EnumMember(Value = "EV")]
    Cev,

    [EnumMember(Value = "EW")]
    Cew,

    [EnumMember(Value = "EX")]
    Cex,

    [EnumMember(Value = "EY")]
    Cey,

    [EnumMember(Value = "EZ")]
    Cez,

    [EnumMember(Value = "FA")]
    Cfa,

    [EnumMember(Value = "FB")]
    Cfb,

    [EnumMember(Value = "FC")]
    Cfc,

    [EnumMember(Value = "FD")]
    Cfd,

    [EnumMember(Value = "FE")]
    Cfe,

    [EnumMember(Value = "FF")]
    Cff,

    [EnumMember(Value = "FG")]
    Cfg,

    [EnumMember(Value = "FH")]
    Cfh,

    [EnumMember(Value = "FI")]
    Cfi,

    [EnumMember(Value = "FJ")]
    Cfj,

    [EnumMember(Value = "FK")]
    Cfk,

    [EnumMember(Value = "FL")]
    Cfl,

    [EnumMember(Value = "FM")]
    Cfm,

    [EnumMember(Value = "FN")]
    Cfn,

    [EnumMember(Value = "FO")]
    Cfo,

    [EnumMember(Value = "FP")]
    Cfp,

    [EnumMember(Value = "FQ")]
    Cfq,

    [EnumMember(Value = "FR")]
    Cfr,

    [EnumMember(Value = "FS")]
    Cfs,

    [EnumMember(Value = "FT")]
    Cft,

    [EnumMember(Value = "FU")]
    Cfu,

    [EnumMember(Value = "FV")]
    Cfv,

    [EnumMember(Value = "FW")]
    Cfw,

    [EnumMember(Value = "FX")]
    Cfx,

    [EnumMember(Value = "FZ")]
    Cfz,

    [EnumMember(Value = "G1")]
    Cg1,

    [EnumMember(Value = "GA")]
    Cga,

    [EnumMember(Value = "GB")]
    Cgb,

    [EnumMember(Value = "GC")]
    Cgc,

    [EnumMember(Value = "GD")]
    Cgd,

    [EnumMember(Value = "GE")]
    Cge,

    [EnumMember(Value = "GF")]
    Cgf,

    [EnumMember(Value = "GG")]
    Cgg,

    [EnumMember(Value = "GI")]
    Cgi,

    [EnumMember(Value = "GJ")]
    Cgj,

    [EnumMember(Value = "GK")]
    Cgk,

    [EnumMember(Value = "GQ")]
    Cgq,

    [EnumMember(Value = "GR")]
    Cgr,

    [EnumMember(Value = "GS")]
    Cgs,

    [EnumMember(Value = "GT")]
    Cgt,

    [EnumMember(Value = "GU")]
    Cgu,

    [EnumMember(Value = "GV")]
    Cgv,

    [EnumMember(Value = "GW")]
    Cgw,

    [EnumMember(Value = "GX")]
    Cgx,

    [EnumMember(Value = "GY")]
    Cgy,

    [EnumMember(Value = "GZ")]
    Cgz,

    [EnumMember(Value = "HA")]
    Cha,

    [EnumMember(Value = "HB")]
    Chb,

    [EnumMember(Value = "HC")]
    Chc,

    [EnumMember(Value = "HD")]
    Chd,

    [EnumMember(Value = "HE")]
    Che,

    [EnumMember(Value = "HF")]
    Chf,

    [EnumMember(Value = "HG")]
    Chg,

    [EnumMember(Value = "HI")]
    Chi,

    [EnumMember(Value = "HJ")]
    Chj,

    [EnumMember(Value = "HK")]
    Chk,

    [EnumMember(Value = "HL")]
    Chl,

    [EnumMember(Value = "HM")]
    Chm,

    [EnumMember(Value = "HS")]
    Chs,

    [EnumMember(Value = "IC")]
    Cic,

    [EnumMember(Value = "ID")]
    Cid,

    [EnumMember(Value = "IF")]
    Cif,

    [EnumMember(Value = "IQ")]
    Ciq,

    [EnumMember(Value = "IT")]
    Cit,

    [EnumMember(Value = "J0")]
    Cj0,

    [EnumMember(Value = "J1")]
    Cj1,

    [EnumMember(Value = "J2")]
    Cj2,

    [EnumMember(Value = "J3")]
    Cj3,

    [EnumMember(Value = "J4")]
    Cj4,

    [EnumMember(Value = "J5")]
    Cj5,

    [EnumMember(Value = "J6")]
    Cj6,

    [EnumMember(Value = "J7")]
    Cj7,

    [EnumMember(Value = "J8")]
    Cj8,

    [EnumMember(Value = "J9")]
    Cj9,

    [EnumMember(Value = "JA")]
    Cja,

    [EnumMember(Value = "JB")]
    Cjb,

    [EnumMember(Value = "JC")]
    Cjc,

    [EnumMember(Value = "JD")]
    Cjd,

    [EnumMember(Value = "JE")]
    Cje,

    [EnumMember(Value = "JF")]
    Cjf,

    [EnumMember(Value = "JG")]
    Cjg,

    [EnumMember(Value = "JH")]
    Cjh,

    [EnumMember(Value = "JI")]
    Cji,

    [EnumMember(Value = "JK")]
    Cjk,

    [EnumMember(Value = "JL")]
    Cjl,

    [EnumMember(Value = "JM")]
    Cjm,

    [EnumMember(Value = "JN")]
    Cjn,

    [EnumMember(Value = "JO")]
    Cjo,

    [EnumMember(Value = "JP")]
    Cjp,

    [EnumMember(Value = "KA")]
    Cka,

    [EnumMember(Value = "KB")]
    Ckb,

    [EnumMember(Value = "KC")]
    Ckc,

    [EnumMember(Value = "KD")]
    Ckd,

    [EnumMember(Value = "KE")]
    Cke,

    [EnumMember(Value = "KF")]
    Ckf,

    [EnumMember(Value = "KG")]
    Ckg,

    [EnumMember(Value = "KH")]
    Ckh,

    [EnumMember(Value = "KI")]
    Cki,

    [EnumMember(Value = "KJ")]
    Ckj,

    [EnumMember(Value = "KK")]
    Ckk,

    [EnumMember(Value = "KL")]
    Ckl,

    [EnumMember(Value = "KM")]
    Ckm,

    [EnumMember(Value = "KO")]
    Cko,

    [EnumMember(Value = "KP")]
    Ckp,

    [EnumMember(Value = "KQ")]
    Ckq,

    [EnumMember(Value = "KS")]
    Cks,

    [EnumMember(Value = "KT")]
    Ckt,

    [EnumMember(Value = "KU")]
    Cku,

    [EnumMember(Value = "KW")]
    Ckw,

    [EnumMember(Value = "KZ")]
    Ckz,

    [EnumMember(Value = "LA")]
    Cla,

    [EnumMember(Value = "LB")]
    Clb,

    [EnumMember(Value = "LC")]
    Clc,

    [EnumMember(Value = "LD")]
    Cld,

    [EnumMember(Value = "LE")]
    Cle,

    [EnumMember(Value = "LF")]
    Clf,

    [EnumMember(Value = "LG")]
    Clg,

    [EnumMember(Value = "LH")]
    Clh,

    [EnumMember(Value = "LJ")]
    Clj,

    [EnumMember(Value = "LK")]
    Clk,

    [EnumMember(Value = "LM")]
    Clm,

    [EnumMember(Value = "LN")]
    Cln,

    [EnumMember(Value = "LO")]
    Clo,

    [EnumMember(Value = "LP")]
    Clp,

    [EnumMember(Value = "LQ")]
    Clq,

    [EnumMember(Value = "LR")]
    Clr,

    [EnumMember(Value = "LS")]
    Cls,

    [EnumMember(Value = "LT")]
    Clt,

    [EnumMember(Value = "LZ")]
    Clz,

    [EnumMember(Value = "MA")]
    Cma,

    [EnumMember(Value = "MB")]
    Cmb,

    [EnumMember(Value = "MC")]
    Cmc,

    [EnumMember(Value = "ME")]
    Cme,

    [EnumMember(Value = "MI")]
    Cmi,

    [EnumMember(Value = "MJ")]
    Cmj,

    [EnumMember(Value = "MK")]
    Cmk,

    [EnumMember(Value = "ML")]
    Cml,

    [EnumMember(Value = "MN")]
    Cmn,

    [EnumMember(Value = "MS")]
    Cms,

    [EnumMember(Value = "MT")]
    Cmt,

    [EnumMember(Value = "NA")]
    Cna,

    [EnumMember(Value = "NB")]
    Cnb,

    [EnumMember(Value = "NC")]
    Cnc,

    [EnumMember(Value = "ND")]
    Cnd,

    [EnumMember(Value = "NE")]
    Cne,

    [EnumMember(Value = "NF")]
    Cnf,

    [EnumMember(Value = "NH")]
    Cnh,

    [EnumMember(Value = "NI")]
    Cni,

    [EnumMember(Value = "NJ")]
    Cnj,

    [EnumMember(Value = "NK")]
    Cnk,

    [EnumMember(Value = "NP")]
    Cnp,

    [EnumMember(Value = "NR")]
    Cnr,

    [EnumMember(Value = "NS")]
    Cns,

    [EnumMember(Value = "NT")]
    Cnt,

    [EnumMember(Value = "O1")]
    Co1,

    [EnumMember(Value = "O2")]
    Co2,

    [EnumMember(Value = "O3")]
    Co3,

    [EnumMember(Value = "O4")]
    Co4,

    [EnumMember(Value = "OC")]
    Coc,

    [EnumMember(Value = "PA")]
    Cpa,

    [EnumMember(Value = "PB")]
    Cpb,

    [EnumMember(Value = "PC")]
    Cpc,

    [EnumMember(Value = "PD")]
    Cpd,

    [EnumMember(Value = "PI")]
    Cpi,

    [EnumMember(Value = "PL")]
    Cpl,

    [EnumMember(Value = "PR")]
    Cpr,

    [EnumMember(Value = "PS")]
    Cps,

    [EnumMember(Value = "PT")]
    Cpt,

    [EnumMember(Value = "QA")]
    Cqa,

    [EnumMember(Value = "QB")]
    Cqb,

    [EnumMember(Value = "QC")]
    Cqc,

    [EnumMember(Value = "QE")]
    Cqe,

    [EnumMember(Value = "QF")]
    Cqf,

    [EnumMember(Value = "QG")]
    Cqg,

    [EnumMember(Value = "QH")]
    Cqh,

    [EnumMember(Value = "QI")]
    Cqi,

    [EnumMember(Value = "QJ")]
    Cqj,

    [EnumMember(Value = "QK")]
    Cqk,

    [EnumMember(Value = "QS")]
    Cqs,

    [EnumMember(Value = "QT")]
    Cqt,

    [EnumMember(Value = "R1")]
    Cr1,

    [EnumMember(Value = "R2")]
    Cr2,

    [EnumMember(Value = "R3")]
    Cr3,

    [EnumMember(Value = "R4")]
    Cr4,

    [EnumMember(Value = "RA")]
    Cra,

    [EnumMember(Value = "RC")]
    Crc,

    [EnumMember(Value = "RD")]
    Crd,

    [EnumMember(Value = "RE")]
    Cre,

    [EnumMember(Value = "RI")]
    Cri,

    [EnumMember(Value = "RQ")]
    Crq,

    [EnumMember(Value = "RT")]
    Crt,

    [EnumMember(Value = "RX")]
    Crx,

    [EnumMember(Value = "SA")]
    Csa,

    [EnumMember(Value = "SB")]
    Csb,

    [EnumMember(Value = "SC")]
    Csc,

    [EnumMember(Value = "SD")]
    Csd,

    [EnumMember(Value = "SE")]
    Cse,

    [EnumMember(Value = "SF")]
    Csf,

    [EnumMember(Value = "SG")]
    Csg,

    [EnumMember(Value = "SH")]
    Csh,

    [EnumMember(Value = "SI")]
    Csi,

    [EnumMember(Value = "SJ")]
    Csj,

    [EnumMember(Value = "SL")]
    Csl,

    [EnumMember(Value = "SO")]
    Cso,

    [EnumMember(Value = "SP")]
    Csp,

    [EnumMember(Value = "SR")]
    Csr,

    [EnumMember(Value = "SS")]
    Css,

    [EnumMember(Value = "ST")]
    Cst,

    [EnumMember(Value = "TB")]
    Ctb,

    [EnumMember(Value = "TC")]
    Ctc,

    [EnumMember(Value = "TD")]
    Ctd,

    [EnumMember(Value = "TE")]
    Cte,

    [EnumMember(Value = "TF")]
    Ctf,

    [EnumMember(Value = "TG")]
    Ctg,

    [EnumMember(Value = "TL")]
    Ctl,

    [EnumMember(Value = "TP")]
    Ctp,

    [EnumMember(Value = "TQ")]
    Ctq,

    [EnumMember(Value = "TR")]
    Ctr,

    [EnumMember(Value = "TT")]
    Ctt,

    [EnumMember(Value = "TX")]
    Ctx,

    [EnumMember(Value = "TY")]
    Cty,

    [EnumMember(Value = "UR")]
    Cur,

    [EnumMember(Value = "US")]
    Cus,

    [EnumMember(Value = "UT")]
    Cut,

    [EnumMember(Value = "UU")]
    Cuu,

    [EnumMember(Value = "VP")]
    Cvp,

    [EnumMember(Value = "XD")]
    Cxd,

    [EnumMember(Value = "ZZ")]
    Czz,

    [EnumMember(Value = "AAA")]
    Caaa,

    [EnumMember(Value = "AAD")]
    Caad,

    [EnumMember(Value = "AAE")]
    Caae,

    [EnumMember(Value = "AAF")]
    Caaf,

    [EnumMember(Value = "AAG")]
    Caag,

    [EnumMember(Value = "AAH")]
    Caah,

    [EnumMember(Value = "AAI")]
    Caai,

    [EnumMember(Value = "AAJ")]
    Caaj,

    [EnumMember(Value = "AAK")]
    Caak,

    [EnumMember(Value = "AAL")]
    Caal,

    [EnumMember(Value = "AAM")]
    Caam,

    [EnumMember(Value = "AAN")]
    Caan,

    [EnumMember(Value = "AAO")]
    Caao,

    [EnumMember(Value = "AAP")]
    Caap,

    [EnumMember(Value = "AAQ")]
    Caaq,

    [EnumMember(Value = "AAR")]
    Caar,

    [EnumMember(Value = "AAS")]
    Caas,

    [EnumMember(Value = "AAT")]
    Caat,

    [EnumMember(Value = "AAU")]
    Caau,

    [EnumMember(Value = "AAV")]
    Caav,

    [EnumMember(Value = "AAW")]
    Caaw,

    [EnumMember(Value = "AAX")]
    Caax,

    [EnumMember(Value = "AAY")]
    Caay,

    [EnumMember(Value = "ABF")]
    Cabf,

    [EnumMember(Value = "ABJ")]
    Cabj,

    [EnumMember(Value = "ABK")]
    Cabk,

    [EnumMember(Value = "ABN")]
    Cabn,

    [EnumMember(Value = "ABR")]
    Cabr,

    [EnumMember(Value = "ABS")]
    Cabs,

    [EnumMember(Value = "ABU")]
    Cabu,

    [EnumMember(Value = "ABV")]
    Cabv,

    [EnumMember(Value = "ACR")]
    Cacr,

    [EnumMember(Value = "ADD")]
    Cadd,

    [EnumMember(Value = "ADJ")]
    Cadj,

    [EnumMember(Value = "AJT")]
    Cajt,

    [EnumMember(Value = "ALM")]
    Calm,

    [EnumMember(Value = "ALP")]
    Calp,

    [EnumMember(Value = "APE")]
    Cape,

    [EnumMember(Value = "APR")]
    Capr,

    [EnumMember(Value = "ARI")]
    Cari,

    [EnumMember(Value = "ASD")]
    Casd,

    [EnumMember(Value = "ATD")]
    Catd,

    [EnumMember(Value = "ATT")]
    Catt,

    [EnumMember(Value = "BBQ")]
    Cbbq,

    [EnumMember(Value = "BBR")]
    Cbbr,

    [EnumMember(Value = "BCC")]
    Cbcc,

    [EnumMember(Value = "BCR")]
    Cbcr,

    [EnumMember(Value = "BPL")]
    Cbpl,

    [EnumMember(Value = "BRL")]
    Cbrl,

    [EnumMember(Value = "BSL")]
    Cbsl,

    [EnumMember(Value = "BSP")]
    Cbsp,

    [EnumMember(Value = "BTC")]
    Cbtc,

    [EnumMember(Value = "BUI")]
    Cbui,

    [EnumMember(Value = "CAH")]
    Ccah,

    [EnumMember(Value = "CFI")]
    Ccfi,

    [EnumMember(Value = "CHG")]
    Cchg,

    [EnumMember(Value = "CIE")]
    Ccie,

    [EnumMember(Value = "CLP")]
    Cclp,

    [EnumMember(Value = "CML")]
    Ccml,

    [EnumMember(Value = "CNC")]
    Ccnc,

    [EnumMember(Value = "COG")]
    Ccog,

    [EnumMember(Value = "CPS")]
    Ccps,

    [EnumMember(Value = "CRC")]
    Ccrc,

    [EnumMember(Value = "CSD")]
    Ccsd,

    [EnumMember(Value = "CSF")]
    Ccsf,

    [EnumMember(Value = "DAC")]
    Cdac,

    [EnumMember(Value = "DBS")]
    Cdbs,

    [EnumMember(Value = "DGO")]
    Cdgo,

    [EnumMember(Value = "DLO")]
    Cdlo,

    [EnumMember(Value = "DLP")]
    Cdlp,

    [EnumMember(Value = "DOF")]
    Cdof,

    [EnumMember(Value = "DPE")]
    Cdpe,

    [EnumMember(Value = "DPL")]
    Cdpl,

    [EnumMember(Value = "DRL")]
    Cdrl,

    [EnumMember(Value = "DSR")]
    Cdsr,

    [EnumMember(Value = "DSS")]
    Cdss,

    [EnumMember(Value = "EAA")]
    Ceaa,

    [EnumMember(Value = "EAB")]
    Ceab,

    [EnumMember(Value = "EAC")]
    Ceac,

    [EnumMember(Value = "EAD")]
    Cead,

    [EnumMember(Value = "EAE")]
    Ceae,

    [EnumMember(Value = "EAF")]
    Ceaf,

    [EnumMember(Value = "EAG")]
    Ceag,

    [EnumMember(Value = "EAH")]
    Ceah,

    [EnumMember(Value = "EAI")]
    Ceai,

    [EnumMember(Value = "EAJ")]
    Ceaj,

    [EnumMember(Value = "EAK")]
    Ceak,

    [EnumMember(Value = "EAL")]
    Ceal,

    [EnumMember(Value = "EAM")]
    Ceam,

    [EnumMember(Value = "EAN")]
    Cean,

    [EnumMember(Value = "EAO")]
    Ceao,

    [EnumMember(Value = "EAP")]
    Ceap,

    [EnumMember(Value = "EAQ")]
    Ceaq,

    [EnumMember(Value = "EAR")]
    Cear,

    [EnumMember(Value = "EAS")]
    Ceas,

    [EnumMember(Value = "EAT")]
    Ceat,

    [EnumMember(Value = "EAU")]
    Ceau,

    [EnumMember(Value = "EAV")]
    Ceav,

    [EnumMember(Value = "EAW")]
    Ceaw,

    [EnumMember(Value = "EAX")]
    Ceax,

    [EnumMember(Value = "EAY")]
    Ceay,

    [EnumMember(Value = "EAZ")]
    Ceaz,

    [EnumMember(Value = "EBA")]
    Ceba,

    [EnumMember(Value = "EBB")]
    Cebb,

    [EnumMember(Value = "EBC")]
    Cebc,

    [EnumMember(Value = "EBD")]
    Cebd,

    [EnumMember(Value = "EBE")]
    Cebe,

    [EnumMember(Value = "EBF")]
    Cebf,

    [EnumMember(Value = "EBG")]
    Cebg,

    [EnumMember(Value = "EBH")]
    Cebh,

    [EnumMember(Value = "EBI")]
    Cebi,

    [EnumMember(Value = "EBJ")]
    Cebj,

    [EnumMember(Value = "EBK")]
    Cebk,

    [EnumMember(Value = "EBL")]
    Cebl,

    [EnumMember(Value = "EBM")]
    Cebm,

    [EnumMember(Value = "EBN")]
    Cebn,

    [EnumMember(Value = "EBO")]
    Cebo,

    [EnumMember(Value = "EBP")]
    Cebp,

    [EnumMember(Value = "EBQ")]
    Cebq,

    [EnumMember(Value = "EBR")]
    Cebr,

    [EnumMember(Value = "EBS")]
    Cebs,

    [EnumMember(Value = "EBT")]
    Cebt,

    [EnumMember(Value = "EBU")]
    Cebu,

    [EnumMember(Value = "EBV")]
    Cebv,

    [EnumMember(Value = "EBW")]
    Cebw,

    [EnumMember(Value = "EBX")]
    Cebx,

    [EnumMember(Value = "EBY")]
    Ceby,

    [EnumMember(Value = "EBZ")]
    Cebz,

    [EnumMember(Value = "ECA")]
    Ceca,

    [EnumMember(Value = "ECB")]
    Cecb,

    [EnumMember(Value = "ECC")]
    Cecc,

    [EnumMember(Value = "ECD")]
    Cecd,

    [EnumMember(Value = "ECE")]
    Cece,

    [EnumMember(Value = "ECF")]
    Cecf,

    [EnumMember(Value = "ECG")]
    Cecg,

    [EnumMember(Value = "ECH")]
    Cech,

    [EnumMember(Value = "ECI")]
    Ceci,

    [EnumMember(Value = "ECJ")]
    Cecj,

    [EnumMember(Value = "ECK")]
    Ceck,

    [EnumMember(Value = "ECL")]
    Cecl,

    [EnumMember(Value = "ECM")]
    Cecm,

    [EnumMember(Value = "ECN")]
    Cecn,

    [EnumMember(Value = "ECO")]
    Ceco,

    [EnumMember(Value = "ECP")]
    Cecp,

    [EnumMember(Value = "ECQ")]
    Cecq,

    [EnumMember(Value = "ECR")]
    Cecr,

    [EnumMember(Value = "ECS")]
    Cecs,

    [EnumMember(Value = "ECT")]
    Cect,

    [EnumMember(Value = "ECU")]
    Cecu,

    [EnumMember(Value = "ECV")]
    Cecv,

    [EnumMember(Value = "ECW")]
    Cecw,

    [EnumMember(Value = "ECX")]
    Cecx,

    [EnumMember(Value = "ECY")]
    Cecy,

    [EnumMember(Value = "ECZ")]
    Cecz,

    [EnumMember(Value = "EDA")]
    Ceda,

    [EnumMember(Value = "EDB")]
    Cedb,

    [EnumMember(Value = "EDC")]
    Cedc,

    [EnumMember(Value = "EDD")]
    Cedd,

    [EnumMember(Value = "EDE")]
    Cede,

    [EnumMember(Value = "EDF")]
    Cedf,

    [EnumMember(Value = "EDG")]
    Cedg,

    [EnumMember(Value = "EDH")]
    Cedh,

    [EnumMember(Value = "EDI")]
    Cedi,

    [EnumMember(Value = "EDJ")]
    Cedj,

    [EnumMember(Value = "EDK")]
    Cedk,

    [EnumMember(Value = "EDL")]
    Cedl,

    [EnumMember(Value = "EDM")]
    Cedm,

    [EnumMember(Value = "EDN")]
    Cedn,

    [EnumMember(Value = "EDO")]
    Cedo,

    [EnumMember(Value = "EDP")]
    Cedp,

    [EnumMember(Value = "EDQ")]
    Cedq,

    [EnumMember(Value = "EDR")]
    Cedr,

    [EnumMember(Value = "EDS")]
    Ceds,

    [EnumMember(Value = "EDT")]
    Cedt,

    [EnumMember(Value = "EDU")]
    Cedu,

    [EnumMember(Value = "EDV")]
    Cedv,

    [EnumMember(Value = "EDW")]
    Cedw,

    [EnumMember(Value = "EDX")]
    Cedx,

    [EnumMember(Value = "EDY")]
    Cedy,

    [EnumMember(Value = "EDZ")]
    Cedz,

    [EnumMember(Value = "EEA")]
    Ceea,

    [EnumMember(Value = "EEB")]
    Ceeb,

    [EnumMember(Value = "EEC")]
    Ceec,

    [EnumMember(Value = "EED")]
    Ceed,

    [EnumMember(Value = "EEE")]
    Ceee,

    [EnumMember(Value = "EEF")]
    Ceef,

    [EnumMember(Value = "EEG")]
    Ceeg,

    [EnumMember(Value = "EEH")]
    Ceeh,

    [EnumMember(Value = "EEI")]
    Ceei,

    [EnumMember(Value = "EEJ")]
    Ceej,

    [EnumMember(Value = "EEK")]
    Ceek,

    [EnumMember(Value = "EEL")]
    Ceel,

    [EnumMember(Value = "EEM")]
    Ceem,

    [EnumMember(Value = "EEN")]
    Ceen,

    [EnumMember(Value = "EEO")]
    Ceeo,

    [EnumMember(Value = "EEP")]
    Ceep,

    [EnumMember(Value = "EEQ")]
    Ceeq,

    [EnumMember(Value = "EER")]
    Ceer,

    [EnumMember(Value = "EES")]
    Cees,

    [EnumMember(Value = "EMC")]
    Cemc,

    [EnumMember(Value = "EQR")]
    Ceqr,

    [EnumMember(Value = "ESC")]
    Cesc,

    [EnumMember(Value = "ESL")]
    Cesl,

    [EnumMember(Value = "ETL")]
    Cetl,

    [EnumMember(Value = "EWC")]
    Cewc,

    [EnumMember(Value = "EWR")]
    Cewr,

    [EnumMember(Value = "EXD")]
    Cexd,

    [EnumMember(Value = "FAP")]
    Cfap,

    [EnumMember(Value = "FC1")]
    Cfc1,

    [EnumMember(Value = "FF1")]
    Cff1,

    [EnumMember(Value = "FH1")]
    Cfh1,

    [EnumMember(Value = "FIR")]
    Cfir,

    [EnumMember(Value = "FL1")]
    Cfl1,

    [EnumMember(Value = "FMO")]
    Cfmo,

    [EnumMember(Value = "FMS")]
    Cfms,

    [EnumMember(Value = "FP1")]
    Cfp1,

    [EnumMember(Value = "FRP")]
    Cfrp,

    [EnumMember(Value = "FT1")]
    Cft1,

    [EnumMember(Value = "HRC")]
    Chrc,

    [EnumMember(Value = "HZR")]
    Chzr,

    [EnumMember(Value = "IBP")]
    Cibp,

    [EnumMember(Value = "IMC")]
    Cimc,

    [EnumMember(Value = "IMP")]
    Cimp,

    [EnumMember(Value = "IND")]
    Cind,

    [EnumMember(Value = "IPA")]
    Cipa,

    [EnumMember(Value = "IRR")]
    Cirr,

    [EnumMember(Value = "IRT")]
    Cirt,

    [EnumMember(Value = "JCL")]
    Cjcl,

    [EnumMember(Value = "JOL")]
    Cjol,

    [EnumMember(Value = "KYL")]
    Ckyl,

    [EnumMember(Value = "LIN")]
    Clin,

    [EnumMember(Value = "LOC")]
    Cloc,

    [EnumMember(Value = "LOI")]
    Cloi,

    [EnumMember(Value = "LSC")]
    Clsc,

    [EnumMember(Value = "MAC")]
    Cmac,

    [EnumMember(Value = "MCC")]
    Cmcc,

    [EnumMember(Value = "MCD")]
    Cmcd,

    [EnumMember(Value = "MEC")]
    Cmec,

    [EnumMember(Value = "MOC")]
    Cmoc,

    [EnumMember(Value = "MOE")]
    Cmoe,

    [EnumMember(Value = "MRI")]
    Cmri,

    [EnumMember(Value = "NAC")]
    Cnac,

    [EnumMember(Value = "NAF")]
    Cnaf,

    [EnumMember(Value = "NAN")]
    Cnan,

    [EnumMember(Value = "NAS")]
    Cnas,

    [EnumMember(Value = "NDC")]
    Cndc,

    [EnumMember(Value = "NIR")]
    Cnir,

    [EnumMember(Value = "NPC")]
    Cnpc,

    [EnumMember(Value = "NUB")]
    Cnub,

    [EnumMember(Value = "PCR")]
    Cpcr,

    [EnumMember(Value = "PDA")]
    Cpda,

    [EnumMember(Value = "PGS")]
    Cpgs,

    [EnumMember(Value = "PHC")]
    Cphc,

    [EnumMember(Value = "PIT")]
    Cpit,

    [EnumMember(Value = "PLC")]
    Cplc,

    [EnumMember(Value = "PLS")]
    Cpls,

    [EnumMember(Value = "POB")]
    Cpob,

    [EnumMember(Value = "PPD")]
    Cppd,

    [EnumMember(Value = "PPP")]
    Cppp,

    [EnumMember(Value = "PPS")]
    Cpps,

    [EnumMember(Value = "PPV")]
    Cppv,

    [EnumMember(Value = "PQA")]
    Cpqa,

    [EnumMember(Value = "PRA")]
    Cpra,

    [EnumMember(Value = "PRC")]
    Cprc,

    [EnumMember(Value = "PRI")]
    Cpri,

    [EnumMember(Value = "PRR")]
    Cprr,

    [EnumMember(Value = "PRT")]
    Cprt,

    [EnumMember(Value = "PWA")]
    Cpwa,

    [EnumMember(Value = "PWI")]
    Cpwi,

    [EnumMember(Value = "PWR")]
    Cpwr,

    [EnumMember(Value = "PWS")]
    Cpws,

    [EnumMember(Value = "PWT")]
    Cpwt,

    [EnumMember(Value = "QDR")]
    Cqdr,

    [EnumMember(Value = "RAS")]
    Cras,

    [EnumMember(Value = "RCA")]
    Crca,

    [EnumMember(Value = "REC")]
    Crec,

    [EnumMember(Value = "RED")]
    Cred,

    [EnumMember(Value = "REN")]
    Cren,

    [EnumMember(Value = "RET")]
    Cret,

    [EnumMember(Value = "RFC")]
    Crfc,

    [EnumMember(Value = "RJC")]
    Crjc,

    [EnumMember(Value = "RSS")]
    Crss,

    [EnumMember(Value = "RTC")]
    Crtc,

    [EnumMember(Value = "RUM")]
    Crum,

    [EnumMember(Value = "RVC")]
    Crvc,

    [EnumMember(Value = "SAT")]
    Csat,

    [EnumMember(Value = "SBA")]
    Csba,

    [EnumMember(Value = "SCI")]
    Csci,

    [EnumMember(Value = "SEC")]
    Csec,

    [EnumMember(Value = "SET")]
    Cset,

    [EnumMember(Value = "SHL")]
    Cshl,

    [EnumMember(Value = "SHM")]
    Cshm,

    [EnumMember(Value = "SHN")]
    Cshn,

    [EnumMember(Value = "SHO")]
    Csho,

    [EnumMember(Value = "SHP")]
    Cshp,

    [EnumMember(Value = "SHQ")]
    Cshq,

    [EnumMember(Value = "SHR")]
    Cshr,

    [EnumMember(Value = "SHS")]
    Cshs,

    [EnumMember(Value = "SHT")]
    Csht,

    [EnumMember(Value = "SHU")]
    Cshu,

    [EnumMember(Value = "SHV")]
    Cshv,

    [EnumMember(Value = "SHW")]
    Cshw,

    [EnumMember(Value = "SHX")]
    Cshx,

    [EnumMember(Value = "SHY")]
    Cshy,

    [EnumMember(Value = "SHZ")]
    Cshz,

    [EnumMember(Value = "SIA")]
    Csia,

    [EnumMember(Value = "SIB")]
    Csib,

    [EnumMember(Value = "SIC")]
    Csic,

    [EnumMember(Value = "SID")]
    Csid,

    [EnumMember(Value = "SIE")]
    Csie,

    [EnumMember(Value = "SIF")]
    Csif,

    [EnumMember(Value = "SIG")]
    Csig,

    [EnumMember(Value = "SIH")]
    Csih,

    [EnumMember(Value = "SII")]
    Csii,

    [EnumMember(Value = "SIJ")]
    Csij,

    [EnumMember(Value = "SIK")]
    Csik,

    [EnumMember(Value = "SIL")]
    Csil,

    [EnumMember(Value = "SIM")]
    Csim,

    [EnumMember(Value = "SIN")]
    Csin,

    [EnumMember(Value = "SIO")]
    Csio,

    [EnumMember(Value = "SIP")]
    Csip,

    [EnumMember(Value = "SIQ")]
    Csiq,

    [EnumMember(Value = "SIR")]
    Csir,

    [EnumMember(Value = "SIS")]
    Csis,

    [EnumMember(Value = "SIT")]
    Csit,

    [EnumMember(Value = "SIU")]
    Csiu,

    [EnumMember(Value = "SIV")]
    Csiv,

    [EnumMember(Value = "SIW")]
    Csiw,

    [EnumMember(Value = "SIX")]
    Csix,

    [EnumMember(Value = "SIY")]
    Csiy,

    [EnumMember(Value = "SIZ")]
    Csiz,

    [EnumMember(Value = "SJA")]
    Csja,

    [EnumMember(Value = "SJB")]
    Csjb,

    [EnumMember(Value = "SJC")]
    Csjc,

    [EnumMember(Value = "SJD")]
    Csjd,

    [EnumMember(Value = "SJE")]
    Csje,

    [EnumMember(Value = "SJF")]
    Csjf,

    [EnumMember(Value = "SJG")]
    Csjg,

    [EnumMember(Value = "SJH")]
    Csjh,

    [EnumMember(Value = "SJI")]
    Csji,

    [EnumMember(Value = "SJJ")]
    Csjj,

    [EnumMember(Value = "SJK")]
    Csjk,

    [EnumMember(Value = "SJL")]
    Csjl,

    [EnumMember(Value = "SJM")]
    Csjm,

    [EnumMember(Value = "SJN")]
    Csjn,

    [EnumMember(Value = "SJO")]
    Csjo,

    [EnumMember(Value = "SJP")]
    Csjp,

    [EnumMember(Value = "SJQ")]
    Csjq,

    [EnumMember(Value = "SJR")]
    Csjr,

    [EnumMember(Value = "SJS")]
    Csjs,

    [EnumMember(Value = "SJT")]
    Csjt,

    [EnumMember(Value = "SJU")]
    Csju,

    [EnumMember(Value = "SJV")]
    Csjv,

    [EnumMember(Value = "SJW")]
    Csjw,

    [EnumMember(Value = "SJX")]
    Csjx,

    [EnumMember(Value = "SJY")]
    Csjy,

    [EnumMember(Value = "SJZ")]
    Csjz,

    [EnumMember(Value = "SKA")]
    Cska,

    [EnumMember(Value = "SKB")]
    Cskb,

    [EnumMember(Value = "SKC")]
    Cskc,

    [EnumMember(Value = "SKD")]
    Cskd,

    [EnumMember(Value = "SKE")]
    Cske,

    [EnumMember(Value = "SKF")]
    Cskf,

    [EnumMember(Value = "SKG")]
    Cskg,

    [EnumMember(Value = "SKH")]
    Cskh,

    [EnumMember(Value = "SKI")]
    Cski,

    [EnumMember(Value = "SKJ")]
    Cskj,

    [EnumMember(Value = "SKK")]
    Cskk,

    [EnumMember(Value = "SKL")]
    Cskl,

    [EnumMember(Value = "SKM")]
    Cskm,

    [EnumMember(Value = "SKN")]
    Cskn,

    [EnumMember(Value = "SKO")]
    Csko,

    [EnumMember(Value = "SKP")]
    Cskp,

    [EnumMember(Value = "SKQ")]
    Cskq,

    [EnumMember(Value = "SKR")]
    Cskr,

    [EnumMember(Value = "SKS")]
    Csks,

    [EnumMember(Value = "SKT")]
    Cskt,

    [EnumMember(Value = "SKU")]
    Csku,

    [EnumMember(Value = "SKV")]
    Cskv,

    [EnumMember(Value = "SKW")]
    Cskw,

    [EnumMember(Value = "SKX")]
    Cskx,

    [EnumMember(Value = "SKY")]
    Csky,

    [EnumMember(Value = "SKZ")]
    Cskz,

    [EnumMember(Value = "SLA")]
    Csla,

    [EnumMember(Value = "SLS")]
    Csls,

    [EnumMember(Value = "SMB")]
    Csmb,

    [EnumMember(Value = "SMC")]
    Csmc,

    [EnumMember(Value = "SMD")]
    Csmd,

    [EnumMember(Value = "SMI")]
    Csmi,

    [EnumMember(Value = "SMT")]
    Csmt,

    [EnumMember(Value = "SPE")]
    Cspe,

    [EnumMember(Value = "SRL")]
    Csrl,

    [EnumMember(Value = "SRR")]
    Csrr,

    [EnumMember(Value = "SRT")]
    Csrt,

    [EnumMember(Value = "SSC")]
    Cssc,

    [EnumMember(Value = "STC")]
    Cstc,

    [EnumMember(Value = "STF")]
    Cstf,

    [EnumMember(Value = "SUI")]
    Csui,

    [EnumMember(Value = "SVC")]
    Csvc,

    [EnumMember(Value = "SWR")]
    Cswr,

    [EnumMember(Value = "T00")]
    Ct00,

    [EnumMember(Value = "T01")]
    Ct01,

    [EnumMember(Value = "T02")]
    Ct02,

    [EnumMember(Value = "T03")]
    Ct03,

    [EnumMember(Value = "T04")]
    Ct04,

    [EnumMember(Value = "T05")]
    Ct05,

    [EnumMember(Value = "T06")]
    Ct06,

    [EnumMember(Value = "T07")]
    Ct07,

    [EnumMember(Value = "T08")]
    Ct08,

    [EnumMember(Value = "T09")]
    Ct09,

    [EnumMember(Value = "T10")]
    Ct10,

    [EnumMember(Value = "T11")]
    Ct11,

    [EnumMember(Value = "T12")]
    Ct12,

    [EnumMember(Value = "T13")]
    Ct13,

    [EnumMember(Value = "T14")]
    Ct14,

    [EnumMember(Value = "T15")]
    Ct15,

    [EnumMember(Value = "T16")]
    Ct16,

    [EnumMember(Value = "T17")]
    Ct17,

    [EnumMember(Value = "T18")]
    Ct18,

    [EnumMember(Value = "T19")]
    Ct19,

    [EnumMember(Value = "T20")]
    Ct20,

    [EnumMember(Value = "T21")]
    Ct21,

    [EnumMember(Value = "T22")]
    Ct22,

    [EnumMember(Value = "T23")]
    Ct23,

    [EnumMember(Value = "T24")]
    Ct24,

    [EnumMember(Value = "T25")]
    Ct25,

    [EnumMember(Value = "T26")]
    Ct26,

    [EnumMember(Value = "T27")]
    Ct27,

    [EnumMember(Value = "T28")]
    Ct28,

    [EnumMember(Value = "T29")]
    Ct29,

    [EnumMember(Value = "T30")]
    Ct30,

    [EnumMember(Value = "T31")]
    Ct31,

    [EnumMember(Value = "T32")]
    Ct32,

    [EnumMember(Value = "T33")]
    Ct33,

    [EnumMember(Value = "T34")]
    Ct34,

    [EnumMember(Value = "T35")]
    Ct35,

    [EnumMember(Value = "TCD")]
    Ctcd,

    [EnumMember(Value = "TCL")]
    Ctcl,

    [EnumMember(Value = "TFR")]
    Ctfr,

    [EnumMember(Value = "TOL")]
    Ctol,

    [EnumMember(Value = "TTL")]
    Cttl,

    [EnumMember(Value = "UER")]
    Cuer,

    [EnumMember(Value = "UJC")]
    Cujc,

    [EnumMember(Value = "UNP")]
    Cunp,

    [EnumMember(Value = "UPC")]
    Cupc,

    [EnumMember(Value = "UPT")]
    Cupt,

    [EnumMember(Value = "UTC")]
    Cutc,

    [EnumMember(Value = "VAL")]
    Cval,

    [EnumMember(Value = "WDL")]
    Cwdl,

    [EnumMember(Value = "WRC")]
    Cwrc,

    [EnumMember(Value = "WSD")]
    Cwsd,

    [EnumMember(Value = "CCC")]
    Cccc,

    [EnumMember(Value = "COR")]
    Ccor,

    [EnumMember(Value = "HMC")]
    Chmc,

    [EnumMember(Value = "TOC")]
    Ctoc,

    [EnumMember(Value = "WAC")]
    Cwac,

    [EnumMember(Value = "WEC")]
    Cwec,

    [EnumMember(Value = "WSC")]
    Cwsc,

    [EnumMember(Value = "WSM")]
    Cwsm,

    [EnumMember(Value = "R5")]
    Cr5,

    [EnumMember(Value = "DCC")]
    Cdcc,

    [EnumMember(Value = "DPC")]
    Cdpc,

    [EnumMember(Value = "IPG")]
    Cipg,

    [EnumMember(Value = "MFD")]
    Cmfd,

    [EnumMember(Value = "PCL")]
    Cpcl,

    [EnumMember(Value = "RNC")]
    Crnc,

    [EnumMember(Value = "RPQ")]
    Crpq,

    [EnumMember(Value = "RQI")]
    Crqi,

    [EnumMember(Value = "TC1")]
    Ctc1,

    [EnumMember(Value = "TDC")]
    Ctdc,

    [EnumMember(Value = "TDJ")]
    Ctdj,

    [EnumMember(Value = "UDC")]
    Cudc,

    [EnumMember(Value = "LCF")]
    Clcf,

    [EnumMember(Value = "NCD")]
    Cncd,

    [EnumMember(Value = "MRC")]
    Cmrc,

    [EnumMember(Value = "RFM")]
    Crfm,

    [EnumMember(Value = "RRC")]
    Crrc,

    [EnumMember(Value = "EPI")]
    Cepi,

    [EnumMember(Value = "EXP")]
    Cexp,

    [EnumMember(Value = "ACC")]
    Cacc,

    [EnumMember(Value = "AEA")]
    Caea,

    [EnumMember(Value = "AOR")]
    Caor,

    [EnumMember(Value = "CTC")]
    Cctc,

    [EnumMember(Value = "DNT")]
    Cdnt,

    [EnumMember(Value = "ITI")]
    Citi,

    [EnumMember(Value = "LPC")]
    Clpc,

    [EnumMember(Value = "LQT")]
    Clqt,

    [EnumMember(Value = "SAD")]
    Csad,

    [EnumMember(Value = "SLC")]
    Cslc,

    [EnumMember(Value = "ARD")]
    Card,

    [EnumMember(Value = "CRI")]
    Ccri,

    [EnumMember(Value = "ERC")]
    Cerc,

    [EnumMember(Value = "ERJ")]
    Cerj,

    [EnumMember(Value = "ERL")]
    Cerl,

    [EnumMember(Value = "ERR")]
    Cerr,

    [EnumMember(Value = "EWM")]
    Cewm,

    [EnumMember(Value = "NBA")]
    Cnba,

    [EnumMember(Value = "NGC")]
    Cngc,

    [EnumMember(Value = "SPD")]
    Cspd,

    [EnumMember(Value = "UBT")]
    Cubt,

    [EnumMember(Value = "UFC")]
    Cufc,

    [EnumMember(Value = "ARL")]
    Carl,

    [EnumMember(Value = "BUR")]
    Cbur,

    [EnumMember(Value = "ICF")]
    Cicf,

    [EnumMember(Value = "LMT")]
    Clmt,

    [EnumMember(Value = "SFO")]
    Csfo,

    [EnumMember(Value = "BBF")]
    Cbbf,

    [EnumMember(Value = "BBJ")]
    Cbbj,

    [EnumMember(Value = "BBK")]
    Cbbk,

    [EnumMember(Value = "BBN")]
    Cbbn,

    [EnumMember(Value = "BBU")]
    Cbbu,

    [EnumMember(Value = "BBV")]
    Cbbv,

    [EnumMember(Value = "BDD")]
    Cbdd,

    [EnumMember(Value = "BPR")]
    Cbpr,

    [EnumMember(Value = "BSD")]
    Cbsd,

    [EnumMember(Value = "BTD")]
    Cbtd,

    [EnumMember(Value = "CBQ")]
    Ccbq,

    [EnumMember(Value = "CBR")]
    Ccbr,

    [EnumMember(Value = "DAP")]
    Cdap,

    [EnumMember(Value = "DCM")]
    Cdcm,

    [EnumMember(Value = "DCR")]
    Cdcr,

    [EnumMember(Value = "DCS")]
    Cdcs,

    [EnumMember(Value = "DCT")]
    Cdct,

    [EnumMember(Value = "DIR")]
    Cdir,

    [EnumMember(Value = "DLT")]
    Cdlt,

    [EnumMember(Value = "DMI")]
    Cdmi,

    [EnumMember(Value = "DRD")]
    Cdrd,

    [EnumMember(Value = "DSC")]
    Cdsc,

    [EnumMember(Value = "DSD")]
    Cdsd,

    [EnumMember(Value = "DSI")]
    Cdsi,

    [EnumMember(Value = "POS")]
    Cpos,

    [EnumMember(Value = "TTD")]
    Cttd,

    [EnumMember(Value = "TTU")]
    Cttu,

    [EnumMember(Value = "RM")]
    Crm,

    [EnumMember(Value = "AQA")]
    Caqa,

    [EnumMember(Value = "FRT")]
    Cfrt,

    [EnumMember(Value = "DMP")]
    Cdmp,

    [EnumMember(Value = "DRS")]
    Cdrs,

    [EnumMember(Value = "NCE")]
    Cnce,

    [EnumMember(Value = "EP")]
    Cep,

    [EnumMember(Value = "SRA")]
    Csra,

    [EnumMember(Value = "DV")]
    Cdv,

    [EnumMember(Value = "ACS")]
    Cacs,

    [EnumMember(Value = "ACT")]
    Cact,

    [EnumMember(Value = "ACU")]
    Cacu,

    [EnumMember(Value = "ACV")]
    Cacv,

    [EnumMember(Value = "ACW")]
    Cacw,

    [EnumMember(Value = "ACX")]
    Cacx,

    [EnumMember(Value = "ACY")]
    Cacy,

    [EnumMember(Value = "ACZ")]
    Cacz,

    [EnumMember(Value = "AD1")]
    Cad1,

    [EnumMember(Value = "AD2")]
    Cad2,

    [EnumMember(Value = "AD3")]
    Cad3,

    [EnumMember(Value = "AD4")]
    Cad4,

    [EnumMember(Value = "DTS")]
    Cdts,

    [EnumMember(Value = "MPP")]
    Cmpp,

    [EnumMember(Value = "MPT")]
    Cmpt,

    [EnumMember(Value = "NMS")]
    Cnms,

    [EnumMember(Value = "SRC")]
    Csrc,
}
