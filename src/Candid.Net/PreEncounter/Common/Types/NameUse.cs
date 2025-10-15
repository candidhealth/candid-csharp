using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(StringEnumSerializer<NameUse>))]
[Serializable]
public readonly record struct NameUse : IStringEnum
{
    public static readonly NameUse Usual = new(Values.Usual);

    public static readonly NameUse Official = new(Values.Official);

    public static readonly NameUse Temp = new(Values.Temp);

    public static readonly NameUse Nickname = new(Values.Nickname);

    public static readonly NameUse Anonymous = new(Values.Anonymous);

    public static readonly NameUse Old = new(Values.Old);

    public static readonly NameUse Maiden = new(Values.Maiden);

    public NameUse(string value)
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
    public static NameUse FromCustom(string value)
    {
        return new NameUse(value);
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

    public static bool operator ==(NameUse value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(NameUse value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(NameUse value) => value.Value;

    public static explicit operator NameUse(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Usual = "USUAL";

        public const string Official = "OFFICIAL";

        public const string Temp = "TEMP";

        public const string Nickname = "NICKNAME";

        public const string Anonymous = "ANONYMOUS";

        public const string Old = "OLD";

        public const string Maiden = "MAIDEN";
    }
}
