using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Superbills.V1;

[JsonConverter(typeof(SuperbillOutputFormat.SuperbillOutputFormatSerializer))]
[Serializable]
public readonly record struct SuperbillOutputFormat : IStringEnum
{
    public static readonly SuperbillOutputFormat Docx = new(Values.Docx);

    public static readonly SuperbillOutputFormat Pdf = new(Values.Pdf);

    public SuperbillOutputFormat(string value)
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
    public static SuperbillOutputFormat FromCustom(string value)
    {
        return new SuperbillOutputFormat(value);
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

    public static bool operator ==(SuperbillOutputFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SuperbillOutputFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SuperbillOutputFormat value) => value.Value;

    public static explicit operator SuperbillOutputFormat(string value) => new(value);

    internal class SuperbillOutputFormatSerializer : JsonConverter<SuperbillOutputFormat>
    {
        public override SuperbillOutputFormat Read(
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
            return new SuperbillOutputFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SuperbillOutputFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SuperbillOutputFormat ReadAsPropertyName(
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
            return new SuperbillOutputFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SuperbillOutputFormat value,
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
        public const string Docx = "DOCX";

        public const string Pdf = "PDF";
    }
}
