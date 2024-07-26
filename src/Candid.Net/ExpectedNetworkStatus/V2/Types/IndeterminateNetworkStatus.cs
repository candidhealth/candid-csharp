using System.Text.Json.Serialization;
using Candid.Net.ExpectedNetworkStatus.V2;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record IndeterminateNetworkStatus
{
    [JsonPropertyName("error")]
    public required string Error { get; init; }

    [JsonPropertyName("explanation")]
    public required Explanation Explanation { get; init; }

    [JsonPropertyName("routed_payer_uuid")]
    public string? RoutedPayerUuid { get; init; }

    [JsonPropertyName("routed_billing_provider_id")]
    public string? RoutedBillingProviderId { get; init; }
}
