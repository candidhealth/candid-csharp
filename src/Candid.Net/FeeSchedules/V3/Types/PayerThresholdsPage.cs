using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record PayerThresholdsPage
{
    [JsonPropertyName("payer_thresholds")]
    public Dictionary<Guid, PayerThreshold> PayerThresholds { get; init; } =
        new Dictionary<Guid, PayerThreshold>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; init; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }
}
