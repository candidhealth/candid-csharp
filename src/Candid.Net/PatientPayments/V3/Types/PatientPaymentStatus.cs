using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PatientPayments.V3;

[JsonConverter(typeof(StringEnumSerializer<PatientPaymentStatus>))]
[Serializable]
public readonly record struct PatientPaymentStatus : IStringEnum
{
    public static readonly PatientPaymentStatus Pending = new(Values.Pending);

    public static readonly PatientPaymentStatus Paid = new(Values.Paid);

    public static readonly PatientPaymentStatus Canceled = new(Values.Canceled);

    public static readonly PatientPaymentStatus Voided = new(Values.Voided);

    public static readonly PatientPaymentStatus Failed = new(Values.Failed);

    public static readonly PatientPaymentStatus Completed = new(Values.Completed);

    public static readonly PatientPaymentStatus StripeSucceeded = new(Values.StripeSucceeded);

    public static readonly PatientPaymentStatus StripePending = new(Values.StripePending);

    public static readonly PatientPaymentStatus StripeFailed = new(Values.StripeFailed);

    public static readonly PatientPaymentStatus StripeRequiresAction = new(
        Values.StripeRequiresAction
    );

    public static readonly PatientPaymentStatus StripeCanceled = new(Values.StripeCanceled);

    public PatientPaymentStatus(string value)
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
    public static PatientPaymentStatus FromCustom(string value)
    {
        return new PatientPaymentStatus(value);
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

    public static bool operator ==(PatientPaymentStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientPaymentStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientPaymentStatus value) => value.Value;

    public static explicit operator PatientPaymentStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pending = "PENDING";

        public const string Paid = "paid";

        public const string Canceled = "CANCELED";

        public const string Voided = "voided";

        public const string Failed = "FAILED";

        public const string Completed = "COMPLETED";

        public const string StripeSucceeded = "succeeded";

        public const string StripePending = "pending";

        public const string StripeFailed = "failed";

        public const string StripeRequiresAction = "requires_action";

        public const string StripeCanceled = "canceled";
    }
}
