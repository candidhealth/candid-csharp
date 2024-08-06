using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.EncounterProviders.V2;

public record EncounterProvider
{
    [JsonPropertyName("provider_id")]
    public required string ProviderId { get; set; }

    [JsonPropertyName("address")]
    public required StreetAddressLongZip Address { get; set; }

    [JsonPropertyName("tax_id")]
    public string? TaxId { get; set; }

    [JsonPropertyName("npi")]
    public required string Npi { get; set; }

    [JsonPropertyName("taxonomy_code")]
    public string? TaxonomyCode { get; set; }

    [JsonPropertyName("qualifier")]
    public QualifierCode? Qualifier { get; set; }
}
