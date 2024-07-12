using System.Text.Json.Serialization;
using Candid.Net.InsuranceRefunds.V1;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

public record InsuranceRefundsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<InsuranceRefund> Items { get; init; } = new List<InsuranceRefund>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; init; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }
}
