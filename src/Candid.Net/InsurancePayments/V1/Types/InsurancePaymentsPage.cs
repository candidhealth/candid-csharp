using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public record InsurancePaymentsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<InsurancePayment> Items { get; set; } = new List<InsurancePayment>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
