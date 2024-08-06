using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<DisabilityStatus>))]
public enum DisabilityStatus
{
    [EnumMember(Value = "DISABLED")]
    Disabled,

    [EnumMember(Value = "NON_DISABLED")]
    NonDisabled
}
