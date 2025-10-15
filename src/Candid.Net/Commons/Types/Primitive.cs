using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<Primitive>))]
[Serializable]
public readonly record struct Primitive : IStringEnum
{
    public static readonly Primitive Boolean = new(Values.Boolean);

    public static readonly Primitive Double = new(Values.Double);

    public static readonly Primitive Integer = new(Values.Integer);

    public static readonly Primitive String = new(Values.String);

    public Primitive(string value)
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
    public static Primitive FromCustom(string value)
    {
        return new Primitive(value);
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

    public static bool operator ==(Primitive value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(Primitive value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(Primitive value) => value.Value;

    public static explicit operator Primitive(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Boolean = "BOOLEAN";

        public const string Double = "DOUBLE";

        public const string Integer = "INTEGER";

        public const string String = "STRING";
    }
}
