using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientPayments.V3;

[JsonConverter(typeof(EnumSerializer<PatientPaymentStatus>))]
public enum PatientPaymentStatus
{
    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "paid")]
    Paid,

    [EnumMember(Value = "CANCELED")]
    Canceled,

    [EnumMember(Value = "voided")]
    Voided,

    [EnumMember(Value = "FAILED")]
    Failed,

    [EnumMember(Value = "COMPLETED")]
    Completed,

    [EnumMember(Value = "succeeded")]
    StripeSucceeded,

    [EnumMember(Value = "pending")]
    StripePending,

    [EnumMember(Value = "failed")]
    StripeFailed,

    [EnumMember(Value = "requires_action")]
    StripeRequiresAction,

    [EnumMember(Value = "canceled")]
    StripeCanceled,
}
