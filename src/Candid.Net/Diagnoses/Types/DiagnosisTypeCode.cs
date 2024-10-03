using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<DiagnosisTypeCode>))]
public enum DiagnosisTypeCode
{
    [EnumMember(Value = "ABF")]
    Abf,

    [EnumMember(Value = "ABJ")]
    Abj,

    [EnumMember(Value = "ABK")]
    Abk,

    [EnumMember(Value = "APR")]
    Apr,

    [EnumMember(Value = "BF")]
    Bf,

    [EnumMember(Value = "BJ")]
    Bj,

    [EnumMember(Value = "BK")]
    Bk,

    [EnumMember(Value = "PR")]
    Pr,

    [EnumMember(Value = "DR")]
    Dr,

    [EnumMember(Value = "LOI")]
    Loi,
}
