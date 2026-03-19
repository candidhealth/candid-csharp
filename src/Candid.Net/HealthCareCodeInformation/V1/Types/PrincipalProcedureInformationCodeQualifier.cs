using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(
    typeof(PrincipalProcedureInformationCodeQualifier.PrincipalProcedureInformationCodeQualifierSerializer)
)]
[Serializable]
public readonly record struct PrincipalProcedureInformationCodeQualifier : IStringEnum
{
    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-10-PCS) Principal Procedure Codes
    /// </summary>
    public static readonly PrincipalProcedureInformationCodeQualifier Cbbr = new(Values.Cbbr);

    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-9-CM) Principal Procedure Codes
    /// </summary>
    public static readonly PrincipalProcedureInformationCodeQualifier Cbr = new(Values.Cbr);

    /// <summary>
    /// Advanced Billing Concepts (ABC) Codes
    /// </summary>
    public static readonly PrincipalProcedureInformationCodeQualifier Ccah = new(Values.Ccah);

    public PrincipalProcedureInformationCodeQualifier(string value)
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
    public static PrincipalProcedureInformationCodeQualifier FromCustom(string value)
    {
        return new PrincipalProcedureInformationCodeQualifier(value);
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

    public static bool operator ==(
        PrincipalProcedureInformationCodeQualifier value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PrincipalProcedureInformationCodeQualifier value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PrincipalProcedureInformationCodeQualifier value) =>
        value.Value;

    public static explicit operator PrincipalProcedureInformationCodeQualifier(string value) =>
        new(value);

    internal class PrincipalProcedureInformationCodeQualifierSerializer
        : JsonConverter<PrincipalProcedureInformationCodeQualifier>
    {
        public override PrincipalProcedureInformationCodeQualifier Read(
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
            return new PrincipalProcedureInformationCodeQualifier(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PrincipalProcedureInformationCodeQualifier value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PrincipalProcedureInformationCodeQualifier ReadAsPropertyName(
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
            return new PrincipalProcedureInformationCodeQualifier(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PrincipalProcedureInformationCodeQualifier value,
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
        /// International Classification of Diseases Clinical Modification (ICD-10-PCS) Principal Procedure Codes
        /// </summary>
        public const string Cbbr = "BBR";

        /// <summary>
        /// International Classification of Diseases Clinical Modification (ICD-9-CM) Principal Procedure Codes
        /// </summary>
        public const string Cbr = "BR";

        /// <summary>
        /// Advanced Billing Concepts (ABC) Codes
        /// </summary>
        public const string Ccah = "CAH";
    }
}
