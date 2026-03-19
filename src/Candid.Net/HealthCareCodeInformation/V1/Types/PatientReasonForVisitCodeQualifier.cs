using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(
    typeof(PatientReasonForVisitCodeQualifier.PatientReasonForVisitCodeQualifierSerializer)
)]
[Serializable]
public readonly record struct PatientReasonForVisitCodeQualifier : IStringEnum
{
    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-9-CM) Patient's Reason for Visit
    /// </summary>
    public static readonly PatientReasonForVisitCodeQualifier Cpr = new(Values.Cpr);

    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-10-CM) Patient's Reason for Visit
    /// </summary>
    public static readonly PatientReasonForVisitCodeQualifier Capr = new(Values.Capr);

    public PatientReasonForVisitCodeQualifier(string value)
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
    public static PatientReasonForVisitCodeQualifier FromCustom(string value)
    {
        return new PatientReasonForVisitCodeQualifier(value);
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

    public static bool operator ==(PatientReasonForVisitCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientReasonForVisitCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientReasonForVisitCodeQualifier value) => value.Value;

    public static explicit operator PatientReasonForVisitCodeQualifier(string value) => new(value);

    internal class PatientReasonForVisitCodeQualifierSerializer
        : JsonConverter<PatientReasonForVisitCodeQualifier>
    {
        public override PatientReasonForVisitCodeQualifier Read(
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
            return new PatientReasonForVisitCodeQualifier(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PatientReasonForVisitCodeQualifier value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PatientReasonForVisitCodeQualifier ReadAsPropertyName(
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
            return new PatientReasonForVisitCodeQualifier(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PatientReasonForVisitCodeQualifier value,
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
        /// International Classification of Diseases Clinical Modification (ICD-9-CM) Patient's Reason for Visit
        /// </summary>
        public const string Cpr = "PR";

        /// <summary>
        /// International Classification of Diseases Clinical Modification (ICD-10-CM) Patient's Reason for Visit
        /// </summary>
        public const string Capr = "APR";
    }
}
