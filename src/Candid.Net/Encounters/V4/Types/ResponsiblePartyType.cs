using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<ResponsiblePartyType>))]
[Serializable]
public readonly record struct ResponsiblePartyType : IStringEnum
{
    public static readonly ResponsiblePartyType InsurancePay = new(Values.InsurancePay);

    public static readonly ResponsiblePartyType SelfPay = new(Values.SelfPay);

    public static readonly ResponsiblePartyType Unknown = new(Values.Unknown);

    public ResponsiblePartyType(string value)
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
    public static ResponsiblePartyType FromCustom(string value)
    {
        return new ResponsiblePartyType(value);
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

    public static bool operator ==(ResponsiblePartyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ResponsiblePartyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ResponsiblePartyType value) => value.Value;

    public static explicit operator ResponsiblePartyType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string InsurancePay = "INSURANCE_PAY";

        public const string SelfPay = "SELF_PAY";

        public const string Unknown = "UNKNOWN";
    }
}
