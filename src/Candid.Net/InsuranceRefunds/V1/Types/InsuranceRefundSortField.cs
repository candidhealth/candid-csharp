using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.InsuranceRefunds.V1;

[JsonConverter(typeof(InsuranceRefundSortField.InsuranceRefundSortFieldSerializer))]
[Serializable]
public readonly record struct InsuranceRefundSortField : IStringEnum
{
    public static readonly InsuranceRefundSortField AmountCents = new(Values.AmountCents);

    public static readonly InsuranceRefundSortField RefundTimestamp = new(Values.RefundTimestamp);

    public static readonly InsuranceRefundSortField RefundNote = new(Values.RefundNote);

    public static readonly InsuranceRefundSortField RefundReason = new(Values.RefundReason);

    public InsuranceRefundSortField(string value)
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
    public static InsuranceRefundSortField FromCustom(string value)
    {
        return new InsuranceRefundSortField(value);
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

    public static bool operator ==(InsuranceRefundSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InsuranceRefundSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InsuranceRefundSortField value) => value.Value;

    public static explicit operator InsuranceRefundSortField(string value) => new(value);

    internal class InsuranceRefundSortFieldSerializer : JsonConverter<InsuranceRefundSortField>
    {
        public override InsuranceRefundSortField Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new InsuranceRefundSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InsuranceRefundSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InsuranceRefundSortField ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new InsuranceRefundSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InsuranceRefundSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AmountCents = "amount_cents";

        public const string RefundTimestamp = "refund_timestamp";

        public const string RefundNote = "refund_note";

        public const string RefundReason = "refund_reason";
    }
}
