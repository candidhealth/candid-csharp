using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(ValueCodeQualifier.ValueCodeQualifierSerializer))]
[Serializable]
public readonly record struct ValueCodeQualifier : IStringEnum
{
    /// <summary>
    /// Value
    /// </summary>
    public static readonly ValueCodeQualifier Cbe = new(Values.Cbe);

    public ValueCodeQualifier(string value)
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
    public static ValueCodeQualifier FromCustom(string value)
    {
        return new ValueCodeQualifier(value);
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

    public static bool operator ==(ValueCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ValueCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ValueCodeQualifier value) => value.Value;

    public static explicit operator ValueCodeQualifier(string value) => new(value);

    internal class ValueCodeQualifierSerializer : JsonConverter<ValueCodeQualifier>
    {
        public override ValueCodeQualifier Read(
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
            return new ValueCodeQualifier(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ValueCodeQualifier value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ValueCodeQualifier ReadAsPropertyName(
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
            return new ValueCodeQualifier(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ValueCodeQualifier value,
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
        /// <summary>
        /// Value
        /// </summary>
        public const string Cbe = "BE";
    }
}
