using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ThirdPartyPayerRefunds.V1;

public record ThirdPartyPayerRefundsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<ThirdPartyPayerRefund> Items { get; set; } =
        new List<ThirdPartyPayerRefund>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
