using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[Serializable]
public record EligibilityRecommendationRequest
{
    [JsonIgnore]
    public string? Filters { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
