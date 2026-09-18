using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(CoverageType.CoverageTypeSerializer))]
[Serializable]
public readonly record struct CoverageType : IStringEnum
{
    public static readonly CoverageType Primary = new(Values.Primary);

    public static readonly CoverageType Secondary = new(Values.Secondary);

    public static readonly CoverageType Tertiary = new(Values.Tertiary);

    public CoverageType(string value)
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
    public static CoverageType FromCustom(string value)
    {
        return new CoverageType(value);
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

    public static bool operator ==(CoverageType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CoverageType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CoverageType value) => value.Value;

    public static explicit operator CoverageType(string value) => new(value);

    internal class CoverageTypeSerializer : JsonConverter<CoverageType>
    {
        public override CoverageType Read(
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
            return new CoverageType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CoverageType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CoverageType ReadAsPropertyName(
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
            return new CoverageType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CoverageType value,
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
        public const string Primary = "primary";

        public const string Secondary = "secondary";

        public const string Tertiary = "tertiary";
    }
}
