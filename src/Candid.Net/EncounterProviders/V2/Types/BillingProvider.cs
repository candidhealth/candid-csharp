using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.EncounterProviders.V2;

public record BillingProvider
{
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
}
