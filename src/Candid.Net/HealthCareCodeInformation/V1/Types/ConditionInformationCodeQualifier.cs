using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(
    typeof(ConditionInformationCodeQualifier.ConditionInformationCodeQualifierSerializer)
)]
[Serializable]
public readonly record struct ConditionInformationCodeQualifier : IStringEnum
{
    /// <summary>
    /// Condition
    /// </summary>
    public static readonly ConditionInformationCodeQualifier Cbg = new(Values.Cbg);

    public ConditionInformationCodeQualifier(string value)
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
    public static ConditionInformationCodeQualifier FromCustom(string value)
    {
        return new ConditionInformationCodeQualifier(value);
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

    public static bool operator ==(ConditionInformationCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ConditionInformationCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ConditionInformationCodeQualifier value) => value.Value;

    public static explicit operator ConditionInformationCodeQualifier(string value) => new(value);

    internal class ConditionInformationCodeQualifierSerializer
        : JsonConverter<ConditionInformationCodeQualifier>
    {
        public override ConditionInformationCodeQualifier Read(
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
            return new ConditionInformationCodeQualifier(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ConditionInformationCodeQualifier value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ConditionInformationCodeQualifier ReadAsPropertyName(
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
            return new ConditionInformationCodeQualifier(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ConditionInformationCodeQualifier value,
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
        /// Condition
        /// </summary>
        public const string Cbg = "BG";
    }
}
