using System.Text.Json.Serialization;
using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.OrganizationProviders.V3;

public record OrganizationProviderUpdateV2
{
    /// <summary>
    /// The NPI of the provider. This must be all digits [0-9] and exactly 10 characters long.
    /// </summary>
    [JsonPropertyName("npi")]
    public string? Npi { get; init; }

    /// <summary>
    /// Whether the provider can be used to render services.
    /// </summary>
    [JsonPropertyName("is_rendering")]
    public bool? IsRendering { get; init; }

    /// <summary>
    /// Whether the provider can be used to bill services.
    /// </summary>
    [JsonPropertyName("is_billing")]
    public bool? IsBilling { get; init; }

    /// <summary>
    /// The first name of the provider, if the provider is an individual.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>
    /// The last name of the provider, if the provider is an individual.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    /// <summary>
    /// The name of the provider, if the provider is an organization.
    /// </summary>
    [JsonPropertyName("organization_name")]
    public string? OrganizationName { get; init; }

    /// <summary>
    /// Whether the provider is an individual (NPPES Type 1) or organization (NPPES Type 2) provider.
    /// </summary>
    [JsonPropertyName("provider_type")]
    public ProviderType? ProviderType { get; init; }

    /// <summary>
    /// If the provider has a contract with insurance, this must be the same tax ID given to the payer on an IRS W-9 form completed during contracting.
    /// </summary>
    [JsonPropertyName("tax_id")]
    public string? TaxId { get; init; }

    /// <summary>
    /// A code designating classification and specialization.
    /// </summary>
    [JsonPropertyName("taxonomy_code")]
    public string? TaxonomyCode { get; init; }

    /// <summary>
    /// The type of license that the provider holds.
    /// </summary>
    [JsonPropertyName("license_type")]
    public LicenseType? LicenseType { get; init; }

    /// <summary>
    /// The addresses associated with this provider.
    /// </summary>
    [JsonPropertyName("addresses")]
    public IEnumerable<OrganizationProviderAddress>? Addresses { get; init; }

    /// <summary>
    /// The employment start date for the provider.
    /// </summary>
    [JsonPropertyName("employment_start_date")]
    public string? EmploymentStartDate { get; init; }

    /// <summary>
    /// The employment termination date for the provider.
    /// </summary>
    [JsonPropertyName("employment_termination_date")]
    public string? EmploymentTerminationDate { get; init; }

    /// <summary>
    /// Provider's qualifications (medicare provider number, medicaid provider number, etc.)
    /// </summary>
    [JsonPropertyName("qualifications")]
    public IEnumerable<object>? Qualifications { get; init; }
}
