using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record ContractWithProviders
{
    /// <summary>
    /// The providers who can render medical services under the contract
    /// </summary>
    [JsonPropertyName("rendering_provider_ids")]
    public HashSet<string> RenderingProviderIds { get; set; } = new HashSet<string>();
}
