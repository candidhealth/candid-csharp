using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(StringEnumSerializer<ExternalProviderType>))]
[Serializable]
public readonly record struct ExternalProviderType : IStringEnum
{
    public static readonly ExternalProviderType Primary = new(Values.Primary);

    public static readonly ExternalProviderType Referring = new(Values.Referring);

    public static readonly ExternalProviderType Attending = new(Values.Attending);

    public ExternalProviderType(string value)
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
    public static ExternalProviderType FromCustom(string value)
    {
        return new ExternalProviderType(value);
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

    public static bool operator ==(ExternalProviderType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ExternalProviderType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ExternalProviderType value) => value.Value;

    public static explicit operator ExternalProviderType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Primary = "PRIMARY";

        public const string Referring = "REFERRING";

        public const string Attending = "ATTENDING";
    }
}
