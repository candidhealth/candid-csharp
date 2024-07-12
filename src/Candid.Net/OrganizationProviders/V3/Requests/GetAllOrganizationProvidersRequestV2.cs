using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.OrganizationProviders.V3;

public record GetAllOrganizationProvidersRequestV2
{
    /// <summary>
    /// Limit the number of results returned. Defaults to 100.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Filter to a name or a part of a name.
    /// </summary>
    public string? SearchTerm { get; init; }

    /// <summary>
    /// Filter to a specific NPI.
    /// </summary>
    public string? Npi { get; init; }

    /// <summary>
    /// Filter to only rendering providers.
    /// </summary>
    public bool? IsRendering { get; init; }

    /// <summary>
    /// Filter to only billing providers.
    /// </summary>
    public bool? IsBilling { get; init; }

    /// <summary>
    /// The page token to continue paging through a previous request.
    /// </summary>
    public string? PageToken { get; init; }

    /// <summary>
    /// Defaults to PROVIDER_NAME_ASC.
    /// </summary>
    public OrganizationProviderSortOptions? Sort { get; init; }
}
