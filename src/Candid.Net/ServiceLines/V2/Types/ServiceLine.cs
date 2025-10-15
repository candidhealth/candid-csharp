using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.EncounterProviders.V2;
using Candid.Net.Invoices.V2;

namespace Candid.Net.ServiceLines.V2;

[Serializable]
public record ServiceLine : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

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

    [JsonPropertyName("copay_cents")]
    public int? CopayCents { get; set; }

    [JsonPropertyName("coinsurance_cents")]
    public int? CoinsuranceCents { get; set; }

    [JsonPropertyName("deductible_cents")]
    public int? DeductibleCents { get; set; }

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
    public IEnumerable<Candid.Net.Invoices.Invoice>? RelatedInvoices { get; set; }

    [JsonPropertyName("related_invoice_info")]
    public IEnumerable<InvoiceInfo>? RelatedInvoiceInfo { get; set; }

    [JsonPropertyName("denial_reason")]
    public ServiceLineDenialReason? DenialReason { get; set; }

    /// <summary>
    /// 837p Loop2300, SV105. This enum is not used or required in 837i claims. If your organization does not intend to submit claims with a different place of service at the service line level, this field should not be populated. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    /// </summary>
    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; set; }

    /// <summary>
    /// 837p Loop2300, SV105. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    /// </summary>
    [JsonPropertyName("place_of_service_code_as_submitted")]
    public FacilityTypeCode? PlaceOfServiceCodeAsSubmitted { get; set; }

    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; set; }

    [JsonPropertyName("procedure_code")]
    public required string ProcedureCode { get; set; }

    [JsonPropertyName("ordering_provider")]
    public EncounterProvider? OrderingProvider { get; set; }

    /// <summary>
    /// A 4 digit code that specifies facility department or type of service arrangement for institutional service line items (837i). This code is not required for professional claim billing (837p).
    /// </summary>
    [JsonPropertyName("revenue_code")]
    public string? RevenueCode { get; set; }

    /// <summary>
    /// String representation of a Decimal that can be parsed by most libraries.
    /// For professional claims, a ServiceLine quantity cannot contain more than one digit of precision
    /// (Example: 1.1 is valid, 1.11 is not). For institutional claims, a ServiceLine quantity cannot contain
    /// more than three decimal digits of precision.
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
    /// A free-form description to clarify the related data elements and their content. Maps to SV1-01, C003-07 on a 837-P and SV2-02, C003-07 on a 837-I form.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; set; }

    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; set; }

    /// <summary>
    /// Contains a list of test results. Test result types may map to MEA-02 on the 837-P (ex: Hemoglobin, Hematocrit).
    /// This is unused by 837-i and ignored for institutional service lines.
    /// No more than 5 MEA-02 test results may be submitted per service line.
    /// </summary>
    [JsonPropertyName("test_results")]
    public IEnumerable<TestResult>? TestResults { get; set; }

    /// <summary>
    /// Maps to SV1-11 on the 837-P and Box 24H on the CMS-1500.
    /// If the value is true, the box will be populated with "Y". Otherwise, the box will not be populated.
    /// </summary>
    [JsonPropertyName("has_epsdt_indicator")]
    public bool? HasEpsdtIndicator { get; set; }

    /// <summary>
    /// Maps to SV1-12 on the 837-P and Box 24I on the CMS-1500.
    /// If the value is true, the box will be populated with "Y". Otherwise, the box will not be populated.
    /// </summary>
    [JsonPropertyName("has_family_planning_indicator")]
    public bool? HasFamilyPlanningIndicator { get; set; }

    /// <summary>
    /// Maps to NTE02 loop 2400 on the EDI 837.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

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
