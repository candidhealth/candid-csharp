using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture.V1;

public record ChargeCapturePage
{
    [JsonPropertyName("items")]
    public IEnumerable<ChargeCapture> Items { get; set; } = new List<ChargeCapture>();

    [JsonPropertyName("item_count")]
    public required int ItemCount { get; set; }

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
