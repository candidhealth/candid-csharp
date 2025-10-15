using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PatientPayments.V3;

[JsonConverter(typeof(StringEnumSerializer<PatientPaymentSource>))]
[Serializable]
public readonly record struct PatientPaymentSource : IStringEnum
{
    public static readonly PatientPaymentSource ManualEntry = new(Values.ManualEntry);

    public static readonly PatientPaymentSource ChargebeePayments = new(Values.ChargebeePayments);

    public static readonly PatientPaymentSource ChargebeeManuallyVoidedByCandid = new(
        Values.ChargebeeManuallyVoidedByCandid
    );

    public static readonly PatientPaymentSource ChargebeeRefunds = new(Values.ChargebeeRefunds);

    public static readonly PatientPaymentSource SquareRefunds = new(Values.SquareRefunds);

    public static readonly PatientPaymentSource SquarePayments = new(Values.SquarePayments);

    public static readonly PatientPaymentSource StripeCharges = new(Values.StripeCharges);

    public static readonly PatientPaymentSource StripeRefunds = new(Values.StripeRefunds);

    public static readonly PatientPaymentSource ElationPayments = new(Values.ElationPayments);

    public PatientPaymentSource(string value)
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
    public static PatientPaymentSource FromCustom(string value)
    {
        return new PatientPaymentSource(value);
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

    public static bool operator ==(PatientPaymentSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientPaymentSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientPaymentSource value) => value.Value;

    public static explicit operator PatientPaymentSource(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ManualEntry = "MANUAL_ENTRY";

        public const string ChargebeePayments = "CHARGEBEE_PAYMENTS";

        public const string ChargebeeManuallyVoidedByCandid = "CHARGEBEE MANUALLY VOIDED BY CANDID";

        public const string ChargebeeRefunds = "CHARGEBEE_REFUNDS";

        public const string SquareRefunds = "SQUARE_REFUNDS";

        public const string SquarePayments = "SQUARE_PAYMENTS";

        public const string StripeCharges = "STRIPE_CHARGES";

        public const string StripeRefunds = "STRIPE_REFUNDS";

        public const string ElationPayments = "ELATION_PAYMENTS";
    }
}
