using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

public record HealthCareCodeInformationCreate
{
    [JsonPropertyName("principal_diagnosis")]
    public PrincipalDiagnosisNew? PrincipalDiagnosis { get; set; }

    [JsonPropertyName("admitting_diagnosis")]
    public AdmittingDiagnosisNew? AdmittingDiagnosis { get; set; }

    [JsonPropertyName("patient_reasons_for_visit")]
    public IEnumerable<PatientReasonForVisitNew>? PatientReasonsForVisit { get; set; }

    [JsonPropertyName("external_causes_of_injury")]
    public IEnumerable<ExternalCauseOfInjuryNew>? ExternalCausesOfInjury { get; set; }

    [JsonPropertyName("diagnosis_related_groups")]
    public DiagnosisRelatedGroupNew? DiagnosisRelatedGroups { get; set; }

    [JsonPropertyName("other_diagnosis_information")]
    public IEnumerable<OtherDiagnosisInformationNew>? OtherDiagnosisInformation { get; set; }

    [JsonPropertyName("principal_procedure")]
    public PrincipalProcedureInformationNew? PrincipalProcedure { get; set; }

    [JsonPropertyName("other_procedure_information")]
    public IEnumerable<OtherProcedureInformationNew>? OtherProcedureInformation { get; set; }

    [JsonPropertyName("occurrence_span_information")]
    public IEnumerable<OccurrenceSpanInformationNew>? OccurrenceSpanInformation { get; set; }

    [JsonPropertyName("occurrence_information")]
    public IEnumerable<OccurrenceInformationNew>? OccurrenceInformation { get; set; }

    [JsonPropertyName("treatment_code_information")]
    public IEnumerable<TreatmentCodeInformationNew>? TreatmentCodeInformation { get; set; }

    [JsonPropertyName("value_information")]
    public IEnumerable<ValueInformationNew>? ValueInformation { get; set; }

    [JsonPropertyName("condition_information")]
    public IEnumerable<ConditionInformationNew>? ConditionInformation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
