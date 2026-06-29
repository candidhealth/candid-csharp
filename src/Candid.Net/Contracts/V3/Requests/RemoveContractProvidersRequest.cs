using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Contracts.V3;

[Serializable]
public record RemoveContractProvidersRequest
{
    /// <summary>
    /// Provider IDs to remove from the contract. Max 100,000 per request.
    /// </summary>
    [JsonPropertyName("rendering_provider_ids")]
    public HashSet<string> RenderingProviderIds { get; set; } = new HashSet<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
