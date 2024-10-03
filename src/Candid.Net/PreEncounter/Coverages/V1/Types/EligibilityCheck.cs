using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record EligibilityCheck
{
    [JsonPropertyName("raw_json")]
    public required object RawJson { get; set; }

    [JsonPropertyName("errors")]
    public object? Errors { get; set; }

    [JsonPropertyName("eligibility_status")]
    public required EligibilityStatus EligibilityStatus { get; set; }

    [JsonPropertyName("plan_metadata")]
    public PlanMetadata? PlanMetadata { get; set; }

    [JsonPropertyName("benefits")]
    public CoverageBenefits? Benefits { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
