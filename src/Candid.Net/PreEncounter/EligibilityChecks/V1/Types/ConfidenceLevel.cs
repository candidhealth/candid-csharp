using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(ConfidenceLevel.ConfidenceLevelSerializer))]
[Serializable]
public readonly record struct ConfidenceLevel : IStringEnum
{
    public static readonly ConfidenceLevel ReviewNeeded = new(Values.ReviewNeeded);

    public static readonly ConfidenceLevel High = new(Values.High);

    public ConfidenceLevel(string value)
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
    public static ConfidenceLevel FromCustom(string value)
    {
        return new ConfidenceLevel(value);
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

    public static bool operator ==(ConfidenceLevel value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ConfidenceLevel value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ConfidenceLevel value) => value.Value;

    public static explicit operator ConfidenceLevel(string value) => new(value);

    internal class ConfidenceLevelSerializer : JsonConverter<ConfidenceLevel>
    {
        public override ConfidenceLevel Read(
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
            return new ConfidenceLevel(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ConfidenceLevel value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ConfidenceLevel ReadAsPropertyName(
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
            return new ConfidenceLevel(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ConfidenceLevel value,
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
        public const string ReviewNeeded = "REVIEW_NEEDED";

        public const string High = "HIGH";
    }
}
