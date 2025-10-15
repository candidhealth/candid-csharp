using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.OrganizationProviders.V2;

[JsonConverter(typeof(StringEnumSerializer<ProviderType>))]
[Serializable]
public readonly record struct ProviderType : IStringEnum
{
    public static readonly ProviderType Individual = new(Values.Individual);

    public static readonly ProviderType Organization = new(Values.Organization);

    public ProviderType(string value)
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
    public static ProviderType FromCustom(string value)
    {
        return new ProviderType(value);
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

    public static bool operator ==(ProviderType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ProviderType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ProviderType value) => value.Value;

    public static explicit operator ProviderType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Individual = "INDIVIDUAL";

        public const string Organization = "ORGANIZATION";
    }
}
