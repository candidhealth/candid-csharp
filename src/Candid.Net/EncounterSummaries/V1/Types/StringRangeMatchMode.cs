using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

[JsonConverter(typeof(StringRangeMatchMode.StringRangeMatchModeSerializer))]
[Serializable]
public readonly record struct StringRangeMatchMode : IStringEnum
{
    public static readonly StringRangeMatchMode Between = new(Values.Between);

    public static readonly StringRangeMatchMode NotBetween = new(Values.NotBetween);

    public StringRangeMatchMode(string value)
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
    public static StringRangeMatchMode FromCustom(string value)
    {
        return new StringRangeMatchMode(value);
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

    public static bool operator ==(StringRangeMatchMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(StringRangeMatchMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(StringRangeMatchMode value) => value.Value;

    public static explicit operator StringRangeMatchMode(string value) => new(value);

    internal class StringRangeMatchModeSerializer : JsonConverter<StringRangeMatchMode>
    {
        public override StringRangeMatchMode Read(
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
            return new StringRangeMatchMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            StringRangeMatchMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override StringRangeMatchMode ReadAsPropertyName(
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
            return new StringRangeMatchMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            StringRangeMatchMode value,
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
