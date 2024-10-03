using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

[JsonConverter(typeof(StringEnumSerializer<InsurancePaymentSortField>))]
public enum InsurancePaymentSortField
{
    [EnumMember(Value = "amount_cents")]
    AmountCents,

    [EnumMember(Value = "payment_timestamp")]
    PaymentTimestamp,

    [EnumMember(Value = "payment_note")]
    PaymentNote,
}
