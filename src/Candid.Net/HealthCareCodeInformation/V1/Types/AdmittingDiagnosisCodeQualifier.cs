using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<AdmittingDiagnosisCodeQualifier>))]
[Serializable]
public readonly record struct AdmittingDiagnosisCodeQualifier : IStringEnum
{
    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-9-CM) Admitting Diagnosis
    /// </summary>
    public static readonly AdmittingDiagnosisCodeQualifier Cbj = new(Values.Cbj);

    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-10-CM) Admitting Diagnosis
    /// </summary>
    public static readonly AdmittingDiagnosisCodeQualifier Cabj = new(Values.Cabj);

    public AdmittingDiagnosisCodeQualifier(string value)
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
    public static AdmittingDiagnosisCodeQualifier FromCustom(string value)
    {
        return new AdmittingDiagnosisCodeQualifier(value);
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

    public static bool operator ==(AdmittingDiagnosisCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AdmittingDiagnosisCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AdmittingDiagnosisCodeQualifier value) => value.Value;

    public static explicit operator AdmittingDiagnosisCodeQualifier(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// International Classification of Diseases Clinical Modification (ICD-9-CM) Admitting Diagnosis
        /// </summary>
        public const string Cbj = "BJ";

        /// <summary>
        /// International Classification of Diseases Clinical Modification (ICD-10-CM) Admitting Diagnosis
        /// </summary>
        public const string Cabj = "ABJ";
    }
}
