using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Payers.V4;

[JsonConverter(typeof(StringEnumSerializer<SupportState>))]
[Serializable]
public readonly record struct SupportState : IStringEnum
{
    public static readonly SupportState NotSupported = new(Values.NotSupported);

    public static readonly SupportState SupportedEnrollmentNotRequired = new(
        Values.SupportedEnrollmentNotRequired
    );

    public static readonly SupportState SupportedEnrollmentRequired = new(
        Values.SupportedEnrollmentRequired
    );

    public SupportState(string value)
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
    public static SupportState FromCustom(string value)
    {
        return new SupportState(value);
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

    public static bool operator ==(SupportState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SupportState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SupportState value) => value.Value;

    public static explicit operator SupportState(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NotSupported = "NOT_SUPPORTED";

        public const string SupportedEnrollmentNotRequired = "SUPPORTED_ENROLLMENT_NOT_REQUIRED";

        public const string SupportedEnrollmentRequired = "SUPPORTED_ENROLLMENT_REQUIRED";
    }
}
