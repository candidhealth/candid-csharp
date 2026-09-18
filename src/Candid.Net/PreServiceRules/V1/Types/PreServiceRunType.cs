using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreServiceRules.V1;

[JsonConverter(typeof(PreServiceRunType.PreServiceRunTypeSerializer))]
[Serializable]
public readonly record struct PreServiceRunType : IStringEnum
{
    public static readonly PreServiceRunType Encounter = new(Values.Encounter);

    public static readonly PreServiceRunType Patient = new(Values.Patient);

    public PreServiceRunType(string value)
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
    public static PreServiceRunType FromCustom(string value)
    {
        return new PreServiceRunType(value);
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

    public static bool operator ==(PreServiceRunType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PreServiceRunType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PreServiceRunType value) => value.Value;

    public static explicit operator PreServiceRunType(string value) => new(value);

    internal class PreServiceRunTypeSerializer : JsonConverter<PreServiceRunType>
    {
        public override PreServiceRunType Read(
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
            return new PreServiceRunType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PreServiceRunType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PreServiceRunType ReadAsPropertyName(
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
            return new PreServiceRunType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PreServiceRunType value,
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
        public const string Encounter = "ENCOUNTER";

        public const string Patient = "PATIENT";
    }
}
