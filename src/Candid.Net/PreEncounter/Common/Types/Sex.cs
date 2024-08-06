using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<Sex>))]
public enum Sex
{
    [EnumMember(Value = "FEMALE")]
    Female,

    [EnumMember(Value = "MALE")]
    Male,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    [EnumMember(Value = "REFUSED")]
    Refused
}
