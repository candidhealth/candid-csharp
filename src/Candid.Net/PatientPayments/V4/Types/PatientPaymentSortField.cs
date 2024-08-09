using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientPayments.V4;

[JsonConverter(typeof(StringEnumSerializer<PatientPaymentSortField>))]
public enum PatientPaymentSortField
{
    [EnumMember(Value = "payment_source")]
    PaymentSource,

    [EnumMember(Value = "amount_cents")]
    AmountCents,

    [EnumMember(Value = "payment_timestamp")]
    PaymentTimestamp,

    [EnumMember(Value = "payment_note")]
    PaymentNote
}
