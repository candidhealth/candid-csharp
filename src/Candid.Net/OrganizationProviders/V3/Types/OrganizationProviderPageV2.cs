using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.OrganizationProviders.V3;

public record OrganizationProviderPageV2
{
    [JsonPropertyName("items")]
    public IEnumerable<OrganizationProviderV2> Items { get; set; } =
        new List<OrganizationProviderV2>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
