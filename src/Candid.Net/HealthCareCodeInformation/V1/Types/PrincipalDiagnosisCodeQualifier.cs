using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<PrincipalDiagnosisCodeQualifier>))]
[Serializable]
public readonly record struct PrincipalDiagnosisCodeQualifier : IStringEnum
{
    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-9-CM) Principal Diagnosis
    /// </summary>
    public static readonly PrincipalDiagnosisCodeQualifier Cbk = new(Values.Cbk);

    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-10-CM) Principal Diagnosis
    /// </summary>
    public static readonly PrincipalDiagnosisCodeQualifier Cabk = new(Values.Cabk);

    public PrincipalDiagnosisCodeQualifier(string value)
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
    public static PrincipalDiagnosisCodeQualifier FromCustom(string value)
    {
        return new PrincipalDiagnosisCodeQualifier(value);
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

    public static bool operator ==(PrincipalDiagnosisCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PrincipalDiagnosisCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PrincipalDiagnosisCodeQualifier value) => value.Value;

    public static explicit operator PrincipalDiagnosisCodeQualifier(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// International Classification of Diseases Clinical Modification (ICD-9-CM) Principal Diagnosis
        /// </summary>
        public const string Cbk = "BK";

        /// <summary>
        /// International Classification of Diseases Clinical Modification (ICD-10-CM) Principal Diagnosis
        /// </summary>
        public const string Cabk = "ABK";
    }
}
