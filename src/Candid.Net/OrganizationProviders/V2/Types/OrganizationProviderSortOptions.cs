using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.OrganizationProviders.V2;

[JsonConverter(typeof(StringEnumSerializer<OrganizationProviderSortOptions>))]
[Serializable]
public readonly record struct OrganizationProviderSortOptions : IStringEnum
{
    public static readonly OrganizationProviderSortOptions ProviderNameAsc = new(
        Values.ProviderNameAsc
    );

    public static readonly OrganizationProviderSortOptions ProviderNameDesc = new(
        Values.ProviderNameDesc
    );

    public static readonly OrganizationProviderSortOptions NpiAsc = new(Values.NpiAsc);

    public static readonly OrganizationProviderSortOptions NpiDesc = new(Values.NpiDesc);

    public OrganizationProviderSortOptions(string value)
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
    public static OrganizationProviderSortOptions FromCustom(string value)
    {
        return new OrganizationProviderSortOptions(value);
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

    public static bool operator ==(OrganizationProviderSortOptions value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrganizationProviderSortOptions value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrganizationProviderSortOptions value) => value.Value;

    public static explicit operator OrganizationProviderSortOptions(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ProviderNameAsc = "provider_name:asc";

        public const string ProviderNameDesc = "provider_name:desc";

        public const string NpiAsc = "npi:asc";

        public const string NpiDesc = "npi:desc";
    }
}
