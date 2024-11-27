using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(EnumSerializer<Sex>))]
public enum Sex
{
    [EnumMember(Value = "FEMALE")]
    Female,

    [EnumMember(Value = "MALE")]
    Male,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    [EnumMember(Value = "REFUSED")]
    Refused,
}
