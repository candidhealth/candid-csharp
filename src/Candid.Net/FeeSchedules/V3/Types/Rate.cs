using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record Rate
{
    [JsonPropertyName("rate_id")]
    public required string RateId { get; set; }

    /// <summary>
    /// The dimension values that distinguish this rate from others.
    /// </summary>
    [JsonPropertyName("dimensions")]
    public required Dimensions Dimensions { get; set; }

    /// <summary>
    /// The version of this rate in the system.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateOnly UpdatedAt { get; set; }

    [JsonPropertyName("updated_by")]
    public required string UpdatedBy { get; set; }

    [JsonPropertyName("entries")]
    public IEnumerable<RateEntry> Entries { get; set; } = new List<RateEntry>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
