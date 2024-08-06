using System.Text.Json.Serialization;
using Candid.Net.OrganizationServiceFacilities.V2;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

public record OrganizationServiceFacilityPage
{
    [JsonPropertyName("items")]
    public IEnumerable<OrganizationServiceFacility> Items { get; set; } =
        new List<OrganizationServiceFacility>();
}
