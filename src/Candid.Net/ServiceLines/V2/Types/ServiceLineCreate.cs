using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.EncounterProviders.V2;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record ServiceLineCreate
{
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

    [JsonPropertyName("procedure_code")]
    public required string ProcedureCode { get; set; }

    /// <summary>
    /// String representation of a Decimal that can be parsed by most libraries.
    /// A ServiceLine quantity cannot contain more than one digit of precision.
    /// Example: 1.1 is valid, 1.11 is not.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required string Quantity { get; set; }

    [JsonPropertyName("units")]
    public required ServiceLineUnits Units { get; set; }

    /// <summary>
    /// The total amount charged for this service line taking quantity into account. For example, if a single unit
    /// costs 100 cents and 2 units were rendered, the charge_amount_cents should be 200. Should be greater than or
    /// equal to 0.
    /// </summary>
    [JsonPropertyName("charge_amount_cents")]
    public int? ChargeAmountCents { get; set; }

    /// <summary>
    /// Indices (zero-indexed) of all the diagnoses this service line references
    /// </summary>
    [JsonPropertyName("diagnosis_pointers")]
    public IEnumerable<int> DiagnosisPointers { get; set; } = new List<int>();

    [JsonPropertyName("drug_identification")]
    public DrugIdentification? DrugIdentification { get; set; }

    /// <summary>
    /// 837p Loop2300, SV105. If your organization does not intend to submit claims with a different place of service at the service line level, this field should not be populated. 02 for telemedicine, 11 for in-person. Full list [here](https://www.cms.gov/Medicare/Coding/place-of-service-codes/Place_of_Service_Code_Set).
    /// </summary>
    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; set; }

    /// <summary>
    /// A free-form description to clarify the related data elements and their content. Maps to SV1-01, C003-07 on the 837-P.
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
    /// Maps to MEA-02 on the 837-P. No more than 5 test results may be submitted per service line.
    /// </summary>
    [JsonPropertyName("test_results")]
    public IEnumerable<TestResult>? TestResults { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
