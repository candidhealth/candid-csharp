using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.EncounterProviders.V2;

/// <summary>
/// The billing provider is the provider or business entity submitting the claim.
/// Billing provider may be, but is not necessarily, the same person/NPI as the rendering provider.
/// From a payer's perspective, this represents the person or entity being reimbursed.
/// When a contract exists with the target payer, the billing provider should be the entity contracted with the payer.
/// In some circumstances, this will be an individual provider. In that case, submit that provider's NPI and the
/// tax ID (TIN) that the provider gave to the payer during contracting.
/// In other cases, the billing entity will be a medical group. If so, submit the group NPI and the group's tax ID.
/// Box 33 on the CMS-1500 claim or Form Locator 1 on a UB-04 claim form.
/// </summary>
[Serializable]
public record BillingProvider : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("address")]
    public required StreetAddressLongZip Address { get; set; }

    /// <summary>
    /// If the provider has a contract with insurance, this must be the same tax ID given to the payer on an IRS W-9 form completed during contracting.
    /// </summary>
    [JsonPropertyName("tax_id")]
    public required string TaxId { get; set; }

    [JsonPropertyName("npi")]
    public required string Npi { get; set; }

    [JsonPropertyName("taxonomy_code")]
    public string? TaxonomyCode { get; set; }

    /// <summary>
    /// 837i Loop2010BB G2
    /// Provider Commercial Number
    /// </summary>
    [JsonPropertyName("provider_commercial_license_type")]
    public BillingProviderCommercialLicenseType? ProviderCommercialLicenseType { get; set; }

    /// <summary>
    /// Only one of provider_commercial_license_type or secondary_identification may be provided
    /// 837i Loop2010BB G2
    /// Secondary Identification
    /// </summary>
    [JsonPropertyName("secondary_identification")]
    public ProviderSecondaryIdentification? SecondaryIdentification { get; set; }

    /// <summary>
    /// If the provider is an individual, this should be set instead of organization name
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    /// <summary>
    /// If the provider is an individual, this should be set instead of organization name
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// If the provider is an organization, this should be set instead of first + last name
    /// </summary>
    [JsonPropertyName("organization_name")]
    public string? OrganizationName { get; set; }

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
