using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.Payers.V3;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public record InsurancePayment
{
    [JsonPropertyName("insurance_payment_id")]
    public required string InsurancePaymentId { get; set; }

    [JsonPropertyName("payer")]
    public required Payer Payer { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<Allocation> Allocations { get; set; } = new List<Allocation>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
