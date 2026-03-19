using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(PatientHistoryCategoryEnum.PatientHistoryCategoryEnumSerializer))]
[Serializable]
public readonly record struct PatientHistoryCategoryEnum : IStringEnum
{
    public static readonly PatientHistoryCategoryEnum PresentIllness = new(Values.PresentIllness);

    public static readonly PatientHistoryCategoryEnum Medical = new(Values.Medical);

    public static readonly PatientHistoryCategoryEnum Family = new(Values.Family);

    public static readonly PatientHistoryCategoryEnum Social = new(Values.Social);

    public PatientHistoryCategoryEnum(string value)
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
    public static PatientHistoryCategoryEnum FromCustom(string value)
    {
        return new PatientHistoryCategoryEnum(value);
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

    public static bool operator ==(PatientHistoryCategoryEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientHistoryCategoryEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientHistoryCategoryEnum value) => value.Value;

    public static explicit operator PatientHistoryCategoryEnum(string value) => new(value);

    internal class PatientHistoryCategoryEnumSerializer : JsonConverter<PatientHistoryCategoryEnum>
    {
        public override PatientHistoryCategoryEnum Read(
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
            return new PatientHistoryCategoryEnum(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PatientHistoryCategoryEnum value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PatientHistoryCategoryEnum ReadAsPropertyName(
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
            return new PatientHistoryCategoryEnum(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PatientHistoryCategoryEnum value,
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
        public const string PresentIllness = "present_illness";

        public const string Medical = "medical";

        public const string Family = "family";

        public const string Social = "social";
    }
}
