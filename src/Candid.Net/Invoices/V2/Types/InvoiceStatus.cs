using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.Invoices.V2;

[JsonConverter(typeof(StringEnumSerializer<InvoiceStatus>))]
public enum InvoiceStatus
{
    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "PAID")]
    Paid,

    [EnumMember(Value = "VOID")]
    Void,

    [EnumMember(Value = "UNCOLLECTIBLE")]
    Uncollectible,

    [EnumMember(Value = "HELD")]
    Held
}
