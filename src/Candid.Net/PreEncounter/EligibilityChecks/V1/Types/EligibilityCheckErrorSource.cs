using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(StringEnumSerializer<EligibilityCheckErrorSource>))]
[Serializable]
public readonly record struct EligibilityCheckErrorSource : IStringEnum
{
    public static readonly EligibilityCheckErrorSource Candid = new(Values.Candid);

    public static readonly EligibilityCheckErrorSource Stedi = new(Values.Stedi);

    public EligibilityCheckErrorSource(string value)
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
    public static EligibilityCheckErrorSource FromCustom(string value)
    {
        return new EligibilityCheckErrorSource(value);
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

    public static bool operator ==(EligibilityCheckErrorSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EligibilityCheckErrorSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EligibilityCheckErrorSource value) => value.Value;

    public static explicit operator EligibilityCheckErrorSource(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Candid = "CANDID";

        public const string Stedi = "STEDI";
    }
}
