using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Invoices.V2;

[JsonConverter(typeof(EnumSerializer<InvoiceSortField>))]
public enum InvoiceSortField
{
    [EnumMember(Value = "CREATED_AT")]
    CreatedAt,

    [EnumMember(Value = "UPDATED_AT")]
    UpdatedAt,

    [EnumMember(Value = "PATIENT_EXTERNAL_ID")]
    PatientExternalId,

    [EnumMember(Value = "NOTE")]
    Note,

    [EnumMember(Value = "DUE_DATE")]
    DueDate,

    [EnumMember(Value = "STATUS")]
    Status,
}
