using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ThirdPartyPayerPayments.V1;

[JsonConverter(typeof(StringEnumSerializer<ThirdPartyPayerPaymentSortField>))]
public enum ThirdPartyPayerPaymentSortField
{
    [EnumMember(Value = "amount_cents")]
    AmountCents,

    [EnumMember(Value = "payment_timestamp")]
    PaymentTimestamp
}
