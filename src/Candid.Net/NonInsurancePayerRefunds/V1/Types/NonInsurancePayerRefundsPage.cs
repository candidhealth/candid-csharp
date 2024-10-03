using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayerRefunds.V1;

public record NonInsurancePayerRefundsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<NonInsurancePayerRefund> Items { get; set; } =
        new List<NonInsurancePayerRefund>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
