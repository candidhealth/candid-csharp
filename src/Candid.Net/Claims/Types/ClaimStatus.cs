using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Claims;

[JsonConverter(typeof(StringEnumSerializer<ClaimStatus>))]
[Serializable]
public readonly record struct ClaimStatus : IStringEnum
{
    public static readonly ClaimStatus BillerReceived = new(Values.BillerReceived);

    public static readonly ClaimStatus Coded = new(Values.Coded);

    public static readonly ClaimStatus SubmittedToPayer = new(Values.SubmittedToPayer);

    public static readonly ClaimStatus MissingInformation = new(Values.MissingInformation);

    public static readonly ClaimStatus NotBillable = new(Values.NotBillable);

    public static readonly ClaimStatus WaitingForProvider = new(Values.WaitingForProvider);

    public static readonly ClaimStatus EraReceived = new(Values.EraReceived);

    public static readonly ClaimStatus Rejected = new(Values.Rejected);

    public static readonly ClaimStatus Denied = new(Values.Denied);

    public static readonly ClaimStatus Paid = new(Values.Paid);

    public static readonly ClaimStatus PaidIncorrectly = new(Values.PaidIncorrectly);

    public static readonly ClaimStatus FinalizedPaid = new(Values.FinalizedPaid);

    public static readonly ClaimStatus FinalizedDenied = new(Values.FinalizedDenied);

    public static readonly ClaimStatus HeldByCustomer = new(Values.HeldByCustomer);

    public static readonly ClaimStatus EraRequiresReview = new(Values.EraRequiresReview);

    public ClaimStatus(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static ClaimStatus FromCustom(string value)
    {
        return new ClaimStatus(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(ClaimStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ClaimStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ClaimStatus value) => value.Value;

    public static explicit operator ClaimStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string BillerReceived = "biller_received";

        public const string Coded = "coded";

        public const string SubmittedToPayer = "submitted_to_payer";

        public const string MissingInformation = "missing_information";

        public const string NotBillable = "not_billable";

        public const string WaitingForProvider = "waiting_for_provider";

        public const string EraReceived = "era_received";

        public const string Rejected = "rejected";

        public const string Denied = "denied";

        public const string Paid = "paid";

        public const string PaidIncorrectly = "paid_incorrectly";

        public const string FinalizedPaid = "finalized_paid";

        public const string FinalizedDenied = "finalized_denied";

        public const string HeldByCustomer = "held_by_customer";

        public const string EraRequiresReview = "era_requires_review";
    }
}
