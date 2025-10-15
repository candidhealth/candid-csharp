using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<ClaimSubmissionPayerResponsibilityType>))]
[Serializable]
public readonly record struct ClaimSubmissionPayerResponsibilityType : IStringEnum
{
    public static readonly ClaimSubmissionPayerResponsibilityType Primary = new(Values.Primary);

    public static readonly ClaimSubmissionPayerResponsibilityType Secondary = new(Values.Secondary);

    public ClaimSubmissionPayerResponsibilityType(string value)
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
    public static ClaimSubmissionPayerResponsibilityType FromCustom(string value)
    {
        return new ClaimSubmissionPayerResponsibilityType(value);
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

    public static bool operator ==(ClaimSubmissionPayerResponsibilityType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ClaimSubmissionPayerResponsibilityType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ClaimSubmissionPayerResponsibilityType value) =>
        value.Value;

    public static explicit operator ClaimSubmissionPayerResponsibilityType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Primary = "primary";

        public const string Secondary = "secondary";
    }
}
