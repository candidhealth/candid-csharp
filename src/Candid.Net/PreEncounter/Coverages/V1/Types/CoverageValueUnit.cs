using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(CoverageValueUnit.CoverageValueUnitSerializer))]
[Serializable]
public readonly record struct CoverageValueUnit : IStringEnum
{
    public static readonly CoverageValueUnit Percent = new(Values.Percent);

    public static readonly CoverageValueUnit Currency = new(Values.Currency);

    public static readonly CoverageValueUnit Count = new(Values.Count);

    public CoverageValueUnit(string value)
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
    public static CoverageValueUnit FromCustom(string value)
    {
        return new CoverageValueUnit(value);
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

    public static bool operator ==(CoverageValueUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CoverageValueUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CoverageValueUnit value) => value.Value;

    public static explicit operator CoverageValueUnit(string value) => new(value);

    internal class CoverageValueUnitSerializer : JsonConverter<CoverageValueUnit>
    {
        public override CoverageValueUnit Read(
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
            return new CoverageValueUnit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CoverageValueUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CoverageValueUnit ReadAsPropertyName(
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
            return new CoverageValueUnit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CoverageValueUnit value,
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
        public const string Percent = "PERCENT";

        public const string Currency = "CURRENCY";

        public const string Count = "COUNT";
    }
}
