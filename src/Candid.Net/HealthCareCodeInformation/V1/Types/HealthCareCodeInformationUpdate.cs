using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

public record HealthCareCodeInformationUpdate
{
    [JsonPropertyName("principal_diagnosis")]
    public SetOrClearPrincipalDiagnosis? PrincipalDiagnosis { get; set; }

    [JsonPropertyName("admitting_diagnosis")]
    public SetOrClearAdmittingDiagnosis? AdmittingDiagnosis { get; set; }

    [JsonPropertyName("patient_reasons_for_visit")]
    public IEnumerable<PatientReasonForVisit>? PatientReasonsForVisit { get; set; }

    [JsonPropertyName("external_causes_of_injury")]
    public IEnumerable<ExternalCauseOfInjury>? ExternalCausesOfInjury { get; set; }

    [JsonPropertyName("diagnosis_related_groups")]
    public SetOrClearDiagnosisRelatedGroup? DiagnosisRelatedGroups { get; set; }

    [JsonPropertyName("other_diagnosis_information")]
    public IEnumerable<OtherDiagnosisInformation>? OtherDiagnosisInformation { get; set; }

    [JsonPropertyName("principal_procedure")]
    public SetOrClearPrincipalProcedureInformation? PrincipalProcedure { get; set; }

    [JsonPropertyName("other_procedure_information")]
    public IEnumerable<OtherProcedureInformation>? OtherProcedureInformation { get; set; }

    [JsonPropertyName("occurrence_span_information")]
    public IEnumerable<OccurrenceSpanInformation>? OccurrenceSpanInformation { get; set; }

    [JsonPropertyName("occurrence_information")]
    public IEnumerable<OccurrenceInformation>? OccurrenceInformation { get; set; }

    [JsonPropertyName("treatment_code_information")]
    public IEnumerable<TreatmentCodeInformation>? TreatmentCodeInformation { get; set; }

    [JsonPropertyName("value_information")]
    public IEnumerable<ValueInformation>? ValueInformation { get; set; }

    [JsonPropertyName("condition_information")]
    public IEnumerable<ConditionInformation>? ConditionInformation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
