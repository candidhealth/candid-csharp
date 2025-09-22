using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Financials;

[JsonConverter(typeof(EnumSerializer<PatientTransactionSource>))]
public enum PatientTransactionSource
{
    [EnumMember(Value = "MANUAL_ENTRY")]
    ManualEntry,

    [EnumMember(Value = "CHARGEBEE")]
    Chargebee,

    [EnumMember(Value = "SQUARE")]
    Square,

    [EnumMember(Value = "STRIPE")]
    Stripe,

    [EnumMember(Value = "ELATION")]
    Elation,

    [EnumMember(Value = "CEDAR")]
    Cedar,

    [EnumMember(Value = "HEALTHIE")]
    Healthie,

    [EnumMember(Value = "REALLOCATION")]
    Reallocation,
}
