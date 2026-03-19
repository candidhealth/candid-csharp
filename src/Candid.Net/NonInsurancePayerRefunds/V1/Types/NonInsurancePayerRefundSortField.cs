using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.NonInsurancePayerRefunds.V1;

[JsonConverter(typeof(NonInsurancePayerRefundSortField.NonInsurancePayerRefundSortFieldSerializer))]
[Serializable]
public readonly record struct NonInsurancePayerRefundSortField : IStringEnum
{
    public static readonly NonInsurancePayerRefundSortField AmountCents = new(Values.AmountCents);

    public static readonly NonInsurancePayerRefundSortField RefundTimestamp = new(
        Values.RefundTimestamp
    );

    public NonInsurancePayerRefundSortField(string value)
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
    public static NonInsurancePayerRefundSortField FromCustom(string value)
    {
        return new NonInsurancePayerRefundSortField(value);
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

    public static bool operator ==(NonInsurancePayerRefundSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NonInsurancePayerRefundSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NonInsurancePayerRefundSortField value) => value.Value;

    public static explicit operator NonInsurancePayerRefundSortField(string value) => new(value);

    internal class NonInsurancePayerRefundSortFieldSerializer
        : JsonConverter<NonInsurancePayerRefundSortField>
    {
        public override NonInsurancePayerRefundSortField Read(
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
            return new NonInsurancePayerRefundSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            NonInsurancePayerRefundSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override NonInsurancePayerRefundSortField ReadAsPropertyName(
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
            return new NonInsurancePayerRefundSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            NonInsurancePayerRefundSortField value,
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
    }
}
