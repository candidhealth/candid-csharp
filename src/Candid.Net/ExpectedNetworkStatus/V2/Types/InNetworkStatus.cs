using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record InNetworkStatus
{
    [JsonPropertyName("routed_payer_uuid")]
    public required Guid RoutedPayerUuid { get; init; }

    [JsonPropertyName("routed_billing_provider_id")]
    public required Guid RoutedBillingProviderId { get; init; }
}
