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
    public Guid? RoutedPayerUuid { get; init; }

    [JsonPropertyName("routed_billing_provider_id")]
    public Guid? RoutedBillingProviderId { get; init; }
}
