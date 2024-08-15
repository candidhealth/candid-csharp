using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ThirdPartyPayers.V1;

public record ThirdPartyPayerPage
{
    [JsonPropertyName("items")]
    public IEnumerable<ThirdPartyPayer> Items { get; set; } = new List<ThirdPartyPayer>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
