using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<SynchronicityType>))]
[Serializable]
public readonly record struct SynchronicityType : IStringEnum
{
    public static readonly SynchronicityType Synchronous = new(Values.Synchronous);

    public static readonly SynchronicityType Asynchronous = new(Values.Asynchronous);

    public SynchronicityType(string value)
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
    public static SynchronicityType FromCustom(string value)
    {
        return new SynchronicityType(value);
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

    public static bool operator ==(SynchronicityType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SynchronicityType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SynchronicityType value) => value.Value;

    public static explicit operator SynchronicityType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Synchronous = "Synchronous";

        public const string Asynchronous = "Asynchronous";
    }
}
