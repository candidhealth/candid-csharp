using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

public record HealthCareCodeInformationGetAllResponse
{
    [JsonPropertyName("principal_diagnosis")]
    public PrincipalDiagnosis? PrincipalDiagnosis { get; set; }

    [JsonPropertyName("admitting_diagnosis")]
    public AdmittingDiagnosis? AdmittingDiagnosis { get; set; }

    [JsonPropertyName("patient_reasons_for_visit")]
    public IEnumerable<PatientReasonForVisit> PatientReasonsForVisit { get; set; } =
        new List<PatientReasonForVisit>();

    [JsonPropertyName("external_causes_of_injury")]
    public IEnumerable<ExternalCauseOfInjury> ExternalCausesOfInjury { get; set; } =
        new List<ExternalCauseOfInjury>();

    [JsonPropertyName("diagnosis_related_groups")]
    public DiagnosisRelatedGroup? DiagnosisRelatedGroups { get; set; }

    [JsonPropertyName("other_diagnosis_information")]
    public IEnumerable<OtherDiagnosisInformation> OtherDiagnosisInformation { get; set; } =
        new List<OtherDiagnosisInformation>();

    [JsonPropertyName("principal_procedure")]
    public PrincipalProcedureInformation? PrincipalProcedure { get; set; }

    [JsonPropertyName("other_procedure_information")]
    public IEnumerable<OtherProcedureInformation> OtherProcedureInformation { get; set; } =
        new List<OtherProcedureInformation>();

    [JsonPropertyName("occurrence_span_information")]
    public IEnumerable<OccurrenceSpanInformation> OccurrenceSpanInformation { get; set; } =
        new List<OccurrenceSpanInformation>();

    [JsonPropertyName("occurrence_information")]
    public IEnumerable<OccurrenceInformation> OccurrenceInformation { get; set; } =
        new List<OccurrenceInformation>();

    [JsonPropertyName("treatment_code_information")]
    public IEnumerable<TreatmentCodeInformation> TreatmentCodeInformation { get; set; } =
        new List<TreatmentCodeInformation>();

    [JsonPropertyName("value_information")]
    public IEnumerable<ValueInformation> ValueInformation { get; set; } =
        new List<ValueInformation>();

    [JsonPropertyName("condition_information")]
    public IEnumerable<ConditionInformation> ConditionInformation { get; set; } =
        new List<ConditionInformation>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
