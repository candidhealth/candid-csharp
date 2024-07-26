using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record NewRateVersion
{
    [JsonPropertyName("rate_id")]
    public required string RateId { get; init; }

    /// <summary>
    /// New versions of rates must indicate the exact version they modify. When the system attempts to save this new version, if the latest version in the system does not equal this previos_version, the request will be rejected with a EntityConflictError.
    /// </summary>
    [JsonPropertyName("previous_version")]
    public required int PreviousVersion { get; init; }

    [JsonPropertyName("entries")]
    public IEnumerable<RateEntry> Entries { get; init; } = new List<RateEntry>();
}
