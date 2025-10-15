using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<NextResponsibleParty>))]
[Serializable]
public readonly record struct NextResponsibleParty : IStringEnum
{
    public static readonly NextResponsibleParty Primary = new(Values.Primary);

    public static readonly NextResponsibleParty Secondary = new(Values.Secondary);

    public static readonly NextResponsibleParty Tertiary = new(Values.Tertiary);

    public static readonly NextResponsibleParty Patient = new(Values.Patient);

    public static readonly NextResponsibleParty NonInsurance = new(Values.NonInsurance);

    public static readonly NextResponsibleParty None = new(Values.None);

    public NextResponsibleParty(string value)
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
    public static NextResponsibleParty FromCustom(string value)
    {
        return new NextResponsibleParty(value);
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

    public static bool operator ==(NextResponsibleParty value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NextResponsibleParty value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NextResponsibleParty value) => value.Value;

    public static explicit operator NextResponsibleParty(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Primary = "primary";

        public const string Secondary = "secondary";

        public const string Tertiary = "tertiary";

        public const string Patient = "patient";

        public const string NonInsurance = "non_insurance";

        public const string None = "none";
    }
}
