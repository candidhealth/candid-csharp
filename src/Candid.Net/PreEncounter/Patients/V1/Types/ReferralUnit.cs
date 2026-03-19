using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(ReferralUnit.ReferralUnitSerializer))]
[Serializable]
public readonly record struct ReferralUnit : IStringEnum
{
    public static readonly ReferralUnit Visit = new(Values.Visit);

    public static readonly ReferralUnit Unit = new(Values.Unit);

    public ReferralUnit(string value)
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
    public static ReferralUnit FromCustom(string value)
    {
        return new ReferralUnit(value);
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

    public static bool operator ==(ReferralUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReferralUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReferralUnit value) => value.Value;

    public static explicit operator ReferralUnit(string value) => new(value);

    internal class ReferralUnitSerializer : JsonConverter<ReferralUnit>
    {
        public override ReferralUnit Read(
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
            return new ReferralUnit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReferralUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReferralUnit ReadAsPropertyName(
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
            return new ReferralUnit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReferralUnit value,
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
        public const string Visit = "VISIT";

        public const string Unit = "UNIT";
    }
}
