using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ThirdPartyPayerRefunds.V1;

[JsonConverter(typeof(StringEnumSerializer<ThirdPartyPayerRefundSortField>))]
public enum ThirdPartyPayerRefundSortField
{
    [EnumMember(Value = "amount_cents")]
    AmountCents,

    [EnumMember(Value = "refund_timestamp")]
    RefundTimestamp
}
