using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchPayer
{
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonPropertyName("match")]
    public required bool Match { get; init; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; init; }
}
