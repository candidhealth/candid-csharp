using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientPayments.V3;

[JsonConverter(typeof(StringEnumSerializer<PatientPaymentSource>))]
public enum PatientPaymentSource
{
    [EnumMember(Value = "MANUAL_ENTRY")]
    ManualEntry,

    [EnumMember(Value = "CHARGEBEE_PAYMENTS")]
    ChargebeePayments,

    [EnumMember(Value = "CHARGEBEE MANUALLY VOIDED BY CANDID")]
    ChargebeeManuallyVoidedByCandid,

    [EnumMember(Value = "CHARGEBEE_REFUNDS")]
    ChargebeeRefunds,

    [EnumMember(Value = "SQUARE_REFUNDS")]
    SquareRefunds,

    [EnumMember(Value = "SQUARE_PAYMENTS")]
    SquarePayments,

    [EnumMember(Value = "STRIPE_CHARGES")]
    StripeCharges,

    [EnumMember(Value = "STRIPE_REFUNDS")]
    StripeRefunds,

    [EnumMember(Value = "ELATION_PAYMENTS")]
    ElationPayments
}
