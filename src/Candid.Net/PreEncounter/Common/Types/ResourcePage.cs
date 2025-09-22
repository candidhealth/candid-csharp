using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Common;

public record ResourcePage
{
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
