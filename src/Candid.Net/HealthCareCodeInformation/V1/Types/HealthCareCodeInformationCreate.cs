using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[Serializable]
public record HealthCareCodeInformationCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("principal_diagnosis")]
    public PrincipalDiagnosisNew? PrincipalDiagnosis { get; set; }

    [JsonPropertyName("other_diagnosis_information")]
    public IEnumerable<OtherDiagnosisInformationNew>? OtherDiagnosisInformation { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("admitting_diagnosis")]
    public AdmittingDiagnosisNew? AdmittingDiagnosis { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("patient_reasons_for_visit")]
    public IEnumerable<PatientReasonForVisitNew>? PatientReasonsForVisit { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("external_causes_of_injury")]
    public IEnumerable<ExternalCauseOfInjuryNew>? ExternalCausesOfInjury { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("diagnosis_related_groups")]
    public DiagnosisRelatedGroupNew? DiagnosisRelatedGroups { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("principal_procedure")]
    public PrincipalProcedureInformationNew? PrincipalProcedure { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("other_procedure_information")]
    public IEnumerable<OtherProcedureInformationNew>? OtherProcedureInformation { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("occurrence_span_information")]
    public IEnumerable<OccurrenceSpanInformationNew>? OccurrenceSpanInformation { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("occurrence_information")]
    public IEnumerable<OccurrenceInformationNew>? OccurrenceInformation { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("treatment_code_information")]
    public IEnumerable<TreatmentCodeInformationNew>? TreatmentCodeInformation { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("value_information")]
    public IEnumerable<ValueInformationNew>? ValueInformation { get; set; }

    /// <summary>
    /// This object only applies to 837i institutional claim forms.
    /// </summary>
    [JsonPropertyName("condition_information")]
    public IEnumerable<ConditionInformationNew>? ConditionInformation { get; set; }

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
