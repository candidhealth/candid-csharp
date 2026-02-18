using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PropertyAndCasualty.V1;

[Serializable]
public record PropertyCasualtyPatientIdentifier : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Represents REF01 on the EDI 837 Loop 2010CA Property and Casualty Patient Identifier segment.
    /// Valid values include 1W (Member Identification Number) and SY (Social Security Number).
    /// </summary>
    [JsonPropertyName("property_casualty_patient_identifier_qualifier")]
    public required PropertyCasualtyPatientIdentifierQualifier PropertyCasualtyPatientIdentifierQualifier { get; set; }

    /// <summary>
    /// Represents REF02 on the EDI 837 Loop 2010CA Property and Casualty Patient Identifier segment. Value cannot exceed 50 characters
    /// </summary>
    [JsonPropertyName("property_casualty_patient_identifier")]
    public required string PropertyCasualtyPatientIdentifier_ { get; set; }

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
