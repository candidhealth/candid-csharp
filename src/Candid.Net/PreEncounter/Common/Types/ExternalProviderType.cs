using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<ExternalProviderType>))]
public enum ExternalProviderType
{
    [EnumMember(Value = "PRIMARY")]
    Primary,

    [EnumMember(Value = "REFERRING")]
    Referring,

    [EnumMember(Value = "ATTENDING")]
    Attending,
}
