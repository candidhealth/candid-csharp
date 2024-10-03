using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record CoverageEligibilityCheckResponse
{
    [JsonPropertyName("metadata")]
    public required EligibilityCheckMetadata Metadata { get; set; }

    [JsonPropertyName("check")]
    public EligibilityCheck? Check { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
