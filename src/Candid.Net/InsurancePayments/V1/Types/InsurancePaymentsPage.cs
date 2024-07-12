using System.Text.Json.Serialization;
using Candid.Net.InsurancePayments.V1;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public record InsurancePaymentsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<InsurancePayment> Items { get; init; } = new List<InsurancePayment>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; init; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }
}
