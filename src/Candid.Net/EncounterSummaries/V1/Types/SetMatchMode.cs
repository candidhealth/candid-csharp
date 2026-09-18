using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

[JsonConverter(typeof(SetMatchMode.SetMatchModeSerializer))]
[Serializable]
public readonly record struct SetMatchMode : IStringEnum
{
    public static readonly SetMatchMode In = new(Values.In);

    public static readonly SetMatchMode NotIn = new(Values.NotIn);

    public SetMatchMode(string value)
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
    public static SetMatchMode FromCustom(string value)
    {
        return new SetMatchMode(value);
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

    public static bool operator ==(SetMatchMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SetMatchMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SetMatchMode value) => value.Value;

    public static explicit operator SetMatchMode(string value) => new(value);

    internal class SetMatchModeSerializer : JsonConverter<SetMatchMode>
    {
        public override SetMatchMode Read(
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
            return new SetMatchMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SetMatchMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SetMatchMode ReadAsPropertyName(
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
            return new SetMatchMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SetMatchMode value,
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
