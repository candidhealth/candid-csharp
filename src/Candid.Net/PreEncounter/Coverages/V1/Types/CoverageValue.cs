using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record CoverageValue
{
    [JsonPropertyName("family")]
    public double? Family { get; set; }

    [JsonPropertyName("individual")]
    public double? Individual { get; set; }
}
