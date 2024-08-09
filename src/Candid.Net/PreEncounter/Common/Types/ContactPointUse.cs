using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<ContactPointUse>))]
public enum ContactPointUse
{
    [EnumMember(Value = "HOME")]
    Home,

    [EnumMember(Value = "WORK")]
    Work,

    [EnumMember(Value = "TEMP")]
    Temp,

    [EnumMember(Value = "OLD")]
    Old,

    [EnumMember(Value = "MOBILE")]
    Mobile
}
