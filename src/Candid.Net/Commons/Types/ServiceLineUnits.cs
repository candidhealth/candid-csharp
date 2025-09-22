using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

[JsonConverter(typeof(EnumSerializer<ServiceLineUnits>))]
public enum ServiceLineUnits
{
    [EnumMember(Value = "MJ")]
    Mj,

    [EnumMember(Value = "UN")]
    Un,
}
