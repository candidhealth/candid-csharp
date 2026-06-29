using global::Candid.Net;
using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterProviders.V2;

/// <summary>
/// Update type for the treating provider. All fields are optional.
/// </summary>
[Serializable]
public record TreatingProviderUpdate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// A National Provider Identifier is a unique 10-digit identification
    /// number issued to health care providers in the United States
    /// </summary>
    [JsonPropertyName("npi")]
    public string? Npi { get; set; }

    [JsonPropertyName("taxonomy_code")]
    public string? TaxonomyCode { get; set; }

    [JsonPropertyName("address")]
    public StreetAddressLongZip? Address { get; set; }

    /// <summary>
    /// The license type of the treating provider (e.g., MD, NP, PA, LCSW).
    /// </summary>
    [JsonPropertyName("license_type")]
    public global::Candid.Net.OrganizationProviders.V2.LicenseType? LicenseType { get; set; }

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
