using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

public record InsuranceRefundsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<InsuranceRefund> Items { get; set; } = new List<InsuranceRefund>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
