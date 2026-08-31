using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Dashboarding.V1;

[JsonConverter(typeof(MetricSnapshot.MetricSnapshotSerializer))]
[Serializable]
public readonly record struct MetricSnapshot : IStringEnum
{
    public static readonly MetricSnapshot Today = new(Values.Today);

    public static readonly MetricSnapshot Yesterday = new(Values.Yesterday);

    public MetricSnapshot(string value)
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
    public static MetricSnapshot FromCustom(string value)
    {
        return new MetricSnapshot(value);
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

    public static bool operator ==(MetricSnapshot value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MetricSnapshot value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MetricSnapshot value) => value.Value;

    public static explicit operator MetricSnapshot(string value) => new(value);

    internal class MetricSnapshotSerializer : JsonConverter<MetricSnapshot>
    {
        public override MetricSnapshot Read(
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
            return new MetricSnapshot(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MetricSnapshot value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MetricSnapshot ReadAsPropertyName(
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
            return new MetricSnapshot(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MetricSnapshot value,
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
        public const string Today = "today";

        public const string Yesterday = "yesterday";
    }
}
