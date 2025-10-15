using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

[JsonConverter(typeof(StringEnumSerializer<LineOfBusiness>))]
[Serializable]
public readonly record struct LineOfBusiness : IStringEnum
{
    public static readonly LineOfBusiness Medicare = new(Values.Medicare);

    public static readonly LineOfBusiness Medicaid = new(Values.Medicaid);

    public static readonly LineOfBusiness Commercial = new(Values.Commercial);

    public LineOfBusiness(string value)
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
    public static LineOfBusiness FromCustom(string value)
    {
        return new LineOfBusiness(value);
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

    public static bool operator ==(LineOfBusiness value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LineOfBusiness value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LineOfBusiness value) => value.Value;

    public static explicit operator LineOfBusiness(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Medicare = "medicare";

        public const string Medicaid = "medicaid";

        public const string Commercial = "commercial";
    }
}
