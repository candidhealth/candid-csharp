using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PatientPayments.V4;

[JsonConverter(typeof(StringEnumSerializer<PatientPaymentSortField>))]
[Serializable]
public readonly record struct PatientPaymentSortField : IStringEnum
{
    public static readonly PatientPaymentSortField PaymentSource = new(Values.PaymentSource);

    public static readonly PatientPaymentSortField AmountCents = new(Values.AmountCents);

    public static readonly PatientPaymentSortField PaymentTimestamp = new(Values.PaymentTimestamp);

    public static readonly PatientPaymentSortField PaymentNote = new(Values.PaymentNote);

    public PatientPaymentSortField(string value)
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
    public static PatientPaymentSortField FromCustom(string value)
    {
        return new PatientPaymentSortField(value);
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

    public static bool operator ==(PatientPaymentSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientPaymentSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientPaymentSortField value) => value.Value;

    public static explicit operator PatientPaymentSortField(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string PaymentSource = "payment_source";

        public const string AmountCents = "amount_cents";

        public const string PaymentTimestamp = "payment_timestamp";

        public const string PaymentNote = "payment_note";
    }
}
