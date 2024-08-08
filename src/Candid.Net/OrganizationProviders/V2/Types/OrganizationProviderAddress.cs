using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.OrganizationProviders.V2;

public record OrganizationProviderAddress
{
    /// <summary>
    /// The address of the provider
    /// </summary>
    [JsonPropertyName("address")]
    public required StreetAddressLongZip Address { get; set; }

    /// <summary>
    /// The address type of the provider
    /// </summary>
    [JsonPropertyName("address_type")]
    public required AddressType AddressType { get; set; }
}
