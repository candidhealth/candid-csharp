using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchProvider
{
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("match")]
    public required bool Match { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }
}
