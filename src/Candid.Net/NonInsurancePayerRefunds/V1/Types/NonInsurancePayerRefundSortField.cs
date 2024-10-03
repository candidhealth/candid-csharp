using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayerRefunds.V1;

[JsonConverter(typeof(StringEnumSerializer<NonInsurancePayerRefundSortField>))]
public enum NonInsurancePayerRefundSortField
{
    [EnumMember(Value = "amount_cents")]
    AmountCents,

    [EnumMember(Value = "refund_timestamp")]
    RefundTimestamp,
}
