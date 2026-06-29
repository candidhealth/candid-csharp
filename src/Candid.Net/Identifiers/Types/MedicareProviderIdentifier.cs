using global::Candid.Net;
using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Identifiers;

[Serializable]
public record MedicareProviderIdentifier : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("state")]
    public required State State { get; set; }

    [JsonPropertyName("provider_number")]
    public required string ProviderNumber { get; set; }

    /// <summary>
    /// When set, this identifier applies only to the given service facility.
    /// </summary>
    [JsonPropertyName("organization_service_facility_id")]
    public string? OrganizationServiceFacilityId { get; set; }

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
