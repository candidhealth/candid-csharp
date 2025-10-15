using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(StringEnumSerializer<AuthorizationUnit>))]
[Serializable]
public readonly record struct AuthorizationUnit : IStringEnum
{
    public static readonly AuthorizationUnit Visit = new(Values.Visit);

    public static readonly AuthorizationUnit Unit = new(Values.Unit);

    public AuthorizationUnit(string value)
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
    public static AuthorizationUnit FromCustom(string value)
    {
        return new AuthorizationUnit(value);
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

    public static bool operator ==(AuthorizationUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AuthorizationUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AuthorizationUnit value) => value.Value;

    public static explicit operator AuthorizationUnit(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Visit = "VISIT";

        public const string Unit = "UNIT";
    }
}
