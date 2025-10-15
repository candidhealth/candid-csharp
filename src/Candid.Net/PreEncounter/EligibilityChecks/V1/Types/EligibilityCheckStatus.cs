using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(StringEnumSerializer<EligibilityCheckStatus>))]
[Serializable]
public readonly record struct EligibilityCheckStatus : IStringEnum
{
    public static readonly EligibilityCheckStatus Completed = new(Values.Completed);

    public static readonly EligibilityCheckStatus Failed = new(Values.Failed);

    public static readonly EligibilityCheckStatus Pending = new(Values.Pending);

    public EligibilityCheckStatus(string value)
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
    public static EligibilityCheckStatus FromCustom(string value)
    {
        return new EligibilityCheckStatus(value);
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

    public static bool operator ==(EligibilityCheckStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EligibilityCheckStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EligibilityCheckStatus value) => value.Value;

    public static explicit operator EligibilityCheckStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Completed = "COMPLETED";

        public const string Failed = "FAILED";

        public const string Pending = "PENDING";
    }
}
