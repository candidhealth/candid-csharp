using System.Text.Json.Serialization;
using Candid.Net.ExpectedNetworkStatus.V2;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record OutOfNetworkStatus
{
    [JsonPropertyName("explanation")]
    public required Explanation Explanation { get; init; }

    [JsonPropertyName("routed_payer_uuid")]
    public required string RoutedPayerUuid { get; init; }

    [JsonPropertyName("routed_billing_provider_id")]
    public required string RoutedBillingProviderId { get; init; }
}
