using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ChargeCapture.V1;

[JsonConverter(typeof(StringEnumSerializer<Hl7MessageType>))]
[Serializable]
public readonly record struct Hl7MessageType : IStringEnum
{
    public static readonly Hl7MessageType Bar = new(Values.Bar);

    public static readonly Hl7MessageType Dft = new(Values.Dft);

    public static readonly Hl7MessageType Adt = new(Values.Adt);

    public Hl7MessageType(string value)
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
    public static Hl7MessageType FromCustom(string value)
    {
        return new Hl7MessageType(value);
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

    public static bool operator ==(Hl7MessageType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(Hl7MessageType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(Hl7MessageType value) => value.Value;

    public static explicit operator Hl7MessageType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Bar = "BAR";

        public const string Dft = "DFT";

        public const string Adt = "ADT";
    }
}
