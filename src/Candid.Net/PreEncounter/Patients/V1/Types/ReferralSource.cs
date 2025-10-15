using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(StringEnumSerializer<ReferralSource>))]
[Serializable]
public readonly record struct ReferralSource : IStringEnum
{
    public static readonly ReferralSource Hospital = new(Values.Hospital);

    public static readonly ReferralSource ReferringMd = new(Values.ReferringMd);

    public static readonly ReferralSource Self = new(Values.Self);

    public static readonly ReferralSource Other = new(Values.Other);

    public ReferralSource(string value)
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
    public static ReferralSource FromCustom(string value)
    {
        return new ReferralSource(value);
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

    public static bool operator ==(ReferralSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReferralSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReferralSource value) => value.Value;

    public static explicit operator ReferralSource(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Hospital = "HOSPITAL";

        public const string ReferringMd = "REFERRING_MD";

        public const string Self = "SELF";

        public const string Other = "OTHER";
    }
}
