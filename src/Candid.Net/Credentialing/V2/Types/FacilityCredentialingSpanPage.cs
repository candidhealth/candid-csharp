using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Credentialing.V2;

public record FacilityCredentialingSpanPage
{
    [JsonPropertyName("items")]
    public IEnumerable<FacilityCredentialingSpan> Items { get; set; } =
        new List<FacilityCredentialingSpan>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
