using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Individual;

[JsonConverter(typeof(StringEnumSerializer<Gender>))]
[Serializable]
public readonly record struct Gender : IStringEnum
{
    public static readonly Gender Male = new(Values.Male);

    public static readonly Gender Female = new(Values.Female);

    public static readonly Gender Other = new(Values.Other);

    public static readonly Gender NotGiven = new(Values.NotGiven);

    public static readonly Gender Unknown = new(Values.Unknown);

    public Gender(string value)
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
    public static Gender FromCustom(string value)
    {
        return new Gender(value);
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

    public static bool operator ==(Gender value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(Gender value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(Gender value) => value.Value;

    public static explicit operator Gender(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Male = "male";

        public const string Female = "female";

        public const string Other = "other";

        public const string NotGiven = "not_given";

        public const string Unknown = "unknown";
    }
}
