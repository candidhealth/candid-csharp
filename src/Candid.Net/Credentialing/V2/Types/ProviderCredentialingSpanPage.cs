using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Credentialing.V2;

public record ProviderCredentialingSpanPage
{
    [JsonPropertyName("items")]
    public IEnumerable<ProviderCredentialingSpan> Items { get; set; } =
        new List<ProviderCredentialingSpan>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
