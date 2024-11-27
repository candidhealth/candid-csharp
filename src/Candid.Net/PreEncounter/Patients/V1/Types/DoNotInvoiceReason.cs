using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(EnumSerializer<DoNotInvoiceReason>))]
public enum DoNotInvoiceReason
{
    [EnumMember(Value = "BANKRUPTCY")]
    Bankruptcy,

    [EnumMember(Value = "DECEASED")]
    Deceased,

    [EnumMember(Value = "HARDSHIP")]
    Hardship,

    [EnumMember(Value = "OTHER")]
    Other,
}
