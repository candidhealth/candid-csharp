using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

[JsonConverter(typeof(StringEnumSerializer<DimensionName>))]
[Serializable]
public readonly record struct DimensionName : IStringEnum
{
    public static readonly DimensionName PayerUuid = new(Values.PayerUuid);

    public static readonly DimensionName OrganizationBillingProviderId = new(
        Values.OrganizationBillingProviderId
    );

    public static readonly DimensionName CptCode = new(Values.CptCode);

    public DimensionName(string value)
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
    public static DimensionName FromCustom(string value)
    {
        return new DimensionName(value);
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

    public static bool operator ==(DimensionName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DimensionName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DimensionName value) => value.Value;

    public static explicit operator DimensionName(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string PayerUuid = "payer_uuid";

        public const string OrganizationBillingProviderId = "organization_billing_provider_id";

        public const string CptCode = "cpt_code";
    }
}
