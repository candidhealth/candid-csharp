using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(EnumSerializer<EligibilityCheckStatus>))]
public enum EligibilityCheckStatus
{
    [EnumMember(Value = "COMPLETED")]
    Completed,

    [EnumMember(Value = "FAILED")]
    Failed,

    [EnumMember(Value = "PENDING")]
    Pending,
}
