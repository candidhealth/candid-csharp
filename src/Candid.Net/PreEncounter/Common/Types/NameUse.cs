using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<NameUse>))]
public enum NameUse
{
    [EnumMember(Value = "USUAL")]
    Usual,

    [EnumMember(Value = "OFFICIAL")]
    Official,

    [EnumMember(Value = "TEMP")]
    Temp,

    [EnumMember(Value = "NICKNAME")]
    Nickname,

    [EnumMember(Value = "ANONYMOUS")]
    Anonymous,

    [EnumMember(Value = "OLD")]
    Old,

    [EnumMember(Value = "MAIDEN")]
    Maiden,
}
