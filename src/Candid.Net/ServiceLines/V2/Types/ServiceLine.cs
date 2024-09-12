using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.EncounterProviders.V2;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record ServiceLine
{
    [JsonPropertyName("modifiers")]
    public IEnumerable<ProcedureModifier>? Modifiers { get; set; }

    [JsonPropertyName("charge_amount_cents")]
    public int? ChargeAmountCents { get; set; }

    [JsonPropertyName("allowed_amount_cents")]
    public int? AllowedAmountCents { get; set; }

    [JsonPropertyName("insurance_balance_cents")]
    public int? InsuranceBalanceCents { get; set; }

    [JsonPropertyName("patient_balance_cents")]
    public int? PatientBalanceCents { get; set; }

    [JsonPropertyName("paid_amount_cents")]
    public int? PaidAmountCents { get; set; }

    [JsonPropertyName("primary_paid_amount_cents")]
    public int? PrimaryPaidAmountCents { get; set; }

    [JsonPropertyName("secondary_paid_amount_cents")]
    public int? SecondaryPaidAmountCents { get; set; }

    [JsonPropertyName("tertiary_paid_amount_cents")]
    public int? TertiaryPaidAmountCents { get; set; }

    [JsonPropertyName("patient_responsibility_cents")]
    public int? PatientResponsibilityCents { get; set; }

    [JsonPropertyName("diagnosis_id_zero")]
    public string? DiagnosisIdZero { get; set; }

    [JsonPropertyName("diagnosis_id_one")]
    public string? DiagnosisIdOne { get; set; }

    [JsonPropertyName("diagnosis_id_two")]
    public string? DiagnosisIdTwo { get; set; }

    [JsonPropertyName("diagnosis_id_three")]
    public string? DiagnosisIdThree { get; set; }

    [JsonPropertyName("drug_identification")]
    public DrugIdentification? DrugIdentification { get; set; }

    [JsonPropertyName("service_line_era_data")]
    public ServiceLineEraData? ServiceLineEraData { get; set; }

    [JsonPropertyName("service_line_manual_adjustments")]
    public IEnumerable<ServiceLineAdjustment>? ServiceLineManualAdjustments { get; set; }

    [JsonPropertyName("related_invoices")]
    public IEnumerable<Invoice>? RelatedInvoices { get; set; }

    [JsonPropertyName("related_invoice_info")]
    public IEnumerable<InvoiceInfo>? RelatedInvoiceInfo { get; set; }

    [JsonPropertyName("denial_reason")]
    public ServiceLineDenialReason? DenialReason { get; set; }

    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; set; }

    [JsonPropertyName("place_of_service_code_as_submitted")]
    public FacilityTypeCode? PlaceOfServiceCodeAsSubmitted { get; set; }

    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; set; }

    [JsonPropertyName("procedure_code")]
    public required string ProcedureCode { get; set; }

    [JsonPropertyName("referring_provider")]
    public EncounterProvider? ReferringProvider { get; set; }

    [JsonPropertyName("initial_referring_provider")]
    public EncounterProvider? InitialReferringProvider { get; set; }

    [JsonPropertyName("supervising_provider")]
    public EncounterProvider? SupervisingProvider { get; set; }

    [JsonPropertyName("ordering_provider")]
    public EncounterProvider? OrderingProvider { get; set; }

    /// <summary>
    /// String representation of a Decimal that can be parsed by most libraries.
    /// A ServiceLine quantity cannot contain more than one digit of precision.
    /// Example: 1.1 is valid, 1.11 is not.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required string Quantity { get; set; }

    [JsonPropertyName("units")]
    public required ServiceLineUnits Units { get; set; }

    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; set; }

    /// <summary>
    /// A range of dates of service for this service line. If the service line is for a single date, the end date
    /// will be empty.
    /// </summary>
    [JsonPropertyName("date_of_service_range")]
    public required DateRangeOptionalEnd DateOfServiceRange { get; set; }

    /// <summary>
    /// A free-form description to clarify the related data elements and their content. Maps to SV1-01, C003-07 on the 837-P.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; set; }

    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; set; }
}
