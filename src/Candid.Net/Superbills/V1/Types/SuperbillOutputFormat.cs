using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Superbills.V1;

[JsonConverter(typeof(StringEnumSerializer<SuperbillOutputFormat>))]
[Serializable]
public readonly record struct SuperbillOutputFormat : IStringEnum
{
    public static readonly SuperbillOutputFormat Docx = new(Values.Docx);

    public static readonly SuperbillOutputFormat Pdf = new(Values.Pdf);

    public SuperbillOutputFormat(string value)
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
    public static SuperbillOutputFormat FromCustom(string value)
    {
        return new SuperbillOutputFormat(value);
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

    public static bool operator ==(SuperbillOutputFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SuperbillOutputFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SuperbillOutputFormat value) => value.Value;

    public static explicit operator SuperbillOutputFormat(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Docx = "DOCX";

        public const string Pdf = "PDF";
    }
}
