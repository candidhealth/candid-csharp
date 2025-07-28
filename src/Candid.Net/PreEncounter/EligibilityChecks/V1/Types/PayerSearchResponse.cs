using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record PayerSearchResponse
{
    [JsonPropertyName("items")]
    public IEnumerable<StediPayerItem> Items { get; set; } = new List<StediPayerItem>();

    [JsonPropertyName("stats")]
    public required object Stats { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("total")]
    public required int Total { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
