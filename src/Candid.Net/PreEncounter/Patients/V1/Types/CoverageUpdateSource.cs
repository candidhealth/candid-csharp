using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(CoverageUpdateSource.CoverageUpdateSourceSerializer))]
[Serializable]
public readonly record struct CoverageUpdateSource : IStringEnum
{
    public static readonly CoverageUpdateSource EligibilityCheck = new(Values.EligibilityCheck);

    public static readonly CoverageUpdateSource Manual = new(Values.Manual);

    public static readonly CoverageUpdateSource Unknown = new(Values.Unknown);

    public CoverageUpdateSource(string value)
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
    public static CoverageUpdateSource FromCustom(string value)
    {
        return new CoverageUpdateSource(value);
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

    public static bool operator ==(CoverageUpdateSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CoverageUpdateSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CoverageUpdateSource value) => value.Value;

    public static explicit operator CoverageUpdateSource(string value) => new(value);

    internal class CoverageUpdateSourceSerializer : JsonConverter<CoverageUpdateSource>
    {
        public override CoverageUpdateSource Read(
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
            return new CoverageUpdateSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CoverageUpdateSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CoverageUpdateSource ReadAsPropertyName(
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
            return new CoverageUpdateSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CoverageUpdateSource value,
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
        public const string EligibilityCheck = "eligibility_check";

        public const string Manual = "manual";

        public const string Unknown = "unknown";
    }
}
