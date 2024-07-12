namespace Candid.Net.OrganizationServiceFacilities.V2;

public record GetAllOrganizationServiceFacilitiesRequest
{
    /// <summary>
    /// Limit the number of results returned. Defaults to 100.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Filter to a name or a part of a name.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// The page token to continue paging through a previous request.
    /// </summary>
    public string? PageToken { get; init; }
}
