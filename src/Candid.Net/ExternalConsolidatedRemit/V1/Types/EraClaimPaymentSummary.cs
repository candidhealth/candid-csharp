using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.EraCommons;
using global::Candid.Net.Eras;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

/// <summary>
/// EraClaimPayment fields, minus era_payment (redundant with the remit_id already on this
/// transaction) and service_payments (redundant with the single related service payment
/// already returned alongside this).
/// </summary>
[Serializable]
public record EraClaimPaymentSummary : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("patient_control_number")]
    public required string PatientControlNumber { get; set; }

    [JsonPropertyName("payer_claim_control_number")]
    public required string PayerClaimControlNumber { get; set; }

    [JsonPropertyName("claim_status_code")]
    public required ClaimStatusCodeCreate ClaimStatusCode { get; set; }

    [JsonPropertyName("total_claim_charge_amount_cents")]
    public required int TotalClaimChargeAmountCents { get; set; }

    [JsonPropertyName("claim_payment_amount_cents")]
    public required int ClaimPaymentAmountCents { get; set; }

    [JsonPropertyName("patient_responsibility_amount_cents")]
    public required int PatientResponsibilityAmountCents { get; set; }

    /// <summary>
    /// Claim-level adjustments (distinct from the service payment's own adjustments).
    /// </summary>
    [JsonPropertyName("adjustments")]
    public IEnumerable<EraAdjustment> Adjustments { get; set; } = new List<EraAdjustment>();

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
