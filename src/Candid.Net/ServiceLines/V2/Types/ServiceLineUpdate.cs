using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record ServiceLineUpdate
{
    [JsonPropertyName("edit_reason")]
    public string? EditReason { get; set; }

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

    [JsonPropertyName("service_line_manual_adjustments")]
    public IEnumerable<ServiceLineAdjustment>? ServiceLineManualAdjustments { get; set; }

    [JsonPropertyName("denial_reason")]
    public ServiceLineDenialReason? DenialReason { get; set; }

    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; set; }

    [JsonPropertyName("place_of_service_code_as_submitted")]
    public FacilityTypeCode? PlaceOfServiceCodeAsSubmitted { get; set; }

    [JsonPropertyName("units")]
    public ServiceLineUnits? Units { get; set; }

    [JsonPropertyName("procedure_code")]
    public string? ProcedureCode { get; set; }

    /// <summary>
    /// String representation of a Decimal that can be parsed by most libraries.
    /// A ServiceLine quantity cannot contain more than one digit of precision.
    /// Example: 1.1 is valid, 1.11 is not.
    /// </summary>
    [JsonPropertyName("quantity")]
    public string? Quantity { get; set; }

    /// <summary>
    /// A free-form description to clarify the related data elements and their content. Maps to SV1-01, C003-07 on the 837-P.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// date_of_service must be defined on either the encounter or the service lines but not both.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public DateOnly? DateOfService { get; set; }

    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; set; }
}
