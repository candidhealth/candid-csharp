using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[Serializable]
public record HealthCareCodeInformationUpdate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Set & Replace semantics.  If the id matches the existing principal_diagnosis, that diagnosis is updated in place.  If the entry has no id, it is created newly, its id will be in the response, and any existing principal_diagnosis is deleted and removed from any service line pointers.
    /// </summary>
    [JsonPropertyName("principal_diagnosis")]
    public SetOrClearPrincipalDiagnosis? PrincipalDiagnosis { get; set; }

    /// <summary>
    /// Set & Replace semantics.  For each entry that has an id, any previous other_diagnosis_information by that id is updated in place.  For each entry without an id, it is created newly and its id will be in the response.  For each existing entry that was not referred to by id, it is deleted, including having it removed from any service line pointers.
    /// </summary>
    [JsonPropertyName("other_diagnosis_information")]
    public IEnumerable<OtherDiagnosisInformation>? OtherDiagnosisInformation { get; set; }

    /// <summary>
    /// Set & Replace semantics.  If the id matches the existing admitting_diagnosis, that diagnosis is updated in place.  If the entry has no id, it is created newly, its id will be in the response, and any existing principal_diagnosis is deleted. This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("admitting_diagnosis")]
    public SetOrClearAdmittingDiagnosis? AdmittingDiagnosis { get; set; }

    /// <summary>
    /// Set & Replace semantics.  For each entry that has an id, any previous patient_reasons_for_visit by that id is updated in place.  For each entry without an id, it is created newly and its id will be in the response.  For each existing entry that was not referred to by id, it is deleted. This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("patient_reasons_for_visit")]
    public IEnumerable<PatientReasonForVisit>? PatientReasonsForVisit { get; set; }

    /// <summary>
    /// Set & Replace semantics.  For each entry that has an id, any previous external_causes_of_injury by that id is updated in place.  For each entry without an id, it is created newly and its id will be in the response.  For each existing entry that was not referred to by id, it is deleted. This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("external_causes_of_injury")]
    public IEnumerable<ExternalCauseOfInjury>? ExternalCausesOfInjury { get; set; }

    /// <summary>
    /// Set & Replace semantics.  If the id matches the existing diagnosis_related_groups, that diagnosis_related_group is updated in place.  If the entry has no id, it is created newly, its id will be in the response, and any existing diagnosis_related_groups is deleted. This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("diagnosis_related_groups")]
    public SetOrClearDiagnosisRelatedGroup? DiagnosisRelatedGroups { get; set; }

    /// <summary>
    /// Set & Replace semantics.  If the id matches the existing principal_procedure, that principal_procedure is updated in place.  If the entry has no id, it is created newly, its id will be in the response, and any existing principal_procedure is deleted. This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("principal_procedure")]
    public SetOrClearPrincipalProcedureInformation? PrincipalProcedure { get; set; }

    /// <summary>
    /// Set & Replace semantics.  For each entry that has an id, any previous other_procedure_information by that id is updated in place.  For each entry without an id, it is created newly and its id will be in the response.  For each existing entry that was not referred to by id, it is deleted. This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("other_procedure_information")]
    public IEnumerable<OtherProcedureInformation>? OtherProcedureInformation { get; set; }

    /// <summary>
    /// Set & Replace semantics.  For each entry that has an id, any previous occurrence_span_information by that id is updated in place.  For each entry without an id, it is created newly and its id will be in the response.  For each existing entry that was not referred to by id, it is deleted. This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("occurrence_span_information")]
    public IEnumerable<OccurrenceSpanInformation>? OccurrenceSpanInformation { get; set; }

    /// <summary>
    /// Set & Replace semantics.  For each entry that has an id, any previous occurrence_information by that id is updated in place.  For each entry without an id, it is created newly and its id will be in the response.  For each existing entry that was not referred to by id, it is deleted. This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("occurrence_information")]
    public IEnumerable<OccurrenceInformation>? OccurrenceInformation { get; set; }

    /// <summary>
    /// Set & Replace semantics.  For each entry that has an id, any previous treatment_code_information by that id is updated in place.  For each entry without an id, it is created newly and its id will be in the response.  For each existing entry that was not referred to by id, it is deleted. This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("treatment_code_information")]
    public IEnumerable<TreatmentCodeInformation>? TreatmentCodeInformation { get; set; }

    /// <summary>
    /// Set & Replace semantics.  For each entry that has an id, any previous value_information by that id is updated in place.  For each entry without an id, it is created newly and its id will be in the response.  For each existing entry that was not referred to by id, it is deleted. This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("value_information")]
    public IEnumerable<ValueInformation>? ValueInformation { get; set; }

    /// <summary>
    /// Set & Replace semantics.  For each entry that has an id, any previous condition_information by that id is updated in place.  For each entry without an id, it is created newly and its id will be in the response.  For each existing entry that was not referred to by id, it is deleted. This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("condition_information")]
    public IEnumerable<ConditionInformation>? ConditionInformation { get; set; }

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
