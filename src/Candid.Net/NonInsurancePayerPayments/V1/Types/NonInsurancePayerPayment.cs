using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.Financials;
using global::Candid.Net.NonInsurancePayers.V1;

namespace Candid.Net.NonInsurancePayerPayments.V1;

[Serializable]
public record NonInsurancePayerPayment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("non_insurance_payer_payment_id")]
    public required string NonInsurancePayerPaymentId { get; set; }

    [JsonPropertyName("non_insurance_payer")]
    public required NonInsurancePayer NonInsurancePayer { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; set; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<Allocation> Allocations { get; set; } = new List<Allocation>();

    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; set; }

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
