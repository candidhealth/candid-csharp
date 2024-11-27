using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayerPayments.V1;

[JsonConverter(typeof(EnumSerializer<NonInsurancePayerPaymentSortField>))]
public enum NonInsurancePayerPaymentSortField
{
    [EnumMember(Value = "amount_cents")]
    AmountCents,

    [EnumMember(Value = "payment_timestamp")]
    PaymentTimestamp,
}
