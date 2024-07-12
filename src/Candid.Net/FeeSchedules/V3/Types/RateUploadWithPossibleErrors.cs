using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record RateUploadWithPossibleErrors
{
    [JsonPropertyName("rate_upload")]
    public required object RateUpload { get; init; }

    [JsonPropertyName("existing_rate")]
    public Rate? ExistingRate { get; init; }

    [JsonPropertyName("possible_errors")]
    public IEnumerable<object> PossibleErrors { get; init; } = new List<object>();
}
