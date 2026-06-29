using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(CarveOutType.CarveOutTypeSerializer))]
[Serializable]
public readonly record struct CarveOutType : IStringEnum
{
    public static readonly CarveOutType Behavioral = new(Values.Behavioral);

    public static readonly CarveOutType Medical = new(Values.Medical);

    public static readonly CarveOutType Therapy = new(Values.Therapy);

    public CarveOutType(string value)
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
    public static CarveOutType FromCustom(string value)
    {
        return new CarveOutType(value);
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

    public static bool operator ==(CarveOutType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CarveOutType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CarveOutType value) => value.Value;

    public static explicit operator CarveOutType(string value) => new(value);

    internal class CarveOutTypeSerializer : JsonConverter<CarveOutType>
    {
        public override CarveOutType Read(
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
            return new CarveOutType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CarveOutType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CarveOutType ReadAsPropertyName(
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
            return new CarveOutType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CarveOutType value,
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
        public const string Behavioral = "BEHAVIORAL";

        public const string Medical = "MEDICAL";

        public const string Therapy = "THERAPY";
    }
}
