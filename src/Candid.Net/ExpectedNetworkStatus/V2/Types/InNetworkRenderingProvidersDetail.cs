using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record InNetworkRenderingProvidersDetail
{
    [JsonPropertyName("rendering_providers")]
    public IEnumerable<Guid> RenderingProviders { get; init; } = new List<Guid>();

    [JsonPropertyName("routed_payer_uuid")]
    public required Guid RoutedPayerUuid { get; init; }

    [JsonPropertyName("routed_billing_provider_id")]
    public required Guid RoutedBillingProviderId { get; init; }
}
