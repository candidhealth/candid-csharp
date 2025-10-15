using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Financials;

[JsonConverter(typeof(StringEnumSerializer<RefundReason>))]
[Serializable]
public readonly record struct RefundReason : IStringEnum
{
    public static readonly RefundReason Overcharged = new(Values.Overcharged);

    public RefundReason(string value)
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
    public static RefundReason FromCustom(string value)
    {
        return new RefundReason(value);
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

    public static bool operator ==(RefundReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RefundReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RefundReason value) => value.Value;

    public static explicit operator RefundReason(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Overcharged = "OVERCHARGED";
    }
}
