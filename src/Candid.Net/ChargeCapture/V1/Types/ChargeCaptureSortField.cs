using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.ChargeCapture.V1;

[JsonConverter(typeof(ChargeCaptureSortField.ChargeCaptureSortFieldSerializer))]
[Serializable]
public readonly record struct ChargeCaptureSortField : IStringEnum
{
    public static readonly ChargeCaptureSortField CreatedAt = new(Values.CreatedAt);

    public static readonly ChargeCaptureSortField DateOfService = new(Values.DateOfService);

    public ChargeCaptureSortField(string value)
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
    public static ChargeCaptureSortField FromCustom(string value)
    {
        return new ChargeCaptureSortField(value);
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

    public static bool operator ==(ChargeCaptureSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChargeCaptureSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChargeCaptureSortField value) => value.Value;

    public static explicit operator ChargeCaptureSortField(string value) => new(value);

    internal class ChargeCaptureSortFieldSerializer : JsonConverter<ChargeCaptureSortField>
    {
        public override ChargeCaptureSortField Read(
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
            return new ChargeCaptureSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChargeCaptureSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChargeCaptureSortField ReadAsPropertyName(
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
            return new ChargeCaptureSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChargeCaptureSortField value,
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
        public const string CreatedAt = "created_at";

        public const string DateOfService = "date_of_service";
    }
}
