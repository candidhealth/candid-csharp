using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<RefundReason>))]
public enum RefundReason
{
    [EnumMember(Value = "OVERCHARGED")]
    Overcharged
}
