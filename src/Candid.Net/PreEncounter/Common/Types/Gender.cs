using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<Gender>))]
public enum Gender
{
    [EnumMember(Value = "MAN")]
    Man,

    [EnumMember(Value = "WOMAN")]
    Woman,

    [EnumMember(Value = "NON_BINARY")]
    NonBinary,

    [EnumMember(Value = "TWO_SPIRIT")]
    TwoSpirit,

    [EnumMember(Value = "OTHER")]
    Other,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    [EnumMember(Value = "REFUSED")]
    Refused
}
