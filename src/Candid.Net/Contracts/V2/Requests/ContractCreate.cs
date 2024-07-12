using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record ContractCreate
{
    /// <summary>
    /// The UUID of the provider under agreement to the contract
    /// </summary>
    [JsonPropertyName("contracting_provider_id")]
    public required Guid ContractingProviderId { get; init; }

    /// <summary>
    /// A rendering provider isn't contracted directly with the payer but can render
    /// services under the contract held by the contracting provider.
    /// Max items is 100.
    ///
    /// </summary>
    [JsonPropertyName("rendering_provider_ids")]
    public HashSet<Guid> RenderingProviderIds { get; init; } = new HashSet<Guid>();

    /// <summary>
    /// The UUID of the insurance company under agreement to the contract
    /// </summary>
    [JsonPropertyName("payer_uuid")]
    public required Guid PayerUuid { get; init; }
}
