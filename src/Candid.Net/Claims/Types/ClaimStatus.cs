using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<ClaimStatus>))]
public enum ClaimStatus
{
    [EnumMember(Value = "biller_received")]
    BillerReceived,

    [EnumMember(Value = "coded")]
    Coded,

    [EnumMember(Value = "submitted_to_payer")]
    SubmittedToPayer,

    [EnumMember(Value = "missing_information")]
    MissingInformation,

    [EnumMember(Value = "not_billable")]
    NotBillable,

    [EnumMember(Value = "waiting_for_provider")]
    WaitingForProvider,

    [EnumMember(Value = "era_received")]
    EraReceived,

    [EnumMember(Value = "rejected")]
    Rejected,

    [EnumMember(Value = "denied")]
    Denied,

    [EnumMember(Value = "paid")]
    Paid,

    [EnumMember(Value = "paid_incorrectly")]
    PaidIncorrectly,

    [EnumMember(Value = "finalized_paid")]
    FinalizedPaid,

    [EnumMember(Value = "finalized_denied")]
    FinalizedDenied,

    [EnumMember(Value = "held_by_customer")]
    HeldByCustomer,

    [EnumMember(Value = "era_requires_review")]
    EraRequiresReview
}
