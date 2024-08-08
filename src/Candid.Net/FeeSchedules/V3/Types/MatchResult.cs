using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchResult
{
    [JsonPropertyName("threshold")]
    public required ThresholdMatch Threshold { get; set; }

    [JsonPropertyName("rate_id")]
    public required string RateId { get; set; }
}
