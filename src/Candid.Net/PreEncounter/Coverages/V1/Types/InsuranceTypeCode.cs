using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(EnumSerializer<InsuranceTypeCode>))]
public enum InsuranceTypeCode
{
    [EnumMember(Value = "01")]
    C01,

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

    [EnumMember(Value = "41")]
    C41,

    [EnumMember(Value = "42")]
    C42,

    [EnumMember(Value = "43")]
    C43,

    [EnumMember(Value = "47")]
    C47,

    [EnumMember(Value = "AP")]
    Cap,

    [EnumMember(Value = "C1")]
    Cc1,

    [EnumMember(Value = "CO")]
    Cco,

    [EnumMember(Value = "CP")]
    Ccp,

    [EnumMember(Value = "D")]
    Cd,

    [EnumMember(Value = "DB")]
    Cdb,

    [EnumMember(Value = "E")]
    Ce,

    [EnumMember(Value = "EP")]
    Cep,

    [EnumMember(Value = "FF")]
    Cff,

    [EnumMember(Value = "GP")]
    Cgp,

    [EnumMember(Value = "HA")]
    Cha,

    [EnumMember(Value = "HB")]
    Chb,

    [EnumMember(Value = "HD")]
    Chd,

    [EnumMember(Value = "HG")]
    Chg,

    [EnumMember(Value = "HM")]
    Chm,

    [EnumMember(Value = "HN")]
    Chn,

    [EnumMember(Value = "HP")]
    Chp,

    [EnumMember(Value = "HS")]
    Chs,

    [EnumMember(Value = "IN")]
    Cin,

    [EnumMember(Value = "IP")]
    Cip,

    [EnumMember(Value = "LC")]
    Clc,

    [EnumMember(Value = "LD")]
    Cld,

    [EnumMember(Value = "LI")]
    Cli,

    [EnumMember(Value = "LT")]
    Clt,

    [EnumMember(Value = "M")]
    Cm,

    [EnumMember(Value = "MA")]
    Cma,

    [EnumMember(Value = "MB")]
    Cmb,

    [EnumMember(Value = "MC")]
    Cmc,

    [EnumMember(Value = "MD")]
    Cmd,

    [EnumMember(Value = "ME")]
    Cme,

    [EnumMember(Value = "MF")]
    Cmf,

    [EnumMember(Value = "MH")]
    Cmh,

    [EnumMember(Value = "MI")]
    Cmi,

    [EnumMember(Value = "MJ")]
    Cmj,

    [EnumMember(Value = "MK")]
    Cmk,

    [EnumMember(Value = "ML")]
    Cml,

    [EnumMember(Value = "MM")]
    Cmm,

    [EnumMember(Value = "MN")]
    Cmn,

    [EnumMember(Value = "MO")]
    Cmo,

    [EnumMember(Value = "MP")]
    Cmp,

    [EnumMember(Value = "MR")]
    Cmr,

    [EnumMember(Value = "MT")]
    Cmt,

    [EnumMember(Value = "MV")]
    Cmv,

    [EnumMember(Value = "OA")]
    Coa,

    [EnumMember(Value = "OT")]
    Cot,

    [EnumMember(Value = "PL")]
    Cpl,

    [EnumMember(Value = "PP")]
    Cpp,

    [EnumMember(Value = "PR")]
    Cpr,

    [EnumMember(Value = "PS")]
    Cps,

    [EnumMember(Value = "QM")]
    Cqm,

    [EnumMember(Value = "RP")]
    Crp,

    [EnumMember(Value = "SP")]
    Csp,

    [EnumMember(Value = "TF")]
    Ctf,

    [EnumMember(Value = "U")]
    Cu,

    [EnumMember(Value = "WC")]
    Cwc,

    [EnumMember(Value = "WU")]
    Cwu,
}
