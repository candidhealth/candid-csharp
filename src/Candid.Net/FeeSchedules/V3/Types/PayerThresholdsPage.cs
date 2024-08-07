using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record PayerThresholdsPage
{
    [JsonPropertyName("payer_thresholds")]
    public Dictionary<string, PayerThreshold> PayerThresholds { get; set; } =
        new Dictionary<string, PayerThreshold>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
