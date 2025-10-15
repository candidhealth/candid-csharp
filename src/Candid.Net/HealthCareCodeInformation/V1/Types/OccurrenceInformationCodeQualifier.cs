using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<OccurrenceInformationCodeQualifier>))]
[Serializable]
public readonly record struct OccurrenceInformationCodeQualifier : IStringEnum
{
    /// <summary>
    /// Occurrence
    /// </summary>
    public static readonly OccurrenceInformationCodeQualifier Cbh = new(Values.Cbh);

    public OccurrenceInformationCodeQualifier(string value)
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
    public static OccurrenceInformationCodeQualifier FromCustom(string value)
    {
        return new OccurrenceInformationCodeQualifier(value);
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

    public static bool operator ==(OccurrenceInformationCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OccurrenceInformationCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OccurrenceInformationCodeQualifier value) => value.Value;

    public static explicit operator OccurrenceInformationCodeQualifier(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Occurrence
        /// </summary>
        public const string Cbh = "BH";
    }
}
