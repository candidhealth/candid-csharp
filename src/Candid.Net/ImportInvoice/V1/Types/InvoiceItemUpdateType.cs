using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ImportInvoice.V1;

[JsonConverter(typeof(StringEnumSerializer<InvoiceItemUpdateType>))]
public enum InvoiceItemUpdateType
{
    [EnumMember(Value = "APPEND")]
    Append,

    [EnumMember(Value = "OVERWRITE")]
    Overwrite,
}
