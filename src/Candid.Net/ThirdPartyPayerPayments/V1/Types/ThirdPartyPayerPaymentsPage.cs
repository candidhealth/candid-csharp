using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ThirdPartyPayerPayments.V1;

public record ThirdPartyPayerPaymentsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<ThirdPartyPayerPayment> Items { get; set; } =
        new List<ThirdPartyPayerPayment>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
