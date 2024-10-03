using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

public record OrganizationServiceFacilityPage
{
    [JsonPropertyName("items")]
    public IEnumerable<OrganizationServiceFacility> Items { get; set; } =
        new List<OrganizationServiceFacility>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
