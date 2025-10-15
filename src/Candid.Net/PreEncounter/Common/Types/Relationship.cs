using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(StringEnumSerializer<Relationship>))]
[Serializable]
public readonly record struct Relationship : IStringEnum
{
    public static readonly Relationship Self = new(Values.Self);

    public static readonly Relationship Spouse = new(Values.Spouse);

    public static readonly Relationship Child = new(Values.Child);

    public static readonly Relationship CommonLawSpouse = new(Values.CommonLawSpouse);

    public static readonly Relationship Other = new(Values.Other);

    public Relationship(string value)
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
    public static Relationship FromCustom(string value)
    {
        return new Relationship(value);
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

    public static bool operator ==(Relationship value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(Relationship value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(Relationship value) => value.Value;

    public static explicit operator Relationship(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Self = "SELF";

        public const string Spouse = "SPOUSE";

        public const string Child = "CHILD";

        public const string CommonLawSpouse = "COMMON_LAW_SPOUSE";

        public const string Other = "OTHER";
    }
}
