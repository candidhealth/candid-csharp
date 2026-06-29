using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ChargeCapture.V1;

[JsonConverter(typeof(Hl7MessageType.Hl7MessageTypeSerializer))]
[Serializable]
public readonly record struct Hl7MessageType : IStringEnum
{
    public static readonly Hl7MessageType Bar = new(Values.Bar);

    public static readonly Hl7MessageType Dft = new(Values.Dft);

    public static readonly Hl7MessageType Adt = new(Values.Adt);

    public Hl7MessageType(string value)
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
    public static Hl7MessageType FromCustom(string value)
    {
        return new Hl7MessageType(value);
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

    public static bool operator ==(Hl7MessageType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(Hl7MessageType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(Hl7MessageType value) => value.Value;

    public static explicit operator Hl7MessageType(string value) => new(value);

    internal class Hl7MessageTypeSerializer : JsonConverter<Hl7MessageType>
    {
        public override Hl7MessageType Read(
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
            return new Hl7MessageType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            Hl7MessageType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override Hl7MessageType ReadAsPropertyName(
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
            return new Hl7MessageType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            Hl7MessageType value,
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
        public const string Bar = "BAR";

        public const string Dft = "DFT";

        public const string Adt = "ADT";
    }
}
