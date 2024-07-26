using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.EncounterProviders.V2;

public record EncounterProvider
{
    [JsonPropertyName("provider_id")]
    public required string ProviderId { get; init; }

    [JsonPropertyName("address")]
    public required StreetAddressLongZip Address { get; init; }

    [JsonPropertyName("tax_id")]
    public string? TaxId { get; init; }

    [JsonPropertyName("npi")]
    public required string Npi { get; init; }

    [JsonPropertyName("taxonomy_code")]
    public string? TaxonomyCode { get; init; }

    [JsonPropertyName("qualifier")]
    public QualifierCode? Qualifier { get; init; }

    /// <summary>
    /// If the provider is an individual, this should be set instead of organization name
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>
    /// If the provider is an individual, this should be set instead of organization name
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    /// <summary>
    /// If the provider is an organization, this should be set instead of first + last name
    /// </summary>
    [JsonPropertyName("organization_name")]
    public string? OrganizationName { get; init; }
}
