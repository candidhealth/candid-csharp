using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(StringEnumSerializer<ReferralType>))]
[Serializable]
public readonly record struct ReferralType : IStringEnum
{
    public static readonly ReferralType Directed = new(Values.Directed);

    public static readonly ReferralType Rotation = new(Values.Rotation);

    public static readonly ReferralType Overnight = new(Values.Overnight);

    public ReferralType(string value)
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
    public static ReferralType FromCustom(string value)
    {
        return new ReferralType(value);
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

    public static bool operator ==(ReferralType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReferralType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReferralType value) => value.Value;

    public static explicit operator ReferralType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Directed = "DIRECTED";

        public const string Rotation = "ROTATION";

        public const string Overnight = "OVERNIGHT";
    }
}
