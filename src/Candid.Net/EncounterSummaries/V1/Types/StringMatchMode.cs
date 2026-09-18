using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

[JsonConverter(typeof(StringMatchMode.StringMatchModeSerializer))]
[Serializable]
public readonly record struct StringMatchMode : IStringEnum
{
    public static readonly StringMatchMode Equals_ = new(Values.Equals_);

    public static readonly StringMatchMode NotEquals = new(Values.NotEquals);

    public static readonly StringMatchMode Contains = new(Values.Contains);

    public static readonly StringMatchMode NotContains = new(Values.NotContains);

    public static readonly StringMatchMode StartsWith = new(Values.StartsWith);

    public static readonly StringMatchMode EndsWith = new(Values.EndsWith);

    public StringMatchMode(string value)
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
    public static StringMatchMode FromCustom(string value)
    {
        return new StringMatchMode(value);
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

    public static bool operator ==(StringMatchMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(StringMatchMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(StringMatchMode value) => value.Value;

    public static explicit operator StringMatchMode(string value) => new(value);

    internal class StringMatchModeSerializer : JsonConverter<StringMatchMode>
    {
        public override StringMatchMode Read(
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
            return new StringMatchMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            StringMatchMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override StringMatchMode ReadAsPropertyName(
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
            return new StringMatchMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            StringMatchMode value,
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
        public const string Equals_ = "equals";

        public const string NotEquals = "not_equals";

        public const string Contains = "contains";

        public const string NotContains = "not_contains";

        public const string StartsWith = "starts_with";

        public const string EndsWith = "ends_with";
    }
}
