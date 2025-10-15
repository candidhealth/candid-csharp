using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PatientRefunds.V1;

[JsonConverter(typeof(StringEnumSerializer<PatientRefundSortField>))]
[Serializable]
public readonly record struct PatientRefundSortField : IStringEnum
{
    public static readonly PatientRefundSortField RefundSource = new(Values.RefundSource);

    public static readonly PatientRefundSortField AmountCents = new(Values.AmountCents);

    public static readonly PatientRefundSortField RefundTimestamp = new(Values.RefundTimestamp);

    public static readonly PatientRefundSortField RefundReason = new(Values.RefundReason);

    public static readonly PatientRefundSortField RefundNote = new(Values.RefundNote);

    public PatientRefundSortField(string value)
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
    public static PatientRefundSortField FromCustom(string value)
    {
        return new PatientRefundSortField(value);
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

    public static bool operator ==(PatientRefundSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientRefundSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientRefundSortField value) => value.Value;

    public static explicit operator PatientRefundSortField(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string RefundSource = "refund_source";

        public const string AmountCents = "amount_cents";

        public const string RefundTimestamp = "refund_timestamp";

        public const string RefundReason = "refund_reason";

        public const string RefundNote = "refund_note";
    }
}
