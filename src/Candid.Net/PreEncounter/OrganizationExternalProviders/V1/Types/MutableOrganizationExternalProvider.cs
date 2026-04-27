using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

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

    [JsonPropertyName("fax_number")]
    public string? FaxNumber { get; set; }

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
