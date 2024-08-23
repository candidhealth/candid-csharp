using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter;

public record ResourcePage
{
    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }
}
