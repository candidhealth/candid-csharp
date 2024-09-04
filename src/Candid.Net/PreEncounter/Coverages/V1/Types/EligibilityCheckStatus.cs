using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(StringEnumSerializer<EligibilityCheckStatus>))]
public enum EligibilityCheckStatus
{
    [EnumMember(Value = "CREATED")]
    Created,

    [EnumMember(Value = "COMPLETED")]
    Completed,

    [EnumMember(Value = "FAILED")]
    Failed,

    [EnumMember(Value = "PENDING")]
    Pending
}