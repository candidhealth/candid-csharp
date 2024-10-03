using System.Text.Json.Serialization;
using Candid.Net.Core;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
