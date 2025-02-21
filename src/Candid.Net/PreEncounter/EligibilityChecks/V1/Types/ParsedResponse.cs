using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Coverages.V1;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record ParsedResponse
{
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
