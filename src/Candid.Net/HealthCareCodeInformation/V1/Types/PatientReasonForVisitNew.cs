using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.HealthCareCodeInformation.V1;

/// <summary>
/// This corresponds to PR or APR code qualifier values.
/// </summary>
[Serializable]
public record PatientReasonForVisitNew : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("patient_reason_for_visit_code_qualifier")]
    public required PatientReasonForVisitCodeQualifier PatientReasonForVisitCodeQualifier { get; set; }

    [JsonPropertyName("patient_reason_for_visit")]
    public required string PatientReasonForVisit { get; set; }

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
