using System.Text.Json.Serialization;
using Candid.Net.Tasks.V3;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Task> Items { get; init; } = new List<Task>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; init; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }
}
