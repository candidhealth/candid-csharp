using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.OrganizationProviders.V2;

[JsonConverter(typeof(StringEnumSerializer<AddressType>))]
[Serializable]
public readonly record struct AddressType : IStringEnum
{
    public static readonly AddressType Default = new(Values.Default);

    public AddressType(string value)
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
    public static AddressType FromCustom(string value)
    {
        return new AddressType(value);
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

    public static bool operator ==(AddressType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AddressType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AddressType value) => value.Value;

    public static explicit operator AddressType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Default = "DEFAULT";
    }
}
