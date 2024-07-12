using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchGeo
{
    [JsonPropertyName("zip_code")]
    public string? ZipCode { get; init; }

    [JsonPropertyName("state")]
    public State? State { get; init; }

    [JsonPropertyName("match")]
    public required bool Match { get; init; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; init; }
}
