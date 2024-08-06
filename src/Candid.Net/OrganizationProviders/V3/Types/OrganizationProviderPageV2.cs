using System.Text.Json.Serialization;
using Candid.Net.OrganizationProviders.V3;

#nullable enable

namespace Candid.Net.OrganizationProviders.V3;

public record OrganizationProviderPageV2
{
    [JsonPropertyName("items")]
    public IEnumerable<OrganizationProviderV2> Items { get; set; } =
        new List<OrganizationProviderV2>();
}
