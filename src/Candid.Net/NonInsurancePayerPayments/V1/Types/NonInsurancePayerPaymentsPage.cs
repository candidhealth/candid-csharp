using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayerPayments.V1;

public record NonInsurancePayerPaymentsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<NonInsurancePayerPayment> Items { get; set; } =
        new List<NonInsurancePayerPayment>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
