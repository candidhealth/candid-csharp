using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Financials;

[JsonConverter(typeof(RefundReason.RefundReasonSerializer))]
[Serializable]
public readonly record struct RefundReason : IStringEnum
{
    public static readonly RefundReason Overcharged = new(Values.Overcharged);

    public static readonly RefundReason EnteredInError = new(Values.EnteredInError);

    public static readonly RefundReason Transfer = new(Values.Transfer);

    public RefundReason(string value)
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
    public static RefundReason FromCustom(string value)
    {
        return new RefundReason(value);
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

    public static bool operator ==(RefundReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RefundReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RefundReason value) => value.Value;

    public static explicit operator RefundReason(string value) => new(value);

    internal class RefundReasonSerializer : JsonConverter<RefundReason>
    {
        public override RefundReason Read(
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
            return new RefundReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RefundReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RefundReason ReadAsPropertyName(
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
            return new RefundReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RefundReason value,
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
        public const string Overcharged = "OVERCHARGED";

        public const string EnteredInError = "ENTERED_IN_ERROR";

        public const string Transfer = "TRANSFER";
    }
}
