using System.Text.Json.Serialization;
using Candid.Net.OrganizationProviders.V3;

#nullable enable

namespace Candid.Net.OrganizationProviders.V3;

public record OrganizationProviderPageV2
{
    [JsonPropertyName("items")]
    public IEnumerable<OrganizationProviderV2> Items { get; init; } =
        new List<OrganizationProviderV2>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; init; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }
}
