using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.EncounterProviders.V2;
using Candid.Net.ServiceLines.V2;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record ServiceLineCreate
{
    [JsonPropertyName("modifiers")]
    public IEnumerable<ProcedureModifier>? Modifiers { get; set; }

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
    /// The final provider who referred the services that were rendered.
    /// All physicians who order services or refer Medicare beneficiaries must
    /// report this data.
    /// </summary>
    [JsonPropertyName("referring_provider")]
    public ReferringProvider? ReferringProvider { get; set; }

    /// <summary>
    /// The second iteration of Loop ID-2310. Use code "P3 - Primary Care Provider" in this loop to
    /// indicate the initial referral from the primary care provider or whatever provider wrote the initial referral for this patient's episode of care being billed/reported in this transaction.
    /// Information in Loop ID-2310 applies to the entire claim unless overridden on a service line by the presence of Loop ID-2420 with the same value in NM101.
    /// </summary>
    [JsonPropertyName("initial_referring_provider")]
    public InitialReferringProvider? InitialReferringProvider { get; set; }

    /// <summary>
    /// Required when the rendering provider is supervised by a physician. If not required by this implementation guide, do not send.
    /// Information in Loop ID-2310 applies to the entire claim unless overridden on a service line by the presence of Loop ID-2420 with the same value in NM101.
    /// </summary>
    [JsonPropertyName("supervising_provider")]
    public SupervisingProvider? SupervisingProvider { get; set; }

    /// <summary>
    /// Required when the service or supply was ordered by a provider who is different than the rendering provider for this service line.
    /// If not required by this implementation guide, do not send.
    /// </summary>
    [JsonPropertyName("ordering_provider")]
    public OrderingProvider? OrderingProvider { get; set; }
}
