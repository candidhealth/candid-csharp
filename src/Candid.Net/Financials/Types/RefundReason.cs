using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Financials;

[JsonConverter(typeof(EnumSerializer<RefundReason>))]
public enum RefundReason
{
    [EnumMember(Value = "OVERCHARGED")]
    Overcharged,
}
