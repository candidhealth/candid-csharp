using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<TreatmentCodeQualifier>))]
[Serializable]
public readonly record struct TreatmentCodeQualifier : IStringEnum
{
    /// <summary>
    /// Treatment Codes
    /// </summary>
    public static readonly TreatmentCodeQualifier Ctc = new(Values.Ctc);

    public TreatmentCodeQualifier(string value)
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
    public static TreatmentCodeQualifier FromCustom(string value)
    {
        return new TreatmentCodeQualifier(value);
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

    public static bool operator ==(TreatmentCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TreatmentCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TreatmentCodeQualifier value) => value.Value;

    public static explicit operator TreatmentCodeQualifier(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Treatment Codes
        /// </summary>
        public const string Ctc = "TC";
    }
}
