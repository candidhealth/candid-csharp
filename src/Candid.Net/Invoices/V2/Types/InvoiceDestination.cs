using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Invoices.V2;

[JsonConverter(typeof(StringEnumSerializer<InvoiceDestination>))]
[Serializable]
public readonly record struct InvoiceDestination : IStringEnum
{
    public static readonly InvoiceDestination Stripe = new(Values.Stripe);

    public static readonly InvoiceDestination Cedar = new(Values.Cedar);

    public static readonly InvoiceDestination Healthie = new(Values.Healthie);

    public static readonly InvoiceDestination Collectly = new(Values.Collectly);

    public static readonly InvoiceDestination ThirdPartyPayers = new(Values.ThirdPartyPayers);

    public InvoiceDestination(string value)
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
    public static InvoiceDestination FromCustom(string value)
    {
        return new InvoiceDestination(value);
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

    public static bool operator ==(InvoiceDestination value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoiceDestination value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceDestination value) => value.Value;

    public static explicit operator InvoiceDestination(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Stripe = "STRIPE";

        public const string Cedar = "CEDAR";

        public const string Healthie = "HEALTHIE";

        public const string Collectly = "COLLECTLY";

        public const string ThirdPartyPayers = "THIRD_PARTY_PAYERS";
    }
}
