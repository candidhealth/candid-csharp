using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record CoordinationOfBenefitsRecommendation
{
    [JsonPropertyName("payload")]
    public required object Payload { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
