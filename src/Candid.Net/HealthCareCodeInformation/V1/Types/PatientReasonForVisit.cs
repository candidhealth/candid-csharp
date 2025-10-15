using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

/// <summary>
/// This corresponds to PR or APR code qualifier values.
/// </summary>
[Serializable]
public record PatientReasonForVisit : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("patient_reason_for_visit_code_qualifier")]
    public required PatientReasonForVisitCodeQualifier PatientReasonForVisitCodeQualifier { get; set; }

    [JsonPropertyName("patient_reason_for_visit")]
    public required string PatientReasonForVisit_ { get; set; }

    /// <summary>
    /// The id of this health care code information if it is already stored.
    /// If this is not set, this is referring to a new health care code information to be added
    /// to the encounter.  If it is set, this refers to an update of an existing health care code
    /// information object on the encounter.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The encounter_id of this health care code information if it is already stored.
    /// This will be set by the server in responses, but clients are not expected to set it.
    /// </summary>
    [JsonPropertyName("encounter_id")]
    public string? EncounterId { get; set; }

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
