using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record EligibilityRecommendationRequest
{
    public string? Filters { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
