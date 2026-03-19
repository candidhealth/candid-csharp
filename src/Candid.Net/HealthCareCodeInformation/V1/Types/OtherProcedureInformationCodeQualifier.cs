using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(
    typeof(OtherProcedureInformationCodeQualifier.OtherProcedureInformationCodeQualifierSerializer)
)]
[Serializable]
public readonly record struct OtherProcedureInformationCodeQualifier : IStringEnum
{
    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-10-PCS) Other Procedure Codes
    /// </summary>
    public static readonly OtherProcedureInformationCodeQualifier Cbbq = new(Values.Cbbq);

    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-9-CM) Other Procedure Codes
    /// </summary>
    public static readonly OtherProcedureInformationCodeQualifier Cbq = new(Values.Cbq);

    public OtherProcedureInformationCodeQualifier(string value)
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
    public static OtherProcedureInformationCodeQualifier FromCustom(string value)
    {
        return new OtherProcedureInformationCodeQualifier(value);
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

    public static bool operator ==(OtherProcedureInformationCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OtherProcedureInformationCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OtherProcedureInformationCodeQualifier value) =>
        value.Value;

    public static explicit operator OtherProcedureInformationCodeQualifier(string value) =>
        new(value);

    internal class OtherProcedureInformationCodeQualifierSerializer
        : JsonConverter<OtherProcedureInformationCodeQualifier>
    {
        public override OtherProcedureInformationCodeQualifier Read(
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
            return new OtherProcedureInformationCodeQualifier(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OtherProcedureInformationCodeQualifier value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OtherProcedureInformationCodeQualifier ReadAsPropertyName(
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
            return new OtherProcedureInformationCodeQualifier(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OtherProcedureInformationCodeQualifier value,
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
        /// International Classification of Diseases Clinical Modification (ICD-10-PCS) Other Procedure Codes
        /// </summary>
        public const string Cbbq = "BBQ";

        /// <summary>
        /// International Classification of Diseases Clinical Modification (ICD-9-CM) Other Procedure Codes
        /// </summary>
        public const string Cbq = "BQ";
    }
}
