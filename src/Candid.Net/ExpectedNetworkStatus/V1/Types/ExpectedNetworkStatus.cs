using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.ExpectedNetworkStatus.V1;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V1;

[JsonConverter(typeof(StringEnumSerializer<ExpectedNetworkStatus>))]
public enum ExpectedNetworkStatus
{
    [EnumMember(Value = "in_network")]
    InNetwork,

    [EnumMember(Value = "out_of_network")]
    OutOfNetwork,

    [EnumMember(Value = "unknown")]
    Unknown
}
