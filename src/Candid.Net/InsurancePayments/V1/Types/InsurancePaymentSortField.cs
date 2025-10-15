using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.InsurancePayments.V1;

[JsonConverter(typeof(StringEnumSerializer<InsurancePaymentSortField>))]
[Serializable]
public readonly record struct InsurancePaymentSortField : IStringEnum
{
    public static readonly InsurancePaymentSortField AmountCents = new(Values.AmountCents);

    public static readonly InsurancePaymentSortField PaymentTimestamp = new(
        Values.PaymentTimestamp
    );

    public static readonly InsurancePaymentSortField PaymentNote = new(Values.PaymentNote);

    public InsurancePaymentSortField(string value)
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
    public static InsurancePaymentSortField FromCustom(string value)
    {
        return new InsurancePaymentSortField(value);
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

    public static bool operator ==(InsurancePaymentSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InsurancePaymentSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InsurancePaymentSortField value) => value.Value;

    public static explicit operator InsurancePaymentSortField(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AmountCents = "amount_cents";

        public const string PaymentTimestamp = "payment_timestamp";

        public const string PaymentNote = "payment_note";
    }
}
