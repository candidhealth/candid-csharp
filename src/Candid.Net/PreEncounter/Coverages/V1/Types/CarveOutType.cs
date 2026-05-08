using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(StringEnumSerializer<CarveOutType>))]
[Serializable]
public readonly record struct CarveOutType : IStringEnum
{
    public static readonly CarveOutType Behavioral = new(Values.Behavioral);

    public static readonly CarveOutType Medical = new(Values.Medical);

    public static readonly CarveOutType Therapy = new(Values.Therapy);

    public CarveOutType(string value)
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
    public static CarveOutType FromCustom(string value)
    {
        return new CarveOutType(value);
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

    public static bool operator ==(CarveOutType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CarveOutType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CarveOutType value) => value.Value;

    public static explicit operator CarveOutType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Behavioral = "BEHAVIORAL";

        public const string Medical = "MEDICAL";

        public const string Therapy = "THERAPY";
    }
}
