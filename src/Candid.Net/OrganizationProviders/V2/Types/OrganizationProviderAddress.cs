using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
