using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record PlanCoverageDetails
{
    [JsonPropertyName("deductible")]
    public CoverageValue? Deductible { get; set; }

    [JsonPropertyName("deductible_remaining")]
    public CoverageValue? DeductibleRemaining { get; set; }

    [JsonPropertyName("oop_max")]
    public CoverageValue? OopMax { get; set; }

    [JsonPropertyName("oop_max_remaining")]
    public CoverageValue? OopMaxRemaining { get; set; }

    [JsonPropertyName("additional_notes")]
    public string? AdditionalNotes { get; set; }
}
