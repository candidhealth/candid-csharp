using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Tags.V1;

public record TagPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Tag> Items { get; set; } = new List<Tag>();

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
