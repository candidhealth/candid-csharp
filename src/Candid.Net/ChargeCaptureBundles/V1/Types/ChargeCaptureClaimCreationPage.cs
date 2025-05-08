using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

public record ChargeCaptureClaimCreationPage
{
    [JsonPropertyName("items")]
    public IEnumerable<ChargeCaptureClaimCreation> Items { get; set; } =
        new List<ChargeCaptureClaimCreation>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
