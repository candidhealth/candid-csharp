using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record CoverageEligibilityCheckResponse
{
    [JsonPropertyName("metadata")]
    public required EligibilityCheckMetadata Metadata { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("check")]
    public EligibilityCheck? Check { get; set; }
}
