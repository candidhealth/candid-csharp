using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.X12.V1;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Eras;

[Serializable]
public record EraServicePayment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("era_claim_payment_id")]
    public required string EraClaimPaymentId { get; set; }

    [JsonPropertyName("adjudicated_procedure_code")]
    public required string AdjudicatedProcedureCode { get; set; }

    [JsonPropertyName("adjudicated_modifiers")]
    public IEnumerable<string> AdjudicatedModifiers { get; set; } = new List<string>();

    [JsonPropertyName("original_procedure_code")]
    public string? OriginalProcedureCode { get; set; }

    [JsonPropertyName("original_modifiers")]
    public IEnumerable<string> OriginalModifiers { get; set; } = new List<string>();

    [JsonPropertyName("allowed_amount_cents")]
    public int? AllowedAmountCents { get; set; }

    [JsonPropertyName("line_item_charge_amount_cents")]
    public required int LineItemChargeAmountCents { get; set; }

    [JsonPropertyName("line_item_provider_payment_amount_cents")]
    public required int LineItemProviderPaymentAmountCents { get; set; }

    [JsonPropertyName("unit_of_service_paid_count")]
    public int? UnitOfServicePaidCount { get; set; }

    [JsonPropertyName("rarcs")]
    public IEnumerable<RemittanceAdviceRemarkCode> Rarcs { get; set; } =
        new List<RemittanceAdviceRemarkCode>();

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
