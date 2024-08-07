using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.EncounterProviders.V2;

public record RenderingProvider
{
    [JsonPropertyName("address")]
    public StreetAddressLongZip? Address { get; set; }

    /// <summary>
    /// A National Provider Identifier is a unique 10-digit identification
    /// number issued to health care providers in the United States
    /// </summary>
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
