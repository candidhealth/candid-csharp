using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientAr.V1;

[JsonConverter(typeof(EnumSerializer<PatientArStatus>))]
public enum PatientArStatus
{
    [EnumMember(Value = "invoiceable")]
    Invoiceable,

    [EnumMember(Value = "non_invoiceable")]
    NonInvoiceable,
}
