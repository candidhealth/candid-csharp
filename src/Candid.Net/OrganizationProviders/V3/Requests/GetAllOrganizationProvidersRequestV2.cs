using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.OrganizationProviders.V3;

public record GetAllOrganizationProvidersRequestV2
{
    /// <summary>
    /// Limit the number of results returned. Defaults to 100.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// Filter to a name or a part of a name.
    /// </summary>
    public string? SearchTerm { get; set; }

    /// <summary>
    /// Filter to a specific NPI.
    /// </summary>
    public string? Npi { get; set; }

    /// <summary>
    /// Filter to only rendering providers.
    /// </summary>
    public bool? IsRendering { get; set; }

    /// <summary>
    /// Filter to only billing providers.
    /// </summary>
    public bool? IsBilling { get; set; }

    /// <summary>
    /// The page token to continue paging through a previous request.
    /// </summary>
    public string? PageToken { get; set; }

    /// <summary>
    /// Defaults to PROVIDER_NAME_ASC.
    /// </summary>
    public OrganizationProviderSortOptions? Sort { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
