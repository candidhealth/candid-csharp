using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<ExternalCauseOfInjuryCodeQualifier>))]
[Serializable]
public readonly record struct ExternalCauseOfInjuryCodeQualifier : IStringEnum
{
    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-9-CM) External Cause of Injury Code (E-codes)
    /// </summary>
    public static readonly ExternalCauseOfInjuryCodeQualifier Cbn = new(Values.Cbn);

    /// <summary>
    /// International Classification of Diseases Clinical Modification (ICD-10-CM) External Cause of Injury Code
    /// </summary>
    public static readonly ExternalCauseOfInjuryCodeQualifier Cabn = new(Values.Cabn);

    public ExternalCauseOfInjuryCodeQualifier(string value)
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
    public static ExternalCauseOfInjuryCodeQualifier FromCustom(string value)
    {
        return new ExternalCauseOfInjuryCodeQualifier(value);
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

    public static bool operator ==(ExternalCauseOfInjuryCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ExternalCauseOfInjuryCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ExternalCauseOfInjuryCodeQualifier value) => value.Value;

    public static explicit operator ExternalCauseOfInjuryCodeQualifier(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// International Classification of Diseases Clinical Modification (ICD-9-CM) External Cause of Injury Code (E-codes)
        /// </summary>
        public const string Cbn = "BN";

        /// <summary>
        /// International Classification of Diseases Clinical Modification (ICD-10-CM) External Cause of Injury Code
        /// </summary>
        public const string Cabn = "ABN";
    }
}
