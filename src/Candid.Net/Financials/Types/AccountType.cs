using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Financials;

[JsonConverter(typeof(StringEnumSerializer<AccountType>))]
[Serializable]
public readonly record struct AccountType : IStringEnum
{
    public static readonly AccountType Patient = new(Values.Patient);

    public static readonly AccountType Insurance = new(Values.Insurance);

    public static readonly AccountType ThirdPartyPayer = new(Values.ThirdPartyPayer);

    public AccountType(string value)
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
    public static AccountType FromCustom(string value)
    {
        return new AccountType(value);
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

    public static bool operator ==(AccountType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountType value) => value.Value;

    public static explicit operator AccountType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Patient = "PATIENT";

        public const string Insurance = "INSURANCE";

        public const string ThirdPartyPayer = "THIRD_PARTY_PAYER";
    }
}
