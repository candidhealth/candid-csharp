using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayerPayments.V1;

[JsonConverter(typeof(StringEnumSerializer<NonInsurancePayerPaymentSortField>))]
[Serializable]
public readonly record struct NonInsurancePayerPaymentSortField : IStringEnum
{
    public static readonly NonInsurancePayerPaymentSortField AmountCents = new(Values.AmountCents);

    public static readonly NonInsurancePayerPaymentSortField PaymentTimestamp = new(
        Values.PaymentTimestamp
    );

    public NonInsurancePayerPaymentSortField(string value)
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
    public static NonInsurancePayerPaymentSortField FromCustom(string value)
    {
        return new NonInsurancePayerPaymentSortField(value);
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

    public static bool operator ==(NonInsurancePayerPaymentSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NonInsurancePayerPaymentSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NonInsurancePayerPaymentSortField value) => value.Value;

    public static explicit operator NonInsurancePayerPaymentSortField(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AmountCents = "amount_cents";

        public const string PaymentTimestamp = "payment_timestamp";
    }
}
