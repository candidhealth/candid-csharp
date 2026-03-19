using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(
    typeof(OccurrenceInformationCodeQualifier.OccurrenceInformationCodeQualifierSerializer)
)]
[Serializable]
public readonly record struct OccurrenceInformationCodeQualifier : IStringEnum
{
    /// <summary>
    /// Occurrence
    /// </summary>
    public static readonly OccurrenceInformationCodeQualifier Cbh = new(Values.Cbh);

    public OccurrenceInformationCodeQualifier(string value)
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
    public static OccurrenceInformationCodeQualifier FromCustom(string value)
    {
        return new OccurrenceInformationCodeQualifier(value);
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

    public static bool operator ==(OccurrenceInformationCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OccurrenceInformationCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OccurrenceInformationCodeQualifier value) => value.Value;

    public static explicit operator OccurrenceInformationCodeQualifier(string value) => new(value);

    internal class OccurrenceInformationCodeQualifierSerializer
        : JsonConverter<OccurrenceInformationCodeQualifier>
    {
        public override OccurrenceInformationCodeQualifier Read(
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
            return new OccurrenceInformationCodeQualifier(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OccurrenceInformationCodeQualifier value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OccurrenceInformationCodeQualifier ReadAsPropertyName(
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
            return new OccurrenceInformationCodeQualifier(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OccurrenceInformationCodeQualifier value,
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
        /// <summary>
        /// Occurrence
        /// </summary>
        public const string Cbh = "BH";
    }
}
