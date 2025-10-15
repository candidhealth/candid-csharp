using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V2;

namespace Candid.Net.OrganizationProviders.V3;

[Serializable]
public record GetAllOrganizationProvidersRequestV2
{
    /// <summary>
    /// Limit the number of results returned. Defaults to 100.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Filter to a name or a part of a name.
    /// </summary>
    [JsonIgnore]
    public string? SearchTerm { get; set; }

    /// <summary>
    /// Filter to a specific NPI.
    /// </summary>
    [JsonIgnore]
    public string? Npi { get; set; }

    /// <summary>
    /// Filter to only rendering providers.
    /// </summary>
    [JsonIgnore]
    public bool? IsRendering { get; set; }

    /// <summary>
    /// Filter to only billing providers.
    /// </summary>
    [JsonIgnore]
    public bool? IsBilling { get; set; }

    /// <summary>
    /// Filter to the provided organization provider IDs.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> OrganizationProviderIds { get; set; } = new List<string>();

    /// <summary>
    /// The page token to continue paging through a previous request.
    /// </summary>
    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Defaults to PROVIDER_NAME_ASC.
    /// </summary>
    [JsonIgnore]
    public OrganizationProviderSortOptions? Sort { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
