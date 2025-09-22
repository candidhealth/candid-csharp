using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(EnumSerializer<DisabilityStatus>))]
public enum DisabilityStatus
{
    [EnumMember(Value = "DISABLED")]
    Disabled,

    [EnumMember(Value = "NON_DISABLED")]
    NonDisabled,
}
