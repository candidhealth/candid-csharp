using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(StringEnumSerializer<AddressUse>))]
[Serializable]
public readonly record struct AddressUse : IStringEnum
{
    public static readonly AddressUse Home = new(Values.Home);

    public static readonly AddressUse Work = new(Values.Work);

    public static readonly AddressUse Temp = new(Values.Temp);

    public static readonly AddressUse Old = new(Values.Old);

    public static readonly AddressUse Billing = new(Values.Billing);

    public AddressUse(string value)
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
    public static AddressUse FromCustom(string value)
    {
        return new AddressUse(value);
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

    public static bool operator ==(AddressUse value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(AddressUse value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AddressUse value) => value.Value;

    public static explicit operator AddressUse(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Home = "HOME";

        public const string Work = "WORK";

        public const string Temp = "TEMP";

        public const string Old = "OLD";

        public const string Billing = "BILLING";
    }
}
