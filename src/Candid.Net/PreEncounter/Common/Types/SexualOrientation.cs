using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(EnumSerializer<SexualOrientation>))]
public enum SexualOrientation
{
    [EnumMember(Value = "HETEROSEXUAL")]
    Heterosexual,

    [EnumMember(Value = "HOMOSEXUAL")]
    Homosexual,

    [EnumMember(Value = "BISEXUAL")]
    Bisexual,

    [EnumMember(Value = "TWO_SPIRIT")]
    TwoSpirit,

    [EnumMember(Value = "OTHER")]
    Other,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    [EnumMember(Value = "REFUSED")]
    Refused,
}
