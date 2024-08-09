using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record IndeterminateNetworkStatus
{
    [JsonPropertyName("error")]
    public required string Error { get; set; }

    [JsonPropertyName("explanation")]
    public required Explanation Explanation { get; set; }

    [JsonPropertyName("routed_payer_uuid")]
    public string? RoutedPayerUuid { get; set; }

    [JsonPropertyName("routed_billing_provider_id")]
    public string? RoutedBillingProviderId { get; set; }
}
