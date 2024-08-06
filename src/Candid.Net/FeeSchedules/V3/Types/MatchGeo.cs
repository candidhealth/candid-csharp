using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchGeo
{
    [JsonPropertyName("zip_code")]
    public string? ZipCode { get; set; }

    [JsonPropertyName("state")]
    public State? State { get; set; }

    [JsonPropertyName("match")]
    public required bool Match { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }
}
