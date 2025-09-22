using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Financials;
using Candid.Net.NonInsurancePayers.V1;

#nullable enable

namespace Candid.Net.NonInsurancePayerPayments.V1;

public record NonInsurancePayerPayment
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
