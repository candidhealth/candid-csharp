using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

/// <summary>
/// Structured filter for searching encounter summaries. Each field accepts an operator-tagged
/// filter object. Omit a field to not filter on it. All specified filters are combined with AND.
/// </summary>
[Serializable]
public record EncounterFilter : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("organization_ids")]
    public UuidSetFilter? OrganizationIds { get; set; }

    [JsonPropertyName("search_term")]
    public string? SearchTerm { get; set; }

    [JsonPropertyName("primary_payer_name")]
    public StringFilter? PrimaryPayerName { get; set; }

    [JsonPropertyName("primary_payer_plan_name")]
    public StringFilter? PrimaryPayerPlanName { get; set; }

    [JsonPropertyName("primary_payer_id")]
    public StringFilter? PrimaryPayerId { get; set; }

    [JsonPropertyName("primary_member_id")]
    public StringFilter? PrimaryMemberId { get; set; }

    [JsonPropertyName("primary_group_number")]
    public StringFilter? PrimaryGroupNumber { get; set; }

    [JsonPropertyName("primary_plan_type")]
    public SetFilter? PrimaryPlanType { get; set; }

    [JsonPropertyName("primary_payer_plan_group_id")]
    public UuidSetFilter? PrimaryPayerPlanGroupId { get; set; }

    /// <summary>
    /// Filter by the name of the payer group (umbrella payer) associated with the primary insurance.
    /// </summary>
    [JsonPropertyName("primary_payer_group_name")]
    public StringFilter? PrimaryPayerGroupName { get; set; }

    [JsonPropertyName("secondary_payer_name")]
    public StringFilter? SecondaryPayerName { get; set; }

    [JsonPropertyName("secondary_payer_plan_name")]
    public StringFilter? SecondaryPayerPlanName { get; set; }

    [JsonPropertyName("secondary_payer_id")]
    public StringFilter? SecondaryPayerId { get; set; }

    [JsonPropertyName("secondary_member_id")]
    public StringFilter? SecondaryMemberId { get; set; }

    [JsonPropertyName("secondary_group_number")]
    public StringFilter? SecondaryGroupNumber { get; set; }

    [JsonPropertyName("secondary_plan_type")]
    public SetFilter? SecondaryPlanType { get; set; }

    [JsonPropertyName("secondary_payer_plan_group_id")]
    public UuidSetFilter? SecondaryPayerPlanGroupId { get; set; }

    /// <summary>
    /// Filter by the name of the payer group (umbrella payer) associated with the secondary insurance.
    /// </summary>
    [JsonPropertyName("secondary_payer_group_name")]
    public StringFilter? SecondaryPayerGroupName { get; set; }

    [JsonPropertyName("service_facility_name")]
    public StringFilter? ServiceFacilityName { get; set; }

    [JsonPropertyName("service_facility_state")]
    public SetFilter? ServiceFacilityState { get; set; }

    [JsonPropertyName("procedure_codes")]
    public RangeableStringFilter? ProcedureCodes { get; set; }

    [JsonPropertyName("procedure_code_range")]
    public StringRangeFilter? ProcedureCodeRange { get; set; }

    [JsonPropertyName("revenue_codes")]
    public SetFilter? RevenueCodes { get; set; }

    [JsonPropertyName("carcs")]
    public PrefixableSetFilter? Carcs { get; set; }

    [JsonPropertyName("rarcs")]
    public PrefixableSetFilter? Rarcs { get; set; }

    [JsonPropertyName("denial_reasons")]
    public SetFilter? DenialReasons { get; set; }

    [JsonPropertyName("rejection_reasons")]
    public SetFilter? RejectionReasons { get; set; }

    [JsonPropertyName("procedure_modifiers")]
    public SetFilter? ProcedureModifiers { get; set; }

    [JsonPropertyName("billing_provider_npi")]
    public StringFilter? BillingProviderNpi { get; set; }

    [JsonPropertyName("billing_provider_tin")]
    public StringFilter? BillingProviderTin { get; set; }

    [JsonPropertyName("rendering_provider_npi")]
    public StringFilter? RenderingProviderNpi { get; set; }

    [JsonPropertyName("rendering_provider_name")]
    public StringFilter? RenderingProviderName { get; set; }

    [JsonPropertyName("attending_provider_npi")]
    public StringFilter? AttendingProviderNpi { get; set; }

    [JsonPropertyName("attending_provider_name")]
    public StringFilter? AttendingProviderName { get; set; }

    [JsonPropertyName("claim_status")]
    public SetFilter? ClaimStatus { get; set; }

    [JsonPropertyName("external_id")]
    public StringFilter? ExternalId { get; set; }

    [JsonPropertyName("claim_id")]
    public UuidSetFilter? ClaimId { get; set; }

    [JsonPropertyName("patient_external_id")]
    public StringFilter? PatientExternalId { get; set; }

    [JsonPropertyName("patient_state")]
    public SetFilter? PatientState { get; set; }

    [JsonPropertyName("billable_status")]
    public SetFilter? BillableStatus { get; set; }

    [JsonPropertyName("responsible_party")]
    public SetFilter? ResponsibleParty { get; set; }

    [JsonPropertyName("next_responsible_party")]
    public SetFilter? NextResponsibleParty { get; set; }

    [JsonPropertyName("owner_of_next_action")]
    public SetFilter? OwnerOfNextAction { get; set; }

    [JsonPropertyName("submission_expectation")]
    public SetFilter? SubmissionExpectation { get; set; }

    [JsonPropertyName("work_queue_id")]
    public SetFilter? WorkQueueId { get; set; }

    [JsonPropertyName("days_in_queue")]
    public IntRangeFilter? DaysInQueue { get; set; }

    [JsonPropertyName("tag_ids")]
    public SetFilter? TagIds { get; set; }

    [JsonPropertyName("static_view_id")]
    public string? StaticViewId { get; set; }

    [JsonPropertyName("task_type")]
    public SetFilter? TaskType { get; set; }

    [JsonPropertyName("task_category")]
    public SetFilter? TaskCategory { get; set; }

    [JsonPropertyName("task_assignee")]
    public UuidSetFilter? TaskAssignee { get; set; }

    [JsonPropertyName("task_description")]
    public StringFilter? TaskDescription { get; set; }

    [JsonPropertyName("date_of_service")]
    public DateRangeFilter? DateOfService { get; set; }

    [JsonPropertyName("timely_filing_deadline")]
    public DateRangeFilter? TimelyFilingDeadline { get; set; }

    [JsonPropertyName("claim_updated_at")]
    public DatetimeRangeFilter? ClaimUpdatedAt { get; set; }

    [JsonPropertyName("sum_charge_amount_cents")]
    public IntRangeFilter? SumChargeAmountCents { get; set; }

    [JsonPropertyName("sum_allowed_amount_cents")]
    public IntRangeFilter? SumAllowedAmountCents { get; set; }

    [JsonPropertyName("sum_paid_amount_cents")]
    public IntRangeFilter? SumPaidAmountCents { get; set; }

    [JsonPropertyName("sum_patient_responsibility_cents")]
    public IntRangeFilter? SumPatientResponsibilityCents { get; set; }

    [JsonPropertyName("claim_balance")]
    public IntRangeFilter? ClaimBalance { get; set; }

    [JsonPropertyName("diagnosis_codes")]
    public StringFilter? DiagnosisCodes { get; set; }

    [JsonPropertyName("has_secondary_insurance")]
    public BooleanFilter? HasSecondaryInsurance { get; set; }

    [JsonPropertyName("has_unassigned_tasks")]
    public BooleanFilter? HasUnassignedTasks { get; set; }

    [JsonPropertyName("is_snoozed")]
    public BooleanFilter? IsSnoozed { get; set; }

    [JsonPropertyName("has_been_submitted")]
    public BooleanFilter? HasBeenSubmitted { get; set; }

    [JsonPropertyName("in_work_queue")]
    public BooleanFilter? InWorkQueue { get; set; }

    [JsonPropertyName("non_insurance_payer_category")]
    public StringFilter? NonInsurancePayerCategory { get; set; }

    [JsonPropertyName("non_insurance_payer_name")]
    public StringFilter? NonInsurancePayerName { get; set; }

    [JsonPropertyName("type_of_bill")]
    public SetFilter? TypeOfBill { get; set; }

    [JsonPropertyName("place_of_service_code")]
    public SetFilter? PlaceOfServiceCode { get; set; }

    [JsonPropertyName("service_line_place_of_service_code")]
    public SetFilter? ServiceLinePlaceOfServiceCode { get; set; }

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
