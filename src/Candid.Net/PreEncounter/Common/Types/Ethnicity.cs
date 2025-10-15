using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(StringEnumSerializer<Ethnicity>))]
[Serializable]
public readonly record struct Ethnicity : IStringEnum
{
    public static readonly Ethnicity HispanicOrLatino = new(Values.HispanicOrLatino);

    public static readonly Ethnicity NotHispanicOrLatino = new(Values.NotHispanicOrLatino);

    public static readonly Ethnicity Unknown = new(Values.Unknown);

    public static readonly Ethnicity Refused = new(Values.Refused);

    public Ethnicity(string value)
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
    public static Ethnicity FromCustom(string value)
    {
        return new Ethnicity(value);
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

    public static bool operator ==(Ethnicity value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(Ethnicity value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(Ethnicity value) => value.Value;

    public static explicit operator Ethnicity(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string HispanicOrLatino = "HISPANIC_OR_LATINO";

        public const string NotHispanicOrLatino = "NOT_HISPANIC_OR_LATINO";

        public const string Unknown = "UNKNOWN";

        public const string Refused = "REFUSED";
    }
}
