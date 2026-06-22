using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(StringEnumSerializer<InsuranceDiscoveryStatus>))]
[Serializable]
public readonly record struct InsuranceDiscoveryStatus : IStringEnum
{
    public static readonly InsuranceDiscoveryStatus Pending = new(Values.Pending);

    public static readonly InsuranceDiscoveryStatus Complete = new(Values.Complete);

    public InsuranceDiscoveryStatus(string value)
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
    public static InsuranceDiscoveryStatus FromCustom(string value)
    {
        return new InsuranceDiscoveryStatus(value);
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

    public static bool operator ==(InsuranceDiscoveryStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InsuranceDiscoveryStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InsuranceDiscoveryStatus value) => value.Value;

    public static explicit operator InsuranceDiscoveryStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pending = "PENDING";

        public const string Complete = "COMPLETE";
    }
}
