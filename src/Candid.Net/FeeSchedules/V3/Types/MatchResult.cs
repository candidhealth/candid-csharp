using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchResult
{
    [JsonPropertyName("threshold")]
    public required ThresholdMatch Threshold { get; init; }

    [JsonPropertyName("rate_id")]
    public required Guid RateId { get; init; }
}
