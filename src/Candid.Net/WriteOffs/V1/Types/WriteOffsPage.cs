using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record WriteOffsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<object> Items { get; set; } = new List<object>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
