using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record PlanCoverageDetails
{
    [JsonPropertyName("deductible")]
    public CoverageValue? Deductible { get; set; }

    [JsonPropertyName("deductible_contract")]
    public CoverageValue? DeductibleContract { get; set; }

    [JsonPropertyName("deductible_remaining")]
    public CoverageValue? DeductibleRemaining { get; set; }

    [JsonPropertyName("deductible_year_to_date")]
    public CoverageValue? DeductibleYearToDate { get; set; }

    [JsonPropertyName("oop_max")]
    public CoverageValue? OopMax { get; set; }

    [JsonPropertyName("oop_max_contract")]
    public CoverageValue? OopMaxContract { get; set; }

    [JsonPropertyName("oop_max_remaining")]
    public CoverageValue? OopMaxRemaining { get; set; }

    [JsonPropertyName("oop_max_year_to_date")]
    public CoverageValue? OopMaxYearToDate { get; set; }

    [JsonPropertyName("additional_notes")]
    public string? AdditionalNotes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
