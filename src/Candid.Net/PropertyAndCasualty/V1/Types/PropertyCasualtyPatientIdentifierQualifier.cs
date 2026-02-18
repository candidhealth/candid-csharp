using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PropertyAndCasualty.V1;

[JsonConverter(typeof(StringEnumSerializer<PropertyCasualtyPatientIdentifierQualifier>))]
[Serializable]
public readonly record struct PropertyCasualtyPatientIdentifierQualifier : IStringEnum
{
    /// <summary>
    /// Member Identification Number
    /// </summary>
    public static readonly PropertyCasualtyPatientIdentifierQualifier OneW = new(Values.OneW);

    /// <summary>
    /// Social Security Number
    /// </summary>
    public static readonly PropertyCasualtyPatientIdentifierQualifier Sy = new(Values.Sy);

    public PropertyCasualtyPatientIdentifierQualifier(string value)
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
    public static PropertyCasualtyPatientIdentifierQualifier FromCustom(string value)
    {
        return new PropertyCasualtyPatientIdentifierQualifier(value);
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
        PropertyCasualtyPatientIdentifierQualifier value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PropertyCasualtyPatientIdentifierQualifier value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PropertyCasualtyPatientIdentifierQualifier value) =>
        value.Value;

    public static explicit operator PropertyCasualtyPatientIdentifierQualifier(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Member Identification Number
        /// </summary>
        public const string OneW = "1W";

        /// <summary>
        /// Social Security Number
        /// </summary>
        public const string Sy = "SY";
    }
}
