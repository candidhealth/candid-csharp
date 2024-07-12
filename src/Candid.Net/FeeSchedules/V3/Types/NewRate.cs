using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record NewRate
{
    [JsonPropertyName("dimensions")]
    public required Dimensions Dimensions { get; init; }

    [JsonPropertyName("entries")]
    public IEnumerable<RateEntry> Entries { get; init; } = new List<RateEntry>();
}
