using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record ThresholdMatch
{
    [JsonPropertyName("threshold")]
    public required PayerThreshold Threshold { get; init; }

    [JsonPropertyName("rate_cents")]
    public required int RateCents { get; init; }

    [JsonPropertyName("match")]
    public required bool Match { get; init; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; init; }
}
