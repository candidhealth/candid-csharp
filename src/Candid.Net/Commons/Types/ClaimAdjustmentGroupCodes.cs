using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<ClaimAdjustmentGroupCodes>))]
public enum ClaimAdjustmentGroupCodes
{
    [EnumMember(Value = "CO")]
    Co,

    [EnumMember(Value = "CR")]
    Cr,

    [EnumMember(Value = "DE")]
    De,

    [EnumMember(Value = "MA")]
    Ma,

    [EnumMember(Value = "OA")]
    Oa,

    [EnumMember(Value = "PI")]
    Pi,

    [EnumMember(Value = "PR")]
    Pr,

    [EnumMember(Value = "RR")]
    Rr,

    [EnumMember(Value = "NC")]
    Nc,

    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
