using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

public record GetAllOrganizationServiceFacilitiesRequest
{
    /// <summary>
    /// Limit the number of results returned. Defaults to 100.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// Filter to a name or a part of a name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The page token to continue paging through a previous request.
    /// </summary>
    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
