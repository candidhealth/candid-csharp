using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter.EligibilityChecks.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record LatestEligibilityCheck
{
    [JsonPropertyName("check_id")]
    public required string CheckId { get; set; }

    [JsonPropertyName("status")]
    public required EligibilityStatus Status { get; set; }

    [JsonPropertyName("initiated_at")]
    public required DateTime InitiatedAt { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
