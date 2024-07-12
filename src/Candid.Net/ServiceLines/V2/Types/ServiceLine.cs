using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.EncounterProviders.V2;
using Candid.Net.Invoices.V2;
using Candid.Net.ServiceLines.V2;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record ServiceLine
{
    [JsonPropertyName("modifiers")]
    public IEnumerable<ProcedureModifier>? Modifiers { get; init; }

    [JsonPropertyName("charge_amount_cents")]
    public int? ChargeAmountCents { get; init; }

    [JsonPropertyName("allowed_amount_cents")]
    public int? AllowedAmountCents { get; init; }

    [JsonPropertyName("insurance_balance_cents")]
    public int? InsuranceBalanceCents { get; init; }

    [JsonPropertyName("patient_balance_cents")]
    public int? PatientBalanceCents { get; init; }

    [JsonPropertyName("paid_amount_cents")]
    public int? PaidAmountCents { get; init; }

    [JsonPropertyName("patient_responsibility_cents")]
    public int? PatientResponsibilityCents { get; init; }

    [JsonPropertyName("diagnosis_id_zero")]
    public Guid? DiagnosisIdZero { get; init; }

    [JsonPropertyName("diagnosis_id_one")]
    public Guid? DiagnosisIdOne { get; init; }

    [JsonPropertyName("diagnosis_id_two")]
    public Guid? DiagnosisIdTwo { get; init; }

    [JsonPropertyName("diagnosis_id_three")]
    public Guid? DiagnosisIdThree { get; init; }

    [JsonPropertyName("service_line_era_data")]
    public ServiceLineEraData? ServiceLineEraData { get; init; }

    [JsonPropertyName("service_line_manual_adjustments")]
    public IEnumerable<ServiceLineAdjustment>? ServiceLineManualAdjustments { get; init; }

    [JsonPropertyName("related_invoices")]
    public IEnumerable<Invoice>? RelatedInvoices { get; init; }

    [JsonPropertyName("related_invoice_info")]
    public IEnumerable<InvoiceInfo>? RelatedInvoiceInfo { get; init; }

    [JsonPropertyName("denial_reason")]
    public ServiceLineDenialReason? DenialReason { get; init; }

    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; init; }

    [JsonPropertyName("place_of_service_code_as_submitted")]
    public FacilityTypeCode? PlaceOfServiceCodeAsSubmitted { get; init; }

    [JsonPropertyName("service_line_id")]
    public required Guid ServiceLineId { get; init; }

    [JsonPropertyName("procedure_code")]
    public required string ProcedureCode { get; init; }

    [JsonPropertyName("referring_provider")]
    public EncounterProvider? ReferringProvider { get; init; }

    [JsonPropertyName("initial_referring_provider")]
    public EncounterProvider? InitialReferringProvider { get; init; }

    [JsonPropertyName("supervising_provider")]
    public EncounterProvider? SupervisingProvider { get; init; }

    [JsonPropertyName("ordering_provider")]
    public EncounterProvider? OrderingProvider { get; init; }

    /// <summary>
    /// String representation of a Decimal that can be parsed by most libraries.
    /// A ServiceLine quantity cannot contain more than one digit of precision.
    /// Example: 1.1 is valid, 1.11 is not.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required string Quantity { get; init; }

    [JsonPropertyName("units")]
    public required ServiceLineUnits Units { get; init; }

    [JsonPropertyName("claim_id")]
    public required Guid ClaimId { get; init; }

    /// <summary>
    /// A range of dates of service for this service line. If the service line is for a single date, the end date
    /// will be empty.
    /// </summary>
    [JsonPropertyName("date_of_service_range")]
    public required DateRangeOptionalEnd DateOfServiceRange { get; init; }

    /// <summary>
    /// A free-form description to clarify the related data elements and their content. Maps to SV1-01, C003-07 on the 837-P.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; init; }

    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; init; }
}
