using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.Identifiers;
using Candid.Net.OrganizationProviders.V2;

namespace Candid.Net.OrganizationProviders.V3;

[Serializable]
public record OrganizationProviderCreateV2 : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The NPI of the provider. This must be all digits [0-9] and exactly 10 characters long.
    /// </summary>
    [JsonPropertyName("npi")]
    public required string Npi { get; set; }

    /// <summary>
    /// Whether the provider can be used to render services.
    /// </summary>
    [JsonPropertyName("is_rendering")]
    public required bool IsRendering { get; set; }

    /// <summary>
    /// Whether the provider can be used to bill services.
    /// </summary>
    [JsonPropertyName("is_billing")]
    public required bool IsBilling { get; set; }

    /// <summary>
    /// The first name of the provider, if the provider is an individual.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    /// <summary>
    /// The last name of the provider, if the provider is an individual.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// The name of the provider, if the provider is an organization.
    /// </summary>
    [JsonPropertyName("organization_name")]
    public string? OrganizationName { get; set; }

    /// <summary>
    /// Whether the provider is an individual (NPPES Type 1) or organization (NPPES Type 2) provider.
    /// </summary>
    [JsonPropertyName("provider_type")]
    public required ProviderType ProviderType { get; set; }

    /// <summary>
    /// If the provider has a contract with insurance, this must be the same tax ID given to the payer on an IRS W-9 form completed during contracting.
    /// </summary>
    [JsonPropertyName("tax_id")]
    public string? TaxId { get; set; }

    /// <summary>
    /// A code designating classification and specialization.
    /// </summary>
    [JsonPropertyName("taxonomy_code")]
    public string? TaxonomyCode { get; set; }

    /// <summary>
    /// The type of license that the provider holds.
    /// </summary>
    [JsonPropertyName("license_type")]
    public required LicenseType LicenseType { get; set; }

    /// <summary>
    /// The addresses associated with this provider.
    /// </summary>
    [JsonPropertyName("addresses")]
    public IEnumerable<OrganizationProviderAddress>? Addresses { get; set; }

    /// <summary>
    /// The employment start date for the provider.
    /// </summary>
    [JsonPropertyName("employment_start_date")]
    public DateOnly? EmploymentStartDate { get; set; }

    /// <summary>
    /// The employment termination date for the provider.
    /// </summary>
    [JsonPropertyName("employment_termination_date")]
    public DateOnly? EmploymentTerminationDate { get; set; }

    /// <summary>
    /// A provider's qualifications such as PTAN, Medicaid Provider Id, etc.
    /// </summary>
    [JsonPropertyName("qualifications")]
    public IEnumerable<IdentifierCreate> Qualifications { get; set; } =
        new List<IdentifierCreate>();

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
