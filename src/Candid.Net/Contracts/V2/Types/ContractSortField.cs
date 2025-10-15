using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V2;

[JsonConverter(typeof(StringEnumSerializer<ContractSortField>))]
[Serializable]
public readonly record struct ContractSortField : IStringEnum
{
    public static readonly ContractSortField CreatedAt = new(Values.CreatedAt);

    public static readonly ContractSortField PayerName = new(Values.PayerName);

    public static readonly ContractSortField PayerId = new(Values.PayerId);

    public static readonly ContractSortField BillingProviderName = new(Values.BillingProviderName);

    public static readonly ContractSortField EffectiveDate = new(Values.EffectiveDate);

    public static readonly ContractSortField ContractStatus = new(Values.ContractStatus);

    public ContractSortField(string value)
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
    public static ContractSortField FromCustom(string value)
    {
        return new ContractSortField(value);
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

    public static bool operator ==(ContractSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractSortField value) => value.Value;

    public static explicit operator ContractSortField(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string CreatedAt = "created_at";

        public const string PayerName = "payer_name";

        public const string PayerId = "payer_id";

        public const string BillingProviderName = "billing_provider_name";

        public const string EffectiveDate = "effective_date";

        public const string ContractStatus = "contract_status";
    }
}
