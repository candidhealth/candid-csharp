using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Images.V1;

[JsonConverter(typeof(StringEnumSerializer<CoverageImageSide>))]
[Serializable]
public readonly record struct CoverageImageSide : IStringEnum
{
    public static readonly CoverageImageSide Front = new(Values.Front);

    public static readonly CoverageImageSide Back = new(Values.Back);

    public CoverageImageSide(string value)
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
    public static CoverageImageSide FromCustom(string value)
    {
        return new CoverageImageSide(value);
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

    public static bool operator ==(CoverageImageSide value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CoverageImageSide value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CoverageImageSide value) => value.Value;

    public static explicit operator CoverageImageSide(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Front = "FRONT";

        public const string Back = "BACK";
    }
}
