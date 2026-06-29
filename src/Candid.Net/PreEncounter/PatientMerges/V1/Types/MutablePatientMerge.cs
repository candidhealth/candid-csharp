using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.PatientMerges.V1;

/// <summary>
/// An object representing a patient merge mapping.
/// </summary>
[Serializable]
public record MutablePatientMerge : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The MRN of the patient that was merged.
    /// </summary>
    [JsonPropertyName("alternative_patient_mrn")]
    public required string AlternativePatientMrn { get; set; }

    /// <summary>
    /// The MRN of the patient that is getting a patient merged into them.
    /// </summary>
    [JsonPropertyName("primary_patient_mrn")]
    public required string PrimaryPatientMrn { get; set; }

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
