using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(ReadySource.ReadySourceSerializer))]
[Serializable]
public readonly record struct ReadySource : IStringEnum
{
    public static readonly ReadySource Manual = new(Values.Manual);

    public static readonly ReadySource Machine = new(Values.Machine);

    public ReadySource(string value)
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
    public static ReadySource FromCustom(string value)
    {
        return new ReadySource(value);
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

    public static bool operator ==(ReadySource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReadySource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReadySource value) => value.Value;

    public static explicit operator ReadySource(string value) => new(value);

    internal class ReadySourceSerializer : JsonConverter<ReadySource>
    {
        public override ReadySource Read(
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
            return new ReadySource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReadySource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReadySource ReadAsPropertyName(
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
            return new ReadySource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReadySource value,
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
        public const string Manual = "MANUAL";

        public const string Machine = "MACHINE";
    }
}
