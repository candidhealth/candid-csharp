using global::Candid.Net;
using global::Candid.Net.Claims;
using global::Candid.Net.ClinicalTrials.V1;
using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.Encounters.V4;
using global::Candid.Net.ServiceFacility;
using global::Candid.Net.ServiceLines.V2;
using global::Candid.Net.Tasks.Commons;
using global::Candid.Net.X12.V1;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

[Serializable]
public record EncounterSummary : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }

    [JsonPropertyName("patient_control_number")]
    public string? PatientControlNumber { get; set; }

    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; set; }

    [JsonPropertyName("claim_status")]
    public required ClaimStatus ClaimStatus { get; set; }

    [JsonPropertyName("billing_provider_npi")]
    public required string BillingProviderNpi { get; set; }

    [JsonPropertyName("billing_provider_name")]
    public required string BillingProviderName { get; set; }

    [JsonPropertyName("billing_provider_tin")]
    public string? BillingProviderTin { get; set; }

    [JsonPropertyName("rendering_provider_npi")]
    public required string RenderingProviderNpi { get; set; }

    [JsonPropertyName("rendering_provider_name")]
    public required string RenderingProviderName { get; set; }

    [JsonPropertyName("rendering_provider_tin")]
    public string? RenderingProviderTin { get; set; }

    [JsonPropertyName("optional_rendering_provider_npi")]
    public string? OptionalRenderingProviderNpi { get; set; }

    [JsonPropertyName("optional_rendering_provider_name")]
    public string? OptionalRenderingProviderName { get; set; }

    [JsonPropertyName("patient_first_name")]
    public required string PatientFirstName { get; set; }

    [JsonPropertyName("patient_last_name")]
    public required string PatientLastName { get; set; }

    [JsonPropertyName("patient_external_id")]
    public string? PatientExternalId { get; set; }

    [JsonPropertyName("patient_state")]
    public State? PatientState { get; set; }

    [JsonPropertyName("primary_payer_id")]
    public string? PrimaryPayerId { get; set; }

    [JsonPropertyName("primary_payer_name")]
    public string? PrimaryPayerName { get; set; }

    [JsonPropertyName("primary_payer_plan_group_name")]
    public string? PrimaryPayerPlanGroupName { get; set; }

    [JsonPropertyName("primary_payer_plan_name")]
    public string? PrimaryPayerPlanName { get; set; }

    [JsonPropertyName("primary_group_number")]
    public string? PrimaryGroupNumber { get; set; }

    [JsonPropertyName("secondary_payer_id")]
    public string? SecondaryPayerId { get; set; }

    [JsonPropertyName("secondary_payer_name")]
    public string? SecondaryPayerName { get; set; }

    [JsonPropertyName("secondary_payer_plan_group_name")]
    public string? SecondaryPayerPlanGroupName { get; set; }

    [JsonPropertyName("secondary_payer_plan_name")]
    public string? SecondaryPayerPlanName { get; set; }

    [JsonPropertyName("secondary_group_number")]
    public string? SecondaryGroupNumber { get; set; }

    [JsonPropertyName("primary_member_id")]
    public string? PrimaryMemberId { get; set; }

    [JsonPropertyName("sum_allowed_amount_cents")]
    public required int SumAllowedAmountCents { get; set; }

    [JsonPropertyName("sum_charge_amount_cents")]
    public required int SumChargeAmountCents { get; set; }

    [JsonPropertyName("sum_paid_amount_cents")]
    public required int SumPaidAmountCents { get; set; }

    [JsonPropertyName("primary_plan_type")]
    public SourceOfPaymentCode? PrimaryPlanType { get; set; }

    [JsonPropertyName("secondary_plan_type")]
    public SourceOfPaymentCode? SecondaryPlanType { get; set; }

    [JsonPropertyName("primary_insurance_paid_cents")]
    public int? PrimaryInsurancePaidCents { get; set; }

    [JsonPropertyName("secondary_insurance_paid_cents")]
    public int? SecondaryInsurancePaidCents { get; set; }

    [JsonPropertyName("tertiary_insurance_paid_cents")]
    public int? TertiaryInsurancePaidCents { get; set; }

    [JsonPropertyName("sum_patient_responsibility_cents")]
    public required int SumPatientResponsibilityCents { get; set; }

    [JsonPropertyName("sum_insurance_balance_amount_cents")]
    public int? SumInsuranceBalanceAmountCents { get; set; }

    [JsonPropertyName("sum_insurance_adjustment_amount_cents")]
    public int? SumInsuranceAdjustmentAmountCents { get; set; }

    [JsonPropertyName("sum_patient_paid_amount_cents")]
    public int? SumPatientPaidAmountCents { get; set; }

    [JsonPropertyName("sum_patient_balance_amount_cents")]
    public int? SumPatientBalanceAmountCents { get; set; }

    [JsonPropertyName("sum_total_balance_amount_cents")]
    public int? SumTotalBalanceAmountCents { get; set; }

    [JsonPropertyName("sum_patient_write_off_amount_cents")]
    public int? SumPatientWriteOffAmountCents { get; set; }

    [JsonPropertyName("sum_non_insurance_paid_cents")]
    public int? SumNonInsurancePaidCents { get; set; }

    [JsonPropertyName("claim_balance_amount_cents")]
    public int? ClaimBalanceAmountCents { get; set; }

    [JsonPropertyName("procedure_codes")]
    public HashSet<string> ProcedureCodes { get; set; } = new HashSet<string>();

    [JsonPropertyName("procedure_modifiers")]
    public HashSet<ProcedureModifier> ProcedureModifiers { get; set; } =
        new HashSet<ProcedureModifier>();

    [JsonPropertyName("carcs")]
    public HashSet<string> Carcs { get; set; } = new HashSet<string>();

    [JsonPropertyName("rarcs")]
    public HashSet<string> Rarcs { get; set; } = new HashSet<string>();

    [JsonPropertyName("denial_reasons")]
    public IEnumerable<DenialReasonContent>? DenialReasons { get; set; }

    [JsonPropertyName("rejection_reason")]
    public RejectionReason? RejectionReason { get; set; }

    [JsonPropertyName("tag_ids")]
    public IEnumerable<string> TagIds { get; set; } = new List<string>();

    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; set; }

    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; set; }

    [JsonPropertyName("timely_filing_deadline")]
    public DateOnly? TimelyFilingDeadline { get; set; }

    [JsonPropertyName("service_facility")]
    public required EncounterServiceFacility ServiceFacility { get; set; }

    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; set; }

    [JsonPropertyName("service_line_place_of_service_codes")]
    public IEnumerable<FacilityTypeCode>? ServiceLinePlaceOfServiceCodes { get; set; }

    [JsonPropertyName("service_line_total_quantity")]
    public double? ServiceLineTotalQuantity { get; set; }

    [JsonPropertyName("diagnosis_codes")]
    public HashSet<string> DiagnosisCodes { get; set; } = new HashSet<string>();

    [JsonPropertyName("encounter_external_id")]
    public string? EncounterExternalId { get; set; }

    [JsonPropertyName("billable_status")]
    public required BillableStatusType BillableStatus { get; set; }

    [JsonPropertyName("responsible_party")]
    public required ResponsiblePartyType ResponsibleParty { get; set; }

    [JsonPropertyName("work_queue_id")]
    public string? WorkQueueId { get; set; }

    [JsonPropertyName("work_queue_name")]
    public string? WorkQueueName { get; set; }

    [JsonPropertyName("work_queue_membership_activated_at")]
    public DateTime? WorkQueueMembershipActivatedAt { get; set; }

    [JsonPropertyName("owner_of_next_action")]
    public required EncounterOwnerOfNextActionType OwnerOfNextAction { get; set; }

    [JsonPropertyName("has_active_job")]
    public required bool HasActiveJob { get; set; }

    [JsonPropertyName("task_category")]
    public TaskCategory? TaskCategory { get; set; }

    [JsonPropertyName("task_type")]
    public TaskType? TaskType { get; set; }

    [JsonPropertyName("active_snooze")]
    public EncounterWorkQueueSnooze? ActiveSnooze { get; set; }

    [JsonPropertyName("days_since_unsnoozed")]
    public int? DaysSinceUnsnoozed { get; set; }

    [JsonPropertyName("claim_updated_at")]
    public required DateTime ClaimUpdatedAt { get; set; }

    [JsonPropertyName("task_assignees")]
    public IEnumerable<string>? TaskAssignees { get; set; }

    [JsonPropertyName("task_assignees_by_name")]
    public IEnumerable<string>? TaskAssigneesByName { get; set; }

    [JsonPropertyName("task_description")]
    public string? TaskDescription { get; set; }

    [JsonPropertyName("next_responsible_party")]
    public NextResponsibleParty? NextResponsibleParty { get; set; }

    [JsonPropertyName("non_insurance_payer_categories")]
    public IEnumerable<string>? NonInsurancePayerCategories { get; set; }

    [JsonPropertyName("non_insurance_payer_names")]
    public IEnumerable<string>? NonInsurancePayerNames { get; set; }

    [JsonPropertyName("clinical_trial_phases")]
    public HashSet<ClinicalTrialPhase>? ClinicalTrialPhases { get; set; }

    [JsonPropertyName("submission_expectation")]
    public EncounterSubmissionExpectation? SubmissionExpectation { get; set; }

    [JsonPropertyName("type_of_bill")]
    public TypeOfBillComposite? TypeOfBill { get; set; }

    [JsonPropertyName("attending_provider_npi")]
    public string? AttendingProviderNpi { get; set; }

    [JsonPropertyName("attending_provider_name")]
    public string? AttendingProviderName { get; set; }

    [JsonPropertyName("revenue_codes")]
    public IEnumerable<string>? RevenueCodes { get; set; }

    [JsonPropertyName("organization_id")]
    public string? OrganizationId { get; set; }

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
