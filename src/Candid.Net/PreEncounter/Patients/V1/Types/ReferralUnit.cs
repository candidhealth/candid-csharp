using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(StringEnumSerializer<ReferralUnit>))]
[Serializable]
public readonly record struct ReferralUnit : IStringEnum
{
    public static readonly ReferralUnit Visit = new(Values.Visit);

    public static readonly ReferralUnit Unit = new(Values.Unit);

    public ReferralUnit(string value)
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
    public static ReferralUnit FromCustom(string value)
    {
        return new ReferralUnit(value);
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

    public static bool operator ==(ReferralUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReferralUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReferralUnit value) => value.Value;

    public static explicit operator ReferralUnit(string value) => new(value);

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
