using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record ResourcePage
{
    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
