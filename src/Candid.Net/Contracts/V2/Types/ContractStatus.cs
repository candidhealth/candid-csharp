using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Contracts.V2;

[JsonConverter(typeof(EnumSerializer<ContractStatus>))]
public enum ContractStatus
{
    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "effective")]
    Effective,

    [EnumMember(Value = "cancelled")]
    Cancelled,
}
