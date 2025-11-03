using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.EncounterProviders.V2;

namespace Candid.Net.ServiceLines.V2;

[Serializable]
public record UniversalServiceLineCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Indices (zero-indexed) of all the diagnoses this service line references
    /// </summary>
    [JsonPropertyName("diagnosis_pointers")]
    public IEnumerable<int>? DiagnosisPointers { get; set; }

    /// <summary>
    /// A 4 digit code that specifies facility department or type of service arrangement for institutional service line items (837i). This code is not required for professional claim billing (837p).
    /// </summary>
    [JsonPropertyName("revenue_code")]
    public string? RevenueCode { get; set; }

    [JsonPropertyName("procedure_code")]
    public string? ProcedureCode { get; set; }

    [JsonPropertyName("modifiers")]
    public IEnumerable<ProcedureModifier>? Modifiers { get; set; }

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
    /// String representation of a Decimal that can be parsed by most libraries.
    /// For professional claims, a ServiceLine quantity cannot contain more than one digit of precision
    /// (Example: 1.1 is valid, 1.11 is not). For institutional claims, a ServiceLine quantity cannot contain
    /// more than three decimal digits of precision.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required string Quantity { get; set; }

    [JsonPropertyName("units")]
    public required ServiceLineUnits Units { get; set; }

    /// <summary>
    /// The total amount charged for this service line, factoring in quantity. If procedure_code is updated and this is not, the system will attempt to set it based on chargemasters entries and the service line’s quantity. For example, if a single unit has an entry of 100 cents and 2 units were rendered, the charge_amount_cents will be set to 200, if there is no chargemaster entry, it will default to the amount set in this field.
    /// </summary>
    [JsonPropertyName("charge_amount_cents")]
    public int? ChargeAmountCents { get; set; }

    [JsonPropertyName("drug_identification")]
    public DrugIdentification? DrugIdentification { get; set; }

    /// <summary>
    /// 837p Loop2300, SV105. This enum is not used or required in 837i claims. If your organization does not intend to submit claims with a different place of service at the service line level, this field should not be populated. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    /// </summary>
    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; set; }

    /// <summary>
    /// A free-form description to clarify the related data elements and their content. Maps to SV1-01, C003-07 on a 837-P and SV2-02, C003-07 on a 837-I form.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("date_of_service")]
    public DateOnly? DateOfService { get; set; }

    [JsonPropertyName("end_date_of_service")]
    public DateOnly? EndDateOfService { get; set; }

    /// <summary>
    /// Required when the service or supply was ordered by a provider who is different than the rendering provider for this service line.
    /// If not required by this implementation guide, do not send.
    /// </summary>
    [JsonPropertyName("ordering_provider")]
    public OrderingProvider? OrderingProvider { get; set; }

    /// <summary>
    /// Contains a list of test results. Test result types may map to MEA-02 on the 837-P (ex: Hemoglobin, Hematocrit).
    /// This is unused by 837-i and ignored for institutional service lines.
    /// No more than 5 MEA-02 test results may be submitted per service line.
    /// </summary>
    [JsonPropertyName("test_results")]
    public IEnumerable<TestResult>? TestResults { get; set; }

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
