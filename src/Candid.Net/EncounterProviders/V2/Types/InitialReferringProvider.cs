using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.EncounterProviders.V2;

public record InitialReferringProvider
{
    /// <summary>
    /// A National Provider Identifier is a unique 10-digit identification
    /// number issued to health care providers in the United States
    /// </summary>
    [JsonPropertyName("npi")]
    public required string Npi { get; set; }

    [JsonPropertyName("taxonomy_code")]
    public string? TaxonomyCode { get; set; }

    [JsonPropertyName("address")]
    public StreetAddressLongZip? Address { get; set; }

    [JsonPropertyName("qualifier")]
    public QualifierCode? Qualifier { get; set; }
}
