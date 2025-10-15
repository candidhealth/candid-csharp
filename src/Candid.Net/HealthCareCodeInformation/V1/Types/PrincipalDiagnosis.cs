using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

/// <summary>
/// This corresponds to BK or ABK code qualifier values.
/// </summary>
[Serializable]
public record PrincipalDiagnosis : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("principal_diagnosis_code_qualifier")]
    public required PrincipalDiagnosisCodeQualifier PrincipalDiagnosisCodeQualifier { get; set; }

    [JsonPropertyName("primary_diagnosis_code")]
    public required string PrimaryDiagnosisCode { get; set; }

    [JsonPropertyName("present_on_admission_indicator")]
    public PresentOnAdmissionIndicatorCode? PresentOnAdmissionIndicator { get; set; }

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
