using System.Text.Json.Serialization;
using Candid.Net.OrganizationServiceFacilities.V2;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

public record OrganizationServiceFacilityPage
{
    [JsonPropertyName("items")]
    public IEnumerable<OrganizationServiceFacility> Items { get; init; } =
        new List<OrganizationServiceFacility>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; init; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }
}
