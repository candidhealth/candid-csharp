using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record ServiceCoverageDetails
{
    [JsonPropertyName("copay")]
    public CoverageValue? Copay { get; set; }

    [JsonPropertyName("coinsurance")]
    public CoverageValue? Coinsurance { get; set; }

    [JsonPropertyName("visits")]
    public CoverageValue? Visits { get; set; }

    [JsonPropertyName("visits_remaining")]
    public CoverageValue? VisitsRemaining { get; set; }

    [JsonPropertyName("additional_notes")]
    public string? AdditionalNotes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
