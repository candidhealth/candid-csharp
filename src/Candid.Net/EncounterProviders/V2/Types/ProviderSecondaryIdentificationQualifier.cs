using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.EncounterProviders.V2;

[JsonConverter(typeof(StringEnumSerializer<ProviderSecondaryIdentificationQualifier>))]
[Serializable]
public readonly record struct ProviderSecondaryIdentificationQualifier : IStringEnum
{
    /// <summary>
    /// Provider Commercial Number
    /// </summary>
    public static readonly ProviderSecondaryIdentificationQualifier G2 = new(Values.G2);

    /// <summary>
    /// Location Number
    /// </summary>
    public static readonly ProviderSecondaryIdentificationQualifier Lu = new(Values.Lu);

    public ProviderSecondaryIdentificationQualifier(string value)
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
    public static ProviderSecondaryIdentificationQualifier FromCustom(string value)
    {
        return new ProviderSecondaryIdentificationQualifier(value);
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

    public static bool operator ==(
        ProviderSecondaryIdentificationQualifier value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ProviderSecondaryIdentificationQualifier value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ProviderSecondaryIdentificationQualifier value) =>
        value.Value;

    public static explicit operator ProviderSecondaryIdentificationQualifier(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Provider Commercial Number
        /// </summary>
        public const string G2 = "G2";

        /// <summary>
        /// Location Number
        /// </summary>
        public const string Lu = "LU";
    }
}
