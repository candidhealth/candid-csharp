using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<LabCodeType>))]
[Serializable]
public readonly record struct LabCodeType : IStringEnum
{
    public static readonly LabCodeType Quest = new(Values.Quest);

    public static readonly LabCodeType Labcorp = new(Values.Labcorp);

    public LabCodeType(string value)
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
    public static LabCodeType FromCustom(string value)
    {
        return new LabCodeType(value);
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

    public static bool operator ==(LabCodeType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LabCodeType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LabCodeType value) => value.Value;

    public static explicit operator LabCodeType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Quest = "quest";

        public const string Labcorp = "labcorp";
    }
}
