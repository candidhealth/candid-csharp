using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Task> Items { get; set; } = new List<Task>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
