using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Credentialing.V2;

[JsonConverter(typeof(StringEnumSerializer<CredentialingSpanStatus>))]
public enum CredentialingSpanStatus
{
    [EnumMember(Value = "work_in_progress")]
    WorkInProgress,

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "effective")]
    Effective,

    [EnumMember(Value = "expired")]
    Expired,
}
