using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.ServiceLines.V2;

[JsonConverter(typeof(MeasurementUnitCode.MeasurementUnitCodeSerializer))]
[Serializable]
public readonly record struct MeasurementUnitCode : IStringEnum
{
    public static readonly MeasurementUnitCode Milliliters = new(Values.Milliliters);

    public static readonly MeasurementUnitCode Units = new(Values.Units);

    public static readonly MeasurementUnitCode Grams = new(Values.Grams);

    public static readonly MeasurementUnitCode InternationalUnit = new(Values.InternationalUnit);

    public static readonly MeasurementUnitCode Milligram = new(Values.Milligram);

    public MeasurementUnitCode(string value)
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
    public static MeasurementUnitCode FromCustom(string value)
    {
        return new MeasurementUnitCode(value);
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

    public static bool operator ==(MeasurementUnitCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MeasurementUnitCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MeasurementUnitCode value) => value.Value;

    public static explicit operator MeasurementUnitCode(string value) => new(value);

    internal class MeasurementUnitCodeSerializer : JsonConverter<MeasurementUnitCode>
    {
        public override MeasurementUnitCode Read(
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
            return new MeasurementUnitCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MeasurementUnitCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MeasurementUnitCode ReadAsPropertyName(
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
            return new MeasurementUnitCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MeasurementUnitCode value,
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
        public const string Milliliters = "ML";

        public const string Units = "UN";

        public const string Grams = "GR";

        public const string InternationalUnit = "F2";

        public const string Milligram = "ME";
    }
}
