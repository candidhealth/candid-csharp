using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.EncounterProviders.V2;

public record BillingProviderUpdate
{
    [JsonPropertyName("address")]
    public StreetAddressLongZip? Address { get; set; }

    /// <summary>
    /// If the provider has a contract with insurance, this must be the same tax ID given to the payer on an IRS W-9 form completed during contracting.
    /// </summary>
    [JsonPropertyName("tax_id")]
    public string? TaxId { get; set; }

    [JsonPropertyName("npi")]
    public string? Npi { get; set; }

    [JsonPropertyName("taxonomy_code")]
    public string? TaxonomyCode { get; set; }

    /// <summary>
    /// 837i Loop2010BB G2
    /// Provider Commercial Number
    /// </summary>
    [JsonPropertyName("provider_commercial_license_type")]
    public BillingProviderCommercialLicenseType? ProviderCommercialLicenseType { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
