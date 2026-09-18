using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

[JsonConverter(typeof(RangeableStringMatchMode.RangeableStringMatchModeSerializer))]
[Serializable]
public readonly record struct RangeableStringMatchMode : IStringEnum
{
    public static readonly RangeableStringMatchMode Equals_ = new(Values.Equals_);

    public static readonly RangeableStringMatchMode NotEquals = new(Values.NotEquals);

    public static readonly RangeableStringMatchMode Contains = new(Values.Contains);

    public static readonly RangeableStringMatchMode NotContains = new(Values.NotContains);

    public static readonly RangeableStringMatchMode StartsWith = new(Values.StartsWith);

    public static readonly RangeableStringMatchMode EndsWith = new(Values.EndsWith);

    public static readonly RangeableStringMatchMode Between = new(Values.Between);

    public static readonly RangeableStringMatchMode NotBetween = new(Values.NotBetween);

    public RangeableStringMatchMode(string value)
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
    public static RangeableStringMatchMode FromCustom(string value)
    {
        return new RangeableStringMatchMode(value);
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

    public static bool operator ==(RangeableStringMatchMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RangeableStringMatchMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RangeableStringMatchMode value) => value.Value;

    public static explicit operator RangeableStringMatchMode(string value) => new(value);

    internal class RangeableStringMatchModeSerializer : JsonConverter<RangeableStringMatchMode>
    {
        public override RangeableStringMatchMode Read(
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
            return new RangeableStringMatchMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RangeableStringMatchMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RangeableStringMatchMode ReadAsPropertyName(
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
            return new RangeableStringMatchMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RangeableStringMatchMode value,
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

        public const string Between = "between";

        public const string NotBetween = "not_between";
    }
}
