using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(EnumSerializer<ReportTypeCode>))]
public enum ReportTypeCode
{
    [EnumMember(Value = "03")]
    C03,

    [EnumMember(Value = "04")]
    C04,

    [EnumMember(Value = "05")]
    C05,

    [EnumMember(Value = "06")]
    C06,

    [EnumMember(Value = "07")]
    C07,

    [EnumMember(Value = "08")]
    C08,

    [EnumMember(Value = "09")]
    C09,

    [EnumMember(Value = "10")]
    C10,

    [EnumMember(Value = "11")]
    C11,

    [EnumMember(Value = "13")]
    C13,

    [EnumMember(Value = "15")]
    C15,

    [EnumMember(Value = "21")]
    C21,

    [EnumMember(Value = "A3")]
    Ca3,

    [EnumMember(Value = "A4")]
    Ca4,

    [EnumMember(Value = "AM")]
    Cam,

    [EnumMember(Value = "AS")]
    Cas,

    [EnumMember(Value = "B2")]
    Cb2,

    [EnumMember(Value = "B3")]
    Cb3,

    [EnumMember(Value = "B4")]
    Cb4,

    [EnumMember(Value = "BR")]
    Cbr,

    [EnumMember(Value = "BS")]
    Cbs,

    [EnumMember(Value = "BT")]
    Cbt,

    [EnumMember(Value = "CB")]
    Ccb,

    [EnumMember(Value = "CK")]
    Cck,

    [EnumMember(Value = "CT")]
    Cct,

    [EnumMember(Value = "D2")]
    Cd2,

    [EnumMember(Value = "DA")]
    Cda,

    [EnumMember(Value = "DB")]
    Cdb,

    [EnumMember(Value = "DG")]
    Cdg,

    [EnumMember(Value = "DJ")]
    Cdj,

    [EnumMember(Value = "DS")]
    Cds,

    [EnumMember(Value = "EB")]
    Ceb,

    [EnumMember(Value = "HC")]
    Chc,

    [EnumMember(Value = "HR")]
    Chr,

    [EnumMember(Value = "I5")]
    Ci5,

    [EnumMember(Value = "IR")]
    Cir,

    [EnumMember(Value = "LA")]
    Cla,

    [EnumMember(Value = "M1")]
    Cm1,

    [EnumMember(Value = "MT")]
    Cmt,

    [EnumMember(Value = "NN")]
    Cnn,

    [EnumMember(Value = "OB")]
    Cob,

    [EnumMember(Value = "OC")]
    Coc,

    [EnumMember(Value = "OD")]
    Cod,

    [EnumMember(Value = "OE")]
    Coe,

    [EnumMember(Value = "OX")]
    Cox,

    [EnumMember(Value = "OZ")]
    Coz,

    [EnumMember(Value = "P4")]
    Cp4,

    [EnumMember(Value = "P5")]
    Cp5,

    [EnumMember(Value = "PE")]
    Cpe,

    [EnumMember(Value = "PN")]
    Cpn,

    [EnumMember(Value = "PO")]
    Cpo,

    [EnumMember(Value = "PQ")]
    Cpq,

    [EnumMember(Value = "PY")]
    Cpy,

    [EnumMember(Value = "PZ")]
    Cpz,

    [EnumMember(Value = "RB")]
    Crb,

    [EnumMember(Value = "RR")]
    Crr,

    [EnumMember(Value = "RT")]
    Crt,

    [EnumMember(Value = "RX")]
    Crx,

    [EnumMember(Value = "SG")]
    Csg,

    [EnumMember(Value = "V5")]
    Cv5,

    [EnumMember(Value = "XP")]
    Cxp,
}
