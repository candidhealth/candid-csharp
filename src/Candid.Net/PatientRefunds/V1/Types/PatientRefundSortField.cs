using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientRefunds.V1;

[JsonConverter(typeof(StringEnumSerializer<PatientRefundSortField>))]
public enum PatientRefundSortField
{
    [EnumMember(Value = "refund_source")]
    RefundSource,

    [EnumMember(Value = "amount_cents")]
    AmountCents,

    [EnumMember(Value = "refund_timestamp")]
    RefundTimestamp,

    [EnumMember(Value = "refund_reason")]
    RefundReason,

    [EnumMember(Value = "refund_note")]
    RefundNote
}
