using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<QualifierCode>))]
[Serializable]
public readonly record struct QualifierCode : IStringEnum
{
    public static readonly QualifierCode Dq = new(Values.Dq);

    public static readonly QualifierCode Dn = new(Values.Dn);

    public static readonly QualifierCode Dk = new(Values.Dk);

    public static readonly QualifierCode P3 = new(Values.P3);

    public QualifierCode(string value)
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
    public static QualifierCode FromCustom(string value)
    {
        return new QualifierCode(value);
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

    public static bool operator ==(QualifierCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(QualifierCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(QualifierCode value) => value.Value;

    public static explicit operator QualifierCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Dq = "DQ";

        public const string Dn = "DN";

        public const string Dk = "DK";

        public const string P3 = "P3";
    }
}
