using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

[JsonConverter(typeof(IntRangeMatchMode.IntRangeMatchModeSerializer))]
[Serializable]
public readonly record struct IntRangeMatchMode : IStringEnum
{
    public static readonly IntRangeMatchMode Between = new(Values.Between);

    public static readonly IntRangeMatchMode NotBetween = new(Values.NotBetween);

    public IntRangeMatchMode(string value)
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
    public static IntRangeMatchMode FromCustom(string value)
    {
        return new IntRangeMatchMode(value);
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

    public static bool operator ==(IntRangeMatchMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IntRangeMatchMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IntRangeMatchMode value) => value.Value;

    public static explicit operator IntRangeMatchMode(string value) => new(value);

    internal class IntRangeMatchModeSerializer : JsonConverter<IntRangeMatchMode>
    {
        public override IntRangeMatchMode Read(
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
            return new IntRangeMatchMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            IntRangeMatchMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override IntRangeMatchMode ReadAsPropertyName(
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
            return new IntRangeMatchMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            IntRangeMatchMode value,
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
        public const string Between = "between";

        public const string NotBetween = "not_between";
    }
}
