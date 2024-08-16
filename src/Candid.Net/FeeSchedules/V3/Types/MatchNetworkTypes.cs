using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchNetworkTypes
{
    [JsonPropertyName("value")]
    public HashSet<NetworkType> Value { get; set; } = new HashSet<NetworkType>();

    [JsonPropertyName("match")]
    public required bool Match { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }
}
