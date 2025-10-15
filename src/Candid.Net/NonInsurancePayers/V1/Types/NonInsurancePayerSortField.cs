using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayers.V1;

[JsonConverter(typeof(StringEnumSerializer<NonInsurancePayerSortField>))]
[Serializable]
public readonly record struct NonInsurancePayerSortField : IStringEnum
{
    public static readonly NonInsurancePayerSortField Name = new(Values.Name);

    public static readonly NonInsurancePayerSortField Category = new(Values.Category);

    public static readonly NonInsurancePayerSortField Enabled = new(Values.Enabled);

    public static readonly NonInsurancePayerSortField UpdatedAt = new(Values.UpdatedAt);

    public NonInsurancePayerSortField(string value)
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
    public static NonInsurancePayerSortField FromCustom(string value)
    {
        return new NonInsurancePayerSortField(value);
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

    public static bool operator ==(NonInsurancePayerSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NonInsurancePayerSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NonInsurancePayerSortField value) => value.Value;

    public static explicit operator NonInsurancePayerSortField(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Name = "NAME";

        public const string Category = "CATEGORY";

        public const string Enabled = "ENABLED";

        public const string UpdatedAt = "UPDATED_AT";
    }
}
