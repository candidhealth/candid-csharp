using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.MetadataSchemas.V1;

[JsonConverter(typeof(MetadataFieldType.MetadataFieldTypeSerializer))]
[Serializable]
public readonly record struct MetadataFieldType : IStringEnum
{
    public static readonly MetadataFieldType String = new(Values.String);

    public static readonly MetadataFieldType Integer = new(Values.Integer);

    public static readonly MetadataFieldType Double = new(Values.Double);

    public static readonly MetadataFieldType Boolean = new(Values.Boolean);

    public static readonly MetadataFieldType Enum = new(Values.Enum);

    public MetadataFieldType(string value)
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
    public static MetadataFieldType FromCustom(string value)
    {
        return new MetadataFieldType(value);
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

    public static bool operator ==(MetadataFieldType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MetadataFieldType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MetadataFieldType value) => value.Value;

    public static explicit operator MetadataFieldType(string value) => new(value);

    internal class MetadataFieldTypeSerializer : JsonConverter<MetadataFieldType>
    {
        public override MetadataFieldType Read(
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
            return new MetadataFieldType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MetadataFieldType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MetadataFieldType ReadAsPropertyName(
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
            return new MetadataFieldType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MetadataFieldType value,
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
        public const string String = "STRING";

        public const string Integer = "INTEGER";

        public const string Double = "DOUBLE";

        public const string Boolean = "BOOLEAN";

        public const string Enum = "ENUM";
    }
}
