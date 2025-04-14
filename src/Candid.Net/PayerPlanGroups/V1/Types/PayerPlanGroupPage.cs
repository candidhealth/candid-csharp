using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PayerPlanGroups.V1;

public record PayerPlanGroupPage
{
    [JsonPropertyName("items")]
    public IEnumerable<PayerPlanGroup> Items { get; set; } = new List<PayerPlanGroup>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
