using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<OtherDiagnosisInformationCodeQualifier>))]
[Serializable]
public readonly record struct OtherDiagnosisInformationCodeQualifier : IStringEnum
{
    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-9-CM) Diagnosis
    /// </summary>
    public static readonly OtherDiagnosisInformationCodeQualifier Cbf = new(Values.Cbf);

    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-10-CM) Diagnosis
    /// </summary>
    public static readonly OtherDiagnosisInformationCodeQualifier Cabf = new(Values.Cabf);

    public OtherDiagnosisInformationCodeQualifier(string value)
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
    public static OtherDiagnosisInformationCodeQualifier FromCustom(string value)
    {
        return new OtherDiagnosisInformationCodeQualifier(value);
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

    public static bool operator ==(OtherDiagnosisInformationCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OtherDiagnosisInformationCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OtherDiagnosisInformationCodeQualifier value) =>
        value.Value;

    public static explicit operator OtherDiagnosisInformationCodeQualifier(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// International Classification of Diseases Clinical Modification (ICD-9-CM) Diagnosis
        /// </summary>
        public const string Cbf = "BF";

        /// <summary>
        /// International Classification of Diseases Clinical Modification (ICD-10-CM) Diagnosis
        /// </summary>
        public const string Cabf = "ABF";
    }
}
