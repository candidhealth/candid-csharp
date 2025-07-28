using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record PostEligibilityRecommendationRequest
{
    [JsonPropertyName("eligibility_check_id")]
    public required string EligibilityCheckId { get; set; }

    [JsonPropertyName("patient")]
    public required EligibilityRecommendationPatientInfo Patient { get; set; }

    [JsonPropertyName("recommendation")]
    public required object Recommendation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
