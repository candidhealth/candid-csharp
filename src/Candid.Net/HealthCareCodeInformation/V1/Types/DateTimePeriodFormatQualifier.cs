using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<DateTimePeriodFormatQualifier>))]
public enum DateTimePeriodFormatQualifier
{
    [EnumMember(Value = "CC")]
    Ccc,

    [EnumMember(Value = "CD")]
    Ccd,

    [EnumMember(Value = "CM")]
    Ccm,

    [EnumMember(Value = "CQ")]
    Ccq,

    [EnumMember(Value = "CY")]
    Ccy,

    [EnumMember(Value = "D6")]
    Cd6,

    [EnumMember(Value = "D8")]
    Cd8,

    [EnumMember(Value = "DA")]
    Cda,

    [EnumMember(Value = "DB")]
    Cdb,

    [EnumMember(Value = "DD")]
    Cdd,

    [EnumMember(Value = "DT")]
    Cdt,

    [EnumMember(Value = "EH")]
    Ceh,

    [EnumMember(Value = "KA")]
    Cka,

    [EnumMember(Value = "MD")]
    Cmd,

    [EnumMember(Value = "MM")]
    Cmm,

    [EnumMember(Value = "RD")]
    Crd,

    [EnumMember(Value = "TC")]
    Ctc,

    [EnumMember(Value = "TM")]
    Ctm,

    [EnumMember(Value = "TQ")]
    Ctq,

    [EnumMember(Value = "TR")]
    Ctr,

    [EnumMember(Value = "TS")]
    Cts,

    [EnumMember(Value = "TT")]
    Ctt,

    [EnumMember(Value = "TU")]
    Ctu,

    [EnumMember(Value = "UN")]
    Cun,

    [EnumMember(Value = "YM")]
    Cym,

    [EnumMember(Value = "YY")]
    Cyy,

    [EnumMember(Value = "DDT")]
    Cddt,

    [EnumMember(Value = "DTD")]
    Cdtd,

    [EnumMember(Value = "DTS")]
    Cdts,

    [EnumMember(Value = "MCY")]
    Cmcy,

    [EnumMember(Value = "RD2")]
    Crd2,

    [EnumMember(Value = "RD4")]
    Crd4,

    [EnumMember(Value = "RD5")]
    Crd5,

    [EnumMember(Value = "RD6")]
    Crd6,

    [EnumMember(Value = "RD8")]
    Crd8,

    [EnumMember(Value = "RDM")]
    Crdm,

    [EnumMember(Value = "RDT")]
    Crdt,

    [EnumMember(Value = "RMD")]
    Crmd,

    [EnumMember(Value = "RMY")]
    Crmy,

    [EnumMember(Value = "RTM")]
    Crtm,

    [EnumMember(Value = "RTS")]
    Crts,

    [EnumMember(Value = "YMM")]
    Cymm,
}
