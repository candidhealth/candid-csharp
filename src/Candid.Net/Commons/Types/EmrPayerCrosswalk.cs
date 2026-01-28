using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<EmrPayerCrosswalk>))]
[Serializable]
public readonly record struct EmrPayerCrosswalk : IStringEnum
{
    public static readonly EmrPayerCrosswalk Healthie = new(Values.Healthie);

    public static readonly EmrPayerCrosswalk Canvas = new(Values.Canvas);

    public static readonly EmrPayerCrosswalk Hl7WebptE34Epic = new(Values.Hl7WebptE34Epic);

    public EmrPayerCrosswalk(string value)
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
    public static EmrPayerCrosswalk FromCustom(string value)
    {
        return new EmrPayerCrosswalk(value);
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

    public static bool operator ==(EmrPayerCrosswalk value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmrPayerCrosswalk value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmrPayerCrosswalk value) => value.Value;

    public static explicit operator EmrPayerCrosswalk(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Healthie = "HEALTHIE";

        public const string Canvas = "CANVAS";

        public const string Hl7WebptE34Epic = "HL7_WEBPT_E34_EPIC";
    }
}
