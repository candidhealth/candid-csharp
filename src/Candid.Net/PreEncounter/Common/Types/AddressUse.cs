using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<AddressUse>))]
public enum AddressUse
{
    [EnumMember(Value = "HOME")]
    Home,

    [EnumMember(Value = "WORK")]
    Work,

    [EnumMember(Value = "TEMP")]
    Temp,

    [EnumMember(Value = "OLD")]
    Old,

    [EnumMember(Value = "BILLING")]
    Billing
}
