using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchNetworkTypes
{
    [JsonPropertyName("value")]
    public HashSet<NetworkType> Value { get; init; } = new HashSet<NetworkType>();

    [JsonPropertyName("match")]
    public required bool Match { get; init; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; init; }
}
