using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record CoveragesPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Coverage> Items { get; set; } = new List<Coverage>();

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
