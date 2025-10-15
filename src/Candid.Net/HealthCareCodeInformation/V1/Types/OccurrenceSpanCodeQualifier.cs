using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<OccurrenceSpanCodeQualifier>))]
[Serializable]
public readonly record struct OccurrenceSpanCodeQualifier : IStringEnum
{
    /// <summary>
    /// Occurrence Span
    /// </summary>
    public static readonly OccurrenceSpanCodeQualifier Cbi = new(Values.Cbi);

    public OccurrenceSpanCodeQualifier(string value)
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
    public static OccurrenceSpanCodeQualifier FromCustom(string value)
    {
        return new OccurrenceSpanCodeQualifier(value);
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

    public static bool operator ==(OccurrenceSpanCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OccurrenceSpanCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OccurrenceSpanCodeQualifier value) => value.Value;

    public static explicit operator OccurrenceSpanCodeQualifier(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Occurrence Span
        /// </summary>
        public const string Cbi = "BI";
    }
}
