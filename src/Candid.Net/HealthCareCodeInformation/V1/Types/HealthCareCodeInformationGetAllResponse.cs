using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[Serializable]
public record HealthCareCodeInformationGetAllResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("principal_diagnosis")]
    public PrincipalDiagnosis? PrincipalDiagnosis { get; set; }

    [JsonPropertyName("other_diagnosis_information")]
    public IEnumerable<OtherDiagnosisInformation> OtherDiagnosisInformation { get; set; } =
        new List<OtherDiagnosisInformation>();

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("admitting_diagnosis")]
    public AdmittingDiagnosis? AdmittingDiagnosis { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("patient_reasons_for_visit")]
    public IEnumerable<PatientReasonForVisit> PatientReasonsForVisit { get; set; } =
        new List<PatientReasonForVisit>();

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("external_causes_of_injury")]
    public IEnumerable<ExternalCauseOfInjury> ExternalCausesOfInjury { get; set; } =
        new List<ExternalCauseOfInjury>();

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("diagnosis_related_groups")]
    public DiagnosisRelatedGroup? DiagnosisRelatedGroups { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("principal_procedure")]
    public PrincipalProcedureInformation? PrincipalProcedure { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("other_procedure_information")]
    public IEnumerable<OtherProcedureInformation> OtherProcedureInformation { get; set; } =
        new List<OtherProcedureInformation>();

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("occurrence_span_information")]
    public IEnumerable<OccurrenceSpanInformation> OccurrenceSpanInformation { get; set; } =
        new List<OccurrenceSpanInformation>();

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("occurrence_information")]
    public IEnumerable<OccurrenceInformation> OccurrenceInformation { get; set; } =
        new List<OccurrenceInformation>();

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("treatment_code_information")]
    public IEnumerable<TreatmentCodeInformation> TreatmentCodeInformation { get; set; } =
        new List<TreatmentCodeInformation>();

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("value_information")]
    public IEnumerable<ValueInformation> ValueInformation { get; set; } =
        new List<ValueInformation>();

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("condition_information")]
    public IEnumerable<ConditionInformation> ConditionInformation { get; set; } =
        new List<ConditionInformation>();

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
