using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<SynchronicityType>))]
public enum SynchronicityType
{
    [EnumMember(Value = "Synchronous")]
    Synchronous,

    [EnumMember(Value = "Asynchronous")]
    Asynchronous
}
