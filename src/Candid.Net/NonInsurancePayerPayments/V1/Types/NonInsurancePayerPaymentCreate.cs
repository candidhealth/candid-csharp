using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.Financials;

namespace Candid.Net.NonInsurancePayerPayments.V1;

[Serializable]
public record NonInsurancePayerPaymentCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("non_insurance_payer_id")]
    public required string NonInsurancePayerId { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; set; }

    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<AllocationCreate> Allocations { get; set; } = new List<AllocationCreate>();

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
