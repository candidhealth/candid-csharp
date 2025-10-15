using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.OrganizationProviders.V2;

[JsonConverter(typeof(StringEnumSerializer<EmploymentStatus>))]
[Serializable]
public readonly record struct EmploymentStatus : IStringEnum
{
    public static readonly EmploymentStatus Active = new(Values.Active);

    public static readonly EmploymentStatus Terminated = new(Values.Terminated);

    public EmploymentStatus(string value)
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
    public static EmploymentStatus FromCustom(string value)
    {
        return new EmploymentStatus(value);
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

    public static bool operator ==(EmploymentStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmploymentStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmploymentStatus value) => value.Value;

    public static explicit operator EmploymentStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "ACTIVE";

        public const string Terminated = "TERMINATED";
    }
}
