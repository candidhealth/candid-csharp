using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<PhoneNumberType>))]
[Serializable]
public readonly record struct PhoneNumberType : IStringEnum
{
    public static readonly PhoneNumberType Home = new(Values.Home);

    public static readonly PhoneNumberType Mobile = new(Values.Mobile);

    public static readonly PhoneNumberType Work = new(Values.Work);

    public PhoneNumberType(string value)
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
    public static PhoneNumberType FromCustom(string value)
    {
        return new PhoneNumberType(value);
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

    public static bool operator ==(PhoneNumberType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PhoneNumberType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PhoneNumberType value) => value.Value;

    public static explicit operator PhoneNumberType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Home = "Home";

        public const string Mobile = "Mobile";

        public const string Work = "Work";
    }
}
