using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

/// <summary>
/// Fields present on every transaction, regardless of type. See each concrete transaction
/// schema's description for the one place nullability genuinely differs by type
/// (remit_id/consolidated_remit_id/era_payer_name).
/// </summary>
[Serializable]
public record TransactionCommonFields : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
