using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

[JsonConverter(typeof(StringEnumSerializer<InsuranceRefundSortField>))]
public enum InsuranceRefundSortField
{
    [EnumMember(Value = "amount_cents")]
    AmountCents,

    [EnumMember(Value = "refund_timestamp")]
    RefundTimestamp,

    [EnumMember(Value = "refund_note")]
    RefundNote,

    [EnumMember(Value = "refund_reason")]
    RefundReason
}
