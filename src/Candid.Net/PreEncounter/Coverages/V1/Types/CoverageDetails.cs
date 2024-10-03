using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record CoverageDetails
{
    [JsonPropertyName("type")]
    public required BenefitType Type { get; set; }

    [JsonPropertyName("coverageLevel")]
    public required CoverageLevel CoverageLevel { get; set; }

    [JsonPropertyName("unit")]
    public required CoverageValueUnit Unit { get; set; }

    [JsonPropertyName("value")]
    public required double Value { get; set; }

    [JsonPropertyName("additional_notes")]
    public string? AdditionalNotes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
