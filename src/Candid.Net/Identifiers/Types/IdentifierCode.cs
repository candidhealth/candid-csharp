using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Identifiers;

[JsonConverter(typeof(IdentifierCode.IdentifierCodeSerializer))]
[Serializable]
public readonly record struct IdentifierCode : IStringEnum
{
    public static readonly IdentifierCode Mcr = new(Values.Mcr);

    public static readonly IdentifierCode Mcd = new(Values.Mcd);

    public IdentifierCode(string value)
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
    public static IdentifierCode FromCustom(string value)
    {
        return new IdentifierCode(value);
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

    public static bool operator ==(IdentifierCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IdentifierCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IdentifierCode value) => value.Value;

    public static explicit operator IdentifierCode(string value) => new(value);

    internal class IdentifierCodeSerializer : JsonConverter<IdentifierCode>
    {
        public override IdentifierCode Read(
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
            return new IdentifierCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            IdentifierCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override IdentifierCode ReadAsPropertyName(
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
            return new IdentifierCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            IdentifierCode value,
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
        public const string Mcr = "MCR";

        public const string Mcd = "MCD";
    }
}
