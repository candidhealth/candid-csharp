using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<InvoiceStatus>))]
public enum InvoiceStatus
{
    [EnumMember(Value = "draft")]
    Draft,

    [EnumMember(Value = "open")]
    Open,

    [EnumMember(Value = "paid")]
    Paid,

    [EnumMember(Value = "void")]
    Void,

    [EnumMember(Value = "uncollectible")]
    Uncollectible,

    [EnumMember(Value = "held")]
    Held
}
