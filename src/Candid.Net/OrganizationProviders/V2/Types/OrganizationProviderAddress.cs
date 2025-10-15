using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.OrganizationProviders.V2;

[Serializable]
public record OrganizationProviderAddress : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
