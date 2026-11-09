using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Contracts.V4;

[Serializable]
public record RemoveContractServiceFacilityProvidersRequest
{
    /// <summary>
    /// Provider IDs to remove from the contract service facility. Max 100,000 per request.
    /// </summary>
    [JsonPropertyName("provider_ids")]
    public HashSet<string> ProviderIds { get; set; } = new HashSet<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
