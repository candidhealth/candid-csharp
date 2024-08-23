using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record CoverageValue
{
    [JsonPropertyName("family")]
    public int? Family { get; set; }

    [JsonPropertyName("individual")]
    public int? Individual { get; set; }
}
