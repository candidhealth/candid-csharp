using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<CodingAttributionType>))]
[Serializable]
public readonly record struct CodingAttributionType : IStringEnum
{
    public static readonly CodingAttributionType Candid = new(Values.Candid);

    public static readonly CodingAttributionType Customer = new(Values.Customer);

    public static readonly CodingAttributionType Tcn = new(Values.Tcn);

    public static readonly CodingAttributionType Pjf = new(Values.Pjf);

    public CodingAttributionType(string value)
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
    public static CodingAttributionType FromCustom(string value)
    {
        return new CodingAttributionType(value);
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

    public static bool operator ==(CodingAttributionType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CodingAttributionType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CodingAttributionType value) => value.Value;

    public static explicit operator CodingAttributionType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Candid = "CANDID";

        public const string Customer = "CUSTOMER";

        public const string Tcn = "TCN";

        public const string Pjf = "PJF";
    }
}
