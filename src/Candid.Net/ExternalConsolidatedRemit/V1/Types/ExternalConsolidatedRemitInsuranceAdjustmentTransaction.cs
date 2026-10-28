using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.Eras;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

/// <summary>
/// Unlike InsurancePayment, posted_by/voided_by can genuinely be real user ids for this
/// transaction type.
/// </summary>
[Serializable]
public record ExternalConsolidatedRemitInsuranceAdjustmentTransaction : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("adjustment_source")]
    public required InsuranceAdjustmentSource AdjustmentSource { get; set; }

    [JsonPropertyName("adjustment_reason")]
    public required InsuranceAdjustmentReason AdjustmentReason { get; set; }

    /// <summary>
    /// The single X12 CARC (Claim Adjustment Reason Code) that best explains this adjustment (lowest-position/highest-priority tie-break when more than one applies). Null only when this adjustment has no ERA link at all (a manual/non-ERA write-off) - see adjustment_source. For the full underlying set rather than the single flattened value, see adjustment_details.
    /// </summary>
    [JsonPropertyName("carc")]
    public string? Carc { get; set; }

    /// <summary>
    /// The full CARC/RARC-level ERA adjustment detail(s) this transaction was created from, if any. carc above is the flattened single-value equivalent of the first (lowest-position) entry here.
    /// </summary>
    [JsonPropertyName("adjustment_details")]
    public IEnumerable<EraAdjustment> AdjustmentDetails { get; set; } = new List<EraAdjustment>();

    /// <summary>
    /// Set iff is_void=true - always another insurance_adjustment transaction's id, never an insurance_payment's.
    /// </summary>
    [JsonPropertyName("reverses_adjustment_id")]
    public string? ReversesAdjustmentId { get; set; }

    /// <summary>
    /// Set iff is_void=false and this transaction has since been reversed - always another insurance_adjustment transaction's id, never an insurance_payment's.
    /// </summary>
    [JsonPropertyName("reverted_by_adjustment_id")]
    public string? RevertedByAdjustmentId { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The ERA payment this transaction was posted from - see each concrete transaction type below for when this can be null.
    /// </summary>
    [JsonPropertyName("remit_id")]
    public string? RemitId { get; set; }

    /// <summary>
    /// Null under the same conditions as remit_id (see above), since it's resolved from remit_id.
    /// </summary>
    [JsonPropertyName("consolidated_remit_id")]
    public string? ConsolidatedRemitId { get; set; }

    /// <summary>
    /// Null under the same conditions as remit_id (see above). Also returned nested under EraPayer on the sibling era-payments endpoint.
    /// </summary>
    [JsonPropertyName("era_payer_name")]
    public string? EraPayerName { get; set; }

    [JsonPropertyName("target_type")]
    public required TargetType TargetType { get; set; }

    /// <summary>
    /// Identifies the target, per target_type - the same value as target_id on the corresponding insurance AR event:
    /// - ORGANIZATION: the organization id
    /// - PROVIDER / EXTERNAL_PROVIDER: the provider's NPI
    /// - CLAIM: the claim id
    /// - SERVICE_LINE: the service line id
    /// </summary>
    [JsonPropertyName("target_id")]
    public required string TargetId { get; set; }

    /// <summary>
    /// Only ever resolves for target_type in (CLAIM, SERVICE_LINE).
    /// </summary>
    [JsonPropertyName("organization_service_facility_id")]
    public string? OrganizationServiceFacilityId { get; set; }

    /// <summary>
    /// Only ever resolves for target_type in (CLAIM, SERVICE_LINE).
    /// </summary>
    [JsonPropertyName("organization_service_facility_external_id")]
    public string? OrganizationServiceFacilityExternalId { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    /// <summary>
    /// When this specific row (posting or void) was created - not to be confused with posted_at/voided_at below, which additionally carry who did it.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// True if this transaction is itself a voiding/reversal; false if it's an original posting.
    /// A reversed original is returned as two separate items - this one with is_void=false, plus
    /// a second item elsewhere in the page with is_void=true - rather than a single item with a
    /// "reversed" flag.
    /// </summary>
    [JsonPropertyName("is_void")]
    public required bool IsVoid { get; set; }

    /// <summary>
    /// Set iff is_void=false.
    /// </summary>
    [JsonPropertyName("posted_at")]
    public DateTime? PostedAt { get; set; }

    /// <summary>
    /// Set iff is_void=false. See each concrete transaction type for whether this can genuinely be a real user id or is always the system account.
    /// </summary>
    [JsonPropertyName("posted_by")]
    public string? PostedBy { get; set; }

    /// <summary>
    /// Set iff is_void=true.
    /// </summary>
    [JsonPropertyName("voided_at")]
    public DateTime? VoidedAt { get; set; }

    /// <summary>
    /// Set iff is_void=true. See each concrete transaction type for whether this can genuinely be a real user id or is always null.
    /// </summary>
    [JsonPropertyName("voided_by")]
    public string? VoidedBy { get; set; }

    [JsonPropertyName("source")]
    public required TransactionSource Source { get; set; }

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
