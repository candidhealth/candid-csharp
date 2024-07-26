using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record InNetworkRenderingProvidersDetail
{
    [JsonPropertyName("rendering_providers")]
    public IEnumerable<string> RenderingProviders { get; init; } = new List<string>();

    [JsonPropertyName("routed_payer_uuid")]
    public required string RoutedPayerUuid { get; init; }

    [JsonPropertyName("routed_billing_provider_id")]
    public required string RoutedBillingProviderId { get; init; }
}
