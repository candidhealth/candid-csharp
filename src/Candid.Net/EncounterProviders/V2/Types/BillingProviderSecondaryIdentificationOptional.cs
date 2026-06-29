using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterProviders.V2;

[Serializable]
public record BillingProviderSecondaryIdentificationOptional : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Represents REF02 on the EDI 837 Loop 2010BB Billing Provider Secondary Identification segment. Value cannot exceed 50 characters
    /// </summary>
    [JsonPropertyName("reference_identification")]
    public string? ReferenceIdentification { get; set; }

    /// <summary>
    /// Represents REF01 on the EDI 837 Loop 2010BB Billing Provider Secondary Identification segment.
    /// Valid values include G2 (Provider Commercial Number) and LU (Location Number). Defaults to G2 if not set.
    /// </summary>
    [JsonPropertyName("reference_identification_qualifier")]
    public BillingProviderSecondaryIdentificationQualifier? ReferenceIdentificationQualifier { get; set; }

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
