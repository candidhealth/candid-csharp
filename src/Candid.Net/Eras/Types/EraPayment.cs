using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.EraCommons;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Eras;

[Serializable]
public record EraPayment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("era_document")]
    public required EraDocument EraDocument { get; set; }

    /// <summary>
    /// when the edi document interchange took place
    /// </summary>
    [JsonPropertyName("posted_at")]
    public required DateTime PostedAt { get; set; }

    [JsonPropertyName("payer")]
    public required EraPayer Payer { get; set; }

    [JsonPropertyName("payment_method_code")]
    public required PaymentMethodCode PaymentMethodCode { get; set; }

    [JsonPropertyName("check_eft_trace_number")]
    public required string CheckEftTraceNumber { get; set; }

    [JsonPropertyName("check_issued_or_eft_effective_date")]
    public required string CheckIssuedOrEftEffectiveDate { get; set; }

    [JsonPropertyName("total_payment_amount_cents")]
    public required int TotalPaymentAmountCents { get; set; }

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
