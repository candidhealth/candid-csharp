using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Credentialing.V2;

[JsonConverter(typeof(StringEnumSerializer<CredentialingSpanStatus>))]
[Serializable]
public readonly record struct CredentialingSpanStatus : IStringEnum
{
    public static readonly CredentialingSpanStatus WorkInProgress = new(Values.WorkInProgress);

    public static readonly CredentialingSpanStatus Pending = new(Values.Pending);

    public static readonly CredentialingSpanStatus Effective = new(Values.Effective);

    public static readonly CredentialingSpanStatus Expired = new(Values.Expired);

    public CredentialingSpanStatus(string value)
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
    public static CredentialingSpanStatus FromCustom(string value)
    {
        return new CredentialingSpanStatus(value);
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

    public static bool operator ==(CredentialingSpanStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CredentialingSpanStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CredentialingSpanStatus value) => value.Value;

    public static explicit operator CredentialingSpanStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string WorkInProgress = "work_in_progress";

        public const string Pending = "pending";

        public const string Effective = "effective";

        public const string Expired = "expired";
    }
}
