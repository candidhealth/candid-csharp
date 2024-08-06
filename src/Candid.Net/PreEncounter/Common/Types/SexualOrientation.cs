using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<SexualOrientation>))]
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
    Refused
}
