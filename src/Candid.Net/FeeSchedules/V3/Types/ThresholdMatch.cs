using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record ThresholdMatch
{
    [JsonPropertyName("threshold")]
    public required PayerThreshold Threshold { get; set; }

    [JsonPropertyName("rate_cents")]
    public required int RateCents { get; set; }

    [JsonPropertyName("match")]
    public required bool Match { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }
}
