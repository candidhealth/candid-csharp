using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.PreEncounter.Common;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.OrganizationExternalProviders.V1;

/// <summary>
/// An object representing an organization-level external provider.
/// </summary>
[Serializable]
public record MutableOrganizationExternalProvider : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required HumanName Name { get; set; }

    [JsonPropertyName("types")]
    public IEnumerable<OrganizationExternalProviderType> Types { get; set; } =
        new List<OrganizationExternalProviderType>();

    [JsonPropertyName("npi")]
    public string? Npi { get; set; }

    [JsonPropertyName("tax_id")]
    public string? TaxId { get; set; }

    [JsonPropertyName("taxonomy_code")]
    public string? TaxonomyCode { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("other_phone_numbers")]
    public IEnumerable<string>? OtherPhoneNumbers { get; set; }

    [JsonPropertyName("fax_number")]
    public string? FaxNumber { get; set; }

    [JsonPropertyName("other_fax_numbers")]
    public IEnumerable<string>? OtherFaxNumbers { get; set; }

    [JsonPropertyName("emails")]
    public IEnumerable<string>? Emails { get; set; }

    [JsonPropertyName("license_type")]
    public LicenseType? LicenseType { get; set; }

    [JsonPropertyName("addresses")]
    public IEnumerable<global::Candid.Net.PreEncounter.Common.Address>? Addresses { get; set; }

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
