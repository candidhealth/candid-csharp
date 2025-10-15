using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(StringEnumSerializer<Sex>))]
[Serializable]
public readonly record struct Sex : IStringEnum
{
    public static readonly Sex Female = new(Values.Female);

    public static readonly Sex Male = new(Values.Male);

    public static readonly Sex Unknown = new(Values.Unknown);

    public static readonly Sex Refused = new(Values.Refused);

    public Sex(string value)
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
    public static Sex FromCustom(string value)
    {
        return new Sex(value);
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

    public static bool operator ==(Sex value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(Sex value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(Sex value) => value.Value;

    public static explicit operator Sex(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Female = "FEMALE";

        public const string Male = "MALE";

        public const string Unknown = "UNKNOWN";

        public const string Refused = "REFUSED";
    }
}
