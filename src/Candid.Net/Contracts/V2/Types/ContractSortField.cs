using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Contracts.V2;

[JsonConverter(typeof(ContractSortField.ContractSortFieldSerializer))]
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

    internal class ContractSortFieldSerializer : JsonConverter<ContractSortField>
    {
        public override ContractSortField Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new ContractSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractSortField ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new ContractSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

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
