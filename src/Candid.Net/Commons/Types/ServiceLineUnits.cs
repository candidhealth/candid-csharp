using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<ServiceLineUnits>))]
public enum ServiceLineUnits
{
    [EnumMember(Value = "MJ")]
    Mj,

    [EnumMember(Value = "UN")]
    Un,
}
