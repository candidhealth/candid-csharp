using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

[JsonConverter(typeof(UuidSetMatchMode.UuidSetMatchModeSerializer))]
[Serializable]
public readonly record struct UuidSetMatchMode : IStringEnum
{
    public static readonly UuidSetMatchMode In = new(Values.In);

    public static readonly UuidSetMatchMode NotIn = new(Values.NotIn);

    public UuidSetMatchMode(string value)
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
    public static UuidSetMatchMode FromCustom(string value)
    {
        return new UuidSetMatchMode(value);
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

    public static bool operator ==(UuidSetMatchMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UuidSetMatchMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UuidSetMatchMode value) => value.Value;

    public static explicit operator UuidSetMatchMode(string value) => new(value);

    internal class UuidSetMatchModeSerializer : JsonConverter<UuidSetMatchMode>
    {
        public override UuidSetMatchMode Read(
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
            return new UuidSetMatchMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UuidSetMatchMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UuidSetMatchMode ReadAsPropertyName(
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
            return new UuidSetMatchMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UuidSetMatchMode value,
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
        public const string In = "in";

        public const string NotIn = "not_in";
    }
}
