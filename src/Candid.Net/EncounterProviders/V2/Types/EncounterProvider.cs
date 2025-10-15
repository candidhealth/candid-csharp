using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.EncounterProviders.V2;

[Serializable]
public record EncounterProvider : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
