using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<ValueCodeQualifier>))]
[Serializable]
public readonly record struct ValueCodeQualifier : IStringEnum
{
    /// <summary>
    /// Value
    /// </summary>
    public static readonly ValueCodeQualifier Cbe = new(Values.Cbe);

    public ValueCodeQualifier(string value)
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
    public static ValueCodeQualifier FromCustom(string value)
    {
        return new ValueCodeQualifier(value);
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

    public static bool operator ==(ValueCodeQualifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ValueCodeQualifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ValueCodeQualifier value) => value.Value;

    public static explicit operator ValueCodeQualifier(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Value
        /// </summary>
        public const string Cbe = "BE";
    }
}
