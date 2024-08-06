using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record OverlappingRateEntriesError
{
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("rate_a")]
    public required RateEntry RateA { get; set; }

    [JsonPropertyName("rate_b")]
    public required RateEntry RateB { get; set; }
}
