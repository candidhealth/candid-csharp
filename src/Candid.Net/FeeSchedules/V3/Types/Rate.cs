using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record Rate
{
    [JsonPropertyName("rate_id")]
    public required string RateId { get; init; }

    /// <summary>
    /// The dimension values that distinguish this rate from others.
    /// </summary>
    [JsonPropertyName("dimensions")]
    public required Dimensions Dimensions { get; init; }

    /// <summary>
    /// The version of this rate in the system.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    [JsonPropertyName("updated_at")]
    public required DateOnly UpdatedAt { get; init; }

    [JsonPropertyName("updated_by")]
    public required string UpdatedBy { get; init; }

    [JsonPropertyName("entries")]
    public IEnumerable<RateEntry> Entries { get; init; } = new List<RateEntry>();
}
