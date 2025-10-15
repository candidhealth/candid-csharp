using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<DiagnosisRelatedGroupCodeQualifier>))]
[Serializable]
public readonly record struct DiagnosisRelatedGroupCodeQualifier : IStringEnum
{
    /// <summary>
    /// Diagnosis Related Group (DRG)
    /// </summary>
    public static readonly DiagnosisRelatedGroupCodeQualifier Cdr = new(Values.Cdr);

    public DiagnosisRelatedGroupCodeQualifier(string value)
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
    public static DiagnosisRelatedGroupCodeQualifier FromCustom(string value)
    {
        return new DiagnosisRelatedGroupCodeQualifier(value);
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

    public static bool operator ==(DiagnosisRelatedGroupCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DiagnosisRelatedGroupCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DiagnosisRelatedGroupCodeQualifier value) => value.Value;

    public static explicit operator DiagnosisRelatedGroupCodeQualifier(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Diagnosis Related Group (DRG)
        /// </summary>
        public const string Cdr = "DR";
    }
}
